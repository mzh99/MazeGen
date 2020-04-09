namespace MazeGen {
   partial class Main_Frm {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.Top_Pnl = new System.Windows.Forms.Panel();
         this.ShowSampleWF_Btn = new System.Windows.Forms.Button();
         this.Seed_EB = new System.Windows.Forms.NumericUpDown();
         this.label4 = new System.Windows.Forms.Label();
         this.Alg_CB = new System.Windows.Forms.ComboBox();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.Rows_EB = new System.Windows.Forms.NumericUpDown();
         this.label1 = new System.Windows.Forms.Label();
         this.Cols_EB = new System.Windows.Forms.NumericUpDown();
         this.Generate_Btn = new System.Windows.Forms.Button();
         this.Bottom_Pnl = new System.Windows.Forms.Panel();
         this.label8 = new System.Windows.Forms.Label();
         this.WallThickness_EB = new System.Windows.Forms.NumericUpDown();
         this.label7 = new System.Windows.Forms.Label();
         this.WallWidth_EB = new System.Windows.Forms.NumericUpDown();
         this.label6 = new System.Windows.Forms.Label();
         this.WallHeight_EB = new System.Windows.Forms.NumericUpDown();
         this.GeomGen_Btn = new System.Windows.Forms.Button();
         this.GeomOut_CB = new System.Windows.Forms.ComboBox();
         this.label5 = new System.Windows.Forms.Label();
         this.Middle_Pnl = new System.Windows.Forms.Panel();
         this.Output_TB = new System.Windows.Forms.TextBox();
         this.Top_Pnl.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.Seed_EB)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.Rows_EB)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.Cols_EB)).BeginInit();
         this.Bottom_Pnl.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.WallThickness_EB)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.WallWidth_EB)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.WallHeight_EB)).BeginInit();
         this.Middle_Pnl.SuspendLayout();
         this.SuspendLayout();
         // 
         // Top_Pnl
         // 
         this.Top_Pnl.Controls.Add(this.ShowSampleWF_Btn);
         this.Top_Pnl.Controls.Add(this.Seed_EB);
         this.Top_Pnl.Controls.Add(this.label4);
         this.Top_Pnl.Controls.Add(this.Alg_CB);
         this.Top_Pnl.Controls.Add(this.label3);
         this.Top_Pnl.Controls.Add(this.label2);
         this.Top_Pnl.Controls.Add(this.Rows_EB);
         this.Top_Pnl.Controls.Add(this.label1);
         this.Top_Pnl.Controls.Add(this.Cols_EB);
         this.Top_Pnl.Controls.Add(this.Generate_Btn);
         this.Top_Pnl.Dock = System.Windows.Forms.DockStyle.Top;
         this.Top_Pnl.Location = new System.Drawing.Point(0, 0);
         this.Top_Pnl.Name = "Top_Pnl";
         this.Top_Pnl.Size = new System.Drawing.Size(1184, 81);
         this.Top_Pnl.TabIndex = 52;
         // 
         // ShowSampleWF_Btn
         // 
         this.ShowSampleWF_Btn.Location = new System.Drawing.Point(668, 25);
         this.ShowSampleWF_Btn.Name = "ShowSampleWF_Btn";
         this.ShowSampleWF_Btn.Size = new System.Drawing.Size(188, 36);
         this.ShowSampleWF_Btn.TabIndex = 62;
         this.ShowSampleWF_Btn.Text = "Show Sample Draw";
         this.ShowSampleWF_Btn.UseVisualStyleBackColor = true;
         this.ShowSampleWF_Btn.Click += new System.EventHandler(this.ShowSampleWF_Btn_Click);
         // 
         // Seed_EB
         // 
         this.Seed_EB.Location = new System.Drawing.Point(425, 38);
         this.Seed_EB.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
         this.Seed_EB.Name = "Seed_EB";
         this.Seed_EB.Size = new System.Drawing.Size(124, 24);
         this.Seed_EB.TabIndex = 59;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(425, 15);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(128, 18);
         this.label4.TabIndex = 57;
         this.label4.Text = "Seed (0=random):";
         this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // Alg_CB
         // 
         this.Alg_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.Alg_CB.FormattingEnabled = true;
         this.Alg_CB.Items.AddRange(new object[] {
            "Recursive Backtracker"});
         this.Alg_CB.Location = new System.Drawing.Point(207, 37);
         this.Alg_CB.Name = "Alg_CB";
         this.Alg_CB.Size = new System.Drawing.Size(199, 26);
         this.Alg_CB.TabIndex = 58;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(207, 15);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(192, 18);
         this.label3.TabIndex = 56;
         this.label3.Text = "Maze Generation Algorithm:";
         this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(110, 16);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(51, 18);
         this.label2.TabIndex = 55;
         this.label2.Text = "Rows:";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // Rows_EB
         // 
         this.Rows_EB.Location = new System.Drawing.Point(110, 37);
         this.Rows_EB.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
         this.Rows_EB.Name = "Rows_EB";
         this.Rows_EB.Size = new System.Drawing.Size(72, 24);
         this.Rows_EB.TabIndex = 54;
         this.Rows_EB.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(17, 16);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(72, 18);
         this.label1.TabIndex = 53;
         this.label1.Text = "Columns:";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // Cols_EB
         // 
         this.Cols_EB.Location = new System.Drawing.Point(17, 37);
         this.Cols_EB.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
         this.Cols_EB.Name = "Cols_EB";
         this.Cols_EB.Size = new System.Drawing.Size(72, 24);
         this.Cols_EB.TabIndex = 52;
         this.Cols_EB.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
         // 
         // Generate_Btn
         // 
         this.Generate_Btn.Location = new System.Drawing.Point(1030, 30);
         this.Generate_Btn.Name = "Generate_Btn";
         this.Generate_Btn.Size = new System.Drawing.Size(119, 36);
         this.Generate_Btn.TabIndex = 60;
         this.Generate_Btn.Text = "Generate";
         this.Generate_Btn.UseVisualStyleBackColor = true;
         this.Generate_Btn.Click += new System.EventHandler(this.Generate_Btn_Click);
         // 
         // Bottom_Pnl
         // 
         this.Bottom_Pnl.Controls.Add(this.label8);
         this.Bottom_Pnl.Controls.Add(this.WallThickness_EB);
         this.Bottom_Pnl.Controls.Add(this.label7);
         this.Bottom_Pnl.Controls.Add(this.WallWidth_EB);
         this.Bottom_Pnl.Controls.Add(this.label6);
         this.Bottom_Pnl.Controls.Add(this.WallHeight_EB);
         this.Bottom_Pnl.Controls.Add(this.GeomGen_Btn);
         this.Bottom_Pnl.Controls.Add(this.GeomOut_CB);
         this.Bottom_Pnl.Controls.Add(this.label5);
         this.Bottom_Pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.Bottom_Pnl.Location = new System.Drawing.Point(0, 890);
         this.Bottom_Pnl.Name = "Bottom_Pnl";
         this.Bottom_Pnl.Size = new System.Drawing.Size(1184, 71);
         this.Bottom_Pnl.TabIndex = 53;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(831, 30);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(80, 18);
         this.label8.TabIndex = 127;
         this.label8.Text = "Thickness:";
         this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // WallThickness_EB
         // 
         this.WallThickness_EB.DecimalPlaces = 3;
         this.WallThickness_EB.Location = new System.Drawing.Point(917, 26);
         this.WallThickness_EB.Name = "WallThickness_EB";
         this.WallThickness_EB.Size = new System.Drawing.Size(86, 24);
         this.WallThickness_EB.TabIndex = 123;
         this.WallThickness_EB.Value = new decimal(new int[] {
            75,
            0,
            0,
            196608});
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(665, 30);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(50, 18);
         this.label7.TabIndex = 125;
         this.label7.Text = "Width:";
         this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // WallWidth_EB
         // 
         this.WallWidth_EB.DecimalPlaces = 3;
         this.WallWidth_EB.Location = new System.Drawing.Point(721, 27);
         this.WallWidth_EB.Name = "WallWidth_EB";
         this.WallWidth_EB.Size = new System.Drawing.Size(95, 24);
         this.WallWidth_EB.TabIndex = 122;
         this.WallWidth_EB.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(462, 28);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(87, 18);
         this.label6.TabIndex = 123;
         this.label6.Text = "Wall Height:";
         this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // WallHeight_EB
         // 
         this.WallHeight_EB.DecimalPlaces = 3;
         this.WallHeight_EB.Location = new System.Drawing.Point(555, 26);
         this.WallHeight_EB.Name = "WallHeight_EB";
         this.WallHeight_EB.Size = new System.Drawing.Size(95, 24);
         this.WallHeight_EB.TabIndex = 121;
         this.WallHeight_EB.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
         // 
         // GeomGen_Btn
         // 
         this.GeomGen_Btn.Location = new System.Drawing.Point(1027, 19);
         this.GeomGen_Btn.Name = "GeomGen_Btn";
         this.GeomGen_Btn.Size = new System.Drawing.Size(125, 36);
         this.GeomGen_Btn.TabIndex = 151;
         this.GeomGen_Btn.Text = "Generate";
         this.GeomGen_Btn.UseVisualStyleBackColor = true;
         this.GeomGen_Btn.Click += new System.EventHandler(this.GeomGen_Btn_Click);
         // 
         // GeomOut_CB
         // 
         this.GeomOut_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.GeomOut_CB.FormattingEnabled = true;
         this.GeomOut_CB.Items.AddRange(new object[] {
            "Maya Mel Script (Meters)",
            "Windows Form Graphics Draw (Pixels)"});
         this.GeomOut_CB.Location = new System.Drawing.Point(97, 27);
         this.GeomOut_CB.Name = "GeomOut_CB";
         this.GeomOut_CB.Size = new System.Drawing.Size(327, 26);
         this.GeomOut_CB.TabIndex = 101;
         this.GeomOut_CB.SelectedIndexChanged += new System.EventHandler(this.GeomOut_CB_SelectedIndexChanged);
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(13, 29);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(78, 18);
         this.label5.TabIndex = 59;
         this.label5.Text = "Geometry:";
         this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // Middle_Pnl
         // 
         this.Middle_Pnl.Controls.Add(this.Output_TB);
         this.Middle_Pnl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.Middle_Pnl.Location = new System.Drawing.Point(0, 81);
         this.Middle_Pnl.Name = "Middle_Pnl";
         this.Middle_Pnl.Size = new System.Drawing.Size(1184, 809);
         this.Middle_Pnl.TabIndex = 54;
         // 
         // Output_TB
         // 
         this.Output_TB.AcceptsReturn = true;
         this.Output_TB.Dock = System.Windows.Forms.DockStyle.Fill;
         this.Output_TB.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Output_TB.Location = new System.Drawing.Point(0, 0);
         this.Output_TB.Multiline = true;
         this.Output_TB.Name = "Output_TB";
         this.Output_TB.ReadOnly = true;
         this.Output_TB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.Output_TB.Size = new System.Drawing.Size(1184, 809);
         this.Output_TB.TabIndex = 6;
         this.Output_TB.WordWrap = false;
         // 
         // Main_Frm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1184, 961);
         this.Controls.Add(this.Middle_Pnl);
         this.Controls.Add(this.Bottom_Pnl);
         this.Controls.Add(this.Top_Pnl);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "Main_Frm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Maze Generation";
         this.Top_Pnl.ResumeLayout(false);
         this.Top_Pnl.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.Seed_EB)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.Rows_EB)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.Cols_EB)).EndInit();
         this.Bottom_Pnl.ResumeLayout(false);
         this.Bottom_Pnl.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.WallThickness_EB)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.WallWidth_EB)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.WallHeight_EB)).EndInit();
         this.Middle_Pnl.ResumeLayout(false);
         this.Middle_Pnl.PerformLayout();
         this.ResumeLayout(false);

      }

        #endregion

        private System.Windows.Forms.Panel Top_Pnl;
        private System.Windows.Forms.NumericUpDown Seed_EB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Alg_CB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Rows_EB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Cols_EB;
        private System.Windows.Forms.Button Generate_Btn;
        private System.Windows.Forms.Panel Bottom_Pnl;
        private System.Windows.Forms.Panel Middle_Pnl;
        private System.Windows.Forms.TextBox Output_TB;
        private System.Windows.Forms.Button GeomGen_Btn;
        private System.Windows.Forms.ComboBox GeomOut_CB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown WallWidth_EB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown WallHeight_EB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown WallThickness_EB;
      private System.Windows.Forms.Button ShowSampleWF_Btn;
   }
}

