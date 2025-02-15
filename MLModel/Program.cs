using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.IO;

class FAQPrediction
{
    // Use Path.Combine for flexible file path handling
    private static readonly string dataPath = Path.Combine(AppContext.BaseDirectory, @"..\..\..\Data\faq_data.tsv");

    static void Main(string[] args)
    {
        // Verify if dataset file exists
        if (!File.Exists(dataPath))
        {
            Console.WriteLine("Dataset file not found. Please check the path or file location.");
            return;
        }

        Console.WriteLine($"Loading data from: {Path.GetFullPath(dataPath)}");

        var context = new MLContext();

        // Load data
        var data = context.Data.LoadFromTextFile<InputData>(
            dataPath,
            hasHeader: false,
            separatorChar: '\t');

        // Define pipeline
        var pipeline = context.Transforms.Text.FeaturizeText("Features", nameof(InputData.Text))
            .Append(context.Transforms.Conversion.MapValueToKey("Label", nameof(InputData.Label)))
            .Append(context.MulticlassClassification.Trainers.SdcaMaximumEntropy())
            .Append(context.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

        // Train the model
        var model = pipeline.Fit(data);

        // Test and evaluate the model
        var predictions = model.Transform(data);
        var metrics = context.MulticlassClassification.Evaluate(predictions);

        Console.WriteLine($"Log-loss: {metrics.LogLoss}");

        // Save the trained model
        context.Model.Save(model, data.Schema, "faq_classifier_model.zip");

        Console.WriteLine("Model training complete.");
    }
}

public class InputData
{
    [LoadColumn(0)]
    public string Label { get; set; }

    [LoadColumn(1)]
    public string Text { get; set; }
}
