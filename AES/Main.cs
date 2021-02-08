using AES.AESImplement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private InputText inputText;
        private void mbtnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void mbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Czy na pewno zamknąć aplikację?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
           inputText = new InputText(txtDecrypted.Text);
            
        }

        private void mbtnEncrypt_Click(object sender, EventArgs e)
        {
            btnEncrypt_Click(null, null);
        }

        private void mbtnDecrypt_Click(object sender, EventArgs e)
        {
            brnDecrypt_Click(null, null);
        }

        private void brnDecrypt_Click(object sender, EventArgs e)
        {

        }

        private void mbtnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Plik tekstowy | *.txt";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtDecrypted.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void mbtnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Plik tekstowy | *.txt";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, txtEncrypted.Text);
            }
        }

        private void pokażToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOperationForm operationForm = new ShowOperationForm();
            operationForm.Show();

        }
    }
}
