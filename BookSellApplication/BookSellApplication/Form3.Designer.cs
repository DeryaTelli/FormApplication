namespace BookSellApplication
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuCircleProgress3 = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuCircleProgress2 = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.bunifuCircleProgress1 = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelEarn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.BackgroundImage = global::BookSellApplication.Properties.Resources.Purple_Modern_Futuristic_Technology_Presentation__2_;
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.bunifuCircleProgress3);
            this.panel5.Controls.Add(this.btnSearch);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Location = new System.Drawing.Point(316, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(357, 390);
            this.panel5.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookName,
            this.bookQuantity});
            this.dataGridView1.Location = new System.Drawing.Point(28, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(292, 202);
            this.dataGridView1.TabIndex = 18;
            // 
            // bookName
            // 
            this.bookName.HeaderText = "Book Name";
            this.bookName.MinimumWidth = 6;
            this.bookName.Name = "bookName";
            this.bookName.Width = 125;
            // 
            // bookQuantity
            // 
            this.bookQuantity.HeaderText = "Book Quantity";
            this.bookQuantity.MinimumWidth = 4;
            this.bookQuantity.Name = "bookQuantity";
            this.bookQuantity.Width = 125;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 65);
            this.label8.TabIndex = 17;
            this.label8.Text = "Book Titles and Quantities Sold Today";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCircleProgress3
            // 
            this.bunifuCircleProgress3.Animated = false;
            this.bunifuCircleProgress3.AnimationInterval = 1;
            this.bunifuCircleProgress3.AnimationSpeed = 1;
            this.bunifuCircleProgress3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgress3.CircleMargin = 10;
            this.bunifuCircleProgress3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.bunifuCircleProgress3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCircleProgress3.IsPercentage = false;
            this.bunifuCircleProgress3.LineProgressThickness = 10;
            this.bunifuCircleProgress3.LineThickness = 10;
            this.bunifuCircleProgress3.Location = new System.Drawing.Point(68, 72);
            this.bunifuCircleProgress3.Name = "bunifuCircleProgress3";
            this.bunifuCircleProgress3.ProgressAnimationSpeed = 200;
            this.bunifuCircleProgress3.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgress3.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCircleProgress3.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.bunifuCircleProgress3.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress3.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.bunifuCircleProgress3.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress3.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bunifuCircleProgress3.Size = new System.Drawing.Size(8, 8);
            this.bunifuCircleProgress3.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress3.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.bunifuCircleProgress3.SubScriptText = ".00";
            this.bunifuCircleProgress3.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress3.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.bunifuCircleProgress3.SuperScriptText = "°C";
            this.bunifuCircleProgress3.TabIndex = 16;
            this.bunifuCircleProgress3.Text = "30";
            this.bunifuCircleProgress3.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bunifuCircleProgress3.Value = 30;
            this.bunifuCircleProgress3.ValueByTransition = 30;
            this.bunifuCircleProgress3.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.ForeColor = System.Drawing.Color.DimGray;
            this.btnSearch.Image = global::BookSellApplication.Properties.Resources.search_7712341;
            this.btnSearch.Location = new System.Drawing.Point(296, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 30);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.LightBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(30, 104);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 30);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Search book name...";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.BackgroundImage = global::BookSellApplication.Properties.Resources.Purple_Modern_Futuristic_Technology_Presentation__2_;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.bunifuCircleProgress2);
            this.panel4.Controls.Add(this.bunifuCircleProgress1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(21, 187);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 257);
            this.panel4.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(44, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 35);
            this.label7.TabIndex = 13;
            this.label7.Text = "Book Sales Rate of the Last 28 Days ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCircleProgress2
            // 
            this.bunifuCircleProgress2.Animated = false;
            this.bunifuCircleProgress2.AnimationInterval = 1;
            this.bunifuCircleProgress2.AnimationSpeed = 1;
            this.bunifuCircleProgress2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgress2.CircleMargin = 10;
            this.bunifuCircleProgress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.bunifuCircleProgress2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCircleProgress2.IsPercentage = false;
            this.bunifuCircleProgress2.LineProgressThickness = 10;
            this.bunifuCircleProgress2.LineThickness = 10;
            this.bunifuCircleProgress2.Location = new System.Drawing.Point(68, 72);
            this.bunifuCircleProgress2.Name = "bunifuCircleProgress2";
            this.bunifuCircleProgress2.ProgressAnimationSpeed = 200;
            this.bunifuCircleProgress2.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgress2.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCircleProgress2.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.bunifuCircleProgress2.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress2.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.bunifuCircleProgress2.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bunifuCircleProgress2.Size = new System.Drawing.Size(8, 8);
            this.bunifuCircleProgress2.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress2.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.bunifuCircleProgress2.SubScriptText = ".00";
            this.bunifuCircleProgress2.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress2.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.bunifuCircleProgress2.SuperScriptText = "°C";
            this.bunifuCircleProgress2.TabIndex = 16;
            this.bunifuCircleProgress2.Text = "30";
            this.bunifuCircleProgress2.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bunifuCircleProgress2.Value = 30;
            this.bunifuCircleProgress2.ValueByTransition = 30;
            this.bunifuCircleProgress2.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // bunifuCircleProgress1
            // 
            this.bunifuCircleProgress1.Animated = false;
            this.bunifuCircleProgress1.AnimationInterval = 1;
            this.bunifuCircleProgress1.AnimationSpeed = 1;
            this.bunifuCircleProgress1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgress1.CircleMargin = 10;
            this.bunifuCircleProgress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCircleProgress1.ForeColor = System.Drawing.Color.Wheat;
            this.bunifuCircleProgress1.IsPercentage = false;
            this.bunifuCircleProgress1.LineProgressThickness = 10;
            this.bunifuCircleProgress1.LineThickness = 10;
            this.bunifuCircleProgress1.Location = new System.Drawing.Point(51, 60);
            this.bunifuCircleProgress1.Name = "bunifuCircleProgress1";
            this.bunifuCircleProgress1.ProgressAnimationSpeed = 200;
            this.bunifuCircleProgress1.ProgressBackColor = System.Drawing.Color.BurlyWood;
            this.bunifuCircleProgress1.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCircleProgress1.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.bunifuCircleProgress1.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress1.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.bunifuCircleProgress1.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bunifuCircleProgress1.Size = new System.Drawing.Size(150, 150);
            this.bunifuCircleProgress1.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress1.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.bunifuCircleProgress1.SubScriptText = "";
            this.bunifuCircleProgress1.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress1.SuperScriptMargin = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.bunifuCircleProgress1.SuperScriptText = "";
            this.bunifuCircleProgress1.TabIndex = 16;
            this.bunifuCircleProgress1.Text = "30";
            this.bunifuCircleProgress1.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bunifuCircleProgress1.Value = 30;
            this.bunifuCircleProgress1.ValueByTransition = 30;
            this.bunifuCircleProgress1.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "Book Sale Rates";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.BackgroundImage = global::BookSellApplication.Properties.Resources.Purple_Modern_Futuristic_Technology_Presentation__2_;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.labelEarn);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(21, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 115);
            this.panel3.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BookSellApplication.Properties.Resources.rb_2147630138;
            this.pictureBox2.Location = new System.Drawing.Point(152, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(15, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Details of Last 28 Days";
            // 
            // labelEarn
            // 
            this.labelEarn.AutoSize = true;
            this.labelEarn.BackColor = System.Drawing.Color.Transparent;
            this.labelEarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEarn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelEarn.Location = new System.Drawing.Point(5, 43);
            this.labelEarn.Name = "labelEarn";
            this.labelEarn.Size = new System.Drawing.Size(117, 39);
            this.labelEarn.TabIndex = 1;
            this.labelEarn.Text = "1234$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Earnings";
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Image = global::BookSellApplication.Properties.Resources.home_9449212__1_;
            this.button4.Location = new System.Drawing.Point(57, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(0, 0);
            this.button4.TabIndex = 14;
            this.button4.Text = "Dashboard";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(15, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 36);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Dashboard";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookSellApplication.Properties.Resources.Screenshot_2024_12_02_134147;
            this.ClientSize = new System.Drawing.Size(683, 447);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookQuantity;
        private System.Windows.Forms.Label label8;
        private Bunifu.UI.WinForms.BunifuCircleProgress bunifuCircleProgress3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuCircleProgress bunifuCircleProgress2;
        private Bunifu.UI.WinForms.BunifuCircleProgress bunifuCircleProgress1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelEarn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblTitle;
    }
}