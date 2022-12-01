namespace _1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inp = File.ReadAllText("input.txt");

            // sum all numbers that are split in sections and return the largest one
            string[] numberSections = inp.Split("\r\n\r\n"); // get all sections
            int highestSum = 0;

            foreach (string section in numberSections)
            {
                int sum = 0;
                string[] numbers = section.Split("\r\n"); // get all numbers into an array

                foreach(string number in numbers)
                {
                    sum += int.Parse(number);
                }

                if(sum > highestSum)
                {
                    highestSum = sum;
                }
            }

            Console.WriteLine(highestSum);
        }
    }
}