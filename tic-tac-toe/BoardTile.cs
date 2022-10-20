using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    public class BoardTile
    {
        public BoardTile(string choice)
        {
            Choice = choice;
            Value = " ";
        }

        public string Choice { get; }
        public string Value { get; set; }
    }
}
