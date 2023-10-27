namespace DZ4
{
    partial class FormTask4
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
            label1 = new Label();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Results";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(171, 54);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(564, 364);
            listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 54);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 0;
            label2.Text = "Word";
            // 
            // button1
            // 
            button1.Location = new Point(12, 143);
            button1.Name = "button1";
            button1.Size = new Size(125, 55);
            button1.TabIndex = 3;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormTask4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTask4";
            Text = "FormTask4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
    }
}