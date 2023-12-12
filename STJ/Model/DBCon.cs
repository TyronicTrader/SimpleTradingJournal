using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;

namespace STJ.Model
{
    internal class DBCon
    {
        public SQLiteConnection Conn;
        public string dbfileName = "./TheDatabase.sqlite3";
        public string dbschemaFile = "../../Resources/SQLiteSchema.sql";

        public string Connectionstring { get; set; }

        string connection;

        public void Getconnection()
        {
            connection = $"Data Source={dbfileName};Version=3;Compress=True;FailIfMissing=True;Synchronous=OFF;Journal Mode=WAL;";
            Connectionstring = connection;
            //System.Console.WriteLine(connectionstring);
        }

        public DBCon()
        {
            Getconnection();
            Conn = new SQLiteConnection(Connectionstring);
            if (!File.Exists($"{dbfileName}"))
            {
                if (!File.Exists($"{dbschemaFile}"))
                {
                    MessageBox.Show("Schema File Missing.");
                    System.Environment.Exit(1);
                }
                else
                {
                    SQLiteConnection.CreateFile($"{dbfileName}");
                    ApplySchema();
                    SchemaUpdate();
                }
            }
            else
            {
                SchemaUpdate();
                string version = Conn.ServerVersion;
                System.Console.WriteLine($"DB ALREADY EXISTING SQLite Version: {version} DATABASE FILE AND WILL USE IT");
            }
        }

        public void ConnOpen()
        {
            if (Conn.State != System.Data.ConnectionState.Open)
                Conn.Open();
        }

        public void ConnClose()
        {
            if (Conn.State != System.Data.ConnectionState.Closed)
                Conn.Close();
        }

        public void ApplySchema()
        {
            if (!File.Exists($"{dbschemaFile}"))
            {
                MessageBox.Show("Schema File Missing.");
            }
            else
            {
                ConnOpen();
                string dbschema = File.ReadAllText($"{dbschemaFile}");
                var schemaInit = Conn.CreateCommand();
                schemaInit.CommandText = dbschema;
                schemaInit.ExecuteNonQuery();
                ConnClose();
            }
            //System.Console.WriteLine(dbschema);
            string version = Conn.ServerVersion;
            System.Console.WriteLine($"JUST CREATED A SQLite Version: {version} DATABASE FOR YOU");
        }

        private void SchemaUpdate()
        {
            ConnOpen();
            string dbschemaUpdate = @"CREATE TRIGGER IF NOT EXISTS cleanupEmptyNotes AFTER UPDATE on NOTES BEGIN DELETE from NOTES where Not_NAME = 'Blank Record' AND Not_NOTES = 'Blank Record'; END";
            var schemaInit = Conn.CreateCommand();
            schemaInit.CommandText = dbschemaUpdate;
            schemaInit.ExecuteNonQuery();
            ConnClose();

        }
    }
}
