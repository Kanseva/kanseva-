// STUDI KASUS 1(SISTEM PENGHITUNG BELANJA)

using System.Reflection.Metadata;

Console.WriteLine("Sistem Penghitung Biaya Belanja");
Console.WriteLine("Daftar Barang");
Console.WriteLine("1. Pensil - Rp 2.000 per pcs");
Console.WriteLine("2. Pulpen - Rp 5.000 per pcs");
Console.WriteLine("3. Penghapus - Rp 1.000 per pcs");
Console.WriteLine("4. Buku - Rp 10.000 per pcs");
Console.WriteLine("5. Penggaris - Rp 4.000 per pcs");

Console.Write("Pilih Jenis Barang(Masukan Nomor) :");
int pilihan = int.Parse(Console.ReadLine());

Console.Write("Masukan Jumlah Yang Ingin Dibeli: ");
int jumlah = int.Parse(Console.ReadLine());

double hargasatuan = 0;

// Tentukan Harga Per Unit
switch (pilihan)
{
    case 1:
        hargasatuan = 2000;
        break;
    case 2:
        hargasatuan = 5000;
        break;
    case 3:
        hargasatuan = 1000;
        break;
    case 4:
        hargasatuan = 10000;
        break;
    case 5:
        hargasatuan = 4000;
        break;
    default:
        Console.WriteLine("Pilihan Tidak Valid. Silahkan Coba Lagi");
        return;
}

//Hitung total biaya
double totalbiaya = hargasatuan * jumlah;

//Cek diskon
if (totalbiaya > 200000)
{
    totalbiaya -= totalbiaya * 0.1;// Diskon 10%
}
else if (totalbiaya > 100000)
{
    totalbiaya -= totalbiaya * 0.05;// Diskon 5%
    }
Console.WriteLine("Total Biaya: Rp " + totalbiaya);
