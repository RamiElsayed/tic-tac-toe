namespace tic_tac_toe
{
    class Program {
        static void Main(string[] args)
        {

        }
        public static string RequestChoice(Board board)
        {
            var choice = Console.ReadLine();
            if (!board.Choices.Contains(choice))
            {
                Console.WriteLine("Enter A Valid Choice");
                return RequestChoice(board);
            }

            if (board.GetValue(choice) != " ")
            {
                Console.WriteLine("you can not choose this box, already used");
                return RequestChoice(board);
            }
            return choice;
        }
    }
    
}
