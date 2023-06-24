namespace VolumeTransitioner
{
    partial class MainWindow
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
            nupMin = new NumericUpDown();
            nupMax = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            btnToggle = new Button();
            lblToggle = new Label();
            menuStrip1 = new MenuStrip();
            mitSavePreset = new ToolStripMenuItem();
            mitLoadPreset = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)nupMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupMax).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // nupMin
            // 
            nupMin.Location = new System.Drawing.Point(123, 30);
            nupMin.Name = "nupMin";
            nupMin.Size = new System.Drawing.Size(52, 23);
            nupMin.TabIndex = 1;
            nupMin.ValueChanged += MinVolChanged;
            // 
            // nupMax
            // 
            nupMax.Location = new System.Drawing.Point(123, 59);
            nupMax.Name = "nupMax";
            nupMax.Size = new System.Drawing.Size(52, 23);
            nupMax.TabIndex = 2;
            nupMax.ValueChanged += MaxVolChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 15);
            label1.TabIndex = 3;
            label1.Text = "Minimum volume";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 63);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(105, 15);
            label2.TabIndex = 4;
            label2.Text = "Maximum volume";
            // 
            // btnToggle
            // 
            btnToggle.BackgroundImage = Properties.Resources.ToggleUp;
            btnToggle.BackgroundImageLayout = ImageLayout.Stretch;
            btnToggle.Location = new System.Drawing.Point(177, 30);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new System.Drawing.Size(52, 52);
            btnToggle.TabIndex = 7;
            btnToggle.UseVisualStyleBackColor = true;
            btnToggle.Click += Toggle;
            // 
            // lblToggle
            // 
            lblToggle.AutoSize = true;
            lblToggle.Location = new System.Drawing.Point(235, 49);
            lblToggle.Name = "lblToggle";
            lblToggle.Size = new System.Drawing.Size(164, 15);
            lblToggle.TabIndex = 8;
            lblToggle.Text = "Toggled to maximum volume";
            lblToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mitSavePreset, mitLoadPreset });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(403, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // mitSavePreset
            // 
            mitSavePreset.Name = "mitSavePreset";
            mitSavePreset.Size = new System.Drawing.Size(78, 20);
            mitSavePreset.Text = "Save Preset";
            mitSavePreset.Click += SavePreset;
            // 
            // mitLoadPreset
            // 
            mitLoadPreset.Name = "mitLoadPreset";
            mitLoadPreset.Size = new System.Drawing.Size(80, 20);
            mitLoadPreset.Text = "Load Preset";
            mitLoadPreset.Click += LoadPreset;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(403, 94);
            Controls.Add(lblToggle);
            Controls.Add(btnToggle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nupMax);
            Controls.Add(nupMin);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            Text = "Volume Transitioner";
            ((System.ComponentModel.ISupportInitialize)nupMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupMax).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown nupMin;
        private NumericUpDown nupMax;
        private Label label1;
        private Label label2;
        private Button btnToggle;
        private Label lblToggle;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mitSavePreset;
        private ToolStripMenuItem mitLoadPreset;
    }
}