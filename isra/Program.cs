namespace isra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== BIODATA ==");
            Console.Write("NAMA\t: ");
            Console.WriteLine("Isra ");
            Console.WriteLine("Alamat\t: Bintaro 9");

            Console.WriteLine();

            Console.WriteLine("== PROGRAM KEYEN ==");
            Console.Write("Tuliskan nama kamu : ");
            string Nama = Console.ReadLine();
            Console.WriteLine("Hallow, {0} Selamat Datang", Nama);

            //inplisit
            var namaweb = "Petani Kode";
            var umur = 18;
            var isMenikah = false;
            Console.WriteLine("nama : " + namaweb);
            Console.WriteLine("umur : " + umur);
            Console.WriteLine("IsMenikah : " + isMenikah);
        }
    }
}