namespace _05102026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cane cane = new Cane("Fido", 3);
            Gatto gatto = new Gatto("Milo", 2);
            Pollo pollo = new Pollo("Pippo", 1);

            Console.WriteLine(cane.Nome + ": " + cane.Verso());
            Console.WriteLine(gatto.Nome + ": " + gatto.Verso());
            Console.WriteLine(pollo.Nome + ": " + pollo.Verso());
        }
    }
}
