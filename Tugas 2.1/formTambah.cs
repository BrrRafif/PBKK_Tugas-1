using System;
using System.Collections.Generic;
 
namespace DataMahasiswa {
  static class TambahMahasiswa {
    public static void Form(List<Mahasiswa> daftarMahasiswa) {
      Console.Clear();
      Console.WriteLine("========================================");
      Console.WriteLine(" TAMBAH MAHASISWA");
      Console.WriteLine("========================================");
 
      Console.Write("NRP  : ");
      string nrp = Console.ReadLine();
 
      Console.Write("Nama : ");
      string nama = Console.ReadLine();
 
      Console.Write("Program Studi: ");
      string prodi = Console.ReadLine();
 
      double ipk;
 
      while (true) {
        Console.Write("IPK  : ");
 
        if (double.TryParse(Console.ReadLine(), out ipk)) {
          if (ipk >= 0 && ipk <= 4) break;
        }
 
        Console.WriteLine("IPK harus berupa angka 0-4.");
      }
 
      Mahasiswa mahasiswa = new Mahasiswa(nrp, nama, prodi, ipk);
      daftarMahasiswa.Add(mahasiswa);
 
      Console.WriteLine();
      Console.WriteLine("Data mahasiswa berhasil ditambahkan.");
    }
  }
}
 
