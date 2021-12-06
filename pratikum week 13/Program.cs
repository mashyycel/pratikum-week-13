using System;

namespace pratikum_week_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Berapa Data : ");
            int banyakData = Convert.ToInt32(Console.ReadLine());
            string[,] kumpulanData = new string[banyakData, 6];
           
            
                for (int i = 0; i < banyakData; i++)
                {
                    Console.WriteLine("data ke-" + (i + 1));
                    Console.Write("NIM           :");
                kumpulanData[i, 0] = Console.ReadLine();
                for (int j = 0;j < i; j++)
                {
                    
                    if (kumpulanData[i, 0] == kumpulanData[j, 0])
                    {
                        Console.WriteLine("NIM SUDAH ADA, MASUKKAN NIM LAIN !!!");
                    Console.Write("NIM           :");
                        kumpulanData[i, 0] = Console.ReadLine();
                    }
                }
                   
                    Console.Write("NAMA          :");
                    kumpulanData[i, 1] = Console.ReadLine();
                    Console.Write("JENIS KELAMIN :");
                    kumpulanData[i, 2] = Console.ReadLine();
                    Console.Write("TAHUN MASUK   :");
                    kumpulanData[i, 3] = Console.ReadLine();
                    Console.Write("PROGRAM STUDI :");
                    kumpulanData[i, 4] = Console.ReadLine();
                    Console.Write("KELAS         :");
                    kumpulanData[i, 5] = Console.ReadLine();
                    Console.Write("\n");
                
                }
            
                Console.Write("PRINT HASIL ? (y/n) ");
                string print = Console.ReadLine();
            
            if (print == "y")
            {
                Console.Clear();
                var sb = new System.Text.StringBuilder();
                sb.Append(string.Format("{0,-5} {1,-6} {2,-26} {3,-26} {4,-15} {5,-15} {6,-5}", "N0", "NIM", "NAMA", "JENIS KELAMIN", "TAHUN MASUK", "PROGRAM STUDI","KELAS\n"));
                for (int i = 0; i < banyakData; i++)
                {
                   sb.Append(string.Format("{0,-5} {1,-6} {2,-26} {3,-26} {4,-15} {5,-15} {6,-5}", (i + 1), kumpulanData[i, 0], kumpulanData[i, 1], kumpulanData[i, 2], kumpulanData[i, 3], kumpulanData[i, 4], kumpulanData[i, 5] + "\n"));
                }
                Console.Write(sb);

            }
            
            Console.Write("Tambah Data? (y/n) ");
            string tambah = Console.ReadLine();
            
            if (tambah == "y")
            {
                Console.Write("Berapa Data? ");
                int tambahan = Convert.ToInt32(Console.ReadLine());
                string[,] kumpulandata = new string[tambahan, 6];
                Console.Clear();
                for (int i = banyakData; i < tambahan; i++)
                {
                    Console.WriteLine("data ke-" + (i));
                    Console.Write("NIM           :");
                    kumpulanData[i, 0] = Console.ReadLine();
                    for (int j = 0; j < i; j++)
                    {

                        if (kumpulanData[i, 0] == kumpulanData[j, 0])
                        {
                            Console.WriteLine("NIM SUDAH ADA, MASUKKAN NIM LAIN !!!");
                            Console.Write("NIM           :");
                            kumpulanData[i, 0] = Console.ReadLine();
                        }
                    }

                    Console.Write("NAMA          :");
                    kumpulanData[i, 1] = Console.ReadLine();
                    Console.Write("JENIS KELAMIN :");
                    kumpulanData[i, 2] = Console.ReadLine();
                    Console.Write("TAHUN MASUK   :");
                    kumpulanData[i, 3] = Console.ReadLine();
                    Console.Write("PROGRAM STUDI :");
                    kumpulanData[i, 4] = Console.ReadLine();
                    Console.Write("KELAS         :");
                    kumpulanData[i, 5] = Console.ReadLine();
                    Console.Write("\n");

                }
               
            }

            
        }
    }
}
