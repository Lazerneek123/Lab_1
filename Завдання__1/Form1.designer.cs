namespace Завдання__1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Border_Style = new System.Windows.Forms.Button();
            this.Resize = new System.Windows.Forms.Button();
            this.Opacity_ = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Border_Style
            // 
            this.Border_Style.Location = new System.Drawing.Point(12, 12);
            this.Border_Style.Name = "Border_Style";
            this.Border_Style.Size = new System.Drawing.Size(75, 23);
            this.Border_Style.TabIndex = 0;
            this.Border_Style.Text = "Border Style";
            this.Border_Style.UseVisualStyleBackColor = true;
            this.Border_Style.Click += new System.EventHandler(this.Border_Style_Click);
            // 
            // Resize
            // 
            this.Resize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resize.Location = new System.Drawing.Point(713, 12);
            this.Resize.Name = "Resize";
            this.Resize.Size = new System.Drawing.Size(75, 23);
            this.Resize.TabIndex = 1;
            this.Resize.Text = "Resize ";
            this.Resize.UseVisualStyleBackColor = true;
            this.Resize.Click += new System.EventHandler(this.Resize_Click);
            // 
            // Opacity_
            // 
            this.Opacity_.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Opacity_.Location = new System.Drawing.Point(370, 415);
            this.Opacity_.Name = "Opacity_";
            this.Opacity_.Size = new System.Drawing.Size(75, 23);
            this.Opacity_.TabIndex = 2;
            this.Opacity_.Text = "Opacity";
            this.Opacity_.UseVisualStyleBackColor = true;
            this.Opacity_.Click += new System.EventHandler(this.Opacity__Click);
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(744, 426);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(48, 15);
            this.name.TabIndex = 3;
            this.name.Text = "by Teo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Opacity_);
            this.Controls.Add(this.Resize);
            this.Controls.Add(this.Border_Style);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "Form1";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Trey Research";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Border_Style;
        private System.Windows.Forms.Button Resize;
        private System.Windows.Forms.Button Opacity_;
        private System.Windows.Forms.Label name;
    }
}

