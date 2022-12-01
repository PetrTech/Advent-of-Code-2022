// Do the same thing as part 1, but get the top 3

namespace _1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inp = File.ReadAllText("input.txt");

            string[] numberSections = inp.Split("\r\n\r\n"); // get all sections
            List<int> highestSums = new();

            foreach (string section in numberSections)
            {
                int sum = 0;
                string[] numbers = section.Split("\r\n"); // get all numbers into an array

                foreach (string number in numbers)
                {
                    sum += int.Parse(number);
                }

                highestSums.Add(sum);
            }

            highestSums.Sort();

            Console.WriteLine(highestSums[highestSums.Count - 1] + highestSums[highestSums.Count - 2] + highestSums[highestSums.Count - 3]);
        }
    }
}