namespace NopanHeitto
{
    partial class NopanHeittoFM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NopanHeittoFM));
            this.Noppa01PB = new System.Windows.Forms.PictureBox();
            this.Noppa02PB = new System.Windows.Forms.PictureBox();
            this.heitaBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa01PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).BeginInit();
            this.SuspendLayout();
            // 
            // Noppa01PB
            // 
            this.Noppa01PB.Image = ((System.Drawing.Image)(resources.GetObject("Noppa01PB.Image")));
            this.Noppa01PB.Location = new System.Drawing.Point(12, 17);
            this.Noppa01PB.Name = "Noppa01PB";
            this.Noppa01PB.Size = new System.Drawing.Size(100, 87);
            this.Noppa01PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa01PB.TabIndex = 0;
            this.Noppa01PB.TabStop = false;
            // 
            // Noppa02PB
            // 
            this.Noppa02PB.Image = ((System.Drawing.Image)(resources.GetObject("Noppa02PB.Image")));
            this.Noppa02PB.Location = new System.Drawing.Point(123, 17);
            this.Noppa02PB.Name = "Noppa02PB";
            this.Noppa02PB.Size = new System.Drawing.Size(100, 87);
            this.Noppa02PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa02PB.TabIndex = 1;
            this.Noppa02PB.TabStop = false;
            // 
            // heitaBT
            // 
            this.heitaBT.Location = new System.Drawing.Point(11, 122);
            this.heitaBT.Name = "heitaBT";
            this.heitaBT.Size = new System.Drawing.Size(212, 30);
            this.heitaBT.TabIndex = 2;
            this.heitaBT.Text = "Heitä";
            this.heitaBT.UseVisualStyleBackColor = true;
            this.heitaBT.Click += new System.EventHandler(this.heitaBT_Click);
            // 
            // NopanHeittoFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 181);
            this.Controls.Add(this.heitaBT);
            this.Controls.Add(this.Noppa02PB);
            this.Controls.Add(this.Noppa01PB);
            this.Name = "NopanHeittoFM";
            this.Text = "Heitä noppaa";
            ((System.ComponentModel.ISupportInitialize)(this.Noppa01PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox Noppa01PB;
        private PictureBox Noppa02PB;
        private Button heitaBT;
    }
}