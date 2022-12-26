using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    public class Board
    {
        private List<BoardTile> Tiles => Choices.Select(x => new BoardTile(x)).ToList();
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
        public string GetValue(string choice)
        {
            return Tiles.Single(x => x.Choice == choice).Value;
        }

        public void SetValue(string choice, string value)
        {
            var tile = Tiles.Single(x => x.Choice == choice);
            tile.Value = value;
        }
        
        public string GetWinner()
        {
            return WinningPositions
                .Select(x => GetWinner(x))
                .FirstOrDefault(x => x.IsWinner)?.Winner;
        }

        private WinResult GetWinner(WinningPosition position)
        {
            var one = GetValue(position.A);
            var two = GetValue(position.B);
            var three = GetValue(position.C);

            if (one != " " && one == two && two == three)
            {
                return WinResult.HasWinner(one);
            }
            return WinResult.NoWinner();
        }
        public class WinResult
        {
            private WinResult(bool isWinner, string winner)
            {
                IsWinner = isWinner;
                Winner = winner;
            }

            public static WinResult HasWinner(string winner)
            {
                return new WinResult(true, winner);
            }

            public static WinResult NoWinner()
            {
                return new WinResult(false, null);
            }

            public bool IsWinner { get; }
            public string Winner { get; }
        }
    }
}
    public record WinningPosition(string A, string B, string C);
}
