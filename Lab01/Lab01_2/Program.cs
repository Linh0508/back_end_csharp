using System.Text;

Console.OutputEncoding = Encoding.UTF8;
double dai;
double rong;
Console.Write("Nhập chiều dài: ");
dai = double.Parse(Console.ReadLine());
Console.Write("Nhập chiều rộng: ");
rong = double.Parse(Console.ReadLine());
double dienTich = dai * rong;
Console.WriteLine($"Diện tích là: {dienTich}");
