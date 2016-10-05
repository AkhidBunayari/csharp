using System;
    class BilanganFaktorial {
        static void Main(string[] args){
            int bil, n;
            int hasil;

            Console.Clear();
            Console.WriteLine("=== Mencari Nilai Faktorial ===");
            Console.WriteLine("===  dari Bilangan Desimal  ===");
            Console.WriteLine("===============================");
            Console.WriteLine("Masukkan angka = ");
            n = Convert.ToInt32(Console.ReadLine());

            //Perulangan
            string tampil = "";
            hasil = 1;
            for (bil=n; bil>=1; bil--) {
                if (bil == 1) {
                    tampil += Convert.ToString(bil);
                } else {
                    tampil += Convert.ToString(bil + " x ");
                }
                hasil = hasil*bil;
            }

            //Output
            Console.WriteLine();
            Console.WriteLine("Calculating... Now..."); 
            Console.WriteLine("Please wait...");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine(); 
            Console.WriteLine( n + "! = " + tampil);
            Console.WriteLine( n + "! = " + hasil);
            Console.WriteLine();
            Console.Write("Press any key to continue . . .");
            Console.ReadLine();
        }
    }
