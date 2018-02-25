namespace Locksmith2018
{
    partial class Form1
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
            this.cboMake = new System.Windows.Forms.ComboBox();
            this.Makelabel = new System.Windows.Forms.Label();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboMake
            // 
            this.cboMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMake.FormattingEnabled = true;
            this.cboMake.Location = new System.Drawing.Point(52, 12);
            this.cboMake.Name = "cboMake";
            this.cboMake.Size = new System.Drawing.Size(121, 21);
            this.cboMake.TabIndex = 0;
            this.cboMake.SelectedIndexChanged += new System.EventHandler(this.cboMake_SelectedIndexChanged);
            // 
            // Makelabel
            // 
            this.Makelabel.AutoSize = true;
            this.Makelabel.Location = new System.Drawing.Point(11, 15);
            this.Makelabel.Name = "Makelabel";
            this.Makelabel.Size = new System.Drawing.Size(37, 13);
            this.Makelabel.TabIndex = 1;
            this.Makelabel.Text = "Make:";
            // 
            // cboModel
            // 
            this.cboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModel.FormattingEnabled = true;
            this.cboModel.Location = new System.Drawing.Point(52, 51);
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size(121, 21);
            this.cboModel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 372);
            this.Controls.Add(this.cboModel);
            this.Controls.Add(this.Makelabel);
            this.Controls.Add(this.cboMake);
            this.Name = "Form1";
            this.Text = "Locksmith 2018 Armada";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMake;
        private System.Windows.Forms.Label Makelabel;
        private System.Windows.Forms.ComboBox cboModel;
    }
}

