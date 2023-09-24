using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C___hess.Models
{
    public abstract class Piece
    {
        public Piece(bool isWhite ,int x, int y)
        {
            IsWhite = isWhite;
            X = x;
            Y = y;
            IsCaptured = false;
        }
        public bool IsWhite { get; }
        private int moveDirection;
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsCaptured { get; set; }


    }
}
