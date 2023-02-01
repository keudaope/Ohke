namespace AutonKustannuslaskuri
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
            this.lainaLB = new System.Windows.Forms.Label();
            this.nesteetLB = new System.Windows.Forms.Label();
            this.muutLB = new System.Windows.Forms.Label();
            this.vakuutusLB = new System.Windows.Forms.Label();
            this.energiaLB = new System.Windows.Forms.Label();
            this.kilometritLB = new System.Windows.Forms.Label();
            this.renkaatLB = new System.Windows.Forms.Label();
            this.huoltoLB = new System.Windows.Forms.Label();
            this.pesuLB = new System.Windows.Forms.Label();
            this.kilometritCB = new System.Windows.Forms.ComboBox();
            this.lainaTB = new System.Windows.Forms.TextBox();
            this.nesteetTB = new System.Windows.Forms.TextBox();
            this.vakuutusTB = new System.Windows.Forms.TextBox();
            this.muutTB = new System.Windows.Forms.TextBox();
            this.energiaTB = new System.Windows.Forms.TextBox();
            this.pesuTB = new System.Windows.Forms.TextBox();
            this.huoltoTB = new System.Windows.Forms.TextBox();
            this.renkaatTB = new System.Windows.Forms.TextBox();
            this.kustannuksetLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.Font = new System.Drawing.Font("Sans Serif Collection", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.otsikkoLB.Location = new System.Drawing.Point(63, 20);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(1439, 185);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "Auton kustannuslaskuri";
            // 
            // lainaLB
            // 
            this.lainaLB.AutoSize = true;
            this.lainaLB.Location = new System.Drawing.Point(85, 205);
            this.lainaLB.Name = "lainaLB";
            this.lainaLB.Size = new System.Drawing.Size(281, 58);
            this.lainaLB.TabIndex = 1;
            this.lainaLB.Text = "Lainanhoito:";
            // 
            // nesteetLB
            // 
            this.nesteetLB.AutoSize = true;
            this.nesteetLB.Location = new System.Drawing.Point(85, 286);
            this.nesteetLB.Name = "nesteetLB";
            this.nesteetLB.Size = new System.Drawing.Size(376, 58);
            this.nesteetLB.TabIndex = 2;
            this.nesteetLB.Text = "Lisättävät nesteet:";
            // 
            // muutLB
            // 
            this.muutLB.AutoSize = true;
            this.muutLB.Location = new System.Drawing.Point(85, 447);
            this.muutLB.Name = "muutLB";
            this.muutLB.Size = new System.Drawing.Size(268, 58);
            this.muutLB.TabIndex = 4;
            this.muutLB.Text = "Muut kulut:";
            // 
            // vakuutusLB
            // 
            this.vakuutusLB.AutoSize = true;
            this.vakuutusLB.Location = new System.Drawing.Point(85, 366);
            this.vakuutusLB.Name = "vakuutusLB";
            this.vakuutusLB.Size = new System.Drawing.Size(366, 58);
            this.vakuutusLB.TabIndex = 3;
            this.vakuutusLB.Text = "Vakuutusmaksut:";
            // 
            // energiaLB
            // 
            this.energiaLB.AutoSize = true;
            this.energiaLB.Location = new System.Drawing.Point(85, 530);
            this.energiaLB.Name = "energiaLB";
            this.energiaLB.Size = new System.Drawing.Size(203, 58);
            this.energiaLB.TabIndex = 5;
            this.energiaLB.Text = "Energia: ";
            // 
            // kilometritLB
            // 
            this.kilometritLB.AutoSize = true;
            this.kilometritLB.Location = new System.Drawing.Point(718, 458);
            this.kilometritLB.Name = "kilometritLB";
            this.kilometritLB.Size = new System.Drawing.Size(389, 58);
            this.kilometritLB.TabIndex = 10;
            this.kilometritLB.Text = "Kilometrit / vuosi";
            // 
            // renkaatLB
            // 
            this.renkaatLB.AutoSize = true;
            this.renkaatLB.Location = new System.Drawing.Point(718, 377);
            this.renkaatLB.Name = "renkaatLB";
            this.renkaatLB.Size = new System.Drawing.Size(204, 58);
            this.renkaatLB.TabIndex = 9;
            this.renkaatLB.Text = "Renkaat:";
            // 
            // huoltoLB
            // 
            this.huoltoLB.AutoSize = true;
            this.huoltoLB.Location = new System.Drawing.Point(718, 297);
            this.huoltoLB.Name = "huoltoLB";
            this.huoltoLB.Size = new System.Drawing.Size(180, 58);
            this.huoltoLB.TabIndex = 8;
            this.huoltoLB.Text = "Huollot:";
            // 
            // pesuLB
            // 
            this.pesuLB.AutoSize = true;
            this.pesuLB.Location = new System.Drawing.Point(718, 216);
            this.pesuLB.Name = "pesuLB";
            this.pesuLB.Size = new System.Drawing.Size(146, 58);
            this.pesuLB.TabIndex = 7;
            this.pesuLB.Text = "Pesut:";
            // 
            // kilometritCB
            // 
            this.kilometritCB.FormattingEnabled = true;
            this.kilometritCB.Items.AddRange(new object[] {
            "10 000",
            "20 000",
            "30 000",
            "40 000",
            "50 000",
            "60 000",
            "70 000",
            "80 000",
            "90 000"});
            this.kilometritCB.Location = new System.Drawing.Point(1131, 455);
            this.kilometritCB.Name = "kilometritCB";
            this.kilometritCB.Size = new System.Drawing.Size(200, 66);
            this.kilometritCB.TabIndex = 11;
            this.kilometritCB.SelectedIndexChanged += new System.EventHandler(this.kilometritCB_SelectedIndexChanged);
            // 
            // lainaTB
            // 
            this.lainaTB.Location = new System.Drawing.Point(469, 202);
            this.lainaTB.Name = "lainaTB";
            this.lainaTB.Size = new System.Drawing.Size(200, 66);
            this.lainaTB.TabIndex = 12;
            // 
            // nesteetTB
            // 
            this.nesteetTB.Location = new System.Drawing.Point(469, 283);
            this.nesteetTB.Name = "nesteetTB";
            this.nesteetTB.Size = new System.Drawing.Size(200, 66);
            this.nesteetTB.TabIndex = 13;
            // 
            // vakuutusTB
            // 
            this.vakuutusTB.Location = new System.Drawing.Point(469, 363);
            this.vakuutusTB.Name = "vakuutusTB";
            this.vakuutusTB.Size = new System.Drawing.Size(200, 66);
            this.vakuutusTB.TabIndex = 14;
            // 
            // muutTB
            // 
            this.muutTB.Location = new System.Drawing.Point(469, 444);
            this.muutTB.Name = "muutTB";
            this.muutTB.Size = new System.Drawing.Size(200, 66);
            this.muutTB.TabIndex = 15;
            // 
            // energiaTB
            // 
            this.energiaTB.Location = new System.Drawing.Point(469, 527);
            this.energiaTB.Name = "energiaTB";
            this.energiaTB.Size = new System.Drawing.Size(200, 66);
            this.energiaTB.TabIndex = 16;
            // 
            // pesuTB
            // 
            this.pesuTB.Location = new System.Drawing.Point(1131, 213);
            this.pesuTB.Name = "pesuTB";
            this.pesuTB.Size = new System.Drawing.Size(200, 66);
            this.pesuTB.TabIndex = 17;
            // 
            // huoltoTB
            // 
            this.huoltoTB.Location = new System.Drawing.Point(1131, 294);
            this.huoltoTB.Name = "huoltoTB";
            this.huoltoTB.Size = new System.Drawing.Size(200, 66);
            this.huoltoTB.TabIndex = 18;
            // 
            // renkaatTB
            // 
            this.renkaatTB.Location = new System.Drawing.Point(1131, 374);
            this.renkaatTB.Name = "renkaatTB";
            this.renkaatTB.Size = new System.Drawing.Size(200, 66);
            this.renkaatTB.TabIndex = 19;
            // 
            // kustannuksetLB
            // 
            this.kustannuksetLB.AutoSize = true;
            this.kustannuksetLB.Location = new System.Drawing.Point(85, 632);
            this.kustannuksetLB.Name = "kustannuksetLB";
            this.kustannuksetLB.Size = new System.Drawing.Size(293, 58);
            this.kustannuksetLB.TabIndex = 20;
            this.kustannuksetLB.Text = "Kustannukset";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(25F, 58F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 816);
            this.Controls.Add(this.kustannuksetLB);
            this.Controls.Add(this.renkaatTB);
            this.Controls.Add(this.huoltoTB);
            this.Controls.Add(this.pesuTB);
            this.Controls.Add(this.energiaTB);
            this.Controls.Add(this.muutTB);
            this.Controls.Add(this.vakuutusTB);
            this.Controls.Add(this.nesteetTB);
            this.Controls.Add(this.lainaTB);
            this.Controls.Add(this.kilometritCB);
            this.Controls.Add(this.kilometritLB);
            this.Controls.Add(this.renkaatLB);
            this.Controls.Add(this.huoltoLB);
            this.Controls.Add(this.pesuLB);
            this.Controls.Add(this.energiaLB);
            this.Controls.Add(this.muutLB);
            this.Controls.Add(this.vakuutusLB);
            this.Controls.Add(this.nesteetLB);
            this.Controls.Add(this.lainaLB);
            this.Controls.Add(this.otsikkoLB);
            this.Font = new System.Drawing.Font("Segoe Script", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label otsikkoLB;
        private Label lainaLB;
        private Label nesteetLB;
        private Label muutLB;
        private Label vakuutusLB;
        private Label energiaLB;
        private Label kilometritLB;
        private Label renkaatLB;
        private Label huoltoLB;
        private Label pesuLB;
        private ComboBox kilometritCB;
        private TextBox lainaTB;
        private TextBox nesteetTB;
        private TextBox vakuutusTB;
        private TextBox muutTB;
        private TextBox energiaTB;
        private TextBox pesuTB;
        private TextBox huoltoTB;
        private TextBox renkaatTB;
        private Label kustannuksetLB;
    }
}