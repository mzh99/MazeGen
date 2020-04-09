namespace MazeGen {

   public interface IMazeRect {
      CellGrid Generate(int numRows, int numCols, int seed);
   }

}
