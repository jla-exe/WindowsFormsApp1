namespace WindowsFormsApp1
{
    partial class Form1
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
            this.calculatorDisplay = new System.Windows.Forms.Label();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.subtractionButton = new System.Windows.Forms.Button();
            this.additionButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculatorDisplay
            // 
            this.calculatorDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calculatorDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculatorDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorDisplay.ForeColor = System.Drawing.Color.White;
            this.calculatorDisplay.Location = new System.Drawing.Point(10, 6);
            this.calculatorDisplay.Name = "calculatorDisplay";
            this.calculatorDisplay.Size = new System.Drawing.Size(314, 65);
            this.calculatorDisplay.TabIndex = 1;
            this.calculatorDisplay.Text = "0";
            // 
            // sixButton
            // 
            this.sixButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sixButton.AutoSize = true;
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixButton.Location = new System.Drawing.Point(170, 200);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(74, 54);
            this.sixButton.TabIndex = 6;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fiveButton.AutoSize = true;
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveButton.Location = new System.Drawing.Point(90, 200);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(74, 54);
            this.fiveButton.TabIndex = 5;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fourButton.AutoSize = true;
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourButton.Location = new System.Drawing.Point(10, 200);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(74, 54);
            this.fourButton.TabIndex = 4;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nineButton.AutoSize = true;
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineButton.Location = new System.Drawing.Point(170, 140);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(74, 54);
            this.nineButton.TabIndex = 3;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oneButton.AutoSize = true;
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneButton.Location = new System.Drawing.Point(10, 260);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(74, 54);
            this.oneButton.TabIndex = 7;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divisionButton.AutoSize = true;
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionButton.Location = new System.Drawing.Point(250, 140);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(74, 54);
            this.divisionButton.TabIndex = 13;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.twoButton.AutoSize = true;
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoButton.Location = new System.Drawing.Point(90, 260);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(74, 54);
            this.twoButton.TabIndex = 8;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.multiplicationButton.AutoSize = true;
            this.multiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicationButton.Location = new System.Drawing.Point(250, 80);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(74, 54);
            this.multiplicationButton.TabIndex = 12;
            this.multiplicationButton.Text = "x";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.multiplicationButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.threeButton.AutoSize = true;
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeButton.Location = new System.Drawing.Point(170, 260);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(74, 54);
            this.threeButton.TabIndex = 9;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eightButton.AutoSize = true;
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightButton.Location = new System.Drawing.Point(90, 140);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(74, 54);
            this.eightButton.TabIndex = 2;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sevenButton.AutoSize = true;
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenButton.Location = new System.Drawing.Point(10, 140);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(74, 54);
            this.sevenButton.TabIndex = 0;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearButton.AutoSize = true;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(10, 80);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(234, 54);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "AC";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // subtractionButton
            // 
            this.subtractionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subtractionButton.AutoSize = true;
            this.subtractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractionButton.Location = new System.Drawing.Point(250, 260);
            this.subtractionButton.Name = "subtractionButton";
            this.subtractionButton.Size = new System.Drawing.Size(74, 54);
            this.subtractionButton.TabIndex = 14;
            this.subtractionButton.Text = "-";
            this.subtractionButton.UseVisualStyleBackColor = true;
            this.subtractionButton.Click += new System.EventHandler(this.subtractionButton_Click);
            // 
            // additionButton
            // 
            this.additionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.additionButton.AutoSize = true;
            this.additionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionButton.Location = new System.Drawing.Point(250, 200);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(74, 54);
            this.additionButton.TabIndex = 20;
            this.additionButton.Text = "+";
            this.additionButton.UseVisualStyleBackColor = true;
            this.additionButton.Click += new System.EventHandler(this.additionButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.equalButton.AutoSize = true;
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalButton.Location = new System.Drawing.Point(170, 320);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(154, 54);
            this.equalButton.TabIndex = 15;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.decimalButton.AutoSize = true;
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButton.Location = new System.Drawing.Point(90, 320);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(74, 54);
            this.decimalButton.TabIndex = 11;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zeroButton.AutoSize = true;
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroButton.Location = new System.Drawing.Point(10, 320);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(74, 54);
            this.zeroButton.TabIndex = 10;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 384);
            this.Controls.Add(this.additionButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.subtractionButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.multiplicationButton);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.calculatorDisplay);
            this.Controls.Add(this.sevenButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label calculatorDisplay;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button subtractionButton;
        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button zeroButton;
    }
}

