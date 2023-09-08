using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
        private CheckBox currentCheckbox;
        private CheckBox oldCheckbox;

        public FormJournal()
        {
            InitializeComponent();
            pictureBox.Image = pictureBox.InitialImage;
        }

        private void FormJournal_Load(object sender, EventArgs e)
        {
            LoadTheme();
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


    }
}
