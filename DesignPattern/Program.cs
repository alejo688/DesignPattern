using System;
using DesignPattern.FactoryPattern;

namespace DesignPattern
{
    class Program
    {
        public void ExecSingleton()
        {
            var log = Singleton.Log.Instance;
            log.Save("a");
            log.Save("b");

            var a = Singleton.Singleton.Instance;
            var b = Singleton.Singleton.Instance;

            Console.WriteLine(a == b);
        }

        static void Main(string[] args)
        {
            SaleFactory storeSaleFactory = new StoreSaleFactory(10);
            SaleFactory internetSaleFactory = new InternetSaleFactory(2);

            ISale sale1 = storeSaleFactory.GetSale();
            sale1.Sell(15);

            ISale sale2 = internetSaleFactory.GetSale();
            sale2.Sell(15);
        }
    }
}
