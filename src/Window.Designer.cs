namespace BPMTool
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.titleLabel = new System.Windows.Forms.Label();
            this.pitchGroup = new System.Windows.Forms.GroupBox();
            this.pitchCalcButton = new System.Windows.Forms.Button();
            this.pitchNewPitchOutput = new System.Windows.Forms.TextBox();
            this.pitchNewPitchOutputLabel = new System.Windows.Forms.Label();
            this.pitchNewBPMInput = new System.Windows.Forms.TextBox();
            this.pitchNewBPMInputLabel = new System.Windows.Forms.Label();
            this.pitchOldBPMInput = new System.Windows.Forms.TextBox();
            this.pitchOldBPMInputLabel = new System.Windows.Forms.Label();
            this.bpmCalcButton = new System.Windows.Forms.Button();
            this.bpmNewBPMOutput = new System.Windows.Forms.TextBox();
            this.bpmNewBPMOutputLabel = new System.Windows.Forms.Label();
            this.bpmPitchDiffInput = new System.Windows.Forms.TextBox();
            this.bpmPitchDiffInputLabel = new System.Windows.Forms.Label();
            this.bpmOldBPMInput = new System.Windows.Forms.TextBox();
            this.bpmOldBPMInputLabel = new System.Windows.Forms.Label();
            this.bpmGroup = new System.Windows.Forms.GroupBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.pitchGroup.SuspendLayout();
            this.bpmGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(50, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // pitchGroup
            // 
            this.pitchGroup.Controls.Add(this.pitchCalcButton);
            this.pitchGroup.Controls.Add(this.pitchNewPitchOutput);
            this.pitchGroup.Controls.Add(this.pitchNewPitchOutputLabel);
            this.pitchGroup.Controls.Add(this.pitchNewBPMInput);
            this.pitchGroup.Controls.Add(this.pitchNewBPMInputLabel);
            this.pitchGroup.Controls.Add(this.pitchOldBPMInput);
            this.pitchGroup.Controls.Add(this.pitchOldBPMInputLabel);
            this.pitchGroup.Location = new System.Drawing.Point(13, 46);
            this.pitchGroup.Name = "pitchGroup";
            this.pitchGroup.Size = new System.Drawing.Size(185, 141);
            this.pitchGroup.TabIndex = 1;
            this.pitchGroup.TabStop = false;
            this.pitchGroup.Text = "Get Pitch";
            // 
            // pitchCalcButton
            // 
            this.pitchCalcButton.Location = new System.Drawing.Point(6, 109);
            this.pitchCalcButton.Name = "pitchCalcButton";
            this.pitchCalcButton.Size = new System.Drawing.Size(168, 24);
            this.pitchCalcButton.TabIndex = 4;
            this.pitchCalcButton.Text = "Calculate";
            this.pitchCalcButton.UseVisualStyleBackColor = true;
            this.pitchCalcButton.Click += new System.EventHandler(this.PitchCalcButtonClickEvent);
            // 
            // pitchNewPitchOutput
            // 
            this.pitchNewPitchOutput.Location = new System.Drawing.Point(74, 80);
            this.pitchNewPitchOutput.Name = "pitchNewPitchOutput";
            this.pitchNewPitchOutput.PlaceholderText = "Pitch";
            this.pitchNewPitchOutput.ReadOnly = true;
            this.pitchNewPitchOutput.Size = new System.Drawing.Size(100, 23);
            this.pitchNewPitchOutput.TabIndex = 3;
            // 
            // pitchNewPitchOutputLabel
            // 
            this.pitchNewPitchOutputLabel.AutoSize = true;
            this.pitchNewPitchOutputLabel.Location = new System.Drawing.Point(6, 83);
            this.pitchNewPitchOutputLabel.Name = "pitchNewPitchOutputLabel";
            this.pitchNewPitchOutputLabel.Size = new System.Drawing.Size(61, 15);
            this.pitchNewPitchOutputLabel.TabIndex = 0;
            this.pitchNewPitchOutputLabel.Text = "New Pitch";
            // 
            // pitchNewBPMInput
            // 
            this.pitchNewBPMInput.Location = new System.Drawing.Point(74, 51);
            this.pitchNewBPMInput.Name = "pitchNewBPMInput";
            this.pitchNewBPMInput.PlaceholderText = "BPM";
            this.pitchNewBPMInput.Size = new System.Drawing.Size(100, 23);
            this.pitchNewBPMInput.TabIndex = 2;
            this.pitchNewBPMInput.TextChanged += new System.EventHandler(this.InputTextChangeEvent);
            // 
            // pitchNewBPMInputLabel
            // 
            this.pitchNewBPMInputLabel.AutoSize = true;
            this.pitchNewBPMInputLabel.Location = new System.Drawing.Point(6, 54);
            this.pitchNewBPMInputLabel.Name = "pitchNewBPMInputLabel";
            this.pitchNewBPMInputLabel.Size = new System.Drawing.Size(59, 15);
            this.pitchNewBPMInputLabel.TabIndex = 0;
            this.pitchNewBPMInputLabel.Text = "New BPM";
            // 
            // pitchOldBPMInput
            // 
            this.pitchOldBPMInput.Location = new System.Drawing.Point(74, 22);
            this.pitchOldBPMInput.Name = "pitchOldBPMInput";
            this.pitchOldBPMInput.PlaceholderText = "BPM";
            this.pitchOldBPMInput.Size = new System.Drawing.Size(100, 23);
            this.pitchOldBPMInput.TabIndex = 1;
            this.pitchOldBPMInput.TextChanged += new System.EventHandler(this.InputTextChangeEvent);
            // 
            // pitchOldBPMInputLabel
            // 
            this.pitchOldBPMInputLabel.AutoSize = true;
            this.pitchOldBPMInputLabel.Location = new System.Drawing.Point(6, 25);
            this.pitchOldBPMInputLabel.Name = "pitchOldBPMInputLabel";
            this.pitchOldBPMInputLabel.Size = new System.Drawing.Size(54, 15);
            this.pitchOldBPMInputLabel.TabIndex = 0;
            this.pitchOldBPMInputLabel.Text = "Old BPM";
            // 
            // bpmCalcButton
            // 
            this.bpmCalcButton.Location = new System.Drawing.Point(6, 109);
            this.bpmCalcButton.Name = "bpmCalcButton";
            this.bpmCalcButton.Size = new System.Drawing.Size(168, 24);
            this.bpmCalcButton.TabIndex = 8;
            this.bpmCalcButton.Text = "Calculate";
            this.bpmCalcButton.UseVisualStyleBackColor = true;
            this.bpmCalcButton.Click += new System.EventHandler(this.BPMCalcButtonClickEvent);
            // 
            // bpmNewBPMOutput
            // 
            this.bpmNewBPMOutput.Location = new System.Drawing.Point(74, 80);
            this.bpmNewBPMOutput.Name = "bpmNewBPMOutput";
            this.bpmNewBPMOutput.PlaceholderText = "Pitch";
            this.bpmNewBPMOutput.ReadOnly = true;
            this.bpmNewBPMOutput.Size = new System.Drawing.Size(100, 23);
            this.bpmNewBPMOutput.TabIndex = 7;
            this.bpmNewBPMOutput.Text = "BPM";
            // 
            // bpmNewBPMOutputLabel
            // 
            this.bpmNewBPMOutputLabel.AutoSize = true;
            this.bpmNewBPMOutputLabel.Location = new System.Drawing.Point(6, 83);
            this.bpmNewBPMOutputLabel.Name = "bpmNewBPMOutputLabel";
            this.bpmNewBPMOutputLabel.Size = new System.Drawing.Size(59, 15);
            this.bpmNewBPMOutputLabel.TabIndex = 0;
            this.bpmNewBPMOutputLabel.Text = "New BPM";
            // 
            // bpmPitchDiffInput
            // 
            this.bpmPitchDiffInput.Location = new System.Drawing.Point(74, 51);
            this.bpmPitchDiffInput.Name = "bpmPitchDiffInput";
            this.bpmPitchDiffInput.PlaceholderText = "Pitch";
            this.bpmPitchDiffInput.Size = new System.Drawing.Size(100, 23);
            this.bpmPitchDiffInput.TabIndex = 6;
            this.bpmPitchDiffInput.TextChanged += new System.EventHandler(this.InputTextChangeEvent);
            // 
            // bpmPitchDiffInputLabel
            // 
            this.bpmPitchDiffInputLabel.AutoSize = true;
            this.bpmPitchDiffInputLabel.Location = new System.Drawing.Point(6, 54);
            this.bpmPitchDiffInputLabel.Name = "bpmPitchDiffInputLabel";
            this.bpmPitchDiffInputLabel.Size = new System.Drawing.Size(56, 15);
            this.bpmPitchDiffInputLabel.TabIndex = 0;
            this.bpmPitchDiffInputLabel.Text = "Pitch Diff";
            // 
            // bpmOldBPMInput
            // 
            this.bpmOldBPMInput.Location = new System.Drawing.Point(74, 22);
            this.bpmOldBPMInput.Name = "bpmOldBPMInput";
            this.bpmOldBPMInput.PlaceholderText = "BPM";
            this.bpmOldBPMInput.Size = new System.Drawing.Size(100, 23);
            this.bpmOldBPMInput.TabIndex = 5;
            this.bpmOldBPMInput.TextChanged += new System.EventHandler(this.InputTextChangeEvent);
            // 
            // bpmOldBPMInputLabel
            // 
            this.bpmOldBPMInputLabel.AutoSize = true;
            this.bpmOldBPMInputLabel.Location = new System.Drawing.Point(6, 25);
            this.bpmOldBPMInputLabel.Name = "bpmOldBPMInputLabel";
            this.bpmOldBPMInputLabel.Size = new System.Drawing.Size(54, 15);
            this.bpmOldBPMInputLabel.TabIndex = 0;
            this.bpmOldBPMInputLabel.Text = "Old BPM";
            // 
            // bpmGroup
            // 
            this.bpmGroup.Controls.Add(this.bpmCalcButton);
            this.bpmGroup.Controls.Add(this.bpmNewBPMOutput);
            this.bpmGroup.Controls.Add(this.bpmNewBPMOutputLabel);
            this.bpmGroup.Controls.Add(this.bpmPitchDiffInput);
            this.bpmGroup.Controls.Add(this.bpmPitchDiffInputLabel);
            this.bpmGroup.Controls.Add(this.bpmOldBPMInput);
            this.bpmGroup.Controls.Add(this.bpmOldBPMInputLabel);
            this.bpmGroup.Location = new System.Drawing.Point(204, 46);
            this.bpmGroup.Name = "bpmGroup";
            this.bpmGroup.Size = new System.Drawing.Size(185, 141);
            this.bpmGroup.TabIndex = 1;
            this.bpmGroup.TabStop = false;
            this.bpmGroup.Text = "Get BPM";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.versionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.versionLabel.Location = new System.Drawing.Point(13, 194);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(51, 13);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Version: ";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urlLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.urlLabel.Location = new System.Drawing.Point(13, 209);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(240, 13);
            this.urlLabel.TabIndex = 2;
            this.urlLabel.Text = "github.com/joshuathompsonlindley/BPMTool";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 233);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.bpmGroup);
            this.Controls.Add(this.pitchGroup);
            this.Controls.Add(this.titleLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BPMTool";
            this.Load += new System.EventHandler(this.WindowLoadEvent);
            this.pitchGroup.ResumeLayout(false);
            this.pitchGroup.PerformLayout();
            this.bpmGroup.ResumeLayout(false);
            this.bpmGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox pitchGroup;
        private System.Windows.Forms.Label pitchOldBPMInputLabel;
        private System.Windows.Forms.Button pitchCalcButton;
        private System.Windows.Forms.TextBox pitchNewPitchOutput;
        private System.Windows.Forms.Label pitchNewPitchOutputLabel;
        private System.Windows.Forms.TextBox pitchNewBPMInput;
        private System.Windows.Forms.Label pitchNewBPMInputLabel;
        private System.Windows.Forms.TextBox pitchOldBPMInput;
        private System.Windows.Forms.Button bpmCalcButton;
        private System.Windows.Forms.TextBox bpmNewBPMOutput;
        private System.Windows.Forms.Label bpmNewBPMOutputLabel;
        private System.Windows.Forms.TextBox bpmPitchDiffInput;
        private System.Windows.Forms.Label bpmPitchDiffInputLabel;
        private System.Windows.Forms.TextBox bpmOldBPMInput;
        private System.Windows.Forms.Label bpmOldBPMInputLabel;
        private System.Windows.Forms.GroupBox bpmGroup;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label urlLabel;
    }
}