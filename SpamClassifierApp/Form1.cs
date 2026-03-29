using System;
using System.Windows.Forms;

namespace SpamClassifierApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                // Train the model immediately when the form loads
                // Note: This might take a few seconds depending on your CSV size
                MLModel.Train();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error training model: {ex.Message}\n\nMake sure 'spam.csv' is in your debug folder!", "Training Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text)) return;

            try
            {
                var result = MLModel.Predict(txtInput.Text);

                // LOGIC: In ML.NET, a Score > 0 usually means the positive class (Spam)
                bool isSpam = result.Prediction;

                // If it's still giving Ham incorrectly, we use the Score threshold:
                // bool isSpam = result.Score > 0;

                lblResult.Text = $"Result: {(isSpam ? "🚨 SPAM" : "✅ HAM (Safe)")}";
                lblConfidence.Text = $"Probability: {result.Probability:P2}";
                lblResult.ForeColor = isSpam ? System.Drawing.Color.Red : System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}