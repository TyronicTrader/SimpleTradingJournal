using System.Drawing;
using System.Windows.Forms;

namespace TradingJournal.Forms
{
    internal class FormV2Journal : Form
    {
        public FormV2Journal()
        {
            InitializeComponent();
            LoadTheme();
        }


        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormV2Journal
            // 
            this.ClientSize = new System.Drawing.Size(1173, 562);
            this.Name = "FormV2Journal";
            this.Text = "V2Journal";
            this.ResumeLayout(false);

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

            }
        }
    }

}