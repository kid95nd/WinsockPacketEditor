﻿using System;
using System.Windows.Forms;
using WPELibrary.Lib;
using System.Reflection;
using System.Data;

namespace WPELibrary
{
    public partial class Socket_SendListForm : Form
    {
        private int SendIndex = -1;
        private string SendName = string.Empty;
        private DataTable dtSendCollection = Socket_Cache.Send.InitSendCollection();
        private readonly Socket_Send ss = new Socket_Send();

        #region//窗体加载

        public Socket_SendListForm(int SIndex)
        {
            MultiLanguage.SetDefaultLanguage(MultiLanguage.DefaultLanguage);
            InitializeComponent();

            this.SendIndex = SIndex;
        }

        #endregion

        #region//窗体事件

        private void SocketSendList_Form_Load(object sender, EventArgs e)
        {
            if (this.SendIndex > -1)
            {
                this.InitSendListForm();
                this.InitSendListDGV();
            }
            else
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_28));
                this.Close();
            }
        }

        private void SocketSendList_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ss.StopSend();
        }

        #endregion

        #region//初始化

        private void InitSendListDGV()
        {
            try
            {
                dgvSendCollection.AutoGenerateColumns = false;
                dgvSendCollection.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dgvSendCollection, true, null);
                dgvSendCollection.DataSource = this.dtSendCollection;
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void InitSendListForm()
        {
            try
            {
                string sSID = Socket_Cache.SendList.lstSend[this.SendIndex].SID.ToString().ToUpper();
                this.Text = string.Format(MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_48), (this.SendIndex + 1), sSID);

                this.SendName = Socket_Cache.SendList.lstSend[this.SendIndex].SName;
                this.txtSendName.Text = this.SendName;
                this.cbSystemSocket.Checked = Socket_Cache.SendList.lstSend[this.SendIndex].SSystemSocket;
                this.lSystemSocket.Text = Socket_Cache.SystemSocket.ToString();
                this.nudLoop_CNT.Value = Socket_Cache.SendList.lstSend[this.SendIndex].SLoopCNT;
                this.nudLoop_INT.Value = Socket_Cache.SendList.lstSend[this.SendIndex].SLoopINT;
                this.dtSendCollection = Socket_Cache.SendList.lstSend[this.SendIndex].SCollection.Copy();

                this.InitSend();
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }          
        }

        private void InitSend()
        {
            try
            {
                this.ss.Worker.ProgressChanged -= this.Worker_ProgressChanged;
                this.ss.Worker.ProgressChanged += this.Worker_ProgressChanged;

                this.ss.Worker.RunWorkerCompleted -= this.Worker_RunWorkerCompleted;
                this.ss.Worker.RunWorkerCompleted += this.Worker_RunWorkerCompleted;
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void dgvSendCollection_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvSendCollection.Columns["cID"].Index)
                {
                    e.Value = (e.RowIndex + 1).ToString();
                    e.FormattingApplied = true;
                }
                else if (e.ColumnIndex == dgvSendCollection.Columns["cType"].Index)
                {
                    Socket_Cache.SocketPacket.PacketType ptType = (Socket_Cache.SocketPacket.PacketType)this.dgvSendCollection.Rows[e.RowIndex].Cells["cType"].Value;
                    e.Value = Socket_Cache.SocketPacket.GetName_ByPacketType(ptType);
                    e.FormattingApplied = true;
                }
                else if (e.ColumnIndex == dgvSendCollection.Columns["cData"].Index)
                {
                    e.Value = Socket_Operation.BytesToString(Socket_Cache.SocketPacket.EncodingFormat.Hex, (byte[])this.dtSendCollection.Rows[e.RowIndex]["Buffer"]);
                    e.FormattingApplied = true;
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        #endregion                

        #region//保存按钮

        private void bSave_Click(object sender, EventArgs e)
        {
            try
            {
                string SName_New = this.txtSendName.Text.Trim();
                if (string.IsNullOrEmpty(SName_New))
                {
                    Socket_Operation.ShowMessageBox(MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_19));
                    return;
                }

                bool SSystemSocket_New = this.cbSystemSocket.Checked;           
                int SLoopCNT_New = ((int)this.nudLoop_CNT.Value);
                int SLoopINT_New = ((int)this.nudLoop_INT.Value);

                Socket_Cache.Send.UpdateSend_BySendIndex(this.SendIndex, SName_New, SSystemSocket_New, SLoopCNT_New, SLoopINT_New, this.dtSendCollection);

                this.Close();
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        #endregion

        #region//关闭按钮

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion        

        #region//执行按钮

        private void bExecute_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dtSendCollection.Rows.Count > 0)
                {
                    if (this.CheckSendInfo())
                    {
                        if (!this.ss.Worker.IsBusy)
                        {
                            this.bExecute.Enabled = false;
                            this.bStop.Enabled = true;
                            this.tlpParameter.Enabled = false;

                            if (this.dgvSendCollection.ContextMenuStrip != null)
                            {
                                this.dgvSendCollection.ContextMenuStrip.Enabled = false;
                            }

                            bool bSystemSocket = this.cbSystemSocket.Checked;
                            int iLoopCNT = ((int)this.nudLoop_CNT.Value);
                            int iLoopINT = ((int)this.nudLoop_INT.Value);

                            ss.StartSend(this.SendName, bSystemSocket, iLoopCNT, iLoopINT, this.dtSendCollection);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void Worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled)
                {
                    string sMsg = string.Format(MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_163), this.SendName);
                    Socket_Operation.ShowMessageBox(sMsg);
                }
                else if (e.Error != null)
                {
                    string sMsg = string.Format(MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_164), this.SendName, e.Error.Message);
                    Socket_Operation.ShowMessageBox(sMsg);
                }
                else
                {
                    string sMsg = string.Format(MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_165), this.SendName);
                    Socket_Operation.ShowMessageBox(sMsg);
                }

                this.bExecute.Enabled = true;
                this.bStop.Enabled = false;
                this.tlpParameter.Enabled = true;

                if (this.dgvSendCollection.ContextMenuStrip != null)
                {
                    this.dgvSendCollection.ContextMenuStrip.Enabled = true;
                }

                this.tlTotal_Send_CNT.Text = this.ss.Total_Send.ToString();
                this.tlSend_Success_CNT.Text = this.ss.Send_Success.ToString();
                this.tlSend_Fail_CNT.Text = this.ss.Send_Failure.ToString();
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void Worker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            try
            {
                int iIndex = e.ProgressPercentage;

                if (iIndex > -1 && iIndex < dgvSendCollection.Rows.Count)
                {
                    this.dgvSendCollection.CurrentCell = this.dgvSendCollection.Rows[iIndex].Cells[0];
                    this.dgvSendCollection.FirstDisplayedScrollingRowIndex = iIndex;
                }

                this.tlTotal_Send_CNT.Text = this.ss.Total_Send.ToString();
                this.tlSend_Success_CNT.Text = this.ss.Send_Success.ToString();
                this.tlSend_Fail_CNT.Text = this.ss.Send_Failure.ToString();
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        #endregion

        #region//停止按钮

        private void bStop_Click(object sender, EventArgs e)
        {
            this.ss.StopSend();
        }        

        #endregion

        #region//检查发送设置

        private bool CheckSendInfo()
        {
            bool bReturn = true;

            try
            {
                if (this.cbSystemSocket.Checked)
                {
                    if (Socket_Cache.SystemSocket <= 0)
                    {
                        Socket_Operation.ShowMessageBox(MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_49));
                        return false;
                    }                   
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bReturn;
        }

        #endregion

        #region//发送集菜单

        private void cmsSendCollection_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string sItemText = e.ClickedItem.Name;
            cmsSendCollection.Close();

            try
            {
                if (dgvSendCollection.Rows.Count > 0)
                {
                    int iIndex = 0;
                    int iSIndex = this.dgvSendCollection.CurrentRow.Index;

                    if (iSIndex > -1)
                    {
                        switch (sItemText)
                        {
                            case "cmsSendList_Top":
                                iIndex = this.UpdateSendCollection_ByListAction(Socket_Cache.ListAction.Top, iSIndex);
                                break;

                            case "cmsSendList_Up":
                                iIndex = this.UpdateSendCollection_ByListAction(Socket_Cache.ListAction.Up, iSIndex);
                                break;

                            case "cmsSendList_Down":
                                iIndex = this.UpdateSendCollection_ByListAction(Socket_Cache.ListAction.Down, iSIndex);
                                break;

                            case "cmsSendList_Bottom":
                                iIndex = this.UpdateSendCollection_ByListAction(Socket_Cache.ListAction.Bottom, iSIndex);
                                break;

                            case "cmsSendList_Delete":
                                iIndex = this.UpdateSendCollection_ByListAction(Socket_Cache.ListAction.Delete, iSIndex);
                                break;

                            case "cmsSendList_CleanUp":

                                DialogResult dr = Socket_Operation.ShowSelectMessageBox(MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_38));

                                if (dr.Equals(DialogResult.OK))
                                {
                                    iIndex = this.UpdateSendCollection_ByListAction(Socket_Cache.ListAction.CleanUp, iSIndex);
                                }
                                
                                break;
                        }

                        if (iIndex > -1 && iIndex < dgvSendCollection.RowCount)
                        {
                            this.dgvSendCollection.ClearSelection();
                            this.dgvSendCollection.Rows[iIndex].Selected = true;
                            this.dgvSendCollection.CurrentCell = this.dgvSendCollection.Rows[iIndex].Cells[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        #endregion

        #region//发送集的列表操作

        public int UpdateSendCollection_ByListAction(Socket_Cache.ListAction listAction, int iSIndex)
        {
            int iReturn = -1;

            try
            {
                int iSendCollectionCount = this.dtSendCollection.Rows.Count;
                DataRow dr = this.dtSendCollection.NewRow();
                dr.ItemArray = this.dtSendCollection.Rows[iSIndex].ItemArray;

                switch (listAction)
                {
                    case Socket_Cache.ListAction.Top:
                        if (iSIndex > 0)
                        {
                            this.dtSendCollection.Rows.RemoveAt(iSIndex);
                            this.dtSendCollection.Rows.InsertAt(dr, 0);
                            iReturn = 0;
                        }
                        break;

                    case Socket_Cache.ListAction.Up:
                        if (iSIndex > 0)
                        {
                            this.dtSendCollection.Rows.RemoveAt(iSIndex);
                            this.dtSendCollection.Rows.InsertAt(dr, iSIndex - 1);
                            iReturn = iSIndex - 1;
                        }
                        break;

                    case Socket_Cache.ListAction.Down:
                        if (iSIndex < iSendCollectionCount - 1)
                        {
                            this.dtSendCollection.Rows.RemoveAt(iSIndex);
                            this.dtSendCollection.Rows.InsertAt(dr, iSIndex + 1);
                            iReturn = iSIndex + 1;
                        }
                        break;

                    case Socket_Cache.ListAction.Bottom:
                        if (iSIndex < iSendCollectionCount - 1)
                        {
                            this.dtSendCollection.Rows.RemoveAt(iSIndex);
                            this.dtSendCollection.Rows.Add(dr);
                            iReturn = this.dtSendCollection.Rows.Count - 1;
                        }
                        break;                    

                    case Socket_Cache.ListAction.Delete:
                        this.dtSendCollection.Rows.RemoveAt(iSIndex);
                        break;

                    case Socket_Cache.ListAction.CleanUp:
                        this.dtSendCollection.Rows.Clear();
                        break;
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return iReturn;
        }

        #endregion
    }
}
