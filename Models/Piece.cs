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
                if (dx <= moveDist && dy <= moveDist)
                {
                    return true;
                }

            }
            return false;
        }
        
        public bool IsWhite { get; }
        private int moveDirection;
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsCaptured { get; set; }
        public int moveDist { get; set; }
        public bool isDiagonal { get; set; }
        public bool isHorizontal { get; set; }

        public int height = 10;
        public int width = 10;

    }
}
