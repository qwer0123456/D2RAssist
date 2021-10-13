
namespace D2RAssist
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1251, 921);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(669, 598);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Normal";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(733, 598);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nightmare";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton3.Location = new System.Drawing.Point(812, 598);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(43, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Hell";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "0 = None",
            "1 = Rogue Encampment",
            "2 = Blood Moor",
            "3 = Cold Plains",
            "4 = Stony Field",
            "5 = Dark Wood",
            "6 = Black Marsh",
            "7 = Tamoe Highland",
            "8 = Den Of Evil",
            "9 = Cave Level 1",
            "10 = Underground Passage Level 1",
            "11 = Hole Level 1",
            "12 = Pit Level 1",
            "13 = Cave Level 2",
            "14 = Underground Passage Level 2",
            "15 = Hole Level 2",
            "16 = Pit Level 2",
            "17 = Burial Grounds",
            "18 = Crypt",
            "19 = Mausoleum",
            "20 = Forgotten Tower",
            "21 = Tower Cellar Level 1",
            "22 = Tower Cellar Level 2",
            "23 = Tower Cellar Level 3",
            "24 = Tower Cellar Level 4",
            "25 = Tower Cellar Level 5",
            "26 = Monastery Gate",
            "27 = Outer Cloister",
            "28 = Barracks",
            "29 = Jail Level 1",
            "30 = Jail Level 2",
            "31 = Jail Level 3",
            "32 = Inner Cloister",
            "33 = Cathedral",
            "34 = Catacombs Level 1",
            "35 = Catacombs Level 2",
            "36 = Catacombs Level 3",
            "37 = Catacombs Level 4",
            "38 = Tristram",
            "39 = Moo Moo Farm",
            "40 = Lut Gholein",
            "41 = Rocky Waste",
            "42 = Dry Hills",
            "43 = Far Oasis",
            "44 = Lost City",
            "45 = Valley Of Snakes",
            "46 = Canyon Of The Magi",
            "47 = A2 Sewers Level 1",
            "48 = A2 Sewers Level 2",
            "49 = A2 Sewers Level 3",
            "50 = Harem Level 1",
            "51 = Harem Level 2",
            "52 = Palace Cellar Level 1",
            "53 = Palace Cellar Level 2",
            "54 = Palace Cellar Level 3",
            "55 = Stony Tomb Level 1",
            "56 = Halls Of The Dead Level 1",
            "57 = Halls Of The Dead Level 2",
            "58 = Claw Viper Temple Level 1",
            "59 = Stony Tomb Level 2",
            "60 = Halls Of The Dead Level 3",
            "61 = Claw Viper Temple Level 2",
            "62 = Maggot Lair Level 1",
            "63 = Maggot Lair Level 2",
            "64 = Maggot Lair Level 3",
            "65 = Ancient Tunnels",
            "66 = Tal Rashas Tomb #1",
            "67 = Tal Rashas Tomb #2",
            "68 = Tal Rashas Tomb #3",
            "69 = Tal Rashas Tomb #4",
            "70 = Tal Rashas Tomb #5",
            "71 = Tal Rashas Tomb #6",
            "72 = Tal Rashas Tomb #7",
            "73 = Duriels Lair",
            "74 = Arcane Sanctuary",
            "75 = Kurast Docktown",
            "76 = Spider Forest",
            "77 = Great Marsh",
            "78 = Flayer Jungle",
            "79 = Lower Kurast",
            "80 = Kurast Bazaar",
            "81 = Upper Kurast",
            "82 = Kurast Causeway",
            "83 = Travincal",
            "84 = Spider Cave",
            "85 = Spider Cavern",
            "86 = Swampy Pit Level 1",
            "87 = Swampy Pit Level 2",
            "88 = Flayer Dungeon Level 1",
            "89 = Flayer Dungeon Level 2",
            "90 = Swampy Pit Level 3",
            "91 = Flayer Dungeon Level 3",
            "92 = A3 Sewers Level 1",
            "93 = A3 Sewers Level 2",
            "94 = Ruined Temple",
            "95 = Disused Fane",
            "96 = Forgotten Reliquary",
            "97 = Forgotten Temple",
            "98 = Ruined Fane",
            "99 = Disused Reliquary",
            "100 = Durance Of Hate Level 1",
            "101 = Durance Of Hate Level 2",
            "102 = Durance Of Hate Level 3",
            "103 = The Pandemonium Fortress",
            "104 = Outer Steppes",
            "105 = Plains Of Despair",
            "106 = City Of The Damned",
            "107 = River Of Flame",
            "108 = Chaos Sanctuary",
            "109 = Harrogath",
            "110 = Bloody Foothills",
            "111 = Frigid Highlands",
            "112 = Arreat Plateau",
            "113 = Crystalized Passage",
            "114 = Frozen River",
            "115 = Glacial Trail",
            "116 = Drifter Cavern",
            "117 = Frozen Tundra",
            "118 = Ancient\'s Way",
            "119 = Icy Cellar",
            "120 = Arreat Summit",
            "121 = Nihlathaks Temple",
            "122 = Halls Of Anguish",
            "123 = Halls Of Pain",
            "124 = Halls Of Vaught",
            "125 = Abaddon",
            "126 = Pit Of Acheron",
            "127 = Infernal Pit",
            "128 = The Worldstone Keep Level 1",
            "129 = The Worldstone Keep Level 2",
            "130 = The Worldstone Keep Level 3",
            "131 = Throne Of Destruction",
            "132 = The Worldstone Chamber",
            "133 = Matron\'s Den",
            "134 = Fogotten Sands",
            "135 = Furnace of Pain",
            "136 = Tristram"});
            this.listBox1.Location = new System.Drawing.Point(669, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(230, 550);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1767, 996);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

