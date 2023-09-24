using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C___hess.Models
{
    class Queen : Piece
    {
        public Queen(bool isWhite, int x, int y) : base(isWhite, x, y)
        {
            moveDist = 20;
            isDiagonal = true;
            isHorizontal = true;
        }

        private int moveDist;
        private bool isDiagonal;
        private bool isHorizontal;
    }
   
}
