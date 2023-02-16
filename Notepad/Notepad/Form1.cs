using System.Runtime.CompilerServices;

namespace Notepad
{
    public partial class NotepadFM : Form
    {
        string tiedostoPolku = ""; // Kƒytet‰‰n tallentamaan tiedoston sijainti
        public NotepadFM()
        {
            InitializeComponent();
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // M‰‰ritet‰‰n tiedostopolku ja RichTextBox tyhjiksi
            // Ei paras ratkaisu, sill‰ ei tarkista, onko tiedosto jo tallennettu
            tiedostoPolku = "";
            rikasTB.Text = "";
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Koodi txt-tiedoston avaamiseen
            using (OpenFileDialog atk = new OpenFileDialog() 
            { Filter = "Rikastekstiformaatti|*.rtf", ValidateNames = true, Multiselect = false })
            {
                if (atk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader vl = new StreamReader(atk.FileName))
                    {
                        tiedostoPolku = atk.FileName;
                        Task<string> teksti = vl.ReadToEndAsync();
                        rikasTB.Rtf = teksti.Result;
                    }
                }
            }
        }
    

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tiedostoPolku))
            {              
                using (SaveFileDialog ttk = new SaveFileDialog() 
                { Filter = "Rikastekstiformaatti|*.rtf", ValidateNames = true })
                {
                    if(ttk.ShowDialog()==DialogResult.OK) 
                    {
                        StreamWriter tiedosto = new StreamWriter(ttk.FileName);
                        tiedosto.WriteLine(this.rikasTB.Rtf);
                        tiedosto.Close();
                    }
                }
            }
            else
            {
                using(StreamWriter vk = new StreamWriter(tiedostoPolku))
                {
                    vk.WriteLineAsync(rikasTB.Rtf);
                }
            }         
        }

        private void tallennaNimell‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Voimme kopioida koodin ylt‰
            using (SaveFileDialog ttk = new SaveFileDialog() { Filter = "Tekstidokumentti|*.txt|Rikastekstiformaatti|*.rtf", ValidateNames = true })
            {
                if (ttk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter vk = new StreamWriter(ttk.FileName))
                    {
                        vk.WriteLineAsync(rikasTB.Text);
                    }
                }
            }
        }

        private void tulostuksenEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ohjelman sulkeminen
            this.Close();
        }

        private void peruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Undo();
        }

        private void teeUudelleenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Redo();
        }

        private void leikkaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Cut();
        }

        private void kopioiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Copy();
        }

        private void liit‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Paste();
        }

        private void poistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.SelectedText = "";
        }

        private void valitseKaikkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.SelectAll();
        }

        private void fonttiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            rikasTB.SelectionFont= new Font(fontDialog1.Font.FontFamily,fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void korostaTeksti‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.SelectionBackColor = Color.Yellow;
        }

        private void tietoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tehnyt Jyri Lindroos");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rikasTB.Text, rikasTB.Font, Brushes.Black, 12, 10);
        }

        private void rikasTB_TextChanged(object sender, EventArgs e)
        {
            if(rikasTB.Text.Length > 0)
            {
                leikkaaToolStripMenuItem.Enabled = true;
                kopioiToolStripMenuItem.Enabled = true;
            }
            else
            {
                leikkaaToolStripMenuItem.Enabled = false;
                kopioiToolStripMenuItem.Enabled = false;
            }
        }

        private void automaattinenRivinvaihtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(automaattinenRivinvaihtoToolStripMenuItem.Checked == false)
            {
                automaattinenRivinvaihtoToolStripMenuItem.Checked = true;
                rikasTB.WordWrap = true;
            }
            else
            {
                automaattinenRivinvaihtoToolStripMenuItem.Checked = false;
                rikasTB.WordWrap = false;
            }
        }
    }
}