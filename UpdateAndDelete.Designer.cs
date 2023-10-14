namespace Gym_management
{
    partial class UpdateAndDelete
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAndDelete));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvThanhVien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clmMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThoiHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHoTen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSDT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbThoiGian = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtThoiHan = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnReset = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(521, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "GYM CONCAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(451, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cập Nhật Và Xoá Thông Tin Thành Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(675, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "(Nhán vào thông tin thành viên để xoá)";
            // 
            // dgvThanhVien
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvThanhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThanhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThanhVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvThanhVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThanhVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThanhVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThanhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThanhVien.ColumnHeadersHeight = 77;
            this.dgvThanhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMa,
            this.clmTen,
            this.clmSDT,
            this.clmGioiTinh,
            this.clmNgaySinh,
            this.clmThoiHan,
            this.clmThoiGian});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThanhVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThanhVien.EnableHeadersVisualStyles = false;
            this.dgvThanhVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThanhVien.Location = new System.Drawing.Point(415, 145);
            this.dgvThanhVien.Name = "dgvThanhVien";
            this.dgvThanhVien.RowHeadersVisible = false;
            this.dgvThanhVien.RowHeadersWidth = 51;
            this.dgvThanhVien.RowTemplate.Height = 24;
            this.dgvThanhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThanhVien.Size = new System.Drawing.Size(697, 489);
            this.dgvThanhVien.TabIndex = 1;
            this.dgvThanhVien.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvThanhVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThanhVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThanhVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThanhVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThanhVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThanhVien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvThanhVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThanhVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvThanhVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThanhVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvThanhVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThanhVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvThanhVien.ThemeStyle.HeaderStyle.Height = 77;
            this.dgvThanhVien.ThemeStyle.ReadOnly = false;
            this.dgvThanhVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThanhVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThanhVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvThanhVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThanhVien.ThemeStyle.RowsStyle.Height = 24;
            this.dgvThanhVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThanhVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // clmMa
            // 
            this.clmMa.HeaderText = "Mã Thành Viên";
            this.clmMa.MinimumWidth = 6;
            this.clmMa.Name = "clmMa";
            // 
            // clmTen
            // 
            this.clmTen.HeaderText = "Tên Thành Viên";
            this.clmTen.MinimumWidth = 6;
            this.clmTen.Name = "clmTen";
            // 
            // clmSDT
            // 
            this.clmSDT.HeaderText = "Số Điện Thoại";
            this.clmSDT.MinimumWidth = 6;
            this.clmSDT.Name = "clmSDT";
            // 
            // clmGioiTinh
            // 
            this.clmGioiTinh.HeaderText = "Giới Tính";
            this.clmGioiTinh.MinimumWidth = 6;
            this.clmGioiTinh.Name = "clmGioiTinh";
            // 
            // clmNgaySinh
            // 
            this.clmNgaySinh.HeaderText = "Ngày Sinh";
            this.clmNgaySinh.MinimumWidth = 6;
            this.clmNgaySinh.Name = "clmNgaySinh";
            // 
            // clmThoiHan
            // 
            this.clmThoiHan.HeaderText = "Thời Hạn";
            this.clmThoiHan.MinimumWidth = 6;
            this.clmThoiHan.Name = "clmThoiHan";
            // 
            // clmThoiGian
            // 
            this.clmThoiGian.HeaderText = "Thời Gian";
            this.clmThoiGian.MinimumWidth = 6;
            this.clmThoiGian.Name = "clmThoiGian";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(52, 6);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(143, 126);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(63, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Thành Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(63, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số Điện Thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(63, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Giới Tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(63, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ngày Sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(63, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Thời Hạn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(63, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Thời Gian";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.HintForeColor = System.Drawing.Color.Empty;
            this.txtHoTen.HintText = "";
            this.txtHoTen.isPassword = false;
            this.txtHoTen.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtHoTen.LineIdleColor = System.Drawing.Color.Brown;
            this.txtHoTen.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtHoTen.LineThickness = 3;
            this.txtHoTen.Location = new System.Drawing.Point(66, 166);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(280, 30);
            this.txtHoTen.TabIndex = 4;
            this.txtHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSDT
            // 
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSDT.ForeColor = System.Drawing.Color.Black;
            this.txtSDT.HintForeColor = System.Drawing.Color.Empty;
            this.txtSDT.HintText = "";
            this.txtSDT.isPassword = false;
            this.txtSDT.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSDT.LineIdleColor = System.Drawing.Color.Brown;
            this.txtSDT.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSDT.LineThickness = 3;
            this.txtSDT.Location = new System.Drawing.Point(65, 231);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(282, 30);
            this.txtSDT.TabIndex = 5;
            this.txtSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSDT.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.ForeColor = System.Drawing.Color.DarkBlue;
            this.radNam.Location = new System.Drawing.Point(63, 301);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(60, 21);
            this.radNam.TabIndex = 6;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.ForeColor = System.Drawing.Color.DarkBlue;
            this.radNu.Location = new System.Drawing.Point(191, 301);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(50, 21);
            this.radNu.TabIndex = 6;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(66, 359);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(282, 31);
            this.guna2DateTimePicker1.TabIndex = 7;
            this.guna2DateTimePicker1.Value = new System.DateTime(2023, 10, 14, 20, 20, 17, 896);
            // 
            // cmbThoiGian
            // 
            this.cmbThoiGian.BackColor = System.Drawing.Color.Transparent;
            this.cmbThoiGian.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbThoiGian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThoiGian.FocusedColor = System.Drawing.Color.Empty;
            this.cmbThoiGian.FocusedState.Parent = this.cmbThoiGian;
            this.cmbThoiGian.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbThoiGian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbThoiGian.FormattingEnabled = true;
            this.cmbThoiGian.HoverState.Parent = this.cmbThoiGian;
            this.cmbThoiGian.ItemHeight = 30;
            this.cmbThoiGian.Items.AddRange(new object[] {
            "1 Tháng",
            "2 Tháng",
            "4 Tháng",
            "6 Tháng",
            "1 Năm"});
            this.cmbThoiGian.ItemsAppearance.Parent = this.cmbThoiGian;
            this.cmbThoiGian.Location = new System.Drawing.Point(65, 489);
            this.cmbThoiGian.Name = "cmbThoiGian";
            this.cmbThoiGian.ShadowDecoration.Parent = this.cmbThoiGian;
            this.cmbThoiGian.Size = new System.Drawing.Size(281, 36);
            this.cmbThoiGian.TabIndex = 8;
            // 
            // txtThoiHan
            // 
            this.txtThoiHan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThoiHan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtThoiHan.ForeColor = System.Drawing.Color.Black;
            this.txtThoiHan.HintForeColor = System.Drawing.Color.Empty;
            this.txtThoiHan.HintText = "";
            this.txtThoiHan.isPassword = false;
            this.txtThoiHan.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtThoiHan.LineIdleColor = System.Drawing.Color.Brown;
            this.txtThoiHan.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtThoiHan.LineThickness = 3;
            this.txtThoiHan.Location = new System.Drawing.Point(63, 427);
            this.txtThoiHan.Margin = new System.Windows.Forms.Padding(4);
            this.txtThoiHan.Name = "txtThoiHan";
            this.txtThoiHan.Size = new System.Drawing.Size(283, 33);
            this.txtThoiHan.TabIndex = 9;
            this.txtThoiHan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnUpdate
            // 
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.Brown;
            this.btnUpdate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Snow;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(27, 559);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(113, 34);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Cập Nhật";
            // 
            // btnDelete
            // 
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.Brown;
            this.btnDelete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Snow;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(162, 559);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(113, 34);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xoá";
            // 
            // btnReset
            // 
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.btnReset.FillColor = System.Drawing.Color.Brown;
            this.btnReset.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Snow;
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Location = new System.Drawing.Point(296, 559);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(113, 34);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            // 
            // btnBack
            // 
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.FillColor = System.Drawing.Color.Brown;
            this.btnBack.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Snow;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Location = new System.Drawing.Point(162, 609);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(113, 34);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            // 
            // UpdateAndDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 653);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtThoiHan);
            this.Controls.Add(this.cmbThoiGian);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.dgvThanhVien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UpdateAndDelete";
            this.Text = "UpdateAndDelete";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateAndDelete_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThoiHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThoiGian;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtHoTen;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSDT;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbThoiGian;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtThoiHan;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdate;
        private Guna.UI2.WinForms.Guna2GradientButton btnDelete;
        private Guna.UI2.WinForms.Guna2GradientButton btnReset;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
    }
}