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
        public Pawn(bool isWhite, int x, int y, System.Windows.Shapes.Rectangle pieceRectangle) : base(isWhite, x, y)
        {
            pawnRectanlge = pieceRectangle;
            moveDist = 1;
            isDiagonal = true;
            isHorizontal = false;
        }

        public System.Windows.Shapes.Rectangle pawnRectanlge;

    }
}
