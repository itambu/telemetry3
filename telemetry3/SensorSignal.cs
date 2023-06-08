using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace telemetry3
{
    public struct SensorSignal<T> : ISensorSignal
    {
        private readonly T? value;
        private readonly DateTime? created;

        public T? Value => value;

        object? ISensorSignal.Value => value;

        public DateTime? Created => created;

        public SensorSignal(T? value, DateTime? created)
        {
            this.value = value;
            this.created = created;
        }

        public override string ToString() => String.Format($"{value}");
    }
}