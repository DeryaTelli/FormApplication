namespace FormApplication2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.writeButton = new System.Windows.Forms.Button();
            this.ComboListButton = new System.Windows.Forms.Button();
            this.deleteComboButton = new System.Windows.Forms.Button();
            this.writeComboButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(97, 187);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(226, 23);
            this.writeButton.TabIndex = 0;
            this.writeButton.Text = "Write ListBox";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // ComboListButton
            // 
            this.ComboListButton.Location = new System.Drawing.Point(97, 358);
            this.ComboListButton.Name = "ComboListButton";
            this.ComboListButton.Size = new System.Drawing.Size(226, 23);
            this.ComboListButton.TabIndex = 1;
            this.ComboListButton.Text = "ComboBox to ListBox";
            this.ComboListButton.UseVisualStyleBackColor = true;
            this.ComboListButton.Click += new System.EventHandler(this.ComboListButton_Click);
            // 
            // deleteComboButton
            // 
            this.deleteComboButton.Location = new System.Drawing.Point(97, 317);
            this.deleteComboButton.Name = "deleteComboButton";
            this.deleteComboButton.Size = new System.Drawing.Size(226, 23);
            this.deleteComboButton.TabIndex = 2;
            this.deleteComboButton.Text = "Delete ComboBox";
            this.deleteComboButton.UseVisualStyleBackColor = true;
            this.deleteComboButton.Click += new System.EventHandler(this.deleteComboButton_Click);
            // 
            // writeComboButton
            // 
            this.writeComboButton.Location = new System.Drawing.Point(97, 274);
            this.writeComboButton.Name = "writeComboButton";
            this.writeComboButton.Size = new System.Drawing.Size(226, 23);
            this.writeComboButton.TabIndex = 3;
            this.writeComboButton.Text = "Write ComboBox";
            this.writeComboButton.UseVisualStyleBackColor = true;
            this.writeComboButton.Click += new System.EventHandler(this.writeComboButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(97, 230);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(226, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete ListBox";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 22);
            this.textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "TextBox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "ComboBox";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(426, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(314, 228);
            this.listBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "ListBox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.writeComboButton);
            this.Controls.Add(this.deleteComboButton);
            this.Controls.Add(this.ComboListButton);
            this.Controls.Add(this.writeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Button ComboListButton;
        private System.Windows.Forms.Button deleteComboButton;
        private System.Windows.Forms.Button writeComboButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
    }
}

