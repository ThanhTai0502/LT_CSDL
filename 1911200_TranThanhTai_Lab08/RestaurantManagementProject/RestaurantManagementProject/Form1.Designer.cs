namespace RestaurantManagementProject
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.dgvFoodList = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmCalculateQuantity = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmAddFood = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmUpdateFood = new System.Windows.Forms.ToolStripMenuItem();
			this.cbbCategory = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.billToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtSearchByName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lblCatName = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvFoodList
			// 
			this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFoodList.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvFoodList.Location = new System.Drawing.Point(0, 64);
			this.dgvFoodList.MultiSelect = false;
			this.dgvFoodList.Name = "dgvFoodList";
			this.dgvFoodList.Size = new System.Drawing.Size(691, 307);
			this.dgvFoodList.TabIndex = 12;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCalculateQuantity,
            this.tsmAddFood,
            this.tsmUpdateFood});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(214, 70);
			// 
			// tsmCalculateQuantity
			// 
			this.tsmCalculateQuantity.Name = "tsmCalculateQuantity";
			this.tsmCalculateQuantity.Size = new System.Drawing.Size(213, 22);
			this.tsmCalculateQuantity.Text = "Tính tổng số lượng đã bán";
			// 
			// tsmAddFood
			// 
			this.tsmAddFood.Name = "tsmAddFood";
			this.tsmAddFood.Size = new System.Drawing.Size(213, 22);
			this.tsmAddFood.Text = "Thêm món ăn";
			this.tsmAddFood.Click += new System.EventHandler(this.tsmAddFood_Click);
			// 
			// tsmUpdateFood
			// 
			this.tsmUpdateFood.Name = "tsmUpdateFood";
			this.tsmUpdateFood.Size = new System.Drawing.Size(213, 22);
			this.tsmUpdateFood.Text = "Cập nhật món ăn";
			this.tsmUpdateFood.Click += new System.EventHandler(this.tsmUpdateFood_Click);
			// 
			// cbbCategory
			// 
			this.cbbCategory.FormattingEnabled = true;
			this.cbbCategory.Location = new System.Drawing.Point(149, 37);
			this.cbbCategory.Name = "cbbCategory";
			this.cbbCategory.Size = new System.Drawing.Size(178, 21);
			this.cbbCategory.TabIndex = 11;
			this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(18, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 15);
			this.label1.TabIndex = 10;
			this.label1.Text = "Chọn nhóm món ăn:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billToolStripMenuItem,
            this.accountToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(688, 24);
			this.menuStrip1.TabIndex = 19;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// billToolStripMenuItem
			// 
			this.billToolStripMenuItem.Name = "billToolStripMenuItem";
			this.billToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.billToolStripMenuItem.Text = "Bill";
			this.billToolStripMenuItem.Click += new System.EventHandler(this.billToolStripMenuItem_Click);
			// 
			// accountToolStripMenuItem
			// 
			this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
			this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.accountToolStripMenuItem.Text = "Account";
			this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
			// 
			// txtSearchByName
			// 
			this.txtSearchByName.Location = new System.Drawing.Point(475, 37);
			this.txtSearchByName.Name = "txtSearchByName";
			this.txtSearchByName.Size = new System.Drawing.Size(178, 20);
			this.txtSearchByName.TabIndex = 18;
			this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(352, 39);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 15);
			this.label4.TabIndex = 17;
			this.label4.Text = "Tìm kiếm theo tên:";
			// 
			// lblCatName
			// 
			this.lblCatName.AutoSize = true;
			this.lblCatName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCatName.Location = new System.Drawing.Point(243, 389);
			this.lblCatName.Name = "lblCatName";
			this.lblCatName.Size = new System.Drawing.Size(16, 15);
			this.lblCatName.TabIndex = 16;
			this.lblCatName.Text = "...";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(114, 388);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 15);
			this.label3.TabIndex = 15;
			this.label3.Text = "món ăn thuộc nhóm";
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQuantity.Location = new System.Drawing.Point(81, 388);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(16, 15);
			this.lblQuantity.TabIndex = 14;
			this.lblQuantity.Text = "...";
			this.lblQuantity.Click += new System.EventHandler(this.lblQuantity_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(18, 388);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 15);
			this.label2.TabIndex = 13;
			this.label2.Text = "Có tất cả";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(688, 406);
			this.Controls.Add(this.dgvFoodList);
			this.Controls.Add(this.cbbCategory);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.txtSearchByName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblCatName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblQuantity);
			this.Controls.Add(this.label2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvFoodList;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmCalculateQuantity;
		private System.Windows.Forms.ToolStripMenuItem tsmAddFood;
		private System.Windows.Forms.ToolStripMenuItem tsmUpdateFood;
		private System.Windows.Forms.ComboBox cbbCategory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem billToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
		private System.Windows.Forms.TextBox txtSearchByName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblCatName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblQuantity;
		private System.Windows.Forms.Label label2;
	}
}

