namespace OOAD.View
{
    partial class MainView
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btYesterday = new System.Windows.Forms.Button();
            this.btToday = new System.Windows.Forms.Button();
            this.btTomorrow = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.Location = new System.Drawing.Point(0, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(1148, 644);
            this.dgv1.TabIndex = 0;
            // 
            // btYesterday
            // 
            this.btYesterday.Location = new System.Drawing.Point(12, 12);
            this.btYesterday.Name = "btYesterday";
            this.btYesterday.Size = new System.Drawing.Size(116, 35);
            this.btYesterday.TabIndex = 1;
            this.btYesterday.Text = "Hôm trước";
            this.btYesterday.UseVisualStyleBackColor = true;
            this.btYesterday.Click += new System.EventHandler(this.btYesterday_Click);
            // 
            // btToday
            // 
            this.btToday.Location = new System.Drawing.Point(134, 12);
            this.btToday.Name = "btToday";
            this.btToday.Size = new System.Drawing.Size(116, 35);
            this.btToday.TabIndex = 2;
            this.btToday.Text = "Hôm nay";
            this.btToday.UseVisualStyleBackColor = true;
            this.btToday.Click += new System.EventHandler(this.btToday_Click);
            // 
            // btTomorrow
            // 
            this.btTomorrow.Location = new System.Drawing.Point(256, 12);
            this.btTomorrow.Name = "btTomorrow";
            this.btTomorrow.Size = new System.Drawing.Size(116, 35);
            this.btTomorrow.TabIndex = 3;
            this.btTomorrow.Text = "Ngày mai";
            this.btTomorrow.UseVisualStyleBackColor = true;
            this.btTomorrow.Click += new System.EventHandler(this.btTomorrow_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(363, 13);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(137, 23);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "thêm cuộc hẹn";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(506, 13);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(137, 23);
            this.btEdit.TabIndex = 5;
            this.btEdit.Text = "sửa cuộc hẹn";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(649, 13);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(137, 23);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "xoá cuộc hẹn";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.btEdit);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 596);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 48);
            this.panel1.TabIndex = 8;
            // 
            // lbDate
            // 
            this.lbDate.Location = new System.Drawing.Point(805, 28);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(119, 19);
            this.lbDate.TabIndex = 4;
            this.lbDate.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btYesterday);
            this.panel2.Controls.Add(this.btToday);
            this.panel2.Controls.Add(this.btTomorrow);
            this.panel2.Controls.Add(this.lbDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1148, 65);
            this.panel2.TabIndex = 9;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 644);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv1);
            this.Name = "MainView";
            this.Text = "Calendar System";
            
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btYesterday;
        private System.Windows.Forms.Button btToday;
        private System.Windows.Forms.Button btTomorrow;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbDate;
    }
}