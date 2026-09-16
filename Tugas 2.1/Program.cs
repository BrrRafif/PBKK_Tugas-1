using System;
using System.Collections.Generic;

namespace DataMahasiswa {
  class Mahasiswa {
    public string NRP {get; set; }
    public string Nama {get; set; }
    public string Prodi {get; set; }
    public double IPK {get; set; }
  
    public Mahasiswa(string nrp, string nama, string prodi, double ipk) {
      NRP = nrp;
      Nama = nama;
      Prodi = prodi;
      IPK = ipk;
    }
  }

  class Program {
    static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();
    
    static void Main(string[] args) {
      int pilihan;

      do
      {
        TampilkanMenu();
        Console.Write("Pilihan: ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out pilihan)) {
          pilihan = 0;
        }

        Console.WriteLine();

        switch (pilihan) {
          case 1:
            TambahMahasiswa.Form(daftarMahasiswa);
            break;

          case 2:
            TampilkanMahasiswa.Form(daftarMahasiswa);
            break;

          case 3:
            CariMahasiswa.Form(daftarMahasiswa);
            break;

          case 4:
            HapusMahasiswa.Form(daftarMahasiswa);
            break;

          case 5:
            Console.WriteLine("Terima kasih telah menggunakan program.");
            break;
        } 

        if (pilihan != 5) {
          Console.WriteLine();
          Console.WriteLine("Tekan ENTER untuk melanjutkan...");
          Console.ReadLine();
        }
      }

      while(pilihan != 5);
    
    }

    static void TampilkanMenu() {
      Console.Clear();

      Console.WriteLine("========================================");
      Console.WriteLine(" SISTEM DATA MAHASISWA");
      Console.WriteLine("========================================");
      Console.WriteLine("1. Tambah Mahasiswa");
      Console.WriteLine("2. Tampilkan Mahasiswa");
      Console.WriteLine("3. Cari Mahasiswa");
      Console.WriteLine("4. Hapus Mahasiswa");
      Console.WriteLine("5. Keluar");
      Console.WriteLine("========================================");
    }
  }
}