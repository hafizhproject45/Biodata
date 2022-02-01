using System;

namespace tugasRPLBiodata // Note: actual namespace depends on the project name.
{
    internal class tugasBiodata
    {
        static void Main(string[] args)
        {
            // Bacaan User
            // Nama
            string? namaUser, alamatUser, ttlUser, hobiUser;

            Console.Write("Nama Lengkap : ");
            namaUser = Console.ReadLine();

            // Alamat
            Console.Write("Alamat : ");
            alamatUser = Console.ReadLine();

            // TTL
            Console.Write("TTL : ");
            ttlUser = Console.ReadLine();

            // Hobi
            Console.Write("Hobi : ");
            hobiUser = Console.ReadLine();

            // Print
            Console.WriteLine("\n=====BIODATA ANDA=====");
            Console.WriteLine("\nNama anda : " + namaUser);
            Console.WriteLine("Alamat anda : " + alamatUser);
            Console.WriteLine("TTL anda    : " + ttlUser);
            Console.WriteLine("Hobi anda   : " + hobiUser);
        }
    }
}
