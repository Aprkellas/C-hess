using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C___hess.Models
{
    class Bishop : Piece
    {
        public Bishop(bool isWhite, int x, int y, System.Windows.Shapes.Rectangle pieceRectangle) : base(isWhite, x, y)
        {
            bishopRectanlge = pieceRectangle;
            moveDist = 20;
            isDiagonal = true;
            isHorizontal = false;
        }
        public System.Windows.Shapes.Rectangle bishopRectanlge;

    }
}
