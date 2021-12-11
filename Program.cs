namespace dengi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double stoimost;

            stoimost = double.Parse(Console.ReadLine());


            if (stoimost < 500)
            {
                Console.WriteLine($"Цена товаров с учетом скидки составяляет: {stoimost}");

            }
            else if (stoimost < 1000 && stoimost >= 500)
            {
                Console.WriteLine($"Цена товаров с учетом скидки составяляет: {stoimost * 0.95}");
            }
            else
            {
                Console.WriteLine($"Цена товаров с учетом скидки составяляет: {stoimost * 0.9}");
            }
            Console.ReadLine();
        }
    }
}