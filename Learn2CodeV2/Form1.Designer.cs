namespace Learn2CodeV2
{
    partial class gridPanel
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
            this.components = new System.ComponentModel.Container();
            this.PresetChoice = new System.Windows.Forms.ComboBox();
            this.flowPanelCommandsStrings = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MoveButton = new System.Windows.Forms.Button();
            this.TurnButton = new System.Windows.Forms.Button();
            this.RepeatButton = new System.Windows.Forms.Button();
            this.AmountStepsTextBox = new System.Windows.Forms.TextBox();
            this.LabelMove = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.EndRepeat = new System.Windows.Forms.Button();
            this.RepeatLabel = new System.Windows.Forms.Label();
            this.textBoxRepeat = new System.Windows.Forms.TextBox();
            this.OKRepeatButton = new System.Windows.Forms.Button();
            this.IndentLevelIndicator = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.Metrics = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteLastCommandButton = new System.Windows.Forms.Button();
            this.loadTxtLabel = new System.Windows.Forms.Label();
            this.FilePathTextbox = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PresetChoice
            // 
            this.PresetChoice.FormattingEnabled = true;
            this.PresetChoice.Items.AddRange(new object[] {
            "Basic",
            "Advanced",
            "Expert",
            "Import File ..."});
            this.PresetChoice.Location = new System.Drawing.Point(13, 13);
            this.PresetChoice.Name = "PresetChoice";
            this.PresetChoice.Size = new System.Drawing.Size(121, 24);
            this.PresetChoice.TabIndex = 0;
            this.PresetChoice.Text = "Choose Preset";
            this.PresetChoice.SelectedIndexChanged += new System.EventHandler(this.PresetChoice_SelectedIndexChanged);
            // 
            // flowPanelCommandsStrings
            // 
            this.flowPanelCommandsStrings.AutoScroll = true;
            this.flowPanelCommandsStrings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelCommandsStrings.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanelCommandsStrings.Location = new System.Drawing.Point(0, 0);
            this.flowPanelCommandsStrings.Name = "flowPanelCommandsStrings";
            this.flowPanelCommandsStrings.Size = new System.Drawing.Size(425, 416);
            this.flowPanelCommandsStrings.TabIndex = 1;
            this.flowPanelCommandsStrings.WrapContents = false;
            this.flowPanelCommandsStrings.Paint += new System.Windows.Forms.PaintEventHandler(this.flowPanelCommandsStrings_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowPanelCommandsStrings);
            this.panel1.Location = new System.Drawing.Point(195, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 416);
            this.panel1.TabIndex = 2;
            // 
            // MoveButton
            // 
            this.MoveButton.Location = new System.Drawing.Point(195, 13);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(75, 26);
            this.MoveButton.TabIndex = 3;
            this.MoveButton.Text = "MOVE";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // TurnButton
            // 
            this.TurnButton.Location = new System.Drawing.Point(365, 12);
            this.TurnButton.Name = "TurnButton";
            this.TurnButton.Size = new System.Drawing.Size(75, 25);
            this.TurnButton.TabIndex = 4;
            this.TurnButton.Text = "TURN";
            this.TurnButton.UseVisualStyleBackColor = true;
            this.TurnButton.Click += new System.EventHandler(this.TurnButton_Click);
            // 
            // RepeatButton
            // 
            this.RepeatButton.Location = new System.Drawing.Point(518, 12);
            this.RepeatButton.Name = "RepeatButton";
            this.RepeatButton.Size = new System.Drawing.Size(102, 25);
            this.RepeatButton.TabIndex = 5;
            this.RepeatButton.Text = "REPEAT";
            this.RepeatButton.UseVisualStyleBackColor = true;
            this.RepeatButton.Click += new System.EventHandler(this.RepeatButton_Click);
            // 
            // AmountStepsTextBox
            // 
            this.AmountStepsTextBox.Enabled = false;
            this.AmountStepsTextBox.Location = new System.Drawing.Point(322, 39);
            this.AmountStepsTextBox.Name = "AmountStepsTextBox";
            this.AmountStepsTextBox.Size = new System.Drawing.Size(48, 22);
            this.AmountStepsTextBox.TabIndex = 6;
            this.AmountStepsTextBox.Visible = false;
            // 
            // LabelMove
            // 
            this.LabelMove.AutoSize = true;
            this.LabelMove.Location = new System.Drawing.Point(201, 42);
            this.LabelMove.Name = "LabelMove";
            this.LabelMove.Size = new System.Drawing.Size(115, 16);
            this.LabelMove.TabIndex = 7;
            this.LabelMove.Text = "How many Steps?";
            this.LabelMove.Visible = false;
            // 
            // OKButton
            // 
            this.OKButton.Enabled = false;
            this.OKButton.Location = new System.Drawing.Point(376, 38);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(52, 23);
            this.OKButton.TabIndex = 8;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Visible = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(446, 38);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(75, 23);
            this.LeftButton.TabIndex = 9;
            this.LeftButton.Text = "Left";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Visible = false;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(527, 38);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(75, 23);
            this.RightButton.TabIndex = 10;
            this.RightButton.Text = "Right";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Visible = false;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // EndRepeat
            // 
            this.EndRepeat.Location = new System.Drawing.Point(626, 12);
            this.EndRepeat.Name = "EndRepeat";
            this.EndRepeat.Size = new System.Drawing.Size(119, 27);
            this.EndRepeat.TabIndex = 11;
            this.EndRepeat.Text = "End REPEAT";
            this.EndRepeat.UseVisualStyleBackColor = true;
            this.EndRepeat.Visible = false;
            this.EndRepeat.Click += new System.EventHandler(this.EndRepeat_Click);
            // 
            // RepeatLabel
            // 
            this.RepeatLabel.AutoSize = true;
            this.RepeatLabel.Location = new System.Drawing.Point(630, 42);
            this.RepeatLabel.Name = "RepeatLabel";
            this.RepeatLabel.Size = new System.Drawing.Size(126, 16);
            this.RepeatLabel.TabIndex = 12;
            this.RepeatLabel.Text = "How many repeats?";
            this.RepeatLabel.Visible = false;
            // 
            // textBoxRepeat
            // 
            this.textBoxRepeat.Enabled = false;
            this.textBoxRepeat.Location = new System.Drawing.Point(762, 39);
            this.textBoxRepeat.Name = "textBoxRepeat";
            this.textBoxRepeat.Size = new System.Drawing.Size(48, 22);
            this.textBoxRepeat.TabIndex = 13;
            this.textBoxRepeat.Visible = false;
            // 
            // OKRepeatButton
            // 
            this.OKRepeatButton.Enabled = false;
            this.OKRepeatButton.Location = new System.Drawing.Point(816, 39);
            this.OKRepeatButton.Name = "OKRepeatButton";
            this.OKRepeatButton.Size = new System.Drawing.Size(52, 23);
            this.OKRepeatButton.TabIndex = 14;
            this.OKRepeatButton.Text = "OK";
            this.OKRepeatButton.UseVisualStyleBackColor = true;
            this.OKRepeatButton.Visible = false;
            this.OKRepeatButton.Click += new System.EventHandler(this.OKRepeatButton_Click);
            // 
            // IndentLevelIndicator
            // 
            this.IndentLevelIndicator.AutoSize = true;
            this.IndentLevelIndicator.Location = new System.Drawing.Point(953, 23);
            this.IndentLevelIndicator.Name = "IndentLevelIndicator";
            this.IndentLevelIndicator.Size = new System.Drawing.Size(134, 16);
            this.IndentLevelIndicator.TabIndex = 15;
            this.IndentLevelIndicator.Text = "Current IndentLevel: 0";
            this.IndentLevelIndicator.Click += new System.EventHandler(this.IndentLevelIndicator_Click);
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(195, 501);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 16;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // Metrics
            // 
            this.Metrics.Location = new System.Drawing.Point(295, 501);
            this.Metrics.Name = "Metrics";
            this.Metrics.Size = new System.Drawing.Size(75, 23);
            this.Metrics.TabIndex = 17;
            this.Metrics.Text = "Metrics";
            this.Metrics.UseVisualStyleBackColor = true;
            this.Metrics.Click += new System.EventHandler(this.Metrics_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DeleteLastCommandButton
            // 
            this.DeleteLastCommandButton.Location = new System.Drawing.Point(948, 42);
            this.DeleteLastCommandButton.Name = "DeleteLastCommandButton";
            this.DeleteLastCommandButton.Size = new System.Drawing.Size(139, 27);
            this.DeleteLastCommandButton.TabIndex = 18;
            this.DeleteLastCommandButton.Text = "Delete Last";
            this.DeleteLastCommandButton.UseVisualStyleBackColor = true;
            this.DeleteLastCommandButton.Click += new System.EventHandler(this.DeleteLastCommandButton_Click);
            // 
            // loadTxtLabel
            // 
            this.loadTxtLabel.AutoSize = true;
            this.loadTxtLabel.Location = new System.Drawing.Point(10, 67);
            this.loadTxtLabel.Name = "loadTxtLabel";
            this.loadTxtLabel.Size = new System.Drawing.Size(177, 16);
            this.loadTxtLabel.TabIndex = 19;
            this.loadTxtLabel.Text = "Paste the path to the file here";
            this.loadTxtLabel.Visible = false;
            // 
            // FilePathTextbox
            // 
            this.FilePathTextbox.Location = new System.Drawing.Point(13, 87);
            this.FilePathTextbox.Name = "FilePathTextbox";
            this.FilePathTextbox.Size = new System.Drawing.Size(176, 22);
            this.FilePathTextbox.TabIndex = 20;
            this.FilePathTextbox.Visible = false;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(13, 116);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 21;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Visible = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // gridPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 675);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.FilePathTextbox);
            this.Controls.Add(this.loadTxtLabel);
            this.Controls.Add(this.DeleteLastCommandButton);
            this.Controls.Add(this.Metrics);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.IndentLevelIndicator);
            this.Controls.Add(this.OKRepeatButton);
            this.Controls.Add(this.textBoxRepeat);
            this.Controls.Add(this.RepeatLabel);
            this.Controls.Add(this.EndRepeat);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.LabelMove);
            this.Controls.Add(this.AmountStepsTextBox);
            this.Controls.Add(this.RepeatButton);
            this.Controls.Add(this.TurnButton);
            this.Controls.Add(this.MoveButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PresetChoice);
            this.Name = "gridPanel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PresetChoice;
        private System.Windows.Forms.FlowLayoutPanel flowPanelCommandsStrings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Button TurnButton;
        private System.Windows.Forms.Button RepeatButton;
        private System.Windows.Forms.TextBox AmountStepsTextBox;
        private System.Windows.Forms.Label LabelMove;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button EndRepeat;
        private System.Windows.Forms.Label RepeatLabel;
        private System.Windows.Forms.TextBox textBoxRepeat;
        private System.Windows.Forms.Button OKRepeatButton;
        private System.Windows.Forms.Label IndentLevelIndicator;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Button Metrics;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button DeleteLastCommandButton;
        private System.Windows.Forms.Label loadTxtLabel;
        private System.Windows.Forms.TextBox FilePathTextbox;
        private System.Windows.Forms.Button LoadButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

