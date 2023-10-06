using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C___hess.Models
{
    class King : Piece
    {
        public King(bool isWhite, int x, int y) : base(isWhite, x, y)
        {
            moveDist = 1;
            isDiagonal = true;
            isHorizontal = true;


        }
    }
}
