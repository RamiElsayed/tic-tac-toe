using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    public class Board
    {
        public List<string> Choices = new()
        {
            "x1", "x2", "x3", "y1", "y2", "y3", "z1", "z2", "z3"
        };
        public List<WinningPosition> WinningPositions = new()
        {
            new WinningPosition("x1", "x2", "x3"),
            new WinningPosition("y1", "y2", "y3"),
            new WinningPosition("z1", "z2", "z3"),
        };
        public record WinningPosition(string A, string B, string C);
    }
}
