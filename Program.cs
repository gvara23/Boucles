namespace Boucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array
            string[] moves = new string[32];
            int numberOfMoves = 0;

            // Boucle for the movements
            while (numberOfMoves < 32)
            {
                Console.WriteLine("Enter a danse move then write 'done' when you finished :");
                string move = Console.ReadLine();

                // if the word is done end the boucle of asking the danse moves :)
                if (move.ToLower() == "done")
                {
                    break;
                }

                // Add the movement to the array while i dont write 'done' 
                moves[numberOfMoves] = move;
                numberOfMoves++;
            }

            // then ask how many times you wanna do the boucle of movements 
            Console.WriteLine("Enter the number of interactions :");
            int numberOfIterations = int.Parse(Console.ReadLine());

            // Boucle for the repetition of the actions
            for (int i = 0; i < numberOfIterations; i++)
            {
                Console.WriteLine("Danse combo " + (i + 1) + ":");

                // the write of the movements like I...
                for (int danse = 0; danse < numberOfMoves; danse++)
                {
                    Console.WriteLine(moves[danse]);
                }

                Console.WriteLine();
            }
        }
    }
}
