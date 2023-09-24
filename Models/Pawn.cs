using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Xps.Serialization;

namespace C___hess.Models
{
    class Pawn : Piece
    {
        public Pawn(bool isWhite, int x, int y) : base(isWhite, x, y)
        {
            moveDist = 1;
            isDiagonal = true;
            isHorizontal = false;
        }
    }
}
