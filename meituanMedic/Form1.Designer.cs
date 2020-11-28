namespace meituanMedic
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoldCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoldPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1216, 47);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "抓取";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodName,
            this.SoldCount,
            this.SoldPrice,
            this.OriginalPrice,
            this.EstimatedPrice});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1196, 735);
            this.dataGridView1.TabIndex = 1;
            // 
            // FoodName
            // 
            this.FoodName.DataPropertyName = "FoodName";
            this.FoodName.HeaderText = "商品名称";
            this.FoodName.MinimumWidth = 6;
            this.FoodName.Name = "FoodName";
            this.FoodName.Width = 375;
            // 
            // SoldCount
            // 
            this.SoldCount.DataPropertyName = "SoldCount";
            this.SoldCount.HeaderText = "每月销量";
            this.SoldCount.MinimumWidth = 6;
            this.SoldCount.Name = "SoldCount";
            this.SoldCount.Width = 125;
            // 
            // SoldPrice
            // 
            this.SoldPrice.DataPropertyName = "SoldPrice";
            this.SoldPrice.HeaderText = "销售价格";
            this.SoldPrice.MinimumWidth = 6;
            this.SoldPrice.Name = "SoldPrice";
            this.SoldPrice.Width = 125;
            // 
            // OriginalPrice
            // 
            this.OriginalPrice.DataPropertyName = "OriginalPrice";
            this.OriginalPrice.HeaderText = "原始价格";
            this.OriginalPrice.MinimumWidth = 6;
            this.OriginalPrice.Name = "OriginalPrice";
            this.OriginalPrice.Width = 125;
            // 
            // EstimatedPrice
            // 
            this.EstimatedPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EstimatedPrice.DataPropertyName = "EstimatedPrice";
            this.EstimatedPrice.HeaderText = "到手价格";
            this.EstimatedPrice.MinimumWidth = 6;
            this.EstimatedPrice.Name = "EstimatedPrice";
            this.EstimatedPrice.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 754);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoldCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoldPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedPrice;
    }
}

