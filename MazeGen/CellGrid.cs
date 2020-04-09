using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGen {

   public class CellGrid {

      private readonly Cell[,] Cells = null;

      public int NumRows { get; private set; }
      public int NumCols { get; private set; }

      // custom multidimensional indexer for convenience
      public Cell this[int row, int col] {
         get { return Cells[row, col]; }
         set { Cells[row, col] = value; }
      }

      public CellGrid(int numRows, int numCols) {
         if (numRows <= 1)
            throw new ArgumentOutOfRangeException("Number of rows must be 1 or more");
         if (numCols <= 1)
            throw new ArgumentOutOfRangeException("Number of columns must be 1 or more");
         NumRows = numRows;
         NumCols = numCols;
         Cells = new Cell[NumRows, NumCols];
         for (int row = 0; row < NumRows; row++) {
            for (int col = 0; col < NumCols; col++) {
               Cells[row, col] = new Cell(row, col);
            }
         }
      }

      public override string ToString() {
         const char HorzWallChar = '-';
         const char CornerChar = '+';
         const char VertWallChar = '|';

         const int horzCharsPerCell = 7;
         const int vertCharsPerCell = 4;

         if (NumCols <= 0 || NumRows <= 0 || Cells == null)
            return string.Empty;
         int numRowChars = NumRows * (vertCharsPerCell - 1) + 1;
         int numColChars = NumCols * (horzCharsPerCell - 1) + 1;
         char[,] outChars = new char[numRowChars, numColChars];
         // init to all spaces
         for (int row = 0; row < numRowChars; row++) {
            for (int col = 0; col < numColChars; col++) {
               outChars[row, col] = ' ';
            }
         }
         for (int row = 0; row < NumRows; row++) {
            for (int col = 0; col < NumCols; col++) {
               int rowNdx = row * (vertCharsPerCell - 1);
               int colNdx = col * (horzCharsPerCell - 1);
               // Mark the cell corners
               outChars[rowNdx, colNdx] = CornerChar;
               outChars[rowNdx + vertCharsPerCell - 1, colNdx] = CornerChar;
               outChars[rowNdx, colNdx + horzCharsPerCell - 1] = CornerChar;
               outChars[rowNdx + vertCharsPerCell - 1, colNdx + horzCharsPerCell - 1] = CornerChar;

               // We only need to draw S and E walls for each cell
               if (this[row, col].HasWall(WallDir.East)) {
                  for (int z = 1; z < vertCharsPerCell - 1; z++) {
                     outChars[rowNdx + z, colNdx + horzCharsPerCell - 1] = VertWallChar;
                  }
               }
               if (this[row, col].HasWall(WallDir.South)) {
                  for (int z = 1; z < horzCharsPerCell - 1; z++) {
                     outChars[rowNdx + vertCharsPerCell - 1, colNdx + z] = HorzWallChar;
                  }
               }
               // paint N container wall if first row
               if (row == 0) {
                  if (this[row, col].HasWall(WallDir.North)) {
                     for (int z = 1; z < horzCharsPerCell - 1; z++) {
                        outChars[0, colNdx + z] = HorzWallChar;
                     }
                  }
               }
               // paint W container wall if first column
               if (col == 0) {
                  if (this[row, col].HasWall(WallDir.West)) {
                     for (int z = 1; z < vertCharsPerCell - 1; z++) {
                        outChars[rowNdx + z, 0] = VertWallChar;
                     }
                  }
               }
            }
         }
         // gather the character matrix
         var output = new StringBuilder();
         for (int row = 0; row < numRowChars; row++) {
            for (int col = 0; col < numColChars; col++) {
               output.Append(outChars[row, col]);
            }
            output.AppendLine();
         }

         return output.ToString();
      }

      public static IEnumerable<CellRef> UnvisitedNeighbors(CellGrid grid, Cell cell) {
         // check left of cell
         if (cell.Point.Col > 0) {
            if (grid[cell.Point.Row, cell.Point.Col - 1].Visited == false)
               yield return new CellRef(cell.Point.Row, cell.Point.Col - 1, WallDir.West);
         }
         // check right of cell
         if (cell.Point.Col < grid.NumCols - 1) {
            if (grid[cell.Point.Row, cell.Point.Col + 1].Visited == false)
               yield return new CellRef(cell.Point.Row, cell.Point.Col + 1, WallDir.East);
         }
         // check above cell
         if (cell.Point.Row > 0) {
            if (grid[cell.Point.Row - 1, cell.Point.Col].Visited == false)
               yield return new CellRef(cell.Point.Row - 1, cell.Point.Col, WallDir.North);
         }
         // check below of cell
         if (cell.Point.Row < grid.NumRows - 1) {
            if (grid[cell.Point.Row + 1, cell.Point.Col].Visited == false)
               yield return new CellRef(cell.Point.Row + 1, cell.Point.Col, WallDir.South);
         }

      }


   }

}
