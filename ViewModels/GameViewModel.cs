using C___hess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace C___hess.ViewModels
{
    class GameViewModel
    {
        public GameViewModel(Grid gamegrid)
        {
            // initlialise game
            LoadComponents();
            gameGrid = gamegrid;
        }
        private void LoadComponents()
        {
            int[,] pieces = new int[8, 8]
            {
                {4, 2, 3, 5, 6, 3, 2, 4},
                {1, 1, 1, 1, 1, 1, 1, 1},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {1, 1, 1, 1, 1, 1, 1, 1},
                {4, 2, 3, 5, 6, 3, 2, 4}
            };

            int pieceNumb = 0;

            foreach (int piece in pieces)
            {
                if (pieceNumb < 32) { 
                    switch (piece)
                    {
                        case 0:
                            break;
                        case 1:
                            Pawn pawn = new Pawn(false, pieceNumb, 1);
                            
                            break;
                    }
                } else
                {

                }
                pieceNumb++;
            }
        }
        public Grid gameGrid;
    }
}
