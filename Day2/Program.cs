namespace TryAndCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a number: ");
            //string userInput = Console.ReadLine();
            //try
            //{
            //    int userInputAsInt = int.Parse(userInput);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Format exceptions, please enter the correct type next time.");

            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Overflow Exception, the number was too long");
            //}
            //catch (ArgumentException)
            //{
            //    Console.WriteLine("ArgumentNullException,the value was empty.");
            //}
            //finally
            //{
            //    Console.WriteLine("this is called anyways");
            //}
            int num1 = 5;
            int num2 = 0;
            int result;


            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("can't divide by zero!!");
            }
            Console.ReadKey();
        }
    }
}