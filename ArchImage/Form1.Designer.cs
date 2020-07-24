namespace ArchImage
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
            this.folderButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.size_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plusbutton = new System.Windows.Forms.Button();
            this.minusbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // folderButton
            // 
            this.folderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.folderButton.Location = new System.Drawing.Point(12, 526);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(110, 23);
            this.folderButton.TabIndex = 0;
            this.folderButton.Text = "Выбрать папку";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 450);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // leftButton
            // 
            this.leftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.leftButton.Location = new System.Drawing.Point(12, 468);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(31, 23);
            this.leftButton.TabIndex = 2;
            this.leftButton.Text = "<";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rightButton.Location = new System.Drawing.Point(49, 468);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(31, 23);
            this.rightButton.TabIndex = 3;
            this.rightButton.Text = ">";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // size_textBox
            // 
            this.size_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.size_textBox.Location = new System.Drawing.Point(362, 526);
            this.size_textBox.Name = "size_textBox";
            this.size_textBox.Size = new System.Drawing.Size(100, 20);
            this.size_textBox.TabIndex = 4;
            this.size_textBox.Text = "10";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Целевой размер, см";
            // 
            // plusbutton
            // 
            this.plusbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.plusbutton.Location = new System.Drawing.Point(137, 526);
            this.plusbutton.Name = "plusbutton";
            this.plusbutton.Size = new System.Drawing.Size(23, 23);
            this.plusbutton.TabIndex = 6;
            this.plusbutton.Text = "+";
            this.plusbutton.UseVisualStyleBackColor = true;
            this.plusbutton.Click += new System.EventHandler(this.plusbutton_Click);
            // 
            // minusbutton
            // 
            this.minusbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.minusbutton.Location = new System.Drawing.Point(166, 526);
            this.minusbutton.Name = "minusbutton";
            this.minusbutton.Size = new System.Drawing.Size(23, 23);
            this.minusbutton.TabIndex = 7;
            this.minusbutton.Text = "-";
            this.minusbutton.UseVisualStyleBackColor = true;
            this.minusbutton.Click += new System.EventHandler(this.minusbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.minusbutton);
            this.Controls.Add(this.plusbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.size_textBox);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.folderButton);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.TextBox size_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plusbutton;
        private System.Windows.Forms.Button minusbutton;
    }
}

