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
                {7, 7, 7, 7, 7, 7, 7, 7},
                {10, 8, 9, 11, 12, 9, 8, 10}
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

                                string imagePathPawn = "../../../Content/white_pawn.png";
                                
                                System.Windows.Shapes.Rectangle pawnPiece = GeneratePiece(imagePathPawn, row, col, gameGrid);

                                Pawn pawn = new Pawn(false, col, row, pawnPiece);

                                break;
                            case 2:
                                //string imagePathKnight = "../../../Content/white_knight.png";

                                //System.Windows.Shapes.Rectangle knightPiece = GeneratePiece(imagePathKnight, row, col, gameGrid);

                                //Knight

                                break;
                            case 3:
                                string imagepathBishop = "../../../Content/white_bishop.png";

                                System.Windows.Shapes.Rectangle bishopPiece = GeneratePiece(imagepathBishop, row, col, gameGrid);

                                Bishop bishop = new Bishop(false, col, row, bishopPiece);

                                break;
                            case 4:
                                string imagePathRook = "../../../Content/white_rook.png";

                                System.Windows.Shapes.Rectangle rookPiece = GeneratePiece(imagePathRook, row, col, gameGrid);

                                Rook rook = new Rook(false, col, row);
                                break;
                            case 5:
                                string imagePathKing = "../../../Content/white_king.png";

                                System.Windows.Shapes.Rectangle kingPiece = GeneratePiece(imagePathKing, row, col, gameGrid);

                                King king = new King(false, col, row);
                                break;
                            case 6:
                                string imagePathQueen = "../../../Content/white_queen.png";

                                System.Windows.Shapes.Rectangle queenPiece = GeneratePiece(imagePathQueen, row, col, gameGrid);

                                Queen queen = new Queen(false, col, row);
                                break;
                             case 7:
                                 string imagePathBlackPawn = "../../../Content/black_pawn.png";

                                 System.Windows.Shapes.Rectangle pawnPieceBlack = GeneratePiece(imagePathBlackPawn, row, col, gameGrid);

                                 Pawn pawnBlack = new Pawn(true, col, row, pawnPieceBlack);

                                 break;
                             case 8:
                                 break;
                             case 9:
                                string imagepathBishopBlack = "../../../Content/black_bishop.png";

                                System.Windows.Shapes.Rectangle bishopPieceBlack = GeneratePiece(imagepathBishopBlack, row, col, gameGrid);

                                Bishop bishopBlack = new Bishop(true, col, row, bishopPieceBlack);
                                break;
                             case 10:
                                string imagepathRookBlack = "../../../Content/black_rook.png";

                                System.Windows.Shapes.Rectangle rookPieceBlack = GeneratePiece(imagepathRookBlack, row, col, gameGrid);

                                Rook rookBlack = new Rook(true, col, row);
                                break;

                             case 11:
                                string imagepathKingBlack = "../../../Content/black_king.png";

                                System.Windows.Shapes.Rectangle kingPieceBlack = GeneratePiece(imagepathKingBlack, row, col, gameGrid);

                                King kingBlack = new King(true, col, row);
                                break;

                             case 12:
                                string imagepathQueenBlack = "../../../Content/black_queen.png";

                                System.Windows.Shapes.Rectangle queenPieceBlack = GeneratePiece(imagepathQueenBlack, row, col, gameGrid);

                                Queen queenBlack = new Queen(true, col, row);
                                 break;

                     
                        }

                    }
                }
            }
        }
        private System.Windows.Shapes.Rectangle GeneratePiece(string filepath, int row, int col, Grid gameGrid)
        {
            BitmapImage bitmap = new BitmapImage(new Uri(filepath, UriKind.RelativeOrAbsolute));

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

            return pieceRectangle;

        }
        public Grid gameGrid;
    }
}
