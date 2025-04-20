using System.Text;

Console.OutputEncoding = Encoding.UTF8;
string ten;
int tuoi;
Console.Write("Nhập tên: ");
ten = Console.ReadLine();
Console.Write("Nhập tuổi: ");
tuoi = int.Parse(Console.ReadLine());
Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");
