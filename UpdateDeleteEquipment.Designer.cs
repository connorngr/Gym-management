namespace Gym_management
{
    partial class UpdateDeleteEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDeleteEquipment));
            this.DTP = new Guna.UI.WinForms.GunaDateTimePicker();
            this.labExit = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCondition = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.EquipmentGrid = new Guna.UI.WinForms.GunaDataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBack = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DTP
            // 
            this.DTP.BaseColor = System.Drawing.Color.White;
            this.DTP.BorderColor = System.Drawing.Color.Silver;
            this.DTP.CustomFormat = null;
            this.DTP.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DTP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP.ForeColor = System.Drawing.Color.Black;
            this.DTP.Location = new System.Drawing.Point(27, 261);
            this.DTP.Margin = new System.Windows.Forms.Padding(2);
            this.DTP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTP.Name = "DTP";
            this.DTP.OnHoverBaseColor = System.Drawing.Color.White;
            this.DTP.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DTP.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DTP.OnPressedColor = System.Drawing.Color.Black;
            this.DTP.Size = new System.Drawing.Size(219, 37);
            this.DTP.TabIndex = 62;
            this.DTP.Text = "Monday, October 16, 2023";
            this.DTP.Value = new System.DateTime(2023, 10, 16, 10, 8, 10, 72);
            // 
            // labExit
            // 
            this.labExit.AutoSize = true;
            this.labExit.BackColor = System.Drawing.SystemColors.Control;
            this.labExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labExit.ForeColor = System.Drawing.Color.DarkBlue;
            this.labExit.Location = new System.Drawing.Point(958, 9);
            this.labExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labExit.Name = "labExit";
            this.labExit.Size = new System.Drawing.Size(28, 26);
            this.labExit.TabIndex = 61;
            this.labExit.Text = "X";
            // 
            // cmbLocation
            // 
            this.cmbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Items.AddRange(new object[] {
            "shelf number 1",
            "shelf number 2",
            "shelf number 3"});
            this.cmbLocation.Location = new System.Drawing.Point(125, 353);
            this.cmbLocation.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(157, 25);
            this.cmbLocation.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(24, 358);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 59;
            this.label10.Text = "Location";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(24, 239);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 58;
            this.label9.Text = "Purchase Date";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "Equipment\'s name";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtName.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtName.LineThickness = 4;
            this.txtName.Location = new System.Drawing.Point(27, 175);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(255, 46);
            this.txtName.TabIndex = 57;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(23, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Name";
            // 
            // cmbCondition
            // 
            this.cmbCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCondition.FormattingEnabled = true;
            this.cmbCondition.Items.AddRange(new object[] {
            "New",
            "Old"});
            this.cmbCondition.Location = new System.Drawing.Point(125, 315);
            this.cmbCondition.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(157, 25);
            this.cmbCondition.TabIndex = 55;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuantity.HintForeColor = System.Drawing.Color.Empty;
            this.txtQuantity.HintText = "Equipment\'s quantity";
            this.txtQuantity.isPassword = false;
            this.txtQuantity.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtQuantity.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtQuantity.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtQuantity.LineThickness = 4;
            this.txtQuantity.Location = new System.Drawing.Point(27, 421);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(222, 44);
            this.txtQuantity.TabIndex = 53;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.HintForeColor = System.Drawing.Color.Empty;
            this.txtPrice.HintText = "Equipment\'s price";
            this.txtPrice.isPassword = false;
            this.txtPrice.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrice.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtPrice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrice.LineThickness = 4;
            this.txtPrice.Location = new System.Drawing.Point(22, 503);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(222, 46);
            this.txtPrice.TabIndex = 54;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(23, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Condition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(23, 397);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(24, 479);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(23, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Group AAA - GYM management tool";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(441, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 26);
            this.label1.TabIndex = 48;
            this.label1.Text = "Update and delete";
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID.HintForeColor = System.Drawing.Color.Empty;
            this.txtID.HintText = "Equipment\'s ID";
            this.txtID.isPassword = false;
            this.txtID.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtID.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtID.LineThickness = 4;
            this.txtID.Location = new System.Drawing.Point(28, 95);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(255, 46);
            this.txtID.TabIndex = 64;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EquipmentGrid
            // 
            this.EquipmentGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EquipmentGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EquipmentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EquipmentGrid.BackgroundColor = System.Drawing.Color.White;
            this.EquipmentGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EquipmentGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EquipmentGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EquipmentGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EquipmentGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EquipmentGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.EquipmentGrid.EnableHeadersVisualStyles = false;
            this.EquipmentGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EquipmentGrid.Location = new System.Drawing.Point(307, 122);
            this.EquipmentGrid.Margin = new System.Windows.Forms.Padding(2);
            this.EquipmentGrid.Name = "EquipmentGrid";
            this.EquipmentGrid.ReadOnly = true;
            this.EquipmentGrid.RowHeadersVisible = false;
            this.EquipmentGrid.RowHeadersWidth = 51;
            this.EquipmentGrid.RowTemplate.Height = 28;
            this.EquipmentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EquipmentGrid.Size = new System.Drawing.Size(679, 526);
            this.EquipmentGrid.TabIndex = 66;
            this.EquipmentGrid.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.EquipmentGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EquipmentGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EquipmentGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EquipmentGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EquipmentGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EquipmentGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EquipmentGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EquipmentGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EquipmentGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EquipmentGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipmentGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EquipmentGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EquipmentGrid.ThemeStyle.HeaderStyle.Height = 30;
            this.EquipmentGrid.ThemeStyle.ReadOnly = true;
            this.EquipmentGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EquipmentGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EquipmentGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipmentGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EquipmentGrid.ThemeStyle.RowsStyle.Height = 28;
            this.EquipmentGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EquipmentGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(541, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 20);
            this.label8.TabIndex = 65;
            this.label8.Text = "Select equipment to delete";
            // 
            // btnBack
            // 
            this.btnBack.ActiveBorderThickness = 1;
            this.btnBack.ActiveCornerRadius = 20;
            this.btnBack.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.btnBack.ActiveForecolor = System.Drawing.Color.White;
            this.btnBack.ActiveLineColor = System.Drawing.Color.Snow;
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.ButtonText = "Back";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnBack.IdleBorderThickness = 1;
            this.btnBack.IdleCornerRadius = 20;
            this.btnBack.IdleFillColor = System.Drawing.Color.White;
            this.btnBack.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.btnBack.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.btnBack.Location = new System.Drawing.Point(84, 617);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 48);
            this.btnBack.TabIndex = 67;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDel
            // 
            this.btnDel.ActiveBorderThickness = 1;
            this.btnDel.ActiveCornerRadius = 20;
            this.btnDel.ActiveFillColor = System.Drawing.Color.Crimson;
            this.btnDel.ActiveForecolor = System.Drawing.Color.White;
            this.btnDel.ActiveLineColor = System.Drawing.Color.Snow;
            this.btnDel.BackColor = System.Drawing.SystemColors.Control;
            this.btnDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDel.BackgroundImage")));
            this.btnDel.ButtonText = "Delete";
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.Crimson;
            this.btnDel.IdleBorderThickness = 1;
            this.btnDel.IdleCornerRadius = 20;
            this.btnDel.IdleFillColor = System.Drawing.Color.White;
            this.btnDel.IdleForecolor = System.Drawing.Color.Crimson;
            this.btnDel.IdleLineColor = System.Drawing.Color.Crimson;
            this.btnDel.Location = new System.Drawing.Point(24, 568);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(89, 48);
            this.btnDel.TabIndex = 68;
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.ActiveBorderThickness = 1;
            this.BtnUpdate.ActiveCornerRadius = 20;
            this.BtnUpdate.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdate.ActiveForecolor = System.Drawing.Color.White;
            this.BtnUpdate.ActiveLineColor = System.Drawing.Color.Snow;
            this.BtnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.BtnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.BackgroundImage")));
            this.BtnUpdate.ButtonText = "Update";
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdate.IdleBorderThickness = 1;
            this.BtnUpdate.IdleCornerRadius = 20;
            this.BtnUpdate.IdleFillColor = System.Drawing.Color.White;
            this.BtnUpdate.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnUpdate.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdate.Location = new System.Drawing.Point(141, 568);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(89, 48);
            this.BtnUpdate.TabIndex = 69;
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateDeleteEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 680);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.EquipmentGrid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTP);
            this.Controls.Add(this.labExit);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCondition);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateDeleteEquipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateDeleteEquipment";
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaDateTimePicker DTP;
        private System.Windows.Forms.Label labExit;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCondition;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtQuantity;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtID;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaDataGridView EquipmentGrid;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBack;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDel;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnUpdate;
    }
}