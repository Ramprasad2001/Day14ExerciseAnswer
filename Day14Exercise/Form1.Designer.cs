
namespace Day14Exercise
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
            this.LblStudentCode = new System.Windows.Forms.Label();
            this.TxtStudentCode = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.LblAddress = new System.Windows.Forms.Label();
            this.TxtDepartment = new System.Windows.Forms.TextBox();
            this.LblDepartment = new System.Windows.Forms.Label();
            this.TxtStudentName = new System.Windows.Forms.TextBox();
            this.LblStudentName = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblStudentCode
            // 
            this.LblStudentCode.AutoSize = true;
            this.LblStudentCode.Location = new System.Drawing.Point(131, 61);
            this.LblStudentCode.Name = "LblStudentCode";
            this.LblStudentCode.Size = new System.Drawing.Size(90, 17);
            this.LblStudentCode.TabIndex = 0;
            this.LblStudentCode.Text = "StudentCode";
            // 
            // TxtStudentCode
            // 
            this.TxtStudentCode.Location = new System.Drawing.Point(285, 58);
            this.TxtStudentCode.Name = "TxtStudentCode";
            this.TxtStudentCode.Size = new System.Drawing.Size(100, 22);
            this.TxtStudentCode.TabIndex = 1;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(285, 209);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(100, 22);
            this.TxtAddress.TabIndex = 3;
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(131, 214);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(60, 17);
            this.LblAddress.TabIndex = 2;
            this.LblAddress.Text = "Address";
            // 
            // TxtDepartment
            // 
            this.TxtDepartment.Location = new System.Drawing.Point(285, 157);
            this.TxtDepartment.Name = "TxtDepartment";
            this.TxtDepartment.Size = new System.Drawing.Size(100, 22);
            this.TxtDepartment.TabIndex = 5;
            // 
            // LblDepartment
            // 
            this.LblDepartment.AutoSize = true;
            this.LblDepartment.Location = new System.Drawing.Point(131, 162);
            this.LblDepartment.Name = "LblDepartment";
            this.LblDepartment.Size = new System.Drawing.Size(82, 17);
            this.LblDepartment.TabIndex = 4;
            this.LblDepartment.Text = "Department";
            // 
            // TxtStudentName
            // 
            this.TxtStudentName.Location = new System.Drawing.Point(285, 105);
            this.TxtStudentName.Name = "TxtStudentName";
            this.TxtStudentName.Size = new System.Drawing.Size(100, 22);
            this.TxtStudentName.TabIndex = 7;
            // 
            // LblStudentName
            // 
            this.LblStudentName.AutoSize = true;
            this.LblStudentName.Location = new System.Drawing.Point(131, 108);
            this.LblStudentName.Name = "LblStudentName";
            this.LblStudentName.Size = new System.Drawing.Size(94, 17);
            this.LblStudentName.TabIndex = 6;
            this.LblStudentName.Text = "StudentName";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(203, 262);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 8;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(285, 333);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 9;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(116, 333);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(447, 333);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(485, 61);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 12;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtStudentName);
            this.Controls.Add(this.LblStudentName);
            this.Controls.Add(this.TxtDepartment);
            this.Controls.Add(this.LblDepartment);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.TxtStudentCode);
            this.Controls.Add(this.LblStudentCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblStudentCode;
        private System.Windows.Forms.TextBox TxtStudentCode;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.TextBox TxtDepartment;
        private System.Windows.Forms.Label LblDepartment;
        private System.Windows.Forms.TextBox TxtStudentName;
        private System.Windows.Forms.Label LblStudentName;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnReset;
    }
}

