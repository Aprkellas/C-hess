using C___hess.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace C___hess.ViewModels
{
    class GameViewModel
    {
        public GameViewModel(Grid gamegrid)
        {
            // initialise board
            LoadComponents(gamegrid);
            gameGrid = gamegrid;

            // start gameloop
            //GameLoop(gameGrid);
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


            for (int row = 0; row < pieces.GetLength(0); row++)
            {
                for (int col = 0; col < pieces.GetLength(1); col++)
                {
                    int piece = pieces[row, col];
                    if (piece != 0)
                    {
                        switch (piece)
                        {
                            case 0:
                                break;
                            case 1:

                                string imagePath = "../../../Content/white_pawn.png";
                                BitmapImage bitmap = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));

                                ImageBrush imageBrush = new ImageBrush(bitmap);

                                System.Windows.Shapes.Rectangle pieceRectangle = new System.Windows.Shapes.Rectangle
                                {
                                    Width = 50,
                                    Height = 50,
                                    Fill = imageBrush
                                };
                                Grid.SetColumn(pieceRectangle, col);
                                Grid.SetRow(pieceRectangle, row);

                                gameGrid.Children.Add(pieceRectangle);

                                Pawn pawn = new Pawn(false, col, row, pieceRectangle);

                                break;
                            case 2:
                                break;
                            case 3:
                                Bishop bishop = new Bishop(false, col, row);

                                // add shape


                                break;
                            case 4:
                                Rook rook = new Rook(false, col, row);
                                break;
                            case 5:
                                King king = new King(false, col, row);
                                break;
                            case 6:
                                Queen queen = new Queen(false, col, row);
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

                                System.Windows.Shapes.Rectangle pieceRectangle = new System.Windows.Shapes.Rectangle
                                {
                                    Width = 50,
                                    Height = 50,
                                    Fill = Brushes.Red
                                };

                                Grid.SetColumn(pieceRectangle, col);
                                Grid.SetRow(pieceRectangle, row);

                                gameGrid.Children.Add(pieceRectangle);

                                Pawn pawn = new Pawn(true, col, row, pieceRectangle);

                                break;
                            case 2:
                                break;
                            case 3:
                                Bishop bishop = new Bishop(true, col, row);

                                // add shape


                                break;
                            case 4:
                                Rook rook = new Rook(true, col, row);
                                break;
                            case 5:
                                King king = new King(true, col, row);
                                break;
                            case 6:
                                Queen queen = new Queen(true, col, row);
                                break;

                        }

                    }
                }
            }
        }
        public Grid gameGrid;
    }
}
