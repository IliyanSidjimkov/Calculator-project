namespace Calculator_Project
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
            FirstOperand = new TextBox();
            Operation = new TextBox();
            SecondOperand = new TextBox();
            FirstOp = new Label();
            Op = new Label();
            SecondOp = new Label();
            Calculate = new Button();
            result = new Label();
            res = new Label();
            Clear = new Button();
            Exit = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // FirstOperand
            // 
            FirstOperand.Location = new Point(39, 42);
            FirstOperand.Name = "FirstOperand";
            FirstOperand.Size = new Size(100, 23);
            FirstOperand.TabIndex = 0;
            // 
            // Operation
            // 
            Operation.Location = new Point(203, 42);
            Operation.Name = "Operation";
            Operation.Size = new Size(100, 23);
            Operation.TabIndex = 1;
            // 
            // SecondOperand
            // 
            SecondOperand.Location = new Point(364, 42);
            SecondOperand.Name = "SecondOperand";
            SecondOperand.Size = new Size(100, 23);
            SecondOperand.TabIndex = 2;
            // 
            // FirstOp
            // 
            FirstOp.AutoSize = true;
            FirstOp.Location = new Point(48, 24);
            FirstOp.Name = "FirstOp";
            FirstOp.Size = new Size(79, 15);
            FirstOp.TabIndex = 3;
            FirstOp.Text = "First operand ";
            // 
            // Op
            // 
            Op.AutoSize = true;
            Op.Location = new Point(213, 24);
            Op.Name = "Op";
            Op.Size = new Size(60, 15);
            Op.TabIndex = 4;
            Op.Text = "Operation";
            // 
            // SecondOp
            // 
            SecondOp.AutoSize = true;
            SecondOp.Location = new Point(364, 24);
            SecondOp.Name = "SecondOp";
            SecondOp.Size = new Size(96, 15);
            SecondOp.TabIndex = 5;
            SecondOp.Text = "Second operand ";
            // 
            // Calculate
            // 
            Calculate.Location = new Point(213, 101);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(75, 23);
            Calculate.TabIndex = 6;
            Calculate.Text = "Calculate";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += button1_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(134, 312);
            result.Name = "result";
            result.Size = new Size(42, 15);
            result.TabIndex = 7;
            result.Text = "Result:";
            // 
            // res
            // 
            res.AutoSize = true;
            res.Location = new Point(224, 321);
            res.Name = "res";
            res.Size = new Size(0, 15);
            res.TabIndex = 8;
            // 
            // Clear
            // 
            Clear.Location = new Point(49, 389);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 23);
            Clear.TabIndex = 9;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += button2_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(423, 389);
            Exit.Name = "Exit";
            Exit.Size = new Size(75, 23);
            Exit.TabIndex = 10;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Calculate);
            groupBox1.Controls.Add(SecondOp);
            groupBox1.Controls.Add(Op);
            groupBox1.Controls.Add(FirstOp);
            groupBox1.Controls.Add(SecondOperand);
            groupBox1.Controls.Add(Operation);
            groupBox1.Controls.Add(FirstOperand);
            groupBox1.Location = new Point(21, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(497, 148);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculation Process";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(144, 40);
            label1.Name = "label1";
            label1.Size = new Size(242, 40);
            label1.TabIndex = 7;
            label1.Text = "Calculator Project";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(545, 436);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(Exit);
            Controls.Add(Clear);
            Controls.Add(res);
            Controls.Add(result);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FirstOperand;
        private TextBox Operation;
        private TextBox SecondOperand;
        private Label FirstOp;
        private Label Op;
        private Label SecondOp;
        private Button Calculate;
        private Label result;
        private Label res;
        private Button Clear;
        private Button Exit;
        private GroupBox groupBox1;
        private Label label1;
    }
}
