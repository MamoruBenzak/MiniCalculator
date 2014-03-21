namespace Калькулятор
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addition = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.firstArgument = new System.Windows.Forms.TextBox();
            this.twoArgument = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(153, 115);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(119, 64);
            this.addition.TabIndex = 0;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(12, 115);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(119, 64);
            this.division.TabIndex = 1;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(12, 185);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(119, 65);
            this.multiplication.TabIndex = 2;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // subtraction
            // 
            this.subtraction.Location = new System.Drawing.Point(153, 185);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(119, 65);
            this.subtraction.TabIndex = 3;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // firstArgument
            // 
            this.firstArgument.Location = new System.Drawing.Point(28, 13);
            this.firstArgument.Name = "firstArgument";
            this.firstArgument.Size = new System.Drawing.Size(233, 20);
            this.firstArgument.TabIndex = 4;
            // 
            // twoArgument
            // 
            this.twoArgument.Location = new System.Drawing.Point(28, 39);
            this.twoArgument.Name = "twoArgument";
            this.twoArgument.Size = new System.Drawing.Size(233, 20);
            this.twoArgument.TabIndex = 5;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(28, 66);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(233, 20);
            this.result.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 267);
            this.Controls.Add(this.result);
            this.Controls.Add(this.twoArgument);
            this.Controls.Add(this.firstArgument);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.division);
            this.Controls.Add(this.addition);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.TextBox firstArgument;
        private System.Windows.Forms.TextBox twoArgument;
        private System.Windows.Forms.TextBox result;
    }
}

