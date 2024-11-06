namespace Learn2CodeV2
{
    partial class GridPanel
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
            this.ResetButton = new System.Windows.Forms.Button();
            this.RepeatUntilButton = new System.Windows.Forms.Button();
            this.WallButton = new System.Windows.Forms.Button();
            this.EdgeButton = new System.Windows.Forms.Button();
            this.PathfindingButton = new System.Windows.Forms.Button();
            this.PathfindingTextbox = new System.Windows.Forms.TextBox();
            this.PathfindingLoadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PathfindingLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PresetChoice
            // 
            this.PresetChoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PresetChoice.FormattingEnabled = true;
            this.PresetChoice.Items.AddRange(new object[] {
            "Basic",
            "Advanced",
            "Expert",
            "Import File ..."});
            this.PresetChoice.Location = new System.Drawing.Point(14, 31);
            this.PresetChoice.Name = "PresetChoice";
            this.PresetChoice.Size = new System.Drawing.Size(125, 24);
            this.PresetChoice.TabIndex = 0;
            this.PresetChoice.Text = "Load program";
            this.PresetChoice.SelectedIndexChanged += new System.EventHandler(this.PresetChoice_SelectedIndexChanged);
            // 
            // flowPanelCommandsStrings
            // 
            this.flowPanelCommandsStrings.AutoScroll = true;
            this.flowPanelCommandsStrings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelCommandsStrings.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanelCommandsStrings.Location = new System.Drawing.Point(6, 12);
            this.flowPanelCommandsStrings.Name = "flowPanelCommandsStrings";
            this.flowPanelCommandsStrings.Size = new System.Drawing.Size(292, 506);
            this.flowPanelCommandsStrings.TabIndex = 1;
            this.flowPanelCommandsStrings.WrapContents = false;
            this.flowPanelCommandsStrings.Paint += new System.Windows.Forms.PaintEventHandler(this.flowPanelCommandsStrings_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.flowPanelCommandsStrings);
            this.panel1.Location = new System.Drawing.Point(212, 76);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6, 12, 0, 0);
            this.panel1.Size = new System.Drawing.Size(300, 520);
            this.panel1.TabIndex = 2;
            // 
            // MoveButton
            // 
            this.MoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MoveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MoveButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveButton.ForeColor = System.Drawing.Color.Black;
            this.MoveButton.Location = new System.Drawing.Point(16, 76);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(175, 30);
            this.MoveButton.TabIndex = 3;
            this.MoveButton.Text = "MOVE";
            this.MoveButton.UseVisualStyleBackColor = false;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // TurnButton
            // 
            this.TurnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TurnButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.TurnButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TurnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TurnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnButton.ForeColor = System.Drawing.Color.Black;
            this.TurnButton.Location = new System.Drawing.Point(15, 176);
            this.TurnButton.Name = "TurnButton";
            this.TurnButton.Size = new System.Drawing.Size(175, 30);
            this.TurnButton.TabIndex = 4;
            this.TurnButton.Text = "TURN";
            this.TurnButton.UseVisualStyleBackColor = false;
            this.TurnButton.Click += new System.EventHandler(this.TurnButton_Click);
            // 
            // RepeatButton
            // 
            this.RepeatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RepeatButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RepeatButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RepeatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RepeatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatButton.ForeColor = System.Drawing.Color.Black;
            this.RepeatButton.Location = new System.Drawing.Point(15, 272);
            this.RepeatButton.Name = "RepeatButton";
            this.RepeatButton.Size = new System.Drawing.Size(175, 30);
            this.RepeatButton.TabIndex = 5;
            this.RepeatButton.Text = "REPEAT";
            this.RepeatButton.UseVisualStyleBackColor = false;
            this.RepeatButton.Click += new System.EventHandler(this.RepeatButton_Click);
            // 
            // AmountStepsTextBox
            // 
            this.AmountStepsTextBox.Enabled = false;
            this.AmountStepsTextBox.Location = new System.Drawing.Point(19, 128);
            this.AmountStepsTextBox.Name = "AmountStepsTextBox";
            this.AmountStepsTextBox.Size = new System.Drawing.Size(110, 22);
            this.AmountStepsTextBox.TabIndex = 6;
            this.AmountStepsTextBox.Visible = false;
            // 
            // LabelMove
            // 
            this.LabelMove.AutoSize = true;
            this.LabelMove.Location = new System.Drawing.Point(16, 109);
            this.LabelMove.Name = "LabelMove";
            this.LabelMove.Size = new System.Drawing.Size(115, 16);
            this.LabelMove.TabIndex = 7;
            this.LabelMove.Text = "How many Steps?";
            this.LabelMove.Visible = false;
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OKButton.Enabled = false;
            this.OKButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OKButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.ForeColor = System.Drawing.Color.Black;
            this.OKButton.Location = new System.Drawing.Point(139, 120);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(52, 30);
            this.OKButton.TabIndex = 8;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Visible = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LeftButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LeftButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftButton.ForeColor = System.Drawing.Color.Black;
            this.LeftButton.Location = new System.Drawing.Point(15, 212);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(85, 30);
            this.LeftButton.TabIndex = 9;
            this.LeftButton.Text = "Left";
            this.LeftButton.UseVisualStyleBackColor = false;
            this.LeftButton.Visible = false;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RightButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RightButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightButton.ForeColor = System.Drawing.Color.Black;
            this.RightButton.Location = new System.Drawing.Point(105, 212);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(85, 30);
            this.RightButton.TabIndex = 10;
            this.RightButton.Text = "Right";
            this.RightButton.UseVisualStyleBackColor = false;
            this.RightButton.Visible = false;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // EndRepeat
            // 
            this.EndRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EndRepeat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EndRepeat.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EndRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndRepeat.ForeColor = System.Drawing.Color.Black;
            this.EndRepeat.Location = new System.Drawing.Point(16, 382);
            this.EndRepeat.Name = "EndRepeat";
            this.EndRepeat.Size = new System.Drawing.Size(175, 30);
            this.EndRepeat.TabIndex = 11;
            this.EndRepeat.Text = "End REPEAT";
            this.EndRepeat.UseVisualStyleBackColor = false;
            this.EndRepeat.Visible = false;
            this.EndRepeat.Click += new System.EventHandler(this.EndRepeat_Click);
            // 
            // RepeatLabel
            // 
            this.RepeatLabel.AutoSize = true;
            this.RepeatLabel.Location = new System.Drawing.Point(16, 304);
            this.RepeatLabel.Name = "RepeatLabel";
            this.RepeatLabel.Size = new System.Drawing.Size(126, 16);
            this.RepeatLabel.TabIndex = 12;
            this.RepeatLabel.Text = "How many repeats?";
            this.RepeatLabel.Visible = false;
            // 
            // textBoxRepeat
            // 
            this.textBoxRepeat.Enabled = false;
            this.textBoxRepeat.Location = new System.Drawing.Point(19, 327);
            this.textBoxRepeat.Name = "textBoxRepeat";
            this.textBoxRepeat.Size = new System.Drawing.Size(110, 22);
            this.textBoxRepeat.TabIndex = 13;
            this.textBoxRepeat.Visible = false;
            // 
            // OKRepeatButton
            // 
            this.OKRepeatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OKRepeatButton.Enabled = false;
            this.OKRepeatButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OKRepeatButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OKRepeatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKRepeatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKRepeatButton.ForeColor = System.Drawing.Color.Black;
            this.OKRepeatButton.Location = new System.Drawing.Point(139, 319);
            this.OKRepeatButton.Name = "OKRepeatButton";
            this.OKRepeatButton.Size = new System.Drawing.Size(52, 30);
            this.OKRepeatButton.TabIndex = 14;
            this.OKRepeatButton.Text = "OK";
            this.OKRepeatButton.UseVisualStyleBackColor = false;
            this.OKRepeatButton.Visible = false;
            this.OKRepeatButton.Click += new System.EventHandler(this.OKRepeatButton_Click);
            // 
            // IndentLevelIndicator
            // 
            this.IndentLevelIndicator.AutoSize = true;
            this.IndentLevelIndicator.Location = new System.Drawing.Point(22, 546);
            this.IndentLevelIndicator.Name = "IndentLevelIndicator";
            this.IndentLevelIndicator.Size = new System.Drawing.Size(133, 16);
            this.IndentLevelIndicator.TabIndex = 15;
            this.IndentLevelIndicator.Text = "Current indent level: 0";
            // 
            // RunButton
            // 
            this.RunButton.BackColor = System.Drawing.Color.Lime;
            this.RunButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RunButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RunButton.FlatAppearance.BorderSize = 3;
            this.RunButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunButton.Location = new System.Drawing.Point(212, 611);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(90, 40);
            this.RunButton.TabIndex = 16;
            this.RunButton.Text = "Run";
            this.RunButton.UseCompatibleTextRendering = true;
            this.RunButton.UseVisualStyleBackColor = false;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // Metrics
            // 
            this.Metrics.BackColor = System.Drawing.SystemColors.Highlight;
            this.Metrics.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Metrics.FlatAppearance.BorderSize = 3;
            this.Metrics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Metrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Metrics.Location = new System.Drawing.Point(317, 611);
            this.Metrics.Name = "Metrics";
            this.Metrics.Size = new System.Drawing.Size(90, 40);
            this.Metrics.TabIndex = 17;
            this.Metrics.Text = "Metrics";
            this.Metrics.UseVisualStyleBackColor = false;
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
            this.DeleteLastCommandButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DeleteLastCommandButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DeleteLastCommandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteLastCommandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteLastCommandButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteLastCommandButton.Location = new System.Drawing.Point(17, 565);
            this.DeleteLastCommandButton.Name = "DeleteLastCommandButton";
            this.DeleteLastCommandButton.Size = new System.Drawing.Size(175, 30);
            this.DeleteLastCommandButton.TabIndex = 18;
            this.DeleteLastCommandButton.Text = "Delete Last";
            this.DeleteLastCommandButton.UseVisualStyleBackColor = false;
            this.DeleteLastCommandButton.Click += new System.EventHandler(this.DeleteLastCommandButton_Click);
            // 
            // loadTxtLabel
            // 
            this.loadTxtLabel.AutoSize = true;
            this.loadTxtLabel.Location = new System.Drawing.Point(214, 14);
            this.loadTxtLabel.Name = "loadTxtLabel";
            this.loadTxtLabel.Size = new System.Drawing.Size(180, 16);
            this.loadTxtLabel.TabIndex = 19;
            this.loadTxtLabel.Text = "Paste the path to the file here:";
            this.loadTxtLabel.Visible = false;
            // 
            // FilePathTextbox
            // 
            this.FilePathTextbox.Location = new System.Drawing.Point(212, 34);
            this.FilePathTextbox.Name = "FilePathTextbox";
            this.FilePathTextbox.Size = new System.Drawing.Size(182, 22);
            this.FilePathTextbox.TabIndex = 20;
            this.FilePathTextbox.Visible = false;
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LoadButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LoadButton.FlatAppearance.BorderSize = 3;
            this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadButton.Location = new System.Drawing.Point(412, 16);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(100, 40);
            this.LoadButton.TabIndex = 21;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Visible = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Red;
            this.ResetButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ResetButton.FlatAppearance.BorderSize = 3;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.Black;
            this.ResetButton.Location = new System.Drawing.Point(422, 611);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(90, 40);
            this.ResetButton.TabIndex = 22;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // RepeatUntilButton
            // 
            this.RepeatUntilButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RepeatUntilButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RepeatUntilButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RepeatUntilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RepeatUntilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatUntilButton.ForeColor = System.Drawing.Color.Black;
            this.RepeatUntilButton.Location = new System.Drawing.Point(16, 457);
            this.RepeatUntilButton.Name = "RepeatUntilButton";
            this.RepeatUntilButton.Size = new System.Drawing.Size(175, 30);
            this.RepeatUntilButton.TabIndex = 23;
            this.RepeatUntilButton.Text = "REPEAT UNTIL";
            this.RepeatUntilButton.UseVisualStyleBackColor = false;
            this.RepeatUntilButton.Click += new System.EventHandler(this.RepeatUntilButton_Click);
            // 
            // WallButton
            // 
            this.WallButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.WallButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.WallButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.WallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WallButton.ForeColor = System.Drawing.Color.Black;
            this.WallButton.Location = new System.Drawing.Point(16, 493);
            this.WallButton.Name = "WallButton";
            this.WallButton.Size = new System.Drawing.Size(85, 30);
            this.WallButton.TabIndex = 24;
            this.WallButton.Text = "Wall";
            this.WallButton.UseVisualStyleBackColor = false;
            this.WallButton.Visible = false;
            this.WallButton.Click += new System.EventHandler(this.WallButton_Click);
            // 
            // EdgeButton
            // 
            this.EdgeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EdgeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EdgeButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EdgeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EdgeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdgeButton.ForeColor = System.Drawing.Color.Black;
            this.EdgeButton.Location = new System.Drawing.Point(106, 493);
            this.EdgeButton.Name = "EdgeButton";
            this.EdgeButton.Size = new System.Drawing.Size(85, 30);
            this.EdgeButton.TabIndex = 25;
            this.EdgeButton.Text = "Edge";
            this.EdgeButton.UseVisualStyleBackColor = false;
            this.EdgeButton.Visible = false;
            this.EdgeButton.Click += new System.EventHandler(this.EdgeButton_Click);
            // 
            // PathfindingButton
            // 
            this.PathfindingButton.Location = new System.Drawing.Point(603, 14);
            this.PathfindingButton.Name = "PathfindingButton";
            this.PathfindingButton.Size = new System.Drawing.Size(92, 40);
            this.PathfindingButton.TabIndex = 26;
            this.PathfindingButton.Text = "Pathfinding";
            this.PathfindingButton.UseVisualStyleBackColor = true;
            this.PathfindingButton.Click += new System.EventHandler(this.PathfindButton_Click);
            // 
            // PathfindingTextbox
            // 
            this.PathfindingTextbox.Location = new System.Drawing.Point(698, 31);
            this.PathfindingTextbox.Name = "PathfindingTextbox";
            this.PathfindingTextbox.Size = new System.Drawing.Size(300, 22);
            this.PathfindingTextbox.TabIndex = 27;
            this.PathfindingTextbox.Visible = false;
            // 
            // PathfindingLoadButton
            // 
            this.PathfindingLoadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PathfindingLoadButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PathfindingLoadButton.FlatAppearance.BorderSize = 3;
            this.PathfindingLoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PathfindingLoadButton.Location = new System.Drawing.Point(1004, 14);
            this.PathfindingLoadButton.Name = "PathfindingLoadButton";
            this.PathfindingLoadButton.Size = new System.Drawing.Size(100, 40);
            this.PathfindingLoadButton.TabIndex = 28;
            this.PathfindingLoadButton.Text = "Load";
            this.PathfindingLoadButton.UseVisualStyleBackColor = false;
            this.PathfindingLoadButton.Visible = false;
            this.PathfindingLoadButton.Click += new System.EventHandler(this.PathfindingLoadButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Load a file or preset";
            // 
            // PathfindingLabel
            // 
            this.PathfindingLabel.AutoSize = true;
            this.PathfindingLabel.Location = new System.Drawing.Point(701, 12);
            this.PathfindingLabel.Name = "PathfindingLabel";
            this.PathfindingLabel.Size = new System.Drawing.Size(180, 16);
            this.PathfindingLabel.TabIndex = 30;
            this.PathfindingLabel.Text = "Paste the path to the file here:";
            this.PathfindingLabel.Visible = false;
            // 
            // gridPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 675);
            this.Controls.Add(this.PathfindingLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PathfindingLoadButton);
            this.Controls.Add(this.PathfindingTextbox);
            this.Controls.Add(this.PathfindingButton);
            this.Controls.Add(this.EdgeButton);
            this.Controls.Add(this.WallButton);
            this.Controls.Add(this.RepeatUntilButton);
            this.Controls.Add(this.ResetButton);
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
            this.Name = "GridPanel";
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
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button RepeatUntilButton;
        private System.Windows.Forms.Button WallButton;
        private System.Windows.Forms.Button EdgeButton;
        private System.Windows.Forms.Button PathfindingButton;
        private System.Windows.Forms.TextBox PathfindingTextbox;
        private System.Windows.Forms.Button PathfindingLoadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PathfindingLabel;
    }
}

