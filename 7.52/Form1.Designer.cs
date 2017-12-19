namespace _7._52
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ArrOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.ArrInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ArrOutput
            // 
            this.ArrOutput.AutoSize = true;
            this.ArrOutput.Location = new System.Drawing.Point(12, 121);
            this.ArrOutput.Name = "ArrOutput";
            this.ArrOutput.Size = new System.Drawing.Size(10, 13);
            this.ArrOutput.TabIndex = 11;
            this.ArrOutput.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "найденная подпоследовательность:";
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(86, 54);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(150, 41);
            this.CalcBtn.TabIndex = 9;
            this.CalcBtn.Text = "найти максимальное чередование";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // ArrInput
            // 
            this.ArrInput.Location = new System.Drawing.Point(8, 28);
            this.ArrInput.Name = "ArrInput";
            this.ArrInput.Size = new System.Drawing.Size(314, 20);
            this.ArrInput.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "введите массив";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 261);
            this.Controls.Add(this.ArrOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.ArrInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "7.52";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ArrOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.TextBox ArrInput;
        private System.Windows.Forms.Label label1;
    }
}

