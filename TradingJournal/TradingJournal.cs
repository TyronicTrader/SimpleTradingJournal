using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TradingJournal
{
    public partial class TradingJournal : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;


        public TradingJournal()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;

            //removes the titlebar
            this.Text = string.Empty;
            this.ControlBox = false;
            //does the window auto snap
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        /// <summary>
        /// DLLImport sections are used for setting the title screen area for draging around window
        /// </summary>
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        #region THEME Section


        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                DisableButton();
                Color color = SelectThemeColor();
                currentButton = (Button)btnSender;
                currentButton.BackColor = color;
                currentButton.ForeColor = Color.White;
                panelTitleBar.BackColor = color;
                panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                ThemeColor.PrimaryColor = color;
                ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                btnCloseChildForm.Visible = true;
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelWorkArea.Controls.Add(childForm);
            this.panelWorkArea.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;

        }


        #endregion


        #region  LEFT NAVIGATION BUTTONS


        private void btnJournal_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormJournal(), sender);
        }

        private void btnMetrics_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMetrics(), sender);
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEvents(), sender);
        }

        private void btnRSS_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormRSS(), sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSettings(), sender);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormInfo(), sender);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSearch(), sender);
        }
        private void btnV2Journal_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormV2Journal(), sender);
        }



        #endregion



        #region TOP NAV BUTTONS


        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState |= FormWindowState.Minimized;
        }


        #endregion



        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "DASHBOARD";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }




    }
}
