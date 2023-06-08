using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace telemetry3
{
    public class PressureSensor : ISensor
    {
        public ISensorSignal GetSignal()
        {
            return new SensorSignal<int>(44, DateTime.Now);
        }
    }
}