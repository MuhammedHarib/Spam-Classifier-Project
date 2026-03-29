using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.Windows.Forms;

public class MLModel
{
    private static readonly MLContext context = new MLContext();
    private static ITransformer model;
    private static PredictionEngine<EmailData, EmailPrediction> predictor;

    public static void Train()
    {
        try
        {
            // 1. Load Data
            var data = context.Data.LoadFromTextFile<EmailData>(
                path: "spam.csv",
                hasHeader: false,
                separatorChar: '\t', // Your file uses Tabs
                allowQuoting: true
            );

            // 2. Build Pipeline
            // STEP A: Convert the "0"/"1" text column into a Boolean Label
            // STEP B: Turn the Email Text into numeric "Features"
            // STEP C: Add the Trainer
            var pipeline = context.Transforms.Conversion.ConvertType("Label", "Label", DataKind.Boolean)
                .Append(context.Transforms.Text.FeaturizeText("Features", nameof(EmailData.Text)))
                .Append(context.BinaryClassification.Trainers.SdcaLogisticRegression(labelColumnName: "Label", featureColumnName: "Features"));

            // 3. Split data
            var splitData = context.Data.TrainTestSplit(data, testFraction: 0.2);

            // 4. Train the model
            model = pipeline.Fit(splitData.TrainSet);

            // 5. Create the predictor
            predictor = context.Model.CreatePredictionEngine<EmailData, EmailPrediction>(model);

            // 6. Evaluate
            var predictions = model.Transform(splitData.TestSet);
            var metrics = context.BinaryClassification.Evaluate(predictions);

            MessageBox.Show($"Model Trained!\nAccuracy: {metrics.Accuracy:P2}");
        }
        catch (Exception ex)
        {
            // If it still says Schema Mismatch, it means column 1 is empty. 
            // Ensure your CSV has no empty lines at the bottom!
            MessageBox.Show($"Error: {ex.Message}");
        }
    }

    public static EmailPrediction Predict(string text)
    {
        if (predictor == null) throw new Exception("Train model first!");
        return predictor.Predict(new EmailData { Text = text });
    }
}