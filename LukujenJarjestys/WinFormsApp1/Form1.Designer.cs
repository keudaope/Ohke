namespace WinFormsApp1
{
    partial class SalasanaFM
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.virheLB = new System.Windows.Forms.Label();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.ssLB = new System.Windows.Forms.Label();
            this.kayttajaTB = new System.Windows.Forms.TextBox();
            this.ktLB = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.terveLB = new System.Windows.Forms.Label();
            this.naytaCB = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.naytaCB);
            this.panel1.Controls.Add(this.virheLB);
            this.panel1.Controls.Add(this.salasanaTB);
            this.panel1.Controls.Add(this.ssLB);
            this.panel1.Controls.Add(this.kayttajaTB);
            this.panel1.Controls.Add(this.ktLB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 250);
            this.panel1.TabIndex = 0;
            // 
            // virheLB
            // 
            this.virheLB.AutoSize = true;
            this.virheLB.Location = new System.Drawing.Point(189, 159);
            this.virheLB.Name = "virheLB";
            this.virheLB.Size = new System.Drawing.Size(104, 51);
            this.virheLB.TabIndex = 3;
            this.virheLB.Text = "virhe";
            this.virheLB.Visible = false;
            this.virheLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // salasanaTB
            // 
            this.salasanaTB.Location = new System.Drawing.Point(303, 89);
            this.salasanaTB.Margin = new System.Windows.Forms.Padding(5);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.PasswordChar = '*';
            this.salasanaTB.Size = new System.Drawing.Size(211, 58);
            this.salasanaTB.TabIndex = 2;
            this.salasanaTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // ssLB
            // 
            this.ssLB.AutoSize = true;
            this.ssLB.Location = new System.Drawing.Point(120, 92);
            this.ssLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ssLB.Name = "ssLB";
            this.ssLB.Size = new System.Drawing.Size(173, 51);
            this.ssLB.TabIndex = 2;
            this.ssLB.Text = "Salasana:";
            // 
            // kayttajaTB
            // 
            this.kayttajaTB.Location = new System.Drawing.Point(303, 21);
            this.kayttajaTB.Margin = new System.Windows.Forms.Padding(5);
            this.kayttajaTB.Name = "kayttajaTB";
            this.kayttajaTB.Size = new System.Drawing.Size(211, 58);
            this.kayttajaTB.TabIndex = 1;
            // 
            // ktLB
            // 
            this.ktLB.AutoSize = true;
            this.ktLB.Location = new System.Drawing.Point(14, 21);
            this.ktLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ktLB.Name = "ktLB";
            this.ktLB.Size = new System.Drawing.Size(279, 51);
            this.ktLB.TabIndex = 0;
            this.ktLB.Text = "Käyttäjätunnus:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.terveLB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 250);
            this.panel2.TabIndex = 1;
            // 
            // terveLB
            // 
            this.terveLB.AutoSize = true;
            this.terveLB.Font = new System.Drawing.Font("Brush Script MT", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.terveLB.ForeColor = System.Drawing.Color.Yellow;
            this.terveLB.Location = new System.Drawing.Point(36, 37);
            this.terveLB.Name = "terveLB";
            this.terveLB.Size = new System.Drawing.Size(629, 91);
            this.terveLB.TabIndex = 0;
            this.terveLB.Text = "Tervetuloa kotisivuilleni";
            // 
            // naytaCB
            // 
            this.naytaCB.AutoSize = true;
            this.naytaCB.Location = new System.Drawing.Point(537, 92);
            this.naytaCB.Name = "naytaCB";
            this.naytaCB.Size = new System.Drawing.Size(300, 55);
            this.naytaCB.TabIndex = 4;
            this.naytaCB.Text = "Näytä salasana";
            this.naytaCB.UseVisualStyleBackColor = true;
            this.naytaCB.CheckedChanged += new System.EventHandler(this.naytaCB_CheckedChanged);
            // 
            // SalasanaFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 250);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SalasanaFM";
            this.Text = "Salasanan tarkastus";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox salasanaTB;
        private Label ssLB;
        private TextBox kayttajaTB;
        private Label ktLB;
        private Label terveLB;
        private Label virheLB;
        private CheckBox naytaCB;
    }
}