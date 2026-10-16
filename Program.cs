namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grade Calculator (Enter -1 to exit)");
            while (true)
            {
                Console.Write("Score: ");
                int score = int.Parse(Console.ReadLine());

                if (score == -1)
                {
                    break;
                }

                if (score < 0 || score > 100)
                {
                    Console.WriteLine("Invalid score");
                }
                else
                {
                    Console.Write("Grade: ");
                    if (score >= 90)
                    {
                        Console.WriteLine("A");
                    }
                    else if (score >= 85)
                    {
                        Console.WriteLine("B");
                    }
                    else if (score >= 70)
                    {
                        Console.WriteLine("C");
                    }
                    else if (score >= 60)
                    {
                        Console.WriteLine("D");
                    }
                    else
                    {
                        Console.WriteLine("F");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------------");
            int number;
            int count = -1;
            int sum = 0;
            double average = 0;

            do
            {
                Console.Write("Number (0 for stop): ");
                number = int.Parse(Console.ReadLine());
                count++;
                sum += number;

            } while (number > 0);

            if (count > 0)
            {
                average = (double)sum / count;
                Console.WriteLine($"Count: {count}  Sum: {sum}  Average: {average}");
            }
            else
            {
                Console.WriteLine("No valid numbers were entered.");
            }
        }
    }
}
