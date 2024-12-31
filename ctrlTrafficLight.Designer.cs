namespace TrafficLight
{
    partial class ctrlTrafficLight
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlTrafficLight));
            pbTrafficLightDisplay = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            lblTimerDisplay = new Label();
            ((System.ComponentModel.ISupportInitialize)pbTrafficLightDisplay).BeginInit();
            SuspendLayout();
            // 
            // pbTrafficLightDisplay
            // 
            pbTrafficLightDisplay.Image = (Image)resources.GetObject("pbTrafficLightDisplay.Image");
            pbTrafficLightDisplay.Location = new Point(0, 0);
            pbTrafficLightDisplay.Name = "pbTrafficLightDisplay";
            pbTrafficLightDisplay.Size = new Size(138, 270);
            pbTrafficLightDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTrafficLightDisplay.TabIndex = 1;
            pbTrafficLightDisplay.TabStop = false;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick_1;
            // 
            // lblTimerDisplay
            // 
            lblTimerDisplay.AutoSize = true;
            lblTimerDisplay.Font = new Font("Segoe UI", 22F);
            lblTimerDisplay.Location = new Point(40, 276);
            lblTimerDisplay.Name = "lblTimerDisplay";
            lblTimerDisplay.Size = new Size(0, 50);
            lblTimerDisplay.TabIndex = 3;
            lblTimerDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ctrlTrafficLight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTimerDisplay);
            Controls.Add(pbTrafficLightDisplay);
            Name = "ctrlTrafficLight";
            Size = new Size(139, 339);
            ((System.ComponentModel.ISupportInitialize)pbTrafficLightDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbTrafficLightDisplay;
        private System.Windows.Forms.Timer timer;
        private Label lblTimerDisplay;
    }
}
