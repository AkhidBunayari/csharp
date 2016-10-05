using System;
	class Karyawan{
		static void Main(string[] args){
			//Variable
			
            string namaKaryawan = ""; 
			int NIK, gajiPokok, tunjangan, uangMakan, uangTransport, a, jumlah;
			double gajiTotal = 0;

			//Input + Proses
			atas:
			Console.Clear();
			Console.WriteLine(" ==================================== ");
			Console.WriteLine(" ==     PROGRAM GAJI KARYAWAN      == ");
			Console.WriteLine(" ==        PT. ABCD Persero        == ");
			Console.WriteLine(" ==================================== ");
			
			Console.Write("\n Jumlah Data Karyawan: ");
			jumlah = Int32.Parse(Console.ReadLine());

			for(a=0; a<jumlah; a++){

				Console.WriteLine("\n Data Karyawan ke-"+(a+1));
				Console.Write(" NIK\t\t: ");
				NIK = Int32.Parse(Console.ReadLine());
				Console.Write(" Nama\t\t: ");
				namaKaryawan = Console.ReadLine();
				Console.Write(" Gaji Pokok\t: ");
				gajiPokok = Int32.Parse(Console.ReadLine());
				Console.Write(" Tunjangan\t: ");
				tunjangan = Int32.Parse(Console.ReadLine());
				Console.Write(" Uang Makan\t: ");
				uangMakan = Int32.Parse(Console.ReadLine());
				Console.Write(" Uang Transport\t: ");
				uangTransport = Int32.Parse(Console.ReadLine());
				gajiTotal = gajiPokok + tunjangan + uangMakan + uangTransport;

				//Output
				Console.WriteLine("\n\n Data Gaji Karyawan ke-"+(a+1));
				Console.WriteLine(" Nama\t\t: "+namaKaryawan);
				Console.WriteLine(String.Format(" Total Gaji\t: "+"Rp "+"{0:n}",gajiTotal));
				Console.WriteLine();
			}

		Console.Write(" Ulang? Pilih [yes/no] = ");
		string jwb = Console.ReadLine();
        if (jwb == "Y" || jwb == "y" || jwb == "Yes" || jwb == "yes" || jwb == "YES"  ) {	
        	Console.Clear();
        	goto atas;	
		} else {
			return;
		}
	}
}
