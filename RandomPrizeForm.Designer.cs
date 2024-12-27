namespace RandomPrizeDrawer
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
            panel1 = new Panel();
            textBoxPrize = new TextBox();
            textBoxParticipant = new TextBox();
            buttonLoad = new Button();
            buttonSave = new Button();
            buttonReset = new Button();
            buttonDrawWinner = new Button();
            buttonAddPrize = new Button();
            buttonAddParticipant = new Button();
            listBoxParticipants = new ListBox();
            listBoxPrizes = new ListBox();
            listBoxWinners = new ListBox();
            lblTitel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTitel);
            panel1.Controls.Add(listBoxWinners);
            panel1.Controls.Add(listBoxPrizes);
            panel1.Controls.Add(listBoxParticipants);
            panel1.Controls.Add(textBoxPrize);
            panel1.Controls.Add(textBoxParticipant);
            panel1.Controls.Add(buttonLoad);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonReset);
            panel1.Controls.Add(buttonDrawWinner);
            panel1.Controls.Add(buttonAddPrize);
            panel1.Controls.Add(buttonAddParticipant);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 710);
            panel1.TabIndex = 0;
            // 
            // textBoxPrize
            // 
            textBoxPrize.Location = new Point(485, 489);
            textBoxPrize.Name = "textBoxPrize";
            textBoxPrize.Size = new Size(100, 23);
            textBoxPrize.TabIndex = 7;
            // 
            // textBoxParticipant
            // 
            textBoxParticipant.Location = new Point(483, 445);
            textBoxParticipant.Name = "textBoxParticipant";
            textBoxParticipant.Size = new Size(100, 23);
            textBoxParticipant.TabIndex = 6;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(281, 670);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(100, 32);
            buttonLoad.TabIndex = 5;
            buttonLoad.Text = "button6";
            buttonLoad.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(281, 632);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 32);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "button5";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(281, 594);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(100, 32);
            buttonReset.TabIndex = 3;
            buttonReset.Text = "button4";
            buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonDrawWinner
            // 
            buttonDrawWinner.Location = new Point(281, 556);
            buttonDrawWinner.Name = "buttonDrawWinner";
            buttonDrawWinner.Size = new Size(100, 32);
            buttonDrawWinner.TabIndex = 2;
            buttonDrawWinner.Text = "button3";
            buttonDrawWinner.UseVisualStyleBackColor = true;
            // 
            // buttonAddPrize
            // 
            buttonAddPrize.Location = new Point(281, 518);
            buttonAddPrize.Name = "buttonAddPrize";
            buttonAddPrize.Size = new Size(100, 32);
            buttonAddPrize.TabIndex = 1;
            buttonAddPrize.Text = "button2";
            buttonAddPrize.UseVisualStyleBackColor = true;
            // 
            // buttonAddParticipant
            // 
            buttonAddParticipant.Location = new Point(281, 480);
            buttonAddParticipant.Name = "buttonAddParticipant";
            buttonAddParticipant.Size = new Size(100, 32);
            buttonAddParticipant.TabIndex = 0;
            buttonAddParticipant.Text = "button1";
            buttonAddParticipant.UseVisualStyleBackColor = true;
            // 
            // listBoxParticipants
            // 
            listBoxParticipants.FormattingEnabled = true;
            listBoxParticipants.ItemHeight = 15;
            listBoxParticipants.Location = new Point(37, 174);
            listBoxParticipants.Name = "listBoxParticipants";
            listBoxParticipants.Size = new Size(151, 229);
            listBoxParticipants.TabIndex = 8;
            // 
            // listBoxPrizes
            // 
            listBoxPrizes.FormattingEnabled = true;
            listBoxPrizes.ItemHeight = 15;
            listBoxPrizes.Location = new Point(598, 174);
            listBoxPrizes.Name = "listBoxPrizes";
            listBoxPrizes.Size = new Size(151, 229);
            listBoxPrizes.TabIndex = 9;
            // 
            // listBoxWinners
            // 
            listBoxWinners.FormattingEnabled = true;
            listBoxWinners.ItemHeight = 15;
            listBoxWinners.Location = new Point(221, 174);
            listBoxWinners.Name = "listBoxWinners";
            listBoxWinners.Size = new Size(339, 229);
            listBoxWinners.TabIndex = 10;
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Font = new Font("Ravie", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitel.ForeColor = Color.Black;
            lblTitel.Location = new Point(22, 22);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(752, 63);
            lblTitel.TabIndex = 11;
            lblTitel.Text = "Random price Drawer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(64, 144);
            label1.Name = "label1";
            label1.Size = new Size(81, 17);
            label1.TabIndex = 12;
            label1.Text = "Participants";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(645, 144);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 13;
            label2.Text = "Prizes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(342, 130);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 14;
            label3.Text = "Winners !";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(790, 710);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlDark;
            Name = "Form1";
            Text = "Random Prize Drawer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonLoad;
        private Button buttonSave;
        private Button buttonReset;
        private Button buttonDrawWinner;
        private Button buttonAddPrize;
        private Button buttonAddParticipant;
        private TextBox textBoxPrize;
        private TextBox textBoxParticipant;
        private ListBox listBoxWinners;
        private ListBox listBoxPrizes;
        private ListBox listBoxParticipants;
        private Label lblTitel;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
