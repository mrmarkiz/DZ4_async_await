namespace DZ4
{
    partial class MenuForm
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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(132, 60);
            button1.TabIndex = 0;
            button1.Tag = "1";
            button1.Text = "Task1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonTask_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 78);
            button2.Name = "button2";
            button2.Size = new Size(132, 60);
            button2.TabIndex = 0;
            button2.Tag = "2";
            button2.Text = "Task2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonTask_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(150, 12);
            button3.Name = "button3";
            button3.Size = new Size(132, 60);
            button3.TabIndex = 0;
            button3.Tag = "3";
            button3.Text = "Task3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonTask_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(150, 78);
            button4.Name = "button4";
            button4.Size = new Size(132, 60);
            button4.TabIndex = 0;
            button4.Tag = "4";
            button4.Text = "Task4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonTask_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(84, 144);
            button5.Name = "button5";
            button5.Size = new Size(132, 60);
            button5.TabIndex = 0;
            button5.Tag = "5";
            button5.Text = "Task5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonTask_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 214);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MenuForm";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}