namespace STJ.View
{
    partial class JournalView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalView));
            this.chbDM = new System.Windows.Forms.CheckBox();
            this.lblTagTip = new System.Windows.Forms.Label();
            this.lblTags = new System.Windows.Forms.Label();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.lblPnL = new System.Windows.Forms.Label();
            this.txtPnL = new System.Windows.Forms.TextBox();
            this.lblInstrument = new System.Windows.Forms.Label();
            this.txtInstrument = new System.Windows.Forms.TextBox();
            this.lblCurRec = new System.Windows.Forms.Label();
            this.chbDailyDown = new System.Windows.Forms.CheckBox();
            this.chbWeeklyDown = new System.Windows.Forms.CheckBox();
            this.chbMonthlyDown = new System.Windows.Forms.CheckBox();
            this.chbDailyUp = new System.Windows.Forms.CheckBox();
            this.chbWeeklyUp = new System.Windows.Forms.CheckBox();
            this.chbMonthlyUp = new System.Windows.Forms.CheckBox();
            this.chbEmotionsNo = new System.Windows.Forms.CheckBox();
            this.chbMindNo = new System.Windows.Forms.CheckBox();
            this.chbBodyNo = new System.Windows.Forms.CheckBox();
            this.chbEmotionsYes = new System.Windows.Forms.CheckBox();
            this.chbMindYes = new System.Windows.Forms.CheckBox();
            this.chbBodyYes = new System.Windows.Forms.CheckBox();
            this.lblDaily = new System.Windows.Forms.Label();
            this.lblWeekly = new System.Windows.Forms.Label();
            this.lblHTF = new System.Windows.Forms.Label();
            this.lblEmotion = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblMonthly = new System.Windows.Forms.Label();
            this.lblMind = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblNameRec = new System.Windows.Forms.Label();
            this.txtNameRec = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStriplblTemplate = new System.Windows.Forms.ToolStripLabel();
            this.toolStripCmbTemplate = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripbtnUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripbtnCut = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripbtnTimestamp = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnOrientation = new System.Windows.Forms.ToolStripButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtNameImg = new System.Windows.Forms.TextBox();
            this.lblNameImg = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSaveImg = new System.Windows.Forms.Button();
            this.btnPasteImg = new System.Windows.Forms.Button();
            this.btnLoadImg = new System.Windows.Forms.Button();
            this.btnFileSaveImg = new System.Windows.Forms.Button();
            this.btnNewRec = new System.Windows.Forms.Button();
            this.btnDelImg = new System.Windows.Forms.Button();
            this.btnDelRec = new System.Windows.Forms.Button();
            this.treeViewNotes = new System.Windows.Forms.TreeView();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lblBackground = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chbDM
            // 
            this.chbDM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbDM.AutoSize = true;
            this.chbDM.Location = new System.Drawing.Point(213, 535);
            this.chbDM.Name = "chbDM";
            this.chbDM.Size = new System.Drawing.Size(76, 17);
            this.chbDM.TabIndex = 109;
            this.chbDM.Text = "DarkMode";
            this.chbDM.UseVisualStyleBackColor = true;
            this.chbDM.Visible = false;
            // 
            // lblTagTip
            // 
            this.lblTagTip.AutoSize = true;
            this.lblTagTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagTip.Location = new System.Drawing.Point(266, 468);
            this.lblTagTip.Name = "lblTagTip";
            this.lblTagTip.Size = new System.Drawing.Size(59, 60);
            this.lblTagTip.TabIndex = 108;
            this.lblTagTip.Text = "Pressing\r\nSpace\r\ncreates a\r\nNew Line";
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTags.Location = new System.Drawing.Point(280, 447);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(45, 18);
            this.lblTags.TabIndex = 107;
            this.lblTags.Text = "Tags";
            // 
            // txtTags
            // 
            this.txtTags.AcceptsReturn = true;
            this.txtTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTags.Location = new System.Drawing.Point(337, 447);
            this.txtTags.Multiline = true;
            this.txtTags.Name = "txtTags";
            this.txtTags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTags.Size = new System.Drawing.Size(150, 90);
            this.txtTags.TabIndex = 106;
            this.txtTags.WordWrap = false;
            // 
            // lblPnL
            // 
            this.lblPnL.AutoSize = true;
            this.lblPnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPnL.Location = new System.Drawing.Point(288, 414);
            this.lblPnL.Name = "lblPnL";
            this.lblPnL.Size = new System.Drawing.Size(37, 18);
            this.lblPnL.TabIndex = 105;
            this.lblPnL.Text = "PnL";
            // 
            // txtPnL
            // 
            this.txtPnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPnL.Location = new System.Drawing.Point(337, 413);
            this.txtPnL.Name = "txtPnL";
            this.txtPnL.Size = new System.Drawing.Size(150, 24);
            this.txtPnL.TabIndex = 104;
            this.txtPnL.Text = "0";
            // 
            // lblInstrument
            // 
            this.lblInstrument.AutoSize = true;
            this.lblInstrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrument.Location = new System.Drawing.Point(238, 381);
            this.lblInstrument.Name = "lblInstrument";
            this.lblInstrument.Size = new System.Drawing.Size(87, 18);
            this.lblInstrument.TabIndex = 103;
            this.lblInstrument.Text = "Instrument";
            // 
            // txtInstrument
            // 
            this.txtInstrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstrument.Location = new System.Drawing.Point(337, 380);
            this.txtInstrument.Name = "txtInstrument";
            this.txtInstrument.Size = new System.Drawing.Size(150, 24);
            this.txtInstrument.TabIndex = 102;
            // 
            // lblCurRec
            // 
            this.lblCurRec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurRec.AutoSize = true;
            this.lblCurRec.BackColor = System.Drawing.SystemColors.Control;
            this.lblCurRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurRec.Location = new System.Drawing.Point(1, 529);
            this.lblCurRec.Name = "lblCurRec";
            this.lblCurRec.Size = new System.Drawing.Size(15, 16);
            this.lblCurRec.TabIndex = 101;
            this.lblCurRec.Text = "0";
            // 
            // chbDailyDown
            // 
            this.chbDailyDown.AutoSize = true;
            this.chbDailyDown.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chbDailyDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDailyDown.Image = ((System.Drawing.Image)(resources.GetObject("chbDailyDown.Image")));
            this.chbDailyDown.Location = new System.Drawing.Point(423, 337);
            this.chbDailyDown.Name = "chbDailyDown";
            this.chbDailyDown.Size = new System.Drawing.Size(54, 28);
            this.chbDailyDown.TabIndex = 100;
            this.chbDailyDown.Text = "     ";
            this.chbDailyDown.UseVisualStyleBackColor = false;
            // 
            // chbWeeklyDown
            // 
            this.chbWeeklyDown.AutoSize = true;
            this.chbWeeklyDown.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chbWeeklyDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbWeeklyDown.Image = ((System.Drawing.Image)(resources.GetObject("chbWeeklyDown.Image")));
            this.chbWeeklyDown.Location = new System.Drawing.Point(424, 299);
            this.chbWeeklyDown.Name = "chbWeeklyDown";
            this.chbWeeklyDown.Size = new System.Drawing.Size(54, 28);
            this.chbWeeklyDown.TabIndex = 99;
            this.chbWeeklyDown.Text = "     ";
            this.chbWeeklyDown.UseVisualStyleBackColor = false;
            // 
            // chbMonthlyDown
            // 
            this.chbMonthlyDown.AutoSize = true;
            this.chbMonthlyDown.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chbMonthlyDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMonthlyDown.Image = ((System.Drawing.Image)(resources.GetObject("chbMonthlyDown.Image")));
            this.chbMonthlyDown.Location = new System.Drawing.Point(423, 263);
            this.chbMonthlyDown.Name = "chbMonthlyDown";
            this.chbMonthlyDown.Size = new System.Drawing.Size(54, 28);
            this.chbMonthlyDown.TabIndex = 98;
            this.chbMonthlyDown.Text = "     ";
            this.chbMonthlyDown.UseVisualStyleBackColor = false;
            // 
            // chbDailyUp
            // 
            this.chbDailyUp.AutoSize = true;
            this.chbDailyUp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chbDailyUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDailyUp.Image = ((System.Drawing.Image)(resources.GetObject("chbDailyUp.Image")));
            this.chbDailyUp.Location = new System.Drawing.Point(351, 337);
            this.chbDailyUp.Name = "chbDailyUp";
            this.chbDailyUp.Size = new System.Drawing.Size(54, 28);
            this.chbDailyUp.TabIndex = 97;
            this.chbDailyUp.Text = "     ";
            this.chbDailyUp.UseVisualStyleBackColor = false;
            // 
            // chbWeeklyUp
            // 
            this.chbWeeklyUp.AutoSize = true;
            this.chbWeeklyUp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chbWeeklyUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbWeeklyUp.Image = ((System.Drawing.Image)(resources.GetObject("chbWeeklyUp.Image")));
            this.chbWeeklyUp.Location = new System.Drawing.Point(351, 299);
            this.chbWeeklyUp.Name = "chbWeeklyUp";
            this.chbWeeklyUp.Size = new System.Drawing.Size(54, 28);
            this.chbWeeklyUp.TabIndex = 96;
            this.chbWeeklyUp.Text = "     ";
            this.chbWeeklyUp.UseVisualStyleBackColor = false;
            // 
            // chbMonthlyUp
            // 
            this.chbMonthlyUp.AutoSize = true;
            this.chbMonthlyUp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chbMonthlyUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMonthlyUp.Image = ((System.Drawing.Image)(resources.GetObject("chbMonthlyUp.Image")));
            this.chbMonthlyUp.Location = new System.Drawing.Point(351, 263);
            this.chbMonthlyUp.Name = "chbMonthlyUp";
            this.chbMonthlyUp.Size = new System.Drawing.Size(54, 28);
            this.chbMonthlyUp.TabIndex = 95;
            this.chbMonthlyUp.Text = "     ";
            this.chbMonthlyUp.UseVisualStyleBackColor = false;
            // 
            // chbEmotionsNo
            // 
            this.chbEmotionsNo.AutoSize = true;
            this.chbEmotionsNo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chbEmotionsNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEmotionsNo.Image = ((System.Drawing.Image)(resources.GetObject("chbEmotionsNo.Image")));
            this.chbEmotionsNo.Location = new System.Drawing.Point(423, 204);
            this.chbEmotionsNo.Name = "chbEmotionsNo";
            this.chbEmotionsNo.Size = new System.Drawing.Size(54, 28);
            this.chbEmotionsNo.TabIndex = 94;
            this.chbEmotionsNo.Text = "     ";
            this.chbEmotionsNo.UseVisualStyleBackColor = false;
            // 
            // chbMindNo
            // 
            this.chbMindNo.AutoSize = true;
            this.chbMindNo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chbMindNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMindNo.Image = ((System.Drawing.Image)(resources.GetObject("chbMindNo.Image")));
            this.chbMindNo.Location = new System.Drawing.Point(423, 171);
            this.chbMindNo.Name = "chbMindNo";
            this.chbMindNo.Size = new System.Drawing.Size(54, 28);
            this.chbMindNo.TabIndex = 93;
            this.chbMindNo.Text = "     ";
            this.chbMindNo.UseVisualStyleBackColor = false;
            // 
            // chbBodyNo
            // 
            this.chbBodyNo.AutoSize = true;
            this.chbBodyNo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chbBodyNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbBodyNo.Image = ((System.Drawing.Image)(resources.GetObject("chbBodyNo.Image")));
            this.chbBodyNo.Location = new System.Drawing.Point(423, 138);
            this.chbBodyNo.Name = "chbBodyNo";
            this.chbBodyNo.Size = new System.Drawing.Size(54, 28);
            this.chbBodyNo.TabIndex = 92;
            this.chbBodyNo.Text = "     ";
            this.chbBodyNo.UseVisualStyleBackColor = false;
            // 
            // chbEmotionsYes
            // 
            this.chbEmotionsYes.AutoSize = true;
            this.chbEmotionsYes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chbEmotionsYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEmotionsYes.Image = ((System.Drawing.Image)(resources.GetObject("chbEmotionsYes.Image")));
            this.chbEmotionsYes.Location = new System.Drawing.Point(351, 204);
            this.chbEmotionsYes.Name = "chbEmotionsYes";
            this.chbEmotionsYes.Size = new System.Drawing.Size(54, 28);
            this.chbEmotionsYes.TabIndex = 91;
            this.chbEmotionsYes.Text = "     ";
            this.chbEmotionsYes.UseVisualStyleBackColor = false;
            // 
            // chbMindYes
            // 
            this.chbMindYes.AutoSize = true;
            this.chbMindYes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chbMindYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMindYes.Image = ((System.Drawing.Image)(resources.GetObject("chbMindYes.Image")));
            this.chbMindYes.Location = new System.Drawing.Point(351, 171);
            this.chbMindYes.Name = "chbMindYes";
            this.chbMindYes.Size = new System.Drawing.Size(54, 28);
            this.chbMindYes.TabIndex = 90;
            this.chbMindYes.Text = "     ";
            this.chbMindYes.UseVisualStyleBackColor = false;
            // 
            // chbBodyYes
            // 
            this.chbBodyYes.AutoSize = true;
            this.chbBodyYes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chbBodyYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbBodyYes.Image = ((System.Drawing.Image)(resources.GetObject("chbBodyYes.Image")));
            this.chbBodyYes.Location = new System.Drawing.Point(351, 138);
            this.chbBodyYes.Name = "chbBodyYes";
            this.chbBodyYes.Size = new System.Drawing.Size(54, 28);
            this.chbBodyYes.TabIndex = 89;
            this.chbBodyYes.Text = "     ";
            this.chbBodyYes.UseVisualStyleBackColor = false;
            // 
            // lblDaily
            // 
            this.lblDaily.AutoSize = true;
            this.lblDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaily.Location = new System.Drawing.Point(280, 342);
            this.lblDaily.Name = "lblDaily";
            this.lblDaily.Size = new System.Drawing.Size(45, 18);
            this.lblDaily.TabIndex = 88;
            this.lblDaily.Text = "Daily";
            // 
            // lblWeekly
            // 
            this.lblWeekly.AutoSize = true;
            this.lblWeekly.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeekly.Location = new System.Drawing.Point(262, 304);
            this.lblWeekly.Name = "lblWeekly";
            this.lblWeekly.Size = new System.Drawing.Size(63, 18);
            this.lblWeekly.TabIndex = 87;
            this.lblWeekly.Text = "Weekly";
            // 
            // lblHTF
            // 
            this.lblHTF.AutoSize = true;
            this.lblHTF.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblHTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHTF.ForeColor = System.Drawing.Color.White;
            this.lblHTF.Location = new System.Drawing.Point(372, 240);
            this.lblHTF.Name = "lblHTF";
            this.lblHTF.Size = new System.Drawing.Size(81, 18);
            this.lblHTF.TabIndex = 86;
            this.lblHTF.Text = "HTF BIAS";
            // 
            // lblEmotion
            // 
            this.lblEmotion.AutoSize = true;
            this.lblEmotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmotion.Location = new System.Drawing.Point(245, 209);
            this.lblEmotion.Name = "lblEmotion";
            this.lblEmotion.Size = new System.Drawing.Size(80, 18);
            this.lblEmotion.TabIndex = 85;
            this.lblEmotion.Text = "Emotions";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.ForeColor = System.Drawing.Color.White;
            this.lblHealth.Location = new System.Drawing.Point(384, 117);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(56, 18);
            this.lblHealth.TabIndex = 84;
            this.lblHealth.Text = "Health";
            // 
            // lblMonthly
            // 
            this.lblMonthly.AutoSize = true;
            this.lblMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthly.Location = new System.Drawing.Point(258, 268);
            this.lblMonthly.Name = "lblMonthly";
            this.lblMonthly.Size = new System.Drawing.Size(67, 18);
            this.lblMonthly.TabIndex = 83;
            this.lblMonthly.Text = "Monthly";
            // 
            // lblMind
            // 
            this.lblMind.AutoSize = true;
            this.lblMind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMind.Location = new System.Drawing.Point(281, 176);
            this.lblMind.Name = "lblMind";
            this.lblMind.Size = new System.Drawing.Size(44, 18);
            this.lblMind.TabIndex = 82;
            this.lblMind.Text = "Mind";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBody.Location = new System.Drawing.Point(279, 143);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(46, 18);
            this.lblBody.TabIndex = 81;
            this.lblBody.Text = "Body";
            // 
            // lblNameRec
            // 
            this.lblNameRec.AutoSize = true;
            this.lblNameRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameRec.Location = new System.Drawing.Point(273, 88);
            this.lblNameRec.Name = "lblNameRec";
            this.lblNameRec.Size = new System.Drawing.Size(52, 18);
            this.lblNameRec.TabIndex = 80;
            this.lblNameRec.Text = "Name";
            // 
            // txtNameRec
            // 
            this.txtNameRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameRec.Location = new System.Drawing.Point(337, 86);
            this.txtNameRec.Name = "txtNameRec";
            this.txtNameRec.Size = new System.Drawing.Size(150, 24);
            this.txtNameRec.TabIndex = 79;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(281, 56);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 18);
            this.lblType.TabIndex = 78;
            this.lblType.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(337, 53);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(150, 24);
            this.cmbType.TabIndex = 77;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(259, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 22);
            this.dateTimePicker1.TabIndex = 76;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.Location = new System.Drawing.Point(513, 12);
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
            this.splitContainer.Size = new System.Drawing.Size(478, 541);
            this.splitContainer.SplitterDistance = 345;
            this.splitContainer.SplitterWidth = 8;
            this.splitContainer.TabIndex = 75;
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(474, 316);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
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
            this.toolStripbtnTimestamp,
            this.toolStripbtnOrientation});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(474, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStriplblTemplate
            // 
            this.toolStriplblTemplate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStriplblTemplate.Name = "toolStriplblTemplate";
            this.toolStriplblTemplate.Size = new System.Drawing.Size(61, 22);
            this.toolStriplblTemplate.Text = "Template";
            // 
            // toolStripCmbTemplate
            // 
            this.toolStripCmbTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripCmbTemplate.Name = "toolStripCmbTemplate";
            this.toolStripCmbTemplate.Size = new System.Drawing.Size(121, 25);
            this.toolStripCmbTemplate.ToolTipText = "Select Template";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripbtnUndo
            // 
            this.toolStripbtnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtnUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnUndo.Image")));
            this.toolStripbtnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnUndo.Name = "toolStripbtnUndo";
            this.toolStripbtnUndo.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtnUndo.Text = "Undo";
            // 
            // toolStripbtnRedo
            // 
            this.toolStripbtnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtnRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnRedo.Image")));
            this.toolStripbtnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnRedo.Name = "toolStripbtnRedo";
            this.toolStripbtnRedo.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtnRedo.Text = "Redo";
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
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripbtnTimestamp
            // 
            this.toolStripbtnTimestamp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtnTimestamp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnTimestamp.Image")));
            this.toolStripbtnTimestamp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnTimestamp.Name = "toolStripbtnTimestamp";
            this.toolStripbtnTimestamp.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtnTimestamp.Text = "TimeStamp";
            this.toolStripbtnTimestamp.ToolTipText = "TimeStamp";
            // 
            // toolStripbtnOrientation
            // 
            this.toolStripbtnOrientation.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripbtnOrientation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtnOrientation.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnOrientation.Image")));
            this.toolStripbtnOrientation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnOrientation.Name = "toolStripbtnOrientation";
            this.toolStripbtnOrientation.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtnOrientation.Text = "Change Orientation";
            this.toolStripbtnOrientation.ToolTipText = "Change Orientation";
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(474, 184);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // txtNameImg
            // 
            this.txtNameImg.AcceptsReturn = true;
            this.txtNameImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameImg.Location = new System.Drawing.Point(1006, 237);
            this.txtNameImg.Name = "txtNameImg";
            this.txtNameImg.Size = new System.Drawing.Size(150, 24);
            this.txtNameImg.TabIndex = 74;
            this.txtNameImg.Visible = false;
            // 
            // lblNameImg
            // 
            this.lblNameImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameImg.AutoSize = true;
            this.lblNameImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameImg.Location = new System.Drawing.Point(1035, 217);
            this.lblNameImg.Name = "lblNameImg";
            this.lblNameImg.Size = new System.Drawing.Size(102, 18);
            this.lblNameImg.TabIndex = 73;
            this.lblNameImg.Text = "Image Name";
            this.lblNameImg.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(987, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(185, 240);
            this.dataGridView1.TabIndex = 72;
            // 
            // btnSaveImg
            // 
            this.btnSaveImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveImg.Location = new System.Drawing.Point(1006, 182);
            this.btnSaveImg.Name = "btnSaveImg";
            this.btnSaveImg.Size = new System.Drawing.Size(150, 30);
            this.btnSaveImg.TabIndex = 71;
            this.btnSaveImg.Text = "Add Image to Record";
            this.btnSaveImg.UseVisualStyleBackColor = true;
            this.btnSaveImg.Visible = false;
            // 
            // btnPasteImg
            // 
            this.btnPasteImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPasteImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasteImg.Location = new System.Drawing.Point(1006, 148);
            this.btnPasteImg.Name = "btnPasteImg";
            this.btnPasteImg.Size = new System.Drawing.Size(150, 30);
            this.btnPasteImg.TabIndex = 70;
            this.btnPasteImg.Text = "Paste Clipboard Image";
            this.btnPasteImg.UseVisualStyleBackColor = true;
            // 
            // btnLoadImg
            // 
            this.btnLoadImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImg.Location = new System.Drawing.Point(1006, 114);
            this.btnLoadImg.Name = "btnLoadImg";
            this.btnLoadImg.Size = new System.Drawing.Size(150, 30);
            this.btnLoadImg.TabIndex = 69;
            this.btnLoadImg.Text = "Load Image from File";
            this.btnLoadImg.UseVisualStyleBackColor = true;
            // 
            // btnFileSaveImg
            // 
            this.btnFileSaveImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFileSaveImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileSaveImg.Location = new System.Drawing.Point(1006, 80);
            this.btnFileSaveImg.Name = "btnFileSaveImg";
            this.btnFileSaveImg.Size = new System.Drawing.Size(150, 30);
            this.btnFileSaveImg.TabIndex = 68;
            this.btnFileSaveImg.Text = "Export Image to File";
            this.btnFileSaveImg.UseVisualStyleBackColor = true;
            // 
            // btnNewRec
            // 
            this.btnNewRec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRec.Location = new System.Drawing.Point(1006, 12);
            this.btnNewRec.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewRec.Name = "btnNewRec";
            this.btnNewRec.Size = new System.Drawing.Size(150, 38);
            this.btnNewRec.TabIndex = 66;
            this.btnNewRec.Text = "New Record";
            this.btnNewRec.UseVisualStyleBackColor = true;
            // 
            // btnDelImg
            // 
            this.btnDelImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelImg.Location = new System.Drawing.Point(1006, 523);
            this.btnDelImg.Name = "btnDelImg";
            this.btnDelImg.Size = new System.Drawing.Size(150, 30);
            this.btnDelImg.TabIndex = 65;
            this.btnDelImg.Text = "Delete Image";
            this.btnDelImg.UseVisualStyleBackColor = true;
            // 
            // btnDelRec
            // 
            this.btnDelRec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelRec.Location = new System.Drawing.Point(51, 523);
            this.btnDelRec.Name = "btnDelRec";
            this.btnDelRec.Size = new System.Drawing.Size(150, 30);
            this.btnDelRec.TabIndex = 64;
            this.btnDelRec.Text = "Delete Record";
            this.btnDelRec.UseVisualStyleBackColor = true;
            // 
            // treeViewNotes
            // 
            this.treeViewNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewNotes.Location = new System.Drawing.Point(11, 184);
            this.treeViewNotes.Name = "treeViewNotes";
            this.treeViewNotes.Size = new System.Drawing.Size(227, 324);
            this.treeViewNotes.TabIndex = 63;
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar.Location = new System.Drawing.Point(11, 9);
            this.monthCalendar.MaxSelectionCount = 43;
            this.monthCalendar.MinDate = new System.DateTime(1969, 7, 20, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 62;
            this.monthCalendar.TabStop = false;
            this.monthCalendar.TitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // lblBackground
            // 
            this.lblBackground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBackground.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBackground.Location = new System.Drawing.Point(325, 46);
            this.lblBackground.Name = "lblBackground";
            this.lblBackground.Size = new System.Drawing.Size(175, 503);
            this.lblBackground.TabIndex = 61;
            this.lblBackground.Tag = "";
            // 
            // JournalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 562);
            this.Controls.Add(this.chbDM);
            this.Controls.Add(this.lblTagTip);
            this.Controls.Add(this.lblTags);
            this.Controls.Add(this.txtTags);
            this.Controls.Add(this.lblPnL);
            this.Controls.Add(this.txtPnL);
            this.Controls.Add(this.lblInstrument);
            this.Controls.Add(this.txtInstrument);
            this.Controls.Add(this.lblCurRec);
            this.Controls.Add(this.chbDailyDown);
            this.Controls.Add(this.chbWeeklyDown);
            this.Controls.Add(this.chbMonthlyDown);
            this.Controls.Add(this.chbDailyUp);
            this.Controls.Add(this.chbWeeklyUp);
            this.Controls.Add(this.chbMonthlyUp);
            this.Controls.Add(this.chbEmotionsNo);
            this.Controls.Add(this.chbMindNo);
            this.Controls.Add(this.chbBodyNo);
            this.Controls.Add(this.chbEmotionsYes);
            this.Controls.Add(this.chbMindYes);
            this.Controls.Add(this.chbBodyYes);
            this.Controls.Add(this.lblDaily);
            this.Controls.Add(this.lblWeekly);
            this.Controls.Add(this.lblHTF);
            this.Controls.Add(this.lblEmotion);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblMonthly);
            this.Controls.Add(this.lblMind);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.lblNameRec);
            this.Controls.Add(this.txtNameRec);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.txtNameImg);
            this.Controls.Add(this.lblNameImg);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSaveImg);
            this.Controls.Add(this.btnPasteImg);
            this.Controls.Add(this.btnLoadImg);
            this.Controls.Add(this.btnFileSaveImg);
            this.Controls.Add(this.btnNewRec);
            this.Controls.Add(this.btnDelImg);
            this.Controls.Add(this.btnDelRec);
            this.Controls.Add(this.treeViewNotes);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.lblBackground);
            this.MinimumSize = new System.Drawing.Size(1189, 601);
            this.Name = "JournalView";
            this.Text = "Journal";
            this.Load += new System.EventHandler(this.JournalView_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbDM;
        private System.Windows.Forms.Label lblTagTip;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.Label lblPnL;
        private System.Windows.Forms.TextBox txtPnL;
        private System.Windows.Forms.Label lblInstrument;
        private System.Windows.Forms.TextBox txtInstrument;
        private System.Windows.Forms.Label lblCurRec;
        private System.Windows.Forms.CheckBox chbDailyDown;
        private System.Windows.Forms.CheckBox chbWeeklyDown;
        private System.Windows.Forms.CheckBox chbMonthlyDown;
        private System.Windows.Forms.CheckBox chbDailyUp;
        private System.Windows.Forms.CheckBox chbWeeklyUp;
        private System.Windows.Forms.CheckBox chbMonthlyUp;
        private System.Windows.Forms.CheckBox chbEmotionsNo;
        private System.Windows.Forms.CheckBox chbMindNo;
        private System.Windows.Forms.CheckBox chbBodyNo;
        private System.Windows.Forms.CheckBox chbEmotionsYes;
        private System.Windows.Forms.CheckBox chbMindYes;
        private System.Windows.Forms.CheckBox chbBodyYes;
        private System.Windows.Forms.Label lblDaily;
        private System.Windows.Forms.Label lblWeekly;
        private System.Windows.Forms.Label lblHTF;
        private System.Windows.Forms.Label lblEmotion;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblMonthly;
        private System.Windows.Forms.Label lblMind;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Label lblNameRec;
        private System.Windows.Forms.TextBox txtNameRec;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStriplblTemplate;
        private System.Windows.Forms.ToolStripComboBox toolStripCmbTemplate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripbtnUndo;
        private System.Windows.Forms.ToolStripButton toolStripbtnRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripbtnCut;
        private System.Windows.Forms.ToolStripButton toolStripbtnCopy;
        private System.Windows.Forms.ToolStripButton toolStripbtnPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripbtnTimestamp;
        private System.Windows.Forms.ToolStripButton toolStripbtnOrientation;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtNameImg;
        private System.Windows.Forms.Label lblNameImg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSaveImg;
        private System.Windows.Forms.Button btnPasteImg;
        private System.Windows.Forms.Button btnLoadImg;
        private System.Windows.Forms.Button btnFileSaveImg;
        private System.Windows.Forms.Button btnNewRec;
        private System.Windows.Forms.Button btnDelImg;
        private System.Windows.Forms.Button btnDelRec;
        private System.Windows.Forms.TreeView treeViewNotes;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label lblBackground;
    }
}