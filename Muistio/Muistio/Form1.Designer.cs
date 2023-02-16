namespace Muistio
{
    partial class muistioFM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tekstiTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tekstiTB
            // 
            this.tekstiTB.Location = new System.Drawing.Point(-3, 0);
            this.tekstiTB.Multiline = true;
            this.tekstiTB.Name = "tekstiTB";
            this.tekstiTB.Size = new System.Drawing.Size(805, 405);
            this.tekstiTB.TabIndex = 0;
            this.tekstiTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tekstiTB_KeyPress);
            // 
            // muistioFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.tekstiTB);
            this.Name = "muistioFM";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tekstiTB;
    }
}