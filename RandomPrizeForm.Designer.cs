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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
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
            panel1.Size = new Size(1122, 710);
            panel1.TabIndex = 0;
            // 
            // textBoxPrize
            // 
            textBoxPrize.Location = new Point(538, 339);
            textBoxPrize.Name = "textBoxPrize";
            textBoxPrize.Size = new Size(100, 23);
            textBoxPrize.TabIndex = 7;
            // 
            // textBoxParticipant
            // 
            textBoxParticipant.Location = new Point(536, 295);
            textBoxParticipant.Name = "textBoxParticipant";
            textBoxParticipant.Size = new Size(100, 23);
            textBoxParticipant.TabIndex = 6;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(326, 510);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(100, 32);
            buttonLoad.TabIndex = 5;
            buttonLoad.Text = "button6";
            buttonLoad.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(326, 472);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 32);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "button5";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(326, 434);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(100, 32);
            buttonReset.TabIndex = 3;
            buttonReset.Text = "button4";
            buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonDrawWinner
            // 
            buttonDrawWinner.Location = new Point(326, 396);
            buttonDrawWinner.Name = "buttonDrawWinner";
            buttonDrawWinner.Size = new Size(100, 32);
            buttonDrawWinner.TabIndex = 2;
            buttonDrawWinner.Text = "button3";
            buttonDrawWinner.UseVisualStyleBackColor = true;
            // 
            // buttonAddPrize
            // 
            buttonAddPrize.Location = new Point(326, 358);
            buttonAddPrize.Name = "buttonAddPrize";
            buttonAddPrize.Size = new Size(100, 32);
            buttonAddPrize.TabIndex = 1;
            buttonAddPrize.Text = "button2";
            buttonAddPrize.UseVisualStyleBackColor = true;
            // 
            // buttonAddParticipant
            // 
            buttonAddParticipant.Location = new Point(326, 320);
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
            listBoxParticipants.Location = new Point(260, 93);
            listBoxParticipants.Name = "listBoxParticipants";
            listBoxParticipants.Size = new Size(120, 94);
            listBoxParticipants.TabIndex = 8;
            // 
            // listBoxPrizes
            // 
            listBoxPrizes.FormattingEnabled = true;
            listBoxPrizes.ItemHeight = 15;
            listBoxPrizes.Location = new Point(440, 104);
            listBoxPrizes.Name = "listBoxPrizes";
            listBoxPrizes.Size = new Size(120, 94);
            listBoxPrizes.TabIndex = 9;
            // 
            // listBoxWinners
            // 
            listBoxWinners.FormattingEnabled = true;
            listBoxWinners.ItemHeight = 15;
            listBoxWinners.Location = new Point(641, 117);
            listBoxWinners.Name = "listBoxWinners";
            listBoxWinners.Size = new Size(120, 94);
            listBoxWinners.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1122, 710);
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
    }
}
