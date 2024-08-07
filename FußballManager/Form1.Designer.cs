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
            SuspendLayout();
            // 
            // PlayerInput
            // 
            PlayerInput.BackColor = Color.Ivory;
            PlayerInput.ForeColor = SystemColors.ControlText;
            PlayerInput.Location = new Point(8, 39);
            PlayerInput.Margin = new Padding(2, 2, 2, 2);
            PlayerInput.Name = "PlayerInput";
            PlayerInput.PlaceholderText = "Hier Spielername eingeben!";
            PlayerInput.Size = new Size(217, 23);
            PlayerInput.TabIndex = 1;
            PlayerInput.TextChanged += PlayerInput_TextChanged;
            PlayerInput.KeyPress += PlayerInput_KeyPress;
            // 
            // HinzuButton
            // 
            HinzuButton.BackColor = Color.FromArgb(128, 128, 255);
            HinzuButton.ForeColor = SystemColors.ActiveCaptionText;
            HinzuButton.Location = new Point(8, 134);
            HinzuButton.Margin = new Padding(2, 2, 2, 2);
            HinzuButton.Name = "HinzuButton";
            HinzuButton.Size = new Size(105, 20);
            HinzuButton.TabIndex = 4;
            HinzuButton.Text = "Hinzufügen";
            HinzuButton.UseVisualStyleBackColor = false;
            HinzuButton.Click += HinzuButton_Click;
            // 
            // PlayerList
            // 
            PlayerList.BackColor = Color.Ivory;
            PlayerList.FormattingEnabled = true;
            PlayerList.ItemHeight = 15;
            PlayerList.Location = new Point(228, 7);
            PlayerList.Margin = new Padding(2, 2, 2, 2);
            PlayerList.MultiColumn = true;
            PlayerList.Name = "PlayerList";
            PlayerList.Size = new Size(874, 604);
            PlayerList.TabIndex = 17;
            PlayerList.SelectedIndexChanged += PlayerList_SelectedIndexChanged;
            PlayerList.SelectedValueChanged += PlayerList_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(8, 239);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 9;
            label1.Text = "Mannschaft:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(8, 262);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 10;
            label2.Text = "Spielername:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(8, 286);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 11;
            label3.Text = "Alter:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(8, 308);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 12;
            label4.Text = "Position:";
            label4.Click += label4_Click;
            // 
            // Mannschaftsname
            // 
            Mannschaftsname.AutoSize = true;
            Mannschaftsname.ForeColor = SystemColors.Window;
            Mannschaftsname.Location = new Point(94, 239);
            Mannschaftsname.Margin = new Padding(2, 0, 2, 0);
            Mannschaftsname.Name = "Mannschaftsname";
            Mannschaftsname.Size = new Size(0, 15);
            Mannschaftsname.TabIndex = 13;
            // 
            // Spielername
            // 
            Spielername.AutoSize = true;
            Spielername.ForeColor = SystemColors.Window;
            Spielername.Location = new Point(94, 262);
            Spielername.Margin = new Padding(2, 0, 2, 0);
            Spielername.Name = "Spielername";
            Spielername.Size = new Size(0, 15);
            Spielername.TabIndex = 14;
            // 
            // Alter
            // 
            Alter.AutoSize = true;
            Alter.ForeColor = SystemColors.Window;
            Alter.Location = new Point(94, 286);
            Alter.Margin = new Padding(2, 0, 2, 0);
            Alter.Name = "Alter";
            Alter.Size = new Size(0, 15);
            Alter.TabIndex = 15;
            // 
            // Position
            // 
            Position.AutoSize = true;
            Position.ForeColor = SystemColors.Window;
            Position.Location = new Point(94, 308);
            Position.Margin = new Padding(2, 0, 2, 0);
            Position.Name = "Position";
            Position.Size = new Size(0, 15);
            Position.TabIndex = 16;
            // 
            // MannschaftInput
            // 
            MannschaftInput.BackColor = Color.Ivory;
            MannschaftInput.Location = new Point(8, 7);
            MannschaftInput.Margin = new Padding(2, 2, 2, 2);
            MannschaftInput.Name = "MannschaftInput";
            MannschaftInput.PlaceholderText = "Hier Mannschaftsname eingeben!";
            MannschaftInput.Size = new Size(217, 23);
            MannschaftInput.TabIndex = 0;
            MannschaftInput.KeyPress += MannschaftInput_KeyPress;
            // 
            // AlterInput
            // 
            AlterInput.BackColor = Color.Ivory;
            AlterInput.Location = new Point(8, 69);
            AlterInput.Margin = new Padding(2, 2, 2, 2);
            AlterInput.Name = "AlterInput";
            AlterInput.PlaceholderText = "Hier Alter eingeben!";
            AlterInput.Size = new Size(217, 23);
            AlterInput.TabIndex = 2;
            AlterInput.TextChanged += AlterInput_TextChanged;
            AlterInput.KeyPress += AlterInput_KeyPress;
            // 
            // PositionInput
            // 
            PositionInput.BackColor = Color.Ivory;
            PositionInput.Location = new Point(8, 101);
            PositionInput.Margin = new Padding(2, 2, 2, 2);
            PositionInput.Name = "PositionInput";
            PositionInput.PlaceholderText = "Hier Position eingeben!";
            PositionInput.Size = new Size(217, 23);
            PositionInput.TabIndex = 3;
            PositionInput.TextChanged += PositionInput_TextChanged;
            PositionInput.KeyPress += PositionInput_KeyPress;
            // 
            // LöschenButton
            // 
            LöschenButton.BackColor = Color.FromArgb(255, 128, 128);
            LöschenButton.Location = new Point(118, 158);
            LöschenButton.Margin = new Padding(2, 2, 2, 2);
            LöschenButton.Name = "LöschenButton";
            LöschenButton.Size = new Size(106, 20);
            LöschenButton.TabIndex = 7;
            LöschenButton.Text = "Löschen";
            LöschenButton.UseVisualStyleBackColor = false;
            LöschenButton.Click += LöschenButton_Click;
            // 
            // SpeicherButton
            // 
            SpeicherButton.BackColor = Color.FromArgb(192, 255, 192);
            SpeicherButton.Location = new Point(118, 134);
            SpeicherButton.Margin = new Padding(2, 2, 2, 2);
            SpeicherButton.Name = "SpeicherButton";
            SpeicherButton.Size = new Size(106, 20);
            SpeicherButton.TabIndex = 5;
            SpeicherButton.Text = "Speichern";
            SpeicherButton.UseVisualStyleBackColor = false;
            SpeicherButton.Click += SpeicherButton_Click;
            SpeicherButton.KeyPress += SpeicherButton_KeyPress;
            // 
            // BearbeitenButton
            // 
            BearbeitenButton.BackColor = Color.FromArgb(255, 192, 128);
            BearbeitenButton.Location = new Point(8, 158);
            BearbeitenButton.Margin = new Padding(2, 2, 2, 2);
            BearbeitenButton.Name = "BearbeitenButton";
            BearbeitenButton.Size = new Size(105, 20);
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
            label5.Location = new Point(8, 206);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(174, 25);
            label5.TabIndex = 8;
            label5.Text = "Gewählter Spieler:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1113, 616);
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "FußballManager";
            Load += Form1_Load;
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
    }
}
