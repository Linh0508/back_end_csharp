int TinhTongSoChan(int[] a)
{
    int tong = 0;
    foreach (int i in a)
    {
        if (i % 2 == 0)
        {
            tong += i;
        }
    }
    return tong;
}

int[] a = { 10, 11, 15, 18, 22, 26, 29 };
int tong = TinhTongSoChan(a);
Console.WriteLine($"Tong la: {tong}");
