using System.Text;

Console.OutputEncoding = Encoding.UTF8;
double c;
Console.Write("Nhập độ C: ");
c = double.Parse(Console.ReadLine());
double f = (c * 9 / 5) + 32;
Console.WriteLine($"Độ F là {f}");
