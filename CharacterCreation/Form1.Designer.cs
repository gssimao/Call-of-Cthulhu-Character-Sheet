
namespace CharacterCreation
{
    partial class character
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
            this.components = new System.ComponentModel.Container();
            this.Name = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CharName = new System.Windows.Forms.TextBox();
            this.CharPlayer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CharOccupation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CharAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CharResidence = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CharBirthplace = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CharMaxHP = new System.Windows.Forms.TextBox();
            this.CharCurrentHP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Randomize = new System.Windows.Forms.Button();
            this.CharSTR = new System.Windows.Forms.TextBox();
            this.Label25 = new System.Windows.Forms.Label();
            this.CharDEX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CharPOW = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CharEDU = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CharAPP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CharCON = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CharMoveRate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CharINT = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CharSIZ = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CharFellowInv1 = new System.Windows.Forms.TextBox();
            this.CharFellowInv2 = new System.Windows.Forms.TextBox();
            this.CharFellowInvName1 = new System.Windows.Forms.TextBox();
            this.CharFellowInvName2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.CharFellowInvName4 = new System.Windows.Forms.TextBox();
            this.CharFellowInvName3 = new System.Windows.Forms.TextBox();
            this.CharFellowInv4 = new System.Windows.Forms.TextBox();
            this.CharFellowInv3 = new System.Windows.Forms.TextBox();
            this.CallDiceRoller = new System.Windows.Forms.Button();
            this.Male = new System.Windows.Forms.CheckBox();
            this.Female = new System.Windows.Forms.CheckBox();
            this.saveChar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(150, 35);
            this.Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(93, 25);
            this.Name.TabIndex = 0;
            this.Name.Text = "character";
            this.Name.Click += new System.EventHandler(this.Name_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CharName
            // 
            this.CharName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharName.Location = new System.Drawing.Point(256, 32);
            this.CharName.Margin = new System.Windows.Forms.Padding(6);
            this.CharName.Name = "CharName";
            this.CharName.Size = new System.Drawing.Size(394, 30);
            this.CharName.TabIndex = 2;
            this.CharName.TextChanged += new System.EventHandler(this.CharName_TextChanged);
            // 
            // CharPlayer
            // 
            this.CharPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharPlayer.Location = new System.Drawing.Point(256, 77);
            this.CharPlayer.Margin = new System.Windows.Forms.Padding(6);
            this.CharPlayer.Name = "CharPlayer";
            this.CharPlayer.Size = new System.Drawing.Size(394, 30);
            this.CharPlayer.TabIndex = 4;
            this.CharPlayer.TextChanged += new System.EventHandler(this.CharPlayer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player";
            // 
            // CharOccupation
            // 
            this.CharOccupation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharOccupation.Location = new System.Drawing.Point(140, 123);
            this.CharOccupation.Margin = new System.Windows.Forms.Padding(6);
            this.CharOccupation.Name = "CharOccupation";
            this.CharOccupation.Size = new System.Drawing.Size(166, 30);
            this.CharOccupation.TabIndex = 6;
            this.CharOccupation.TextChanged += new System.EventHandler(this.CharOccupation_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Occuation";
            // 
            // CharAge
            // 
            this.CharAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharAge.Location = new System.Drawing.Point(365, 171);
            this.CharAge.Margin = new System.Windows.Forms.Padding(6);
            this.CharAge.Name = "CharAge";
            this.CharAge.Size = new System.Drawing.Size(56, 30);
            this.CharAge.TabIndex = 8;
            this.CharAge.TextChanged += new System.EventHandler(this.CharAge_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Age";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sex";
            // 
            // CharResidence
            // 
            this.CharResidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharResidence.Location = new System.Drawing.Point(140, 171);
            this.CharResidence.Margin = new System.Windows.Forms.Padding(6);
            this.CharResidence.Name = "CharResidence";
            this.CharResidence.Size = new System.Drawing.Size(166, 30);
            this.CharResidence.TabIndex = 12;
            this.CharResidence.TextChanged += new System.EventHandler(this.CharResidence_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Residence";
            // 
            // CharBirthplace
            // 
            this.CharBirthplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharBirthplace.Location = new System.Drawing.Point(435, 123);
            this.CharBirthplace.Margin = new System.Windows.Forms.Padding(6);
            this.CharBirthplace.Name = "CharBirthplace";
            this.CharBirthplace.Size = new System.Drawing.Size(215, 30);
            this.CharBirthplace.TabIndex = 14;
            this.CharBirthplace.TextChanged += new System.EventHandler(this.CharBirthplace_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(325, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Birthplace";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 226);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Max HP";
            // 
            // CharMaxHP
            // 
            this.CharMaxHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharMaxHP.Location = new System.Drawing.Point(140, 226);
            this.CharMaxHP.Margin = new System.Windows.Forms.Padding(6);
            this.CharMaxHP.Name = "CharMaxHP";
            this.CharMaxHP.Size = new System.Drawing.Size(37, 30);
            this.CharMaxHP.TabIndex = 16;
            this.CharMaxHP.TextChanged += new System.EventHandler(this.CharMaxHP_TextChanged);
            // 
            // CharCurrentHP
            // 
            this.CharCurrentHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharCurrentHP.Location = new System.Drawing.Point(140, 263);
            this.CharCurrentHP.Margin = new System.Windows.Forms.Padding(6);
            this.CharCurrentHP.Name = "CharCurrentHP";
            this.CharCurrentHP.Size = new System.Drawing.Size(37, 30);
            this.CharCurrentHP.TabIndex = 17;
            this.CharCurrentHP.TextChanged += new System.EventHandler(this.CharCurrentHP_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 266);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Current HP";
            // 
            // Randomize
            // 
            this.Randomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Randomize.Location = new System.Drawing.Point(30, 26);
            this.Randomize.Margin = new System.Windows.Forms.Padding(6);
            this.Randomize.Name = "Randomize";
            this.Randomize.Size = new System.Drawing.Size(105, 42);
            this.Randomize.TabIndex = 19;
            this.Randomize.Text = "Randomize Investigator";
            this.Randomize.UseVisualStyleBackColor = true;
            this.Randomize.Click += new System.EventHandler(this.Randomize_Click);
            // 
            // CharSTR
            // 
            this.CharSTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharSTR.Location = new System.Drawing.Point(290, 223);
            this.CharSTR.Margin = new System.Windows.Forms.Padding(6);
            this.CharSTR.Name = "CharSTR";
            this.CharSTR.Size = new System.Drawing.Size(51, 30);
            this.CharSTR.TabIndex = 21;
            this.CharSTR.TextChanged += new System.EventHandler(this.CharSTR_TextChanged);
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label25.Location = new System.Drawing.Point(226, 226);
            this.Label25.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(52, 25);
            this.Label25.TabIndex = 20;
            this.Label25.Text = "STR";
            // 
            // CharDEX
            // 
            this.CharDEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharDEX.Location = new System.Drawing.Point(448, 223);
            this.CharDEX.Margin = new System.Windows.Forms.Padding(6);
            this.CharDEX.Name = "CharDEX";
            this.CharDEX.Size = new System.Drawing.Size(51, 30);
            this.CharDEX.TabIndex = 23;
            this.CharDEX.TextChanged += new System.EventHandler(this.CharDex_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(387, 226);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "DEX";
            // 
            // CharPOW
            // 
            this.CharPOW.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharPOW.Location = new System.Drawing.Point(599, 223);
            this.CharPOW.Margin = new System.Windows.Forms.Padding(6);
            this.CharPOW.Name = "CharPOW";
            this.CharPOW.Size = new System.Drawing.Size(51, 30);
            this.CharPOW.TabIndex = 25;
            this.CharPOW.TextChanged += new System.EventHandler(this.CharPow_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(535, 226);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "POW";
            // 
            // CharEDU
            // 
            this.CharEDU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharEDU.Location = new System.Drawing.Point(599, 265);
            this.CharEDU.Margin = new System.Windows.Forms.Padding(6);
            this.CharEDU.Name = "CharEDU";
            this.CharEDU.Size = new System.Drawing.Size(51, 30);
            this.CharEDU.TabIndex = 31;
            this.CharEDU.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(535, 268);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "EDU";
            // 
            // CharAPP
            // 
            this.CharAPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharAPP.Location = new System.Drawing.Point(448, 265);
            this.CharAPP.Margin = new System.Windows.Forms.Padding(6);
            this.CharAPP.Name = "CharAPP";
            this.CharAPP.Size = new System.Drawing.Size(51, 30);
            this.CharAPP.TabIndex = 29;
            this.CharAPP.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(387, 268);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 25);
            this.label12.TabIndex = 28;
            this.label12.Text = "APP";
            // 
            // CharCON
            // 
            this.CharCON.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharCON.Location = new System.Drawing.Point(290, 265);
            this.CharCON.Margin = new System.Windows.Forms.Padding(6);
            this.CharCON.Name = "CharCON";
            this.CharCON.Size = new System.Drawing.Size(51, 30);
            this.CharCON.TabIndex = 27;
            this.CharCON.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(226, 268);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 25);
            this.label13.TabIndex = 26;
            this.label13.Text = "CON";
            // 
            // CharMoveRate
            // 
            this.CharMoveRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharMoveRate.Location = new System.Drawing.Point(140, 304);
            this.CharMoveRate.Margin = new System.Windows.Forms.Padding(6);
            this.CharMoveRate.Name = "CharMoveRate";
            this.CharMoveRate.Size = new System.Drawing.Size(37, 30);
            this.CharMoveRate.TabIndex = 37;
            this.CharMoveRate.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(30, 304);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 25);
            this.label14.TabIndex = 36;
            this.label14.Text = "Move Rate";
            // 
            // CharINT
            // 
            this.CharINT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharINT.Location = new System.Drawing.Point(448, 307);
            this.CharINT.Margin = new System.Windows.Forms.Padding(6);
            this.CharINT.Name = "CharINT";
            this.CharINT.Size = new System.Drawing.Size(51, 30);
            this.CharINT.TabIndex = 35;
            this.CharINT.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(387, 310);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 25);
            this.label15.TabIndex = 34;
            this.label15.Text = "INT";
            // 
            // CharSIZ
            // 
            this.CharSIZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharSIZ.Location = new System.Drawing.Point(290, 307);
            this.CharSIZ.Margin = new System.Windows.Forms.Padding(6);
            this.CharSIZ.Name = "CharSIZ";
            this.CharSIZ.Size = new System.Drawing.Size(51, 30);
            this.CharSIZ.TabIndex = 33;
            this.CharSIZ.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(226, 310);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 25);
            this.label16.TabIndex = 32;
            this.label16.Text = "SIZ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 836);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(649, 196);
            this.richTextBox1.TabIndex = 38;
            this.richTextBox1.Text = "Notes";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(164, 554);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(319, 39);
            this.label17.TabIndex = 39;
            this.label17.Text = "Fellow Investigators";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // CharFellowInv1
            // 
            this.CharFellowInv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharFellowInv1.Location = new System.Drawing.Point(73, 654);
            this.CharFellowInv1.Margin = new System.Windows.Forms.Padding(6);
            this.CharFellowInv1.Name = "CharFellowInv1";
            this.CharFellowInv1.Size = new System.Drawing.Size(248, 30);
            this.CharFellowInv1.TabIndex = 40;
            // 
            // CharFellowInv2
            // 
            this.CharFellowInv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharFellowInv2.Location = new System.Drawing.Point(73, 696);
            this.CharFellowInv2.Margin = new System.Windows.Forms.Padding(6);
            this.CharFellowInv2.Name = "CharFellowInv2";
            this.CharFellowInv2.Size = new System.Drawing.Size(248, 30);
            this.CharFellowInv2.TabIndex = 41;
            // 
            // CharFellowInvName1
            // 
            this.CharFellowInvName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharFellowInvName1.Location = new System.Drawing.Point(348, 654);
            this.CharFellowInvName1.Margin = new System.Windows.Forms.Padding(6);
            this.CharFellowInvName1.Name = "CharFellowInvName1";
            this.CharFellowInvName1.Size = new System.Drawing.Size(248, 30);
            this.CharFellowInvName1.TabIndex = 42;
            // 
            // CharFellowInvName2
            // 
            this.CharFellowInvName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharFellowInvName2.Location = new System.Drawing.Point(348, 696);
            this.CharFellowInvName2.Margin = new System.Windows.Forms.Padding(6);
            this.CharFellowInvName2.Name = "CharFellowInvName2";
            this.CharFellowInvName2.Size = new System.Drawing.Size(248, 30);
            this.CharFellowInvName2.TabIndex = 43;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(167, 623);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 25);
            this.label18.TabIndex = 44;
            this.label18.Text = "Char.";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(440, 623);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 25);
            this.label19.TabIndex = 45;
            this.label19.Text = "Name";
            // 
            // CharFellowInvName4
            // 
            this.CharFellowInvName4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharFellowInvName4.Location = new System.Drawing.Point(348, 780);
            this.CharFellowInvName4.Margin = new System.Windows.Forms.Padding(6);
            this.CharFellowInvName4.Name = "CharFellowInvName4";
            this.CharFellowInvName4.Size = new System.Drawing.Size(248, 30);
            this.CharFellowInvName4.TabIndex = 49;
            // 
            // CharFellowInvName3
            // 
            this.CharFellowInvName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharFellowInvName3.Location = new System.Drawing.Point(348, 738);
            this.CharFellowInvName3.Margin = new System.Windows.Forms.Padding(6);
            this.CharFellowInvName3.Name = "CharFellowInvName3";
            this.CharFellowInvName3.Size = new System.Drawing.Size(248, 30);
            this.CharFellowInvName3.TabIndex = 48;
            // 
            // CharFellowInv4
            // 
            this.CharFellowInv4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharFellowInv4.Location = new System.Drawing.Point(73, 780);
            this.CharFellowInv4.Margin = new System.Windows.Forms.Padding(6);
            this.CharFellowInv4.Name = "CharFellowInv4";
            this.CharFellowInv4.Size = new System.Drawing.Size(248, 30);
            this.CharFellowInv4.TabIndex = 47;
            // 
            // CharFellowInv3
            // 
            this.CharFellowInv3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharFellowInv3.Location = new System.Drawing.Point(73, 738);
            this.CharFellowInv3.Margin = new System.Windows.Forms.Padding(6);
            this.CharFellowInv3.Name = "CharFellowInv3";
            this.CharFellowInv3.Size = new System.Drawing.Size(248, 30);
            this.CharFellowInv3.TabIndex = 46;
            // 
            // CallDiceRoller
            // 
            this.CallDiceRoller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CallDiceRoller.Location = new System.Drawing.Point(540, 307);
            this.CallDiceRoller.Margin = new System.Windows.Forms.Padding(6);
            this.CallDiceRoller.Name = "CallDiceRoller";
            this.CallDiceRoller.Size = new System.Drawing.Size(110, 30);
            this.CallDiceRoller.TabIndex = 50;
            this.CallDiceRoller.Text = "Dice Roller";
            this.CallDiceRoller.UseVisualStyleBackColor = true;
            this.CallDiceRoller.Click += new System.EventHandler(this.CallDiceRoller_Click);
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(586, 172);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(74, 29);
            this.Male.TabIndex = 51;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            this.Male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(481, 172);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(96, 29);
            this.Female.TabIndex = 52;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            this.Female.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // saveChar
            // 
            this.saveChar.Location = new System.Drawing.Point(30, 74);
            this.saveChar.Name = "saveChar";
            this.saveChar.Size = new System.Drawing.Size(105, 36);
            this.saveChar.TabIndex = 53;
            this.saveChar.Text = "Save";
            this.saveChar.UseVisualStyleBackColor = true;
            this.saveChar.Click += new System.EventHandler(this.saveChar_Click);
            // 
            // character
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 1061);
            this.Controls.Add(this.saveChar);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.CallDiceRoller);
            this.Controls.Add(this.CharFellowInvName4);
            this.Controls.Add(this.CharFellowInvName3);
            this.Controls.Add(this.CharFellowInv4);
            this.Controls.Add(this.CharFellowInv3);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.CharFellowInvName2);
            this.Controls.Add(this.CharFellowInvName1);
            this.Controls.Add(this.CharFellowInv2);
            this.Controls.Add(this.CharFellowInv1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.CharMoveRate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CharINT);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CharSIZ);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.CharEDU);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CharAPP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CharCON);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CharPOW);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CharDEX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CharSTR);
            this.Controls.Add(this.Label25);
            this.Controls.Add(this.Randomize);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CharCurrentHP);
            this.Controls.Add(this.CharMaxHP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CharBirthplace);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CharResidence);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CharAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CharOccupation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CharPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CharName);
            this.Controls.Add(this.Name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name.Text = "character";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.character_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox CharName;
        private System.Windows.Forms.TextBox CharPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CharOccupation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CharAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CharResidence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CharBirthplace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CharMaxHP;
        private System.Windows.Forms.TextBox CharCurrentHP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Randomize;
        private System.Windows.Forms.TextBox CharSTR;
        private System.Windows.Forms.Label Label25;
        private System.Windows.Forms.TextBox CharDEX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CharPOW;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CharEDU;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CharAPP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CharCON;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CharMoveRate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox CharINT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox CharSIZ;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox CharFellowInv1;
        private System.Windows.Forms.TextBox CharFellowInv2;
        private System.Windows.Forms.TextBox CharFellowInvName1;
        private System.Windows.Forms.TextBox CharFellowInvName2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox CharFellowInvName4;
        private System.Windows.Forms.TextBox CharFellowInvName3;
        private System.Windows.Forms.TextBox CharFellowInv4;
        private System.Windows.Forms.TextBox CharFellowInv3;
        private System.Windows.Forms.Button CallDiceRoller;
        private System.Windows.Forms.CheckBox Male;
        private System.Windows.Forms.CheckBox Female;
        private System.Windows.Forms.Button saveChar;
    }
}

