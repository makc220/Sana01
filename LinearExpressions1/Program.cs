﻿Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Введіть значення для a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введіть значення для b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введіть значення для c: ");
double c = Convert.ToDouble(Console.ReadLine());
Console.Write("Введіть значення для d: ");
double d = Convert.ToDouble(Console.ReadLine());


double x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);
double y = (5 * (a + b) * (c - d)) / (0.5 * c) + Math.Pow(d, 2) * (Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a);
double z = (Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);
double r = (0.5 * a + (3.0 / 4) * b - 7.0 / 5) / (3 * c + 1) + 1 / (a - c);


Console.WriteLine($"x = {x}");
Console.WriteLine($"y = {y}");
Console.WriteLine($"z = {z}");
Console.WriteLine($"r = {r}");