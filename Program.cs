// See https://aka.ms/new-console-template for more information
using Telerik.Reporting;

Console.WriteLine("Hello, World!");

var reportPackager = new ReportPackager();
using var sourceStream = new MemoryStream();
reportPackager.Package(File.ReadAllText("/opt/candle-server/Candle/Candle.Services/SeedData/Reports/Report Cards/Citrus Report Card.trdx"), sourceStream);