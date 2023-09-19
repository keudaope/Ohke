namespace SuosikkiNimet
{
    partial class suosikkiFM
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
            this.vastausLB = new System.Windows.Forms.Label();
            this.nimiTB = new System.Windows.Forms.TextBox();
            this.tarkastaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.Location = new System.Drawing.Point(14, 20);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(586, 25);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "Anna nimesi, niin tarkastan, onko se suosituimpien nimien joukossa: ";
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(14, 127);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(80, 25);
            this.vastausLB.TabIndex = 1;
            this.vastausLB.Text = "Vastaus:";
            // 
            // nimiTB
            // 
            this.nimiTB.Location = new System.Drawing.Point(606, 17);
            this.nimiTB.Name = "nimiTB";
            this.nimiTB.Size = new System.Drawing.Size(228, 33);
            this.nimiTB.TabIndex = 2;
            // 
            // tarkastaBT
            // 
            this.tarkastaBT.Location = new System.Drawing.Point(14, 66);
            this.tarkastaBT.Name = "tarkastaBT";
            this.tarkastaBT.Size = new System.Drawing.Size(820, 41);
            this.tarkastaBT.TabIndex = 3;
            this.tarkastaBT.Text = "Tarkasta";
            this.tarkastaBT.UseVisualStyleBackColor = true;
            this.tarkastaBT.Click += new System.EventHandler(this.tarkastaBT_Click);
            // 
            // suosikkiFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 159);
            this.Controls.Add(this.tarkastaBT);
            this.Controls.Add(this.nimiTB);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.otsikkoLB);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "suosikkiFM";
            this.Text = "Onko nimesi suosituimpien nimien joukossa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label otsikkoLB;
        private Label vastausLB;
        private TextBox nimiTB;
        private Button tarkastaBT;
    }
}