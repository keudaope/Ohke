namespace Sekkari
{
    partial class sekkariFM
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
            this.components = new System.ComponentModel.Container();
            this.kelloLB = new System.Windows.Forms.Label();
            this.kaynnistaBT = new System.Windows.Forms.Button();
            this.pysaytaBT = new System.Windows.Forms.Button();
            this.nollaaBT = new System.Windows.Forms.Button();
            this.ajastinTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // kelloLB
            // 
            this.kelloLB.AutoSize = true;
            this.kelloLB.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kelloLB.Location = new System.Drawing.Point(32, 18);
            this.kelloLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kelloLB.Name = "kelloLB";
            this.kelloLB.Size = new System.Drawing.Size(585, 128);
            this.kelloLB.TabIndex = 0;
            this.kelloLB.Text = "00:00:00.000";
            // 
            // kaynnistaBT
            // 
            this.kaynnistaBT.Location = new System.Drawing.Point(57, 158);
            this.kaynnistaBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kaynnistaBT.Name = "kaynnistaBT";
            this.kaynnistaBT.Size = new System.Drawing.Size(155, 58);
            this.kaynnistaBT.TabIndex = 1;
            this.kaynnistaBT.Text = "Käynnistä";
            this.kaynnistaBT.UseVisualStyleBackColor = true;
            this.kaynnistaBT.Click += new System.EventHandler(this.kaynnistaBT_Click);
            // 
            // pysaytaBT
            // 
            this.pysaytaBT.Location = new System.Drawing.Point(240, 158);
            this.pysaytaBT.Margin = new System.Windows.Forms.Padding(2);
            this.pysaytaBT.Name = "pysaytaBT";
            this.pysaytaBT.Size = new System.Drawing.Size(155, 58);
            this.pysaytaBT.TabIndex = 2;
            this.pysaytaBT.Text = "Pysäytä";
            this.pysaytaBT.UseVisualStyleBackColor = true;
            this.pysaytaBT.Click += new System.EventHandler(this.pysaytaBT_Click);
            // 
            // nollaaBT
            // 
            this.nollaaBT.Location = new System.Drawing.Point(423, 158);
            this.nollaaBT.Margin = new System.Windows.Forms.Padding(2);
            this.nollaaBT.Name = "nollaaBT";
            this.nollaaBT.Size = new System.Drawing.Size(155, 58);
            this.nollaaBT.TabIndex = 3;
            this.nollaaBT.Text = "Nollaa";
            this.nollaaBT.UseVisualStyleBackColor = true;
            this.nollaaBT.Click += new System.EventHandler(this.nollaaBT_Click);
            // 
            // ajastinTM
            // 
            this.ajastinTM.Enabled = true;
            this.ajastinTM.Tick += new System.EventHandler(this.ajastinTM_Tick);
            // 
            // sekkariFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 276);
            this.Controls.Add(this.nollaaBT);
            this.Controls.Add(this.pysaytaBT);
            this.Controls.Add(this.kaynnistaBT);
            this.Controls.Add(this.kelloLB);
            this.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "sekkariFM";
            this.Text = "Sekuntikello";
//            this.Load += new System.EventHandler(this.sekkariFM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label kelloLB;
        private Button kaynnistaBT;
        private Button pysaytaBT;
        private Button nollaaBT;
        private System.Windows.Forms.Timer ajastinTM;
    }
}