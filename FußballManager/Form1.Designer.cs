namespace FußballManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PlayerInput = new TextBox();
            HinzuButton = new Button();
            PlayerList = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Mannschaftsname = new Label();
            Spielername = new Label();
            Alter = new Label();
            Position = new Label();
            MannschaftInput = new TextBox();
            AlterInput = new TextBox();
            PositionInput = new TextBox();
            LöschenButton = new Button();
            SpeicherButton = new Button();
            BearbeitenButton = new Button();
            label5 = new Label();
            label6 = new Label();
            Transferwert = new Label();
            TransferwertInput = new TextBox();
            LänderspieleToreInput = new TextBox();
            GrößeInput = new TextBox();
            label7 = new Label();
            LänderspieleTore = new Label();
            label8 = new Label();
            Größe = new Label();
            pictureBox1 = new PictureBox();
            BildHochladen = new Button();
            GeburtstagInput = new TextBox();
            StaatsangehörigkeitInput = new TextBox();
            GeburtsortInput = new TextBox();
            AktNationalspielerInput = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            AktNationalspieler = new Label();
            Staatsangehörigkeit = new Label();
            Geburtstag = new Label();
            Geburtsort = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PlayerInput
            // 
            PlayerInput.BackColor = Color.Ivory;
            PlayerInput.ForeColor = SystemColors.ControlText;
            PlayerInput.Location = new Point(11, 65);
            PlayerInput.Name = "PlayerInput";
            PlayerInput.PlaceholderText = "Hier Spielername eingeben!";
            PlayerInput.Size = new Size(407, 31);
            PlayerInput.TabIndex = 1;
            PlayerInput.TextChanged += PlayerInput_TextChanged;
            PlayerInput.KeyPress += PlayerInput_KeyPress;
            // 
            // HinzuButton
            // 
            HinzuButton.BackColor = Color.FromArgb(128, 128, 255);
            HinzuButton.ForeColor = SystemColors.ActiveCaptionText;
            HinzuButton.Location = new Point(10, 749);
            HinzuButton.Name = "HinzuButton";
            HinzuButton.Size = new Size(196, 53);
            HinzuButton.TabIndex = 4;
            HinzuButton.Text = "Hinzufügen";
            HinzuButton.UseVisualStyleBackColor = false;
            HinzuButton.Click += HinzuButton_Click;
            // 
            // PlayerList
            // 
            PlayerList.BackColor = Color.Ivory;
            PlayerList.FormattingEnabled = true;
            PlayerList.ItemHeight = 25;
            PlayerList.Location = new Point(424, 12);
            PlayerList.MultiColumn = true;
            PlayerList.Name = "PlayerList";
            PlayerList.Size = new Size(619, 854);
            PlayerList.TabIndex = 17;
            PlayerList.Click += PlayerList_SelectedValueChanged;
            PlayerList.SelectedIndexChanged += PlayerList_SelectedIndexChanged;
            PlayerList.SelectedValueChanged += PlayerList_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(1069, 87);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 9;
            label1.Text = "Mannschaft:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(1069, 112);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 10;
            label2.Text = "Spielername:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(1069, 212);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 11;
            label3.Text = "Alter:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(1069, 262);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 12;
            label4.Text = "Position:";
            label4.Click += label4_Click;
            // 
            // Mannschaftsname
            // 
            Mannschaftsname.AutoSize = true;
            Mannschaftsname.ForeColor = SystemColors.Window;
            Mannschaftsname.Location = new Point(1256, 87);
            Mannschaftsname.Name = "Mannschaftsname";
            Mannschaftsname.Size = new Size(0, 25);
            Mannschaftsname.TabIndex = 13;
            // 
            // Spielername
            // 
            Spielername.AutoSize = true;
            Spielername.ForeColor = SystemColors.Window;
            Spielername.Location = new Point(1256, 112);
            Spielername.Name = "Spielername";
            Spielername.Size = new Size(0, 25);
            Spielername.TabIndex = 14;
            // 
            // Alter
            // 
            Alter.AutoSize = true;
            Alter.ForeColor = SystemColors.Window;
            Alter.Location = new Point(1256, 212);
            Alter.Name = "Alter";
            Alter.Size = new Size(0, 25);
            Alter.TabIndex = 15;
            // 
            // Position
            // 
            Position.AutoSize = true;
            Position.ForeColor = SystemColors.Window;
            Position.Location = new Point(1256, 262);
            Position.Name = "Position";
            Position.Size = new Size(0, 25);
            Position.TabIndex = 16;
            // 
            // MannschaftInput
            // 
            MannschaftInput.BackColor = Color.Ivory;
            MannschaftInput.Location = new Point(11, 12);
            MannschaftInput.Name = "MannschaftInput";
            MannschaftInput.PlaceholderText = "Hier Mannschaftsname eingeben!";
            MannschaftInput.Size = new Size(407, 31);
            MannschaftInput.TabIndex = 0;
            MannschaftInput.KeyPress += MannschaftInput_KeyPress;
            // 
            // AlterInput
            // 
            AlterInput.BackColor = Color.Ivory;
            AlterInput.Location = new Point(10, 297);
            AlterInput.Name = "AlterInput";
            AlterInput.PlaceholderText = "Hier Alter eingeben!";
            AlterInput.Size = new Size(407, 31);
            AlterInput.TabIndex = 2;
            AlterInput.TextChanged += AlterInput_TextChanged;
            AlterInput.KeyPress += AlterInput_KeyPress;
            // 
            // PositionInput
            // 
            PositionInput.BackColor = Color.Ivory;
            PositionInput.Location = new Point(10, 407);
            PositionInput.Name = "PositionInput";
            PositionInput.PlaceholderText = "Hier Position eingeben!";
            PositionInput.Size = new Size(407, 31);
            PositionInput.TabIndex = 3;
            PositionInput.TextChanged += PositionInput_TextChanged;
            PositionInput.KeyPress += PositionInput_KeyPress;
            // 
            // LöschenButton
            // 
            LöschenButton.BackColor = Color.FromArgb(255, 128, 128);
            LöschenButton.Location = new Point(212, 808);
            LöschenButton.Name = "LöschenButton";
            LöschenButton.Size = new Size(206, 58);
            LöschenButton.TabIndex = 7;
            LöschenButton.Text = "Löschen";
            LöschenButton.UseVisualStyleBackColor = false;
            LöschenButton.Click += LöschenButton_Click;
            // 
            // SpeicherButton
            // 
            SpeicherButton.BackColor = Color.FromArgb(192, 255, 192);
            SpeicherButton.Location = new Point(212, 749);
            SpeicherButton.Name = "SpeicherButton";
            SpeicherButton.Size = new Size(206, 53);
            SpeicherButton.TabIndex = 5;
            SpeicherButton.Text = "Speichern";
            SpeicherButton.UseVisualStyleBackColor = false;
            SpeicherButton.Click += SpeicherButton_Click;
            SpeicherButton.KeyPress += SpeicherButton_KeyPress;
            // 
            // BearbeitenButton
            // 
            BearbeitenButton.BackColor = Color.FromArgb(255, 192, 128);
            BearbeitenButton.Location = new Point(11, 809);
            BearbeitenButton.Name = "BearbeitenButton";
            BearbeitenButton.Size = new Size(195, 58);
            BearbeitenButton.TabIndex = 6;
            BearbeitenButton.Text = "Bearbeiten";
            BearbeitenButton.UseVisualStyleBackColor = false;
            BearbeitenButton.Click += BearbeitenButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(1069, 30);
            label5.Name = "label5";
            label5.Size = new Size(258, 38);
            label5.TabIndex = 8;
            label5.Text = "Gewählter Spieler:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(1069, 287);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 18;
            label6.Text = "Marktwert:";
            label6.Click += label6_Click;
            // 
            // Transferwert
            // 
            Transferwert.AutoSize = true;
            Transferwert.ForeColor = SystemColors.ControlLight;
            Transferwert.Location = new Point(1256, 287);
            Transferwert.Name = "Transferwert";
            Transferwert.Size = new Size(0, 25);
            Transferwert.TabIndex = 19;
            // 
            // TransferwertInput
            // 
            TransferwertInput.BackColor = Color.Ivory;
            TransferwertInput.Location = new Point(11, 463);
            TransferwertInput.Name = "TransferwertInput";
            TransferwertInput.PlaceholderText = "Hier Marktwert eingeben!";
            TransferwertInput.Size = new Size(407, 31);
            TransferwertInput.TabIndex = 20;
            TransferwertInput.TextChanged += TransferwertInput_TextChanged;
            TransferwertInput.KeyPress += TransferwertInput_KeyPress;
            // 
            // LänderspieleToreInput
            // 
            LänderspieleToreInput.BackColor = Color.Ivory;
            LänderspieleToreInput.Location = new Point(10, 580);
            LänderspieleToreInput.Name = "LänderspieleToreInput";
            LänderspieleToreInput.PlaceholderText = "Hier Länderspiele/Tore eingeben!";
            LänderspieleToreInput.Size = new Size(407, 31);
            LänderspieleToreInput.TabIndex = 21;
            LänderspieleToreInput.KeyPress += LänderspieleToreInput_KeyPress;
            // 
            // GrößeInput
            // 
            GrößeInput.BackColor = Color.Ivory;
            GrößeInput.Location = new Point(11, 354);
            GrößeInput.Name = "GrößeInput";
            GrößeInput.PlaceholderText = "Hier Größe eingeben!";
            GrößeInput.Size = new Size(407, 31);
            GrößeInput.TabIndex = 22;
            GrößeInput.TextChanged += GrößeInput_TextChanged;
            GrößeInput.KeyPress += GrößeInput_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(1069, 337);
            label7.Name = "label7";
            label7.Size = new Size(154, 25);
            label7.TabIndex = 23;
            label7.Text = "Länderspiele/Tore:";
            // 
            // LänderspieleTore
            // 
            LänderspieleTore.AutoSize = true;
            LänderspieleTore.ForeColor = SystemColors.ControlLight;
            LänderspieleTore.Location = new Point(1256, 337);
            LänderspieleTore.Name = "LänderspieleTore";
            LänderspieleTore.Size = new Size(0, 25);
            LänderspieleTore.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlLight;
            label8.Location = new Point(1069, 237);
            label8.Name = "label8";
            label8.Size = new Size(64, 25);
            label8.TabIndex = 25;
            label8.Text = "Größe:";
            // 
            // Größe
            // 
            Größe.AutoSize = true;
            Größe.ForeColor = SystemColors.ControlLight;
            Größe.Location = new Point(1256, 237);
            Größe.Name = "Größe";
            Größe.Size = new Size(0, 25);
            Größe.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1049, 407);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(408, 412);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PlayerList_SelectedIndexChanged;
            // 
            // BildHochladen
            // 
            BildHochladen.BackColor = SystemColors.Desktop;
            BildHochladen.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            BildHochladen.FlatAppearance.BorderSize = 0;
            BildHochladen.FlatStyle = FlatStyle.Flat;
            BildHochladen.ForeColor = SystemColors.ControlLight;
            BildHochladen.Location = new Point(1049, 822);
            BildHochladen.Name = "BildHochladen";
            BildHochladen.Size = new Size(408, 45);
            BildHochladen.TabIndex = 28;
            BildHochladen.Text = "Bild Hochladen ";
            BildHochladen.UseVisualStyleBackColor = false;
            BildHochladen.Click += BildHochladen_Click;
            // 
            // GeburtstagInput
            // 
            GeburtstagInput.BackColor = Color.Ivory;
            GeburtstagInput.Location = new Point(10, 181);
            GeburtstagInput.Name = "GeburtstagInput";
            GeburtstagInput.PlaceholderText = "Hier Geburtstag eingeben!";
            GeburtstagInput.Size = new Size(407, 31);
            GeburtstagInput.TabIndex = 29;
            GeburtstagInput.TextChanged += textBox1_TextChanged;
            GeburtstagInput.KeyPress += GeburtstagInput_KeyPress;
            // 
            // StaatsangehörigkeitInput
            // 
            StaatsangehörigkeitInput.BackColor = Color.Ivory;
            StaatsangehörigkeitInput.Location = new Point(11, 121);
            StaatsangehörigkeitInput.Name = "StaatsangehörigkeitInput";
            StaatsangehörigkeitInput.PlaceholderText = "Hier Staatsangehörigkeit eingeben!";
            StaatsangehörigkeitInput.Size = new Size(407, 31);
            StaatsangehörigkeitInput.TabIndex = 30;
            StaatsangehörigkeitInput.KeyPress += StaatsangehörigkeitInput_KeyPress;
            // 
            // GeburtsortInput
            // 
            GeburtsortInput.BackColor = Color.Ivory;
            GeburtsortInput.Location = new Point(10, 237);
            GeburtsortInput.Name = "GeburtsortInput";
            GeburtsortInput.PlaceholderText = "Hier Geburtsort eingeben!";
            GeburtsortInput.Size = new Size(407, 31);
            GeburtsortInput.TabIndex = 31;
            GeburtsortInput.KeyPress += GeburtsortInput_KeyPress;
            // 
            // AktNationalspielerInput
            // 
            AktNationalspielerInput.BackColor = Color.Ivory;
            AktNationalspielerInput.Location = new Point(10, 521);
            AktNationalspielerInput.Name = "AktNationalspielerInput";
            AktNationalspielerInput.PlaceholderText = "Hier Akt. Nationalspieler eingeben!";
            AktNationalspielerInput.Size = new Size(407, 31);
            AktNationalspielerInput.TabIndex = 32;
            AktNationalspielerInput.KeyPress += AktNationalspielerInput_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ControlLight;
            label9.Location = new Point(1069, 137);
            label9.Name = "label9";
            label9.Size = new Size(172, 25);
            label9.TabIndex = 33;
            label9.Text = "Staatsangehörigkeit:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ControlLight;
            label10.Location = new Point(1069, 162);
            label10.Name = "label10";
            label10.Size = new Size(104, 25);
            label10.TabIndex = 34;
            label10.Text = "Geburtstag:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ControlLight;
            label11.Location = new Point(1069, 187);
            label11.Name = "label11";
            label11.Size = new Size(101, 25);
            label11.TabIndex = 35;
            label11.Text = "Geburtsort:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.ControlLight;
            label12.Location = new Point(1069, 312);
            label12.Name = "label12";
            label12.Size = new Size(169, 25);
            label12.TabIndex = 36;
            label12.Text = "Akt. Nationalspieler:";
            // 
            // AktNationalspieler
            // 
            AktNationalspieler.AutoSize = true;
            AktNationalspieler.ForeColor = SystemColors.ControlLight;
            AktNationalspieler.Location = new Point(1256, 312);
            AktNationalspieler.Name = "AktNationalspieler";
            AktNationalspieler.Size = new Size(0, 25);
            AktNationalspieler.TabIndex = 37;
            // 
            // Staatsangehörigkeit
            // 
            Staatsangehörigkeit.AutoSize = true;
            Staatsangehörigkeit.ForeColor = SystemColors.ControlLight;
            Staatsangehörigkeit.Location = new Point(1256, 137);
            Staatsangehörigkeit.Name = "Staatsangehörigkeit";
            Staatsangehörigkeit.Size = new Size(0, 25);
            Staatsangehörigkeit.TabIndex = 38;
            // 
            // Geburtstag
            // 
            Geburtstag.AutoSize = true;
            Geburtstag.ForeColor = SystemColors.ControlLight;
            Geburtstag.Location = new Point(1256, 162);
            Geburtstag.Name = "Geburtstag";
            Geburtstag.Size = new Size(0, 25);
            Geburtstag.TabIndex = 39;
            // 
            // Geburtsort
            // 
            Geburtsort.AutoSize = true;
            Geburtsort.ForeColor = SystemColors.ControlLight;
            Geburtsort.Location = new Point(1256, 187);
            Geburtsort.Name = "Geburtsort";
            Geburtsort.Size = new Size(0, 25);
            Geburtsort.TabIndex = 40;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1469, 874);
            Controls.Add(Geburtsort);
            Controls.Add(Geburtstag);
            Controls.Add(Staatsangehörigkeit);
            Controls.Add(AktNationalspieler);
            Controls.Add(LänderspieleTore);
            Controls.Add(label7);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(AktNationalspielerInput);
            Controls.Add(GeburtsortInput);
            Controls.Add(StaatsangehörigkeitInput);
            Controls.Add(GeburtstagInput);
            Controls.Add(BildHochladen);
            Controls.Add(pictureBox1);
            Controls.Add(Größe);
            Controls.Add(label8);
            Controls.Add(GrößeInput);
            Controls.Add(LänderspieleToreInput);
            Controls.Add(TransferwertInput);
            Controls.Add(Transferwert);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(BearbeitenButton);
            Controls.Add(SpeicherButton);
            Controls.Add(LöschenButton);
            Controls.Add(PositionInput);
            Controls.Add(AlterInput);
            Controls.Add(MannschaftInput);
            Controls.Add(Position);
            Controls.Add(Alter);
            Controls.Add(Spielername);
            Controls.Add(Mannschaftsname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PlayerList);
            Controls.Add(HinzuButton);
            Controls.Add(PlayerInput);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "FußballManager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PlayerInput;
        private Button HinzuButton;
        private ListBox PlayerList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Mannschaftsname;
        private Label Spielername;
        private Label Alter;
        private Label Position;
        private TextBox MannschaftInput;
        private TextBox AlterInput;
        private TextBox PositionInput;
        private Button LöschenButton;
        private Button SpeicherButton;
        private Button BearbeitenButton;
        private Label label5;
        private Label label6;
        private Label Transferwert;
        private TextBox TransferwertInput;
        private TextBox LänderspieleToreInput;
        private TextBox GrößeInput;
        private Label label7;
        private Label LänderspieleTore;
        private Label label8;
        private Label Größe;
        private PictureBox pictureBox1;
        private Button BildHochladen;
        private TextBox GeburtstagInput;
        private TextBox StaatsangehörigkeitInput;
        private TextBox GeburtsortInput;
        private TextBox AktNationalspielerInput;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label AktNationalspieler;
        private Label Staatsangehörigkeit;
        private Label Geburtstag;
        private Label Geburtsort;
    }
}
