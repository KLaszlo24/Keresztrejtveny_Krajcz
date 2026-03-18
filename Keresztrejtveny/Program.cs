namespace Keresztrejtveny
{
    internal class Program
    {
        static void Main(string[] args)
        {
			KeresztrejtvenyRacs racs = new KeresztrejtvenyRacs("kr1.txt");

			Console.WriteLine("5. feladat");
			Console.WriteLine($"Sorok száma: {racs.SorokDb}");
			Console.WriteLine($"Oszlopok száma: {racs.OszlopokDb}");

			Console.WriteLine("\n6. feladat");
			racs.Megjelenit();

			Console.WriteLine("\n7. feladat");
			Console.WriteLine($"Leghosszabb függgőleges szó: {racs.MaxFuggoleges()} karakter hosszú");
		}
    }
}
