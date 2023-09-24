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

        public bool IsValidMove(int sourceX, int sourceY, int targetX, int targetY)
        {
            if (sourceX == targetX && sourceY == targetY)
            {
                return false;
            }

            int dx = Math.Abs(targetX - sourceX);
            int dy = Math.Abs(targetY - sourceY);

            if (dx == 0 || dy == 0 || dx == dy)
            {
                return true; 
            }

            return false;
        }


        private int moveDist;
        private bool isDiagonal;
        private bool isHorizontal;
    }
   
}
