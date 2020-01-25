namespace ca_project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.Import = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.panelWidthSet = new System.Windows.Forms.TextBox();
            this.panelHeightSet = new System.Windows.Forms.TextBox();
            this.xsize = new System.Windows.Forms.Label();
            this.ySize = new System.Windows.Forms.Label();
            this.setUp = new System.Windows.Forms.Button();
            this.numberOfGrain = new System.Windows.Forms.ComboBox();
            this.randomGrains = new System.Windows.Forms.Button();
            this.simpleGrowth = new System.Windows.Forms.Button();
            this.simpleGrowthVonNeumman = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddInclusion = new System.Windows.Forms.Button();
            this.typeOfInclusion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SizeOfInclusion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountOfInclusion = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ClearSpace = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.NumberOfSelectedBoundaries = new System.Windows.Forms.TextBox();
            this.GenerateSelectedBoundaries = new System.Windows.Forms.Button();
            this.AllBoundaries = new System.Windows.Forms.Button();
            this.GrainBoundarySize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel.Location = new System.Drawing.Point(344, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(300, 300);
            this.panel.TabIndex = 0;
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(6, 27);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(75, 23);
            this.Import.TabIndex = 1;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(104, 27);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(75, 23);
            this.Export.TabIndex = 2;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // panelWidthSet
            // 
            this.panelWidthSet.Location = new System.Drawing.Point(17, 44);
            this.panelWidthSet.Name = "panelWidthSet";
            this.panelWidthSet.Size = new System.Drawing.Size(100, 20);
            this.panelWidthSet.TabIndex = 3;
            // 
            // panelHeightSet
            // 
            this.panelHeightSet.Location = new System.Drawing.Point(145, 44);
            this.panelHeightSet.Name = "panelHeightSet";
            this.panelHeightSet.Size = new System.Drawing.Size(100, 20);
            this.panelHeightSet.TabIndex = 4;
            // 
            // xsize
            // 
            this.xsize.AutoSize = true;
            this.xsize.Location = new System.Drawing.Point(143, 28);
            this.xsize.Name = "xsize";
            this.xsize.Size = new System.Drawing.Size(32, 13);
            this.xsize.TabIndex = 5;
            this.xsize.Text = "xSize";
            // 
            // ySize
            // 
            this.ySize.AutoSize = true;
            this.ySize.Location = new System.Drawing.Point(17, 28);
            this.ySize.Name = "ySize";
            this.ySize.Size = new System.Drawing.Size(32, 13);
            this.ySize.TabIndex = 6;
            this.ySize.Text = "ySize";
            // 
            // setUp
            // 
            this.setUp.Location = new System.Drawing.Point(100, 70);
            this.setUp.Name = "setUp";
            this.setUp.Size = new System.Drawing.Size(75, 23);
            this.setUp.TabIndex = 7;
            this.setUp.Text = "setUp";
            this.setUp.UseVisualStyleBackColor = true;
            this.setUp.Click += new System.EventHandler(this.setUp_Click);
            // 
            // numberOfGrain
            // 
            this.numberOfGrain.FormattingEnabled = true;
            this.numberOfGrain.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.numberOfGrain.Location = new System.Drawing.Point(17, 99);
            this.numberOfGrain.Name = "numberOfGrain";
            this.numberOfGrain.Size = new System.Drawing.Size(121, 21);
            this.numberOfGrain.TabIndex = 8;
            // 
            // randomGrains
            // 
            this.randomGrains.Location = new System.Drawing.Point(145, 99);
            this.randomGrains.Name = "randomGrains";
            this.randomGrains.Size = new System.Drawing.Size(75, 23);
            this.randomGrains.TabIndex = 9;
            this.randomGrains.Text = "randomGrains";
            this.randomGrains.UseVisualStyleBackColor = true;
            this.randomGrains.Click += new System.EventHandler(this.randomGrains_Click);
            // 
            // simpleGrowth
            // 
            this.simpleGrowth.Location = new System.Drawing.Point(17, 29);
            this.simpleGrowth.Name = "simpleGrowth";
            this.simpleGrowth.Size = new System.Drawing.Size(136, 23);
            this.simpleGrowth.TabIndex = 10;
            this.simpleGrowth.Text = "simpleGrowth Moore";
            this.simpleGrowth.UseVisualStyleBackColor = true;
            this.simpleGrowth.Click += new System.EventHandler(this.simpleGrowth_Click);
            // 
            // simpleGrowthVonNeumman
            // 
            this.simpleGrowthVonNeumman.Location = new System.Drawing.Point(17, 58);
            this.simpleGrowthVonNeumman.Name = "simpleGrowthVonNeumman";
            this.simpleGrowthVonNeumman.Size = new System.Drawing.Size(158, 23);
            this.simpleGrowthVonNeumman.TabIndex = 11;
            this.simpleGrowthVonNeumman.Text = "simpleGrowth VonNeumman";
            this.simpleGrowthVonNeumman.UseVisualStyleBackColor = true;
            this.simpleGrowthVonNeumman.Click += new System.EventHandler(this.simpleGrowthVonNeumman_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelWidthSet);
            this.groupBox1.Controls.Add(this.panelHeightSet);
            this.groupBox1.Controls.Add(this.setUp);
            this.groupBox1.Controls.Add(this.ySize);
            this.groupBox1.Controls.Add(this.randomGrains);
            this.groupBox1.Controls.Add(this.xsize);
            this.groupBox1.Controls.Add(this.numberOfGrain);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 140);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SetUp box";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.simpleGrowth);
            this.groupBox2.Controls.Add(this.simpleGrowthVonNeumman);
            this.groupBox2.Location = new System.Drawing.Point(12, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simple Growth";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AddInclusion);
            this.groupBox3.Controls.Add(this.typeOfInclusion);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.SizeOfInclusion);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.AmountOfInclusion);
            this.groupBox3.Location = new System.Drawing.Point(12, 329);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 196);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inclusions";
            // 
            // AddInclusion
            // 
            this.AddInclusion.Location = new System.Drawing.Point(17, 150);
            this.AddInclusion.Name = "AddInclusion";
            this.AddInclusion.Size = new System.Drawing.Size(115, 23);
            this.AddInclusion.TabIndex = 6;
            this.AddInclusion.Text = "Add Inclusion";
            this.AddInclusion.UseVisualStyleBackColor = true;
            this.AddInclusion.Click += new System.EventHandler(this.AddInclusion_Click);
            // 
            // typeOfInclusion
            // 
            this.typeOfInclusion.FormattingEnabled = true;
            this.typeOfInclusion.Items.AddRange(new object[] {
            "circle",
            "square"});
            this.typeOfInclusion.Location = new System.Drawing.Point(17, 123);
            this.typeOfInclusion.Name = "typeOfInclusion";
            this.typeOfInclusion.Size = new System.Drawing.Size(100, 21);
            this.typeOfInclusion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type of inclusion";
            // 
            // SizeOfInclusion
            // 
            this.SizeOfInclusion.Location = new System.Drawing.Point(17, 78);
            this.SizeOfInclusion.Name = "SizeOfInclusion";
            this.SizeOfInclusion.Size = new System.Drawing.Size(100, 20);
            this.SizeOfInclusion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size of Inclusion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount Of Inclusion";
            // 
            // AmountOfInclusion
            // 
            this.AmountOfInclusion.Location = new System.Drawing.Point(17, 35);
            this.AmountOfInclusion.Name = "AmountOfInclusion";
            this.AmountOfInclusion.Size = new System.Drawing.Size(100, 20);
            this.AmountOfInclusion.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ClearSpace);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.NumberOfSelectedBoundaries);
            this.groupBox4.Controls.Add(this.GenerateSelectedBoundaries);
            this.groupBox4.Controls.Add(this.AllBoundaries);
            this.groupBox4.Controls.Add(this.GrainBoundarySize);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(171, 329);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(161, 218);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Grain Boundaries";
            // 
            // ClearSpace
            // 
            this.ClearSpace.Location = new System.Drawing.Point(10, 175);
            this.ClearSpace.Name = "ClearSpace";
            this.ClearSpace.Size = new System.Drawing.Size(123, 23);
            this.ClearSpace.TabIndex = 6;
            this.ClearSpace.Text = "ClearSpace";
            this.ClearSpace.UseVisualStyleBackColor = true;
            this.ClearSpace.Click += new System.EventHandler(this.ClearSpace_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "n boundary grain";
            // 
            // NumberOfSelectedBoundaries
            // 
            this.NumberOfSelectedBoundaries.Location = new System.Drawing.Point(10, 106);
            this.NumberOfSelectedBoundaries.Name = "NumberOfSelectedBoundaries";
            this.NumberOfSelectedBoundaries.Size = new System.Drawing.Size(100, 20);
            this.NumberOfSelectedBoundaries.TabIndex = 4;
            // 
            // GenerateSelectedBoundaries
            // 
            this.GenerateSelectedBoundaries.Location = new System.Drawing.Point(10, 132);
            this.GenerateSelectedBoundaries.Name = "GenerateSelectedBoundaries";
            this.GenerateSelectedBoundaries.Size = new System.Drawing.Size(123, 37);
            this.GenerateSelectedBoundaries.TabIndex = 3;
            this.GenerateSelectedBoundaries.Text = "Generete Selected Boundaries";
            this.GenerateSelectedBoundaries.UseVisualStyleBackColor = true;
            this.GenerateSelectedBoundaries.Click += new System.EventHandler(this.GenerateSelectedBoundaries_Click);
            // 
            // AllBoundaries
            // 
            this.AllBoundaries.Location = new System.Drawing.Point(10, 62);
            this.AllBoundaries.Name = "AllBoundaries";
            this.AllBoundaries.Size = new System.Drawing.Size(123, 23);
            this.AllBoundaries.TabIndex = 2;
            this.AllBoundaries.Text = "GenerateBoundaries";
            this.AllBoundaries.UseVisualStyleBackColor = true;
            this.AllBoundaries.Click += new System.EventHandler(this.AllBoundaries_Click);
            // 
            // GrainBoundarySize
            // 
            this.GrainBoundarySize.Location = new System.Drawing.Point(10, 35);
            this.GrainBoundarySize.Name = "GrainBoundarySize";
            this.GrainBoundarySize.Size = new System.Drawing.Size(100, 20);
            this.GrainBoundarySize.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Grain Boundary Size";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Import);
            this.groupBox5.Controls.Add(this.Export);
            this.groupBox5.Location = new System.Drawing.Point(12, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(199, 60);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Import/export";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 559);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Multiscale Modelling";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.TextBox panelWidthSet;
        private System.Windows.Forms.TextBox panelHeightSet;
        private System.Windows.Forms.Label xsize;
        private System.Windows.Forms.Label ySize;
        private System.Windows.Forms.Button setUp;
        private System.Windows.Forms.ComboBox numberOfGrain;
        private System.Windows.Forms.Button randomGrains;
        private System.Windows.Forms.Button simpleGrowth;
        private System.Windows.Forms.Button simpleGrowthVonNeumman;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox AmountOfInclusion;
        private System.Windows.Forms.Button AddInclusion;
        private System.Windows.Forms.ComboBox typeOfInclusion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SizeOfInclusion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button AllBoundaries;
        private System.Windows.Forms.TextBox GrainBoundarySize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumberOfSelectedBoundaries;
        private System.Windows.Forms.Button GenerateSelectedBoundaries;
        private System.Windows.Forms.Button ClearSpace;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

