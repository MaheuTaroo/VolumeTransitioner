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
            this.nupMin = new System.Windows.Forms.NumericUpDown();
            this.nupMax = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnToggle = new System.Windows.Forms.Button();
            this.lblToggle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMax)).BeginInit();
            this.SuspendLayout();
            // 
            // nupMin
            // 
            this.nupMin.Location = new System.Drawing.Point(123, 6);
            this.nupMin.Name = "nupMin";
            this.nupMin.Size = new System.Drawing.Size(52, 23);
            this.nupMin.TabIndex = 1;
            this.nupMin.ValueChanged += new System.EventHandler(this.MinVolChanged);
            // 
            // nupMax
            // 
            this.nupMax.Location = new System.Drawing.Point(123, 35);
            this.nupMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nupMax.Name = "nupMax";
            this.nupMax.Size = new System.Drawing.Size(52, 23);
            this.nupMax.TabIndex = 2;
            this.nupMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nupMax.ValueChanged += new System.EventHandler(this.MaxVolChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minimum volume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Maximum volume";
            // 
            // btnToggle
            // 
            this.btnToggle.BackgroundImage = global::VolumeTransitioner.Properties.Resources.ToggleUp;
            this.btnToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnToggle.Location = new System.Drawing.Point(177, 6);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(52, 52);
            this.btnToggle.TabIndex = 7;
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.Toggle);
            // 
            // lblToggle
            // 
            this.lblToggle.AutoSize = true;
            this.lblToggle.Location = new System.Drawing.Point(235, 25);
            this.lblToggle.Name = "lblToggle";
            this.lblToggle.Size = new System.Drawing.Size(164, 15);
            this.lblToggle.TabIndex = 8;
            this.lblToggle.Text = "Toggled to maximum volume";
            this.lblToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 66);
            this.Controls.Add(this.lblToggle);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupMax);
            this.Controls.Add(this.nupMin);
            this.Name = "MainWindow";
            this.Text = "Volume Transitioner";
            ((System.ComponentModel.ISupportInitialize)(this.nupMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NumericUpDown nupMin;
        private NumericUpDown nupMax;
        private Label label1;
        private Label label2;
        private Button btnToggle;
        private Label lblToggle;
    }
}