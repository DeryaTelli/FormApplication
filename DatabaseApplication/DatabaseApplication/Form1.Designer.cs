namespace DatabaseApplication
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.phoneT = new System.Windows.Forms.MaskedTextBox();
            this.nameT = new System.Windows.Forms.TextBox();
            this.wageT = new System.Windows.Forms.TextBox();
            this.emailT = new System.Windows.Forms.TextBox();
            this.addressT = new System.Windows.Forms.TextBox();
            this.surnameT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.jobCombo = new System.Windows.Forms.ComboBox();
            this.editCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.selectPicture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(137, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(25, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(25, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Job";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(33, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(484, 51);
            this.label8.TabIndex = 0;
            this.label8.Text = "Personal Tracking System ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // phoneT
            // 
            this.phoneT.Location = new System.Drawing.Point(118, 278);
            this.phoneT.Mask = "(999) 000-0000";
            this.phoneT.Name = "phoneT";
            this.phoneT.Size = new System.Drawing.Size(100, 22);
            this.phoneT.TabIndex = 8;
            // 
            // nameT
            // 
            this.nameT.Location = new System.Drawing.Point(118, 106);
            this.nameT.Name = "nameT";
            this.nameT.Size = new System.Drawing.Size(100, 22);
            this.nameT.TabIndex = 9;
            // 
            // wageT
            // 
            this.wageT.Location = new System.Drawing.Point(118, 367);
            this.wageT.Name = "wageT";
            this.wageT.Size = new System.Drawing.Size(100, 22);
            this.wageT.TabIndex = 11;
            // 
            // emailT
            // 
            this.emailT.Location = new System.Drawing.Point(118, 237);
            this.emailT.Name = "emailT";
            this.emailT.Size = new System.Drawing.Size(100, 22);
            this.emailT.TabIndex = 12;
            // 
            // addressT
            // 
            this.addressT.Location = new System.Drawing.Point(118, 188);
            this.addressT.Name = "addressT";
            this.addressT.Size = new System.Drawing.Size(243, 22);
            this.addressT.TabIndex = 13;
            // 
            // surnameT
            // 
            this.surnameT.Location = new System.Drawing.Point(118, 143);
            this.surnameT.Name = "surnameT";
            this.surnameT.Size = new System.Drawing.Size(100, 22);
            this.surnameT.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(31, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Wage";
            // 
            // jobCombo
            // 
            this.jobCombo.FormattingEnabled = true;
            this.jobCombo.Location = new System.Drawing.Point(118, 325);
            this.jobCombo.Name = "jobCombo";
            this.jobCombo.Size = new System.Drawing.Size(121, 24);
            this.jobCombo.TabIndex = 16;
            // 
            // editCombo
            // 
            this.editCombo.FormattingEnabled = true;
            this.editCombo.Location = new System.Drawing.Point(499, 111);
            this.editCombo.Name = "editCombo";
            this.editCombo.Size = new System.Drawing.Size(121, 24);
            this.editCombo.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(626, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 30);
            this.button1.TabIndex = 18;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(626, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 42);
            this.button2.TabIndex = 19;
            this.button2.Text = "Select Picture";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSalmon;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(660, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 41);
            this.button3.TabIndex = 20;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSalmon;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(548, 388);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 41);
            this.button4.TabIndex = 21;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSalmon;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(455, 388);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 41);
            this.button5.TabIndex = 22;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // selectPicture
            // 
            this.selectPicture.Location = new System.Drawing.Point(432, 169);
            this.selectPicture.Name = "selectPicture";
            this.selectPicture.Size = new System.Drawing.Size(188, 198);
            this.selectPicture.TabIndex = 23;
            this.selectPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectPicture);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editCombo);
            this.Controls.Add(this.jobCombo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.surnameT);
            this.Controls.Add(this.addressT);
            this.Controls.Add(this.emailT);
            this.Controls.Add(this.wageT);
            this.Controls.Add(this.nameT);
            this.Controls.Add(this.phoneT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox phoneT;
        private System.Windows.Forms.TextBox nameT;
        private System.Windows.Forms.TextBox wageT;
        private System.Windows.Forms.TextBox emailT;
        private System.Windows.Forms.TextBox addressT;
        private System.Windows.Forms.TextBox surnameT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox jobCombo;
        private System.Windows.Forms.ComboBox editCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox selectPicture;
    }
}

