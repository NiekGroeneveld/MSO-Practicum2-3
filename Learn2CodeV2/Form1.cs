
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Learn2CodeV2
{
    public partial class GridPanel : Form
    {
        private ConsoleTextBox _consoleOutput;

        private Grid _grid;
        public GridPanel()
        {
            InitializeComponent();


            // Create the console box
            _consoleOutput = new ConsoleTextBox();
            _consoleOutput.Location = new Point(400, 410);  // X=12, Y=12 pixels from top-left
            _consoleOutput.Size = new Size(400, 120);     // Width=400, Height=300
            this.Controls.Add(_consoleOutput);            // Add it to the form

            _grid = new Grid(100, 100, false);

        }
        string[] _arrayCommands = Array.Empty<string>();
        int _indentLevel = 0;


        private void DisplayCommandsInBlock(String[] commandListString, int indentLevel = 0)
        {
            // Clear existing items if it's the top-level call
            if (indentLevel == 0)
            {
                flowPanelCommandsStrings.Controls.Clear();
            }

            // Iterate through commands to display each in the FlowLayoutPanel
            foreach (var command in commandListString)
            {
                // Format the command text to show only relevant information
                indentLevel = command.TakeWhile(c => c == ' ').Count();
                string commandText = new string(' ', indentLevel * 4) + command;


                System.Windows.Forms.Label commandLabel = new System.Windows.Forms.Label
                {
                    Text = commandText, // Set the formatted text
                    BorderStyle = BorderStyle.FixedSingle,
                    AutoSize = true, // Allow the label to size itself based on content
                    Width = flowPanelCommandsStrings.ClientSize.Width - 20, // Adjust width for padding
                    Font = new Font("Arial", 12, FontStyle.Regular), // Set font
                };
                flowPanelCommandsStrings.Controls.Add(commandLabel);
            }
        }

        private void PresetChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLevel = PresetChoice.SelectedItem.ToString();
            string[] loadedprogram;

            switch (selectedLevel)
            {
                case "Basic":
                case "Advanced":
                case "Expert":
                    PresetToCommand presetToCommand = new PresetToCommand();
                    loadedprogram = presetToCommand.GetPreset(selectedLevel.ToLower());
                    _arrayCommands = loadedprogram;
                    break;

                case "Import File ...":
                    loadTxtLabel.Visible = true;
                    LoadButton.Visible = true;
                    FilePathTextbox.Visible = true;
                    break;

                default:
                    MessageBox.Show("PresetChoice went Wrong");
                    return;
            }
            DisplayCommandsInBlock(_arrayCommands);

        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            //Make boxes visible
            OKButton.Visible = true;
            AmountStepsTextBox.Visible = true;
            LabelMove.Visible = true;
            
            
            //Enable Invisible boxes
            AmountStepsTextBox.Enabled = true;
            OKButton.Enabled = true;
        }

        private void flowPanelCommandsStrings_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (AmountStepsTextBox.Visible && LabelMove.Visible)
            {
                if (int.TryParse(AmountStepsTextBox.Text, out int moves))
                {
                    string newCommand = new string(' ', _indentLevel) + $"Move " + moves;

                    OKButton.Visible = false;
                    AmountStepsTextBox.Visible = false;
                    LabelMove.Visible = false;


                    _arrayCommands = _arrayCommands.Concat(new[] { newCommand }).ToArray();
                    
                    DisplayCommandsInBlock(_arrayCommands);


                    //Enable Invisible boxes
                    AmountStepsTextBox.Enabled = false;
                    LabelMove.Enabled = false;
                    AmountStepsTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a valid number of moves.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TurnButton_Click(object sender, EventArgs e)
        {
            LeftButton.Visible = true;
            RightButton.Visible = true;
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            string newCommand = new string(' ', _indentLevel) + $"Turn left";
            _arrayCommands = _arrayCommands.Concat(new[] { newCommand }).ToArray();
            DisplayCommandsInBlock(_arrayCommands);
            LeftButton.Visible = false;
            RightButton.Visible = false;
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            string newCommand = new string(' ', _indentLevel) + $"Turn right";
            _arrayCommands = _arrayCommands.Concat(new[] { newCommand }).ToArray();
            DisplayCommandsInBlock(_arrayCommands);
            LeftButton.Visible = false;
            RightButton.Visible = false;
        }

        private void RepeatButton_Click(object sender, EventArgs e)
        {
            _indentLevel++;
            IndentLevelIndicator.Text = "IndentLevel: " + _indentLevel;
            EndRepeat.Visible = true;
            RepeatLabel.Visible = true;
            textBoxRepeat.Visible = true;
            OKRepeatButton.Visible = true;

            OKRepeatButton.Enabled = true;
            textBoxRepeat.Enabled = true;
        }

 

        private void EndRepeat_Click(object sender, EventArgs e)
        {
            _indentLevel--;
            if (_indentLevel == 0) { EndRepeat.Visible = false; }
            IndentLevelIndicator.Text = "IndentLevel: " + _indentLevel;
        }

        private void OKRepeatButton_Click(object sender, EventArgs e)
        {
            if (RepeatLabel.Visible && textBoxRepeat.Visible)
            {
                if (int.TryParse(textBoxRepeat.Text, out int repeats))
                {
                    string newCommand = new string(' ', _indentLevel-1) + $"Repeat " + repeats + " times";

                    OKRepeatButton.Visible = false;
                    textBoxRepeat.Visible = false;
                    RepeatLabel.Visible = false;


                    _arrayCommands = _arrayCommands.Concat(new[] { newCommand }).ToArray();

                    DisplayCommandsInBlock(_arrayCommands);


                    //Enable Invisible boxes
                    textBoxRepeat.Enabled = false;
                    RepeatLabel.Enabled = false;
                    textBoxRepeat.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a valid number of moves.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        
        private void RunButton_Click(object sender, EventArgs e)
        {
            // First we need to return the string[] _arrayCommands to a List of Commands
            TxtToCommand txtToCommand = new TxtToCommand();
            List<ICommand> commandList = txtToCommand.ToCommandList(_arrayCommands);
            Executor executor = new Executor(_grid, commandList);
            executor.Run(_consoleOutput);

            GridControl gridControl = new GridControl(_grid);
            gridControl.SetPosition(450, 100);
            this.Controls.Add(gridControl);
            this.Invalidate();

            // Use the consoleOutput instance (not the class name)
            _consoleOutput.WriteLine(executor.Grid.Character.ToString());
        }

        private void Metrics_Click(object sender, EventArgs e)
        {
            TxtToCommand txtToCommand = new TxtToCommand();
            List<ICommand> commandList = txtToCommand.ToCommandList(_arrayCommands);
            Metrics metrics = txtToCommand.GetMetrics(commandList);
            _consoleOutput.WriteLine(metrics.ToString());

            //Array.Clear(_arrayCommands, 0, _arrayCommands.Length);
            //DisplayCommandsInBlock(_arrayCommands);
        }

        private void DeleteLastCommandButton_Click(object sender, EventArgs e)
        {
            if (_arrayCommands.Length > 0)
            {
                Array.Resize(ref _arrayCommands, _arrayCommands.Length - 1);
            }
            DisplayCommandsInBlock(_arrayCommands);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            string filePath = FilePathTextbox.Text;
            _arrayCommands = File.ReadAllLines(filePath);
            DisplayCommandsInBlock(_arrayCommands);

            loadTxtLabel.Visible = false;
            loadTxtLabel.Visible = false;
            LoadButton.Visible = false;
            FilePathTextbox.Visible = false;

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void gridViewPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Restarter.RestartApplication();
        }

        private void RepeatUntilButton_Click(object sender, EventArgs e)
        {
            WallButton.Visible = true;
            EdgeButton.Visible = true;
        }

        private void WallButton_Click(object sender, EventArgs e)
        {
            _indentLevel++;
            IndentLevelIndicator.Text = "IndentLevel: " + _indentLevel;

            string newCommand = new string(' ', _indentLevel - 1) + $"RepeatUntil wall";
            _arrayCommands = _arrayCommands.Concat(new[] { newCommand }).ToArray();
            DisplayCommandsInBlock(_arrayCommands);
            WallButton.Visible = false;
            EdgeButton.Visible = false;

            EndRepeat.Visible = true;
        }

        private void EdgeButton_Click(object sender, EventArgs e)
        {
            _indentLevel++;
            IndentLevelIndicator.Text = "IndentLevel: " + _indentLevel;

            string newCommand = new string(' ', _indentLevel - 1) + $"RepeatUntil edge";
            _arrayCommands = _arrayCommands.Concat(new[] { newCommand }).ToArray();
            DisplayCommandsInBlock(_arrayCommands);
            WallButton.Visible = false;
            EdgeButton.Visible = false;

            EndRepeat.Visible = true;
        }

        private void PathfindButton_Click(object sender, EventArgs e)
        {
            PathfindingLoadButton.Visible = true;
            PathfindingTextbox.Visible = true;
            PathfindingLabel.Visible = true;
        }

        private void PathfindingLoadButton_Click(object sender, EventArgs e)
        {
            string filePath = PathfindingTextbox.Text;
            _grid = new TxtToGrid().FileToGrid(filePath);

            GridControl gridControl = new GridControl(_grid);
            gridControl.SetPosition(550, 100);
            this.Controls.Add(gridControl);
        }

        public void WriteToConsole(string message)
        {
            _consoleOutput.AppendText(message);
        }
    }
}
