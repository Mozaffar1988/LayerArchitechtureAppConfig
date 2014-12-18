namespace DepartmentApp
{
    partial class DepertmentUI
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
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deptNameTextBox = new System.Windows.Forms.TextBox();
            this.deptCodeTextBox = new System.Windows.Forms.TextBox();
            this.showdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.showdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(320, 109);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(129, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dept _Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dept_Code";
            // 
            // deptNameTextBox
            // 
            this.deptNameTextBox.Location = new System.Drawing.Point(271, 18);
            this.deptNameTextBox.Name = "deptNameTextBox";
            this.deptNameTextBox.Size = new System.Drawing.Size(162, 20);
            this.deptNameTextBox.TabIndex = 3;
            // 
            // deptCodeTextBox
            // 
            this.deptCodeTextBox.Location = new System.Drawing.Point(271, 65);
            this.deptCodeTextBox.Name = "deptCodeTextBox";
            this.deptCodeTextBox.Size = new System.Drawing.Size(162, 20);
            this.deptCodeTextBox.TabIndex = 4;
            // 
            // showdataGridView
            // 
            this.showdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdataGridView.Location = new System.Drawing.Point(153, 169);
            this.showdataGridView.Name = "showdataGridView";
            this.showdataGridView.Size = new System.Drawing.Size(345, 150);
            this.showdataGridView.TabIndex = 5;
            // 
            // DepertmentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 355);
            this.Controls.Add(this.showdataGridView);
            this.Controls.Add(this.deptCodeTextBox);
            this.Controls.Add(this.deptNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Name = "DepertmentUI";
            this.Text = "DepertmentUI";
            ((System.ComponentModel.ISupportInitialize)(this.showdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox deptNameTextBox;
        private System.Windows.Forms.TextBox deptCodeTextBox;
        private System.Windows.Forms.DataGridView showdataGridView;
    }
}

