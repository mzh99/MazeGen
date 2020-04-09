using System;

namespace MazeGen {

   public enum WallDir { North, East, South, West }

   public class Cell {

      private readonly bool[] walls = new bool[4];

      // custom indexer for walls (for convenience)
      public bool this[WallDir dir] {
         get { return IsValidEnum(dir) ? walls[(int) dir] : false; }
         set {
            if (IsValidEnum(dir)) {
               walls[(int) dir] = value;
            }
         }
      }

      public CellIndex Point { get; private set; }
      public bool Visited { get; set; }

      public Cell(int row, int col) {
         this.Point = new CellIndex(row, col);
         this.Visited = false;
         SetWalls(true);
      }

      public void SetWall(WallDir dir, bool status) {
         this[dir] = status;
      }

      public void SetWalls(bool status) {
         SetWall(WallDir.North, status);
         SetWall(WallDir.South, status);
         SetWall(WallDir.East, status);
         SetWall(WallDir.West, status);
      }

      public bool HasWall(WallDir dir) {
         return this[dir];
      }

      private bool IsValidEnum(WallDir dir) {
         return Enum.IsDefined(typeof(WallDir), dir);
      }

      public static WallDir GetOppositeWall(WallDir dir) {
         switch (dir) {
            case WallDir.North:
               return WallDir.South;
            case WallDir.East:
               return WallDir.West;
            case WallDir.South:
               return WallDir.North;
            case WallDir.West:
               return WallDir.East;
         }
         throw new ArgumentException("Invalid Wall direction enum");
      }

   }

}
