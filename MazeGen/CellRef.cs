namespace MazeGen {

   public class CellRef {
      public CellIndex CellIndex { get; private set; }
      public WallDir Direction { get; private set; }

      public CellRef(int row, int col, WallDir dir): this(new CellIndex(row, col), dir) { }

      public CellRef(CellIndex cellIndex, WallDir dir) {
         this.CellIndex = cellIndex;
         this.Direction = dir;
      }


   }

}
