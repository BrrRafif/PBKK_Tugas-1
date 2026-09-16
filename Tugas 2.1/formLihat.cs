using System;
using System.Collections.Generic;
 
namespace DataMahasiswa {
  static class TampilkanMahasiswa {
    public static void Form(List<Mahasiswa> daftarMahasiswa) {
      Console.Clear();
 
      Console.WriteLine("==========================================================");
      Console.WriteLine(" DAFTAR MAHASISWA");
      Console.WriteLine("==========================================================");
 
      if (daftarMahasiswa.Count == 0) {
        Console.WriteLine("Belum ada data mahasiswa.");
        Console.WriteLine("==========================================================");
        return;
      }
 
      Console.WriteLine("{0,-12} {1,-20} {2,-20} {3,5}", "NRP", "Nama", "Prodi", "IPK");
      Console.WriteLine("==========================================================");
 
      foreach (Mahasiswa m in daftarMahasiswa) {
        Console.WriteLine("{0,-12} {1,-20} {2,-20} {3,5:F2}", m.NRP, m.Nama, m.Prodi, m.IPK);
      }
 
      Console.WriteLine("==========================================================");
    }
  }
}