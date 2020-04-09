namespace MazeGen {

   public class CellIndex {
      public int Row { get; set; }
      public int Col { get; set; }

      public CellIndex() : this(0, 0) { }

      public CellIndex(int row, int col) {
         this.Row = row;
         this.Col = col;
      }

   }

}
