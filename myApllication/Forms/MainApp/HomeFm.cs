using myApllication.Extra;
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
    public partial class HomeFm : Form
    {
        public HomeFm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region MehrCodeLand
        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenLink.OpenUrl("https://github.com/MehrCodeLand");
        }



        #endregion

        private void createNewDownloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewDownloadFm downloadFm = new CreateNewDownloadFm();
            downloadFm.ShowDialog();
        }
    }
}
