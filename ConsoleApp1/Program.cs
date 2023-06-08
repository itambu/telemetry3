// See https://aka.ms/new-console-template for more information
using telemetry3;

Console.WriteLine("Hello, World!");

var sensors = new List<ISensor>() { new TemperatureSensor(), new PressureSensor() };
var signals = new List<ISensorSignal>();

var cp = new CentralPost(sensors, signals);
cp.RequestAll();

foreach (ISensorSignal signal in signals)
{
    Console.WriteLine($"{signal.Value} {signal.Created}");
}