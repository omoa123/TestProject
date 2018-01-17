
namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new Store();
            var storeList = Store.QueryStoreList("826", "01");
        }

       
    }
}
