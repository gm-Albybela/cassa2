using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cassa
{
    public partial class Form1 : Form
    {
        List<string> nomi = new List<string>();
        List<double> prezzi = new List<double>();
        List<int> quantita = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void aggiorna()
        {
            listBoxScontrino.Items.Clear();
            double totale = 0;

            for (int i = 0; i < nomi.Count; i++)
            {
                double costoRiga = prezzi[i] * quantita[i];
                totale = totale + costoRiga;
                string riga = "x" + quantita[i] + " " + nomi[i] + " - €" + costoRiga;
                listBoxScontrino.Items.Add(riga);
            }

            labelPrezzoTotale.Text = "€ " + totale;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //txtbNomeProdotto
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //txtbPrezzoProdotto
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //txtQuantitaprodotto
        }

        // Bottone Inserisci Prodotto
        private void BottoneInserisciAltroP_Click(object sender, EventArgs e)
        {
            if (txtbNomeProdotto.Text != "" && txtbPrezzoProdotto.Text != "" && txtbQuantitaprodotto.Text != "")
            {
                string nome = txtbNomeProdotto.Text;
                double prezzo = Convert.ToDouble(txtbPrezzoProdotto.Text);
                int qta = Convert.ToInt32(txtbQuantitaprodotto.Text);

                nomi.Add(nome);
                prezzi.Add(prezzo);
                quantita.Add(qta);

                txtbNomeProdotto.Text = "";
                txtbPrezzoProdotto.Text = "";
                txtbQuantitaprodotto.Text = "";

                aggiorna();
            }
            else
            {
                MessageBox.Show("Compila tutti i campi!");
            }
        }

        // Bottone Rimuovi Selezionato
        private void BottoneRimuoviProdotto_Click(object sender, EventArgs e)
        {
            int posizione = listBoxScontrino.SelectedIndex;

            if (posizione != -1)
            {
                nomi.RemoveAt(posizione);
                prezzi.RemoveAt(posizione);
                quantita.RemoveAt(posizione);

                aggiorna();
            }
            else
            {
                MessageBox.Show("Seleziona prima un articolo dalla lista!");
            }
        }

        private void listBoxScontrino_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listboxScontrino
        }

        // Bottone Emetti Scontrino
        private void bottoneEmettiscontrino_Click(object sender, EventArgs e)
        {
            if (nomi.Count > 0)
            {
                double totale = 0;

                for (int i = 0; i < nomi.Count; i++)
                {
                    double costoRiga = prezzi[i] * quantita[i];
                    totale = totale + costoRiga;

                    string rigaFile = nomi[i] + ";" + quantita[i] + ";" + costoRiga + "\n";
                    File.AppendAllText("scontrini.csv", rigaFile);
                }

                File.AppendAllText("scontrini.csv", "TOTALE;" + totale + "\n---\n");

                MessageBox.Show("Scontrino salvato in scontrini.csv!");

                nomi.Clear();
                prezzi.Clear();
                quantita.Clear();

                aggiorna();
            }
            else
            {
                MessageBox.Show("Il carrello è vuoto!");
            }
        }

        private void labelPrezzoTotale_Click(object sender, EventArgs e)
        {
            //labelPrezzoTotale
        }
    }
}