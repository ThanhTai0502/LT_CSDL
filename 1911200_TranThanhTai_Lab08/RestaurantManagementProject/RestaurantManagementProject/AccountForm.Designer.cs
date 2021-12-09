namespace RestaurantManagementProject
{
	partial class AccountForm
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
			this.dgvAccount = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(556, 21);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(97, 29);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "Thêm tài khoản";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// dgvAccount
			// 
			this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAccount.Location = new System.Drawing.Point(2, 54);
			this.dgvAccount.Margin = new System.Windows.Forms.Padding(2);
			this.dgvAccount.Name = "dgvAccount";
			this.dgvAccount.RowHeadersWidth = 51;
			this.dgvAccount.RowTemplate.Height = 24;
			this.dgvAccount.Size = new System.Drawing.Size(657, 316);
			this.dgvAccount.TabIndex = 4;
			// 
			// AccountForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(657, 393);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dgvAccount);
			this.Name = "AccountForm";
			this.Text = "AccountForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.DataGridView dgvAccount;
	}
}