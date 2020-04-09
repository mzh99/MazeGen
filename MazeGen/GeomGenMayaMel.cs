using System.Text;

namespace MazeGen {

   public class GeomGenMayaMel: IGeometryGenerator {

      private float wallHeightMeters = 0;
      private float wallWidthMeters = 0;
      private float wallThicknessMeters = 0;

      public string GenerateAll(CellGrid grid, float wallHeight, float wallWidth, float wallThickness) {
         string wallName;

         this.wallHeightMeters = wallHeight;
         this.wallWidthMeters = wallWidth;
         this.wallThicknessMeters = wallThickness;

         float halfWidth = wallWidthMeters / 2.0f;
         var sb = new StringBuilder();
         sb.AppendLine("string $groupCmd = \"group -w -name Maze_G \";");
         sb.AppendLine("string $wall[];");
         sb.AppendLine("string $proj;");
         for (int row = 0; row < grid.NumRows; row++) {
            for (int col = 0; col < grid.NumCols; col++) {
               // We only need to draw S and E walls for each cell
               if (grid[row, col].HasWall(WallDir.East)) {
                  wallName = MayaMelGetWalllName(row, col, WallDir.East);
                  sb.AppendLine(MayaMelGenWall(wallName));
                  sb.AppendLine($"setAttr \"{wallName}.translateX\" {col * wallWidthMeters + wallWidthMeters};");
                  sb.AppendLine($"setAttr \"{wallName}.translateZ\" {row * wallWidthMeters + halfWidth};");
                  sb.AppendLine($"setAttr \"{wallName}.rotateY\" 90;");
                  sb.AppendLine($"$groupCmd += \" {wallName}\";");
               }
               if (grid[row, col].HasWall(WallDir.South)) {
                  wallName = MayaMelGetWalllName(row, col,WallDir.South);
                  sb.AppendLine(MayaMelGenWall(wallName));
                  sb.AppendLine($"setAttr \"{wallName}.translateX\" {col * wallWidthMeters + halfWidth};");
                  sb.AppendLine($"setAttr \"{wallName}.translateZ\" {row * wallWidthMeters + wallWidthMeters};");
                  sb.AppendLine($"$groupCmd += \" {wallName}\";");
               }
               // generate N container wall if first row
               if (row == 0) {
                  wallName = MayaMelGetWalllName(row, col,WallDir.North);
                  sb.AppendLine(MayaMelGenWall(wallName));
                  sb.AppendLine($"setAttr \"{wallName}.translateX\" {col * wallWidthMeters + halfWidth};");
                  sb.AppendLine($"setAttr \"{wallName}.translateZ\" 0;");
                  sb.AppendLine($"$groupCmd += \" {wallName}\";");
               }
               // paint W container wall if first column
               if (col == 0) {
                  wallName = MayaMelGetWalllName(row, col,WallDir.West);
                  sb.AppendLine(MayaMelGenWall(wallName));
                  sb.AppendLine($"setAttr \"{wallName}.translateX\" 0;");
                  sb.AppendLine($"setAttr \"{wallName}.translateZ\" {row * wallWidthMeters + halfWidth};");
                  sb.AppendLine($"setAttr \"{wallName}.rotateY\" 90;");
                  sb.AppendLine($"$groupCmd += \" {wallName}\";");
               }
            }
         }
         sb.AppendLine("eval($groupCmd);");
         return sb.ToString();
      }

      private string MayaMelGetWalllName(int row, int col, WallDir dir) {
         return $"WallR{row + 1}C{col + 1}{dir}";
      }

      private string MayaMelGenWall(string wallName) {
         // create cube for a wall with no construction history and just 1 division on each axis
         const string MayaWallGen = "$wall = `polyCube -w 1 -h 1 -d 1 -sx 1 -sy 1 -sz 1 -ax 0 1 0 -cuv 4 -ch 0`;";

         float uvSideOffset = (wallThicknessMeters / wallWidthMeters) / 2.0f;
         float uvTopOffset = (wallThicknessMeters / wallHeightMeters) / 2.0f;

         StringBuilder mel = new StringBuilder();
         mel.AppendLine(MayaWallGen);
         mel.AppendLine($"rename $wall[0] \"{wallName}\";");

         mel.AppendLine($"setAttr \"{wallName}.scaleZ\" {wallThicknessMeters};");
         mel.AppendLine($"setAttr \"{wallName}.scaleX\" {wallWidthMeters};");
         mel.AppendLine($"setAttr \"{wallName}.scaleY\" {wallHeightMeters};");

         // setup UVs based on axis projections
         // front and back faces (0 & 2)
         mel.AppendLine($"polyProjection -ch 0 -type Planar -ibd on -md z {wallName}.f[0] {wallName}.f[2];");
         // top and bottom faces (1 & 3)
         mel.AppendLine($"polyProjection -ch 0 -type Planar -ibd on -kir -md y  -icx 0.5 -icy {uvTopOffset} {wallName}.f[1] {wallName}.f[3];");
         // side faces (4 & 5) with projection and moving uvs to start of U
         mel.AppendLine($"polyProjection -ch 0 -type Planar -ibd on -kir -md x -icx {uvSideOffset} -icy 0.5 {wallName}.f[4:5];");
         // raise wall to half wall height
         mel.AppendLine($"setAttr \"{wallName}.translateY\" {wallHeightMeters / 2.0f};");
         return mel.ToString();
      }

   }

}
