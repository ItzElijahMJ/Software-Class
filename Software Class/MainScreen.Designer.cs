namespace Software_Class
{
    partial class MainScreen
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
            this.components = new System.ComponentModel.Container();
            this.GreenBack = new System.Windows.Forms.Button();
            this.BlueBack = new System.Windows.Forms.Button();
            this.RedBack = new System.Windows.Forms.Button();
            this.tbFirstNumber = new System.Windows.Forms.TextBox();
            this.tbEndResult = new System.Windows.Forms.TextBox();
            this.tbSecondNumber = new System.Windows.Forms.TextBox();
            this.cbPlus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCalculate = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tLoop = new System.Windows.Forms.Button();
            this.tTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // GreenBack
            // 
            this.GreenBack.BackColor = System.Drawing.Color.Green;
            this.GreenBack.Location = new System.Drawing.Point(12, 12);
            this.GreenBack.Name = "GreenBack";
            this.GreenBack.Size = new System.Drawing.Size(515, 53);
            this.GreenBack.TabIndex = 0;
            this.GreenBack.Text = "Green";
            this.GreenBack.UseVisualStyleBackColor = false;
            this.GreenBack.MouseEnter += new System.EventHandler(this.GreenBack_MouseEnter);
            this.GreenBack.MouseLeave += new System.EventHandler(this.GreenBack_MouseLeave);
            // 
            // BlueBack
            // 
            this.BlueBack.BackColor = System.Drawing.Color.Blue;
            this.BlueBack.ForeColor = System.Drawing.Color.White;
            this.BlueBack.Location = new System.Drawing.Point(12, 71);
            this.BlueBack.Name = "BlueBack";
            this.BlueBack.Size = new System.Drawing.Size(515, 50);
            this.BlueBack.TabIndex = 1;
            this.BlueBack.Text = "Blue";
            this.BlueBack.UseVisualStyleBackColor = false;
            this.BlueBack.MouseEnter += new System.EventHandler(this.BlueBack_MouseEnter);
            this.BlueBack.MouseLeave += new System.EventHandler(this.BlueBack_MouseLeave);
            // 
            // RedBack
            // 
            this.RedBack.BackColor = System.Drawing.Color.Red;
            this.RedBack.Location = new System.Drawing.Point(12, 127);
            this.RedBack.Name = "RedBack";
            this.RedBack.Size = new System.Drawing.Size(515, 52);
            this.RedBack.TabIndex = 2;
            this.RedBack.Text = "Red";
            this.RedBack.UseVisualStyleBackColor = false;
            this.RedBack.MouseEnter += new System.EventHandler(this.RedBack_MouseEnter);
            this.RedBack.MouseLeave += new System.EventHandler(this.RedBack_MouseLeave);
            // 
            // tbFirstNumber
            // 
            this.tbFirstNumber.Location = new System.Drawing.Point(12, 185);
            this.tbFirstNumber.Name = "tbFirstNumber";
            this.tbFirstNumber.Size = new System.Drawing.Size(104, 20);
            this.tbFirstNumber.TabIndex = 3;
            // 
            // tbEndResult
            // 
            this.tbEndResult.Location = new System.Drawing.Point(317, 185);
            this.tbEndResult.Name = "tbEndResult";
            this.tbEndResult.Size = new System.Drawing.Size(218, 20);
            this.tbEndResult.TabIndex = 4;
            // 
            // tbSecondNumber
            // 
            this.tbSecondNumber.Location = new System.Drawing.Point(172, 185);
            this.tbSecondNumber.Name = "tbSecondNumber";
            this.tbSecondNumber.Size = new System.Drawing.Size(120, 20);
            this.tbSecondNumber.TabIndex = 5;
            // 
            // cbPlus
            // 
            this.cbPlus.FormattingEnabled = true;
            this.cbPlus.Items.AddRange(new object[] {
            "plus",
            "min",
            "deel",
            "keer"});
            this.cbPlus.Location = new System.Drawing.Point(122, 184);
            this.cbPlus.Name = "cbPlus";
            this.cbPlus.Size = new System.Drawing.Size(44, 21);
            this.cbPlus.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "=";
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(33, 211);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(493, 38);
            this.btCalculate.TabIndex = 8;
            this.btCalculate.Text = "Calculate";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tLoop
            // 
            this.tLoop.Location = new System.Drawing.Point(232, 283);
            this.tLoop.Name = "tLoop";
            this.tLoop.Size = new System.Drawing.Size(75, 23);
            this.tLoop.TabIndex = 9;
            this.tLoop.Text = "Loop please";
            this.tLoop.UseVisualStyleBackColor = true;
            this.tLoop.Click += new System.EventHandler(this.tLoop_Click);
            // 
            // tTimer
            // 
            this.tTimer.AutoSize = true;
            this.tTimer.Location = new System.Drawing.Point(250, 309);
            this.tTimer.Name = "tTimer";
            this.tTimer.Size = new System.Drawing.Size(30, 13);
            this.tTimer.TabIndex = 10;
            this.tTimer.Text = "Time";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 386);
            this.Controls.Add(this.tTimer);
            this.Controls.Add(this.tLoop);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPlus);
            this.Controls.Add(this.tbSecondNumber);
            this.Controls.Add(this.tbEndResult);
            this.Controls.Add(this.tbFirstNumber);
            this.Controls.Add(this.RedBack);
            this.Controls.Add(this.BlueBack);
            this.Controls.Add(this.GreenBack);
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GreenBack;
        private System.Windows.Forms.Button BlueBack;
        private System.Windows.Forms.Button RedBack;
        private System.Windows.Forms.TextBox tbFirstNumber;
        private System.Windows.Forms.TextBox tbEndResult;
        private System.Windows.Forms.TextBox tbSecondNumber;
        private System.Windows.Forms.ComboBox cbPlus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button tLoop;
        private System.Windows.Forms.Label tTimer;
    }
}

