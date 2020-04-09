using System;
using System.Windows.Forms;

namespace MazeGen {

   public partial class Main_Frm: Form {

      private CellGrid grid = null;
      private int numRows = 0;
      private int numCols = 0;
      private int seed = 0;

      public Main_Frm() {
         InitializeComponent();
         Alg_CB.SelectedIndex = 0;
         GeomOut_CB.SelectedIndex = 0;
         GeomGen_Btn.Enabled = false;
      }

      private void Generate_Btn_Click(object sender, EventArgs e) {
         IMazeRect mazeGenAlg = null;
         numRows = (int) Rows_EB.Value;
         numCols = (int) Cols_EB.Value;
         seed = (int) Seed_EB.Value;
         switch (Alg_CB.SelectedIndex) {
            case 0:     // recursive backtracker
               mazeGenAlg = new RecursiveBacktracker();
               break;
         }
         if (mazeGenAlg == null) {
            ShowInfo("Please select a maze-generation algorithm.");
            return;
         }
         grid = mazeGenAlg.Generate(numRows, numCols, seed);
         Output_TB.Text = grid.ToString();
         GeomGen_Btn.Enabled = true;
      }

      private void ShowInfo(string msg) {
         MessageBox.Show(msg, "Information", MessageBoxButtons.OK);
      }

      private void GeomGen_Btn_Click(object sender, EventArgs e) {
         IGeometryGenerator geomGen = null;
         float wallHeightMeters = (float) WallHeight_EB.Value;
         if (wallHeightMeters <= 0) {
            ShowInfo("Wall height must be greater than zero.");
            return;
         }
         float wallWidthMeters = (float) WallWidth_EB.Value;
         if (wallWidthMeters <= 0) {
            ShowInfo("Wall width must be greater than zero.");
            return;
         }
         float wallThicknessMeters = (float) WallThickness_EB.Value;
         if (wallThicknessMeters <= 0) {
            ShowInfo("Wall thickness must be greater than zero.");
            return;
         }
         switch (GeomOut_CB.SelectedIndex) {
            case 0:     // Maya Mel script
               geomGen = new GeomGenMayaMel();
               break;
            case 1:     // WinForms Graphics
               geomGen = new GeomGenWFCartesian();
               break;
         }
         if (geomGen == null) {
            ShowInfo("Please select a geometry generation output type.");
            return;
         }
         Output_TB.Text = geomGen.GenerateAll(grid, wallHeightMeters, wallWidthMeters, wallThicknessMeters);
      }

      private void ShowSampleWF_Btn_Click(object sender, EventArgs e) {
         new TestDraw_Frm().Show();
      }

      private void GeomOut_CB_SelectedIndexChanged(object sender, EventArgs e) {
         switch (GeomOut_CB.SelectedIndex) {
            case 0:     // Maya Mel script
               WallHeight_EB.Value = 4.0m;
               WallWidth_EB.Value = 4.0m;
               WallThickness_EB.Value = 0.075m;
               break;
            case 1:     // WinForms Graphics
               WallHeight_EB.Value = 40m;
               WallWidth_EB.Value = 40m;
               WallThickness_EB.Value = 1m;
               break;
         }
      }
   }

}
