using System.Text;

namespace MazeGen {

   /// <summary>Geometry generation for Windows Forms Graphics using Cartesian Coordinates</summary>
   public class GeomGenWFCartesian: IGeometryGenerator {

      public string GenerateAll(CellGrid grid, float wallHeight, float wallWidth, float wallThickness) {
         float x1, y1, x2, y2;
         // setup drawing offset in case they want a thickness greater than 1 pixel
         float linethicknessOffset = wallThickness == 1.0f ? 0 : wallThickness / 2.0f;
         var sb = new StringBuilder();
         sb.AppendLine($"// Generation Parameters: Grid={grid.NumCols}x{grid.NumRows} with Wall Width: {wallWidth} Wall Thickness: {wallThickness}");
         sb.AppendLine("Graphics g = e.Graphics;");
         sb.AppendLine("g.SmoothingMode = SmoothingMode.HighQuality;");
         sb.AppendLine($"Pen pen = new Pen(Color.Black, {wallThickness});");
         for (int row = 0; row < grid.NumRows; row++) {
            for (int col = 0; col < grid.NumCols; col++) {
               // We only need to draw S and E walls for each cell
               sb.AppendLine($"// Draw lines for cell at row {row + 1}, column {col + 1}");
               if (grid[row, col].HasWall(WallDir.East)) {
                  x1 = col * wallWidth + wallWidth + linethicknessOffset;
                  y1 = row * wallWidth + linethicknessOffset;
                  x2 = x1;
                  y2 = y1 + wallWidth;
                  sb.AppendLine($"g.DrawLine(pen, {x1}, {y1}, {x2}, {y2});");
               }
               if (grid[row, col].HasWall(WallDir.South)) {
                  x1 = col * wallWidth + linethicknessOffset;
                  y1 = row * wallWidth + wallWidth + linethicknessOffset;
                  x2 = x1 + wallWidth;
                  y2 = y1;
                  sb.AppendLine($"g.DrawLine(pen, {x1}, {y1}, {x2}, {y2});");
               }
            }
         }
         // Draw N wall
         sb.AppendLine("// Draw North wall");
         sb.AppendLine($"g.DrawLine(pen, {linethicknessOffset}, {linethicknessOffset}, {wallWidth * grid.NumCols + linethicknessOffset}, {linethicknessOffset});");
         // Draw W wall
         sb.AppendLine("// Draw West wall");
         sb.AppendLine($"g.DrawLine(pen, {linethicknessOffset}, {linethicknessOffset}, {linethicknessOffset}, {wallWidth * grid.NumRows + linethicknessOffset});");
         return sb.ToString();
      }

   }

}
