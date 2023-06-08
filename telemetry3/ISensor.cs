using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace telemetry3
{
    public interface ISensor
    {
        ISensorSignal GetSignal();
    }
}