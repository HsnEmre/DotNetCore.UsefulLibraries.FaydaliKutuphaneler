//Console.WriteLine("Hello, World!");



using Solid.App;

//SalaryCalculator salaryCalculator= new SalaryCalculator();
//Console.WriteLine($"low salary{salaryCalculator.Calculate(1000,SalaryType.Low)}");
//Console.WriteLine($"mid salary{salaryCalculator.Calculate(1000,SalaryType.Middle)}");
//Console.WriteLine($"high salary{salaryCalculator.Calculate(1000,SalaryType.High)}");



//oc ggod way
//SalaryCalculator2 salaryCalculator = new SalaryCalculator2();
//Console.WriteLine($"low salary{salaryCalculator.Calculate(1000, new LowSalaryCalculate())}");
//Console.WriteLine($"mid salary{salaryCalculator.Calculate(1000, new MidSalaryCalculate())}");
//Console.WriteLine($"high salary{salaryCalculator.Calculate(1000, new HighSalaryCalculate())}");
SalaryCalculator3 salaryCalculator = new SalaryCalculator3();
Console.WriteLine($"low salary: {salaryCalculator.Calculate(1000, new LowSalaryCalculate2().Calculate)}");
Console.WriteLine($"mid salary: {salaryCalculator.Calculate(1000, new MidSalaryCalculate2().Calculate)}");
Console.WriteLine($"high salary: {salaryCalculator.Calculate(1000, new HighSalaryCalculate2().Calculate)}");
