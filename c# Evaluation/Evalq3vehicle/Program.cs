namespace Evalq3vehicle
{
    interface Ivehicle
    {
        public void drive();
        public bool refuel(int a);
    }
    class car : Ivehicle
    {
        public int fuel;
        public void drive()
        {
            Console.WriteLine("Car is Driving.");
        }
        public bool refuel(int a1)
        {
            return true;
        }
        public car(int a)
        {
            this.fuel= a;
            Console.WriteLine("Fuel amount now : " + fuel);
        }
    }
   class program { 
        static void Main(string[] args)
        {
            car car = new car(0);
            if (car.fuel > 0)
            {
                car.drive();
            }
            else
            {
                Console.WriteLine("Enter the fuel to be filled");
                int a1 = int.Parse(Console.ReadLine());
                car.refuel(a1);
                car.fuel = car.fuel + a1;
                car.drive();
            }
        }
    }
}