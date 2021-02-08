namespace AES
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.brnDecrypt = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.operacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnEncrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnDecrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtInstruction = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.txtKeyASCII = new System.Windows.Forms.TextBox();
            this.txtKeyBits = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGeratedKEy = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtEncypted = new System.Windows.Forms.RichTextBox();
            this.txtDecrypted = new System.Windows.Forms.RichTextBox();
            this.txtEncrypted = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mbtnShowOperation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(4, 27);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(78, 58);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Szyfruj";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // brnDecrypt
            // 
            this.brnDecrypt.Location = new System.Drawing.Point(88, 27);
            this.brnDecrypt.Name = "brnDecrypt";
            this.brnDecrypt.Size = new System.Drawing.Size(75, 58);
            this.brnDecrypt.TabIndex = 1;
            this.brnDecrypt.Text = "Odszyfruj";
            this.brnDecrypt.UseVisualStyleBackColor = true;
            this.brnDecrypt.Click += new System.EventHandler(this.brnDecrypt_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.operacjeToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(928, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtnOpen,
            this.mbtnSave,
            this.mbtnClose});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "&Plik";
            // 
            // mbtnOpen
            // 
            this.mbtnOpen.Name = "mbtnOpen";
            this.mbtnOpen.Size = new System.Drawing.Size(117, 22);
            this.mbtnOpen.Text = "&Otwórz";
            this.mbtnOpen.Click += new System.EventHandler(this.mbtnOpen_Click);
            // 
            // mbtnSave
            // 
            this.mbtnSave.Name = "mbtnSave";
            this.mbtnSave.Size = new System.Drawing.Size(117, 22);
            this.mbtnSave.Text = "&Zapisz";
            this.mbtnSave.Click += new System.EventHandler(this.mbtnSave_Click);
            // 
            // mbtnClose
            // 
            this.mbtnClose.Name = "mbtnClose";
            this.mbtnClose.Size = new System.Drawing.Size(117, 22);
            this.mbtnClose.Text = "Zam&knij";
            this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
            // 
            // operacjeToolStripMenuItem
            // 
            this.operacjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtnEncrypt,
            this.mbtnDecrypt,
            this.mbtnShowOperation});
            this.operacjeToolStripMenuItem.Name = "operacjeToolStripMenuItem";
            this.operacjeToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.operacjeToolStripMenuItem.Text = "&Operacje";
            // 
            // mbtnEncrypt
            // 
            this.mbtnEncrypt.Name = "mbtnEncrypt";
            this.mbtnEncrypt.Size = new System.Drawing.Size(180, 22);
            this.mbtnEncrypt.Text = "&Szyfruj";
            this.mbtnEncrypt.Click += new System.EventHandler(this.mbtnEncrypt_Click);
            // 
            // mbtnDecrypt
            // 
            this.mbtnDecrypt.Name = "mbtnDecrypt";
            this.mbtnDecrypt.Size = new System.Drawing.Size(180, 22);
            this.mbtnDecrypt.Text = "&Deszyfruj";
            this.mbtnDecrypt.Click += new System.EventHandler(this.mbtnDecrypt_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtInstruction,
            this.mbtnAbout});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Po&moc";
            // 
            // mbtInstruction
            // 
            this.mbtInstruction.Name = "mbtInstruction";
            this.mbtInstruction.Size = new System.Drawing.Size(141, 22);
            this.mbtInstruction.Text = "&Instrukcja";
            // 
            // mbtnAbout
            // 
            this.mbtnAbout.Name = "mbtnAbout";
            this.mbtnAbout.Size = new System.Drawing.Size(141, 22);
            this.mbtnAbout.Text = "&O programie";
            this.mbtnAbout.Click += new System.EventHandler(this.mbtnAbout_Click);
            // 
            // txtKeyASCII
            // 
            this.txtKeyASCII.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeyASCII.Location = new System.Drawing.Point(235, 32);
            this.txtKeyASCII.Name = "txtKeyASCII";
            this.txtKeyASCII.Size = new System.Drawing.Size(596, 20);
            this.txtKeyASCII.TabIndex = 5;
            // 
            // txtKeyBits
            // 
            this.txtKeyBits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeyBits.Location = new System.Drawing.Point(235, 58);
            this.txtKeyBits.Name = "txtKeyBits";
            this.txtKeyBits.Size = new System.Drawing.Size(596, 20);
            this.txtKeyBits.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Klucz ASCII:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Klucz BIT:";
            // 
            // btnGeratedKEy
            // 
            this.btnGeratedKEy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeratedKEy.Location = new System.Drawing.Point(838, 27);
            this.btnGeratedKEy.Name = "btnGeratedKEy";
            this.btnGeratedKEy.Size = new System.Drawing.Size(75, 58);
            this.btnGeratedKEy.TabIndex = 9;
            this.btnGeratedKEy.Text = "Generuj klucz";
            this.btnGeratedKEy.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtEncypted, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDecrypted, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 116);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 402F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(916, 402);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // txtEncypted
            // 
            this.txtEncypted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEncypted.Location = new System.Drawing.Point(461, 3);
            this.txtEncypted.Name = "txtEncypted";
            this.txtEncypted.Size = new System.Drawing.Size(452, 396);
            this.txtEncypted.TabIndex = 5;
            this.txtEncypted.Text = "";
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDecrypted.Location = new System.Drawing.Point(3, 3);
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.Size = new System.Drawing.Size(452, 396);
            this.txtDecrypted.TabIndex = 4;
            this.txtDecrypted.Text = "Jakiś przykłądowy tekst testowy.";
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncrypted.Location = new System.Drawing.Point(457, 3);
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Size = new System.Drawing.Size(449, 405);
            this.txtEncrypted.TabIndex = 5;
            this.txtEncrypted.Text = "Jakiś przykłądowy tekst testowy.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tekst jawny:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tekst zaszyfrowany:";
            // 
            // mbtnShowOperation
            // 
            this.mbtnShowOperation.Name = "mbtnShowOperation";
            this.mbtnShowOperation.Size = new System.Drawing.Size(180, 22);
            this.mbtnShowOperation.Text = "&Pokaż";
            this.mbtnShowOperation.Click += new System.EventHandler(this.pokażToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 516);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnGeratedKEy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKeyBits);
            this.Controls.Add(this.txtKeyASCII);
            this.Controls.Add(this.brnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "AES szyfruj, deszyfruj";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button brnDecrypt;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mbtnOpen;
        private System.Windows.Forms.ToolStripMenuItem mbtnSave;
        private System.Windows.Forms.ToolStripMenuItem mbtnClose;
        private System.Windows.Forms.ToolStripMenuItem operacjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mbtnEncrypt;
        private System.Windows.Forms.ToolStripMenuItem mbtnDecrypt;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mbtInstruction;
        private System.Windows.Forms.ToolStripMenuItem mbtnAbout;
        private System.Windows.Forms.TextBox txtKeyASCII;
        private System.Windows.Forms.TextBox txtKeyBits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGeratedKEy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox txtDecrypted;
        private System.Windows.Forms.RichTextBox txtEncrypted;
        private System.Windows.Forms.RichTextBox txtEncypted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem mbtnShowOperation;
    }
}

