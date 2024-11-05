namespace QuizQuestion2
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
            this.label1 = new System.Windows.Forms.Label();
            this.numberText = new System.Windows.Forms.TextBox();
            this.squareRadio = new System.Windows.Forms.RadioButton();
            this.cupeRadio = new System.Windows.Forms.RadioButton();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            // 
            // numberText
            // 
            this.numberText.Location = new System.Drawing.Point(218, 113);
            this.numberText.Name = "numberText";
            this.numberText.Size = new System.Drawing.Size(100, 22);
            this.numberText.TabIndex = 1;
            // 
            // squareRadio
            // 
            this.squareRadio.AutoSize = true;
            this.squareRadio.Location = new System.Drawing.Point(123, 221);
            this.squareRadio.Name = "squareRadio";
            this.squareRadio.Size = new System.Drawing.Size(72, 20);
            this.squareRadio.TabIndex = 2;
            this.squareRadio.TabStop = true;
            this.squareRadio.Text = "Square";
            this.squareRadio.UseVisualStyleBackColor = true;
            // 
            // cupeRadio
            // 
            this.cupeRadio.AutoSize = true;
            this.cupeRadio.Location = new System.Drawing.Point(292, 221);
            this.cupeRadio.Name = "cupeRadio";
            this.cupeRadio.Size = new System.Drawing.Size(60, 20);
            this.cupeRadio.TabIndex = 3;
            this.cupeRadio.TabStop = true;
            this.cupeRadio.Text = "Cupe";
            this.cupeRadio.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(123, 287);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(110, 63);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(394, 310);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(14, 16);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.cupeRadio);
            this.Controls.Add(this.squareRadio);
            this.Controls.Add(this.numberText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberText;
        private System.Windows.Forms.RadioButton squareRadio;
        private System.Windows.Forms.RadioButton cupeRadio;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label3;
    }
}

