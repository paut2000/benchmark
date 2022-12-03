using System.Text;

namespace lab2;

public class CsvWriter
{
    public void Write(List<MeasurementResult> results, string delimiter ,string path)
    {
        if (!File.Exists(path))
        {
            using var streamWriter = File.CreateText(path);
            streamWriter.Write(CreateStructure(results, delimiter));
        }
        else
        {
            using var streamWriter = File.AppendText(path);
            streamWriter.Write(CreateStructure(results, delimiter));
        }
    }

    private string CreateStructure(List<MeasurementResult> results, string delimiter)
    {
        var csv = new StringBuilder();

        results.ForEach(result =>
        {
            csv.Append(result.ProcessorModel).Append(delimiter)
                .Append(result.Task).Append(delimiter)
                .Append(result.OperandType).Append(delimiter)
                .Append(result.Optimisations).Append(delimiter)
                .Append(result.InstructionCount).Append(delimiter)
                .Append(result.Timer).Append(delimiter)
                .Append(result.Time).Append(delimiter)
                .Append(result.LaunchNumer).Append(delimiter)
                .Append(result.AverageTime).Append(delimiter)
                .Append(result.AbsoluteError).Append(delimiter)
                .Append(result.RelativeError).Append(delimiter)
                .Append(result.TaskPerformance).AppendLine();
        });

        return csv.ToString();
    }
}