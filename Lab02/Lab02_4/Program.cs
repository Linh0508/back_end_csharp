using System.Text;

Console.OutputEncoding = Encoding.UTF8;
int TimSoLonThuHai(int[] a)
{
    if (a.Length < 2)
    {
        return -1;
    }
    int max = a[0];
    int scMax = a[0];
    foreach (int i in a)
    {
        if (i > max)
        {
            scMax = max;
            max = i;
        }
        else if (i > scMax && i < max)
        {
            scMax = i;
        }
    }
    return scMax;
}

int[] a = { 19, 37, 66, 85, 10, 5, 2 };
int n = TimSoLonThuHai(a);
Console.WriteLine($"Số lớn thứ 2 trong mảng là: {n}");
