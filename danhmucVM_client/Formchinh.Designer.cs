﻿namespace danhmucVM_client
{
    partial class Formchinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formchinh));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbngayban = new System.Windows.Forms.Label();
            this.lbmotasanpham = new System.Windows.Forms.Label();
            this.lbdatrunghaychua = new System.Windows.Forms.Label();
            this.lbduocbanhaychua = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmatong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datag1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbtrangthai = new System.Windows.Forms.Label();
            this.lbbaomail = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXuatIn = new System.Windows.Forms.Button();
            this.lbmahang = new System.Windows.Forms.Label();
            this.btnchuatrunghang = new System.Windows.Forms.Button();
            this.btndatrunghang = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbtongma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbphatanh = new System.Windows.Forms.PictureBox();
            this.pbAMTHANH = new System.Windows.Forms.PictureBox();
            this.pbanhsanpham = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxoamatong = new System.Windows.Forms.PictureBox();
            this.nuthts_trung = new danhmucVM_client.nuthts();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datag1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbphatanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAMTHANH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbanhsanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxoamatong)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1111, 15);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // txtbarcode
            // 
            this.txtbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbarcode.Location = new System.Drawing.Point(165, 16);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(277, 26);
            this.txtbarcode.TabIndex = 3;
            this.txtbarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbarcode_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pbxoamatong);
            this.groupBox1.Controls.Add(this.lbngayban);
            this.groupBox1.Controls.Add(this.lbmotasanpham);
            this.groupBox1.Controls.Add(this.lbdatrunghaychua);
            this.groupBox1.Controls.Add(this.lbduocbanhaychua);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtmatong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbarcode);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1088, 165);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // lbngayban
            // 
            this.lbngayban.BackColor = System.Drawing.Color.White;
            this.lbngayban.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngayban.ForeColor = System.Drawing.Color.Tomato;
            this.lbngayban.Location = new System.Drawing.Point(448, 12);
            this.lbngayban.Name = "lbngayban";
            this.lbngayban.Size = new System.Drawing.Size(342, 70);
            this.lbngayban.TabIndex = 4;
            this.lbngayban.Text = "Ngày bán";
            this.lbngayban.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbmotasanpham
            // 
            this.lbmotasanpham.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbmotasanpham.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmotasanpham.ForeColor = System.Drawing.Color.DimGray;
            this.lbmotasanpham.Location = new System.Drawing.Point(7, 82);
            this.lbmotasanpham.Name = "lbmotasanpham";
            this.lbmotasanpham.Size = new System.Drawing.Size(783, 79);
            this.lbmotasanpham.TabIndex = 4;
            this.lbmotasanpham.Text = "Mô tả sản phẩm";
            this.lbmotasanpham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbdatrunghaychua
            // 
            this.lbdatrunghaychua.BackColor = System.Drawing.Color.BlueViolet;
            this.lbdatrunghaychua.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdatrunghaychua.ForeColor = System.Drawing.SystemColors.Control;
            this.lbdatrunghaychua.Location = new System.Drawing.Point(796, 89);
            this.lbdatrunghaychua.Name = "lbdatrunghaychua";
            this.lbdatrunghaychua.Size = new System.Drawing.Size(280, 70);
            this.lbdatrunghaychua.TabIndex = 4;
            this.lbdatrunghaychua.Text = "Trưng ?";
            this.lbdatrunghaychua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbduocbanhaychua
            // 
            this.lbduocbanhaychua.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbduocbanhaychua.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbduocbanhaychua.ForeColor = System.Drawing.SystemColors.Control;
            this.lbduocbanhaychua.Location = new System.Drawing.Point(796, 13);
            this.lbduocbanhaychua.Name = "lbduocbanhaychua";
            this.lbduocbanhaychua.Size = new System.Drawing.Size(280, 70);
            this.lbduocbanhaychua.TabIndex = 4;
            this.lbduocbanhaychua.Text = "Bán ?";
            this.lbduocbanhaychua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tìm theo mã tổng:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtmatong
            // 
            this.txtmatong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatong.Location = new System.Drawing.Point(165, 51);
            this.txtmatong.Name = "txtmatong";
            this.txtmatong.Size = new System.Drawing.Size(277, 26);
            this.txtmatong.TabIndex = 3;
            this.txtmatong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtmatong.TextChanged += new System.EventHandler(this.txtmatong_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tìm theo Barcode:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datag1
            // 
            this.datag1.AllowUserToAddRows = false;
            this.datag1.AllowUserToDeleteRows = false;
            this.datag1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datag1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.datag1.BackgroundColor = System.Drawing.Color.White;
            this.datag1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datag1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datag1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datag1.DefaultCellStyle = dataGridViewCellStyle2;
            this.datag1.Location = new System.Drawing.Point(18, 243);
            this.datag1.Name = "datag1";
            this.datag1.RowHeadersVisible = false;
            this.datag1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datag1.Size = new System.Drawing.Size(982, 411);
            this.datag1.TabIndex = 6;
            this.datag1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datag1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pbAMTHANH);
            this.panel1.Controls.Add(this.lbtrangthai);
            this.panel1.Controls.Add(this.lbbaomail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 663);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 28);
            this.panel1.TabIndex = 11;
            // 
            // lbtrangthai
            // 
            this.lbtrangthai.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtrangthai.ForeColor = System.Drawing.Color.Crimson;
            this.lbtrangthai.Location = new System.Drawing.Point(104, 5);
            this.lbtrangthai.Name = "lbtrangthai";
            this.lbtrangthai.Size = new System.Drawing.Size(1176, 20);
            this.lbtrangthai.TabIndex = 0;
            this.lbtrangthai.Text = "---hts---";
            // 
            // lbbaomail
            // 
            this.lbbaomail.AutoSize = true;
            this.lbbaomail.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbaomail.Location = new System.Drawing.Point(17, 6);
            this.lbbaomail.Name = "lbbaomail";
            this.lbbaomail.Size = new System.Drawing.Size(62, 15);
            this.lbbaomail.TabIndex = 0;
            this.lbbaomail.Text = "Thông báo:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(201, 42);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chọn khoảng thời gian cần in";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnXuatIn);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Location = new System.Drawing.Point(1006, 539);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 120);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // btnXuatIn
            // 
            this.btnXuatIn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnXuatIn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatIn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXuatIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatIn.Location = new System.Drawing.Point(6, 68);
            this.btnXuatIn.Name = "btnXuatIn";
            this.btnXuatIn.Size = new System.Drawing.Size(320, 47);
            this.btnXuatIn.TabIndex = 14;
            this.btnXuatIn.Text = "Xuất file Excel và In";
            this.btnXuatIn.UseVisualStyleBackColor = false;
            this.btnXuatIn.Click += new System.EventHandler(this.btnXuatIn_Click);
            // 
            // lbmahang
            // 
            this.lbmahang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbmahang.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmahang.ForeColor = System.Drawing.Color.Crimson;
            this.lbmahang.Location = new System.Drawing.Point(1006, 186);
            this.lbmahang.Name = "lbmahang";
            this.lbmahang.Size = new System.Drawing.Size(332, 35);
            this.lbmahang.TabIndex = 4;
            this.lbmahang.Text = "Mã hàng";
            this.lbmahang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnchuatrunghang
            // 
            this.btnchuatrunghang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnchuatrunghang.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchuatrunghang.ForeColor = System.Drawing.Color.Purple;
            this.btnchuatrunghang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnchuatrunghang.Location = new System.Drawing.Point(359, 13);
            this.btnchuatrunghang.Name = "btnchuatrunghang";
            this.btnchuatrunghang.Size = new System.Drawing.Size(167, 41);
            this.btnchuatrunghang.TabIndex = 6;
            this.btnchuatrunghang.Text = "Chưa trưng";
            this.btnchuatrunghang.UseVisualStyleBackColor = false;
            this.btnchuatrunghang.Click += new System.EventHandler(this.btnchuatrunghang_Click);
            // 
            // btndatrunghang
            // 
            this.btndatrunghang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btndatrunghang.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndatrunghang.ForeColor = System.Drawing.Color.Navy;
            this.btndatrunghang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndatrunghang.Location = new System.Drawing.Point(39, 14);
            this.btndatrunghang.Name = "btndatrunghang";
            this.btndatrunghang.Size = new System.Drawing.Size(166, 41);
            this.btndatrunghang.TabIndex = 6;
            this.btndatrunghang.Text = "Đã trưng";
            this.btndatrunghang.UseVisualStyleBackColor = false;
            this.btndatrunghang.Click += new System.EventHandler(this.btndatrunghang_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btndatrunghang);
            this.groupBox3.Controls.Add(this.btnchuatrunghang);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(455, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(545, 61);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update mã chọn vào danh sách đã trưng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbtongma);
            this.groupBox4.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(18, 176);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(163, 61);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tổng mã";
            // 
            // lbtongma
            // 
            this.lbtongma.BackColor = System.Drawing.Color.White;
            this.lbtongma.Font = new System.Drawing.Font("Comic Sans MS", 21F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtongma.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbtongma.Location = new System.Drawing.Point(20, 16);
            this.lbtongma.Name = "lbtongma";
            this.lbtongma.Size = new System.Drawing.Size(113, 38);
            this.lbtongma.TabIndex = 0;
            this.lbtongma.Text = "0";
            this.lbtongma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm các mã chưa trưng:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbphatanh
            // 
            this.pbphatanh.Image = global::danhmucVM_client.Properties.Resources.pause;
            this.pbphatanh.Location = new System.Drawing.Point(1147, 222);
            this.pbphatanh.Name = "pbphatanh";
            this.pbphatanh.Size = new System.Drawing.Size(47, 33);
            this.pbphatanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbphatanh.TabIndex = 16;
            this.pbphatanh.TabStop = false;
            this.pbphatanh.Click += new System.EventHandler(this.pbphatanh_Click);
            // 
            // pbAMTHANH
            // 
            this.pbAMTHANH.Image = global::danhmucVM_client.Properties.Resources.speaker;
            this.pbAMTHANH.Location = new System.Drawing.Point(1294, 0);
            this.pbAMTHANH.Name = "pbAMTHANH";
            this.pbAMTHANH.Size = new System.Drawing.Size(38, 28);
            this.pbAMTHANH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAMTHANH.TabIndex = 2;
            this.pbAMTHANH.TabStop = false;
            this.pbAMTHANH.Click += new System.EventHandler(this.pbAMTHANH_Click);
            // 
            // pbanhsanpham
            // 
            this.pbanhsanpham.Location = new System.Drawing.Point(1006, 257);
            this.pbanhsanpham.Name = "pbanhsanpham";
            this.pbanhsanpham.Size = new System.Drawing.Size(332, 281);
            this.pbanhsanpham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbanhsanpham.TabIndex = 7;
            this.pbanhsanpham.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(169, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pbxoamatong
            // 
            this.pbxoamatong.Image = ((System.Drawing.Image)(resources.GetObject("pbxoamatong.Image")));
            this.pbxoamatong.Location = new System.Drawing.Point(169, 54);
            this.pbxoamatong.Name = "pbxoamatong";
            this.pbxoamatong.Size = new System.Drawing.Size(23, 22);
            this.pbxoamatong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxoamatong.TabIndex = 5;
            this.pbxoamatong.TabStop = false;
            this.pbxoamatong.Click += new System.EventHandler(this.pbxoamatong_Click);
            // 
            // nuthts_trung
            // 
            this.nuthts_trung.AutoSize = true;
            this.nuthts_trung.Location = new System.Drawing.Point(360, 195);
            this.nuthts_trung.Name = "nuthts_trung";
            this.nuthts_trung.Padding = new System.Windows.Forms.Padding(6);
            this.nuthts_trung.Size = new System.Drawing.Size(73, 29);
            this.nuthts_trung.TabIndex = 19;
            this.nuthts_trung.Text = "nuthts1";
            this.nuthts_trung.UseVisualStyleBackColor = true;
            this.nuthts_trung.CheckedChanged += new System.EventHandler(this.nuthts_trung_CheckedChanged);
            // 
            // Formchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 691);
            this.Controls.Add(this.nuthts_trung);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pbphatanh);
            this.Controls.Add(this.lbmahang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbanhsanpham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datag1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Formchinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Up Hàng";
            this.Load += new System.EventHandler(this.Formchinh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datag1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbphatanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAMTHANH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbanhsanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxoamatong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView datag1;
        private System.Windows.Forms.Label lbmotasanpham;
        private System.Windows.Forms.Label lbduocbanhaychua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbanhsanpham;
        private System.Windows.Forms.Label lbdatrunghaychua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmatong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbbaomail;
        private System.Windows.Forms.Label lbtrangthai;
        private System.Windows.Forms.Label lbngayban;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnXuatIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbmahang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbxoamatong;
        private System.Windows.Forms.Button btndatrunghang;
        private System.Windows.Forms.Button btnchuatrunghang;
        private System.Windows.Forms.PictureBox pbphatanh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbtongma;
        private System.Windows.Forms.PictureBox pbAMTHANH;
        private nuthts nuthts_trung;
        private System.Windows.Forms.Label label1;
    }
}

