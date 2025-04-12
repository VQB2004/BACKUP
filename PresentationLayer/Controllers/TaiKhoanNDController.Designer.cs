namespace PresentationLayer.Controllers
{
    partial class TaiKhoanNDController
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
            this.tabTKND = new System.Windows.Forms.TabControl();
            this.tabKH = new System.Windows.Forms.TabPage();
            this.dgvTKKH = new System.Windows.Forms.DataGridView();
            this.tabNV = new System.Windows.Forms.TabPage();
            this.dgvTKNV = new System.Windows.Forms.DataGridView();
            this.tabQTV = new System.Windows.Forms.TabPage();
            this.dgvTKQTV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbChucNang = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnHuyThemTT = new System.Windows.Forms.Button();
            this.maND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucNangId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.maND_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenND_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDangNhap_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucNangId_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDT_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhau_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkAnh_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete_NV = new System.Windows.Forms.DataGridViewImageColumn();
            this.maND_Admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenND_Admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDangNhap_Admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucNangId_Admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDT_Admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhau_Admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkAnh_Admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete_Admin = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnCapNhatTK = new System.Windows.Forms.Button();
            this.tabTKND.SuspendLayout();
            this.tabKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKKH)).BeginInit();
            this.tabNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKNV)).BeginInit();
            this.tabQTV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKQTV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabTKND
            // 
            this.tabTKND.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabTKND.Controls.Add(this.tabKH);
            this.tabTKND.Controls.Add(this.tabNV);
            this.tabTKND.Controls.Add(this.tabQTV);
            this.tabTKND.Location = new System.Drawing.Point(17, 16);
            this.tabTKND.Name = "tabTKND";
            this.tabTKND.SelectedIndex = 0;
            this.tabTKND.Size = new System.Drawing.Size(912, 329);
            this.tabTKND.TabIndex = 72;
            // 
            // tabKH
            // 
            this.tabKH.Controls.Add(this.dgvTKKH);
            this.tabKH.Location = new System.Drawing.Point(4, 25);
            this.tabKH.Name = "tabKH";
            this.tabKH.Padding = new System.Windows.Forms.Padding(3);
            this.tabKH.Size = new System.Drawing.Size(904, 300);
            this.tabKH.TabIndex = 0;
            this.tabKH.Text = "Khách hàng";
            this.tabKH.UseVisualStyleBackColor = true;
            // 
            // dgvTKKH
            // 
            this.dgvTKKH.AllowUserToAddRows = false;
            this.dgvTKKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTKKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maND,
            this.hoTenND,
            this.tenDangNhap,
            this.ChucNangId,
            this.soDT,
            this.matKhau,
            this.linkAnh,
            this.Delete});
            this.dgvTKKH.Location = new System.Drawing.Point(4, 6);
            this.dgvTKKH.Name = "dgvTKKH";
            this.dgvTKKH.RowHeadersWidth = 51;
            this.dgvTKKH.RowTemplate.Height = 24;
            this.dgvTKKH.Size = new System.Drawing.Size(896, 288);
            this.dgvTKKH.TabIndex = 0;
            // 
            // tabNV
            // 
            this.tabNV.Controls.Add(this.dgvTKNV);
            this.tabNV.Location = new System.Drawing.Point(4, 25);
            this.tabNV.Name = "tabNV";
            this.tabNV.Padding = new System.Windows.Forms.Padding(3);
            this.tabNV.Size = new System.Drawing.Size(904, 300);
            this.tabNV.TabIndex = 1;
            this.tabNV.Text = "Nhân viên";
            this.tabNV.UseVisualStyleBackColor = true;
            // 
            // dgvTKNV
            // 
            this.dgvTKNV.AllowUserToAddRows = false;
            this.dgvTKNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTKNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maND_NV,
            this.hoTenND_NV,
            this.tenDangNhap_NV,
            this.ChucNangId_NV,
            this.soDT_NV,
            this.matKhau_NV,
            this.linkAnh_NV,
            this.Delete_NV});
            this.dgvTKNV.Location = new System.Drawing.Point(4, 6);
            this.dgvTKNV.Name = "dgvTKNV";
            this.dgvTKNV.RowHeadersWidth = 51;
            this.dgvTKNV.RowTemplate.Height = 24;
            this.dgvTKNV.Size = new System.Drawing.Size(894, 289);
            this.dgvTKNV.TabIndex = 1;
            // 
            // tabQTV
            // 
            this.tabQTV.Controls.Add(this.dgvTKQTV);
            this.tabQTV.Location = new System.Drawing.Point(4, 25);
            this.tabQTV.Name = "tabQTV";
            this.tabQTV.Padding = new System.Windows.Forms.Padding(3);
            this.tabQTV.Size = new System.Drawing.Size(904, 300);
            this.tabQTV.TabIndex = 2;
            this.tabQTV.Text = "Quản trị viên";
            this.tabQTV.UseVisualStyleBackColor = true;
            // 
            // dgvTKQTV
            // 
            this.dgvTKQTV.AllowUserToAddRows = false;
            this.dgvTKQTV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTKQTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKQTV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maND_Admin,
            this.hoTenND_Admin,
            this.tenDangNhap_Admin,
            this.ChucNangId_Admin,
            this.soDT_Admin,
            this.matKhau_Admin,
            this.linkAnh_Admin,
            this.Delete_Admin});
            this.dgvTKQTV.Location = new System.Drawing.Point(4, 6);
            this.dgvTKQTV.Name = "dgvTKQTV";
            this.dgvTKQTV.RowHeadersWidth = 51;
            this.dgvTKQTV.RowTemplate.Height = 24;
            this.dgvTKQTV.Size = new System.Drawing.Size(894, 289);
            this.dgvTKQTV.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(788, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 34);
            this.button1.TabIndex = 71;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(572, 488);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(357, 24);
            this.textBox3.TabIndex = 70;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(509, 491);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 18);
            this.label13.TabIndex = 69;
            this.label13.Text = "Địa chỉ:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(606, 449);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(323, 24);
            this.textBox2.TabIndex = 68;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(509, 452);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 18);
            this.label12.TabIndex = 67;
            this.label12.Text = "Ảnh đại diện:";
            // 
            // cbChucNang
            // 
            this.cbChucNang.FormattingEnabled = true;
            this.cbChucNang.Location = new System.Drawing.Point(103, 527);
            this.cbChucNang.Name = "cbChucNang";
            this.cbChucNang.Size = new System.Drawing.Size(121, 24);
            this.cbChucNang.TabIndex = 66;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 527);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 18);
            this.label10.TabIndex = 65;
            this.label10.Text = "Chức năng:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(613, 411);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 24);
            this.textBox1.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(509, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 63;
            this.label9.Text = "Số điện thoại:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(93, 491);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(181, 24);
            this.txtMatKhau.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 494);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 61;
            this.label8.Text = "Mật khẩu:";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDN.Location = new System.Drawing.Point(129, 456);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(181, 24);
            this.txtTenDN.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 59;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(77, 416);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(182, 24);
            this.txtHoTen.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 57;
            this.label1.Text = "Họ tên:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(372, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 25);
            this.label11.TabIndex = 56;
            this.label11.Text = "Thông tin tài khoản";
            // 
            // btnHuyThemTT
            // 
            this.btnHuyThemTT.BackColor = System.Drawing.Color.Red;
            this.btnHuyThemTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyThemTT.ForeColor = System.Drawing.Color.White;
            this.btnHuyThemTT.Location = new System.Drawing.Point(297, 527);
            this.btnHuyThemTT.Name = "btnHuyThemTT";
            this.btnHuyThemTT.Size = new System.Drawing.Size(117, 34);
            this.btnHuyThemTT.TabIndex = 73;
            this.btnHuyThemTT.Text = "Hủy";
            this.btnHuyThemTT.UseVisualStyleBackColor = false;
            // 
            // maND
            // 
            this.maND.DataPropertyName = "maND";
            this.maND.HeaderText = "maND";
            this.maND.MinimumWidth = 6;
            this.maND.Name = "maND";
            this.maND.Width = 45;
            // 
            // hoTenND
            // 
            this.hoTenND.DataPropertyName = "hoTenND";
            this.hoTenND.HeaderText = "hoTenND";
            this.hoTenND.MinimumWidth = 6;
            this.hoTenND.Name = "hoTenND";
            this.hoTenND.Width = 95;
            // 
            // tenDangNhap
            // 
            this.tenDangNhap.DataPropertyName = "tenDangNhap";
            this.tenDangNhap.HeaderText = "tenDangNhap";
            this.tenDangNhap.MinimumWidth = 6;
            this.tenDangNhap.Name = "tenDangNhap";
            this.tenDangNhap.Width = 80;
            // 
            // ChucNangId
            // 
            this.ChucNangId.DataPropertyName = "ChucNangId";
            this.ChucNangId.HeaderText = "ChucNangId";
            this.ChucNangId.MinimumWidth = 6;
            this.ChucNangId.Name = "ChucNangId";
            this.ChucNangId.Width = 60;
            // 
            // soDT
            // 
            this.soDT.DataPropertyName = "soDT";
            this.soDT.FillWeight = 80F;
            this.soDT.HeaderText = "soDT";
            this.soDT.MinimumWidth = 6;
            this.soDT.Name = "soDT";
            this.soDT.Width = 80;
            // 
            // matKhau
            // 
            this.matKhau.DataPropertyName = "matKhau";
            this.matKhau.HeaderText = "matKhau";
            this.matKhau.MinimumWidth = 6;
            this.matKhau.Name = "matKhau";
            // 
            // linkAnh
            // 
            this.linkAnh.DataPropertyName = "linkAnh";
            this.linkAnh.HeaderText = "linkAnh";
            this.linkAnh.MinimumWidth = 6;
            this.linkAnh.Name = "linkAnh";
            this.linkAnh.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 30;
            // 
            // maND_NV
            // 
            this.maND_NV.DataPropertyName = "maND";
            this.maND_NV.HeaderText = "maND";
            this.maND_NV.MinimumWidth = 6;
            this.maND_NV.Name = "maND_NV";
            this.maND_NV.Width = 45;
            // 
            // hoTenND_NV
            // 
            this.hoTenND_NV.DataPropertyName = "hoTenND";
            this.hoTenND_NV.HeaderText = "hoTenND";
            this.hoTenND_NV.MinimumWidth = 6;
            this.hoTenND_NV.Name = "hoTenND_NV";
            this.hoTenND_NV.Width = 95;
            // 
            // tenDangNhap_NV
            // 
            this.tenDangNhap_NV.DataPropertyName = "tenDangNhap";
            this.tenDangNhap_NV.HeaderText = "tenDangNhap";
            this.tenDangNhap_NV.MinimumWidth = 6;
            this.tenDangNhap_NV.Name = "tenDangNhap_NV";
            this.tenDangNhap_NV.Width = 80;
            // 
            // ChucNangId_NV
            // 
            this.ChucNangId_NV.DataPropertyName = "ChucNangId";
            this.ChucNangId_NV.HeaderText = "ChucNangId";
            this.ChucNangId_NV.MinimumWidth = 6;
            this.ChucNangId_NV.Name = "ChucNangId_NV";
            this.ChucNangId_NV.Width = 60;
            // 
            // soDT_NV
            // 
            this.soDT_NV.DataPropertyName = "soDT";
            this.soDT_NV.HeaderText = "soDT";
            this.soDT_NV.MinimumWidth = 6;
            this.soDT_NV.Name = "soDT_NV";
            this.soDT_NV.Width = 80;
            // 
            // matKhau_NV
            // 
            this.matKhau_NV.DataPropertyName = "matKhau";
            this.matKhau_NV.HeaderText = "matKhau";
            this.matKhau_NV.MinimumWidth = 6;
            this.matKhau_NV.Name = "matKhau_NV";
            // 
            // linkAnh_NV
            // 
            this.linkAnh_NV.HeaderText = "linkAnh";
            this.linkAnh_NV.MinimumWidth = 6;
            this.linkAnh_NV.Name = "linkAnh_NV";
            this.linkAnh_NV.Width = 125;
            // 
            // Delete_NV
            // 
            this.Delete_NV.HeaderText = "";
            this.Delete_NV.MinimumWidth = 6;
            this.Delete_NV.Name = "Delete_NV";
            this.Delete_NV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete_NV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete_NV.Width = 30;
            // 
            // maND_Admin
            // 
            this.maND_Admin.DataPropertyName = "maND";
            this.maND_Admin.HeaderText = "maND";
            this.maND_Admin.MinimumWidth = 6;
            this.maND_Admin.Name = "maND_Admin";
            this.maND_Admin.Width = 45;
            // 
            // hoTenND_Admin
            // 
            this.hoTenND_Admin.DataPropertyName = "hoTenND";
            this.hoTenND_Admin.HeaderText = "hoTenND";
            this.hoTenND_Admin.MinimumWidth = 6;
            this.hoTenND_Admin.Name = "hoTenND_Admin";
            this.hoTenND_Admin.Width = 95;
            // 
            // tenDangNhap_Admin
            // 
            this.tenDangNhap_Admin.DataPropertyName = "tenDangNhap";
            this.tenDangNhap_Admin.HeaderText = "tenDangNhap";
            this.tenDangNhap_Admin.MinimumWidth = 6;
            this.tenDangNhap_Admin.Name = "tenDangNhap_Admin";
            this.tenDangNhap_Admin.Width = 80;
            // 
            // ChucNangId_Admin
            // 
            this.ChucNangId_Admin.DataPropertyName = "ChucNangId";
            this.ChucNangId_Admin.HeaderText = "ChucNangId";
            this.ChucNangId_Admin.MinimumWidth = 6;
            this.ChucNangId_Admin.Name = "ChucNangId_Admin";
            this.ChucNangId_Admin.Width = 60;
            // 
            // soDT_Admin
            // 
            this.soDT_Admin.DataPropertyName = "soDT";
            this.soDT_Admin.HeaderText = "soDT";
            this.soDT_Admin.MinimumWidth = 6;
            this.soDT_Admin.Name = "soDT_Admin";
            this.soDT_Admin.Width = 80;
            // 
            // matKhau_Admin
            // 
            this.matKhau_Admin.DataPropertyName = "matKhau";
            this.matKhau_Admin.HeaderText = "matKhau";
            this.matKhau_Admin.MinimumWidth = 6;
            this.matKhau_Admin.Name = "matKhau_Admin";
            // 
            // linkAnh_Admin
            // 
            this.linkAnh_Admin.DataPropertyName = "linkAnh";
            this.linkAnh_Admin.HeaderText = "linkAnh";
            this.linkAnh_Admin.MinimumWidth = 6;
            this.linkAnh_Admin.Name = "linkAnh_Admin";
            this.linkAnh_Admin.Width = 125;
            // 
            // Delete_Admin
            // 
            this.Delete_Admin.HeaderText = "";
            this.Delete_Admin.MinimumWidth = 6;
            this.Delete_Admin.Name = "Delete_Admin";
            this.Delete_Admin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete_Admin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete_Admin.Width = 30;
            // 
            // btnCapNhatTK
            // 
            this.btnCapNhatTK.BackColor = System.Drawing.Color.Blue;
            this.btnCapNhatTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatTK.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatTK.Location = new System.Drawing.Point(536, 527);
            this.btnCapNhatTK.Name = "btnCapNhatTK";
            this.btnCapNhatTK.Size = new System.Drawing.Size(134, 34);
            this.btnCapNhatTK.TabIndex = 126;
            this.btnCapNhatTK.Text = "Cập nhật";
            this.btnCapNhatTK.UseVisualStyleBackColor = false;
            // 
            // TaiKhoanNDController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCapNhatTK);
            this.Controls.Add(this.btnHuyThemTT);
            this.Controls.Add(this.tabTKND);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbChucNang);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Name = "TaiKhoanNDController";
            this.Size = new System.Drawing.Size(943, 587);
            this.Load += new System.EventHandler(this.TaiKhoanNDController_Load);
            this.tabTKND.ResumeLayout(false);
            this.tabKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKKH)).EndInit();
            this.tabNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKNV)).EndInit();
            this.tabQTV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKQTV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabTKND;
        private System.Windows.Forms.TabPage tabKH;
        private System.Windows.Forms.DataGridView dgvTKKH;
        private System.Windows.Forms.TabPage tabNV;
        private System.Windows.Forms.DataGridView dgvTKNV;
        private System.Windows.Forms.TabPage tabQTV;
        private System.Windows.Forms.DataGridView dgvTKQTV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbChucNang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnHuyThemTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maND;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenND;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucNangId;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkAnh;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn maND_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenND_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhap_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucNangId_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDT_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhau_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkAnh_NV;
        private System.Windows.Forms.DataGridViewImageColumn Delete_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn maND_Admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenND_Admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhap_Admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucNangId_Admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDT_Admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhau_Admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkAnh_Admin;
        private System.Windows.Forms.DataGridViewImageColumn Delete_Admin;
        private System.Windows.Forms.Button btnCapNhatTK;
    }
}
