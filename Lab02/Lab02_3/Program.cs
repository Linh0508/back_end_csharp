using System.Text;

Console.OutputEncoding = Encoding.UTF8;
void DemSo(int[] a)
{
    int soSoAm = 0;
    int soSoDuong = 0;
    foreach (int i in a)
    {
        if (i < 0)
        {
            soSoAm++;
        }
        else if (i > 0)
        {
            soSoDuong++;
        }
    }
    Console.WriteLine($"Số lượng số âm: {soSoAm}");
    Console.WriteLine($"Số lượng số dương: {soSoDuong}");
}

int n;
Console.Write("Nhập số phần tử của mảng: ");
n = int.Parse(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Nhập giá trị: ");
    a[i] = int.Parse(Console.ReadLine());
}
DemSo(a);
