namespace SimulacijaModeliranje
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lStoperica = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            this.tbZaustavnoVremeSati = new System.Windows.Forms.TextBox();
            this.lbZaustavnoVreme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBrzina = new System.Windows.Forms.TextBox();
            this.tbZaustavnoVremeMinuti = new System.Windows.Forms.TextBox();
            this.tbZaustavnoVremeSekunde = new System.Windows.Forms.TextBox();
            this.lProsecanBrojArtikala = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaxArtikala = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVremePoArtiklu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMaxVremeIzmedjuDvaKupca = new System.Windows.Forms.TextBox();
            this.lProsecnoVremeObradeKupca = new System.Windows.Forms.Label();
            this.lBrojKupacaUSporomRedu = new System.Windows.Forms.Label();
            this.lProsecnoVremeURedu = new System.Windows.Forms.Label();
            this.lRedSporeKase = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lLimitBrzeKase = new System.Windows.Forms.Label();
            this.tbLimitBrzeKase = new System.Windows.Forms.TextBox();
            this.lRedBrzeKase = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lStoperica
            // 
            this.lStoperica.AutoSize = true;
            this.lStoperica.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStoperica.Location = new System.Drawing.Point(218, 30);
            this.lStoperica.Name = "lStoperica";
            this.lStoperica.Size = new System.Drawing.Size(69, 29);
            this.lStoperica.TabIndex = 0;
            this.lStoperica.Text = "0:0:0";
            this.lStoperica.Click += new System.EventHandler(this.lStoperica_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(15, 28);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(101, 41);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Pokretanje";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // tbZaustavnoVremeSati
            // 
            this.tbZaustavnoVremeSati.Location = new System.Drawing.Point(119, 107);
            this.tbZaustavnoVremeSati.Name = "tbZaustavnoVremeSati";
            this.tbZaustavnoVremeSati.Size = new System.Drawing.Size(30, 20);
            this.tbZaustavnoVremeSati.TabIndex = 2;
            this.tbZaustavnoVremeSati.Text = "0";
            // 
            // lbZaustavnoVreme
            // 
            this.lbZaustavnoVreme.AutoSize = true;
            this.lbZaustavnoVreme.Location = new System.Drawing.Point(12, 114);
            this.lbZaustavnoVreme.Name = "lbZaustavnoVreme";
            this.lbZaustavnoVreme.Size = new System.Drawing.Size(101, 13);
            this.lbZaustavnoVreme.TabIndex = 3;
            this.lbZaustavnoVreme.Text = "Vreme zaustavljanja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ubrzavanje simulacije";
            // 
            // tbBrzina
            // 
            this.tbBrzina.Location = new System.Drawing.Point(125, 138);
            this.tbBrzina.Name = "tbBrzina";
            this.tbBrzina.Size = new System.Drawing.Size(33, 20);
            this.tbBrzina.TabIndex = 4;
            this.tbBrzina.Text = "10";
            // 
            // tbZaustavnoVremeMinuti
            // 
            this.tbZaustavnoVremeMinuti.Location = new System.Drawing.Point(155, 107);
            this.tbZaustavnoVremeMinuti.Name = "tbZaustavnoVremeMinuti";
            this.tbZaustavnoVremeMinuti.Size = new System.Drawing.Size(31, 20);
            this.tbZaustavnoVremeMinuti.TabIndex = 6;
            this.tbZaustavnoVremeMinuti.Text = "5";
            this.tbZaustavnoVremeMinuti.TextChanged += new System.EventHandler(this.tbZaustavnoVremeMinuti_TextChanged);
            // 
            // tbZaustavnoVremeSekunde
            // 
            this.tbZaustavnoVremeSekunde.Location = new System.Drawing.Point(192, 107);
            this.tbZaustavnoVremeSekunde.Name = "tbZaustavnoVremeSekunde";
            this.tbZaustavnoVremeSekunde.Size = new System.Drawing.Size(29, 20);
            this.tbZaustavnoVremeSekunde.TabIndex = 7;
            this.tbZaustavnoVremeSekunde.Text = "0";
            // 
            // lProsecanBrojArtikala
            // 
            this.lProsecanBrojArtikala.AutoSize = true;
            this.lProsecanBrojArtikala.Location = new System.Drawing.Point(337, 26);
            this.lProsecanBrojArtikala.Name = "lProsecanBrojArtikala";
            this.lProsecanBrojArtikala.Size = new System.Drawing.Size(109, 13);
            this.lProsecanBrojArtikala.TabIndex = 8;
            this.lProsecanBrojArtikala.Text = "Prosecan broj artikala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Maksimalni brioj artikala";
            // 
            // tbMaxArtikala
            // 
            this.tbMaxArtikala.Location = new System.Drawing.Point(136, 169);
            this.tbMaxArtikala.Name = "tbMaxArtikala";
            this.tbMaxArtikala.Size = new System.Drawing.Size(39, 20);
            this.tbMaxArtikala.TabIndex = 9;
            this.tbMaxArtikala.Text = "50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fiksno vreme po artiklu";
            // 
            // tbVremePoArtiklu
            // 
            this.tbVremePoArtiklu.Location = new System.Drawing.Point(136, 203);
            this.tbVremePoArtiklu.Name = "tbVremePoArtiklu";
            this.tbVremePoArtiklu.Size = new System.Drawing.Size(22, 20);
            this.tbVremePoArtiklu.TabIndex = 11;
            this.tbVremePoArtiklu.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Maksimalno vreme izmedju dva kupca";
            // 
            // tbMaxVremeIzmedjuDvaKupca
            // 
            this.tbMaxVremeIzmedjuDvaKupca.Location = new System.Drawing.Point(207, 236);
            this.tbMaxVremeIzmedjuDvaKupca.Name = "tbMaxVremeIzmedjuDvaKupca";
            this.tbMaxVremeIzmedjuDvaKupca.Size = new System.Drawing.Size(26, 20);
            this.tbMaxVremeIzmedjuDvaKupca.TabIndex = 13;
            this.tbMaxVremeIzmedjuDvaKupca.Text = "30";
            // 
            // lProsecnoVremeObradeKupca
            // 
            this.lProsecnoVremeObradeKupca.AutoSize = true;
            this.lProsecnoVremeObradeKupca.Location = new System.Drawing.Point(337, 55);
            this.lProsecnoVremeObradeKupca.Name = "lProsecnoVremeObradeKupca";
            this.lProsecnoVremeObradeKupca.Size = new System.Drawing.Size(153, 13);
            this.lProsecnoVremeObradeKupca.TabIndex = 15;
            this.lProsecnoVremeObradeKupca.Text = "Prosecno vreme obrade kupca";
            // 
            // lBrojKupacaUSporomRedu
            // 
            this.lBrojKupacaUSporomRedu.AutoSize = true;
            this.lBrojKupacaUSporomRedu.Location = new System.Drawing.Point(337, 81);
            this.lBrojKupacaUSporomRedu.Name = "lBrojKupacaUSporomRedu";
            this.lBrojKupacaUSporomRedu.Size = new System.Drawing.Size(134, 13);
            this.lBrojKupacaUSporomRedu.TabIndex = 16;
            this.lBrojKupacaUSporomRedu.Text = "Broj kupaca u sporom redu";
            // 
            // lProsecnoVremeURedu
            // 
            this.lProsecnoVremeURedu.AutoSize = true;
            this.lProsecnoVremeURedu.Location = new System.Drawing.Point(337, 107);
            this.lProsecnoVremeURedu.Name = "lProsecnoVremeURedu";
            this.lProsecnoVremeURedu.Size = new System.Drawing.Size(150, 13);
            this.lProsecnoVremeURedu.TabIndex = 17;
            this.lProsecnoVremeURedu.Text = "Prosecno vreme kupca u redu";
            // 
            // lRedSporeKase
            // 
            this.lRedSporeKase.AutoSize = true;
            this.lRedSporeKase.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRedSporeKase.Location = new System.Drawing.Point(337, 142);
            this.lRedSporeKase.Name = "lRedSporeKase";
            this.lRedSporeKase.Size = new System.Drawing.Size(13, 13);
            this.lRedSporeKase.TabIndex = 18;
            this.lRedSporeKase.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(337, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "1    2    3    4    5    6    7    8    9   10";
            // 
            // lLimitBrzeKase
            // 
            this.lLimitBrzeKase.AutoSize = true;
            this.lLimitBrzeKase.Location = new System.Drawing.Point(14, 269);
            this.lLimitBrzeKase.Name = "lLimitBrzeKase";
            this.lLimitBrzeKase.Size = new System.Drawing.Size(91, 13);
            this.lLimitBrzeKase.TabIndex = 22;
            this.lLimitBrzeKase.Text = "Limit za brzu kasu";
            // 
            // tbLimitBrzeKase
            // 
            this.tbLimitBrzeKase.Location = new System.Drawing.Point(111, 266);
            this.tbLimitBrzeKase.Name = "tbLimitBrzeKase";
            this.tbLimitBrzeKase.Size = new System.Drawing.Size(27, 20);
            this.tbLimitBrzeKase.TabIndex = 21;
            this.tbLimitBrzeKase.Text = "10";
            // 
            // lRedBrzeKase
            // 
            this.lRedBrzeKase.AutoSize = true;
            this.lRedBrzeKase.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRedBrzeKase.Location = new System.Drawing.Point(337, 191);
            this.lRedBrzeKase.Name = "lRedBrzeKase";
            this.lRedBrzeKase.Size = new System.Drawing.Size(13, 13);
            this.lRedBrzeKase.TabIndex = 23;
            this.lRedBrzeKase.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(337, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "1    2    3    4    5    6    7    8    9   10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Sati";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Minuti";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(189, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Sekundi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(152, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "TAJMER:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(626, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Prikaz spora kasa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(626, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Prikaz brza kasa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 330);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lRedBrzeKase);
            this.Controls.Add(this.lLimitBrzeKase);
            this.Controls.Add(this.tbLimitBrzeKase);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lRedSporeKase);
            this.Controls.Add(this.lProsecnoVremeURedu);
            this.Controls.Add(this.lBrojKupacaUSporomRedu);
            this.Controls.Add(this.lProsecnoVremeObradeKupca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMaxVremeIzmedjuDvaKupca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbVremePoArtiklu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMaxArtikala);
            this.Controls.Add(this.lProsecanBrojArtikala);
            this.Controls.Add(this.tbZaustavnoVremeSekunde);
            this.Controls.Add(this.tbZaustavnoVremeMinuti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBrzina);
            this.Controls.Add(this.lbZaustavnoVreme);
            this.Controls.Add(this.tbZaustavnoVremeSati);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.lStoperica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lStoperica;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.TextBox tbZaustavnoVremeSati;
        private System.Windows.Forms.Label lbZaustavnoVreme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBrzina;
        private System.Windows.Forms.TextBox tbZaustavnoVremeMinuti;
        private System.Windows.Forms.TextBox tbZaustavnoVremeSekunde;
        private System.Windows.Forms.Label lProsecanBrojArtikala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaxArtikala;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVremePoArtiklu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMaxVremeIzmedjuDvaKupca;
        private System.Windows.Forms.Label lProsecnoVremeObradeKupca;
        private System.Windows.Forms.Label lBrojKupacaUSporomRedu;
        private System.Windows.Forms.Label lProsecnoVremeURedu;
        private System.Windows.Forms.Label lRedSporeKase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lLimitBrzeKase;
        private System.Windows.Forms.TextBox tbLimitBrzeKase;
        private System.Windows.Forms.Label lRedBrzeKase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

