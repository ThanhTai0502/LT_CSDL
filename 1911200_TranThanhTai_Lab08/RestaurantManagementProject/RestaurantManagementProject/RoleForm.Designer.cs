namespace RestaurantManagementProject
{
	partial class RoleForm
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
			this.txtRoleName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRoleID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lvRole = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.txtAccountName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtRoleName
			// 
			this.txtRoleName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRoleName.Location = new System.Drawing.Point(105, 65);
			this.txtRoleName.Name = "txtRoleName";
			this.txtRoleName.Size = new System.Drawing.Size(231, 21);
			this.txtRoleName.TabIndex = 95;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 15);
			this.label4.TabIndex = 94;
			this.label4.Text = "Tên vai trò:";
			// 
			// txtRoleID
			// 
			this.txtRoleID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRoleID.Location = new System.Drawing.Point(105, 38);
			this.txtRoleID.Name = "txtRoleID";
			this.txtRoleID.ReadOnly = true;
			this.txtRoleID.Size = new System.Drawing.Size(231, 21);
			this.txtRoleID.TabIndex = 93;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 15);
			this.label3.TabIndex = 92;
			this.label3.Text = "Mã vai trò:";
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(423, 63);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(90, 23);
			this.btnCancel.TabIndex = 91;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(423, 34);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(90, 23);
			this.btnUpdate.TabIndex = 90;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(423, 5);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(90, 23);
			this.btnAdd.TabIndex = 89;
			this.btnAdd.Text = "Add new";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// lvRole
			// 
			this.lvRole.CheckBoxes = true;
			this.lvRole.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.lvRole.FullRowSelect = true;
			this.lvRole.GridLines = true;
			this.lvRole.HideSelection = false;
			this.lvRole.Location = new System.Drawing.Point(11, 107);
			this.lvRole.Margin = new System.Windows.Forms.Padding(2);
			this.lvRole.Name = "lvRole";
			this.lvRole.Size = new System.Drawing.Size(503, 219);
			this.lvRole.TabIndex = 88;
			this.lvRole.UseCompatibleStateImageBehavior = false;
			this.lvRole.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ID";
			this.columnHeader1.Width = 67;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Vai trò";
			this.columnHeader2.Width = 591;
			// 
			// txtAccountName
			// 
			this.txtAccountName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAccountName.Location = new System.Drawing.Point(105, 11);
			this.txtAccountName.Name = "txtAccountName";
			this.txtAccountName.ReadOnly = true;
			this.txtAccountName.Size = new System.Drawing.Size(231, 21);
			this.txtAccountName.TabIndex = 87;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 15);
			this.label1.TabIndex = 86;
			this.label1.Text = "Tên tài khoản:";
			// 
			// RoleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(516, 338);
			this.Controls.Add(this.txtRoleName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtRoleID);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lvRole);
			this.Controls.Add(this.txtAccountName);
			this.Controls.Add(this.label1);
			this.Name = "RoleForm";
			this.Text = "RoleForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtRoleName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtRoleID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ListView lvRole;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.TextBox txtAccountName;
		private System.Windows.Forms.Label label1;
	}
}