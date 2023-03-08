namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var faveNumber = r.Next(1, 10);
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < faveNumber)
            {
                Console.WriteLine("The variable is set to tooLow.");
            }
            else if (userInput > faveNumber)
            {
                Console.WriteLine("The variable is set to tooHigh");
            }
              else
            {
                Console.WriteLine("The variable is set to youGuessedIt");
            }
        }
    }
}