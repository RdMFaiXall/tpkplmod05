// See https://aka.ms/new-console-template for more information

namespace tpmodul5_1302220093
{
    // membuat class bernama DataGeneric dengan generic variable T
    public class DataGeneric<T>
    {
        private T data;

        // Konstruktor dengan parameter nama variabel data
        public DataGeneric(T data)
        {
            this.data = data;
        }

        // menampilkan data yang telah berisi
        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah : {data}");
        }
    }
    
    //private static void Main(string[] args)
    //{
        // memanggil class DataGeneric dengan method printData
      //  Console.WriteLine("NIM : ");
        //string NIM = Console.ReadLine();
        //DataGeneric<string> data = new DataGeneric<string>(NIM);
        //data.PrintData();
    //}
}