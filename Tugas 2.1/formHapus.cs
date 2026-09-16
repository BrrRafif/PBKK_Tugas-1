using System;
using System.Collections.Generic;
 
namespace DataMahasiswa {
  static class HapusMahasiswa {
    public static void Form(List<Mahasiswa> daftarMahasiswa) {
      Console.Clear();
      Console.WriteLine("========================================");
      Console.WriteLine(" HAPUS MAHASISWA");
      Console.WriteLine("========================================");
 
      Console.Write("Masukkan NRP: ");
      string nrpHapus = Console.ReadLine();
      Mahasiswa mahasiswaDitemukan = null;
 
      foreach (Mahasiswa m in daftarMahasiswa) {
        if (m.NRP.Equals(nrpHapus, StringComparison.OrdinalIgnoreCase)) {
          mahasiswaDitemukan = m;
          break;
        }
      }
 
      if (mahasiswaDitemukan != null) {
        daftarMahasiswa.Remove(mahasiswaDitemukan);
 
        Console.WriteLine();
        Console.WriteLine("Data mahasiswa berhasil dihapus.");
      }
      else {
        Console.WriteLine();
        Console.WriteLine("Data mahasiswa tidak ditemukan.");
      }
    }
  }
}