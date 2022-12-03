namespace lab2;

public class MetricsCalculator
{
    public List<MeasurementResult> CalculateMetrics(
        double[] measurements, 
        string processorModel,
        Optimisations optimisations,
        string task,
        string timer,
        string operandType)
    {
        var measurementResults = new List<MeasurementResult>();
        var listMeasurements = measurements.ToList();
        
        var average = listMeasurements.Average();
        var instructionCount = (int) Math.Pow(listMeasurements.Count, 3);
        var taskPerformance = instructionCount / average;


        for (var i = 0; i < listMeasurements.Count; i++)
        {
            var absoluteError = Math.Abs(average - listMeasurements[i]);
            var relativeError = absoluteError / average;
            
            measurementResults.Add(new MeasurementResult()
            {
                LaunchNumer = i,
                AverageTime = average,
                InstructionCount = instructionCount,
                AbsoluteError = absoluteError,
                RelativeError = relativeError,
                TaskPerformance = taskPerformance,
                Time = listMeasurements[i],
                ProcessorModel = processorModel,
                Optimisations = optimisations,
                Task = task,
                Timer = timer,
                OperandType = operandType
            });
        }

        return measurementResults;
    }
}