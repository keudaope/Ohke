namespace Tehtava4
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
            this.dateTimeDT = new System.Windows.Forms.DateTimePicker();
            this.laskeBT = new System.Windows.Forms.Button();
            this.vuodetLB = new System.Windows.Forms.Label();
            this.kuukaudetLB = new System.Windows.Forms.Label();
            this.paivatLB = new System.Windows.Forms.Label();
            this.tunnitLB = new System.Windows.Forms.Label();
            this.minuutitLB = new System.Windows.Forms.Label();
            this.sekunnitLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimeDT
            // 
            this.dateTimeDT.Location = new System.Drawing.Point(29, 34);
            this.dateTimeDT.Name = "dateTimeDT";
            this.dateTimeDT.Size = new System.Drawing.Size(395, 39);
            this.dateTimeDT.TabIndex = 0;
            // 
            // laskeBT
            // 
            this.laskeBT.Location = new System.Drawing.Point(444, 35);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(167, 38);
            this.laskeBT.TabIndex = 1;
            this.laskeBT.Text = "Laske";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // vuodetLB
            // 
            this.vuodetLB.AutoSize = true;
            this.vuodetLB.Location = new System.Drawing.Point(32, 102);
            this.vuodetLB.Name = "vuodetLB";
            this.vuodetLB.Size = new System.Drawing.Size(89, 32);
            this.vuodetLB.TabIndex = 2;
            this.vuodetLB.Text = "vuodet";
            this.vuodetLB.Visible = false;
            // 
            // kuukaudetLB
            // 
            this.kuukaudetLB.AutoSize = true;
            this.kuukaudetLB.Location = new System.Drawing.Point(29, 170);
            this.kuukaudetLB.Name = "kuukaudetLB";
            this.kuukaudetLB.Size = new System.Drawing.Size(127, 32);
            this.kuukaudetLB.TabIndex = 3;
            this.kuukaudetLB.Text = "kuukaudet";
            this.kuukaudetLB.Visible = false;
            // 
            // paivatLB
            // 
            this.paivatLB.AutoSize = true;
            this.paivatLB.Location = new System.Drawing.Point(29, 257);
            this.paivatLB.Name = "paivatLB";
            this.paivatLB.Size = new System.Drawing.Size(78, 32);
            this.paivatLB.TabIndex = 4;
            this.paivatLB.Text = "paivat";
            this.paivatLB.Visible = false;
            // 
            // tunnitLB
            // 
            this.tunnitLB.AutoSize = true;
            this.tunnitLB.Location = new System.Drawing.Point(345, 102);
            this.tunnitLB.Name = "tunnitLB";
            this.tunnitLB.Size = new System.Drawing.Size(78, 32);
            this.tunnitLB.TabIndex = 5;
            this.tunnitLB.Text = "tunnit";
            this.tunnitLB.Visible = false;
            // 
            // minuutitLB
            // 
            this.minuutitLB.AutoSize = true;
            this.minuutitLB.Location = new System.Drawing.Point(345, 170);
            this.minuutitLB.Name = "minuutitLB";
            this.minuutitLB.Size = new System.Drawing.Size(105, 32);
            this.minuutitLB.TabIndex = 6;
            this.minuutitLB.Text = "minuutit";
            this.minuutitLB.Visible = false;
            // 
            // sekunnitLB
            // 
            this.sekunnitLB.AutoSize = true;
            this.sekunnitLB.Location = new System.Drawing.Point(345, 257);
            this.sekunnitLB.Name = "sekunnitLB";
            this.sekunnitLB.Size = new System.Drawing.Size(105, 32);
            this.sekunnitLB.TabIndex = 7;
            this.sekunnitLB.Text = "sekunnit";
            this.sekunnitLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 315);
            this.Controls.Add(this.sekunnitLB);
            this.Controls.Add(this.minuutitLB);
            this.Controls.Add(this.tunnitLB);
            this.Controls.Add(this.paivatLB);
            this.Controls.Add(this.kuukaudetLB);
            this.Controls.Add(this.vuodetLB);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.dateTimeDT);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Tehtäävä 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimeDT;
        private Button laskeBT;
        private Label vuodetLB;
        private Label kuukaudetLB;
        private Label paivatLB;
        private Label tunnitLB;
        private Label minuutitLB;
        private Label sekunnitLB;
    }
}