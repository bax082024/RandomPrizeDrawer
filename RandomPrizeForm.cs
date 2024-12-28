namespace RandomPrizeDrawer
{
    public partial class RandomPrizeForm : Form
    {
        public RandomPrizeForm()
        {
            InitializeComponent();
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

            // Remove the participant and prize to avoid duplicates
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
                if (!File.Exists("session.json"))
                {
                    MessageBox.Show("No saved session found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string json = File.ReadAllText("session.json");
                var session = System.Text.Json.JsonSerializer.Deserialize<dynamic>(json);

                listBoxParticipants.Items.Clear();
                foreach (var participant in session.Participants)
                {
                    listBoxParticipants.Items.Add(participant);
                }

                listBoxPrizes.Items.Clear();
                foreach (var prize in session.Prizes)
                {
                    listBoxPrizes.Items.Add(prize);
                }

                listBoxWinners.Items.Clear();
                foreach (var winner in session.Winners)
                {
                    listBoxWinners.Items.Add(winner);
                }

                MessageBox.Show("Session loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void SaveSession()
        {
            try
            {
                var sessionData = new SessionData
                {
                    Participants = listBoxParticipants.Items.Cast<string>().ToList(),
                    Winners = listBoxWinners.Items.Cast<string>().ToList(),
                    Prizes = listBoxPrizes.Items.Cast<string>().ToList()
                };

                string json = System.Text.Json.JsonSerializer.Serialize(sessionData, new System.Text.Json.JsonSerializerOptions
                {
                    WriteIndented = true
                });

                File.WriteAllText(SessionFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save session: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
