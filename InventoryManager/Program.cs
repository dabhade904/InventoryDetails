namespace InventoryManeger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FetchInventoryManegement obj = new FetchInventoryManegement();
            string filePath = "C:/Users/sir/Desktop/dotNet/InventoryManager/InventoryManager/data.json";
            Rice data = obj.Read(filePath);
            // Console.WriteLine(data);
            for (int i = 0; i < data.typeOfRice.Count; i++)
            {
                Console.WriteLine(data.typeOfRice[i].name);
                Console.WriteLine(data.typeOfRice[i].weight);
                Console.WriteLine(data.typeOfRice[i].price);

                int total = data.typeOfRice[i].weight * data.typeOfRice[i].price;
                Console.WriteLine("total price of rice is : " + total);
                Console.WriteLine("------------------------");
            }

            for (int i = 0; i < data.typeOfWheats.Count; i++)
            {
                Console.WriteLine(data.typeOfWheats[i].name);
                Console.WriteLine(data.typeOfWheats[i].weight);
                Console.WriteLine(data.typeOfWheats[i].price);
                int total = data.typeOfWheats[i].weight * data.typeOfWheats[i].price;
                Console.WriteLine("total price of Wheats is : " + total);
                Console.WriteLine("------------------------");
            }

            for (int i = 0; i < data.typeOfPulses.Count; i++)
            {
                Console.WriteLine(data.typeOfPulses[i].name);
                Console.WriteLine(data.typeOfPulses[i].weight);
                Console.WriteLine(data.typeOfPulses[i].price);
                int total = data.typeOfPulses[i].weight * data.typeOfPulses[i].price;
                Console.WriteLine("total price of Pulses is : " + total);
                Console.WriteLine("------------------------");
            }
        }
    }
}