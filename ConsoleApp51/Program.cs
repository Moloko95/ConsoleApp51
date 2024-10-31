using System;

class Program
{
    static void Main()
    {
        int number;
        //loop to prompt user until valid input is entered
        while (true)
        {
            Console.Write("Enter a number (0 to 9999): ");
            number = Convert.ToInt32(Console.ReadLine());

            //check if input value it's an integer and within the range
            if (number >= 0 && number <= 9999)
            {
                string words = ConvertToWords(number);
                Console.WriteLine($"{number} -> {words}");
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid integer between 0 and 9999.");
            }
        }
    }

    static string ConvertToWords(int num)
    {
        if (num == 0)
        {
            return "Zero";
        }
        // array containing words for numbers 0 to 19
        string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                          "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
                          "Seventeen", "Eighteen", "Nineteen" };

        // array containing words for multiples of ten 
        string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        string words = ""; // Variable to hold the final words

        if (num >= 1000)
        {
            words += ones[num / 1000] + " Thousand";
            num %= 1000;
            if (num > 0) words += " ";
        }

        if (num >= 100)
        {
            words += ones[num / 100] + " Hundred";
            num %= 100;
            if (num > 0) words += " ";
        }

        if (num >= 20)
        {
            words += tens[num / 10];
            num %= 10;
            if (num > 0) words += "-";
        }

        if (num > 0)
        {
            words += ones[num];
        }

        return words.Trim();//Trim whitespace and return the final words
    }
}
