namespace Завдання_6
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
            this.numberLabels = new System.Windows.Forms.Label();
            this.createLabels = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberLabels
            // 
            this.numberLabels.AutoSize = true;
            this.numberLabels.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabels.Location = new System.Drawing.Point(342, 291);
            this.numberLabels.Name = "numberLabels";
            this.numberLabels.Size = new System.Drawing.Size(137, 21);
            this.numberLabels.TabIndex = 0;
            this.numberLabels.Text = "Номер мітки:  0";
            // 
            // createLabels
            // 
            this.createLabels.Font = new System.Drawing.Font("Goudy Stout", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLabels.Location = new System.Drawing.Point(346, 182);
            this.createLabels.Name = "createLabels";
            this.createLabels.Size = new System.Drawing.Size(138, 106);
            this.createLabels.TabIndex = 7;
            this.createLabels.Text = "Створити мітку";
            this.createLabels.UseVisualStyleBackColor = true;
            this.createLabels.Click += new System.EventHandler(this.createLabels_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createLabels);
            this.Controls.Add(this.numberLabels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberLabels;
        private System.Windows.Forms.Button createLabels;
    }
}

