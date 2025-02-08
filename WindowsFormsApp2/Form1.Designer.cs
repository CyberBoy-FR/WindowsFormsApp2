namespace WindowsFormsApp2
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
            this.showTextButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showTextButton
            // 
            this.showTextButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showTextButton.Font = new System.Drawing.Font("Impact", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showTextButton.ForeColor = System.Drawing.SystemColors.Control;
            this.showTextButton.Location = new System.Drawing.Point(523, 248);
            this.showTextButton.Name = "showTextButton";
            this.showTextButton.Size = new System.Drawing.Size(211, 61);
            this.showTextButton.TabIndex = 0;
            this.showTextButton.Text = "КУПИТЬ!\r\n\r\n";
            this.showTextButton.UseVisualStyleBackColor = false;
            this.showTextButton.Click += new System.EventHandler(this.showTextButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resultLabel.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.resultLabel.Location = new System.Drawing.Point(558, 302);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 54);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(554, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 42);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.resultLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.IkINJtCoDkA__1_;
            this.ClientSize = new System.Drawing.Size(1166, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.showTextButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showTextButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label1;
    }
}

