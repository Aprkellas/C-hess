using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C___hess.Models
{
    class Rook : Piece
    {
        public Rook(bool isWhite, int x, int y ) : base(isWhite, x,y)
        {
            moveDist = 20;
            isDiagonal = false;
            isHorizontal = true;
        }
    }
}
