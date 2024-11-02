Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Введіть значення для a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введіть значення для b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введіть значення для m: ");
double m = Convert.ToDouble(Console.ReadLine());
Console.Write("Введіть значення для n: ");
double n = Convert.ToDouble(Console.ReadLine());
Console.Write("Введіть значення для x: ");
double x = Convert.ToDouble(Console.ReadLine());

double z1 = (m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n) / Math.Sqrt(Math.Pow(m, 3) * n + n * m + Math.Pow(m, 2) - m);
double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
double y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

Console.WriteLine($"z1 = {z1}");
Console.WriteLine($"z2 = {z2}");
Console.WriteLine($"y = {y}");