using AES.AESImplement;
using AES.AESImplement.MatrixOperation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES
{
    public partial class ShowOperationForm : Form
    {
        public ShowOperationForm(Matrix matrix = null)
        {
            InitializeComponent();
            leftMatrix = matrix;
        }

        Matrix leftMatrix;
        SBox sbox = new SBox();

        private void showMatrix(Matrix matrix, RichTextBox richTextBox)
        {

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    sb.Append(matrix[i, j].ToString("X") + "\t");
                }
                sb.Append("\n");
            }

            richTextBox.Text = sb.ToString();
        }

        private void btnSwitchRows_Click(object sender, EventArgs e)
        {
            if (leftMatrix == null) return;

            Matrix m = (Matrix)leftMatrix.Clone();
            m.SwitchRows();
            showMatrix(m, txtMatrixB);
        }

        private void btnMixColumns_Click(object sender, EventArgs e)
        {
            if (leftMatrix == null) return;

            Matrix m = (Matrix)leftMatrix.Clone();
            m.MixColumns();
            showMatrix(m, txtMatrixB);
        }

        private void btnSBox_Click(object sender, EventArgs e)
        {
            if (leftMatrix == null) return;

            Matrix m = (Matrix)leftMatrix.Clone();

            m.SubBytes(sbox);
            showMatrix(m, txtMatrixB);
        }

        private void ShowOperationForm_Load(object sender, EventArgs e)
        {
            if (leftMatrix != null)
            {
                showMatrix(leftMatrix, txtMatrixA);
            }
        }

        private void btnCreateMatrix_Click(object sender, EventArgs e)
        {
            string[] sBytes = txtMatrixA.Text.Split(' ');
            Matrix matrix = new Matrix();
            bool isError = false;
            if (sBytes.Length > 15)
            {
                int poss = 0;
                for (int i = 0; i < 4; ++i)
                {
                    for (int j = 0; j < 4; ++j)
                    {
                        try
                        {                           
                            byte b = Convert.ToByte(sBytes[poss],16);
                            matrix[i, j] = b;
                            ++poss;
                        }
                        catch (Exception)
                        {
                            isError = true;
                            break;
                        }
                    }

                    if (isError)
                    {
                        MessageBox.Show("Błąd konwersji na bajt na pozycji " + (poss+ 1).ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                }

                leftMatrix = matrix;
                showMatrix(leftMatrix, txtMatrixA);
            }
        }
    }
}
