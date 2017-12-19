namespace _7._21
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
            this.LastArrOut = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FirstArrOut = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChangeArrBtn = new System.Windows.Forms.Button();
            this.KInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ArrInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LastArrOut
            // 
            this.LastArrOut.AutoSize = true;
            this.LastArrOut.Location = new System.Drawing.Point(15, 162);
            this.LastArrOut.Name = "LastArrOut";
            this.LastArrOut.Size = new System.Drawing.Size(10, 13);
            this.LastArrOut.TabIndex = 19;
            this.LastArrOut.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "для последней серии";
            // 
            // FirstArrOut
            // 
            this.FirstArrOut.AutoSize = true;
            this.FirstArrOut.Location = new System.Drawing.Point(15, 126);
            this.FirstArrOut.Name = "FirstArrOut";
            this.FirstArrOut.Size = new System.Drawing.Size(10, 13);
            this.FirstArrOut.TabIndex = 17;
            this.FirstArrOut.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "для первой серии";
            // 
            // ChangeArrBtn
            // 
            this.ChangeArrBtn.Location = new System.Drawing.Point(82, 90);
            this.ChangeArrBtn.Name = "ChangeArrBtn";
            this.ChangeArrBtn.Size = new System.Drawing.Size(117, 23);
            this.ChangeArrBtn.TabIndex = 15;
            this.ChangeArrBtn.Text = "изменить массив";
            this.ChangeArrBtn.UseVisualStyleBackColor = true;
            this.ChangeArrBtn.Click += new System.EventHandler(this.ChangeArrBtn_Click);
            // 
            // KInput
            // 
            this.KInput.Location = new System.Drawing.Point(38, 64);
            this.KInput.Name = "KInput";
            this.KInput.Size = new System.Drawing.Size(234, 20);
            this.KInput.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "K =";
            // 
            // ArrInput
            // 
            this.ArrInput.Location = new System.Drawing.Point(16, 38);
            this.ArrInput.Name = "ArrInput";
            this.ArrInput.Size = new System.Drawing.Size(256, 20);
            this.ArrInput.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "введите массив";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LastArrOut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FirstArrOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChangeArrBtn);
            this.Controls.Add(this.KInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArrInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "7.21";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LastArrOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label FirstArrOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ChangeArrBtn;
        private System.Windows.Forms.TextBox KInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ArrInput;
        private System.Windows.Forms.Label label1;
    }
}

