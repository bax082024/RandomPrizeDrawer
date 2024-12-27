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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBoxParticipant = new TextBox();
            textBoxPrize = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(textBoxPrize);
            panel1.Controls.Add(textBoxParticipant);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1122, 710);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(326, 320);
            button1.Name = "button1";
            button1.Size = new Size(100, 32);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
          
            // 
            // button2
            // 
            button2.Location = new Point(326, 358);
            button2.Name = "button2";
            button2.Size = new Size(100, 32);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(326, 396);
            button3.Name = "button3";
            button3.Size = new Size(100, 32);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(326, 434);
            button4.Name = "button4";
            button4.Size = new Size(100, 32);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(326, 472);
            button5.Name = "button5";
            button5.Size = new Size(100, 32);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(326, 510);
            button6.Name = "button6";
            button6.Size = new Size(100, 32);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // textBoxParticipant
            // 
            textBoxParticipant.Location = new Point(536, 295);
            textBoxParticipant.Name = "textBoxParticipant";
            textBoxParticipant.Size = new Size(100, 23);
            textBoxParticipant.TabIndex = 6;
            // 
            // textBoxPrize
            // 
            textBoxPrize.Location = new Point(538, 339);
            textBoxPrize.Name = "textBoxPrize";
            textBoxPrize.Size = new Size(100, 23);
            textBoxPrize.TabIndex = 7;
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
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBoxPrize;
        private TextBox textBoxParticipant;
    }
}
