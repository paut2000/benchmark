namespace lab2;

public record MeasurementResult
{
    public string ProcessorModel { get; init; } // Модель процессора, на котором проводятся испытания
    public string Task { get; init; } // Название выбранной типовой задачи
    public string OperandType { get; init; } // Тип операндов используемых при вычислениях типовой задачи
    public Optimisations Optimisations { get; init; } // Используемы ключи оптимизации
    public int InstructionCount { get; init; } // Оценка числа инструкций при выполнении типовой задачи
    public string Timer { get; init; } // Название функции обращения к таймеру
    public double Time { get; init; } // Время выполнения отдельного испытания
    public int LaunchNumer { get; init; } // Номер испытания типовой задачи
    public double AverageTime { get; init; } // Среднее время выполнения типовой задачи из всех испытаний
    public double AbsoluteError { get; init; } // Абсолютная погрешность измерения времени в секундах
    public double  RelativeError { get; init; } // Относительная погрешность измерения времени в %
    public double  TaskPerformance { get; init; } // Производительность (быстродействие) процессора при выполнении типовой задачи
}