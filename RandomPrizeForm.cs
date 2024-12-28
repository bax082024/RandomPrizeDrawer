namespace RandomPrizeDrawer
{
    public partial class RandomPrizeForm : Form
    {
        private const string SessionFilePath = "session.json";


        public RandomPrizeForm()
        {
            InitializeComponent();
           
            listBoxParticipants.AllowDrop = true;
            listBoxPrizes.AllowDrop = true;

            listBoxParticipants.DragEnter += ListBoxParticipants_DragEnter;
            listBoxParticipants.DragDrop += ListBoxParticipants_DragDrop;

            listBoxPrizes.DragEnter += ListBoxPrizes_DragEnter;
            listBoxPrizes.DragDrop += ListBoxPrizes_DragDrop;
        }

        private void buttonAddParticipant_Click(object sender, EventArgs e)
        {
            string participant = textBoxParticipant.Text.Trim();

            if (string.IsNullOrEmpty(participant))
            {
                MessageBox.Show("Please enter a participant name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listBoxParticipants.Items.Contains(participant))
            {
                MessageBox.Show("This participant is already in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listBoxParticipants.Items.Add(participant);
            textBoxParticipant.Clear();
        }

        private void buttonAddPrize_Click(object sender, EventArgs e)
        {
            string prize = textBoxPrize.Text.Trim();

            if (string.IsNullOrEmpty(prize))
            {
                MessageBox.Show("Please enter a prize name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listBoxPrizes.Items.Contains(prize))
            {
                MessageBox.Show("This prize is already in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listBoxPrizes.Items.Add(prize);
            textBoxPrize.Clear();
        }

        private void buttonDrawWinner_Click(object sender, EventArgs e)
        {
            if (listBoxParticipants.Items.Count == 0 || listBoxPrizes.Items.Count == 0)
            {
                MessageBox.Show("Please make sure both participants and prizes are available before drawing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Random random = new Random();

            int participantIndex = random.Next(listBoxParticipants.Items.Count);
            int prizeIndex = random.Next(listBoxPrizes.Items.Count);

            string selectedParticipant = listBoxParticipants.Items[participantIndex].ToString();
            string selectedPrize = listBoxPrizes.Items[prizeIndex].ToString();

            listBoxWinners.Items.Add($"{selectedParticipant} wins {selectedPrize}!");

            listBoxParticipants.Items.RemoveAt(participantIndex);
            listBoxPrizes.Items.RemoveAt(prizeIndex);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            listBoxParticipants.Items.Clear();
            listBoxPrizes.Items.Clear();
            listBoxWinners.Items.Clear();
            textBoxParticipant.Clear();
            textBoxPrize.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var session = new
                {
                    Participants = listBoxParticipants.Items.Cast<string>().ToList(),
                    Prizes = listBoxPrizes.Items.Cast<string>().ToList(),
                    Winners = listBoxWinners.Items.Cast<string>().ToList()
                };

                string json = System.Text.Json.JsonSerializer.Serialize(session, new System.Text.Json.JsonSerializerOptions
                {
                    WriteIndented = true
                });

                File.WriteAllText("session.json", json);
                MessageBox.Show("Session saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save session: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(SessionFilePath))
                {
                    MessageBox.Show("No saved session found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string json = File.ReadAllText(SessionFilePath);
                var sessionData = System.Text.Json.JsonSerializer.Deserialize<SessionData>(json);

                if (sessionData != null)
                {
                    listBoxParticipants.Items.Clear();
                    listBoxPrizes.Items.Clear();
                    listBoxWinners.Items.Clear();

                    foreach (var participant in sessionData.Participants ?? new List<string>())
                    {
                        listBoxParticipants.Items.Add(participant);
                    }

                    foreach (var prize in sessionData.Prizes ?? new List<string>())
                    {
                        listBoxPrizes.Items.Add(prize);
                    }

                    foreach (var winner in sessionData.Winners ?? new List<string>())
                    {
                        listBoxWinners.Items.Add(winner);
                    }

                    MessageBox.Show("Session loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to parse session data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load session: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private class SessionData
        {
            public List<string>? Participants { get; set; }
            public List<string>? Winners { get; set; }
            public List<string>? Prizes { get; set; }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                this.ClientRectangle,
                Color.LightSkyBlue,  // Top color
                Color.Orange,        // Bottom color
                System.Drawing.Drawing2D.LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            using (Pen borderPen = new Pen(Color.DarkSlateGray, 2))
            {
                e.Graphics.DrawRectangle(borderPen,
                    listBoxParticipants.Left - 5, listBoxParticipants.Top - 5,
                    listBoxParticipants.Width + 10, listBoxParticipants.Height + 10);

                e.Graphics.DrawRectangle(borderPen,
                    listBoxWinners.Left - 5, listBoxWinners.Top - 5,
                    listBoxWinners.Width + 10, listBoxWinners.Height + 10);

                e.Graphics.DrawRectangle(borderPen,
                    listBoxPrizes.Left - 5, listBoxPrizes.Top - 5,
                    listBoxPrizes.Width + 10, listBoxPrizes.Height + 10);
            }
        }

        private void ListBoxParticipants_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                // Only allow text files
                if (files.All(file => file.EndsWith(".txt", StringComparison.OrdinalIgnoreCase)))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }






    }

}
