namespace Tp3_1302220037_Nizar_Rasyiid
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
            INPUT = new Button();
            button2 = new Button();
            Output = new Button();
            Submit = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // INPUT
            // 
            INPUT.AccessibleName = "";
            INPUT.BackColor = Color.OrangeRed;
            INPUT.ForeColor = SystemColors.ButtonFace;
            INPUT.Location = new Point(75, 23);
            INPUT.Name = "INPUT";
            INPUT.Size = new Size(230, 50);
            INPUT.TabIndex = 0;
            INPUT.Tag = "";
            INPUT.Text = "INPUT";
            INPUT.UseVisualStyleBackColor = false;
            INPUT.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(785, 204);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Output
            // 
            Output.BackColor = Color.OrangeRed;
            Output.ForeColor = SystemColors.ButtonFace;
            Output.Location = new Point(75, 101);
            Output.Name = "Output";
            Output.Size = new Size(383, 51);
            Output.TabIndex = 2;
            Output.UseVisualStyleBackColor = false;
            Output.Click += button3_Click;
            // 
            // Submit
            // 
            Submit.BackColor = Color.OrangeRed;
            Submit.ForeColor = SystemColors.ButtonFace;
            Submit.Location = new Point(337, 23);
            Submit.Name = "Submit";
            Submit.Size = new Size(121, 50);
            Submit.TabIndex = 3;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.OrangeRed;
            textBox1.Location = new Point(111, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.OrangeRed;
            label1.Location = new Point(248, 119);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 5;
            label1.Text = "Output";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(Submit);
            Controls.Add(Output);
            Controls.Add(button2);
            Controls.Add(INPUT);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button INPUT;
        private Button button2;
        private Button Output;
        private Button Submit;
        private TextBox textBox1;
        private Label label1;
    }
}
