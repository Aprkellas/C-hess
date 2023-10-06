using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C___hess.Models
{
    class Bishop : Piece
    {
        public Bishop(bool isWhite, int x, int y) : base(isWhite, x, y)
        {
            moveDist = 20;
            isDiagonal = true;
            isHorizontal = false;
        }
    }
}
