using EncounterMeWF.UserControls;
using System;
using System.Windows.Forms;
//using BusinessLogic;

namespace EncounterMeWF
{
    public partial class mainForm : Form
    {
        //private Json _math = new Json();
        public mainForm()
        {
            InitializeComponent();
            IndexUC uc = new IndexUC();
            addUserControl(uc);
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void indexButton_Click(object sender, EventArgs e)
        {
            IndexUC uc = new IndexUC();
            addUserControl(uc);
        }

        private void trailsButton_Click(object sender, EventArgs e)
        {
            TrailsUC uc = new TrailsUC();
            addUserControl(uc);
        }
    }
}
