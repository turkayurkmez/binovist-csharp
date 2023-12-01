// See https://aka.ms/new-console-template for more information
using Constructors;

Console.WriteLine("Hello, World!");

//Report report = new Report(path: "");
//Console.WriteLine(report.ReportFormat.ToString());

Report report1 = new Report("C:\\Users\\turka\\source\\sales.xlsx");
Console.WriteLine(report1.ReportFormat.ToString());


//SqlDataAdapter sqlDataAdapter = new SqlDataAdapter()
Report report2 = new Report("C:\\Users\\turka\\source\\sales.xlsx", ReportFormats.PDF);
Console.WriteLine(report2.ReportFormat.ToString());


