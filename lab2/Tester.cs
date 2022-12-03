using System.Diagnostics;
using System.Numerics;

namespace lab2;

public class Tester<T> where T : INumber<T>
{
    private readonly Stopwatch _stopwatch = new();

    public double DoMeasurement(int rows, int columns, Func<T> rand)
    {
        _stopwatch.Start();
        
        var a = MatrixOperation<T>.Generate(rows, columns, rand);
        var b = MatrixOperation<T>.Generate(rows, columns, rand);
        var c = MatrixOperation<T>.Multiply(a, b);
        
        _stopwatch.Stop();
        var totalSeconds = _stopwatch.Elapsed.TotalSeconds;
        _stopwatch.Reset();
        return totalSeconds;
    }

    public double[] DoMeasurements(int n, int arraySize, Func<T> rand)
    {
        var measurements = new double[n];
        for (int i = 0; i < n; i++)
        {
            measurements[i] = DoMeasurement(arraySize, arraySize, rand);
        }

        return measurements;
    }
}