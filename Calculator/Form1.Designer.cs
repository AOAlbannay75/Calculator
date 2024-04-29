namespace Calculator
{
    partial class calculator
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
            sevenBt = new Button();
            calculatorDisplay = new Label();
            fourBt = new Button();
            oneBt = new Button();
            eightBt = new Button();
            fiveBt = new Button();
            twoBt = new Button();
            nineBt = new Button();
            sixBt = new Button();
            threeBt = new Button();
            minusBt = new Button();
            multiplyBt = new Button();
            clearBt = new Button();
            devideBt = new Button();
            plusBt = new Button();
            zeroBt = new Button();
            dotBt = new Button();
            equalBt = new Button();
            ClearEntryBtn = new Button();
            DeleteBtn = new Button();
            SuspendLayout();
            // 
            // sevenBt
            // 
            sevenBt.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            sevenBt.Location = new Point(13, 92);
            sevenBt.Name = "sevenBt";
            sevenBt.Size = new Size(78, 60);
            sevenBt.TabIndex = 0;
            sevenBt.Text = "7";
            sevenBt.UseVisualStyleBackColor = true;
            sevenBt.Click += NumbPad;
            // 
            // calculatorDisplay
            // 
            calculatorDisplay.BackColor = SystemColors.ActiveCaptionText;
            calculatorDisplay.Font = new Font("Segoe UI", 35F);
            calculatorDisplay.ForeColor = SystemColors.ButtonFace;
            calculatorDisplay.Location = new Point(12, 9);
            calculatorDisplay.Name = "calculatorDisplay";
            calculatorDisplay.Size = new Size(415, 72);
            calculatorDisplay.TabIndex = 1;
            calculatorDisplay.Text = "0";
            // 
            // fourBt
            // 
            fourBt.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            fourBt.Location = new Point(13, 158);
            fourBt.Name = "fourBt";
            fourBt.Size = new Size(78, 60);
            fourBt.TabIndex = 2;
            fourBt.Text = "4";
            fourBt.UseVisualStyleBackColor = true;
            fourBt.Click += NumbPad;
            // 
            // oneBt
            // 
            oneBt.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            oneBt.Location = new Point(13, 224);
            oneBt.Name = "oneBt";
            oneBt.Size = new Size(78, 60);
            oneBt.TabIndex = 3;
            oneBt.Text = "1";
            oneBt.UseVisualStyleBackColor = true;
            oneBt.Click += NumbPad;
            // 
            // eightBt
            // 
            eightBt.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            eightBt.Location = new Point(97, 92);
            eightBt.Name = "eightBt";
            eightBt.Size = new Size(78, 60);
            eightBt.TabIndex = 4;
            eightBt.Text = "8";
            eightBt.UseVisualStyleBackColor = true;
            eightBt.Click += NumbPad;
            // 
            // fiveBt
            // 
            fiveBt.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            fiveBt.Location = new Point(97, 158);
            fiveBt.Name = "fiveBt";
            fiveBt.Size = new Size(78, 60);
            fiveBt.TabIndex = 5;
            fiveBt.Text = "5";
            fiveBt.UseVisualStyleBackColor = true;
            fiveBt.Click += NumbPad;
            // 
            // twoBt
            // 
            twoBt.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            twoBt.Location = new Point(97, 224);
            twoBt.Name = "twoBt";
            twoBt.Size = new Size(78, 60);
            twoBt.TabIndex = 6;
            twoBt.Text = "2";
            twoBt.UseVisualStyleBackColor = true;
            twoBt.Click += NumbPad;
            // 
            // nineBt
            // 
            nineBt.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            nineBt.Location = new Point(181, 92);
            nineBt.Name = "nineBt";
            nineBt.Size = new Size(78, 60);
            nineBt.TabIndex = 7;
            nineBt.Text = "9";
            nineBt.UseVisualStyleBackColor = true;
            nineBt.Click += NumbPad;
            // 
            // sixBt
            // 
            sixBt.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            sixBt.Location = new Point(181, 158);
            sixBt.Name = "sixBt";
            sixBt.Size = new Size(78, 60);
            sixBt.TabIndex = 8;
            sixBt.Text = "6";
            sixBt.UseVisualStyleBackColor = true;
            sixBt.Click += NumbPad;
            // 
            // threeBt
            // 
            threeBt.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            threeBt.Location = new Point(181, 224);
            threeBt.Name = "threeBt";
            threeBt.Size = new Size(78, 60);
            threeBt.TabIndex = 9;
            threeBt.Text = "3";
            threeBt.UseVisualStyleBackColor = true;
            threeBt.Click += NumbPad;
            // 
            // minusBt
            // 
            minusBt.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            minusBt.Location = new Point(265, 290);
            minusBt.Name = "minusBt";
            minusBt.Size = new Size(78, 60);
            minusBt.TabIndex = 10;
            minusBt.Text = "-";
            minusBt.UseVisualStyleBackColor = true;
            minusBt.Click += Operators;
            // 
            // multiplyBt
            // 
            multiplyBt.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            multiplyBt.Location = new Point(265, 92);
            multiplyBt.Name = "multiplyBt";
            multiplyBt.Size = new Size(78, 60);
            multiplyBt.TabIndex = 11;
            multiplyBt.Text = "*";
            multiplyBt.UseVisualStyleBackColor = true;
            multiplyBt.Click += Operators;
            // 
            // clearBt
            // 
            clearBt.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            clearBt.Location = new Point(349, 158);
            clearBt.Name = "clearBt";
            clearBt.Size = new Size(78, 60);
            clearBt.TabIndex = 12;
            clearBt.Text = "C";
            clearBt.UseVisualStyleBackColor = true;
            clearBt.Click += clearBt_Click;
            // 
            // devideBt
            // 
            devideBt.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            devideBt.Location = new Point(265, 158);
            devideBt.Name = "devideBt";
            devideBt.Size = new Size(78, 60);
            devideBt.TabIndex = 13;
            devideBt.Text = "/";
            devideBt.UseVisualStyleBackColor = true;
            devideBt.Click += Operators;
            // 
            // plusBt
            // 
            plusBt.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            plusBt.Location = new Point(265, 224);
            plusBt.Name = "plusBt";
            plusBt.Size = new Size(78, 60);
            plusBt.TabIndex = 14;
            plusBt.Text = "+";
            plusBt.UseVisualStyleBackColor = true;
            plusBt.Click += Operators;
            // 
            // zeroBt
            // 
            zeroBt.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            zeroBt.Location = new Point(13, 290);
            zeroBt.Name = "zeroBt";
            zeroBt.Size = new Size(162, 60);
            zeroBt.TabIndex = 15;
            zeroBt.Text = "0";
            zeroBt.UseVisualStyleBackColor = true;
            zeroBt.Click += NumbPad;
            // 
            // dotBt
            // 
            dotBt.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            dotBt.Location = new Point(181, 290);
            dotBt.Name = "dotBt";
            dotBt.Size = new Size(78, 60);
            dotBt.TabIndex = 17;
            dotBt.Text = ".";
            dotBt.UseVisualStyleBackColor = true;
            dotBt.Click += NumbPad;
            // 
            // equalBt
            // 
            equalBt.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            equalBt.Location = new Point(349, 290);
            equalBt.Name = "equalBt";
            equalBt.Size = new Size(78, 60);
            equalBt.TabIndex = 18;
            equalBt.Text = "=";
            equalBt.UseVisualStyleBackColor = true;
            equalBt.Click += Equal;
            // 
            // ClearEntryBtn
            // 
            ClearEntryBtn.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            ClearEntryBtn.Location = new Point(349, 224);
            ClearEntryBtn.Name = "ClearEntryBtn";
            ClearEntryBtn.Size = new Size(78, 60);
            ClearEntryBtn.TabIndex = 19;
            ClearEntryBtn.Text = "CE";
            ClearEntryBtn.UseVisualStyleBackColor = true;
            ClearEntryBtn.Click += ClearEntryBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            DeleteBtn.Location = new Point(349, 92);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(78, 60);
            DeleteBtn.TabIndex = 20;
            DeleteBtn.Text = "DEL";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 363);
            Controls.Add(DeleteBtn);
            Controls.Add(ClearEntryBtn);
            Controls.Add(equalBt);
            Controls.Add(dotBt);
            Controls.Add(zeroBt);
            Controls.Add(plusBt);
            Controls.Add(devideBt);
            Controls.Add(clearBt);
            Controls.Add(multiplyBt);
            Controls.Add(minusBt);
            Controls.Add(threeBt);
            Controls.Add(sixBt);
            Controls.Add(nineBt);
            Controls.Add(twoBt);
            Controls.Add(fiveBt);
            Controls.Add(eightBt);
            Controls.Add(oneBt);
            Controls.Add(fourBt);
            Controls.Add(calculatorDisplay);
            Controls.Add(sevenBt);
            Name = "calculator";
            Text = "Calculator";
            Click += NumbPad;
            ResumeLayout(false);
        }

        #endregion

        private Button sevenBt;
        private Label calculatorDisplay;
        private Button fourBt;
        private Button oneBt;
        private Button eightBt;
        private Button fiveBt;
        private Button twoBt;
        private Button nineBt;
        private Button sixBt;
        private Button threeBt;
        private Button minusBt;
        private Button multiplyBt;
        private Button clearBt;
        private Button devideBt;
        private Button plusBt;
        private Button zeroBt;
        private Button dotBt;
        private Button equalBt;
        private Button ClearEntryBtn;
        private Button DeleteBtn;
    }
}
