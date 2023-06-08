using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace telemetry3
{
    public class TemperatureSensor : ISensor
    {
        public ISensorSignal GetSignal()
        {
            return new TemperatureSignal(100, DateTime.Now);
        }
    }
}