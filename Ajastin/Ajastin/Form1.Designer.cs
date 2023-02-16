namespace Ajastin
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minCB = new System.Windows.Forms.ComboBox();
            this.SekCB = new System.Windows.Forms.ComboBox();
            this.aikaLB = new System.Windows.Forms.Label();
            this.startBT = new System.Windows.Forms.Button();
            this.stopBT = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minuutit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sekunnit";
            // 
            // minCB
            // 
            this.minCB.FormattingEnabled = true;
            this.minCB.Location = new System.Drawing.Point(24, 46);
            this.minCB.Name = "minCB";
            this.minCB.Size = new System.Drawing.Size(59, 23);
            this.minCB.TabIndex = 2;
            // 
            // SekCB
            // 
            this.SekCB.FormattingEnabled = true;
            this.SekCB.Location = new System.Drawing.Point(142, 46);
            this.SekCB.Name = "SekCB";
            this.SekCB.Size = new System.Drawing.Size(59, 23);
            this.SekCB.TabIndex = 3;
            // 
            // aikaLB
            // 
            this.aikaLB.AutoSize = true;
            this.aikaLB.Location = new System.Drawing.Point(89, 95);
            this.aikaLB.Name = "aikaLB";
            this.aikaLB.Size = new System.Drawing.Size(34, 15);
            this.aikaLB.TabIndex = 4;
            this.aikaLB.Text = "00:00";
            // 
            // startBT
            // 
            this.startBT.Location = new System.Drawing.Point(21, 129);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(75, 23);
            this.startBT.TabIndex = 5;
            this.startBT.Text = "Aloita";
            this.startBT.UseVisualStyleBackColor = true;
            this.startBT.Click += new System.EventHandler(this.startBT_Click);
            // 
            // stopBT
            // 
            this.stopBT.Location = new System.Drawing.Point(126, 129);
            this.stopBT.Name = "stopBT";
            this.stopBT.Size = new System.Drawing.Size(75, 23);
            this.stopBT.TabIndex = 6;
            this.stopBT.Text = "lopeta";
            this.stopBT.UseVisualStyleBackColor = true;
            this.stopBT.Click += new System.EventHandler(this.stopBT_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 178);
            this.Controls.Add(this.stopBT);
            this.Controls.Add(this.startBT);
            this.Controls.Add(this.aikaLB);
            this.Controls.Add(this.SekCB);
            this.Controls.Add(this.minCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox minCB;
        private ComboBox SekCB;
        private Label aikaLB;
        private Button startBT;
        private Button stopBT;
        private System.Windows.Forms.Timer timer1;
    }
}