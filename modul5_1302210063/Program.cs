internal class Program
{
    private static void Main(string[] args)
    {
        Penjumlahan<Double> penjumlahan = new Penjumlahan<double>();
        penjumlahan.jumlahTigaAngka(13, 02, 21);
        SimpleDataBase<Double> data = new SimpleDataBase<Double>();
        data.addNewData(13);
        data.addNewData(02);
        data.addNewData(21);
        data.addNewData(00);
        data.printAllData();
    }
}

class SimpleDataBase<T>
{
    List<T> storeData { get; set; }
    List<DateTime> inputDates { get; set; }
    public SimpleDataBase()
    {
        storeData = new List<T>();
        inputDates = new List<DateTime>();
    }
    public void addNewData(T data)
    {
        storeData.Add(data);
        inputDates.Add(DateTime.Now.Date);
    }
    public void printAllData()
    {
        for(int i=0;i<storeData.Count;i++)
        {
            Console.WriteLine("Data " + (i + 1) + " berisi " + storeData.ElementAt(i) + " yang disimpan pada waktu " + inputDates.ElementAt(i));
        }

       
    }
}
class Penjumlahan<T>
{
    public void jumlahTigaAngka(T a,T b, T c)
    {
        
        dynamic aa = a;
        dynamic bb = b;
        dynamic cc = c;
        Console.WriteLine(aa+bb+cc);

    }
}