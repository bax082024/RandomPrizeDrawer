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
    }
}
