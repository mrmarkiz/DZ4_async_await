namespace DZ4
{
    partial class FormTask5
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
            button1 = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(39, 155);
            button1.Name = "button1";
            button1.Size = new Size(125, 55);
            button1.TabIndex = 8;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(198, 66);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(564, 364);
            listBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 66);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 4;
            label2.Text = "Word";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(308, 21);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 5;
            label1.Text = "Results";
            // 
            // FormTask5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTask5";
            Text = "FormTask5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private ListBox listBox1;
        private Label label2;
        private Label label1;
    }
}