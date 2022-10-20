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
        public static void PrintInstructions()
        {
            Console.WriteLine("       |      |       ");
            Console.WriteLine("   x1  |  x2  |  x3   ");
            Console.WriteLine(" ______|______|______ ");
            Console.WriteLine("       |      |       ");
            Console.WriteLine("   y1  |  y2  |  y3   ");
            Console.WriteLine(" ______|______|______ ");
            Console.WriteLine("       |      |       ");
            Console.WriteLine("   z1  |  z2  |  z3   ");
            Console.WriteLine("       |      |       ");
            Console.WriteLine("Type one of the moves above");
        }
        public static void PrintEmptyBoard()
        {
            Console.WriteLine("      |     |      ");
            Console.WriteLine("      |     |      ");
            Console.WriteLine(" _____|_____|_____ ");
            Console.WriteLine("      |     |      ");
            Console.WriteLine("      |     |      ");
            Console.WriteLine(" _____|_____|_____ ");
            Console.WriteLine("      |     |      ");
            Console.WriteLine("      |     |      ");
            Console.WriteLine("      |     |      ");
        }
        public static void PrintBoard(Board board)
        {
            Console.WriteLine("      |     |      ");
            PrintValueLine(board, "x", 2);
            Console.WriteLine(" _____|_____|_____ ");
            Console.WriteLine("      |     |      ");
            PrintValueLine(board, "y", 2);
            Console.WriteLine(" _____|_____|_____ ");
            Console.WriteLine("      |     |      ");
            PrintValueLine(board, "z", 2);
            Console.WriteLine("      |     |      ");
        }
        public static void PrintValueLine(Board board, string s, int spacing)
        {
            var one = board.GetValue($"{s}1");
            var two = board.GetValue($"{s}2");
            var three = board.GetValue($"{s}3");

            var spaces = string.Join("", Enumerable.Repeat(" ", spacing));
            var line = $"{spaces}{spaces}{one}{spaces}|{spaces}{two}{spaces}|{spaces}{three}{spaces}";
            Console.WriteLine(line);
        }
    }
    
}
