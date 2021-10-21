using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

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
                        if (txbGuiDuLieu.Focused == true)
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
                    btnNgatKetNoi.Enabled = true;
                    gbxGuiDuLieu.Enabled = true;
                    txbNhanDuLieu.Enabled = true;
                    btnKetNoi.Enabled = false;
                }
                else
                {
                    btnNgatKetNoi.Enabled = false;
                    gbxGuiDuLieu.Enabled = false;
                    txbNhanDuLieu.Enabled = false;
                    btnKetNoi.Enabled = true;
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
                    btnNgatKetNoi.Enabled = true;
                    gbxGuiDuLieu.Enabled = true;
                    txbNhanDuLieu.Enabled = true;
                    btnKetNoi.Enabled = false;
                }
                else
                {
                    btnNgatKetNoi.Enabled = false;
                    gbxGuiDuLieu.Enabled = false;
                    txbNhanDuLieu.Enabled = false;
                    btnKetNoi.Enabled = true;
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
                UART.Write(txbGuiDuLieu.Text.Trim() + ".");
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
                //Tam = UART.ReadExisting();
                Tam = UART.ReadTo(".");

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
    }
}
