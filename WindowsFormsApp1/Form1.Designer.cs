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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.sqrtButton = new System.Windows.Forms.Button();
            this.sqButton = new System.Windows.Forms.Button();
            this.sinButton = new System.Windows.Forms.Button();
            this.cosButton = new System.Windows.Forms.Button();
            this.aSinButton = new System.Windows.Forms.Button();
            this.aCosButton = new System.Windows.Forms.Button();
            this.tanButton = new System.Windows.Forms.Button();
            this.aTanButton = new System.Windows.Forms.Button();
            this.plusMinusButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculatorDisplay
            // 
            this.calculatorDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculatorDisplay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calculatorDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorDisplay.ForeColor = System.Drawing.Color.White;
            this.calculatorDisplay.Location = new System.Drawing.Point(4, 4);
            this.calculatorDisplay.Name = "calculatorDisplay";
            this.calculatorDisplay.Size = new System.Drawing.Size(478, 75);
            this.calculatorDisplay.TabIndex = 1;
            this.calculatorDisplay.Text = "0";
            this.calculatorDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sixButton
            // 
            this.sixButton.AutoSize = true;
            this.sixButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixButton.Location = new System.Drawing.Point(164, 202);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(78, 58);
            this.sixButton.TabIndex = 6;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.AutoSize = true;
            this.fiveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveButton.Location = new System.Drawing.Point(84, 202);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(78, 58);
            this.fiveButton.TabIndex = 5;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.AutoSize = true;
            this.fourButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourButton.Location = new System.Drawing.Point(4, 202);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(78, 58);
            this.fourButton.TabIndex = 4;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.AutoSize = true;
            this.nineButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineButton.Location = new System.Drawing.Point(164, 142);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(78, 58);
            this.nineButton.TabIndex = 3;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.AutoSize = true;
            this.oneButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneButton.Location = new System.Drawing.Point(4, 262);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(78, 58);
            this.oneButton.TabIndex = 7;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.AutoSize = true;
            this.divisionButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionButton.Location = new System.Drawing.Point(244, 142);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(78, 58);
            this.divisionButton.TabIndex = 13;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.AutoSize = true;
            this.twoButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoButton.Location = new System.Drawing.Point(84, 262);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(78, 58);
            this.twoButton.TabIndex = 8;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.AutoSize = true;
            this.multiplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.multiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicationButton.Location = new System.Drawing.Point(244, 82);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(78, 58);
            this.multiplicationButton.TabIndex = 12;
            this.multiplicationButton.Text = "x";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.multiplicationButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.AutoSize = true;
            this.threeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeButton.Location = new System.Drawing.Point(164, 262);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(78, 58);
            this.threeButton.TabIndex = 9;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.AutoSize = true;
            this.eightButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightButton.Location = new System.Drawing.Point(84, 142);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(78, 58);
            this.eightButton.TabIndex = 2;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.AutoSize = true;
            this.sevenButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenButton.Location = new System.Drawing.Point(4, 142);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(78, 58);
            this.sevenButton.TabIndex = 0;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.BackColor = System.Drawing.SystemColors.Control;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.Control;
            this.clearButton.Location = new System.Drawing.Point(4, 82);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(238, 58);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "AC";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // subtractionButton
            // 
            this.subtractionButton.AutoSize = true;
            this.subtractionButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.subtractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractionButton.Location = new System.Drawing.Point(244, 262);
            this.subtractionButton.Name = "subtractionButton";
            this.subtractionButton.Size = new System.Drawing.Size(78, 58);
            this.subtractionButton.TabIndex = 14;
            this.subtractionButton.Text = "-";
            this.subtractionButton.UseVisualStyleBackColor = true;
            this.subtractionButton.Click += new System.EventHandler(this.subtractionButton_Click);
            // 
            // additionButton
            // 
            this.additionButton.AutoSize = true;
            this.additionButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.additionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionButton.Location = new System.Drawing.Point(244, 202);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(78, 58);
            this.additionButton.TabIndex = 20;
            this.additionButton.Text = "+";
            this.additionButton.UseVisualStyleBackColor = true;
            this.additionButton.Click += new System.EventHandler(this.additionButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.AutoSize = true;
            this.equalButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalButton.Location = new System.Drawing.Point(164, 322);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(158, 58);
            this.equalButton.TabIndex = 15;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.AutoSize = true;
            this.decimalButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButton.Location = new System.Drawing.Point(84, 322);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(78, 58);
            this.decimalButton.TabIndex = 11;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.AutoSize = true;
            this.zeroButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroButton.Location = new System.Drawing.Point(4, 322);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(78, 58);
            this.zeroButton.TabIndex = 10;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // sqrtButton
            // 
            this.sqrtButton.AutoSize = true;
            this.sqrtButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sqrtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrtButton.Location = new System.Drawing.Point(324, 82);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(78, 58);
            this.sqrtButton.TabIndex = 21;
            this.sqrtButton.Text = "√(x)";
            this.sqrtButton.UseVisualStyleBackColor = true;
            this.sqrtButton.Click += new System.EventHandler(this.sqrtButton_Click);
            // 
            // sqButton
            // 
            this.sqButton.AutoSize = true;
            this.sqButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sqButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqButton.Location = new System.Drawing.Point(404, 82);
            this.sqButton.Name = "sqButton";
            this.sqButton.Size = new System.Drawing.Size(78, 58);
            this.sqButton.TabIndex = 22;
            this.sqButton.Text = "x²";
            this.sqButton.UseVisualStyleBackColor = true;
            this.sqButton.Click += new System.EventHandler(this.sqButton_Click);
            // 
            // sinButton
            // 
            this.sinButton.AutoSize = true;
            this.sinButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinButton.Location = new System.Drawing.Point(324, 142);
            this.sinButton.Name = "sinButton";
            this.sinButton.Size = new System.Drawing.Size(78, 58);
            this.sinButton.TabIndex = 23;
            this.sinButton.Text = "sin";
            this.sinButton.UseVisualStyleBackColor = true;
            this.sinButton.Click += new System.EventHandler(this.sinButton_Click);
            // 
            // cosButton
            // 
            this.cosButton.AutoSize = true;
            this.cosButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cosButton.Location = new System.Drawing.Point(324, 202);
            this.cosButton.Name = "cosButton";
            this.cosButton.Size = new System.Drawing.Size(78, 58);
            this.cosButton.TabIndex = 24;
            this.cosButton.Text = "cos";
            this.cosButton.UseVisualStyleBackColor = true;
            this.cosButton.Click += new System.EventHandler(this.cosButton_Click);
            // 
            // aSinButton
            // 
            this.aSinButton.AutoSize = true;
            this.aSinButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.aSinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aSinButton.Location = new System.Drawing.Point(404, 142);
            this.aSinButton.Name = "aSinButton";
            this.aSinButton.Size = new System.Drawing.Size(78, 58);
            this.aSinButton.TabIndex = 25;
            this.aSinButton.Text = "asin";
            this.aSinButton.UseVisualStyleBackColor = true;
            this.aSinButton.Click += new System.EventHandler(this.aSinButton_Click);
            // 
            // aCosButton
            // 
            this.aCosButton.AutoSize = true;
            this.aCosButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.aCosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aCosButton.Location = new System.Drawing.Point(404, 202);
            this.aCosButton.Name = "aCosButton";
            this.aCosButton.Size = new System.Drawing.Size(78, 58);
            this.aCosButton.TabIndex = 26;
            this.aCosButton.Text = "acos";
            this.aCosButton.UseVisualStyleBackColor = true;
            this.aCosButton.Click += new System.EventHandler(this.aCosButton_Click);
            // 
            // tanButton
            // 
            this.tanButton.AutoSize = true;
            this.tanButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanButton.Location = new System.Drawing.Point(324, 262);
            this.tanButton.Name = "tanButton";
            this.tanButton.Size = new System.Drawing.Size(78, 58);
            this.tanButton.TabIndex = 27;
            this.tanButton.Text = "tan";
            this.tanButton.UseVisualStyleBackColor = true;
            this.tanButton.Click += new System.EventHandler(this.tanButton_Click);
            // 
            // aTanButton
            // 
            this.aTanButton.AutoSize = true;
            this.aTanButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.aTanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aTanButton.Location = new System.Drawing.Point(404, 262);
            this.aTanButton.Name = "aTanButton";
            this.aTanButton.Size = new System.Drawing.Size(78, 58);
            this.aTanButton.TabIndex = 28;
            this.aTanButton.Text = "atan";
            this.aTanButton.UseVisualStyleBackColor = true;
            this.aTanButton.Click += new System.EventHandler(this.aTanButton_Click);
            // 
            // plusMinusButton
            // 
            this.plusMinusButton.AutoSize = true;
            this.plusMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plusMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusMinusButton.Location = new System.Drawing.Point(324, 322);
            this.plusMinusButton.Name = "plusMinusButton";
            this.plusMinusButton.Size = new System.Drawing.Size(78, 58);
            this.plusMinusButton.TabIndex = 29;
            this.plusMinusButton.Text = "+/-";
            this.plusMinusButton.UseVisualStyleBackColor = true;
            this.plusMinusButton.Click += new System.EventHandler(this.plusMinusButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Unispace", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(404, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 58);
            this.label1.TabIndex = 30;
            this.label1.Text = "JLA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(486, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plusMinusButton);
            this.Controls.Add(this.aTanButton);
            this.Controls.Add(this.tanButton);
            this.Controls.Add(this.aCosButton);
            this.Controls.Add(this.aSinButton);
            this.Controls.Add(this.cosButton);
            this.Controls.Add(this.sinButton);
            this.Controls.Add(this.sqButton);
            this.Controls.Add(this.sqrtButton);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.Button sqButton;
        private System.Windows.Forms.Button sinButton;
        private System.Windows.Forms.Button cosButton;
        private System.Windows.Forms.Button aSinButton;
        private System.Windows.Forms.Button aCosButton;
        private System.Windows.Forms.Button tanButton;
        private System.Windows.Forms.Button aTanButton;
        private System.Windows.Forms.Button plusMinusButton;
        private System.Windows.Forms.Label label1;
    }
}

