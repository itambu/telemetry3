using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace telemetry3
{
    // 
    public class CentralPost
    {
        protected ICollection<ISensor> Sensors { get; set; }
        protected ICollection<ISensorSignal> Signals { get; set; }

        public CentralPost(ICollection<ISensor> sensors, ICollection<ISensorSignal> signals)
        {
            Sensors = sensors;
            Signals = signals;
        }

        public void RequestAll()
        {
            foreach (var sensor in Sensors) 
            {
                Signals.Add( sensor.GetSignal());
            }
        }
    }
}