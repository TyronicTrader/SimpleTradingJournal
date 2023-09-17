using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingJournal
{
    internal class DBCon
    {
        public SQLiteConnection Conn;
        public string dbfileName = "./TheDatabase.sqlite3";
        public string dbschemaFile = "../../SQLiteSchema.sql";

        public string connectionstring { get; set; }

        string connection;

        public void getconnection()
        {
            connection = $"Data Source={dbfileName};Version=3;Compress=True;FailIfMissing=True;UTF16Encoding=True;UseUTF16Encoding=True;Synchronous=OFF;Journal Mode=WAL;";
            connectionstring = connection;
            System.Console.WriteLine(connectionstring);
        }

        public DBCon()
        {
            getconnection();
            Conn = new SQLiteConnection(connectionstring);
            if (!File.Exists($"{dbfileName}"))
            {
                if (!File.Exists($"{dbschemaFile}"))
                {
                    MessageBox.Show("Schema File Missing.");
                    //System.Windows.Forms.Application.Exit();
                    System.Environment.Exit(1);
                    //System.Windows.Forms.Application.ExitThread();
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
