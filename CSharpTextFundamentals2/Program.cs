using System;

namespace CSharpTextFundamentals2
{
    class Program
    {
        static void Main( string[] args )
        {
            string greetingSomeone = "Hello Ronal!";

            /* greetingSomeone is the Receiver and Length
             * is the Property */
            int greetingLength = greetingSomeone.Length;
            Console.WriteLine($"Length of {greetingSomeone}" +
                              $" is: {greetingLength}");

            /* greetingSomeone is the Receiver and ToUpper()
             * is the Instance Method
             * greetingSomeone.ToUpper() is the Argument of
             * Console.WriteLine */
            Console.WriteLine($"Uppercase of {greetingSomeone}" +
                              $" is: {greetingSomeone.ToUpper()}");

            /* Using ToUpper() Method to Convert greetingSomeone 
             * string to Uppercase */
            greetingSomeone.ToUpper();

            /* ToUpper() Method Creates a Copy of greetingSomeone
             * and then Converts that to Uppercase but doesn't
             * Mutate or Change the Actual Value of greetingSomeone */
            Console.WriteLine($"Unmutated String: {greetingSomeone}");

            /* Assigning greetingSomeone.ToUpper() Expression Value
             * to greetingSomeone string */
            greetingSomeone = greetingSomeone.ToUpper();

            // Printing Mutated string greetingSomeone
            Console.WriteLine($"Mutated String: {greetingSomeone}");

            /* Assigning Preferred Substring
             * 0 and 5 are the Arguments of greetingSomeone.Substring() */
            string greetingSub = greetingSomeone.Substring(0, 5);
            Console.WriteLine($"Subset of Mutated String: {greetingSub}\n");

            // string Comparison
            string person1 = "Ronal";
            string person2 = "Rifency";
            string person3 = "Rohan";
            string person4 = "Ronal";

            /* person1 and person2 don't have the Same Number of
             * Characters, they can't be Equal */
            bool stringComparisonChecker = person1 == person2;
            Console.WriteLine($"{person1} is Equal to {person2}:" +
                              $" {stringComparisonChecker}");

            /* person1 and person3 have the Same Number of Characters
             * but Those are Not Identical, so Still Not Equal */
            stringComparisonChecker = person1 == person3;
            Console.WriteLine($"{person1} is Equal to {person3}:" +
                              $" {stringComparisonChecker}");

            /* person1 and person4 have the Same Number of Identical
             * Characters, so Both of Them are Equal */
            stringComparisonChecker = person1 == person4;
            Console.WriteLine($"{person1} is Equal to {person4}:" +
                              $" {stringComparisonChecker}\n");

            /* Comparing Strings by Static Method and Getting Integer Value
             * person2 String is Positioned Ahead and Comparatively Larger
             * than person1 String considering the Sorting Order, 
             * so the Value is -1*/
            int stringComparisonValue = string.Compare(person2, person1);
            Console.WriteLine($"Comparison Value between {person2} and" +
                              $" {person1} is: {stringComparisonValue}");

            /* person3 String is Positioned Behind and Comparatively Larger
             * than person1 String considering the Sorting Order, 
             * so the Value is 1 */
            stringComparisonValue = string.Compare(person1, person3);
            Console.WriteLine($"Comparison Value between {person1} and" +
                              $" {person3} is: {stringComparisonValue}");

            /* As the Sorting Order of person1 and person4 Strings are
             * Identical, Position of them doesn't Matter; the Value is 0 */
            stringComparisonValue = string.Compare(person1, person4);
            Console.WriteLine($"Comparison Value between {person1} and" +
                              $" {person4} is: {stringComparisonValue}\n");

            /* Convert to string */
            // int to string
            int number = 777;
            string numberString = number.ToString();

            // char to string
            char character = 'R';
            string characterString = character.ToString();

            // double to string
            double pi = 3.1416;
            string piString = pi.ToString();

            // decimal to string
            decimal dollar = 199.99m;
            string dollarString = dollar.ToString();

            Console.WriteLine($"Random Number: {numberString}\n" +
                              $"Random Character: {characterString}\n" +
                              $"Value of Pi: {piString}\n" +
                              $"Bill: {dollarString}\n");
        }
    }
}