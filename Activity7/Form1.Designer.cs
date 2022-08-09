namespace Activity7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.piCalculator = new System.Windows.Forms.Button();
            this.valueDisplay = new System.Windows.Forms.Label();
            this.userInputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // piCalculator
            // 
            this.piCalculator.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.piCalculator.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.piCalculator.Location = new System.Drawing.Point(85, 233);
            this.piCalculator.Name = "piCalculator";
            this.piCalculator.Size = new System.Drawing.Size(219, 69);
            this.piCalculator.TabIndex = 0;
            this.piCalculator.Text = "CALCULATE";
            this.piCalculator.UseVisualStyleBackColor = false;
            this.piCalculator.Click += new System.EventHandler(this.button1_Click);
            // 
            // valueDisplay
            // 
            this.valueDisplay.AutoSize = true;
            this.valueDisplay.Location = new System.Drawing.Point(44, 374);
            this.valueDisplay.Name = "valueDisplay";
            this.valueDisplay.Size = new System.Drawing.Size(366, 32);
            this.valueDisplay.TabIndex = 1;
            this.valueDisplay.Text = "Your result will be displayed here";
            // 
            // userInputBox
            // 
            this.userInputBox.Location = new System.Drawing.Point(296, 119);
            this.userInputBox.Name = "userInputBox";
            this.userInputBox.Size = new System.Drawing.Size(200, 39);
            this.userInputBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter # of terms:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(298, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pi Calcualtor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userInputBox);
            this.Controls.Add(this.valueDisplay);
            this.Controls.Add(this.piCalculator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " Approximate PI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button piCalculator;
        private Label valueDisplay;
        private TextBox userInputBox;
        private Label label1;
        private Label label2;
    }
}