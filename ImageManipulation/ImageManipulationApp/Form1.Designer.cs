namespace ImageManipulationApp
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
            orginalPicure = new PictureBox();
            changedPicture = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)orginalPicure).BeginInit();
            ((System.ComponentModel.ISupportInitialize)changedPicture).BeginInit();
            SuspendLayout();
            // 
            // orginalPicure
            // 
            orginalPicure.Location = new Point(56, 130);
            orginalPicure.Name = "orginalPicure";
            orginalPicure.Size = new Size(384, 342);
            orginalPicure.SizeMode = PictureBoxSizeMode.Zoom;
            orginalPicure.TabIndex = 0;
            orginalPicure.TabStop = false;
            // 
            // changedPicture
            // 
            changedPicture.Location = new Point(583, 130);
            changedPicture.Name = "changedPicture";
            changedPicture.Size = new Size(407, 342);
            changedPicture.SizeMode = PictureBoxSizeMode.Zoom;
            changedPicture.TabIndex = 1;
            changedPicture.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(56, 32);
            button1.Name = "button1";
            button1.Size = new Size(192, 40);
            button1.TabIndex = 2;
            button1.Text = "Select image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(456, 153);
            button2.Name = "button2";
            button2.Size = new Size(110, 40);
            button2.TabIndex = 3;
            button2.Text = "To Gray";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(456, 199);
            button3.Name = "button3";
            button3.Size = new Size(110, 40);
            button3.TabIndex = 4;
            button3.Text = "To Negative";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(456, 245);
            button4.Name = "button4";
            button4.Size = new Size(110, 40);
            button4.TabIndex = 5;
            button4.Text = "Resize";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(456, 291);
            button5.Name = "button5";
            button5.Size = new Size(110, 40);
            button5.TabIndex = 6;
            button5.Text = "Rotate";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 494);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(changedPicture);
            Controls.Add(orginalPicure);
            Name = "Form1";
            Text = "Image Manipulation Application";
            ((System.ComponentModel.ISupportInitialize)orginalPicure).EndInit();
            ((System.ComponentModel.ISupportInitialize)changedPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox orginalPicure;
        private PictureBox changedPicture;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}