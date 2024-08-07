namespace BasicCalculator
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
            AddButton = new Button();
            FirstNumText = new TextBox();
            SubButton = new Button();
            MulButton = new Button();
            DivButton = new Button();
            SecondNumText = new TextBox();
            OutputNumText = new TextBox();
            FirstNum = new Label();
            SecondNum = new Label();
            OutputNumber = new Label();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.White;
            AddButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddButton.ForeColor = Color.FromArgb(64, 64, 64);
            AddButton.Location = new Point(3, 531);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(159, 65);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += Add_Click;
            // 
            // FirstNumText
            // 
            FirstNumText.BackColor = Color.FromArgb(64, 64, 64);
            FirstNumText.ForeColor = Color.White;
            FirstNumText.Location = new Point(92, 57);
            FirstNumText.Name = "FirstNumText";
            FirstNumText.Size = new Size(226, 31);
            FirstNumText.TabIndex = 4;
            // 
            // SubButton
            // 
            SubButton.BackColor = Color.White;
            SubButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubButton.ForeColor = Color.FromArgb(64, 64, 64);
            SubButton.Location = new Point(181, 531);
            SubButton.Name = "SubButton";
            SubButton.Size = new Size(159, 65);
            SubButton.TabIndex = 7;
            SubButton.Text = "Substract";
            SubButton.UseVisualStyleBackColor = false;
            SubButton.Click += button1_Click_1;
            // 
            // MulButton
            // 
            MulButton.BackColor = Color.White;
            MulButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MulButton.ForeColor = Color.FromArgb(64, 64, 64);
            MulButton.Location = new Point(361, 531);
            MulButton.Name = "MulButton";
            MulButton.Size = new Size(159, 65);
            MulButton.TabIndex = 8;
            MulButton.Text = "Multiply";
            MulButton.UseVisualStyleBackColor = false;
            MulButton.Click += MulButton_Click;
            // 
            // DivButton
            // 
            DivButton.BackColor = Color.White;
            DivButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DivButton.ForeColor = Color.FromArgb(64, 64, 64);
            DivButton.Location = new Point(539, 531);
            DivButton.Name = "DivButton";
            DivButton.Size = new Size(159, 65);
            DivButton.TabIndex = 9;
            DivButton.Text = "Divide";
            DivButton.UseVisualStyleBackColor = false;
            DivButton.Click += DivButton_Click;
            // 
            // SecondNumText
            // 
            SecondNumText.BackColor = Color.FromArgb(64, 64, 64);
            SecondNumText.ForeColor = Color.White;
            SecondNumText.Location = new Point(92, 185);
            SecondNumText.Name = "SecondNumText";
            SecondNumText.Size = new Size(226, 31);
            SecondNumText.TabIndex = 10;
            // 
            // OutputNumText
            // 
            OutputNumText.BackColor = Color.FromArgb(64, 64, 64);
            OutputNumText.ForeColor = Color.White;
            OutputNumText.Location = new Point(422, 86);
            OutputNumText.Name = "OutputNumText";
            OutputNumText.Size = new Size(226, 31);
            OutputNumText.TabIndex = 11;
            // 
            // FirstNum
            // 
            FirstNum.AutoSize = true;
            FirstNum.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FirstNum.Location = new Point(92, 18);
            FirstNum.Name = "FirstNum";
            FirstNum.Size = new Size(134, 28);
            FirstNum.TabIndex = 12;
            FirstNum.Text = "Number-1";
            // 
            // SecondNum
            // 
            SecondNum.AutoSize = true;
            SecondNum.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SecondNum.Location = new Point(92, 144);
            SecondNum.Name = "SecondNum";
            SecondNum.Size = new Size(134, 28);
            SecondNum.TabIndex = 13;
            SecondNum.Text = "Number-2";
            SecondNum.Click += label2_Click;
            // 
            // OutputNumber
            // 
            OutputNumber.AutoSize = true;
            OutputNumber.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OutputNumber.Location = new Point(422, 45);
            OutputNumber.Name = "OutputNumber";
            OutputNumber.Size = new Size(101, 28);
            OutputNumber.TabIndex = 14;
            OutputNumber.Text = "Output";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(705, 640);
            Controls.Add(OutputNumber);
            Controls.Add(SecondNum);
            Controls.Add(FirstNum);
            Controls.Add(OutputNumText);
            Controls.Add(SecondNumText);
            Controls.Add(DivButton);
            Controls.Add(MulButton);
            Controls.Add(SubButton);
            Controls.Add(FirstNumText);
            Controls.Add(AddButton);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private TextBox FirstNumText;
        private Button SubButton;
        private Button MulButton;
        private Button DivButton;
        private TextBox SecondNumText;
        private TextBox OutputNumText;
        private Label FirstNum;
        private Label SecondNum;
        private Label OutputNumber;
    }
}
