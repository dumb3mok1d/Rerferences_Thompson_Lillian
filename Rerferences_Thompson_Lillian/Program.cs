namespace Rerferences_Thompson_Lillian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sedan myFirstSedan = new Sedan(0);
            IAutomoblie MyAutoMobile = myFirstSedan;

            Sedan myOtherSedan = new Sedan(0);

            myFirstSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(MyAutoMobile.Speed);
            Console.WriteLine(myFirstSedan.Equals(MyAutoMobile));

            myOtherSedan.IncreaseSpeed();
            Console.WriteLine(myOtherSedan.Speed);
            Console.WriteLine(MyAutoMobile.Speed);
            Console.WriteLine(myFirstSedan.Equals(MyAutoMobile));

            Truck myTruck = new Truck(50, 500, "MyTrUck");

            // Calls Stringify method and describe automoblie.
            myFirstSedan.Stringify();
            MyAutoMobile.Stringify();
            myOtherSedan.Stringify();
            myTruck.Stringify();
        }
    }
}