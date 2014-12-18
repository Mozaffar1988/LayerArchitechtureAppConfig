namespace LayerArchitecture.UI
{
    partial class DepartmentUI
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
            this.departmentGridView = new System.Windows.Forms.DataGridView();
            this.saveDepartmentButton = new System.Windows.Forms.Button();
            this.departmentCodeTextBox = new System.Windows.Forms.TextBox();
            this.departmentNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.departmentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentGridView
            // 
            this.departmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentGridView.Location = new System.Drawing.Point(114, 138);
            this.departmentGridView.Name = "departmentGridView";
            this.departmentGridView.Size = new System.Drawing.Size(376, 150);
            this.departmentGridView.TabIndex = 10;
            // 
            // saveDepartmentButton
            // 
            this.saveDepartmentButton.Location = new System.Drawing.Point(303, 94);
            this.saveDepartmentButton.Name = "saveDepartmentButton";
            this.saveDepartmentButton.Size = new System.Drawing.Size(186, 23);
            this.saveDepartmentButton.TabIndex = 9;
            this.saveDepartmentButton.Text = "Save";
            this.saveDepartmentButton.UseVisualStyleBackColor = true;
            this.saveDepartmentButton.Click += new System.EventHandler(this.saveDepartmentButton_Click);
            // 
            // departmentCodeTextBox
            // 
            this.departmentCodeTextBox.Location = new System.Drawing.Point(220, 57);
            this.departmentCodeTextBox.Name = "departmentCodeTextBox";
            this.departmentCodeTextBox.Size = new System.Drawing.Size(270, 20);
            this.departmentCodeTextBox.TabIndex = 7;
            // 
            // departmentNameTextBox
            // 
            this.departmentNameTextBox.Location = new System.Drawing.Point(220, 28);
            this.departmentNameTextBox.Name = "departmentNameTextBox";
            this.departmentNameTextBox.Size = new System.Drawing.Size(270, 20);
            this.departmentNameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Department Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Department Name";
            // 
            // DepartmentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 326);
            this.Controls.Add(this.departmentGridView);
            this.Controls.Add(this.saveDepartmentButton);
            this.Controls.Add(this.departmentCodeTextBox);
            this.Controls.Add(this.departmentNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DepartmentUI";
            this.Text = "DepartmentUI";
            ((System.ComponentModel.ISupportInitialize)(this.departmentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView departmentGridView;
        private System.Windows.Forms.Button saveDepartmentButton;
        private System.Windows.Forms.TextBox departmentCodeTextBox;
        private System.Windows.Forms.TextBox departmentNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}