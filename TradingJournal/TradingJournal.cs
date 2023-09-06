using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

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

        private void btnJournal_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnMetrics_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void btnRSS_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }
    }
}
