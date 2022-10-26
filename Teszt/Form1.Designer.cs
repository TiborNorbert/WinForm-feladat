
namespace Teszt
{
    partial class Settings
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.szulettido = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Azonnum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.angol = new System.Windows.Forms.RadioButton();
            this.nemet = new System.Windows.Forms.RadioButton();
            this.francia = new System.Windows.Forms.RadioButton();
            this.olasz = new System.Windows.Forms.RadioButton();
            this.szuletetthely = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Nevtext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Azonnum)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Azonositó";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ellenörzés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // szulettido
            // 
            this.szulettido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.szulettido.Location = new System.Drawing.Point(243, 127);
            this.szulettido.Name = "szulettido";
            this.szulettido.Size = new System.Drawing.Size(200, 20);
            this.szulettido.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Született";
            // 
            // Azonnum
            // 
            this.Azonnum.Location = new System.Drawing.Point(274, 93);
            this.Azonnum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Azonnum.Name = "Azonnum";
            this.Azonnum.Size = new System.Drawing.Size(90, 20);
            this.Azonnum.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nyelv";
            // 
            // angol
            // 
            this.angol.AutoSize = true;
            this.angol.Location = new System.Drawing.Point(243, 173);
            this.angol.Name = "angol";
            this.angol.Size = new System.Drawing.Size(52, 17);
            this.angol.TabIndex = 7;
            this.angol.TabStop = true;
            this.angol.Text = "Angol";
            this.angol.UseVisualStyleBackColor = true;
            // 
            // nemet
            // 
            this.nemet.AutoSize = true;
            this.nemet.Location = new System.Drawing.Point(243, 196);
            this.nemet.Name = "nemet";
            this.nemet.Size = new System.Drawing.Size(56, 17);
            this.nemet.TabIndex = 8;
            this.nemet.TabStop = true;
            this.nemet.Text = "Német";
            this.nemet.UseVisualStyleBackColor = true;
            // 
            // francia
            // 
            this.francia.AutoSize = true;
            this.francia.Location = new System.Drawing.Point(243, 219);
            this.francia.Name = "francia";
            this.francia.Size = new System.Drawing.Size(60, 17);
            this.francia.TabIndex = 9;
            this.francia.TabStop = true;
            this.francia.Text = "Francia";
            this.francia.UseVisualStyleBackColor = true;
            // 
            // olasz
            // 
            this.olasz.AutoSize = true;
            this.olasz.Location = new System.Drawing.Point(243, 242);
            this.olasz.Name = "olasz";
            this.olasz.Size = new System.Drawing.Size(51, 17);
            this.olasz.TabIndex = 10;
            this.olasz.TabStop = true;
            this.olasz.Text = "Olasz";
            this.olasz.UseVisualStyleBackColor = true;
            // 
            // szuletetthely
            // 
            this.szuletetthely.FormattingEnabled = true;
            this.szuletetthely.Items.AddRange(new object[] {
            "Aba",
            "Abádszalók",
            "Abaújszántó",
            "Abony",
            "Ács",
            "Adony",
            "Ajak",
            "Ajka",
            "Albertirsa",
            "Alsózsolca",
            "Aszód",
            "Bábolna",
            "Bácsalmás",
            "Badacsonytomaj",
            "Baja",
            "Baktalórántháza",
            "Balassagyarmat",
            "Balatonalmádi",
            "Balatonboglár",
            "Balatonföldvár",
            "Balatonfüred",
            "Balatonfűzfő",
            "Balatonkenese",
            "Balatonlelle",
            "Balkány",
            "Balmazújváros",
            "Barcs",
            "Bátaszék",
            "Bátonyterenye",
            "Battonya",
            "Békés",
            "Békéscsaba",
            "Bélapátfalva",
            "Beled",
            "Berettyóújfalu",
            "Berhida",
            "Besenyszög",
            "Biatorbágy",
            "Bicske",
            "Biharkeresztes",
            "Bodajk",
            "Bóly",
            "Bonyhád",
            "Borsodnádasd",
            "Budakalász",
            "Budakeszi",
            "Budaörs",
            "Budapest",
            "Bük",
            "Cegléd",
            "Celldömölk",
            "Cigánd",
            "Csákvár",
            "Csanádpalota",
            "Csenger",
            "Csepreg",
            "Csongrád",
            "Csorna",
            "Csorvás",
            "Csurgó",
            "Dabas",
            "Debrecen",
            "Demecser",
            "Derecske",
            "Dévaványa",
            "Devecser",
            "Diósd",
            "Dombóvár",
            "Dombrád",
            "Dorog",
            "Dunaföldvár",
            "Dunaharaszti",
            "Dunakeszi",
            "Dunaújváros",
            "Dunavarsány",
            "Dunavecse",
            "Edelény",
            "Eger",
            "Elek",
            "Emőd",
            "Encs",
            "Enying",
            "Ercsi",
            "Érd",
            "Esztergom",
            "Fegyvernek",
            "Fehérgyarmat",
            "Felsőzsolca",
            "Fertőd",
            "Fertőszentmiklós",
            "Fonyód",
            "Fót",
            "Füzesabony",
            "Füzesgyarmat",
            "Gárdony",
            "Göd",
            "Gödöllő",
            "Gönc",
            "Gyál",
            "Gyomaendrőd",
            "Gyömrő",
            "Gyöngyös",
            "Gyöngyöspata",
            "Gyönk",
            "Győr",
            "Gyula",
            "Hajdúböszörmény",
            "Hajdúdorog",
            "Hajdúhadház",
            "Hajdúnánás",
            "Hajdúsámson",
            "Hajdúszoboszló",
            "Hajós",
            "Halásztelek",
            "Harkány",
            "Hatvan",
            "Herend",
            "Heves",
            "Hévíz",
            "Hódmezővásárhely",
            "Ibrány",
            "Igal",
            "Isaszeg",
            "Izsák",
            "Jánoshalma",
            "Jánosháza",
            "Jánossomorja",
            "Jászapáti",
            "Jászárokszállás",
            "Jászberény",
            "Jászfényszaru",
            "Jászkisér",
            "Kaba",
            "Kadarkút",
            "Kalocsa",
            "Kaposvár",
            "Kapuvár",
            "Karcag",
            "Kazincbarcika",
            "Kecel",
            "Kecskemét",
            "Kemecse",
            "Kenderes",
            "Kerekegyháza",
            "Kerepes",
            "Keszthely",
            "Kisbér",
            "Kisköre",
            "Kiskőrös",
            "Kiskunfélegyháza",
            "Kiskunhalas",
            "Kiskunlacháza",
            "Kiskunmajsa",
            "Kistarcsa",
            "Kistelek",
            "Kisújszállás",
            "Kisvárda",
            "Komádi",
            "Komárom",
            "Komló",
            "Kondoros",
            "Kozármisleny",
            "Körmend",
            "Körösladány",
            "Kőszeg",
            "Kunhegyes",
            "Kunszentmárton",
            "Kunszentmiklós",
            "Lábatlan",
            "Lajosmizse",
            "Lébény",
            "Lengyeltóti",
            "Lenti",
            "Létavértes",
            "Letenye",
            "Lőrinci",
            "Maglód",
            "Mágocs",
            "Makó",
            "Mándok",
            "Marcali",
            "Máriapócs",
            "Martfű",
            "Martonvásár",
            "Mátészalka",
            "Medgyesegyháza",
            "Mélykút",
            "Mezőberény",
            "Mezőcsát",
            "Mezőhegyes",
            "Mezőkeresztes",
            "Mezőkovácsháza",
            "Mezőkövesd",
            "Mezőtúr",
            "Mindszent",
            "Miskolc",
            "Mohács",
            "Monor",
            "Mór",
            "Mórahalom",
            "Mosonmagyaróvár",
            "Nádudvar",
            "Nagyatád",
            "Nagybajom",
            "Nagyecsed",
            "Nagyhalász",
            "Nagykálló",
            "Nagykanizsa",
            "Nagykáta",
            "Nagykőrös",
            "Nagymányok",
            "Nagymaros",
            "Nyékládháza",
            "Nyergesújfalu",
            "Nyíradony",
            "Nyírbátor",
            "Nyírbogát",
            "Nyíregyháza",
            "Nyírlugos",
            "Nyírmada",
            "Nyírtelek",
            "Ócsa",
            "Onga",
            "Orosháza",
            "Oroszlány",
            "Ózd",
            "Őrbottyán",
            "Őriszentpéter",
            "Örkény",
            "Pacsa",
            "Paks",
            "Pálháza",
            "Pannonhalma",
            "Pápa",
            "Pásztó",
            "Pécel",
            "Pécs",
            "Pécsvárad",
            "Pétervására",
            "Pilis",
            "Piliscsaba",
            "Pilisvörösvár",
            "Polgár",
            "Polgárdi",
            "Pomáz",
            "Pusztaszabolcs",
            "Putnok",
            "Püspökladány",
            "Rácalmás",
            "Ráckeve",
            "Rakamaz",
            "Rákóczifalva",
            "Répcelak",
            "Rétság",
            "Rudabánya",
            "Sajóbábony",
            "Sajószentpéter",
            "Salgótarján",
            "Sándorfalva",
            "Sárbogárd",
            "Sarkad",
            "Sárospatak",
            "Sárvár",
            "Sásd",
            "Sátoraljaújhely",
            "Sellye",
            "Siklós",
            "Simontornya",
            "Siófok",
            "Solt",
            "Soltvadkert",
            "Sopron",
            "Sülysáp",
            "Sümeg",
            "Szabadszállás",
            "Szarvas",
            "Százhalombatta",
            "Szécsény",
            "Szeged",
            "Szeghalom",
            "Székesfehérvár",
            "Szekszárd",
            "Szendrő",
            "Szentendre",
            "Szentes",
            "Szentgotthárd",
            "Szentlőrinc",
            "Szerencs",
            "Szigethalom",
            "Szigetszentmiklós",
            "Szigetvár",
            "Szikszó",
            "Szob",
            "Szolnok",
            "Szombathely",
            "Tab",
            "Tamási",
            "Tápiószele",
            "Tapolca",
            "Tát",
            "Tata",
            "Tatabánya",
            "Téglás",
            "Tét",
            "Tiszacsege",
            "Tiszaföldvár",
            "Tiszafüred",
            "Tiszakécske",
            "Tiszalök",
            "Tiszaújváros",
            "Tiszavasvári",
            "Tokaj",
            "Tolna",
            "Tompa",
            "Tótkomlós",
            "Tököl",
            "Törökbálint",
            "Törökszentmiklós",
            "Tura",
            "Túrkeve",
            "Újfehértó",
            "Újhartyán",
            "Újkígyós",
            "Újszász",
            "Üllő",
            "Vác",
            "Vaja",
            "Vámospércs",
            "Várpalota",
            "Vásárosnamény",
            "Vasvár",
            "Vecsés",
            "Velence",
            "Vép",
            "Veresegyház",
            "Verpelét",
            "Veszprém",
            "Vésztő",
            "Villány",
            "Visegrád",
            "Záhony",
            "Zalaegerszeg",
            "Zalakaros",
            "Zalalövő",
            "Zalaszentgrót",
            "Zamárdi",
            "Zirc",
            "Zsámbék"});
            this.szuletetthely.Location = new System.Drawing.Point(469, 127);
            this.szuletetthely.Name = "szuletetthely";
            this.szuletetthely.Size = new System.Drawing.Size(151, 21);
            this.szuletetthely.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nev";
            // 
            // Nevtext
            // 
            this.Nevtext.Location = new System.Drawing.Point(256, 58);
            this.Nevtext.Name = "Nevtext";
            this.Nevtext.Size = new System.Drawing.Size(148, 20);
            this.Nevtext.TabIndex = 13;
            // 
            // Settings
            // 
            this.ClientSize = new System.Drawing.Size(1243, 647);
            this.Controls.Add(this.Nevtext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.szuletetthely);
            this.Controls.Add(this.olasz);
            this.Controls.Add(this.francia);
            this.Controls.Add(this.nemet);
            this.Controls.Add(this.angol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Azonnum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.szulettido);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Name = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.Azonnum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonudv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker szulettido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Azonnum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton angol;
        private System.Windows.Forms.RadioButton nemet;
        private System.Windows.Forms.RadioButton francia;
        private System.Windows.Forms.RadioButton olasz;
        private System.Windows.Forms.ComboBox szuletetthely;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Nevtext;
    }
}

