using System.Text;

Console.OutputEncoding = Encoding.UTF8;
double so1, so2;
Console.Write("Nhập số thứ nhất: ");
so1 = double.Parse(Console.ReadLine());
Console.Write("Nhập số thứ hai: ");
so2 = double.Parse(Console.ReadLine());
double tong = so1 + so2;
double tich = so1 * so2;
Console.WriteLine($"Tổng 2 số là {tong}");
Console.WriteLine($"Tích 2 số là {tich}");
