namespace WinFormsApp
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
            buttonRun = new Button();
            seedBox = new TextBox();
            labelSeed = new Label();
            labelNumber = new Label();
            labelCapacity = new Label();
            numberBox = new TextBox();
            capacityBox = new TextBox();
            instanceBox = new ListBox();
            resultBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(46, 225);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(94, 29);
            buttonRun.TabIndex = 0;
            buttonRun.Text = "RUN";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += ButtonRun_Click;
            // 
            // seedBox
            // 
            seedBox.Location = new Point(46, 49);
            seedBox.Name = "seedBox";
            seedBox.Size = new Size(125, 27);
            seedBox.TabIndex = 2;
            // 
            // labelSeed
            // 
            labelSeed.AutoSize = true;
            labelSeed.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelSeed.Location = new Point(46, 26);
            labelSeed.Name = "labelSeed";
            labelSeed.Size = new Size(42, 20);
            labelSeed.TabIndex = 3;
            labelSeed.Text = "Seed";
            labelSeed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelNumber.Location = new Point(47, 88);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(124, 20);
            labelNumber.TabIndex = 4;
            labelNumber.Text = "Number of itmes";
            labelNumber.TextAlign = ContentAlignment.MiddleCenter;
            labelNumber.Click += Items_Click;
            // 
            // labelCapacity
            // 
            labelCapacity.AutoSize = true;
            labelCapacity.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelCapacity.Location = new Point(46, 150);
            labelCapacity.Name = "labelCapacity";
            labelCapacity.Size = new Size(67, 20);
            labelCapacity.TabIndex = 5;
            labelCapacity.Text = "Capacity";
            labelCapacity.Click += labelSize_Click;
            // 
            // numberBox
            // 
            numberBox.Location = new Point(46, 111);
            numberBox.Name = "numberBox";
            numberBox.Size = new Size(125, 27);
            numberBox.TabIndex = 6;
            // 
            // capacityBox
            // 
            capacityBox.Location = new Point(46, 173);
            capacityBox.Name = "capacityBox";
            capacityBox.Size = new Size(125, 27);
            capacityBox.TabIndex = 7;
            // 
            // instanceBox
            // 
            instanceBox.FormattingEnabled = true;
            instanceBox.Location = new Point(348, 49);
            instanceBox.Name = "instanceBox";
            instanceBox.Size = new Size(270, 384);
            instanceBox.TabIndex = 8;
            instanceBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // resultBox
            // 
            resultBox.Location = new Point(46, 308);
            resultBox.Multiline = true;
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(234, 125);
            resultBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(47, 285);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 10;
            label1.Text = "Results";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(348, 26);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 11;
            label2.Text = "Instance";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 476);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resultBox);
            Controls.Add(instanceBox);
            Controls.Add(capacityBox);
            Controls.Add(numberBox);
            Controls.Add(labelCapacity);
            Controls.Add(labelNumber);
            Controls.Add(labelSeed);
            Controls.Add(seedBox);
            Controls.Add(buttonRun);
            Name = "Form1";
            Text = "Backpack Problem";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRun;
        private TextBox seedBox;
        private Label labelSeed;
        private Label labelNumber;
        private Label labelCapacity;
        private TextBox numberBox;
        private TextBox capacityBox;
        private ListBox instanceBox;
        private TextBox resultBox;
        private Label label1;
        private Label label2;
    }
}
