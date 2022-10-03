namespace ConsoleApp4
{
    class order
    {
        int quantity;
        string foodname;
        double foodprice;

    }
    class food_order : order
    {
        public void food_gst(string foodname, int quantity, double foodprice)
        {
            double totamt = foodprice + (foodprice * quantity * 0.05);
            Console.WriteLine("Total Amount of food is : " + totamt);
        }
    }
    class grocery_order : order
    {
        public void grocery_gst(string groceryname, int quantity, double groceryprice)
        {
            double totamt = groceryprice + (groceryprice * quantity * 0.08);
            Console.WriteLine("Total Amount of Grocery is : " + totamt);
        }
    }

    class clothing_order : order
    {
        public void clothing_gst(string clothingname, int quantity, double clothingprice)
        {
            double totamt = clothingprice + (clothingprice * quantity * 0.1);
            Console.WriteLine("Total Amount of Clothing is : " + totamt);
        }
    }
    class sample
    {
        static void Main(string[] args)
        {
            food_order food = new food_order();
            grocery_order grocery = new grocery_order();
            clothing_order clothing = new clothing_order();
            food.food_gst("Biriyani", 2, 250);
            grocery.grocery_gst("Butter", 1, 150);
            clothing.clothing_gst("tshirt", 4, 300);
        }
    }
}