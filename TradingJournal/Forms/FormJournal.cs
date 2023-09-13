using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingJournal.Forms
{
    public partial class FormJournal : Form
    {
        DBCon dbCon = new DBCon();
        SQLiteCommand cmd;
        SQLiteDataAdapter sda;
        SQLiteCommandBuilder scb;
        DataSet ds = new DataSet();
        string activeUsr = "1";
        string startDate = DateTime.Now.ToString("d");
        string endDate = DateTime.Now.ToString("d");
        public int activeRecordID = 0;
        private CheckBox currentCheckbox;
        private CheckBox oldCheckbox;
        string strDefaultTextboxMessage = "HINTS:\r\n<-- If you want to create a Template you can chose New Record and the Type called Template and it will add a template to the above template menu\r\n<-- Change color theme by clicking on the Journal icon in the left column  Keep pressing until you find a color scheme you prefer\r\n-->  After you have Loaded or Pasted an Image to your Record/Note then give it a name and Click \"Add Image to Record\" to include it into the active Record/Note\r\n<-- Tags allow you to add HashTags to your Record/Note for reference and will be used in future updates for reporting and searching\r\n<--The Monthly Calendar will allow you to highlight multiple dates to fill the tree below it with records from those selected dates\r\n";
        string strDefaultTagsExamples = "EXAMPLES:\r\n FOMC\r\n CPI\r\n GDP\r\n nonFarmPayroll";
        string strDefaultInstrumentExample = "EUR/USD or BTC";
        string strDefaultImageName = "Image Name here";
        string strDefaultType = "Record Type here";
        string strDefaultRecordName = "Record Name here";

        public int ActiveRecordID
        {
            get { return activeRecordID; }
            set
            {
                activeRecordID = value;
                lblCurRec.Text = activeRecordID.ToString();
            }
        }


        public FormJournal()
        {
            InitializeComponent();
            pictureBox.Image = pictureBox.InitialImage;
            lblCurRec.BorderStyle = BorderStyle.None;  
        }


        private void FormJournal_Load(object sender, EventArgs e)
        {
            LoadTheme();
            FillGrid();
            FillCombo();
            HighlightMonthCalendar();
            FillTreeView(startDate, endDate);
            ActivateFields(false);
        }


        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    btn.FlatStyle = FlatStyle.Flat;
                }
                //Labels
                if (btns.GetType() == typeof(Label))
                {
                    Label btn = (Label)btns;
                    btn.ForeColor = ThemeColor.SecondaryColor;
                }
                lblBackground.BackColor = ThemeColor.SecondaryColor;
                lblHealth.BackColor = ThemeColor.SecondaryColor;
                lblHealth.ForeColor = Color.White;
                lblHTF.BackColor = ThemeColor.SecondaryColor;
                lblHTF.ForeColor = Color.White;
                ////Treeview
                treeViewNotes.BackColor = ThemeColor.SecondaryColor;
                treeViewNotes.ForeColor = Color.White;
                //ToolStrip
                toolStriplblTemplate.ForeColor = Color.White;
                toolStrip1.BackColor = ThemeColor.SecondaryColor;
                //Checkboxes
                if (btns.GetType() == typeof(CheckBox))
                {
                    CheckBox btn = (CheckBox)btns;
                    btn.BackColor = ThemeColor.SecondaryColor;
                }

            }
        }



        #region THE WORK



        private void HighlightMonthCalendar()
        {
            string boldDatesQuery = "select Not_DATETIME from NOTES";
            sda = new SQLiteDataAdapter(boldDatesQuery, dbCon.Conn);
            sda.Fill(ds, "boldDates");
            try
            {
                foreach (DataRow dr in ds.Tables["boldDates"].Rows)
                {
                    monthCalendar.AddBoldedDate(DateTime.Parse(dr["Not_DATETIME"].ToString()));
                    monthCalendar.UpdateBoldedDates();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ds.Tables.Remove("boldDates");
        }


        private void FillTreeView(string startDate, string endDate)
        {
            treeViewNotes.Nodes.Clear();
            string treequery = $"Select Not_ID, Not_NAME, Not_DATETIME, Ntp_NAME from NOTES, NOTETYPES where Not_DATETIME >= '{startDate}' " +
                $"AND Not_DATETIME <= '{endDate}' AND Ntp_ID = Not_Ntp_ID ORDER BY Not_DATETIME, Ntp_NAME";
            sda = new SQLiteDataAdapter(treequery, dbCon.Conn);
            sda.Fill(ds, "Filltree");
            try
            {
                treeViewNotes.BeginUpdate();
                foreach (DataRow dr in ds.Tables["Filltree"].Rows)
                {
                    //TreeNode topNode = new TreeNode( dr["Not_DATETIME"].ToString(), dr["Not_DATETIME"].ToString());
                    TreeNode topNode = treeViewNotes.Nodes.Add(dr["Not_ID"].ToString(), dr["Not_DATETIME"].ToString());
                    //node = new TreeNode( dr["Ntp_NAME"].ToString());
                    TreeNode subNode = topNode.Nodes.Add(dr["Not_ID"].ToString(), dr["Ntp_NAME"].ToString());
                    //TreeNode node2 = new TreeNode(dr["Not_NAME"].ToString());
                    TreeNode subsubNode = subNode.Nodes.Add(dr["Not_ID"].ToString(), dr["Not_NAME"].ToString());
                    //Console.WriteLine("I have found the record here " + treeViewNotes.Nodes.Find("Record22", true).ToString());
                    Console.WriteLine(topNode.Text.ToString() + " - " + subNode.Text.ToString() + " " + subsubNode.Text.ToString());
                }
                treeViewNotes.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ds.Tables.Remove("Filltree");
            treeViewNotes.ExpandAll();
            treeViewNotes.Update();
        }


        private void treeViewNotes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            #region excluded Interesting Console data
            /*
            treeView1.PathSeparator = ".";
            int myNodeCount = treeView1.SelectedNode.GetNodeCount(true);
            decimal myChildPercentage = ((decimal)myNodeCount /
              (decimal)treeView1.GetNodeCount(true)) * 100;
            Console.WriteLine("this is the Name " + treeView1.SelectedNode.Name);
            Console.WriteLine("this is the Text " + treeView1.SelectedNode.Text);
            Console.WriteLine("this is the Tag " + treeView1.SelectedNode.Tag);
            Console.WriteLine("You selected " + treeView1.Nodes.Find(treeView1.SelectedNode.Name, true).ToString());
            Console.WriteLine("The '" + treeView1.SelectedNode.FullPath + "' node has "
                + myNodeCount.ToString() + " child nodes.\nThat is "
                + string.Format("{0:###.##}", myChildPercentage)
                + "% of the total tree nodes in the tree view control.");
            if (e.Node.Parent != null &&
                e.Node.Parent.GetType() == typeof(TreeNode))
            {
                Console.WriteLine( "Parent: " + e.Node.Parent.Text + "\n"
                   + "Index Position: " + e.Node.Parent.Index.ToString());
            }
            else
            {
                Console.WriteLine("No parent node.");
            }
            */
            #endregion


            ActiveRecordID = Convert.ToInt32(treeViewNotes.SelectedNode.Name);
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(CheckBox))
                {
                    CheckBox btn = (CheckBox)btns;
                    btn.Checked = false;
                }
            }
            string selectedRecord = $"Select * from NOTES, NOTETYPES where Not_ID = {activeRecordID} AND Not_Ntp_ID = Ntp_ID";
            sda = new SQLiteDataAdapter(selectedRecord, dbCon.Conn);
            sda.Fill(ds, "SelectedTreeRecord");
            foreach (DataRow dr in ds.Tables["SelectedTreeRecord"].Rows)
            {
                richTextBox1.Text = dr["Not_NOTES"].ToString();
                cmbType.Text = dr["Ntp_NAME"].ToString();
                txtNameRec.Text = dr["Not_NAME"].ToString();
                if (dr["Not_BODY"].ToString() == "1") { chbBodyYes.Checked = true; }
                if (dr["Not_BODY"].ToString() == "2") { chbBodyNo.Checked = true; }
                if (dr["Not_MIND"].ToString() == "1") { chbMindYes.Checked = true; }
                if (dr["Not_MIND"].ToString() == "2") { chbMindNo.Checked = true; }
                if (dr["Not_EMOTION"].ToString() == "1") { chbEmotionsYes.Checked = true; }
                if (dr["Not_EMOTION"].ToString() == "2") { chbEmotionsNo.Checked = true; }
                if (dr["Not_MONTHLY"].ToString() == "1") { chbMonthlyUp.Checked = true; }
                if (dr["Not_MONTHLY"].ToString() == "2") { chbMonthlyDown.Checked = true; }
                if (dr["Not_WEEKLY"].ToString() == "1") { chbWeeklyUp.Checked = true; }
                if (dr["Not_WEEKLY"].ToString() == "2") { chbWeeklyDown.Checked = true; }
                if (dr["Not_DAILY"].ToString() == "1") { chbDailyUp.Checked = true; }
                if (dr["Not_DAILY"].ToString() == "2") { chbDailyDown.Checked = true; }
                txtInstrument.Text = dr["Not_INSTRUMENT"].ToString();
                txtPnL.Text = dr["Not_PNL"].ToString();
                txtTags.Text = dr["Not_HASHTAG"].ToString();
            }
            FillGrid();
            txtNameImg.Text = null;
            pictureBox.Image = null;
            //pictureBox2.Image = null;
            ActivateFields(true); 
            LoadFirstRecImage();

        }


        private void FillCombo()
        {
            toolStripCmbTemplate.Items.Clear();
            cmbType.Items.Clear();
            string templatequery = "Select Not_NAME from NOTES where Not_Ntp_ID = (select Ntp_ID from NOTETYPES where Ntp_NAME = 'Template')";
            sda = new SQLiteDataAdapter(templatequery, dbCon.Conn);
            sda.Fill(ds, "NoteTemplates");
            string recordtypequery = "Select Ntp_NAME from NOTETYPES";
            sda = new SQLiteDataAdapter(recordtypequery, dbCon.Conn);
            sda.Fill(ds, "NoteTypes");
            try
            {
                foreach (DataRow dr in ds.Tables["NoteTemplates"].Rows)
                {
                    toolStripCmbTemplate.Items.Add(dr["Not_NAME"].ToString());
                }
                foreach (DataRow dr in ds.Tables["NoteTypes"].Rows)
                {
                    cmbType.Items.Add(dr["Ntp_NAME"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ds.Tables.Remove("NoteTemplates");
            ds.Tables.Remove("NoteTypes");
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;
            int prevcolumn = columnindex - 1;
            int picinfo = prevcolumn - 1;
            txtNameImg.Text = (string)dataGridView1.Rows[rowindex].Cells[picinfo].Value;
            byte[] img = (byte[])dataGridView1.Rows[rowindex].Cells[prevcolumn].Value;
            //byte[] imgT = (byte[])dataGridView1.Rows[rowindex].Cells[columnindex].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox.Image = Image.FromStream(ms);
            ms.Close();
            //Display Thumbnail
            //MemoryStream ms2 = new MemoryStream(imgT);
            //pictureBox2.Image = Image.FromStream(ms2);
            //ms2.Close();
            //Console.WriteLine( rowindex + "  " + columnindex + "  " + prevcolumn +"  " + picinfo);

        }


        private void FillGrid()
        {
            try
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowTemplate.Height = 90;
                dataGridView1.AllowUserToResizeRows = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.RowHeadersWidth = 4;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.ColumnHeadersHeight = 4;
                dataGridView1.ColumnHeadersVisible = false;
                dataGridView1.AllowUserToResizeColumns = false;
                //Using command builder here to also use in the delete process 
                string insertMediaQuery = $"SELECT * FROM NOTEMEDIA WHERE Nmd_Not_ID = {ActiveRecordID}";
                sda = new SQLiteDataAdapter(insertMediaQuery, dbCon.Conn);
                ds = new DataSet();
                scb = new SQLiteCommandBuilder(sda);
                scb.DataAdapter = sda;
                sda.Fill(ds, "Nmd_THUMB");
                dataGridView1.DataSource = ds.Tables["Nmd_THUMB"];
                //Only want the Thumbnail immage to show up
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = true;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadFirstRecImage()
        {
            if (dataGridView1.RowCount > 0)
            {
                try
                {
                    txtNameImg.Clear();
                    txtNameImg.Text = (string)dataGridView1.Rows[0].Cells[1].Value;
                    Console.WriteLine(txtNameImg.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    byte[] img = (byte[])dataGridView1.Rows[0].Cells[2].Value;
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox.Image = Image.FromStream(ms);
                    ms.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Picbox2db()
        {
            // write image to database
            try
            {
                if (pictureBox.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] img = ms.ToArray();
                    ms.Close();
                    Bitmap image = (Bitmap)pictureBox.Image.GetThumbnailImage(160, 90, new Image.GetThumbnailImageAbort(() => false), new IntPtr());

                    MemoryStream ms2 = new MemoryStream();
                    image.Save(ms2, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] thumb = ms2.ToArray();
                    ms2.Close();

                    if (ActiveRecordID != 0)
                    {
                        if (txtNameImg.Text != "")
                        {
                            string description = txtNameImg.Text;
                            string thedatetime = DateTime.Now.ToString("u");
                            //string insertQuery = "INSERT INTO NOTEMEDIA('Nmd_ID', 'Nmd_DESCRIPTION', 'Nmd_MEDIA', 'Nmd_NOTEID', 'Nmd_THUMB', 'Nmd_DATETIME') VALUES (@id, @description, @img, '@nid', @thumb, @thedatetime)";
                            string insertQuery = "INSERT INTO NOTEMEDIA('Nmd_DESCRIPTION', 'Nmd_MEDIA', 'Nmd_THUMB', 'Nmd_Not_ID', 'Nmd_DATETIME') VALUES (@description, @img, @thumb, @nid, @thedatetime)";
                            cmd = new SQLiteCommand(insertQuery, dbCon.Conn);
                            dbCon.ConnOpen();
                            cmd.Parameters.AddWithValue("@description", description);
                            cmd.Parameters.AddWithValue("@img", img);
                            cmd.Parameters.AddWithValue("@thumb", thumb);
                            cmd.Parameters.AddWithValue("@nid", ActiveRecordID);
                            cmd.Parameters.AddWithValue("@thedatetime", thedatetime);
                            cmd.ExecuteNonQuery();
                            dbCon.ConnClose();

                        }
                        else
                        {
                            MessageBox.Show("You need to have a name for this image.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("You need to have an active record open.");
                        pictureBox.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("No Image to save.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            startDate = monthCalendar.SelectionStart.ToString("d");
            endDate = monthCalendar.SelectionEnd.ToString("d");
            FillTreeView(startDate, endDate);
            dateTimePicker1.Value = monthCalendar.SelectionStart;

            //Update the fields 
            ActiveRecordID = 0;
            ResetFields();
            ActivateFields(false);
        }


        private void CreateTheRecord()
        {
            ActivateFields(true);
            //clear all the fields for a new record
            //dateTimePicker1.Text = string.Empty ;
            cmbType.Text = string.Empty;
            richTextBox1.Text = string.Empty;
            txtNameRec.Clear();
            txtNameImg.Clear();
            pictureBox.Image = null;
            txtInstrument.Text = string.Empty;
            txtPnL.Text = string.Empty;
            txtTags.Clear();
            //pictureBox2.Image = null;

            //create a new database record
            string thedatetime = dateTimePicker1.Value.ToString("d");
            string insertQuery = "INSERT INTO NOTES('Not_NAME', 'Not_NOTES', 'Not_DATETIME', 'Not_Usr_ID', 'Not_Ntp_ID') VALUES (@name, @note, @thedatetime, @notusrid, (select Ntp_ID from NOTETYPES where Ntp_NAME = @nottypid))";
            cmd = new SQLiteCommand(insertQuery, dbCon.Conn);
            dbCon.ConnOpen();
            cmd.Parameters.AddWithValue("@name", "Blank Record");
            cmd.Parameters.AddWithValue("@note", "Blank Record");
            cmd.Parameters.AddWithValue("@thedatetime", thedatetime);
            cmd.Parameters.AddWithValue("@notusrid", activeUsr);
            cmd.Parameters.AddWithValue("@nottypid", "Other");
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbCon.ConnClose();

            //update the Active Record with the most new database record that was created
            string getMostCurrentRec = "Select Not_ID from NOTES ORDER BY Not_ID DESC LIMIT 1";
            try
            {
                sda = new SQLiteDataAdapter(getMostCurrentRec, dbCon.Conn);
                sda.Fill(ds, "CurrentRec");
                foreach (DataRow dr in ds.Tables["CurrentRec"].Rows)
                {
                    ActiveRecordID = Convert.ToInt32(dr["Not_ID"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Update the fields 
            //monthCalendar.AddBoldedDate(DateTime.Parse(thedatetime.ToString()));
            //monthCalendar.UpdateBoldedDates();
            //FillCombo();
            //FillGrid();
            //FillTreeView(startDate, endDate);
            ResetFields();
        }


        private void SaveTheRecord()
        {

            if (ActiveRecordID != 0)
            {
                int intBody = 0;
                if (chbBodyYes.Checked) { intBody = 1; }
                if (chbBodyNo.Checked) { intBody = 2; }
	            int intMind = 0;
                if (chbMindYes.Checked) { intMind = 1; }
                if (chbMindNo.Checked) { intMind = 2; }
	            int intEmotion = 0;
                if(chbEmotionsYes.Checked) { intEmotion = 1; }
                if (chbEmotionsNo.Checked) { intEmotion = 2; }
	            int intMonthly = 0;
                if(chbMonthlyUp.Checked) { intMonthly = 1; }
                if (chbMonthlyDown.Checked) { intMonthly = 2; }
	            int intWeekly = 0;
                if (chbWeeklyUp.Checked) { intWeekly = 1; }
                if (chbWeeklyDown.Checked) { intWeekly = 2; }
	            int intDaily = 0;
                if (chbDailyUp.Checked) { intDaily = 1; }
                if (chbDailyDown.Checked) { intDaily = 2; }
	            string strInstrument;
                strInstrument = txtInstrument.Text;
                if (txtPnL.Text.Length == 0 || txtPnL.Text == " ") { txtPnL.Text = "0"; }
                decimal decPnL;
                if( Decimal.TryParse(txtPnL.Text, out decPnL)) { } 
                else { MessageBox.Show("Only Numbers with decimal point allowed for PnL " + decPnL.ToString()); }
                string strHashtag;
                strHashtag = txtTags.Text;

                string recordName = txtNameRec.Text;
                recordName = recordName.Replace("'", "''");
                string myrichText = richTextBox1.Text;
                myrichText = myrichText.Replace("'", "''");
                string thedatetime = dateTimePicker1.Value.ToString("d");
                string insertQuery = $"UPDATE NOTES SET Not_NAME ='{recordName}', Not_NOTES='{myrichText}', Not_DATETIME='{thedatetime}', " +
                    $"Not_Usr_ID='{activeUsr}', Not_BODY='{intBody}', Not_MIND='{intMind}', Not_EMOTION='{intEmotion}', " +
                    $"Not_MONTHLY='{intMonthly}', Not_WEEKLY='{intWeekly}', Not_DAILY='{intDaily}', " +
                    $"Not_INSTRUMENT='{strInstrument}', Not_PNL='{decPnL}', Not_HASHTAG='{strHashtag}', " +
                    $"Not_Ntp_ID=(select Ntp_ID from NOTETYPES where Ntp_NAME = '{cmbType.Text}') WHERE Not_ID = '{activeRecordID}'";
                //string insertQuery = "INSERT INTO NOTES('Not_NAME', 'Not_NOTES', 'Not_DATETIME', 'Not_Usr_ID', 'Not_Ntp_ID') VALUES (@name, @note, @thedatetime, @notusrid, (select Ntp_ID from NOTETYPES where Ntp_NAME = @nottypid))";
                cmd = new SQLiteCommand(insertQuery, dbCon.Conn);
                dbCon.ConnOpen();
                if (cmbType.Text != "")
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Make sure you have selected a Record Type");
                }
                dbCon.ConnClose();
                //fillTreeView(startDate, endDate);
                monthCalendar.AddBoldedDate(DateTime.Parse(thedatetime.ToString()));
                monthCalendar.UpdateBoldedDates();
                FillCombo();
                FillTreeView(startDate, endDate);
            }
            else
            {
                MessageBox.Show("You need to have an active record open.");
            }
            MessageBox.Show("Record has been saved.");
        }


        private void ResetFields()
        {
            //Update the fields 
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(CheckBox))
                {
                    CheckBox btn = (CheckBox)btns;
                    btn.Checked = false;
                }
            }
            cmbType.Text = string.Empty;
            richTextBox1.Text = string.Empty;
            txtNameRec.Clear();
            txtNameImg.Clear();
            pictureBox.Image = null;
            txtTags.Clear();
            txtInstrument.Clear();
            txtPnL.Text = "0";
            string thedatetime = dateTimePicker1.Value.ToString("d");
            monthCalendar.UpdateBoldedDates();
            FillCombo();
            FillGrid();
            FillTreeView(startDate, endDate);
        }


        private void ActivateFields(bool x)
        {
            btnDelImg.Enabled = x;
            btnDelRec.Enabled = x;
            btnSaveRec.Enabled = x;
            btnFileSaveImg.Enabled = x;
            btnLoadImg.Enabled = x;
            btnPasteImg.Enabled = x;
            btnSaveImg.Enabled = x;
            toolStripbtnCopy.Enabled = x;
            toolStripbtnCut.Enabled = x;
            toolStripbtnPaste.Enabled = x;
            toolStripbtnRedo.Enabled = x;
            toolStripbtnUndo.Enabled = x;
            toolStripCmbTemplate.Enabled = x;
            toolStripbtnTimestamp.Enabled = x;
            cmbType.Enabled = x;
            txtNameImg.Enabled = x;
            txtNameRec.Enabled = x;
            txtInstrument.Enabled = x;
            txtPnL.Enabled = x;
            txtTags.Enabled = x;
            richTextBox1.Enabled = x;
            pictureBox.Enabled = x;

            if (!pictureBox.Enabled) { pictureBox.Image = pictureBox.InitialImage; }
            if (!richTextBox1.Enabled) { richTextBox1.Text = strDefaultTextboxMessage; }
            if (!txtTags.Enabled) { txtTags.Text = strDefaultTagsExamples; }
            if (!txtInstrument.Enabled) { txtInstrument.Text = strDefaultInstrumentExample; }
            if (!txtNameImg.Enabled) { txtNameImg.Text = strDefaultImageName; }
            if (!cmbType.Enabled) { cmbType.Text = strDefaultType; }
            if (!txtNameRec.Enabled) { txtNameRec.Text = strDefaultRecordName; }
        }

        #endregion


        #region ToolStrip Items

        private void toolStripbtnUndo_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void toolStripbtnRedo_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void toolStripbtnCut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void toolStripbtnCopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripbtnPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripbtnTimestamp_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\r\n \r\n " + DateTime.Now.ToString();
        }

        private void toolStripbtnOrientation_Click(object sender, EventArgs e)
        {
            if (splitContainer.Orientation.Equals(Orientation.Vertical))
            {
                splitContainer.Orientation = Orientation.Horizontal;
            }
            else
            {
                splitContainer.Orientation = Orientation.Vertical;
            }
        }


        #endregion


        #region CHECKBOXES

        //changing the matching checkboxes from one to other being checked
        private void changeCheckbox(object chbSender, object chbOther)
        {
            currentCheckbox = (CheckBox)chbSender;
            oldCheckbox = (CheckBox)chbOther;
            if(oldCheckbox.Checked != false)
            {
                oldCheckbox.Checked = false;
                currentCheckbox.Checked = true;
            }
        }

        private void chbBodyYes_CheckedChanged(object sender, EventArgs e)
        {
            changeCheckbox(sender,  chbBodyNo);
        }

        private void chbBodyNo_CheckedChanged(object sender, EventArgs e)
        {
            changeCheckbox(sender, chbBodyYes);
        }

        private void chbMindYes_CheckedChanged(object sender, EventArgs e)
        {
            changeCheckbox(sender, chbMindNo);
        }

        private void chbMindNo_CheckedChanged(object sender, EventArgs e)
        {
            changeCheckbox(sender, chbMindYes);
        }

        private void chbEmotionsYes_CheckedChanged(object sender, EventArgs e)
        {
            changeCheckbox(sender, chbEmotionsNo);
        }

        private void chbEmotionsNo_CheckedChanged(object sender, EventArgs e)
        {
            changeCheckbox(sender, chbEmotionsYes);
        }

        private void chbMonthlyUp_CheckedChanged(object sender, EventArgs e)
        {
            changeCheckbox(sender, chbMonthlyDown);
        }

        private void chbMonthlyDown_CheckedChanged(object sender, EventArgs e)
        {
            changeCheckbox(sender, chbMonthlyUp);
        }

        private void chbWeeklyUp_CheckedChanged(object sender, EventArgs e)
        {
            changeCheckbox(sender, chbWeeklyDown);
        }

        private void chbWeeklyDown_CheckedChanged(object sender, EventArgs e)
        {
            changeCheckbox(sender, chbWeeklyUp);
        }

        private void chbDailyUp_CheckedChanged(object sender, EventArgs e)
        {
            changeCheckbox(sender, chbDailyDown);
        }

        private void chbDailyDown_CheckedChanged(object sender, EventArgs e)
        {
            changeCheckbox(sender, chbDailyUp);
        }


        #endregion


        #region BUTTONS
        private void btnNewRec_Click(object sender, EventArgs e)
        {
            CreateTheRecord();
        }

        private void btnSaveRec_Click(object sender, EventArgs e)
        {
            SaveTheRecord();
        }

        private void btnFileSaveImg_Click(object sender, EventArgs e)
        {
            //Save pic from picbox to HD
            if (pictureBox.Image != null)
            {
                using (SaveFileDialog spf = new SaveFileDialog() { Filter = "Chose Image File(*.jpg; *.png, *.gif)|*.jpg; *.png; *.gif", ValidateNames = true })
                {
                    if (spf.ShowDialog() == DialogResult.OK)
                    {
                        Bitmap image = new Bitmap(pictureBox.Image);
                        image.Save(spf.FileName);
                    }
                }
            }

        }

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            txtNameImg.Clear();
            //add pic to database pictureBox
            using (OpenFileDialog opf = new OpenFileDialog() { Filter = "Chose Image File(*.jpg; *.png, *.gif)|*.jpg; *.png; *.gif", ValidateNames = true, Multiselect = false })
            {
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Image = Image.FromFile(opf.FileName);
                    txtNameImg.Text = opf.FileName;
                }
            }
            txtNameImg.Focus();
        }

        private void btnPasteImg_Click(object sender, EventArgs e)
        {
            txtNameImg.Clear();
            try
            {
                if (Clipboard.ContainsImage())
                {
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Image = Clipboard.GetImage();
                    txtNameImg.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\nTry again and if it dosen't work then\n maybe something is wrong with the image source or my code");
            }

        }

        private void btnSaveImg_Click(object sender, EventArgs e)
        {
            Picbox2db();
            FillGrid();
        }

        private void btnDelImg_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this image?", "Delete Image", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (dataGridView1.CurrentCell != null)
                    {
                        int rowIndex = dataGridView1.CurrentCell.RowIndex;
                        dataGridView1.Rows.RemoveAt(rowIndex);
                        scb = new SQLiteCommandBuilder(sda);
                        sda.Update(ds.Tables["Nmd_THUMB"]);
                        FillGrid();
                        txtNameImg.Text = null;
                        pictureBox.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelRec_Click(object sender, EventArgs e)
        {
            string delrec = $"DELETE from NOTES where Not_ID = {ActiveRecordID}";
            cmd = new SQLiteCommand(delrec, dbCon.Conn);
            dbCon.ConnOpen();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Update the fields 
            ActiveRecordID = 0;
            ResetFields();
            ActivateFields(false);
        }
        #endregion


        private void pictureBox_Click(object sender, EventArgs e)
        {
            if(pictureBox.Image != pictureBox.InitialImage)
            {
                if (pictureBox.Image != null)
                {
                    if (MessageBox.Show("Do you want to copy image to clipboard?", "Copy image to clipboard", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Clipboard.SetImage(pictureBox.Image);
                    }
                }
            }
        }

        private void txtTags_TextChanged(object sender, EventArgs e)
        {
            string s = txtTags.Text;
            if (s.Contains(" "))
            {
                s = s.Replace(" ", "");
                txtTags.Text = "\r\n" + s;
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                // suspend layout to avoid blinking
                richTextBox1.SuspendLayout();

                // get insertion point
                int insPt = richTextBox1.SelectionStart;

                // preserve text from after insertion pont to end of RTF content
                string postRTFContent = richTextBox1.Text.Substring(insPt);

                // remove the content after the insertion point
                richTextBox1.Text = richTextBox1.Text.Substring(0, insPt);

                // add the clipboard content and then the preserved postRTF content
                richTextBox1.Text += (string)Clipboard.GetData("Text") + postRTFContent;

                // adjust the insertion point to just after the inserted text
                richTextBox1.SelectionStart = richTextBox1.TextLength - postRTFContent.Length;

                // restore layout
                richTextBox1.ResumeLayout();

                // cancel the paste
                e.Handled = true;

                //thank you Tommaso Belluzzo
                MessageBox.Show("You can not paste directly to the text box\n\n      Type in the Image Name \n      Click on Add Image to Record");


                txtNameImg.Clear();
                try
                {
                    if (Clipboard.ContainsImage())
                    {
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Image = Clipboard.GetImage();
                        txtNameImg.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\nTry again and if it dosen't work then\n maybe something is wrong with the image source or my code");
                }
            }
        }
    }
}
