using System;
using System.Collections.Generic;
 
namespace DataMahasiswa {
  static class CariMahasiswa {
    public static void Form(List<Mahasiswa> daftarMahasiswa) {
      Console.Clear();
 
      Console.WriteLine("========================================");
      Console.WriteLine(" CARI MAHASISWA");
      Console.WriteLine("========================================");
 
      Console.Write("Masukkan NRP: ");
      string nrpCari = Console.ReadLine();
 
      Mahasiswa mahasiswaDitemukan = null;
 
      foreach (Mahasiswa m in daftarMahasiswa) {
        if (m.NRP.Equals(nrpCari, StringComparison.OrdinalIgnoreCase)) {
          mahasiswaDitemukan = m;
          break;
        }
      }
 
      Console.WriteLine();
 
      if (mahasiswaDitemukan != null) {
        Console.WriteLine("Data ditemukan!");
        Console.WriteLine("NRP   : " + mahasiswaDitemukan.NRP);
        Console.WriteLine("Nama  : " + mahasiswaDitemukan.Nama);
        Console.WriteLine("Prodi : " + mahasiswaDitemukan.Prodi);
        Console.WriteLine("IPK   : " + mahasiswaDitemukan.IPK.ToString("F2"));
      }
      else {
        Console.WriteLine("Mahasiswa dengan NRP tersebut tidak ditemukan.");
      }
    }
  }
}