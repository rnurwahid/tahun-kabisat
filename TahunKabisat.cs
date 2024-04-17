//1. Menentukan Tahun Kabisat

using System;

public class TahunKabisat
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menentukan Jenis Tahun Masehi");
        Console.Write("Masukkan tahun: ");
        int t = Convert.ToInt32(Console.ReadLine());

        if (t % 4 == 0)
        {
            Console.WriteLine("Tahun Kabisat");
        }
        else
        {
            Console.WriteLine("Bukan Tahun Kabisat");
        }
    }

}