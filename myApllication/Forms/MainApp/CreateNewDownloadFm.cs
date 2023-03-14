using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myApllication.Forms.MainApp
{
    public partial class CreateNewDownloadFm : Form
    {
        public CreateNewDownloadFm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            LoadData();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if(downloadTextbox.Text != null && downloadTextbox.Text != "")
            {
                if(PathtextBox.Text != null && PathtextBox.Text != "")
                {

                }
                else
                {
                    var message = "Error!";
                    MessageBox.Show("Path is null!", message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var message = "Error!";
                MessageBox.Show("Download Link is null!", message , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Please Select File Path...";
            sfd.FileName = Path.GetFileName(downloadTextbox.Text);
            sfd.ShowDialog();
            PathtextBox.Text = sfd.FileName;
        }

        private void DownloadLattercBxo_CheckedChanged(object sender, EventArgs e)
        {
            if (DownloadLattercBxo.Checked)
            {
                dateBox.Enabled = true;
                timeBox.Enabled = true;
            }
            else
            {
                dateBox.Enabled = false;
                timeBox.Enabled = false;
            }
        }

        private void LoadData()
        {
            timeBox.Text = DateTime.Now.ToShortTimeString();
            dateBox.Text = DateTime.Now.ToShortDateString();

        } 
    }
}
