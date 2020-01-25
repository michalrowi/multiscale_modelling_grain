using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ca_project
{
    public partial class Form1 : Form
    {
        private readonly Random _rand = new Random(0);

        //Structure represent Each Grain. Value is the color represation.
        // Boundary is information - is this grain boundary?
        // Boundary direction is help for drawing to which direction should be created boundare if size is bigger than 1
        private struct Structure
        {
            public int Value;
            public bool Boundary;
            public string BoundaryDirection;
        }

        private Graphics _graphics;
        private int _numberOfGrains;
        private int _panelHeight;
        private int _panelWidth;
        private int[] _valueOfGrain;
        private Structure[,] _table;
        private Structure[,] _tableNew;
        private int _sizeOfInclusion;
        private int _amountOfInclusion;
        private int _sizeOfBoundaries;
        private int _numberOfSelectedBoundaries;

        private int _x, _y;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //Method for import file
        private void Import_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog {Filter = @"Text File | *.txt"};


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var sr = new StreamReader(openFileDialog.FileName);

                var tokens = sr.ReadLine().Split();

                _panelHeight = int.Parse(tokens[0]);
                _panelWidth = int.Parse(tokens[1]);

                if (_panelHeight >= 50 && _panelHeight <= 600 && _panelWidth >= 50 && _panelWidth <= 600)
                {
                    panelHeightSet.Text = Convert.ToString(_panelHeight);
                    panelWidthSet.Text = Convert.ToString(_panelWidth);

                    SetUpPanel();
                }
                else
                {
                    MessageBox.Show(@"Size is wrong", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                while (sr.Peek() > -1)
                {
                    var line = sr.ReadLine().Split();
                    var i = int.Parse(line[0]);
                    var j = int.Parse(line[1]);
                    _tableNew[i, j].Value = int.Parse(line[2]);
                }
            }

            DrawOnPanel();
        }

        //Method for export file
        private void Export_Click(object sender, EventArgs e)
        {
            var exportFileDialog = new SaveFileDialog
            {
                FileName = "DefaultOutputName.txt", Filter = @"Text File | *.txt"
            };


            if (exportFileDialog.ShowDialog() == DialogResult.OK)
            {
                var sw = new StreamWriter(exportFileDialog.FileName);
                sw.WriteLine(Convert.ToString(_panelHeight) + " " + Convert.ToString(_panelWidth));


                for (var i = 0; i < _panelHeight; i++)
                for (var j = 0; j < _panelWidth; j++)
                {
                    sw.WriteLine(Convert.ToString(i + " " + j + " " + _tableNew[i, j].Value));

                    sw.Flush();
                }
            }
        }
    
        //Method to draw on each grain of Panel
        private void DrawOnPanel()
        {
            for (var i = 1; i < _panelHeight - 2; i++)
            for (var j = 1; j < _panelWidth - 2; j++)
                Draw(_tableNew[i, j].Value, i, j);
        }

        //Method to draw on current grain with x,y position and i value
        // 'i' value represent colors of grains - 8 colors
        private void Draw(int i, int x, int y)
        {
            var pens = new List<Pen>
            {
                Pens.White, Pens.Blue, Pens.ForestGreen, Pens.DarkOrchid, Pens.Firebrick, Pens.Orange, Pens.Aqua,
                Pens.Yellow, Pens.Chartreuse, Pens.Black
            };
            _graphics.DrawEllipse(pens[i], x, y, 1, 1);
        }

        //Method to set up panel to use simulation 
        private void SetUpPanel()
        {
            panel.Size = new Size(_panelHeight,_panelWidth);
            _graphics = panel.CreateGraphics();
            _graphics.Clear(Color.White);
            _table = new Structure[_panelHeight, _panelWidth];
            _tableNew = new Structure[_panelHeight, _panelWidth];
            _valueOfGrain = new int[10];
        }

        //Method called by click to get data from useer about panel (height and width) and set up panel 
        private void setUp_Click(object sender, EventArgs e)
        {
            try
            {
                var tempHeight = Convert.ToInt32(panelHeightSet.Text);
                var tempWidth = Convert.ToInt32(panelWidthSet.Text);

                if (tempHeight >= 50 && tempHeight <= 600 && tempWidth >= 50 && tempWidth <= 600)
                {
                    _panelHeight = tempHeight;
                    _panelWidth = tempWidth;
                    SetUpPanel();
                }
                else
                {
                    MessageBox.Show(@"Program support table from 300 to 600", @"Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show(@"Program needs dimensions of panel", @"Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        //Method to generate random location of grains
        private void RandGrains(int panelHeight, int panelWidth, ref int x, ref int y)
        {
            do
            {
                x = _rand.Next(2, panelHeight - 2);
                y = _rand.Next(2, panelWidth - 2);

            } while (_tableNew[x, y].Value != 0 && _tableNew[x, y].Value != 9);
        }


        //Method to generate random location of center of Inclusion
        private void RandInclusionCenter(int panelHeight, int panelWidth, int inclSize, ref int x, ref int y)
        {

                x = _rand.Next((inclSize/2)+2, panelHeight - 2);
                y = _rand.Next((inclSize / 2) + 2, panelWidth - 2);
            
        }

        //Method to clear Table and Panel -> to be able add inclusion before simulation this method are not cleaning inclusion
        private void ClearTableAndPanel()
        {
            for (var i = 1; i < _panelHeight; i++)
            for (var j = 1; j < _panelWidth; j++)
            {
                if (_tableNew[i, j].Value != 9)
                {                  
                    _tableNew[i, j].Value = 0;
                    _table[i, j].Value = 0;
                }
            }

            DrawOnPanel();
        }

        //Method called by click to button to generate and place on panel random Grains, 1-8 allowed
        private void randomGrains_Click(object sender, EventArgs e)
        {
            ClearTableAndPanel();

            try
            {
                _numberOfGrains = Convert.ToInt32(numberOfGrain.Text);
            }
            catch
            {
                MessageBox.Show(@"You must enter number from 1 to 8", @"Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            for (var i = 1; i <= _numberOfGrains ; i++)
            {
                RandGrains(_panelHeight, _panelWidth, ref _x, ref _y);
                Draw(i, _x, _y);
                _tableNew[_x, _y].Value = i;
            }
        }

        //Method for AlgoritmMoore
        private void SimpleGrowthAlgorithmMoore()
        {
            RewriteTable();
            for (var i = 2; i < _panelHeight - 2; i++)
            for (var j = 2; j < _panelWidth - 2; j++)
                if (_table[i, j].Value == 0)
                {
                    for (var k = 0; k < 9; k++) _valueOfGrain[k] = 0;
                    CheckNeighborhoodMoore(i, j);
                    _tableNew[i, j].Value = ChooseMax();
                    }
        }

        //Method for AlgoritmVonNeumman
        private void SimpleGrowthAlgorithmVonNeumman()
        {
            RewriteTable();
            for (var i = 2; i < _panelHeight - 2; i++)
            for (var j = 2; j < _panelWidth - 2; j++)
                if (_table[i, j].Value == 0)
                {
                    for (var k = 0; k < 9; k++) _valueOfGrain[k] = 0;
                    CheckNeighborhoodVonNeumman(i, j);
                    _tableNew[i, j].Value = ChooseMax();
                }
        }

        //Method for checking Neighborhood - Moore
        private void CheckNeighborhoodMoore(int i, int j)
        {
            if(_valueOfGrain[_table[i - 1, j - 1].Value] !=9)
                _valueOfGrain[_table[i - 1, j - 1].Value]++;
            if (_valueOfGrain[_table[i - 1, j].Value] != 9)
                _valueOfGrain[_table[i - 1, j].Value]++;
            if (_valueOfGrain[_table[i - 1, j + 1].Value] != 9)
                _valueOfGrain[_table[i - 1, j + 1].Value]++;
            if (_valueOfGrain[_table[i, j - 1].Value] != 9)
                _valueOfGrain[_table[i, j - 1].Value]++;
            if (_valueOfGrain[_table[i, j + 1].Value] != 9)
                _valueOfGrain[_table[i, j + 1].Value]++;
            if (_valueOfGrain[_table[i + 1, j - 1].Value] != 9)
                _valueOfGrain[_table[i + 1, j - 1].Value]++;
            if (_valueOfGrain[_table[i + 1, j].Value] != 9)
                _valueOfGrain[_table[i + 1, j].Value]++;
            if (_valueOfGrain[_table[i + 1, j + 1].Value] != 9)
                _valueOfGrain[_table[i + 1, j + 1].Value]++;            
        }

        //Method for checking Neighborhood - Von Neumman -> 
        private void CheckNeighborhoodVonNeumman(int i, int j)
        {
            if (_valueOfGrain[_table[i - 1, j].Value] != 9)
                _valueOfGrain[_table[i - 1, j].Value]++;
            if (_valueOfGrain[_table[i, j - 1].Value] != 9)
                _valueOfGrain[_table[i, j - 1].Value]++;
            if (_valueOfGrain[_table[i, j + 1].Value] != 9)
                _valueOfGrain[_table[i, j + 1].Value]++;
            if (_valueOfGrain[_table[i + 1, j].Value] != 9)
                _valueOfGrain[_table[i + 1, j].Value]++;
        }

        //Choose Maximum from Neightborhood grains
        private int ChooseMax()
        {
            var max = 0;
            var index = 0;
            for (var i = 1; i <= 8; i++)
                if (_valueOfGrain[i] == max)
                {
                }
                else if (_valueOfGrain[i] > max)
                {
                    index = i;
                    max = _valueOfGrain[i];
                }

            return index;
        }

        //Method called by click for Moore Growth
        private void simpleGrowth_Click(object sender, EventArgs e)
        {
            var check = false;
            while (check == false)
            {
                SimpleGrowthAlgorithmMoore();
                check = CheckTable();
            }

            DrawOnPanel();
        }

        //Rewrite table to use new one
        private void RewriteTable()
        {
            for (var i = 0; i < _panelHeight - 1; i++)
            for (var j = 0; j < _panelWidth - 1; j++)
            {
                _table[i, j].Value = _tableNew[i, j].Value;
                _table[i, j].Boundary = _tableNew[i, j].Boundary;
                _table[i, j].BoundaryDirection = _tableNew[i, j].BoundaryDirection;
            }
        }

        //Method called by click for VonNeumman Growth
        private void simpleGrowthVonNeumman_Click(object sender, EventArgs e)
        {
            var check = false;
            while (check == false)
            {
                SimpleGrowthAlgorithmVonNeumman();                
                check = CheckTable();
            }

            DrawOnPanel();
        }

        //Method are checking if Table doesn't have free spaces
        private bool CheckTable()
        {
            for (var i = 2; i < _panelHeight - 2; i++)
            for (var j = 2; j < _panelWidth - 2; j++)
                if (_table[i, j].Value == 0)
                    return false;

            return true;
        }

        //Method called by click to button to generate inclusion choosed by user
        private void AddInclusion_Click(object sender, EventArgs e)
        {
            try
            {
                _sizeOfInclusion = Convert.ToInt32(SizeOfInclusion.Text);
            }
            catch
            {
                MessageBox.Show("You need to add size of Inclusion", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            try
            {
                _amountOfInclusion = Convert.ToInt32(AmountOfInclusion.Text);
            }
            catch
            {
                MessageBox.Show("You need to add amount of Inclusion", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            for (int i = 1; i <= _amountOfInclusion; i++)
            {

                RandInclusionCenter((_panelHeight - _sizeOfInclusion -2), (_panelWidth - _sizeOfInclusion-2),_sizeOfInclusion, ref _x,  ref _y);

                if (typeOfInclusion.Text == "square")
                {
                    for (var k = 0; k < _sizeOfInclusion; k++)
                    {
                        for (int j = 0; j < _sizeOfInclusion; j++)
                        {
                            _tableNew[_x + j, _y +k].Value = 9;
                            Draw(9, _x + j, _y + k);
                        }
                    }
                }

                if (typeOfInclusion.Text == "circle")
                {
                    for (var k = -_sizeOfInclusion; k < _sizeOfInclusion; k++)
                    {
                        for (int j = -_sizeOfInclusion; j < _sizeOfInclusion; j++)
                        {
                            var d = GetDistance(_x, _y, _x + j, _y + k);
                            if (d < (_sizeOfInclusion / 2))
                            {
                                _tableNew[_x + j, _y + k].Value = 9;
                                Draw(9, _x + j, _y + k);
                            }
                        }
                    }
                }

            }
        }

        //Method are checking distance from point to center of inclusion. Used in Circle inclusion.
        private static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        //Method called by click to button -> generate and draw boundaries for all grains
        private void AllBoundaries_Click(object sender, EventArgs e)
        {
            try
            {
                _sizeOfBoundaries = Convert.ToInt32(GrainBoundarySize.Text);
            }
            catch
            {
                MessageBox.Show("You need to add size of Boundaries", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            SetUpBoundaries();
            DrawBoundaries();
        }

        //Method which set up boundaries for all grains
        private void SetUpBoundaries()
        { 
            for (var i = 2; i < _panelHeight - 2; i++)
            {
                for (var j = 2; j < _panelWidth - 2; j++)
                {
                    if (_table[i - 1, j].Value != _table[i, j].Value && _table[i - 1, j].Value !=0)
                    {
                        _tableNew[i, j].Boundary = true;
                        _tableNew[i, j].BoundaryDirection = "x";
                    }

                    if (_table[i + 1, j].Value != _table[i, j].Value && _table[i + 1, j].Value != 0)
                    {
                        _tableNew[i, j].Boundary = true;
                        _tableNew[i, j].BoundaryDirection = "x";
                    }

                    if (_table[i, j - 1].Value != _table[i, j].Value && _table[i, j-1].Value != 0)
                    {
                        _tableNew[i, j].Boundary = true;
                        _tableNew[i, j].BoundaryDirection = "y";
                    }

                    if (_table[i, j + 1].Value != _table[i, j].Value && _table[i, j+1].Value != 0)
                    {
                        _tableNew[i, j].Boundary = true;
                        _tableNew[i, j].BoundaryDirection = "y";
                    }                                       

                }
            }
        }


        //Method which set up boundaries for selected grains
        private void SetUpSelectedBoundaries(int k)
        {
           
            for (var l = 1; l <= k; l++)
            {
                for (var i = 2; i < _panelHeight - 2; i++)
                {
                    for (var j = 2; j < _panelWidth - 2; j++)
                    {
                        if (_table[i - 1, j].Value != _table[i, j].Value && _table[i, j].Value == l && _table[i - 1, j].Value != 0)
                        {
                            _tableNew[i, j].Boundary = true;
                            _tableNew[i, j].BoundaryDirection = "x";
                        }

                        if (_table[i, j - 1].Value != _table[i, j].Value && _table[i, j].Value == l && _table[i, j - 1].Value != 0)
                        {
                            _tableNew[i, j].Boundary = true;
                            _tableNew[i, j].BoundaryDirection = "y";
                        }

                        if (_table[i, j + 1].Value != _table[i, j].Value && _table[i, j].Value == l && _table[i, j + 1].Value != 0)
                        {
                            _tableNew[i, j].Boundary = true;
                            _tableNew[i, j].BoundaryDirection = "y";
                        }

                        if (_table[i + 1, j].Value != _table[i, j].Value && _table[i, j].Value == l && _table[i + 1, j].Value != 0)
                        {
                            _tableNew[i, j].Boundary = true;
                            _tableNew[i, j].BoundaryDirection = "x";
                        }

                    }
                }
            }
        }
        
        //Method which drawing boundaries on Panel for generated boundaries
        private void DrawBoundaries()
        {
            RewriteTable();
            for (var i = 2; i < _panelHeight - 2; i++)
            {
                for (var j = 2; j < _panelWidth - 2; j++)
                {
                    if (_table[i, j].Boundary == true)
                    {
                        for (var s = 0; s < _sizeOfBoundaries; s++)
                        {
                            if (i + s < _panelHeight && j + s < _panelWidth)
                            {
                                if (_table[i, j].BoundaryDirection == "x")
                                {
                                    _tableNew[i + s, j].Value = 9;
                                    Draw(9, i + s, j);
                                }

                                if (_table[i, j].BoundaryDirection == "y")
                                {
                                    _tableNew[i, j+s].Value = 9;
                                    Draw(9, i , j+s);
                                }

                            }
                        }
                    }
                }
            }
        }

        //Method called by click to button -> generate and draw boundaries for selected grains
        private void GenerateSelectedBoundaries_Click(object sender, EventArgs e)
        {
            try
            {
                _sizeOfBoundaries = Convert.ToInt32(GrainBoundarySize.Text);
            }
            catch
            {
                MessageBox.Show("You need to add size of Boundaries", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            try
            {
                _numberOfSelectedBoundaries = Convert.ToInt32(NumberOfSelectedBoundaries.Text);
            }
            catch
            {
                MessageBox.Show("You need to add number of elements where boundaries should be created", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            SetUpSelectedBoundaries(_numberOfSelectedBoundaries);
            DrawBoundaries();
        }
        

        //Method called by click to button. Method are cleaning panel from grains and leave only boundaries on panel.
        private void ClearSpace_Click(object sender, EventArgs e)
        {
            RewriteTable();
            for (var i = 2; i < _panelHeight - 2; i++)
            {
                for (var j = 2; j < _panelWidth - 2; j++)
                {
                    if (_table[i,j].Value!=9)
                    {
                        _tableNew[i, j].Value = 0;
                        Draw(0, i, j );
                    } 
                }
            }
        }

        
    }
}