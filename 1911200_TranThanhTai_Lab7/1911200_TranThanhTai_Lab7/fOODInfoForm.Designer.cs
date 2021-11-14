
namespace _1911200_TranThanhTai_Lab7
{
	partial class fOODInfoForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtFoodID = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtUnit = new System.Windows.Forms.TextBox();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.cbbCatName = new System.Windows.Forms.ComboBox();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.nudPrice = new System.Windows.Forms.NumericUpDown();
			this.btnAddFood = new System.Windows.Forms.Button();
			this.btnUpdateFood = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "FoodID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 237);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Price";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 294);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Notes";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 134);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Unit";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 183);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(102, 17);
			this.label6.TabIndex = 5;
			this.label6.Text = "CategoryName";
			// 
			// txtFoodID
			// 
			this.txtFoodID.Location = new System.Drawing.Point(137, 37);
			this.txtFoodID.Multiline = true;
			this.txtFoodID.Name = "txtFoodID";
			this.txtFoodID.ReadOnly = true;
			this.txtFoodID.Size = new System.Drawing.Size(206, 25);
			this.txtFoodID.TabIndex = 6;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(137, 80);
			this.txtName.Multiline = true;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(505, 25);
			this.txtName.TabIndex = 7;
			// 
			// txtUnit
			// 
			this.txtUnit.Location = new System.Drawing.Point(137, 131);
			this.txtUnit.Multiline = true;
			this.txtUnit.Name = "txtUnit";
			this.txtUnit.Size = new System.Drawing.Size(505, 25);
			this.txtUnit.TabIndex = 8;
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(137, 286);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(505, 25);
			this.txtNotes.TabIndex = 10;
			// 
			// cbbCatName
			// 
			this.cbbCatName.FormattingEnabled = true;
			this.cbbCatName.Location = new System.Drawing.Point(137, 176);
			this.cbbCatName.Name = "cbbCatName";
			this.cbbCatName.Size = new System.Drawing.Size(400, 24);
			this.cbbCatName.TabIndex = 11;
			// 
			// btnAddNew
			// 
			this.btnAddNew.Location = new System.Drawing.Point(543, 177);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(99, 23);
			this.btnAddNew.TabIndex = 12;
			this.btnAddNew.Text = "Add New";
			this.btnAddNew.UseVisualStyleBackColor = true;
			// 
			// nudPrice
			// 
			this.nudPrice.Location = new System.Drawing.Point(137, 237);
			this.nudPrice.Name = "nudPrice";
			this.nudPrice.Size = new System.Drawing.Size(505, 22);
			this.nudPrice.TabIndex = 13;
			// 
			// btnAddFood
			// 
			this.btnAddFood.Location = new System.Drawing.Point(278, 336);
			this.btnAddFood.Name = "btnAddFood";
			this.btnAddFood.Size = new System.Drawing.Size(82, 27);
			this.btnAddFood.TabIndex = 14;
			this.btnAddFood.Text = "Add";
			this.btnAddFood.UseVisualStyleBackColor = true;
			this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
			// 
			// btnUpdateFood
			// 
			this.btnUpdateFood.Location = new System.Drawing.Point(381, 336);
			this.btnUpdateFood.Name = "btnUpdateFood";
			this.btnUpdateFood.Size = new System.Drawing.Size(91, 27);
			this.btnUpdateFood.TabIndex = 15;
			this.btnUpdateFood.Text = "Update";
			this.btnUpdateFood.UseVisualStyleBackColor = true;
			this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(493, 336);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(91, 27);
			this.btnCancel.TabIndex = 16;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// fOODInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(657, 401);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnUpdateFood);
			this.Controls.Add(this.btnAddFood);
			this.Controls.Add(this.nudPrice);
			this.Controls.Add(this.btnAddNew);
			this.Controls.Add(this.cbbCatName);
			this.Controls.Add(this.txtNotes);
			this.Controls.Add(this.txtUnit);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtFoodID);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "fOODInfoForm";
			this.Text = "FoodInfoForm";
			this.Load += new System.EventHandler(this.fOODInfoForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtFoodID;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtUnit;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.ComboBox cbbCatName;
		private System.Windows.Forms.Button btnAddNew;
		private System.Windows.Forms.NumericUpDown nudPrice;
		private System.Windows.Forms.Button btnAddFood;
		private System.Windows.Forms.Button btnUpdateFood;
		private System.Windows.Forms.Button btnCancel;
	}
}