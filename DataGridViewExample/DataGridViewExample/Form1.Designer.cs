namespace DataGridViewExample
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showRecordBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.nameColumn,
            this.surnameColumn,
            this.mailColumn,
            this.positionColumn});
            this.dataGridView1.Location = new System.Drawing.Point(22, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // columnId
            // 
            this.columnId.HeaderText = "Id";
            this.columnId.MinimumWidth = 6;
            this.columnId.Name = "columnId";
            this.columnId.Width = 125;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Width = 125;
            // 
            // surnameColumn
            // 
            this.surnameColumn.HeaderText = "Surname";
            this.surnameColumn.MinimumWidth = 6;
            this.surnameColumn.Name = "surnameColumn";
            this.surnameColumn.Width = 125;
            // 
            // mailColumn
            // 
            this.mailColumn.HeaderText = "Mail";
            this.mailColumn.MinimumWidth = 6;
            this.mailColumn.Name = "mailColumn";
            this.mailColumn.Width = 125;
            // 
            // positionColumn
            // 
            this.positionColumn.HeaderText = "Position ";
            this.positionColumn.MinimumWidth = 6;
            this.positionColumn.Name = "positionColumn";
            this.positionColumn.Width = 125;
            // 
            // showRecordBtn
            // 
            this.showRecordBtn.Location = new System.Drawing.Point(22, 216);
            this.showRecordBtn.Name = "showRecordBtn";
            this.showRecordBtn.Size = new System.Drawing.Size(184, 44);
            this.showRecordBtn.TabIndex = 1;
            this.showRecordBtn.Text = "Show Record";
            this.showRecordBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 179);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(441, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 204);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showRecordBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionColumn;
        private System.Windows.Forms.Button showRecordBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

