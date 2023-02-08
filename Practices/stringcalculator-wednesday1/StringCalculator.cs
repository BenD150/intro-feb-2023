
using System.Runtime.InteropServices;

namespace StringCalculator;

public class StringCalculator
{

    // This public method will be the only thing we are going to test
    public int Add(string numbers)
    {
        string[] nums = Array.Empty<string>();

        if (numbers != "")
        {
            nums = numbers.Split(',', '\n');

            if (numbers.StartsWith("//"))
            {
                string newNumbers = numbers[2..];
                char delimiter = numbers[2];
                nums = newNumbers.Split(',', '\n', delimiter);
            }
        }

        if (nums.Length == 0) 
        { 
            return 0;   

        } else
        {
            int sum = 0;
            int numberAsInt = 0;
            foreach (string number in nums) 
            { 
                if (number != "")
                {
                    numberAsInt = int.Parse(number);
                    sum += numberAsInt;
                }

            }
            return sum;
        }
    }

}
