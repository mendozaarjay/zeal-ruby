using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ruby
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if(txtInput.Text.Replace(" ","").Length > 0)
            {
                try
                {
                    txtOutput.Text = Security.Encrypt(txtInput.Text);
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Replace(" ", "").Length > 0)
            {
                try
                {
                    txtOutput.Text = Security.Decrypt(txtInput.Text);
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
