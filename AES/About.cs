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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            webBrowserAbout.DocumentText = @"<body>
                                            <p><b>Szyfrowanie i deszyfrowanie AES.</p>
                                            <p>Długość klucza 128 bitów.</p>
                                            <p>Wersja 1.0.0.0</b></p>
                                            <p>Autor: Krzysztof Klockowski</p>
                                            <p>Zajęcia: Bezpieczeństwo systemów komputerowych</p>
                                            <p>MUP Oświęcim, 3 semster, informatyka niestacjonarna.</p>
                                            </body>";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
