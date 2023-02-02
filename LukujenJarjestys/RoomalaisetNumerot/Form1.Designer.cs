namespace RoomalaisetNumerot
{
    partial class RoomalaisetFM
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
            this.pyyntoLB = new System.Windows.Forms.Label();
            this.lukuTB = new System.Windows.Forms.TextBox();
            this.vastausLB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.otsikkoLB.Location = new System.Drawing.Point(125, 9);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(731, 63);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "Roomalaiset numerot";
            // 
            // pyyntoLB
            // 
            this.pyyntoLB.AutoSize = true;
            this.pyyntoLB.Location = new System.Drawing.Point(12, 93);
            this.pyyntoLB.Name = "pyyntoLB";
            this.pyyntoLB.Size = new System.Drawing.Size(781, 26);
            this.pyyntoLB.TabIndex = 1;
            this.pyyntoLB.Text = "Anna luku välillä (0 - 3999), joka muunnetaan roomalaisiksi:";
            // 
            // lukuTB
            // 
            this.lukuTB.Location = new System.Drawing.Point(817, 90);
            this.lukuTB.Name = "lukuTB";
            this.lukuTB.Size = new System.Drawing.Size(100, 33);
            this.lukuTB.TabIndex = 2;
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(18, 147);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(83, 26);
            this.vastausLB.TabIndex = 3;
            this.vastausLB.Text = "label1";
            this.vastausLB.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(810, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "muuta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RoomalaisetFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 202);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.lukuTB);
            this.Controls.Add(this.pyyntoLB);
            this.Controls.Add(this.otsikkoLB);
            this.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "RoomalaisetFM";
            this.Text = "Muunto Roomalaisiksi numeroiksi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label otsikkoLB;
        private Label pyyntoLB;
        private TextBox lukuTB;
        private Label vastausLB;
        private Button button1;
    }
}