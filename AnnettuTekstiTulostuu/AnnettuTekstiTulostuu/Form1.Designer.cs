namespace AnnettuTekstiTulostuu
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
            this.haeTekstiTB = new System.Windows.Forms.TextBox();
            this.tulostusLB = new System.Windows.Forms.Label();
            this.tulostaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.Location = new System.Drawing.Point(18, 33);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(270, 32);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "Anna tulostettava teksti:";
            // 
            // haeTekstiTB
            // 
            this.haeTekstiTB.Location = new System.Drawing.Point(303, 33);
            this.haeTekstiTB.Name = "haeTekstiTB";
            this.haeTekstiTB.Size = new System.Drawing.Size(578, 39);
            this.haeTekstiTB.TabIndex = 1;
            // 
            // tulostusLB
            // 
            this.tulostusLB.AutoSize = true;
            this.tulostusLB.Location = new System.Drawing.Point(29, 95);
            this.tulostusLB.Name = "tulostusLB";
            this.tulostusLB.Size = new System.Drawing.Size(58, 32);
            this.tulostusLB.TabIndex = 2;
            this.tulostusLB.Text = "xxxx";
            this.tulostusLB.Visible = false;
            // 
            // tulostaBT
            // 
            this.tulostaBT.ForeColor = System.Drawing.Color.ForestGreen;
            this.tulostaBT.Location = new System.Drawing.Point(690, 109);
            this.tulostaBT.Name = "tulostaBT";
            this.tulostaBT.Size = new System.Drawing.Size(191, 53);
            this.tulostaBT.TabIndex = 3;
            this.tulostaBT.Text = "Tulosta teksti";
            this.tulostaBT.UseVisualStyleBackColor = true;
            this.tulostaBT.Click += new System.EventHandler(this.tulostaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(907, 195);
            this.Controls.Add(this.tulostaBT);
            this.Controls.Add(this.tulostusLB);
            this.Controls.Add(this.haeTekstiTB);
            this.Controls.Add(this.otsikkoLB);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.MintCream;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Harjoitus 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label otsikkoLB;
        private TextBox haeTekstiTB;
        private Label tulostusLB;
        private Button tulostaBT;
    }
}