namespace Program
{
    partial class MyForm
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
            this.buttonCircleMove = new System.Windows.Forms.Button();
            this.buttonSquareMove = new System.Windows.Forms.Button();
            this.buttonRhombMove = new System.Windows.Forms.Button();
            
            this.SuspendLayout();
            // 
            // buttonCircleMove
            // 
            this.buttonCircleMove.Location = new System.Drawing.Point(10, 20);
            this.buttonCircleMove.Name = "buttonCircleMove";
            this.buttonCircleMove.Size = new System.Drawing.Size(95, 23);
            this.buttonCircleMove.TabIndex = 0;
            this.buttonCircleMove.Text = "Circle";
            this.buttonCircleMove.UseVisualStyleBackColor = true;
            this.buttonCircleMove.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonSquareMove
            // 
            this.buttonSquareMove.Location = new System.Drawing.Point(110, 20);
            this.buttonSquareMove.Name = "buttonSquareMove";
            this.buttonSquareMove.Size = new System.Drawing.Size(95, 23);
            this.buttonSquareMove.TabIndex = 1;
            this.buttonSquareMove.Text = "Square";
            this.buttonSquareMove.UseVisualStyleBackColor = true;
            this.buttonSquareMove.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // buttonRhombMove
            // 
            this.buttonRhombMove.Location = new System.Drawing.Point(210, 20);
            this.buttonRhombMove.Name = "buttonRhombMove";
            this.buttonRhombMove.Size = new System.Drawing.Size(95, 23);
            this.buttonRhombMove.TabIndex = 2;
            this.buttonRhombMove.Text = "Rhomb";
            this.buttonRhombMove.UseVisualStyleBackColor = true;
            this.buttonRhombMove.Click += new System.EventHandler(this.buttonRhomb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 315);
            this.Controls.Add(this.buttonCircleMove);
            this.Controls.Add(this.buttonSquareMove);
            this.Controls.Add(this.buttonRhombMove);
            this.Name = "MyForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }
        
        #endregion

        private System.Windows.Forms.Button buttonCircleMove;
        private System.Windows.Forms.Button buttonSquareMove;
        private System.Windows.Forms.Button buttonRhombMove;
    }
}