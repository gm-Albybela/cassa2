namespace cassa
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
            bottoneEmettiscontrino = new Button();
            txtbQuantitaprodotto = new TextBox();
            txtbPrezzoProdotto = new TextBox();
            txtbNomeProdotto = new TextBox();
            listBoxScontrino = new ListBox();
            BottoneInserisciAltroP = new Button();
            BottoneRimuoviProdotto = new Button();
            labelPrezzoTotale = new Label();
            SuspendLayout();
            // 
            // bottoneEmettiscontrino
            // 
            bottoneEmettiscontrino.Location = new Point(383, 344);
            bottoneEmettiscontrino.Name = "bottoneEmettiscontrino";
            bottoneEmettiscontrino.Size = new Size(121, 58);
            bottoneEmettiscontrino.TabIndex = 0;
            bottoneEmettiscontrino.Text = "button1";
            bottoneEmettiscontrino.UseVisualStyleBackColor = true;
            bottoneEmettiscontrino.Click += bottoneEmettiscontrino_Click;
            // 
            // txtbQuantitaprodotto
            // 
            txtbQuantitaprodotto.Location = new Point(142, 94);
            txtbQuantitaprodotto.Name = "txtbQuantitaprodotto";
            txtbQuantitaprodotto.Size = new Size(100, 23);
            txtbQuantitaprodotto.TabIndex = 1;
            txtbQuantitaprodotto.TextChanged += textBox1_TextChanged;
            // 
            // txtbPrezzoProdotto
            // 
            txtbPrezzoProdotto.Location = new Point(12, 94);
            txtbPrezzoProdotto.Name = "txtbPrezzoProdotto";
            txtbPrezzoProdotto.Size = new Size(100, 23);
            txtbPrezzoProdotto.TabIndex = 2;
            txtbPrezzoProdotto.TextChanged += textBox2_TextChanged;
            // 
            // txtbNomeProdotto
            // 
            txtbNomeProdotto.Location = new Point(72, 35);
            txtbNomeProdotto.Name = "txtbNomeProdotto";
            txtbNomeProdotto.Size = new Size(100, 23);
            txtbNomeProdotto.TabIndex = 3;
            txtbNomeProdotto.TextChanged += textBox3_TextChanged;
            // 
            // listBoxScontrino
            // 
            listBoxScontrino.FormattingEnabled = true;
            listBoxScontrino.ItemHeight = 15;
            listBoxScontrino.Location = new Point(300, 35);
            listBoxScontrino.Name = "listBoxScontrino";
            listBoxScontrino.Size = new Size(218, 214);
            listBoxScontrino.TabIndex = 4;
            listBoxScontrino.SelectedIndexChanged += listBoxScontrino_SelectedIndexChanged;
            // 
            // BottoneInserisciAltroP
            // 
            BottoneInserisciAltroP.Location = new Point(51, 165);
            BottoneInserisciAltroP.Name = "BottoneInserisciAltroP";
            BottoneInserisciAltroP.Size = new Size(179, 58);
            BottoneInserisciAltroP.TabIndex = 5;
            BottoneInserisciAltroP.Text = "button2";
            BottoneInserisciAltroP.UseVisualStyleBackColor = true;
            BottoneInserisciAltroP.Click += BottoneInserisciAltroP_Click;
            // 
            // BottoneRimuoviProdotto
            // 
            BottoneRimuoviProdotto.Location = new Point(51, 229);
            BottoneRimuoviProdotto.Name = "BottoneRimuoviProdotto";
            BottoneRimuoviProdotto.Size = new Size(179, 31);
            BottoneRimuoviProdotto.TabIndex = 6;
            BottoneRimuoviProdotto.Text = "button3";
            BottoneRimuoviProdotto.UseVisualStyleBackColor = true;
            BottoneRimuoviProdotto.Click += BottoneRimuoviProdotto_Click;
            // 
            // labelPrezzoTotale
            // 
            labelPrezzoTotale.AutoSize = true;
            labelPrezzoTotale.Font = new Font("Segoe UI", 15F);
            labelPrezzoTotale.Location = new Point(107, 344);
            labelPrezzoTotale.Name = "labelPrezzoTotale";
            labelPrezzoTotale.Size = new Size(76, 28);
            labelPrezzoTotale.TabIndex = 7;
            labelPrezzoTotale.Text = "TOTALE";
            labelPrezzoTotale.Click += labelPrezzoTotale_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPrezzoTotale);
            Controls.Add(BottoneRimuoviProdotto);
            Controls.Add(BottoneInserisciAltroP);
            Controls.Add(listBoxScontrino);
            Controls.Add(txtbNomeProdotto);
            Controls.Add(txtbPrezzoProdotto);
            Controls.Add(txtbQuantitaprodotto);
            Controls.Add(bottoneEmettiscontrino);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bottoneEmettiscontrino;
        private TextBox txtbQuantitaprodotto;
        private TextBox txtbPrezzoProdotto;
        private TextBox txtbNomeProdotto;
        private ListBox listBoxScontrino;
        private Button BottoneInserisciAltroP;
        private Button BottoneRimuoviProdotto;
        private Label labelPrezzoTotale;
    }
}
