namespace CopycatCalculator
{
    partial class frmMain
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
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.lsbHistory = new System.Windows.Forms.ListBox();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtbOutput.Location = new System.Drawing.Point(12, 12);
            this.rtbOutput.Multiline = false;
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtbOutput.Size = new System.Drawing.Size(318, 96);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            // 
            // lsbHistory
            // 
            this.lsbHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lsbHistory.FormattingEnabled = true;
            this.lsbHistory.ItemHeight = 15;
            this.lsbHistory.Location = new System.Drawing.Point(336, 12);
            this.lsbHistory.Name = "lsbHistory";
            this.lsbHistory.Size = new System.Drawing.Size(120, 409);
            this.lsbHistory.TabIndex = 1;
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.Gray;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeven.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSeven.Location = new System.Drawing.Point(12, 114);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(75, 47);
            this.btnSeven.TabIndex = 2;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.ButtonInput_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.Gray;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEight.Location = new System.Drawing.Point(93, 114);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(75, 47);
            this.btnEight.TabIndex = 3;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.ButtonInput_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.Gray;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNine.Location = new System.Drawing.Point(174, 114);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(75, 47);
            this.btnNine.TabIndex = 4;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.ButtonInput_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.Gray;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFour.Location = new System.Drawing.Point(12, 167);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(75, 47);
            this.btnFour.TabIndex = 5;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.ButtonInput_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.Gray;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFive.Location = new System.Drawing.Point(93, 167);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(75, 47);
            this.btnFive.TabIndex = 6;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.ButtonInput_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.Gray;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSix.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSix.Location = new System.Drawing.Point(174, 167);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(75, 47);
            this.btnSix.TabIndex = 7;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.ButtonInput_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.Gray;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOne.Location = new System.Drawing.Point(12, 220);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(75, 47);
            this.btnOne.TabIndex = 8;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.ButtonInput_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.Gray;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTwo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTwo.Location = new System.Drawing.Point(93, 220);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(75, 47);
            this.btnTwo.TabIndex = 9;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.ButtonInput_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.Gray;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThree.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThree.Location = new System.Drawing.Point(174, 220);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(75, 47);
            this.btnThree.TabIndex = 10;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.ButtonInput_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.Gray;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnZero.Location = new System.Drawing.Point(93, 273);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(75, 47);
            this.btnZero.TabIndex = 11;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.ButtonInput_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.Silver;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDivide.Location = new System.Drawing.Point(255, 114);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 47);
            this.btnDivide.TabIndex = 12;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.Silver;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiply.Location = new System.Drawing.Point(255, 167);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 47);
            this.btnMultiply.TabIndex = 13;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.Silver;
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubtract.Location = new System.Drawing.Point(255, 220);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(75, 47);
            this.btnSubtract.TabIndex = 14;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(255, 273);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 47);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Silver;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnter.Location = new System.Drawing.Point(255, 326);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 47);
            this.btnEnter.TabIndex = 16;
            this.btnEnter.Text = "=";
            this.btnEnter.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(467, 450);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.lsbHistory);
            this.Controls.Add(this.rtbOutput);
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyboardInput_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtbOutput;
        private ListBox lsbHistory;
        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnZero;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnSubtract;
        private Button btnAdd;
        private Button btnEnter;
    }
}