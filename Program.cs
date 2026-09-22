namespace Topic_3_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Jeremiah
            int roomNumber;
            double price;
            string courseName;
            string fullName;
            int gradYear;
            double radius;
            double area;
            double a2;
            double b2;
            double c2;

           

            roomNumber = 29;
            price = 2.99;
            courseName = "Computer Science";
            fullName = "Jeremiah Mol";
            gradYear = 2028;
            radius = 15;
            a2 = Math.Pow(7,2);
            b2 = Math.Pow(5, 2);
            c2 = a2 + b2;

            area = double.Pi * (radius * radius); // Area of a cirle formula


            Console.WriteLine("This is room #" + roomNumber);
            Console.WriteLine("The price is $" + price);
            Console.WriteLine("I am learning a bit about " + courseName);
            Console.WriteLine("");
            Console.WriteLine("My name is " + fullName + " and I'll graduate in " + gradYear + ".");
            Console.WriteLine("");
            Console.WriteLine(Math.Round(area,2)); // Area of a circle with a radius of 15 rounded to 2 decimals
            Console.WriteLine("");
            Console.WriteLine("My favourite formula is pythagoream theorem");
            Console.WriteLine(



        }
    }
}
