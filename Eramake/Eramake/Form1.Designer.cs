namespace Eramake
{
    partial class SalausFM
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
            this.merkkijonoLB = new System.Windows.Forms.Label();
            this.merkkijonoTB = new System.Windows.Forms.TextBox();
            this.ECLB = new System.Windows.Forms.Label();
            this.ECTB = new System.Windows.Forms.TextBox();
            this.DCLB = new System.Windows.Forms.Label();
            this.DCTB = new System.Windows.Forms.TextBox();
            this.ECBT = new System.Windows.Forms.Button();
            this.DCBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // merkkijonoLB
            // 
            this.merkkijonoLB.AutoSize = true;
            this.merkkijonoLB.Location = new System.Drawing.Point(15, 9);
            this.merkkijonoLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.merkkijonoLB.Name = "merkkijonoLB";
            this.merkkijonoLB.Size = new System.Drawing.Size(140, 32);
            this.merkkijonoLB.TabIndex = 0;
            this.merkkijonoLB.Text = "Merkkijono:";
            // 
            // merkkijonoTB
            // 
            this.merkkijonoTB.Location = new System.Drawing.Point(205, 6);
            this.merkkijonoTB.Name = "merkkijonoTB";
            this.merkkijonoTB.Size = new System.Drawing.Size(926, 39);
            this.merkkijonoTB.TabIndex = 1;
            // 
            // ECLB
            // 
            this.ECLB.AutoSize = true;
            this.ECLB.Location = new System.Drawing.Point(15, 56);
            this.ECLB.Name = "ECLB";
            this.ECLB.Size = new System.Drawing.Size(167, 32);
            this.ECLB.TabIndex = 2;
            this.ECLB.Text = "Enkryptattuna:";
            // 
            // ECTB
            // 
            this.ECTB.Location = new System.Drawing.Point(205, 53);
            this.ECTB.Name = "ECTB";
            this.ECTB.Size = new System.Drawing.Size(926, 39);
            this.ECTB.TabIndex = 3;
            // 
            // DCLB
            // 
            this.DCLB.AutoSize = true;
            this.DCLB.Location = new System.Drawing.Point(15, 108);
            this.DCLB.Name = "DCLB";
            this.DCLB.Size = new System.Drawing.Size(171, 32);
            this.DCLB.TabIndex = 4;
            this.DCLB.Text = "Dekryptattuna:";
            // 
            // DCTB
            // 
            this.DCTB.Location = new System.Drawing.Point(203, 108);
            this.DCTB.Name = "DCTB";
            this.DCTB.Size = new System.Drawing.Size(928, 39);
            this.DCTB.TabIndex = 5;
            // 
            // ECBT
            // 
            this.ECBT.Location = new System.Drawing.Point(15, 162);
            this.ECBT.Name = "ECBT";
            this.ECBT.Size = new System.Drawing.Size(241, 54);
            this.ECBT.TabIndex = 6;
            this.ECBT.Text = "Salaa";
            this.ECBT.UseVisualStyleBackColor = true;
            this.ECBT.Click += new System.EventHandler(this.ECBT_Click);
            // 
            // DCBT
            // 
            this.DCBT.Location = new System.Drawing.Point(321, 162);
            this.DCBT.Name = "DCBT";
            this.DCBT.Size = new System.Drawing.Size(241, 54);
            this.DCBT.TabIndex = 7;
            this.DCBT.Text = "Pura salaus";
            this.DCBT.UseVisualStyleBackColor = true;
            this.DCBT.Click += new System.EventHandler(this.DCBT_Click);
            // 
            // SalausFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 243);
            this.Controls.Add(this.DCBT);
            this.Controls.Add(this.ECBT);
            this.Controls.Add(this.DCTB);
            this.Controls.Add(this.DCLB);
            this.Controls.Add(this.ECTB);
            this.Controls.Add(this.ECLB);
            this.Controls.Add(this.merkkijonoTB);
            this.Controls.Add(this.merkkijonoLB);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SalausFM";
            this.Text = "Enkryptaus (salaus) ja Dekryptaus (purku)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label merkkijonoLB;
        private TextBox merkkijonoTB;
        private Label ECLB;
        private TextBox ECTB;
        private Label DCLB;
        private TextBox DCTB;
        private Button ECBT;
        private Button DCBT;
    }
}