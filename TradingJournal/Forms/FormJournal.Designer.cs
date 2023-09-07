namespace TradingJournal.Forms
{
    partial class FormJournal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJournal));
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.treeViewNotes = new System.Windows.Forms.TreeView();
            this.btnDelRec = new System.Windows.Forms.Button();
            this.btnDelImg = new System.Windows.Forms.Button();
            this.btnNewRec = new System.Windows.Forms.Button();
            this.btnSaveRec = new System.Windows.Forms.Button();
            this.btnFileSaveImg = new System.Windows.Forms.Button();
            this.btnLoadImg = new System.Windows.Forms.Button();
            this.btnPasteImg = new System.Windows.Forms.Button();
            this.btnSaveImg = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblNameImg = new System.Windows.Forms.Label();
            this.txtImageName = new System.Windows.Forms.TextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStriplblTemplate = new System.Windows.Forms.ToolStripLabel();
            this.toolStripCmbTemplate = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripbtnUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripbtnCut = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripbtnOrientation = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendar.Location = new System.Drawing.Point(13, 13);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.TitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // treeViewNotes
            // 
            this.treeViewNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewNotes.Location = new System.Drawing.Point(13, 188);
            this.treeViewNotes.Name = "treeViewNotes";
            this.treeViewNotes.Size = new System.Drawing.Size(227, 324);
            this.treeViewNotes.TabIndex = 1;
            // 
            // btnDelRec
            // 
            this.btnDelRec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelRec.Location = new System.Drawing.Point(51, 527);
            this.btnDelRec.Name = "btnDelRec";
            this.btnDelRec.Size = new System.Drawing.Size(150, 30);
            this.btnDelRec.TabIndex = 2;
            this.btnDelRec.Text = "Delete Record";
            this.btnDelRec.UseVisualStyleBackColor = true;
            // 
            // btnDelImg
            // 
            this.btnDelImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelImg.Location = new System.Drawing.Point(1008, 527);
            this.btnDelImg.Name = "btnDelImg";
            this.btnDelImg.Size = new System.Drawing.Size(150, 30);
            this.btnDelImg.TabIndex = 3;
            this.btnDelImg.Text = "Delete Image";
            this.btnDelImg.UseVisualStyleBackColor = true;
            // 
            // btnNewRec
            // 
            this.btnNewRec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRec.Location = new System.Drawing.Point(1008, 16);
            this.btnNewRec.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewRec.Name = "btnNewRec";
            this.btnNewRec.Size = new System.Drawing.Size(150, 30);
            this.btnNewRec.TabIndex = 4;
            this.btnNewRec.Text = "New Record";
            this.btnNewRec.UseVisualStyleBackColor = true;
            // 
            // btnSaveRec
            // 
            this.btnSaveRec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRec.Location = new System.Drawing.Point(1008, 50);
            this.btnSaveRec.Name = "btnSaveRec";
            this.btnSaveRec.Size = new System.Drawing.Size(150, 30);
            this.btnSaveRec.TabIndex = 5;
            this.btnSaveRec.Text = "Save Record";
            this.btnSaveRec.UseVisualStyleBackColor = true;
            // 
            // btnFileSaveImg
            // 
            this.btnFileSaveImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFileSaveImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileSaveImg.Location = new System.Drawing.Point(1008, 84);
            this.btnFileSaveImg.Name = "btnFileSaveImg";
            this.btnFileSaveImg.Size = new System.Drawing.Size(150, 30);
            this.btnFileSaveImg.TabIndex = 6;
            this.btnFileSaveImg.Text = "Save Image to File";
            this.btnFileSaveImg.UseVisualStyleBackColor = true;
            // 
            // btnLoadImg
            // 
            this.btnLoadImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImg.Location = new System.Drawing.Point(1008, 118);
            this.btnLoadImg.Name = "btnLoadImg";
            this.btnLoadImg.Size = new System.Drawing.Size(150, 30);
            this.btnLoadImg.TabIndex = 7;
            this.btnLoadImg.Text = "Load Image from File";
            this.btnLoadImg.UseVisualStyleBackColor = true;
            // 
            // btnPasteImg
            // 
            this.btnPasteImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPasteImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasteImg.Location = new System.Drawing.Point(1008, 152);
            this.btnPasteImg.Name = "btnPasteImg";
            this.btnPasteImg.Size = new System.Drawing.Size(150, 30);
            this.btnPasteImg.TabIndex = 8;
            this.btnPasteImg.Text = "Paste Clipboard Image";
            this.btnPasteImg.UseVisualStyleBackColor = true;
            // 
            // btnSaveImg
            // 
            this.btnSaveImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveImg.Location = new System.Drawing.Point(1008, 186);
            this.btnSaveImg.Name = "btnSaveImg";
            this.btnSaveImg.Size = new System.Drawing.Size(150, 30);
            this.btnSaveImg.TabIndex = 9;
            this.btnSaveImg.Text = "Add Image to Record";
            this.btnSaveImg.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1008, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(150, 246);
            this.dataGridView1.TabIndex = 10;
            // 
            // lblNameImg
            // 
            this.lblNameImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameImg.AutoSize = true;
            this.lblNameImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameImg.Location = new System.Drawing.Point(1037, 221);
            this.lblNameImg.Name = "lblNameImg";
            this.lblNameImg.Size = new System.Drawing.Size(102, 18);
            this.lblNameImg.TabIndex = 11;
            this.lblNameImg.Text = "Image Name";
            // 
            // txtImageName
            // 
            this.txtImageName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImageName.Location = new System.Drawing.Point(1008, 242);
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.Size = new System.Drawing.Size(150, 22);
            this.txtImageName.TabIndex = 12;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.Location = new System.Drawing.Point(493, 16);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.richTextBox1);
            this.splitContainer.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pictureBox);
            this.splitContainer.Size = new System.Drawing.Size(500, 541);
            this.splitContainer.SplitterDistance = 246;
            this.splitContainer.SplitterWidth = 8;
            this.splitContainer.TabIndex = 13;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.InitialImage = global::TradingJournal.Properties.Resources.placeholder;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(496, 283);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStriplblTemplate,
            this.toolStripCmbTemplate,
            this.toolStripSeparator1,
            this.toolStripbtnUndo,
            this.toolStripbtnRedo,
            this.toolStripSeparator2,
            this.toolStripbtnCut,
            this.toolStripbtnCopy,
            this.toolStripbtnPaste,
            this.toolStripSeparator3,
            this.toolStripbtnOrientation});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(496, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStriplblTemplate
            // 
            this.toolStriplblTemplate.Name = "toolStriplblTemplate";
            this.toolStriplblTemplate.Size = new System.Drawing.Size(55, 22);
            this.toolStriplblTemplate.Text = "Template";
            // 
            // toolStripCmbTemplate
            // 
            this.toolStripCmbTemplate.Name = "toolStripCmbTemplate";
            this.toolStripCmbTemplate.Size = new System.Drawing.Size(121, 25);
            this.toolStripCmbTemplate.ToolTipText = "Select Template";
            // 
            // toolStripbtnUndo
            // 
            this.toolStripbtnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtnUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnUndo.Image")));
            this.toolStripbtnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnUndo.Name = "toolStripbtnUndo";
            this.toolStripbtnUndo.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtnUndo.Text = "Undo";
            this.toolStripbtnUndo.Click += new System.EventHandler(this.toolStripbtnUndo_Click);
            // 
            // toolStripbtnRedo
            // 
            this.toolStripbtnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtnRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnRedo.Image")));
            this.toolStripbtnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnRedo.Name = "toolStripbtnRedo";
            this.toolStripbtnRedo.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtnRedo.Text = "Redo";
            this.toolStripbtnRedo.Click += new System.EventHandler(this.toolStripbtnRedo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripbtnCut
            // 
            this.toolStripbtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtnCut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnCut.Image")));
            this.toolStripbtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnCut.Name = "toolStripbtnCut";
            this.toolStripbtnCut.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtnCut.Text = "Cut";
            this.toolStripbtnCut.ToolTipText = "Cut";
            this.toolStripbtnCut.Click += new System.EventHandler(this.toolStripbtnCut_Click);
            // 
            // toolStripbtnCopy
            // 
            this.toolStripbtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtnCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnCopy.Image")));
            this.toolStripbtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnCopy.Name = "toolStripbtnCopy";
            this.toolStripbtnCopy.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtnCopy.Text = "Copy";
            this.toolStripbtnCopy.ToolTipText = "Copy";
            this.toolStripbtnCopy.Click += new System.EventHandler(this.toolStripbtnCopy_Click);
            // 
            // toolStripbtnPaste
            // 
            this.toolStripbtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtnPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnPaste.Image")));
            this.toolStripbtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnPaste.Name = "toolStripbtnPaste";
            this.toolStripbtnPaste.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtnPaste.Text = "Paste";
            this.toolStripbtnPaste.ToolTipText = "Paste";
            this.toolStripbtnPaste.Click += new System.EventHandler(this.toolStripbtnPaste_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripbtnOrientation
            // 
            this.toolStripbtnOrientation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtnOrientation.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnOrientation.Image")));
            this.toolStripbtnOrientation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnOrientation.Name = "toolStripbtnOrientation";
            this.toolStripbtnOrientation.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtnOrientation.Text = "Change Orientation";
            this.toolStripbtnOrientation.ToolTipText = "Change Orientation";
            this.toolStripbtnOrientation.Click += new System.EventHandler(this.toolStripbtnOrientation_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(496, 217);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(271, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(326, 44);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(145, 24);
            this.cmbType.TabIndex = 15;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(276, 45);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 18);
            this.lblType.TabIndex = 16;
            this.lblType.Text = "Type";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(326, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 22);
            this.textBox1.TabIndex = 17;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(268, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 18);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(252, 101);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(235, 454);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(227, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(227, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 562);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.txtImageName);
            this.Controls.Add(this.lblNameImg);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSaveImg);
            this.Controls.Add(this.btnPasteImg);
            this.Controls.Add(this.btnLoadImg);
            this.Controls.Add(this.btnFileSaveImg);
            this.Controls.Add(this.btnSaveRec);
            this.Controls.Add(this.btnNewRec);
            this.Controls.Add(this.btnDelImg);
            this.Controls.Add(this.btnDelRec);
            this.Controls.Add(this.treeViewNotes);
            this.Controls.Add(this.monthCalendar);
            this.Name = "FormJournal";
            this.Text = "JOURNAL";
            this.Load += new System.EventHandler(this.FormJournal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.TreeView treeViewNotes;
        private System.Windows.Forms.Button btnDelRec;
        private System.Windows.Forms.Button btnDelImg;
        private System.Windows.Forms.Button btnNewRec;
        private System.Windows.Forms.Button btnSaveRec;
        private System.Windows.Forms.Button btnFileSaveImg;
        private System.Windows.Forms.Button btnLoadImg;
        private System.Windows.Forms.Button btnPasteImg;
        private System.Windows.Forms.Button btnSaveImg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNameImg;
        private System.Windows.Forms.TextBox txtImageName;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStriplblTemplate;
        private System.Windows.Forms.ToolStripComboBox toolStripCmbTemplate;
        private System.Windows.Forms.ToolStripButton toolStripbtnUndo;
        private System.Windows.Forms.ToolStripButton toolStripbtnRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripbtnCut;
        private System.Windows.Forms.ToolStripButton toolStripbtnCopy;
        private System.Windows.Forms.ToolStripButton toolStripbtnPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripbtnOrientation;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}