namespace LukujenJarjestys
{
    partial class LuvutFM
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
            this.lukuTB = new System.Windows.Forms.TextBox();
            this.vastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.otsikkoLB.Location = new System.Drawing.Point(28, 65);
            this.otsikkoLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(349, 25);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "Anna kokonaisluku (-999 lopettaaksesi): ";
            // 
            // lukuTB
            // 
            this.lukuTB.Location = new System.Drawing.Point(377, 62);
            this.lukuTB.Margin = new System.Windows.Forms.Padding(5);
            this.lukuTB.Name = "lukuTB";
            this.lukuTB.Size = new System.Drawing.Size(155, 33);
            this.lukuTB.TabIndex = 1;
            this.lukuTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lukuTB_KeyPress);
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(28, 111);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(76, 25);
            this.vastausLB.TabIndex = 2;
            this.vastausLB.Text = "Vastaus";
            this.vastausLB.Visible = false;
            // 
            // LuvutFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 172);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.lukuTB);
            this.Controls.Add(this.otsikkoLB);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LuvutFM";
            this.Text = "Lukujen järjestys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label otsikkoLB;
        private TextBox lukuTB;
        private Label vastausLB;
    }
}