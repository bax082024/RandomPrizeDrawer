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
    }
}
