namespace RestaurantManagementProject
{
	partial class CategoryForm
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.cbbCateType = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCateName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(215, 84);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(56, 24);
			this.btnAdd.TabIndex = 16;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(286, 84);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(56, 24);
			this.btnCancel.TabIndex = 17;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// cbbCateType
			// 
			this.cbbCateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbCateType.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbCateType.FormattingEnabled = true;
			this.cbbCateType.Location = new System.Drawing.Point(147, 42);
			this.cbbCateType.Margin = new System.Windows.Forms.Padding(2);
			this.cbbCateType.Name = "cbbCateType";
			this.cbbCateType.Size = new System.Drawing.Size(197, 23);
			this.cbbCateType.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(11, 42);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 15);
			this.label3.TabIndex = 12;
			this.label3.Text = "Loại";
			// 
			// txtCateName
			// 
			this.txtCateName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCateName.Location = new System.Drawing.Point(147, 19);
			this.txtCateName.Margin = new System.Windows.Forms.Padding(2);
			this.txtCateName.Name = "txtCateName";
			this.txtCateName.Size = new System.Drawing.Size(197, 22);
			this.txtCateName.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(11, 19);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 15);
			this.label2.TabIndex = 13;
			this.label2.Text = "Tên nhóm thức ăn";
			// 
			// CategoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(358, 124);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.cbbCateType);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCateName);
			this.Controls.Add(this.label2);
			this.Name = "CategoryForm";
			this.Text = "CategoryForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ComboBox cbbCateType;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCateName;
		private System.Windows.Forms.Label label2;
	}
}