using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MazeGen {

   public class RecursiveBacktracker: IMazeRect {

      // Do not new Random each time as you'll likely get repeat seeding. Best to init once as static
      private Random rnd = new Random();

      private readonly Stack stack = new Stack();     // used to avoid recursion with normally limited stacks
      private CellGrid grid = null;

      /// <summary>Generate Maze using Recursive backtracker algorithm. Refer to: https://en.wikipedia.org/wiki/Maze_generation_algorithm </summary>
      /// <remarks>
      /// Algorithm from wiki:
      /// Choose the initial cell, mark it as visited and push it to the stack
      ///  While the stack is not empty
      ///      Pop a cell from the stack and make it a current cell
      ///      If the current cell has any neighbours which have not been visited
      ///      Push the current cell to the stack
      ///      Choose one of the unvisited neighbours
      ///      Remove the wall between the current cell and the chosen cell
      ///      Mark the chosen cell as visited and push it to the stack
      /// </remarks>
      public CellGrid Generate(int numRows, int numCols, int seed) {
         grid = new CellGrid(numRows, numCols);
         // reseed PRNG if needed
         if (seed > 0) {
            rnd = new Random(seed);
         }
         Cell currCell;
         stack.Clear();
         var startCell = grid[rnd.Next(numRows), rnd.Next(numCols)];   // get random cell
         startCell.Visited = true;
         stack.Push(startCell);
         while (stack.Count > 0) {
            currCell = (Cell) stack.Pop();
            var neighbors = CellGrid.UnvisitedNeighbors(grid, currCell);
            if (neighbors.Any()) {
               stack.Push(currCell);
               var cellRef = GetRandomCellRef(neighbors);   // get one of the
               currCell.SetWall(cellRef.Direction, false);  // turn off wall on current cell
               var oppositeWallDir = Cell.GetOppositeWall(cellRef.Direction);  // get chosen cell opposite wall to remove
               grid[cellRef.CellIndex.Row, cellRef.CellIndex.Col].SetWall(oppositeWallDir, false);   // turn off wall on selected adjacent cell
               grid[cellRef.CellIndex.Row, cellRef.CellIndex.Col].Visited = true;  // chosen cell is now visited
               stack.Push(grid[cellRef.CellIndex.Row, cellRef.CellIndex.Col]);     // chosen cell is pushed on stack
            }
         }

         return grid;
      }

      private CellRef GetRandomCellRef(IEnumerable<CellRef> cells) {
         var cellArray = cells.ToArray();
         Debug.Assert(cellArray.Length > 0, "Neighbor cell array is empty in GetRandomCellRef()");
         return (cellArray.Length == 1) ? cellArray[0] : cellArray[rnd.Next(cellArray.Length)];
      }

   }

}
