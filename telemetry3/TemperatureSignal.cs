using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace telemetry3
{
    public struct TemperatureSignal : ISensorSignal
    {
        private readonly double? temperature;
        private readonly DateTime? created;

        public double? Value => temperature;

        object? ISensorSignal.Value => temperature;

        public DateTime? Created => created;

        public TemperatureSignal(double? temperature, DateTime? created)
        {
            this.temperature = temperature;
            this.created = created;
        }

        public override string ToString() => String.Format($"{temperature}");
    }
}