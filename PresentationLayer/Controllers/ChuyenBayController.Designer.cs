namespace PresentationLayer.Controllers
{
    partial class ChuyenBayController
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTimKiemTB = new System.Windows.Forms.Button();
            this.dgvChuyenBay = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTuyenBaySearch = new System.Windows.Forms.ComboBox();
            this.datetimeTimKiem = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuyThemCB = new System.Windows.Forms.Button();
            this.btnThemCB = new System.Windows.Forms.Button();
            this.cbTienTrinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMaTuyenBay = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThoiGianBay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.datetimeThemTB = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCapNhatCB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenBay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiemTB
            // 
            this.btnTimKiemTB.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTimKiemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemTB.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemTB.Location = new System.Drawing.Point(876, 34);
            this.btnTimKiemTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiemTB.Name = "btnTimKiemTB";
            this.btnTimKiemTB.Size = new System.Drawing.Size(163, 42);
            this.btnTimKiemTB.TabIndex = 83;
            this.btnTimKiemTB.Text = "Tìm kiếm";
            this.btnTimKiemTB.UseVisualStyleBackColor = false;
            this.btnTimKiemTB.Click += new System.EventHandler(this.btnTimKiemTB_Click);
            // 
            // dgvChuyenBay
            // 
            this.dgvChuyenBay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenBay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Edit});
            this.dgvChuyenBay.Location = new System.Drawing.Point(17, 102);
            this.dgvChuyenBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvChuyenBay.Name = "dgvChuyenBay";
            this.dgvChuyenBay.RowHeadersWidth = 51;
            this.dgvChuyenBay.RowTemplate.Height = 24;
            this.dgvChuyenBay.Size = new System.Drawing.Size(1023, 386);
            this.dgvChuyenBay.TabIndex = 82;
            this.dgvChuyenBay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuyenBay_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(369, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 81;
            this.label2.Text = "Tuyến bay:";
            // 
            // cbTuyenBaySearch
            // 
            this.cbTuyenBaySearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTuyenBaySearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbTuyenBaySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTuyenBaySearch.ForeColor = System.Drawing.Color.Navy;
            this.cbTuyenBaySearch.FormattingEnabled = true;
            this.cbTuyenBaySearch.Location = new System.Drawing.Point(374, 41);
            this.cbTuyenBaySearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTuyenBaySearch.Name = "cbTuyenBaySearch";
            this.cbTuyenBaySearch.Size = new System.Drawing.Size(301, 33);
            this.cbTuyenBaySearch.TabIndex = 80;
            // 
            // datetimeTimKiem
            // 
            this.datetimeTimKiem.CalendarForeColor = System.Drawing.Color.Black;
            this.datetimeTimKiem.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.datetimeTimKiem.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.datetimeTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeTimKiem.Location = new System.Drawing.Point(17, 39);
            this.datetimeTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datetimeTimKiem.Name = "datetimeTimKiem";
            this.datetimeTimKiem.Size = new System.Drawing.Size(258, 31);
            this.datetimeTimKiem.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 78;
            this.label1.Text = "Ngày:";
            // 
            // btnHuyThemCB
            // 
            this.btnHuyThemCB.BackColor = System.Drawing.Color.Red;
            this.btnHuyThemCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyThemCB.ForeColor = System.Drawing.Color.White;
            this.btnHuyThemCB.Location = new System.Drawing.Point(47, 682);
            this.btnHuyThemCB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuyThemCB.Name = "btnHuyThemCB";
            this.btnHuyThemCB.Size = new System.Drawing.Size(151, 42);
            this.btnHuyThemCB.TabIndex = 122;
            this.btnHuyThemCB.Text = "Hủy";
            this.btnHuyThemCB.UseVisualStyleBackColor = false;
            this.btnHuyThemCB.Click += new System.EventHandler(this.btnHuyThemCB_Click);
            // 
            // btnThemCB
            // 
            this.btnThemCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThemCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCB.ForeColor = System.Drawing.Color.White;
            this.btnThemCB.Location = new System.Drawing.Point(866, 682);
            this.btnThemCB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemCB.Name = "btnThemCB";
            this.btnThemCB.Size = new System.Drawing.Size(151, 42);
            this.btnThemCB.TabIndex = 121;
            this.btnThemCB.Text = "Thêm";
            this.btnThemCB.UseVisualStyleBackColor = false;
            this.btnThemCB.Click += new System.EventHandler(this.btnThemCB_Click);
            // 
            // cbTienTrinh
            // 
            this.cbTienTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTienTrinh.ForeColor = System.Drawing.Color.Navy;
            this.cbTienTrinh.FormattingEnabled = true;
            this.cbTienTrinh.Location = new System.Drawing.Point(848, 629);
            this.cbTienTrinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTienTrinh.Name = "cbTienTrinh";
            this.cbTienTrinh.Size = new System.Drawing.Size(168, 30);
            this.cbTienTrinh.TabIndex = 120;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(752, 630);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 119;
            this.label4.Text = "Tiến trình:";
            // 
            // cbMaTuyenBay
            // 
            this.cbMaTuyenBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaTuyenBay.ForeColor = System.Drawing.Color.Navy;
            this.cbMaTuyenBay.FormattingEnabled = true;
            this.cbMaTuyenBay.Location = new System.Drawing.Point(166, 629);
            this.cbMaTuyenBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMaTuyenBay.Name = "cbMaTuyenBay";
            this.cbMaTuyenBay.Size = new System.Drawing.Size(136, 30);
            this.cbMaTuyenBay.TabIndex = 118;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(753, 572);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 22);
            this.label5.TabIndex = 117;
            this.label5.Text = "Thời gian bay:";
            // 
            // txtThoiGianBay
            // 
            this.txtThoiGianBay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThoiGianBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGianBay.ForeColor = System.Drawing.Color.Navy;
            this.txtThoiGianBay.Location = new System.Drawing.Point(875, 569);
            this.txtThoiGianBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThoiGianBay.Name = "txtThoiGianBay";
            this.txtThoiGianBay.Size = new System.Drawing.Size(39, 28);
            this.txtThoiGianBay.TabIndex = 116;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(44, 631);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 22);
            this.label6.TabIndex = 115;
            this.label6.Text = "Mã tuyến bay:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(457, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 29);
            this.label7.TabIndex = 114;
            this.label7.Text = "Thêm chuyến bay:";
            // 
            // datetimeThemTB
            // 
            this.datetimeThemTB.CalendarForeColor = System.Drawing.Color.Black;
            this.datetimeThemTB.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.datetimeThemTB.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.datetimeThemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeThemTB.Location = new System.Drawing.Point(47, 568);
            this.datetimeThemTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datetimeThemTB.Name = "datetimeThemTB";
            this.datetimeThemTB.Size = new System.Drawing.Size(258, 28);
            this.datetimeThemTB.TabIndex = 124;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(43, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 123;
            this.label3.Text = "Ngày giờ đi:";
            // 
            // btnCapNhatCB
            // 
            this.btnCapNhatCB.BackColor = System.Drawing.Color.Blue;
            this.btnCapNhatCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatCB.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatCB.Location = new System.Drawing.Point(444, 682);
            this.btnCapNhatCB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCapNhatCB.Name = "btnCapNhatCB";
            this.btnCapNhatCB.Size = new System.Drawing.Size(151, 42);
            this.btnCapNhatCB.TabIndex = 125;
            this.btnCapNhatCB.Text = "Cập nhật";
            this.btnCapNhatCB.UseVisualStyleBackColor = false;
            this.btnCapNhatCB.Click += new System.EventHandler(this.btnCapNhatCB_Click);
            // 
            // ChuyenBayController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCapNhatCB);
            this.Controls.Add(this.datetimeThemTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHuyThemCB);
            this.Controls.Add(this.btnThemCB);
            this.Controls.Add(this.cbTienTrinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMaTuyenBay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtThoiGianBay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTimKiemTB);
            this.Controls.Add(this.dgvChuyenBay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTuyenBaySearch);
            this.Controls.Add(this.datetimeTimKiem);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChuyenBayController";
            this.Size = new System.Drawing.Size(1061, 734);
            this.Load += new System.EventHandler(this.ChuyenBayController_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiemTB;
        private System.Windows.Forms.DataGridView dgvChuyenBay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTuyenBaySearch;
        private System.Windows.Forms.DateTimePicker datetimeTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuyThemCB;
        private System.Windows.Forms.Button btnThemCB;
        private System.Windows.Forms.ComboBox cbTienTrinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMaTuyenBay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThoiGianBay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datetimeThemTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCapNhatCB;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
    }
}
