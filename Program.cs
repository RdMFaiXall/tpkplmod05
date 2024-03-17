// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

internal class Program
{
    // class bernama HaloGeneric dengan access modifier public
    public class HaloGeneric
    {
        // method generic SapaUser dengan parameter variabel X
        public void SapaUser<T>(T X)
        {
            // menampilkan data yang disimpan pada variabel X
            Console.WriteLine($"Halo {X}");
        }
    }

    private static void Main(string[] args)
    {
        // memanggil class haloGeneric dan method generic SapaUser
        HaloGeneric generic = new HaloGeneric();
        Console.WriteLine("Nama : ");
        String namaAnda = Console.ReadLine();
        generic.SapaUser ( namaAnda );
    }
}