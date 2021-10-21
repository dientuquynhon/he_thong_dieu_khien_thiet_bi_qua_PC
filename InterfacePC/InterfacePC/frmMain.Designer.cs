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
            this.btnGui = new System.Windows.Forms.Button();
            this.txbGuiDuLieu = new System.Windows.Forms.TextBox();
            this.txbNhanDuLieu = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miXoaDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.gbxGuiDuLieu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNgatKetNoi);
            this.groupBox1.Controls.Add(this.btnKetNoi);
            this.groupBox1.Controls.Add(this.cbxTenCongCom);
            this.groupBox1.Controls.Add(this.label1);
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
            this.cbxTenCongCom.Size = new System.Drawing.Size(139, 24);
            this.cbxTenCongCom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cổng Com";
            // 
            // gbxGuiDuLieu
            // 
            this.gbxGuiDuLieu.Controls.Add(this.btnGui);
            this.gbxGuiDuLieu.Controls.Add(this.txbGuiDuLieu);
            this.gbxGuiDuLieu.Enabled = false;
            this.gbxGuiDuLieu.Location = new System.Drawing.Point(590, 4);
            this.gbxGuiDuLieu.Name = "gbxGuiDuLieu";
            this.gbxGuiDuLieu.Size = new System.Drawing.Size(284, 56);
            this.gbxGuiDuLieu.TabIndex = 1;
            this.gbxGuiDuLieu.TabStop = false;
            this.gbxGuiDuLieu.Text = "Gửi Dữ Liệu";
            // 
            // btnGui
            // 
            this.btnGui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGui.Location = new System.Drawing.Point(210, 15);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(60, 35);
            this.btnGui.TabIndex = 4;
            this.btnGui.Text = "Gửi";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // txbGuiDuLieu
            // 
            this.txbGuiDuLieu.Location = new System.Drawing.Point(17, 21);
            this.txbGuiDuLieu.Name = "txbGuiDuLieu";
            this.txbGuiDuLieu.Size = new System.Drawing.Size(182, 23);
            this.txbGuiDuLieu.TabIndex = 0;
            // 
            // txbNhanDuLieu
            // 
            this.txbNhanDuLieu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbNhanDuLieu.ContextMenuStrip = this.contextMenuStrip1;
            this.txbNhanDuLieu.Enabled = false;
            this.txbNhanDuLieu.ForeColor = System.Drawing.Color.White;
            this.txbNhanDuLieu.Location = new System.Drawing.Point(590, 75);
            this.txbNhanDuLieu.Multiline = true;
            this.txbNhanDuLieu.Name = "txbNhanDuLieu";
            this.txbNhanDuLieu.ReadOnly = true;
            this.txbNhanDuLieu.Size = new System.Drawing.Size(284, 229);
            this.txbNhanDuLieu.TabIndex = 2;
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
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(276, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 291);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điều khiển thiết bị";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 311);
            this.Controls.Add(this.groupBox2);
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
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.TextBox txbGuiDuLieu;
        private System.Windows.Forms.TextBox txbNhanDuLieu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miXoaDuLieu;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

