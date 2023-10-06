using C___hess.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace C___hess.ViewModels
{
    class GameViewModel
    {
        public GameViewModel(Grid gamegrid)
        {
            // initlialise game
            LoadComponents(gamegrid);
            gameGrid = gamegrid;
        }
        private void LoadComponents(Grid gameGrid)
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
                if (pieceNumb < 32)
                {
                    switch (piece)
                    {
                        case 0:
                            break;
                        case 1:
                            Pawn pawn = new Pawn(false, pieceNumb, 1);

                            System.Windows.Shapes.Rectangle pieceRectangle = new System.Windows.Shapes.Rectangle
                            {
                                Width = 50,
                                Height = 50,
                                Fill = Brushes.Blue
                            };

                            gameGrid.Children.Add(pieceRectangle);
                            //int column = pieces.GetValue(piece);
                            Grid.SetColumn(pieceRectangle, (pieceNumb / 8));
                            Grid.SetRow(pieceRectangle, 1);

                            break;
                        case 2:
                            break;
                        case 3:
                            Bishop bishop = new Bishop(false, pieceNumb, 0);

                            // add shape


                            break;
                        case 4:
                            Rook rook = new Rook(false, pieceNumb, 0);
                            break;
                        case 5:
                            King king = new King(false, pieceNumb, 0);
                            break;
                        case 6:
                            Queen queen = new Queen(false, pieceNumb, 0);
                            break;

                    }
                }
                else
                {
                    switch (piece)
                    {
                        case 0:
                            break;
                        case 1:
                            Pawn pawn = new Pawn(true, pieceNumb, 6);

                            System.Windows.Shapes.Rectangle pieceRectangle = new System.Windows.Shapes.Rectangle
                            {
                                Width = 50,
                                Height = 50,
                                Fill = Brushes.Blue
                            };

                            gameGrid.Children.Add(pieceRectangle);
                            //int column = pieces.GetValue(piece);
                            Grid.SetColumn(pieceRectangle, (pieceNumb / 8));
                            Grid.SetRow(pieceRectangle, 1);

                            break;
                        case 2:
                            break;
                        case 3:
                            Bishop bishop = new Bishop(true, pieceNumb, 7);

                            // add shape


                            break;
                        case 4:
                            Rook rook = new Rook(true, pieceNumb, 7);
                            break;
                        case 5:
                            King king = new King(true, pieceNumb, 7);
                            break;
                        case 6:
                            Queen queen = new Queen(true, pieceNumb, 7);
                            break;

                    }
                    pieceNumb++;
                }
            }
        }
        public Grid gameGrid;
    }
}
