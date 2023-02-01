namespace Teksti
{
    partial class Form1
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
            this.otsikkoLB = new System.Windows.Forms.Label();
            this.vaihdaTekstiBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.otsikkoLB.Location = new System.Drawing.Point(14, 12);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(113, 40);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "Otsikko";
            // 
            // vaihdaTekstiBT
            // 
            this.vaihdaTekstiBT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vaihdaTekstiBT.Location = new System.Drawing.Point(23, 67);
            this.vaihdaTekstiBT.Name = "vaihdaTekstiBT";
            this.vaihdaTekstiBT.Size = new System.Drawing.Size(276, 55);
            this.vaihdaTekstiBT.TabIndex = 1;
            this.vaihdaTekstiBT.Text = "Vaihda teksti";
            this.vaihdaTekstiBT.UseVisualStyleBackColor = true;
            this.vaihdaTekstiBT.Click += new System.EventHandler(this.vaihdaTekstiBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 134);
            this.Controls.Add(this.vaihdaTekstiBT);
            this.Controls.Add(this.otsikkoLB);
            this.Name = "Form1";
            this.Text = "Harjoitus1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label otsikkoLB;
        private Button vaihdaTekstiBT;
    }
}