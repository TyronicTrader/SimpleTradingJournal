using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingJournal.Forms
{
    public partial class FormJournal : Form
    {

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
                //Radio Buttons
                if (btns.GetType() == typeof(RadioButton))
                {
                    RadioButton btn = (RadioButton)btns;
                    btn.BackColor = ThemeColor.SecondaryColor;
                }

                if(btns.GetType() == typeof(GroupBox))
                {
                    GroupBox btn = (GroupBox)btns;
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

    }
}
