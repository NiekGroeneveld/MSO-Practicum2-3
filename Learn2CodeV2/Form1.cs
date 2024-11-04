using MSO_P2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Learn2CodeV2
{
    public partial class gridPanel : Form
    {
        private ConsoleTextBox consoleOutput;
        public gridPanel()
        {
            InitializeComponent();


            // Create the console box
            consoleOutput = new ConsoleTextBox();
            consoleOutput.Location = new Point(125, 435);  // X=12, Y=12 pixels from top-left
            consoleOutput.Size = new Size(400, 100);     // Width=400, Height=300
            this.Controls.Add(consoleOutput);            // Add it to the form

        }
        string[] arrayCommands = Array.Empty<string>();
        int indentLevel = 0;


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
                if(indentLevel == null) { indentLevel = 0; }
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
                    arrayCommands = loadedprogram;
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
            DisplayCommandsInBlock(arrayCommands);

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
                    string newCommand = new string(' ', indentLevel) + $"Move " + moves;

                    OKButton.Visible = false;
                    AmountStepsTextBox.Visible = false;
                    LabelMove.Visible = false;


                    arrayCommands = arrayCommands.Concat(new[] { newCommand }).ToArray();
                    
                    DisplayCommandsInBlock(arrayCommands);


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
            string newCommand = new string(' ', indentLevel) + $"Turn left";
            arrayCommands = arrayCommands.Concat(new[] { newCommand }).ToArray();
            DisplayCommandsInBlock(arrayCommands);
            LeftButton.Visible = false;
            RightButton.Visible = false;
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            string newCommand = new string(' ', indentLevel) + $"Turn right";
            arrayCommands = arrayCommands.Concat(new[] { newCommand }).ToArray();
            DisplayCommandsInBlock(arrayCommands);
            LeftButton.Visible = false;
            RightButton.Visible = false;
        }

        private void RepeatButton_Click(object sender, EventArgs e)
        {
            indentLevel++;
            IndentLevelIndicator.Text = "IndentLevel: " + indentLevel;
            EndRepeat.Visible = true;
            RepeatLabel.Visible = true;
            textBoxRepeat.Visible = true;
            OKRepeatButton.Visible = true;

            OKRepeatButton.Enabled = true;
            textBoxRepeat.Enabled = true;
        }

 

        private void EndRepeat_Click(object sender, EventArgs e)
        {
            indentLevel--;
            if (indentLevel == 0) { EndRepeat.Visible = false; }
            IndentLevelIndicator.Text = "IndentLevel: " + indentLevel;
        }

        private void IndentLevelIndicator_Click(object sender, EventArgs e)
        {

        }

        private void OKRepeatButton_Click(object sender, EventArgs e)
        {
            if (RepeatLabel.Visible && textBoxRepeat.Visible)
            {
                if (int.TryParse(textBoxRepeat.Text, out int repeats))
                {
                    string newCommand = new string(' ', indentLevel-1) + $"Repeat " + repeats + " times";

                    OKRepeatButton.Visible = false;
                    textBoxRepeat.Visible = false;
                    RepeatLabel.Visible = false;


                    arrayCommands = arrayCommands.Concat(new[] { newCommand }).ToArray();

                    DisplayCommandsInBlock(arrayCommands);


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
            // First we need to return the string[] arrayCommands to a List of Commands
            TxtToCommand txtToCommand = new TxtToCommand();
            List<ICommand> commandList = txtToCommand.ToCommandList(arrayCommands);
            Grid grid = new Grid(11, 11);
            Executor executor = new Executor(grid, commandList);
            executor.Run();

            GridControl gridControl = new GridControl(grid);
            gridControl.SetPosition(550, 100);
            this.Controls.Add(gridControl);

            // Use the consoleOutput instance (not the class name)
            consoleOutput.WriteLine(executor.grid.character.ToString());
        }

        private void Metrics_Click(object sender, EventArgs e)
        {
            TxtToCommand txtToCommand = new TxtToCommand();
            List<ICommand> commandList = txtToCommand.ToCommandList(arrayCommands);
            Metrics metrics = txtToCommand.GetMetrics(commandList);
            consoleOutput.WriteLine(metrics.ToString());

            //Array.Clear(arrayCommands, 0, arrayCommands.Length);
            //DisplayCommandsInBlock(arrayCommands);
        }

        private void DeleteLastCommandButton_Click(object sender, EventArgs e)
        {
            if (arrayCommands.Length > 0)
            {
                Array.Resize(ref arrayCommands, arrayCommands.Length - 1);
            }
            DisplayCommandsInBlock(arrayCommands);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            string filePath = FilePathTextbox.Text;
            arrayCommands = File.ReadAllLines(filePath);
            DisplayCommandsInBlock(arrayCommands);

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
    }
}
