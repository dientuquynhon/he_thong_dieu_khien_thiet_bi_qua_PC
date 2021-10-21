namespace InterfacePC
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNgatKetNoi = new System.Windows.Forms.Button();
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.cbxTenCongCom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxGuiDuLieu = new System.Windows.Forms.GroupBox();
            this.btnSetLight = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txbValueLight = new System.Windows.Forms.TextBox();
            this.btnSetHump = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbValueHump = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSetTemp = new System.Windows.Forms.Button();
            this.txbValueTemp = new System.Windows.Forms.TextBox();
            this.txbNhanDuLieu = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miXoaDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.gbxDevice = new System.Windows.Forms.GroupBox();
            this.btnDevice5 = new System.Windows.Forms.Button();
            this.btnDevice4 = new System.Windows.Forms.Button();
            this.btnDevice3 = new System.Windows.Forms.Button();
            this.btnDevice2 = new System.Windows.Forms.Button();
            this.btnDevice1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gbxControl = new System.Windows.Forms.GroupBox();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbxGuiDuLieu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.gbxDevice.SuspendLayout();
            this.gbxControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNgatKetNoi);
            this.groupBox1.Controls.Add(this.btnKetNoi);
            this.groupBox1.Controls.Add(this.cbxTenCongCom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cài đặt COM";
            // 
            // btnNgatKetNoi
            // 
            this.btnNgatKetNoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNgatKetNoi.Enabled = false;
            this.btnNgatKetNoi.Location = new System.Drawing.Point(135, 72);
            this.btnNgatKetNoi.Name = "btnNgatKetNoi";
            this.btnNgatKetNoi.Size = new System.Drawing.Size(118, 35);
            this.btnNgatKetNoi.TabIndex = 3;
            this.btnNgatKetNoi.Text = "Ngắt Kết Nối";
            this.btnNgatKetNoi.UseVisualStyleBackColor = true;
            this.btnNgatKetNoi.Click += new System.EventHandler(this.btnNgatKetNoi_Click);
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKetNoi.Location = new System.Drawing.Point(11, 72);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(118, 35);
            this.btnKetNoi.TabIndex = 2;
            this.btnKetNoi.Text = "Kết Nối";
            this.btnKetNoi.UseVisualStyleBackColor = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // cbxTenCongCom
            // 
            this.cbxTenCongCom.FormattingEnabled = true;
            this.cbxTenCongCom.Location = new System.Drawing.Point(114, 18);
            this.cbxTenCongCom.Name = "cbxTenCongCom";
            this.cbxTenCongCom.Size = new System.Drawing.Size(139, 28);
            this.cbxTenCongCom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cổng Com";
            // 
            // gbxGuiDuLieu
            // 
            this.gbxGuiDuLieu.Controls.Add(this.btnSetLight);
            this.gbxGuiDuLieu.Controls.Add(this.label16);
            this.gbxGuiDuLieu.Controls.Add(this.label15);
            this.gbxGuiDuLieu.Controls.Add(this.txbValueLight);
            this.gbxGuiDuLieu.Controls.Add(this.btnSetHump);
            this.gbxGuiDuLieu.Controls.Add(this.label14);
            this.gbxGuiDuLieu.Controls.Add(this.label13);
            this.gbxGuiDuLieu.Controls.Add(this.label7);
            this.gbxGuiDuLieu.Controls.Add(this.txbValueHump);
            this.gbxGuiDuLieu.Controls.Add(this.label8);
            this.gbxGuiDuLieu.Controls.Add(this.btnSetTemp);
            this.gbxGuiDuLieu.Controls.Add(this.txbValueTemp);
            this.gbxGuiDuLieu.Enabled = false;
            this.gbxGuiDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGuiDuLieu.Location = new System.Drawing.Point(276, 316);
            this.gbxGuiDuLieu.Name = "gbxGuiDuLieu";
            this.gbxGuiDuLieu.Size = new System.Drawing.Size(598, 100);
            this.gbxGuiDuLieu.TabIndex = 1;
            this.gbxGuiDuLieu.TabStop = false;
            this.gbxGuiDuLieu.Text = "Cài đặt";
            // 
            // btnSetLight
            // 
            this.btnSetLight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetLight.Location = new System.Drawing.Point(465, 54);
            this.btnSetLight.Name = "btnSetLight";
            this.btnSetLight.Size = new System.Drawing.Size(94, 27);
            this.btnSetLight.TabIndex = 17;
            this.btnSetLight.Text = "Cài đặt";
            this.btnSetLight.UseVisualStyleBackColor = true;
            this.btnSetLight.Click += new System.EventHandler(this.btnSetLight_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(559, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 20);
            this.label16.TabIndex = 16;
            this.label16.Text = "Lux";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(403, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 20);
            this.label15.TabIndex = 15;
            this.label15.Text = "A.Sáng";
            // 
            // txbValueLight
            // 
            this.txbValueLight.Location = new System.Drawing.Point(465, 19);
            this.txbValueLight.Name = "txbValueLight";
            this.txbValueLight.Size = new System.Drawing.Size(94, 26);
            this.txbValueLight.TabIndex = 14;
            // 
            // btnSetHump
            // 
            this.btnSetHump.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetHump.Location = new System.Drawing.Point(270, 54);
            this.btnSetHump.Name = "btnSetHump";
            this.btnSetHump.Size = new System.Drawing.Size(94, 27);
            this.btnSetHump.TabIndex = 13;
            this.btnSetHump.Text = "Cài đặt";
            this.btnSetHump.UseVisualStyleBackColor = true;
            this.btnSetHump.Click += new System.EventHandler(this.btnSetHump_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(215, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 20);
            this.label14.TabIndex = 12;
            this.label14.Text = "Đ.Ẩm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "N.Độ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "%";
            // 
            // txbValueHump
            // 
            this.txbValueHump.Location = new System.Drawing.Point(270, 19);
            this.txbValueHump.Name = "txbValueHump";
            this.txbValueHump.Size = new System.Drawing.Size(94, 26);
            this.txbValueHump.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "*C";
            // 
            // btnSetTemp
            // 
            this.btnSetTemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetTemp.Location = new System.Drawing.Point(75, 54);
            this.btnSetTemp.Name = "btnSetTemp";
            this.btnSetTemp.Size = new System.Drawing.Size(94, 27);
            this.btnSetTemp.TabIndex = 4;
            this.btnSetTemp.Text = "Cài đặt";
            this.btnSetTemp.UseVisualStyleBackColor = true;
            this.btnSetTemp.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // txbValueTemp
            // 
            this.txbValueTemp.Location = new System.Drawing.Point(75, 19);
            this.txbValueTemp.Name = "txbValueTemp";
            this.txbValueTemp.Size = new System.Drawing.Size(94, 26);
            this.txbValueTemp.TabIndex = 0;
            // 
            // txbNhanDuLieu
            // 
            this.txbNhanDuLieu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbNhanDuLieu.ContextMenuStrip = this.contextMenuStrip1;
            this.txbNhanDuLieu.Enabled = false;
            this.txbNhanDuLieu.ForeColor = System.Drawing.Color.White;
            this.txbNhanDuLieu.Location = new System.Drawing.Point(515, 45);
            this.txbNhanDuLieu.Multiline = true;
            this.txbNhanDuLieu.Name = "txbNhanDuLieu";
            this.txbNhanDuLieu.ReadOnly = true;
            this.txbNhanDuLieu.Size = new System.Drawing.Size(359, 204);
            this.txbNhanDuLieu.TabIndex = 2;
            this.txbNhanDuLieu.TextChanged += new System.EventHandler(this.txbNhanDuLieu_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miXoaDuLieu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 26);
            // 
            // miXoaDuLieu
            // 
            this.miXoaDuLieu.Name = "miXoaDuLieu";
            this.miXoaDuLieu.Size = new System.Drawing.Size(137, 22);
            this.miXoaDuLieu.Text = "Xóa Dữ Liệu";
            this.miXoaDuLieu.Click += new System.EventHandler(this.miXoaDuLieu_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(15, 142);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // gbxDevice
            // 
            this.gbxDevice.Controls.Add(this.btnDevice5);
            this.gbxDevice.Controls.Add(this.btnDevice4);
            this.gbxDevice.Controls.Add(this.btnDevice3);
            this.gbxDevice.Controls.Add(this.btnDevice2);
            this.gbxDevice.Controls.Add(this.btnDevice1);
            this.gbxDevice.Controls.Add(this.label6);
            this.gbxDevice.Controls.Add(this.label5);
            this.gbxDevice.Controls.Add(this.label4);
            this.gbxDevice.Controls.Add(this.label3);
            this.gbxDevice.Controls.Add(this.label2);
            this.gbxDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDevice.Location = new System.Drawing.Point(276, 12);
            this.gbxDevice.Name = "gbxDevice";
            this.gbxDevice.Size = new System.Drawing.Size(233, 291);
            this.gbxDevice.TabIndex = 4;
            this.gbxDevice.TabStop = false;
            this.gbxDevice.Text = "Điều khiển thiết bị";
            // 
            // btnDevice5
            // 
            this.btnDevice5.Location = new System.Drawing.Point(122, 235);
            this.btnDevice5.Name = "btnDevice5";
            this.btnDevice5.Size = new System.Drawing.Size(75, 31);
            this.btnDevice5.TabIndex = 9;
            this.btnDevice5.Text = "Bật TB5";
            this.btnDevice5.UseVisualStyleBackColor = true;
            this.btnDevice5.Click += new System.EventHandler(this.btnDevice5_Click_1);
            // 
            // btnDevice4
            // 
            this.btnDevice4.Location = new System.Drawing.Point(121, 187);
            this.btnDevice4.Name = "btnDevice4";
            this.btnDevice4.Size = new System.Drawing.Size(75, 31);
            this.btnDevice4.TabIndex = 8;
            this.btnDevice4.Text = "Bật TB4";
            this.btnDevice4.UseVisualStyleBackColor = true;
            this.btnDevice4.Click += new System.EventHandler(this.btnDevice4_Click_1);
            // 
            // btnDevice3
            // 
            this.btnDevice3.Location = new System.Drawing.Point(121, 137);
            this.btnDevice3.Name = "btnDevice3";
            this.btnDevice3.Size = new System.Drawing.Size(75, 31);
            this.btnDevice3.TabIndex = 7;
            this.btnDevice3.Text = "Bật TB3";
            this.btnDevice3.UseVisualStyleBackColor = true;
            this.btnDevice3.Click += new System.EventHandler(this.btnDevice3_Click_1);
            // 
            // btnDevice2
            // 
            this.btnDevice2.Location = new System.Drawing.Point(122, 85);
            this.btnDevice2.Name = "btnDevice2";
            this.btnDevice2.Size = new System.Drawing.Size(75, 31);
            this.btnDevice2.TabIndex = 6;
            this.btnDevice2.Text = "Bật TB2";
            this.btnDevice2.UseVisualStyleBackColor = true;
            this.btnDevice2.Click += new System.EventHandler(this.btnDevice2_Click_1);
            // 
            // btnDevice1
            // 
            this.btnDevice1.Location = new System.Drawing.Point(121, 38);
            this.btnDevice1.Name = "btnDevice1";
            this.btnDevice1.Size = new System.Drawing.Size(75, 31);
            this.btnDevice1.TabIndex = 5;
            this.btnDevice1.Text = "Bật TB1";
            this.btnDevice1.UseVisualStyleBackColor = true;
            this.btnDevice1.Click += new System.EventHandler(this.btnDevice1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Thiết bị 5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thiết bị 4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thiết bị 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thiết bị 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thiết bị 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(180, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(565, 27);
            this.label9.TabIndex = 5;
            this.label9.Text = "Hệ thống Giám sát và Điều khiển các thông số môi trường";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(673, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Giá trị nhận";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Thủ công";
            // 
            // gbxControl
            // 
            this.gbxControl.Controls.Add(this.btnAuto);
            this.gbxControl.Controls.Add(this.btnManual);
            this.gbxControl.Controls.Add(this.label12);
            this.gbxControl.Controls.Add(this.label11);
            this.gbxControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxControl.Location = new System.Drawing.Point(16, 316);
            this.gbxControl.Name = "gbxControl";
            this.gbxControl.Size = new System.Drawing.Size(241, 100);
            this.gbxControl.TabIndex = 9;
            this.gbxControl.TabStop = false;
            this.gbxControl.Text = "Chế độ điều khiển";
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(102, 64);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(75, 26);
            this.btnAuto.TabIndex = 10;
            this.btnAuto.Text = "Bật";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnManual
            // 
            this.btnManual.Location = new System.Drawing.Point(102, 30);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(75, 26);
            this.btnManual.TabIndex = 11;
            this.btnManual.Text = "Bật";
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Tự động";
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(515, 281);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(249, 23);
            this.txtSend.TabIndex = 10;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(799, 258);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(799, 295);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Xóa";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 457);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.gbxControl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gbxDevice);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.txbNhanDuLieu);
            this.Controls.Add(this.gbxGuiDuLieu);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIAO DIỆN ĐIỀU KHIỂN PIC <=> PC";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxGuiDuLieu.ResumeLayout(false);
            this.gbxGuiDuLieu.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbxDevice.ResumeLayout(false);
            this.gbxDevice.PerformLayout();
            this.gbxControl.ResumeLayout(false);
            this.gbxControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNgatKetNoi;
        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.ComboBox cbxTenCongCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxGuiDuLieu;
        private System.Windows.Forms.Button btnSetTemp;
        private System.Windows.Forms.TextBox txbValueTemp;
        private System.Windows.Forms.TextBox txbNhanDuLieu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miXoaDuLieu;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox gbxDevice;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnDevice5;
        private System.Windows.Forms.Button btnDevice4;
        private System.Windows.Forms.Button btnDevice3;
        private System.Windows.Forms.Button btnDevice2;
        private System.Windows.Forms.Button btnDevice1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSetLight;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txbValueLight;
        private System.Windows.Forms.Button btnSetHump;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbValueHump;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbxControl;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
    }
}

