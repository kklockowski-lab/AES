
namespace AES
{
    partial class ShowOperationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowOperationForm));
            this.txtMatrixB = new System.Windows.Forms.RichTextBox();
            this.btnSwitchRows = new System.Windows.Forms.Button();
            this.btnMixColumns = new System.Windows.Forms.Button();
            this.btnSBox = new System.Windows.Forms.Button();
            this.txtMatrixA = new System.Windows.Forms.RichTextBox();
            this.btnCreateMatrix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMatrixB
            // 
            this.txtMatrixB.Location = new System.Drawing.Point(383, 52);
            this.txtMatrixB.Name = "txtMatrixB";
            this.txtMatrixB.Size = new System.Drawing.Size(197, 150);
            this.txtMatrixB.TabIndex = 1;
            this.txtMatrixB.Text = "";
            // 
            // btnSwitchRows
            // 
            this.btnSwitchRows.Location = new System.Drawing.Point(267, 65);
            this.btnSwitchRows.Name = "btnSwitchRows";
            this.btnSwitchRows.Size = new System.Drawing.Size(75, 23);
            this.btnSwitchRows.TabIndex = 2;
            this.btnSwitchRows.Text = "SwitchRows";
            this.btnSwitchRows.UseVisualStyleBackColor = true;
            this.btnSwitchRows.Click += new System.EventHandler(this.btnSwitchRows_Click);
            // 
            // btnMixColumns
            // 
            this.btnMixColumns.Location = new System.Drawing.Point(267, 103);
            this.btnMixColumns.Name = "btnMixColumns";
            this.btnMixColumns.Size = new System.Drawing.Size(75, 23);
            this.btnMixColumns.TabIndex = 3;
            this.btnMixColumns.Text = "MixColumns";
            this.btnMixColumns.UseVisualStyleBackColor = true;
            this.btnMixColumns.Click += new System.EventHandler(this.btnMixColumns_Click);
            // 
            // btnSBox
            // 
            this.btnSBox.Location = new System.Drawing.Point(267, 144);
            this.btnSBox.Name = "btnSBox";
            this.btnSBox.Size = new System.Drawing.Size(75, 23);
            this.btnSBox.TabIndex = 4;
            this.btnSBox.Text = "SBox";
            this.btnSBox.UseVisualStyleBackColor = true;
            this.btnSBox.Click += new System.EventHandler(this.btnSBox_Click);
            // 
            // txtMatrixA
            // 
            this.txtMatrixA.Location = new System.Drawing.Point(22, 52);
            this.txtMatrixA.Name = "txtMatrixA";
            this.txtMatrixA.Size = new System.Drawing.Size(197, 150);
            this.txtMatrixA.TabIndex = 5;
            this.txtMatrixA.Text = "";
            // 
            // btnCreateMatrix
            // 
            this.btnCreateMatrix.Location = new System.Drawing.Point(22, 12);
            this.btnCreateMatrix.Name = "btnCreateMatrix";
            this.btnCreateMatrix.Size = new System.Drawing.Size(107, 23);
            this.btnCreateMatrix.TabIndex = 6;
            this.btnCreateMatrix.Text = "Utwórz macierz";
            this.btnCreateMatrix.UseVisualStyleBackColor = true;
            this.btnCreateMatrix.Click += new System.EventHandler(this.btnCreateMatrix_Click);
            // 
            // ShowOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 233);
            this.Controls.Add(this.btnCreateMatrix);
            this.Controls.Add(this.txtMatrixA);
            this.Controls.Add(this.btnSBox);
            this.Controls.Add(this.btnMixColumns);
            this.Controls.Add(this.btnSwitchRows);
            this.Controls.Add(this.txtMatrixB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowOperationForm";
            this.Text = "ShowOperationForm";
            this.Load += new System.EventHandler(this.ShowOperationForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtMatrixB;
        private System.Windows.Forms.Button btnSwitchRows;
        private System.Windows.Forms.Button btnMixColumns;
        private System.Windows.Forms.Button btnSBox;
        private System.Windows.Forms.RichTextBox txtMatrixA;
        private System.Windows.Forms.Button btnCreateMatrix;
    }
}