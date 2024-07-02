namespace Latih5_TipeDataObjet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var BMW = new Mobil
            {
                TipeMobil = "BMW sedan",
                Warna = "Putih",
                VolumeMesin = 2500,
                MaxKecepatan = 180,
                BahanBakar = "Pertamax Turbo",
                TglProduksi = new DateTime(2020, 1, 2)
            };
            var HondaJazz = new Mobil
            {
                TipeMobil = "Jazz 2019",
                Warna = "Hitam",
                VolumeMesin = 2000,
                MaxKecepatan = 160,
                BahanBakar = "Pertamax Turbo",
                TglProduksi = new DateTime(2019, 2, 12)
            };
            var InovaKijang = new Mobil
            {
                TipeMobil = "Inova Reborn",
                Warna = "Hitam",
                VolumeMesin = 2500,
                MaxKecepatan = 190,
                BahanBakar = "Solar",
                TglProduksi = new DateTime(2021, 2, 12)
            };

            var ListMobil = new List<Mobil>();

            ListMobil.Add(BMW);
            ListMobil.Add(HondaJazz);
            ListMobil.Add(InovaKijang);

            int number = 1;
            foreach (var item in ListMobil)
            {
                Console.WriteLine($"Tipe Mobil {number}: {item.TipeMobil}");
                Console.WriteLine($"Warna: {item.Warna}");
                Console.WriteLine($"Volume Mesin: {item.VolumeMesin}");
                Console.WriteLine($"Max Kecepatan: {item.MaxKecepatan}");
                Console.WriteLine($"Bahan Bakar: {item.BahanBakar}");
                Console.WriteLine($"TglProduksi: {item.TglProduksi.ToString("dd-MM-yyyy")}\n");
                number++;
            }
        }
    }
}
