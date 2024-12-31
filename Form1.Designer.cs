namespace TrafficLight
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            ctrlTrafficLight1 = new ctrlTrafficLight();
            ctrlTrafficLight2 = new ctrlTrafficLight();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(535, 169);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(535, 230);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ctrlTrafficLight1
            // 
            ctrlTrafficLight1.GreenTime = 2;
            ctrlTrafficLight1.Location = new Point(31, 22);
            ctrlTrafficLight1.Name = "ctrlTrafficLight1";
            ctrlTrafficLight1.RedTime = 5;
            ctrlTrafficLight1.Size = new Size(138, 340);
            ctrlTrafficLight1.StartColor = Classes.LightColorEnum.Green;
            ctrlTrafficLight1.TabIndex = 3;
            ctrlTrafficLight1.YellowTime = 4;
            // 
            // ctrlTrafficLight2
            // 
            ctrlTrafficLight2.GreenTime = 15;
            ctrlTrafficLight2.Location = new Point(204, 22);
            ctrlTrafficLight2.Name = "ctrlTrafficLight2";
            ctrlTrafficLight2.RedTime = 15;
            ctrlTrafficLight2.Size = new Size(138, 340);
            ctrlTrafficLight2.StartColor = Classes.LightColorEnum.Red;
            ctrlTrafficLight2.TabIndex = 4;
            ctrlTrafficLight2.YellowTime = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ctrlTrafficLight2);
            Controls.Add(ctrlTrafficLight1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private ctrlTrafficLight ctrlTrafficLight1;
        private ctrlTrafficLight ctrlTrafficLight2;
    }
}
