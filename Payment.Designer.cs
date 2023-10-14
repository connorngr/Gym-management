namespace Gym_management
{
    partial class Payment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labHeader = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labExit = new System.Windows.Forms.Label();
            this.amounttb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labPeriode = new System.Windows.Forms.Label();
            this.labNum = new System.Windows.Forms.Label();
            this.butRefresh = new System.Windows.Forms.Button();
            this.butPayment = new System.Windows.Forms.Button();
            this.butExitOfpayment = new System.Windows.Forms.Button();
            this.labAmount = new System.Windows.Forms.Label();
            this.Periode = new System.Windows.Forms.DateTimePicker();
            this.numcb = new System.Windows.Forms.ComboBox();
            this.dgvPayment = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.butFind = new System.Windows.Forms.Button();
            this.searchPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.butShowAll = new System.Windows.Forms.Button();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labHeader
            // 
            this.labHeader.AutoSize = true;
            this.labHeader.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHeader.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labHeader.Location = new System.Drawing.Point(335, 9);
            this.labHeader.Name = "labHeader";
            this.labHeader.Size = new System.Drawing.Size(304, 36);
            this.labHeader.TabIndex = 2;
            this.labHeader.Text = "TRUNG TÂM THỂ LỰC";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labName.Location = new System.Drawing.Point(392, 50);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(163, 28);
            this.labName.TabIndex = 3;
            this.labName.Text = "THANH TOÁN";
            // 
            // labExit
            // 
            this.labExit.AutoSize = true;
            this.labExit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labExit.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labExit.Location = new System.Drawing.Point(922, 9);
            this.labExit.Name = "labExit";
            this.labExit.Size = new System.Drawing.Size(28, 28);
            this.labExit.TabIndex = 4;
            this.labExit.Text = "X";
            this.labExit.Click += new System.EventHandler(this.labExit_Click);
            // 
            // amounttb
            // 
            this.amounttb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amounttb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amounttb.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.amounttb.HintForeColor = System.Drawing.Color.Empty;
            this.amounttb.HintText = "";
            this.amounttb.isPassword = false;
            this.amounttb.LineFocusedColor = System.Drawing.Color.Blue;
            this.amounttb.LineIdleColor = System.Drawing.Color.LightGreen;
            this.amounttb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.amounttb.LineThickness = 4;
            this.amounttb.Location = new System.Drawing.Point(38, 429);
            this.amounttb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.amounttb.Name = "amounttb";
            this.amounttb.Size = new System.Drawing.Size(196, 48);
            this.amounttb.TabIndex = 6;
            this.amounttb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.amounttb.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // labPeriode
            // 
            this.labPeriode.AutoSize = true;
            this.labPeriode.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPeriode.ForeColor = System.Drawing.Color.LightGreen;
            this.labPeriode.Location = new System.Drawing.Point(34, 222);
            this.labPeriode.Name = "labPeriode";
            this.labPeriode.Size = new System.Drawing.Size(174, 23);
            this.labPeriode.TabIndex = 7;
            this.labPeriode.Text = "Thanh Toán Tháng";
            // 
            // labNum
            // 
            this.labNum.AutoSize = true;
            this.labNum.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNum.ForeColor = System.Drawing.Color.LightGreen;
            this.labNum.Location = new System.Drawing.Point(34, 307);
            this.labNum.Name = "labNum";
            this.labNum.Size = new System.Drawing.Size(123, 23);
            this.labNum.TabIndex = 8;
            this.labNum.Text = "Số điện thoại";
            // 
            // butRefresh
            // 
            this.butRefresh.BackColor = System.Drawing.Color.LightSeaGreen;
            this.butRefresh.FlatAppearance.BorderSize = 0;
            this.butRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRefresh.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRefresh.ForeColor = System.Drawing.Color.White;
            this.butRefresh.Location = new System.Drawing.Point(146, 516);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(129, 31);
            this.butRefresh.TabIndex = 9;
            this.butRefresh.Text = "Làm mới";
            this.butRefresh.UseVisualStyleBackColor = false;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // butPayment
            // 
            this.butPayment.BackColor = System.Drawing.Color.LightSeaGreen;
            this.butPayment.FlatAppearance.BorderSize = 0;
            this.butPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPayment.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPayment.ForeColor = System.Drawing.Color.White;
            this.butPayment.Location = new System.Drawing.Point(11, 516);
            this.butPayment.Name = "butPayment";
            this.butPayment.Size = new System.Drawing.Size(129, 31);
            this.butPayment.TabIndex = 10;
            this.butPayment.Text = "Thanh toán";
            this.butPayment.UseVisualStyleBackColor = false;
            this.butPayment.Click += new System.EventHandler(this.butPayment_Click);
            // 
            // butExitOfpayment
            // 
            this.butExitOfpayment.BackColor = System.Drawing.Color.LightSeaGreen;
            this.butExitOfpayment.FlatAppearance.BorderSize = 0;
            this.butExitOfpayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butExitOfpayment.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExitOfpayment.ForeColor = System.Drawing.Color.White;
            this.butExitOfpayment.Location = new System.Drawing.Point(79, 565);
            this.butExitOfpayment.Name = "butExitOfpayment";
            this.butExitOfpayment.Size = new System.Drawing.Size(129, 31);
            this.butExitOfpayment.TabIndex = 11;
            this.butExitOfpayment.Text = "Trở lại";
            this.butExitOfpayment.UseVisualStyleBackColor = false;
            this.butExitOfpayment.Click += new System.EventHandler(this.butExitOfpayment_Click);
            // 
            // labAmount
            // 
            this.labAmount.AutoSize = true;
            this.labAmount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAmount.ForeColor = System.Drawing.Color.LightGreen;
            this.labAmount.Location = new System.Drawing.Point(34, 406);
            this.labAmount.Name = "labAmount";
            this.labAmount.Size = new System.Drawing.Size(174, 23);
            this.labAmount.TabIndex = 13;
            this.labAmount.Text = "Thanh Toán Tháng";
            // 
            // Periode
            // 
            this.Periode.CustomFormat = "dd/MMMM/yyyy";
            this.Periode.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Periode.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Periode.Location = new System.Drawing.Point(38, 254);
            this.Periode.Name = "Periode";
            this.Periode.Size = new System.Drawing.Size(209, 31);
            this.Periode.TabIndex = 14;
            // 
            // numcb
            // 
            this.numcb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.numcb.FormattingEnabled = true;
            this.numcb.Location = new System.Drawing.Point(38, 347);
            this.numcb.Name = "numcb";
            this.numcb.Size = new System.Drawing.Size(209, 29);
            this.numcb.TabIndex = 17;
            this.numcb.SelectedIndexChanged += new System.EventHandler(this.numcb_SelectedIndexChanged);
            // 
            // dgvPayment
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPayment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayment.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvPayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.DoubleBuffered = true;
            this.dgvPayment.EnableHeadersVisualStyles = false;
            this.dgvPayment.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvPayment.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvPayment.Location = new System.Drawing.Point(314, 222);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPayment.Size = new System.Drawing.Size(602, 347);
            this.dgvPayment.TabIndex = 18;
            // 
            // butFind
            // 
            this.butFind.BackColor = System.Drawing.Color.LightSeaGreen;
            this.butFind.FlatAppearance.BorderSize = 0;
            this.butFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butFind.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFind.ForeColor = System.Drawing.Color.White;
            this.butFind.Location = new System.Drawing.Point(605, 183);
            this.butFind.Name = "butFind";
            this.butFind.Size = new System.Drawing.Size(129, 31);
            this.butFind.TabIndex = 20;
            this.butFind.Text = "Tìm kiếm";
            this.butFind.UseVisualStyleBackColor = false;
            this.butFind.Click += new System.EventHandler(this.butFind_Click);
            // 
            // searchPhone
            // 
            this.searchPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPhone.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.searchPhone.HintForeColor = System.Drawing.Color.Empty;
            this.searchPhone.HintText = "";
            this.searchPhone.isPassword = false;
            this.searchPhone.LineFocusedColor = System.Drawing.Color.Blue;
            this.searchPhone.LineIdleColor = System.Drawing.Color.LightGreen;
            this.searchPhone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.searchPhone.LineThickness = 4;
            this.searchPhone.Location = new System.Drawing.Point(341, 166);
            this.searchPhone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.searchPhone.Name = "searchPhone";
            this.searchPhone.Size = new System.Drawing.Size(267, 48);
            this.searchPhone.TabIndex = 21;
            this.searchPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // butShowAll
            // 
            this.butShowAll.BackColor = System.Drawing.Color.LightSeaGreen;
            this.butShowAll.FlatAppearance.BorderSize = 0;
            this.butShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butShowAll.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butShowAll.ForeColor = System.Drawing.Color.White;
            this.butShowAll.Location = new System.Drawing.Point(749, 183);
            this.butShowAll.Name = "butShowAll";
            this.butShowAll.Size = new System.Drawing.Size(137, 31);
            this.butShowAll.TabIndex = 22;
            this.butShowAll.Text = "Hiển thị tất cả";
            this.butShowAll.UseVisualStyleBackColor = false;
            this.butShowAll.Click += new System.EventHandler(this.butShowAll_Click);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::Gym_management.Properties.Resources.dollar;
            this.pictureBoxIcon.Location = new System.Drawing.Point(430, 84);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(85, 69);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 5;
            this.pictureBoxIcon.TabStop = false;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 600);
            this.Controls.Add(this.butShowAll);
            this.Controls.Add(this.searchPhone);
            this.Controls.Add(this.butFind);
            this.Controls.Add(this.dgvPayment);
            this.Controls.Add(this.numcb);
            this.Controls.Add(this.Periode);
            this.Controls.Add(this.labAmount);
            this.Controls.Add(this.butExitOfpayment);
            this.Controls.Add(this.butPayment);
            this.Controls.Add(this.butRefresh);
            this.Controls.Add(this.labNum);
            this.Controls.Add(this.labPeriode);
            this.Controls.Add(this.amounttb);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.labExit);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labHeader;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labExit;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private Bunifu.Framework.UI.BunifuMaterialTextbox amounttb;
        private System.Windows.Forms.Label labPeriode;
        private System.Windows.Forms.Label labNum;
        private System.Windows.Forms.Button butRefresh;
        private System.Windows.Forms.Button butPayment;
        private System.Windows.Forms.Button butExitOfpayment;
        private System.Windows.Forms.Label labAmount;
        private System.Windows.Forms.DateTimePicker Periode;
        private System.Windows.Forms.ComboBox numcb;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvPayment;
        private System.Windows.Forms.Button butFind;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchPhone;
        private System.Windows.Forms.Button butShowAll;
    }
}