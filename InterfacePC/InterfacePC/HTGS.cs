using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace InterfacePC
{
    public partial class frmMain : Form
    {
        #region Quan ly bien
        SerialPort UART = new SerialPort();
        #endregion
        #region Quan ly ham
        private void _KhoiTao()
        {
            disableElement(false);
            try
            {
                cbxTenCongCom.DataSource = SerialPort.GetPortNames();
                if (cbxTenCongCom.Items.Count > 0)
                {
                    cbxTenCongCom.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {
                
            }
        }
        #endregion
        #region Quan ly form
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _KhoiTao();
            this.UART.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.UART_DataReceived);
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void disableElement(Boolean enable)
        {
            btnNgatKetNoi.Enabled = enable;
            gbxGuiDuLieu.Enabled = enable;
            txbNhanDuLieu.Enabled = enable;
            gbxDevice.Enabled = enable;
            gbxControl.Enabled = enable;
            btnClear.Enabled = enable;
            btnSend.Enabled = enable;
            btnKetNoi.Enabled = !enable;
        }
        private void frmMain_Shown(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    {
                        Close();
                        break;
                    }
                case Keys.Enter:
                    {
                        if (txbValueTemp.Focused == true)
                        {
                            btnGui_Click(null, null);
                        }
                        break;
                    }
            }
        }
        #endregion
        #region Quan ly com
        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxTenCongCom.Text.Trim().Length == 0)
                {
                    MessageBox.Show("VUI LÒNG CHỌN CỔNG COM!");
                    return;
                }

                UART.PortName = cbxTenCongCom.Text;
                UART.Open();
                if (UART.IsOpen == true)
                {
                    disableElement(true);
                    //int A1 = ReadSample(1);
                    //if (A1 == 1)
                    //{
                    //    onDevice("0", "1");
                    //}
                    //else
                    //{
                    //    offDevice("1", "1");
                    //}
                    
                }
                else
                {
                    disableElement(false);
                }
            }
            catch (Exception)
            {
                                
            }
        }

        private void btnNgatKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                //UART.PortName = cbxTenCongCom.Text;
                UART.Close();
                if (UART.IsOpen == true)
                {
                    disableElement(true);
                }
                else
                {
                    disableElement(false);

                }
            }
            catch (Exception)
            {
                                
            }           
        }
        #endregion
        private void btnGui_Click(object sender, EventArgs e)
        {
            try
            {
                UART.Write(txbValueTemp.Text.Trim() + ".");
                MessageBox.Show("Thông số đã được cài đặt");
            }
            catch (Exception)
            {
                                
            }
        }

        string Tam = "";
        string Tam2 = "";
        private void UART_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Tam = UART.ReadExisting();
                //Tam = UART.ReadTo(".");
                var Tach = Tam.Split('-');
                //txbData1.Text = Tach[0];
                //txbData2.Text = Tach[1];
                //txbData3.Text = Tach[2].Replace(".", ""); ;

                txbNhanDuLieu.Text += Tam + " - " + DateTime.Now.ToString("HH:mm:ss") + System.Environment.NewLine;
                txbNhanDuLieu.SelectionStart = txbNhanDuLieu.TextLength;
                txbNhanDuLieu.ScrollToCaret();

            }
            catch (Exception)
            {
                                
            }
        }

        private void miXoaDuLieu_Click(object sender, EventArgs e)
        {
            txbNhanDuLieu.ResetText();
        }

        public void onDevice (string value, string numDevice)
        {
            UART.Write(value);
            btnDevice1.Text = "Tắt TB"+numDevice;
            Color mau1 = Color.FromArgb(0, 255, 0);
            btnDevice1.BackColor = mau1;
        }

        public void offDevice(string value, string numDevice)
        {
            UART.Write(value);
            btnDevice1.Text = "Bật TB" + numDevice;
            Color mau1 = Color.FromArgb(255, 0, 0);
            btnDevice1.BackColor = mau1;
        }

        private void btnDevice1_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnDevice1.Text == "Bật TB1")
                {
                    UART.Write("0");
                    btnDevice1.Text = "Tắt TB1";
                    Color mau1 = Color.FromArgb( 0, 255,0);
                    btnDevice1.BackColor = mau1;
                    WriteToExcel(1, 1, 1);
                }
                else
                {
                    UART.Write("1");
                    btnDevice1.Text = "Bật TB1";
                    Color mau1 = Color.FromArgb(255, 0,0);
                    btnDevice1.BackColor = mau1;
                    WriteToExcel(1, 1, 0);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        private void btnDevice2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (btnDevice2.Text == "Bật TB2")
                {
                    UART.Write("2");
                    btnDevice2.Text = "Tắt TB2";
                    Color mau1 = Color.FromArgb(0, 255, 0);
                    btnDevice2.BackColor = mau1;
                    WriteToExcel(2, 1, 1);
                }
                else
                {
                    UART.Write("3");
                    btnDevice2.Text = "Bật TB2";
                    Color mau1 = Color.FromArgb(255, 0, 0);
                    btnDevice2.BackColor = mau1;
                    WriteToExcel(2, 1, 0);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDevice3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (btnDevice3.Text == "Bật TB3")
                {
                    UART.Write("4");
                    btnDevice3.Text = "Tắt TB3";
                    Color mau1 = Color.FromArgb(0, 255, 0);
                    btnDevice3.BackColor = mau1;
                    WriteToExcel(3, 1, 1);
                }
                else
                {
                    UART.Write("5");
                    btnDevice3.Text = "Bật TB3";
                    Color mau1 = Color.FromArgb(255, 0, 0);
                    btnDevice3.BackColor = mau1;
                    WriteToExcel(3, 1, 0);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDevice4_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (btnDevice4.Text == "Bật TB4")
                {
                    UART.Write("6");
                    btnDevice4.Text = "Tắt TB4";
                    Color mau1 = Color.FromArgb(0, 255, 0);
                    btnDevice4.BackColor = mau1;
                }
                else
                {
                    UART.Write("7");
                    btnDevice4.Text = "Bật TB4";
                    Color mau1 = Color.FromArgb(255, 0, 0);
                    btnDevice4.BackColor = mau1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDevice5_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (btnDevice5.Text == "Bật TB5")
                {
                    UART.Write("8");
                    btnDevice5.Text = "Tắt TB5";
                    Color mau1 = Color.FromArgb(0, 255, 0);
                    btnDevice5.BackColor = mau1;
                }
                else
                {
                    UART.Write("9");
                    btnDevice5.Text = "Bật TB5";
                    Color mau1 = Color.FromArgb(255, 0, 0);
                    btnDevice5.BackColor = mau1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

     

        private void btnAuto_Click(object sender, EventArgs e)
        {
            try
            {
                if(btnAuto.Text=="Bật")
                {
                    btnAuto.Text = "Tắt";
                    Color mau1 = Color.FromArgb(0, 255, 0);
                    btnAuto.BackColor = mau1;
                    btnManual.Enabled = false;
                }
                else
                {
                    btnAuto.Text = "Bật";
                    Color mau1 = Color.FromArgb(255, 0,0);
                    btnAuto.BackColor = mau1;
                    btnManual.Enabled = true;
                   
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            try
            {
                if(btnManual.Text=="Bật")
                {
                    btnManual.Text = "Tắt";
                    Color mau1 = Color.FromArgb(0, 255, 0);
                    btnManual.BackColor = mau1;
                    btnAuto.Enabled = false;
                    gbxGuiDuLieu.Enabled = false;
                }
                else
                {
                    btnManual.Text = "Bật";
                    Color mau1 = Color.FromArgb(255, 0,0);
                    btnManual.BackColor = mau1;
                    btnAuto.Enabled = true;
                    gbxGuiDuLieu.Enabled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSetHump_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thông số đã được cài đặt");
        }

        private void btnSetLight_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thông số đã được cài đặt");
        }

        private void sendData()
        {
            UART.Write(txtSend.Text);
            txbNhanDuLieu.ForeColor = Color.White;
            txbNhanDuLieu.AppendText(txtSend.Text + "\n");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sendData();
        }

        private void txbNhanDuLieu_TextChanged(object sender, EventArgs e)
        {
            txbNhanDuLieu.ScrollToCaret();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbNhanDuLieu.Clear();
            txtSend.Clear();
        }
        private void WriteToExcel(int x, int y, int value)
        {
            string myPath = @"E:\ProjectPic-PC\Data\Excel.xlsx"; // this must be full path.

                var excelApp = new Microsoft.Office.Interop.Excel.Application();
                var workbook = excelApp.Workbooks.Open(myPath);
                Worksheet worksheet = workbook.ActiveSheet as Worksheet;
                Microsoft.Office.Interop.Excel.Range range = worksheet.Cells[x, y] as Range;
                range.Value2 = value;

                //excelApp.Visible = true;
                workbook.Save();
                workbook.Close();
            
        }

        private int ReadSample(int x)
        {
            int getStatusBtn;
            Excel.Application excelApp = new Excel.Application();
            //if (excelApp != null)
            //{
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(@"E:\ProjectPic-PC\Data\Excel.xlsx", 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];

                Excel.Range excelRange = excelWorksheet.UsedRange;
                //int rowCount = excelRange.Rows.Count;
                //int colCount = excelRange.Columns.Count;

                //for (int i = 1; i <= rowCount; i++)
                //{
                //    for (int j = 1; j <= colCount; j++)
                //    {
                //        Excel.Range range = (excelWorksheet.Cells[i, 1] as Excel.Range);
                //        string cellValue = range.Value.ToString();
                //        //do anything
                //    }
                //}
                        Excel.Range range = (excelWorksheet.Cells[x, 1] as Excel.Range);
                        string cellValue = range.Value.ToString();
                        getStatusBtn = Int32.Parse(cellValue);
                //do anything
                excelWorkbook.Close();
                excelApp.Quit();
            //}
            return getStatusBtn;
        }

    }
}
