namespace RestaurantManagementProject
{
	partial class BillForm
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
			this.lblSum = new System.Windows.Forms.Label();
			this.dgvBills = new System.Windows.Forms.DataGridView();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnFind = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
			this.SuspendLayout();
			// 
			// lblSum
			// 
			this.lblSum.AutoSize = true;
			this.lblSum.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSum.Location = new System.Drawing.Point(108, 405);
			this.lblSum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSum.Name = "lblSum";
			this.lblSum.Size = new System.Drawing.Size(16, 15);
			this.lblSum.TabIndex = 13;
			this.lblSum.Text = "...";
			// 
			// dgvBills
			// 
			this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBills.Location = new System.Drawing.Point(11, 51);
			this.dgvBills.Margin = new System.Windows.Forms.Padding(2);
			this.dgvBills.Name = "dgvBills";
			this.dgvBills.RowHeadersWidth = 51;
			this.dgvBills.RowTemplate.Height = 24;
			this.dgvBills.Size = new System.Drawing.Size(838, 348);
			this.dgvBills.TabIndex = 12;
			// 
			// dtpDate
			// 
			this.dtpDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDate.Location = new System.Drawing.Point(111, 25);
			this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(84, 22);
			this.dtpDate.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 25);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 17);
			this.label2.TabIndex = 9;
			this.label2.Text = "Chọn ngày";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(10, 405);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 17);
			this.label1.TabIndex = 10;
			this.label1.Text = "Doanh thu";
			// 
			// btnFind
			// 
			this.btnFind.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFind.Location = new System.Drawing.Point(242, 25);
			this.btnFind.Margin = new System.Windows.Forms.Padding(2);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(65, 24);
			this.btnFind.TabIndex = 14;
			this.btnFind.Text = "Tìm";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// BillForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(860, 435);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.lblSum);
			this.Controls.Add(this.dgvBills);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "BillForm";
			this.Text = "BillForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblSum;
		private System.Windows.Forms.DataGridView dgvBills;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnFind;
	}
}