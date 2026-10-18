using LAB05;

Linear linear = new Linear(2, 7);
Linear linear1 = new Linear(3, 8);

Console.WriteLine($"a = {linear.A}, b = {linear.B}");
Console.WriteLine($"a = {linear1.A}, b = {linear1.B}");

linear.A = 5;
linear.B = 9;
Console.WriteLine($"После изменения: a = {linear.A}, b = {linear.B}");

Console.WriteLine(linear.Calculate(3));
Console.WriteLine(linear1.Calculate(6));

linear.PrintEquation();
linear1.PrintEquation();
