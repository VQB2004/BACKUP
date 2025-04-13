namespace PresentationLayer.Controllers
{
    partial class QuyDinhController
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
            this.btnHuyThemSB = new System.Windows.Forms.Button();
            this.txtNoiDungQD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemQD = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenQuyDinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabDSTuyenBay = new System.Windows.Forms.DataGridView();
            this.btnCapNhatQD = new System.Windows.Forms.Button();
            this.dgvQuyDinh = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabDSTuyenBay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyDinh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuyThemSB
            // 
            this.btnHuyThemSB.BackColor = System.Drawing.Color.Red;
            this.btnHuyThemSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyThemSB.ForeColor = System.Drawing.Color.White;
            this.btnHuyThemSB.Location = new System.Drawing.Point(618, 539);
            this.btnHuyThemSB.Name = "btnHuyThemSB";
            this.btnHuyThemSB.Size = new System.Drawing.Size(117, 34);
            this.btnHuyThemSB.TabIndex = 123;
            this.btnHuyThemSB.Text = "Hủy";
            this.btnHuyThemSB.UseVisualStyleBackColor = false;
            this.btnHuyThemSB.Click += new System.EventHandler(this.btnHuyThemSB_Click);
            // 
            // txtNoiDungQD
            // 
            this.txtNoiDungQD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoiDungQD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDungQD.ForeColor = System.Drawing.Color.Navy;
            this.txtNoiDungQD.Location = new System.Drawing.Point(692, 498);
            this.txtNoiDungQD.Name = "txtNoiDungQD";
            this.txtNoiDungQD.Size = new System.Drawing.Size(78, 24);
            this.txtNoiDungQD.TabIndex = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(369, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 119;
            this.label1.Text = "Quản lý quy định";
            // 
            // btnThemQD
            // 
            this.btnThemQD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThemQD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemQD.ForeColor = System.Drawing.Color.White;
            this.btnThemQD.Location = new System.Drawing.Point(215, 539);
            this.btnThemQD.Name = "btnThemQD";
            this.btnThemQD.Size = new System.Drawing.Size(117, 34);
            this.btnThemQD.TabIndex = 118;
            this.btnThemQD.Text = "Thêm";
            this.btnThemQD.UseVisualStyleBackColor = false;
            this.btnThemQD.Click += new System.EventHandler(this.btnThemQD_Click_1);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(106, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 117;
            this.label5.Text = "Tên quy định:";
            // 
            // txtTenQuyDinh
            // 
            this.txtTenQuyDinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenQuyDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenQuyDinh.ForeColor = System.Drawing.Color.Navy;
            this.txtTenQuyDinh.Location = new System.Drawing.Point(215, 498);
            this.txtTenQuyDinh.Name = "txtTenQuyDinh";
            this.txtTenQuyDinh.Size = new System.Drawing.Size(181, 24);
            this.txtTenQuyDinh.TabIndex = 116;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(615, 501);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 115;
            this.label6.Text = "Nội dung:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(406, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 114;
            this.label7.Text = "Thêm quy định";
            // 
            // tabDSTuyenBay
            // 
            this.tabDSTuyenBay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDSTuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabDSTuyenBay.Location = new System.Drawing.Point(28, 57);
            this.tabDSTuyenBay.Name = "tabDSTuyenBay";
            this.tabDSTuyenBay.RowHeadersWidth = 51;
            this.tabDSTuyenBay.RowTemplate.Height = 24;
            this.tabDSTuyenBay.Size = new System.Drawing.Size(887, 384);
            this.tabDSTuyenBay.TabIndex = 113;
            // 
            // btnCapNhatQD
            // 
            this.btnCapNhatQD.BackColor = System.Drawing.Color.Blue;
            this.btnCapNhatQD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatQD.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatQD.Location = new System.Drawing.Point(411, 539);
            this.btnCapNhatQD.Name = "btnCapNhatQD";
            this.btnCapNhatQD.Size = new System.Drawing.Size(134, 34);
            this.btnCapNhatQD.TabIndex = 126;
            this.btnCapNhatQD.Text = "Cập nhật";
            this.btnCapNhatQD.UseVisualStyleBackColor = false;
            this.btnCapNhatQD.Click += new System.EventHandler(this.btnCapNhatQD_Click);
            // 
            // dgvQuyDinh
            // 
            this.dgvQuyDinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuyDinh.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvQuyDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuyDinh.Location = new System.Drawing.Point(37, 68);
            this.dgvQuyDinh.Name = "dgvQuyDinh";
            this.dgvQuyDinh.RowHeadersWidth = 51;
            this.dgvQuyDinh.RowTemplate.Height = 24;
            this.dgvQuyDinh.Size = new System.Drawing.Size(866, 362);
            this.dgvQuyDinh.TabIndex = 127;
            this.dgvQuyDinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuyDinh_CellClick_1);
            // 
            // QuyDinhController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvQuyDinh);
            this.Controls.Add(this.btnCapNhatQD);
            this.Controls.Add(this.btnHuyThemSB);
            this.Controls.Add(this.txtNoiDungQD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThemQD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenQuyDinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabDSTuyenBay);
            this.Name = "QuyDinhController";
            this.Size = new System.Drawing.Size(943, 587);
            this.Load += new System.EventHandler(this.QuyDinhController_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabDSTuyenBay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyDinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuyThemSB;
        private System.Windows.Forms.TextBox txtNoiDungQD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemQD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenQuyDinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView tabDSTuyenBay;
        private System.Windows.Forms.Button btnCapNhatQD;
        private System.Windows.Forms.DataGridView dgvQuyDinh;
    }
}
