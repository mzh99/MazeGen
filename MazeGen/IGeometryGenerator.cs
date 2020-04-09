namespace MazeGen {

   public interface IGeometryGenerator {
      string GenerateAll(CellGrid grid, float wallHeight, float wallWidth, float wallThickness);
   }

}
