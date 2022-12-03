using lab2;

Console.WriteLine("Запуск");

var path = "result.csv";

string processorModel = "Intel(R) Core(TM) i5-7200U CPU @ 2.50GHz";
Optimisations optimisations = Optimisations.NoOptimized;
string task = "matrix_multiply";
string timer = "stopwatch";

var random = new Random();
var csvWriter = new CsvWriter();
var metricsCalculator = new MetricsCalculator();

Console.WriteLine("Тестирование целочисленное");

var testerInt = new Tester<int>();
var resultsInt = testerInt.DoMeasurements(100, 200, () => random.Next() % 1000);
Console.WriteLine("Расчёт метрик");
var measurementResultsInt = metricsCalculator.CalculateMetrics(
    resultsInt, processorModel, optimisations, task, timer, "int");
Console.WriteLine("Запись результатов");
csvWriter.Write(measurementResultsInt, ";", path);

Console.WriteLine("Тестирование чисел с плавающей точкой");

var testerFloat = new Tester<float>();
var resultsFloat = testerFloat.DoMeasurements(100, 200, () => random.Next() % 1000);
Console.WriteLine("Расчёт метрик");
var measurementResultsFloat = metricsCalculator.CalculateMetrics(
    resultsFloat, processorModel, optimisations, task, timer, "float");
Console.WriteLine("Запись результатов");
csvWriter.Write(measurementResultsFloat, ";", path);

Console.WriteLine("Тестирование чисел с плавающей точкой двойной точности");

var testerDouble = new Tester<double>();
var resultsDouble = testerDouble.DoMeasurements(100, 200, () => random.Next() % 1000);
Console.WriteLine("Расчёт метрик");
var measurementResultsDouble = metricsCalculator.CalculateMetrics(
    resultsDouble, processorModel, optimisations, task, timer, "double");
Console.WriteLine("Запись результатов");
csvWriter.Write(measurementResultsDouble, ";", path);

Console.WriteLine("Конец тестирования");