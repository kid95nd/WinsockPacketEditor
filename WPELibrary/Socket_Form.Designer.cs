﻿
namespace WPELibrary
{
    partial class Socket_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Socket_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpSocketForm = new System.Windows.Forms.TableLayoutPanel();
            this.ssSocketList = new System.Windows.Forms.StatusStrip();
            this.tlALL = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlALL_CNT = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlSplit1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlQueue = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlQueue_CNT = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlSplit2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlFilter = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlFilter_CNT = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlSplit4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlIntercept = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlIntercept_CNT = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlSend = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlSend_CNT = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlSplit3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlRecv = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlRecv_CNT = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlSendTo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlSendTo_CNT = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlRecvFrom = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlRecvFrom_CNT = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlWSASend = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlWSASend_CNT = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel11 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlWSARecv = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlWSARecv_CNT = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel14 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlWSASendTo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlWSASendTo_CNT = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel17 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlWSARecvFrom = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlWSARecvFrom_CNT = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvSocketList = new System.Windows.Forms.DataGridView();
            this.cTypeImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.cIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPacketType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSocket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsSocketList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsSocketList_Send = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSocketList_tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsSocketList_UseSocket = new System.Windows.Forms.ToolStripMenuItem();
            this.tss4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsSocketList_ShowSendList = new System.Windows.Forms.ToolStripMenuItem();
            this.tss5 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsSocketList_ToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsSocketList_Comparison_A = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSocketList_Comparison_B = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpParameter = new System.Windows.Forms.TableLayoutPanel();
            this.gbSocketList_Set = new System.Windows.Forms.GroupBox();
            this.tlpSocketList_Set = new System.Windows.Forms.TableLayoutPanel();
            this.nudSocketList_AutoClearValue = new System.Windows.Forms.NumericUpDown();
            this.cbSocketList_AutoClear = new System.Windows.Forms.CheckBox();
            this.cbSocketList_AutoRoll = new System.Windows.Forms.CheckBox();
            this.gbFilterSet = new System.Windows.Forms.GroupBox();
            this.tlpFilterSet = new System.Windows.Forms.TableLayoutPanel();
            this.tlpFilterSet_PacketLength = new System.Windows.Forms.TableLayoutPanel();
            this.nudCheckSizeTo = new System.Windows.Forms.NumericUpDown();
            this.lCheck_Size = new System.Windows.Forms.Label();
            this.nudCheckSizeFrom = new System.Windows.Forms.NumericUpDown();
            this.cbCheckSize = new System.Windows.Forms.CheckBox();
            this.rbFilter_Show = new System.Windows.Forms.RadioButton();
            this.rbFilter_NotShow = new System.Windows.Forms.RadioButton();
            this.txtCheckPort = new System.Windows.Forms.TextBox();
            this.cbCheckPort = new System.Windows.Forms.CheckBox();
            this.txtCheckData = new System.Windows.Forms.TextBox();
            this.cbCheckData = new System.Windows.Forms.CheckBox();
            this.cbCheckSocket = new System.Windows.Forms.CheckBox();
            this.cbCheckIP = new System.Windows.Forms.CheckBox();
            this.txtCheckSocket = new System.Windows.Forms.TextBox();
            this.txtCheckIP = new System.Windows.Forms.TextBox();
            this.gbHookType = new System.Windows.Forms.GroupBox();
            this.tlpHookType = new System.Windows.Forms.TableLayoutPanel();
            this.cbHookRecvFrom = new System.Windows.Forms.CheckBox();
            this.cbHookSend = new System.Windows.Forms.CheckBox();
            this.cbHookSendTo = new System.Windows.Forms.CheckBox();
            this.cbHookRecv = new System.Windows.Forms.CheckBox();
            this.cbHookWSASend = new System.Windows.Forms.CheckBox();
            this.cbHookWSASendTo = new System.Windows.Forms.CheckBox();
            this.cbHookWSARecv = new System.Windows.Forms.CheckBox();
            this.cbHookWSARecvFrom = new System.Windows.Forms.CheckBox();
            this.gbHookButton_Search = new System.Windows.Forms.GroupBox();
            this.tlpSearch = new System.Windows.Forms.TableLayoutPanel();
            this.rbFromIndex = new System.Windows.Forms.RadioButton();
            this.rbFromHead = new System.Windows.Forms.RadioButton();
            this.tlpSearchButton = new System.Windows.Forms.TableLayoutPanel();
            this.bSearchNext = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.tlpHookButton = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHookButton_Start = new System.Windows.Forms.TableLayoutPanel();
            this.bStopHook = new System.Windows.Forms.Button();
            this.bStartHook = new System.Windows.Forms.Button();
            this.bCleanUp = new System.Windows.Forms.Button();
            this.tlpInformation = new System.Windows.Forms.TableLayoutPanel();
            this.gbFilterList = new System.Windows.Forms.GroupBox();
            this.tlpFilterList = new System.Windows.Forms.TableLayoutPanel();
            this.dgvFilterList = new System.Windows.Forms.DataGridView();
            this.cIsCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cFNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsFilterList = new System.Windows.Forms.ToolStrip();
            this.tsFilterList_Load = new System.Windows.Forms.ToolStripButton();
            this.tsFilterList_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsFilterList_Add = new System.Windows.Forms.ToolStripButton();
            this.tsFilterList_Edit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsFilterList_Delete = new System.Windows.Forms.ToolStripButton();
            this.tsFilterList_CleanUp = new System.Windows.Forms.ToolStripButton();
            this.tlpPacketInfo = new System.Windows.Forms.TableLayoutPanel();
            this.tcPacketInfo = new System.Windows.Forms.TabControl();
            this.tpPacketData = new System.Windows.Forms.TabPage();
            this.tlpPacketData = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHexBox = new System.Windows.Forms.TableLayoutPanel();
            this.hbPacketData = new Be.Windows.Forms.HexBox();
            this.cmsHexBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsHexBox_Send = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsHexBox_tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsHexBox_SendList = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsHexBox_tss2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsHexBox_FilterList = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsHexBox_tss3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsHexBox_CopyHex = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsHexBox_CopyText = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsHexBox_tss4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsHexBox_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tpComparison = new System.Windows.Forms.TabPage();
            this.tlpComparison = new System.Windows.Forms.TableLayoutPanel();
            this.tlpComparison_Button = new System.Windows.Forms.TableLayoutPanel();
            this.bComparison_Exchange = new System.Windows.Forms.Button();
            this.bComparison_Clear = new System.Windows.Forms.Button();
            this.bComparison = new System.Windows.Forms.Button();
            this.lComparison_B = new System.Windows.Forms.Label();
            this.lComparison_A = new System.Windows.Forms.Label();
            this.pComparison_A = new System.Windows.Forms.Panel();
            this.rtbComparison_A = new System.Windows.Forms.RichTextBox();
            this.pComparison_B = new System.Windows.Forms.Panel();
            this.rtbComparison_B = new System.Windows.Forms.RichTextBox();
            this.pComparison_Result = new System.Windows.Forms.Panel();
            this.rtbComparison_Result = new System.Windows.Forms.RichTextBox();
            this.tpXOR = new System.Windows.Forms.TabPage();
            this.tlpPacketInfo_XOR = new System.Windows.Forms.TableLayoutPanel();
            this.hbXOR_To = new Be.Windows.Forms.HexBox();
            this.tlpPacketInfo_XOR_Button = new System.Windows.Forms.TableLayoutPanel();
            this.lXOR2 = new System.Windows.Forms.Label();
            this.bXOR_Clear = new System.Windows.Forms.Button();
            this.bXOR = new System.Windows.Forms.Button();
            this.lXOR = new System.Windows.Forms.Label();
            this.txtXOR = new System.Windows.Forms.TextBox();
            this.hbXOR_From = new Be.Windows.Forms.HexBox();
            this.tpEncoding = new System.Windows.Forms.TabPage();
            this.tlpPacketInfo_Encoding = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPacketInfo_Encoding_Button = new System.Windows.Forms.TableLayoutPanel();
            this.bPacketInfo_Decoding = new System.Windows.Forms.Button();
            this.bPacketInfo_Encoding = new System.Windows.Forms.Button();
            this.tlpPacketInfo_Encoding_Result = new System.Windows.Forms.TableLayoutPanel();
            this.txtPacketInfo_Encoding_ANSIUnicode = new System.Windows.Forms.TextBox();
            this.lPacketInfo_Encoding_ANSIUnicode = new System.Windows.Forms.Label();
            this.txtPacketInfo_Encoding_ANSIUTF32 = new System.Windows.Forms.TextBox();
            this.lPacketInfo_Encoding_ANSIUTF32 = new System.Windows.Forms.Label();
            this.txtPacketInfo_Encoding_ANSIUTF16 = new System.Windows.Forms.TextBox();
            this.lPacketInfo_Encoding_ANSIASCII = new System.Windows.Forms.Label();
            this.txtPacketInfo_Encoding_Unicode = new System.Windows.Forms.TextBox();
            this.lPacketInfo_Encoding_Unicode = new System.Windows.Forms.Label();
            this.txtPacketInfo_Encoding_UTF32 = new System.Windows.Forms.TextBox();
            this.lPacketInfo_Encoding_UTF32 = new System.Windows.Forms.Label();
            this.txtPacketInfo_Encoding_UTF16 = new System.Windows.Forms.TextBox();
            this.lPacketInfo_Encoding_ASCII = new System.Windows.Forms.Label();
            this.txtPacketInfo_Encoding_ANSIbase64 = new System.Windows.Forms.TextBox();
            this.txtPacketInfo_Encoding_ANSIUTF8 = new System.Windows.Forms.TextBox();
            this.txtPacketInfo_Encoding_ANSIUTF7 = new System.Windows.Forms.TextBox();
            this.txtPacketInfo_Encoding_ANSIGBK = new System.Windows.Forms.TextBox();
            this.lPacketInfo_Encoding_ANSIbase64 = new System.Windows.Forms.Label();
            this.lPacketInfo_Encoding_ANSIUTF8 = new System.Windows.Forms.Label();
            this.lPacketInfo_Encoding_ANSIUTF7 = new System.Windows.Forms.Label();
            this.lPacketInfo_Encoding_UTF7 = new System.Windows.Forms.Label();
            this.lPacketInfo_Encoding_ANSIGBK = new System.Windows.Forms.Label();
            this.txtPacketInfo_Encoding_base64 = new System.Windows.Forms.TextBox();
            this.txtPacketInfo_Encoding_UTF8 = new System.Windows.Forms.TextBox();
            this.txtPacketInfo_Encoding_UTF7 = new System.Windows.Forms.TextBox();
            this.lPacketInfo_Encoding_base64 = new System.Windows.Forms.Label();
            this.lPacketInfo_Encoding_UTF8 = new System.Windows.Forms.Label();
            this.lPacketInfo_Encoding_Bytes = new System.Windows.Forms.Label();
            this.txtPacketInfo_Encoding_Bytes = new System.Windows.Forms.TextBox();
            this.pPacketInfo_Encoding = new System.Windows.Forms.Panel();
            this.rtbPacketInfo_Encoding = new System.Windows.Forms.RichTextBox();
            this.tpSystemLog = new System.Windows.Forms.TabPage();
            this.dgvLogList = new System.Windows.Forms.DataGridView();
            this.cTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFuncName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsLogList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsLogList_CleanUp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsLogList_ToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.ssProcessInfo = new System.Windows.Forms.StatusStrip();
            this.tsslProcessName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslProcessInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslWinSock = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTotalBytes = new System.Windows.Forms.ToolStripStatusLabel();
            this.bgwSocketList = new System.ComponentModel.BackgroundWorker();
            this.tSocketInfo = new System.Windows.Forms.Timer(this.components);
            this.bgwLogList = new System.ComponentModel.BackgroundWorker();
            this.bgwSearchPacketData = new System.ComponentModel.BackgroundWorker();
            this.niWPE = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsIcon_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.tss17 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsIcon_StartHook = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsIcon_StopHook = new System.Windows.Forms.ToolStripMenuItem();
            this.tss18 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsIcon_CleanUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tss19 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsIcon_ShowSendList = new System.Windows.Forms.ToolStripMenuItem();
            this.tss20 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsIcon_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tlpSocketForm.SuspendLayout();
            this.ssSocketList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocketList)).BeginInit();
            this.cmsSocketList.SuspendLayout();
            this.tlpParameter.SuspendLayout();
            this.gbSocketList_Set.SuspendLayout();
            this.tlpSocketList_Set.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSocketList_AutoClearValue)).BeginInit();
            this.gbFilterSet.SuspendLayout();
            this.tlpFilterSet.SuspendLayout();
            this.tlpFilterSet_PacketLength.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCheckSizeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCheckSizeFrom)).BeginInit();
            this.gbHookType.SuspendLayout();
            this.tlpHookType.SuspendLayout();
            this.gbHookButton_Search.SuspendLayout();
            this.tlpSearch.SuspendLayout();
            this.tlpSearchButton.SuspendLayout();
            this.tlpHookButton.SuspendLayout();
            this.tlpHookButton_Start.SuspendLayout();
            this.tlpInformation.SuspendLayout();
            this.gbFilterList.SuspendLayout();
            this.tlpFilterList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilterList)).BeginInit();
            this.tsFilterList.SuspendLayout();
            this.tlpPacketInfo.SuspendLayout();
            this.tcPacketInfo.SuspendLayout();
            this.tpPacketData.SuspendLayout();
            this.tlpPacketData.SuspendLayout();
            this.tlpHexBox.SuspendLayout();
            this.cmsHexBox.SuspendLayout();
            this.tpComparison.SuspendLayout();
            this.tlpComparison.SuspendLayout();
            this.tlpComparison_Button.SuspendLayout();
            this.pComparison_A.SuspendLayout();
            this.pComparison_B.SuspendLayout();
            this.pComparison_Result.SuspendLayout();
            this.tpXOR.SuspendLayout();
            this.tlpPacketInfo_XOR.SuspendLayout();
            this.tlpPacketInfo_XOR_Button.SuspendLayout();
            this.tpEncoding.SuspendLayout();
            this.tlpPacketInfo_Encoding.SuspendLayout();
            this.tlpPacketInfo_Encoding_Button.SuspendLayout();
            this.tlpPacketInfo_Encoding_Result.SuspendLayout();
            this.pPacketInfo_Encoding.SuspendLayout();
            this.tpSystemLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogList)).BeginInit();
            this.cmsLogList.SuspendLayout();
            this.ssProcessInfo.SuspendLayout();
            this.cmsIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpSocketForm
            // 
            resources.ApplyResources(this.tlpSocketForm, "tlpSocketForm");
            this.tlpSocketForm.Controls.Add(this.ssSocketList, 0, 1);
            this.tlpSocketForm.Controls.Add(this.dgvSocketList, 0, 2);
            this.tlpSocketForm.Controls.Add(this.tlpParameter, 0, 0);
            this.tlpSocketForm.Controls.Add(this.tlpInformation, 0, 3);
            this.tlpSocketForm.Controls.Add(this.ssProcessInfo, 0, 4);
            this.tlpSocketForm.Name = "tlpSocketForm";
            // 
            // ssSocketList
            // 
            resources.ApplyResources(this.ssSocketList, "ssSocketList");
            this.ssSocketList.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ssSocketList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlALL,
            this.tlALL_CNT,
            this.tlSplit1,
            this.tlQueue,
            this.tlQueue_CNT,
            this.tlSplit2,
            this.tlFilter,
            this.tlFilter_CNT,
            this.tlSplit4,
            this.tlIntercept,
            this.tlIntercept_CNT,
            this.toolStripStatusLabel9,
            this.tlSend,
            this.tlSend_CNT,
            this.tlSplit3,
            this.tlRecv,
            this.tlRecv_CNT,
            this.toolStripStatusLabel2,
            this.tlSendTo,
            this.tlSendTo_CNT,
            this.toolStripStatusLabel5,
            this.tlRecvFrom,
            this.tlRecvFrom_CNT,
            this.toolStripStatusLabel8,
            this.tlWSASend,
            this.tlWSASend_CNT,
            this.toolStripStatusLabel11,
            this.tlWSARecv,
            this.tlWSARecv_CNT,
            this.toolStripStatusLabel14,
            this.tlWSASendTo,
            this.tlWSASendTo_CNT,
            this.toolStripStatusLabel17,
            this.tlWSARecvFrom,
            this.tlWSARecvFrom_CNT});
            this.ssSocketList.Name = "ssSocketList";
            this.ssSocketList.SizingGrip = false;
            // 
            // tlALL
            // 
            resources.ApplyResources(this.tlALL, "tlALL");
            this.tlALL.Name = "tlALL";
            // 
            // tlALL_CNT
            // 
            resources.ApplyResources(this.tlALL_CNT, "tlALL_CNT");
            this.tlALL_CNT.Name = "tlALL_CNT";
            // 
            // tlSplit1
            // 
            this.tlSplit1.ForeColor = System.Drawing.Color.DarkGray;
            this.tlSplit1.Name = "tlSplit1";
            resources.ApplyResources(this.tlSplit1, "tlSplit1");
            // 
            // tlQueue
            // 
            resources.ApplyResources(this.tlQueue, "tlQueue");
            this.tlQueue.Name = "tlQueue";
            // 
            // tlQueue_CNT
            // 
            resources.ApplyResources(this.tlQueue_CNT, "tlQueue_CNT");
            this.tlQueue_CNT.Name = "tlQueue_CNT";
            // 
            // tlSplit2
            // 
            this.tlSplit2.ForeColor = System.Drawing.Color.DarkGray;
            this.tlSplit2.Name = "tlSplit2";
            resources.ApplyResources(this.tlSplit2, "tlSplit2");
            // 
            // tlFilter
            // 
            this.tlFilter.Name = "tlFilter";
            resources.ApplyResources(this.tlFilter, "tlFilter");
            // 
            // tlFilter_CNT
            // 
            resources.ApplyResources(this.tlFilter_CNT, "tlFilter_CNT");
            this.tlFilter_CNT.Name = "tlFilter_CNT";
            // 
            // tlSplit4
            // 
            this.tlSplit4.ForeColor = System.Drawing.Color.DarkGray;
            this.tlSplit4.Name = "tlSplit4";
            resources.ApplyResources(this.tlSplit4, "tlSplit4");
            // 
            // tlIntercept
            // 
            this.tlIntercept.Name = "tlIntercept";
            resources.ApplyResources(this.tlIntercept, "tlIntercept");
            // 
            // tlIntercept_CNT
            // 
            resources.ApplyResources(this.tlIntercept_CNT, "tlIntercept_CNT");
            this.tlIntercept_CNT.Name = "tlIntercept_CNT";
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.ForeColor = System.Drawing.Color.DarkGray;
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            resources.ApplyResources(this.toolStripStatusLabel9, "toolStripStatusLabel9");
            // 
            // tlSend
            // 
            resources.ApplyResources(this.tlSend, "tlSend");
            this.tlSend.Name = "tlSend";
            // 
            // tlSend_CNT
            // 
            resources.ApplyResources(this.tlSend_CNT, "tlSend_CNT");
            this.tlSend_CNT.Name = "tlSend_CNT";
            // 
            // tlSplit3
            // 
            this.tlSplit3.ForeColor = System.Drawing.Color.DarkGray;
            this.tlSplit3.Name = "tlSplit3";
            resources.ApplyResources(this.tlSplit3, "tlSplit3");
            // 
            // tlRecv
            // 
            resources.ApplyResources(this.tlRecv, "tlRecv");
            this.tlRecv.Name = "tlRecv";
            // 
            // tlRecv_CNT
            // 
            resources.ApplyResources(this.tlRecv_CNT, "tlRecv_CNT");
            this.tlRecv_CNT.Name = "tlRecv_CNT";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // tlSendTo
            // 
            resources.ApplyResources(this.tlSendTo, "tlSendTo");
            this.tlSendTo.Name = "tlSendTo";
            // 
            // tlSendTo_CNT
            // 
            resources.ApplyResources(this.tlSendTo_CNT, "tlSendTo_CNT");
            this.tlSendTo_CNT.Name = "tlSendTo_CNT";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.ForeColor = System.Drawing.Color.DarkGray;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            resources.ApplyResources(this.toolStripStatusLabel5, "toolStripStatusLabel5");
            // 
            // tlRecvFrom
            // 
            resources.ApplyResources(this.tlRecvFrom, "tlRecvFrom");
            this.tlRecvFrom.Name = "tlRecvFrom";
            // 
            // tlRecvFrom_CNT
            // 
            resources.ApplyResources(this.tlRecvFrom_CNT, "tlRecvFrom_CNT");
            this.tlRecvFrom_CNT.Name = "tlRecvFrom_CNT";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.ForeColor = System.Drawing.Color.DarkGray;
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            resources.ApplyResources(this.toolStripStatusLabel8, "toolStripStatusLabel8");
            // 
            // tlWSASend
            // 
            resources.ApplyResources(this.tlWSASend, "tlWSASend");
            this.tlWSASend.Name = "tlWSASend";
            // 
            // tlWSASend_CNT
            // 
            resources.ApplyResources(this.tlWSASend_CNT, "tlWSASend_CNT");
            this.tlWSASend_CNT.Name = "tlWSASend_CNT";
            // 
            // toolStripStatusLabel11
            // 
            this.toolStripStatusLabel11.ForeColor = System.Drawing.Color.DarkGray;
            this.toolStripStatusLabel11.Name = "toolStripStatusLabel11";
            resources.ApplyResources(this.toolStripStatusLabel11, "toolStripStatusLabel11");
            // 
            // tlWSARecv
            // 
            resources.ApplyResources(this.tlWSARecv, "tlWSARecv");
            this.tlWSARecv.Name = "tlWSARecv";
            // 
            // tlWSARecv_CNT
            // 
            resources.ApplyResources(this.tlWSARecv_CNT, "tlWSARecv_CNT");
            this.tlWSARecv_CNT.Name = "tlWSARecv_CNT";
            // 
            // toolStripStatusLabel14
            // 
            this.toolStripStatusLabel14.ForeColor = System.Drawing.Color.DarkGray;
            this.toolStripStatusLabel14.Name = "toolStripStatusLabel14";
            resources.ApplyResources(this.toolStripStatusLabel14, "toolStripStatusLabel14");
            // 
            // tlWSASendTo
            // 
            resources.ApplyResources(this.tlWSASendTo, "tlWSASendTo");
            this.tlWSASendTo.Name = "tlWSASendTo";
            // 
            // tlWSASendTo_CNT
            // 
            resources.ApplyResources(this.tlWSASendTo_CNT, "tlWSASendTo_CNT");
            this.tlWSASendTo_CNT.Name = "tlWSASendTo_CNT";
            // 
            // toolStripStatusLabel17
            // 
            this.toolStripStatusLabel17.ForeColor = System.Drawing.Color.DarkGray;
            this.toolStripStatusLabel17.Name = "toolStripStatusLabel17";
            resources.ApplyResources(this.toolStripStatusLabel17, "toolStripStatusLabel17");
            // 
            // tlWSARecvFrom
            // 
            resources.ApplyResources(this.tlWSARecvFrom, "tlWSARecvFrom");
            this.tlWSARecvFrom.Name = "tlWSARecvFrom";
            // 
            // tlWSARecvFrom_CNT
            // 
            resources.ApplyResources(this.tlWSARecvFrom_CNT, "tlWSARecvFrom_CNT");
            this.tlWSARecvFrom_CNT.Name = "tlWSARecvFrom_CNT";
            // 
            // dgvSocketList
            // 
            this.dgvSocketList.AllowUserToAddRows = false;
            this.dgvSocketList.AllowUserToDeleteRows = false;
            this.dgvSocketList.AllowUserToResizeColumns = false;
            this.dgvSocketList.AllowUserToResizeRows = false;
            this.dgvSocketList.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSocketList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSocketList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocketList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTypeImg,
            this.cIndex,
            this.cPacketType,
            this.cSocket,
            this.cFrom,
            this.cTo,
            this.cLen,
            this.cData});
            this.dgvSocketList.ContextMenuStrip = this.cmsSocketList;
            resources.ApplyResources(this.dgvSocketList, "dgvSocketList");
            this.dgvSocketList.MultiSelect = false;
            this.dgvSocketList.Name = "dgvSocketList";
            this.dgvSocketList.RowHeadersVisible = false;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSocketList.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSocketList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.WindowText;
            this.dgvSocketList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSocketList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.LimeGreen;
            this.dgvSocketList.RowTemplate.Height = 23;
            this.dgvSocketList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSocketList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSocketList_CellFormatting);
            this.dgvSocketList.SelectionChanged += new System.EventHandler(this.dgvSocketInfo_SelectionChanged);
            // 
            // cTypeImg
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cTypeImg.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.cTypeImg, "cTypeImg");
            this.cTypeImg.Image = global::WPELibrary.Properties.Resources.Info16;
            this.cTypeImg.Name = "cTypeImg";
            this.cTypeImg.ReadOnly = true;
            this.cTypeImg.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cIndex
            // 
            this.cIndex.DataPropertyName = "PacketIndex";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cIndex.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.cIndex, "cIndex");
            this.cIndex.Name = "cIndex";
            this.cIndex.ReadOnly = true;
            this.cIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cPacketType
            // 
            this.cPacketType.DataPropertyName = "PacketType";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cPacketType.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.cPacketType, "cPacketType");
            this.cPacketType.Name = "cPacketType";
            this.cPacketType.ReadOnly = true;
            this.cPacketType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cSocket
            // 
            this.cSocket.DataPropertyName = "PacketSocket";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cSocket.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.cSocket, "cSocket");
            this.cSocket.Name = "cSocket";
            this.cSocket.ReadOnly = true;
            this.cSocket.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cFrom
            // 
            this.cFrom.DataPropertyName = "PacketFrom";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cFrom.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.cFrom, "cFrom");
            this.cFrom.Name = "cFrom";
            this.cFrom.ReadOnly = true;
            this.cFrom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cTo
            // 
            this.cTo.DataPropertyName = "PacketTo";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cTo.DefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(this.cTo, "cTo");
            this.cTo.Name = "cTo";
            this.cTo.ReadOnly = true;
            this.cTo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cLen
            // 
            this.cLen.DataPropertyName = "PacketLen";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cLen.DefaultCellStyle = dataGridViewCellStyle8;
            resources.ApplyResources(this.cLen, "cLen");
            this.cLen.Name = "cLen";
            this.cLen.ReadOnly = true;
            this.cLen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cData
            // 
            this.cData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cData.DataPropertyName = "PacketData";
            resources.ApplyResources(this.cData, "cData");
            this.cData.Name = "cData";
            this.cData.ReadOnly = true;
            this.cData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmsSocketList
            // 
            this.cmsSocketList.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsSocketList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsSocketList_Send,
            this.cmsSocketList_tss1,
            this.cmsSocketList_UseSocket,
            this.tss4,
            this.cmsSocketList_ShowSendList,
            this.tss5,
            this.cmsSocketList_ToExcel,
            this.toolStripSeparator3,
            this.cmsSocketList_Comparison_A,
            this.cmsSocketList_Comparison_B});
            this.cmsSocketList.Name = "cmsSocketInfo";
            resources.ApplyResources(this.cmsSocketList, "cmsSocketList");
            this.cmsSocketList.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsSocketList_ItemClicked);
            // 
            // cmsSocketList_Send
            // 
            this.cmsSocketList_Send.Image = global::WPELibrary.Properties.Resources.sent;
            resources.ApplyResources(this.cmsSocketList_Send, "cmsSocketList_Send");
            this.cmsSocketList_Send.Name = "cmsSocketList_Send";
            // 
            // cmsSocketList_tss1
            // 
            this.cmsSocketList_tss1.Name = "cmsSocketList_tss1";
            resources.ApplyResources(this.cmsSocketList_tss1, "cmsSocketList_tss1");
            // 
            // cmsSocketList_UseSocket
            // 
            this.cmsSocketList_UseSocket.Image = global::WPELibrary.Properties.Resources.Info16;
            resources.ApplyResources(this.cmsSocketList_UseSocket, "cmsSocketList_UseSocket");
            this.cmsSocketList_UseSocket.Name = "cmsSocketList_UseSocket";
            // 
            // tss4
            // 
            this.tss4.Name = "tss4";
            resources.ApplyResources(this.tss4, "tss4");
            // 
            // cmsSocketList_ShowSendList
            // 
            this.cmsSocketList_ShowSendList.Image = global::WPELibrary.Properties.Resources.File_info16;
            resources.ApplyResources(this.cmsSocketList_ShowSendList, "cmsSocketList_ShowSendList");
            this.cmsSocketList_ShowSendList.Name = "cmsSocketList_ShowSendList";
            // 
            // tss5
            // 
            this.tss5.Name = "tss5";
            resources.ApplyResources(this.tss5, "tss5");
            // 
            // cmsSocketList_ToExcel
            // 
            this.cmsSocketList_ToExcel.Image = global::WPELibrary.Properties.Resources.saveHS;
            resources.ApplyResources(this.cmsSocketList_ToExcel, "cmsSocketList_ToExcel");
            this.cmsSocketList_ToExcel.Name = "cmsSocketList_ToExcel";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // cmsSocketList_Comparison_A
            // 
            this.cmsSocketList_Comparison_A.Image = global::WPELibrary.Properties.Resources.CopyHS;
            resources.ApplyResources(this.cmsSocketList_Comparison_A, "cmsSocketList_Comparison_A");
            this.cmsSocketList_Comparison_A.Name = "cmsSocketList_Comparison_A";
            // 
            // cmsSocketList_Comparison_B
            // 
            this.cmsSocketList_Comparison_B.Image = global::WPELibrary.Properties.Resources.CopyHS;
            resources.ApplyResources(this.cmsSocketList_Comparison_B, "cmsSocketList_Comparison_B");
            this.cmsSocketList_Comparison_B.Name = "cmsSocketList_Comparison_B";
            // 
            // tlpParameter
            // 
            resources.ApplyResources(this.tlpParameter, "tlpParameter");
            this.tlpParameter.Controls.Add(this.gbSocketList_Set, 2, 0);
            this.tlpParameter.Controls.Add(this.gbFilterSet, 0, 0);
            this.tlpParameter.Controls.Add(this.gbHookType, 1, 0);
            this.tlpParameter.Controls.Add(this.gbHookButton_Search, 3, 0);
            this.tlpParameter.Controls.Add(this.tlpHookButton, 4, 0);
            this.tlpParameter.Name = "tlpParameter";
            // 
            // gbSocketList_Set
            // 
            this.gbSocketList_Set.Controls.Add(this.tlpSocketList_Set);
            resources.ApplyResources(this.gbSocketList_Set, "gbSocketList_Set");
            this.gbSocketList_Set.Name = "gbSocketList_Set";
            this.gbSocketList_Set.TabStop = false;
            // 
            // tlpSocketList_Set
            // 
            resources.ApplyResources(this.tlpSocketList_Set, "tlpSocketList_Set");
            this.tlpSocketList_Set.Controls.Add(this.nudSocketList_AutoClearValue, 0, 2);
            this.tlpSocketList_Set.Controls.Add(this.cbSocketList_AutoClear, 0, 1);
            this.tlpSocketList_Set.Controls.Add(this.cbSocketList_AutoRoll, 0, 0);
            this.tlpSocketList_Set.Name = "tlpSocketList_Set";
            // 
            // nudSocketList_AutoClearValue
            // 
            resources.ApplyResources(this.nudSocketList_AutoClearValue, "nudSocketList_AutoClearValue");
            this.nudSocketList_AutoClearValue.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudSocketList_AutoClearValue.Name = "nudSocketList_AutoClearValue";
            this.nudSocketList_AutoClearValue.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // cbSocketList_AutoClear
            // 
            resources.ApplyResources(this.cbSocketList_AutoClear, "cbSocketList_AutoClear");
            this.cbSocketList_AutoClear.Name = "cbSocketList_AutoClear";
            this.cbSocketList_AutoClear.UseVisualStyleBackColor = true;
            this.cbSocketList_AutoClear.CheckedChanged += new System.EventHandler(this.cbSocketList_AutoClear_CheckedChanged);
            // 
            // cbSocketList_AutoRoll
            // 
            resources.ApplyResources(this.cbSocketList_AutoRoll, "cbSocketList_AutoRoll");
            this.cbSocketList_AutoRoll.Name = "cbSocketList_AutoRoll";
            this.cbSocketList_AutoRoll.UseVisualStyleBackColor = true;
            // 
            // gbFilterSet
            // 
            this.gbFilterSet.Controls.Add(this.tlpFilterSet);
            resources.ApplyResources(this.gbFilterSet, "gbFilterSet");
            this.gbFilterSet.Name = "gbFilterSet";
            this.gbFilterSet.TabStop = false;
            // 
            // tlpFilterSet
            // 
            resources.ApplyResources(this.tlpFilterSet, "tlpFilterSet");
            this.tlpFilterSet.Controls.Add(this.tlpFilterSet_PacketLength, 3, 0);
            this.tlpFilterSet.Controls.Add(this.cbCheckSize, 2, 0);
            this.tlpFilterSet.Controls.Add(this.rbFilter_Show, 1, 0);
            this.tlpFilterSet.Controls.Add(this.rbFilter_NotShow, 0, 0);
            this.tlpFilterSet.Controls.Add(this.txtCheckPort, 3, 2);
            this.tlpFilterSet.Controls.Add(this.cbCheckPort, 2, 2);
            this.tlpFilterSet.Controls.Add(this.txtCheckData, 3, 1);
            this.tlpFilterSet.Controls.Add(this.cbCheckData, 2, 1);
            this.tlpFilterSet.Controls.Add(this.cbCheckSocket, 0, 1);
            this.tlpFilterSet.Controls.Add(this.cbCheckIP, 0, 2);
            this.tlpFilterSet.Controls.Add(this.txtCheckSocket, 1, 1);
            this.tlpFilterSet.Controls.Add(this.txtCheckIP, 1, 2);
            this.tlpFilterSet.Name = "tlpFilterSet";
            // 
            // tlpFilterSet_PacketLength
            // 
            resources.ApplyResources(this.tlpFilterSet_PacketLength, "tlpFilterSet_PacketLength");
            this.tlpFilterSet_PacketLength.Controls.Add(this.nudCheckSizeTo, 2, 0);
            this.tlpFilterSet_PacketLength.Controls.Add(this.lCheck_Size, 1, 0);
            this.tlpFilterSet_PacketLength.Controls.Add(this.nudCheckSizeFrom, 0, 0);
            this.tlpFilterSet_PacketLength.Name = "tlpFilterSet_PacketLength";
            // 
            // nudCheckSizeTo
            // 
            resources.ApplyResources(this.nudCheckSizeTo, "nudCheckSizeTo");
            this.nudCheckSizeTo.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudCheckSizeTo.Name = "nudCheckSizeTo";
            this.nudCheckSizeTo.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lCheck_Size
            // 
            resources.ApplyResources(this.lCheck_Size, "lCheck_Size");
            this.lCheck_Size.Name = "lCheck_Size";
            // 
            // nudCheckSizeFrom
            // 
            resources.ApplyResources(this.nudCheckSizeFrom, "nudCheckSizeFrom");
            this.nudCheckSizeFrom.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudCheckSizeFrom.Name = "nudCheckSizeFrom";
            // 
            // cbCheckSize
            // 
            resources.ApplyResources(this.cbCheckSize, "cbCheckSize");
            this.cbCheckSize.Name = "cbCheckSize";
            this.cbCheckSize.UseVisualStyleBackColor = true;
            // 
            // rbFilter_Show
            // 
            resources.ApplyResources(this.rbFilter_Show, "rbFilter_Show");
            this.rbFilter_Show.Name = "rbFilter_Show";
            this.rbFilter_Show.UseVisualStyleBackColor = true;
            // 
            // rbFilter_NotShow
            // 
            resources.ApplyResources(this.rbFilter_NotShow, "rbFilter_NotShow");
            this.rbFilter_NotShow.Checked = true;
            this.rbFilter_NotShow.Name = "rbFilter_NotShow";
            this.rbFilter_NotShow.TabStop = true;
            this.rbFilter_NotShow.UseVisualStyleBackColor = true;
            // 
            // txtCheckPort
            // 
            this.txtCheckPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtCheckPort, "txtCheckPort");
            this.txtCheckPort.Name = "txtCheckPort";
            this.txtCheckPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCheck_Port_KeyPress);
            // 
            // cbCheckPort
            // 
            resources.ApplyResources(this.cbCheckPort, "cbCheckPort");
            this.cbCheckPort.Name = "cbCheckPort";
            this.cbCheckPort.UseVisualStyleBackColor = true;
            // 
            // txtCheckData
            // 
            this.txtCheckData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheckData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtCheckData, "txtCheckData");
            this.txtCheckData.Name = "txtCheckData";
            this.txtCheckData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCheck_Packet_KeyPress);
            // 
            // cbCheckData
            // 
            resources.ApplyResources(this.cbCheckData, "cbCheckData");
            this.cbCheckData.Name = "cbCheckData";
            this.cbCheckData.UseVisualStyleBackColor = true;
            // 
            // cbCheckSocket
            // 
            resources.ApplyResources(this.cbCheckSocket, "cbCheckSocket");
            this.cbCheckSocket.Name = "cbCheckSocket";
            this.cbCheckSocket.UseVisualStyleBackColor = true;
            // 
            // cbCheckIP
            // 
            resources.ApplyResources(this.cbCheckIP, "cbCheckIP");
            this.cbCheckIP.Name = "cbCheckIP";
            this.cbCheckIP.UseVisualStyleBackColor = true;
            // 
            // txtCheckSocket
            // 
            this.txtCheckSocket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtCheckSocket, "txtCheckSocket");
            this.txtCheckSocket.Name = "txtCheckSocket";
            this.txtCheckSocket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCheck_Socket_KeyPress);
            // 
            // txtCheckIP
            // 
            this.txtCheckIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtCheckIP, "txtCheckIP");
            this.txtCheckIP.Name = "txtCheckIP";
            this.txtCheckIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCheck_IP_KeyPress);
            // 
            // gbHookType
            // 
            this.gbHookType.Controls.Add(this.tlpHookType);
            resources.ApplyResources(this.gbHookType, "gbHookType");
            this.gbHookType.Name = "gbHookType";
            this.gbHookType.TabStop = false;
            // 
            // tlpHookType
            // 
            resources.ApplyResources(this.tlpHookType, "tlpHookType");
            this.tlpHookType.Controls.Add(this.cbHookRecvFrom, 0, 3);
            this.tlpHookType.Controls.Add(this.cbHookSend, 0, 0);
            this.tlpHookType.Controls.Add(this.cbHookSendTo, 0, 1);
            this.tlpHookType.Controls.Add(this.cbHookRecv, 0, 2);
            this.tlpHookType.Controls.Add(this.cbHookWSASend, 1, 0);
            this.tlpHookType.Controls.Add(this.cbHookWSASendTo, 1, 1);
            this.tlpHookType.Controls.Add(this.cbHookWSARecv, 1, 2);
            this.tlpHookType.Controls.Add(this.cbHookWSARecvFrom, 1, 3);
            this.tlpHookType.Name = "tlpHookType";
            // 
            // cbHookRecvFrom
            // 
            resources.ApplyResources(this.cbHookRecvFrom, "cbHookRecvFrom");
            this.cbHookRecvFrom.Checked = true;
            this.cbHookRecvFrom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHookRecvFrom.Name = "cbHookRecvFrom";
            this.cbHookRecvFrom.UseVisualStyleBackColor = true;
            // 
            // cbHookSend
            // 
            resources.ApplyResources(this.cbHookSend, "cbHookSend");
            this.cbHookSend.Checked = true;
            this.cbHookSend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHookSend.Name = "cbHookSend";
            this.cbHookSend.UseVisualStyleBackColor = true;
            // 
            // cbHookSendTo
            // 
            resources.ApplyResources(this.cbHookSendTo, "cbHookSendTo");
            this.cbHookSendTo.Checked = true;
            this.cbHookSendTo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHookSendTo.Name = "cbHookSendTo";
            this.cbHookSendTo.UseVisualStyleBackColor = true;
            // 
            // cbHookRecv
            // 
            resources.ApplyResources(this.cbHookRecv, "cbHookRecv");
            this.cbHookRecv.Checked = true;
            this.cbHookRecv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHookRecv.Name = "cbHookRecv";
            this.cbHookRecv.UseVisualStyleBackColor = true;
            // 
            // cbHookWSASend
            // 
            resources.ApplyResources(this.cbHookWSASend, "cbHookWSASend");
            this.cbHookWSASend.Checked = true;
            this.cbHookWSASend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHookWSASend.Name = "cbHookWSASend";
            this.cbHookWSASend.UseVisualStyleBackColor = true;
            // 
            // cbHookWSASendTo
            // 
            resources.ApplyResources(this.cbHookWSASendTo, "cbHookWSASendTo");
            this.cbHookWSASendTo.Checked = true;
            this.cbHookWSASendTo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHookWSASendTo.Name = "cbHookWSASendTo";
            this.cbHookWSASendTo.UseVisualStyleBackColor = true;
            // 
            // cbHookWSARecv
            // 
            resources.ApplyResources(this.cbHookWSARecv, "cbHookWSARecv");
            this.cbHookWSARecv.Checked = true;
            this.cbHookWSARecv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHookWSARecv.Name = "cbHookWSARecv";
            this.cbHookWSARecv.UseVisualStyleBackColor = true;
            // 
            // cbHookWSARecvFrom
            // 
            resources.ApplyResources(this.cbHookWSARecvFrom, "cbHookWSARecvFrom");
            this.cbHookWSARecvFrom.Checked = true;
            this.cbHookWSARecvFrom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHookWSARecvFrom.Name = "cbHookWSARecvFrom";
            this.cbHookWSARecvFrom.UseVisualStyleBackColor = true;
            // 
            // gbHookButton_Search
            // 
            this.gbHookButton_Search.Controls.Add(this.tlpSearch);
            resources.ApplyResources(this.gbHookButton_Search, "gbHookButton_Search");
            this.gbHookButton_Search.Name = "gbHookButton_Search";
            this.gbHookButton_Search.TabStop = false;
            // 
            // tlpSearch
            // 
            resources.ApplyResources(this.tlpSearch, "tlpSearch");
            this.tlpSearch.Controls.Add(this.rbFromIndex, 0, 1);
            this.tlpSearch.Controls.Add(this.rbFromHead, 0, 0);
            this.tlpSearch.Controls.Add(this.tlpSearchButton, 0, 2);
            this.tlpSearch.Name = "tlpSearch";
            // 
            // rbFromIndex
            // 
            resources.ApplyResources(this.rbFromIndex, "rbFromIndex");
            this.rbFromIndex.Name = "rbFromIndex";
            this.rbFromIndex.UseVisualStyleBackColor = true;
            // 
            // rbFromHead
            // 
            resources.ApplyResources(this.rbFromHead, "rbFromHead");
            this.rbFromHead.Checked = true;
            this.rbFromHead.Name = "rbFromHead";
            this.rbFromHead.TabStop = true;
            this.rbFromHead.UseVisualStyleBackColor = true;
            // 
            // tlpSearchButton
            // 
            resources.ApplyResources(this.tlpSearchButton, "tlpSearchButton");
            this.tlpSearchButton.Controls.Add(this.bSearchNext, 2, 0);
            this.tlpSearchButton.Controls.Add(this.bSearch, 0, 0);
            this.tlpSearchButton.Name = "tlpSearchButton";
            // 
            // bSearchNext
            // 
            resources.ApplyResources(this.bSearchNext, "bSearchNext");
            this.bSearchNext.FlatAppearance.BorderSize = 0;
            this.bSearchNext.Image = global::WPELibrary.Properties.Resources.Search16;
            this.bSearchNext.Name = "bSearchNext";
            this.bSearchNext.UseVisualStyleBackColor = true;
            this.bSearchNext.Click += new System.EventHandler(this.bSearchNext_Click);
            // 
            // bSearch
            // 
            resources.ApplyResources(this.bSearch, "bSearch");
            this.bSearch.FlatAppearance.BorderSize = 0;
            this.bSearch.Image = global::WPELibrary.Properties.Resources.File_info16;
            this.bSearch.Name = "bSearch";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // tlpHookButton
            // 
            resources.ApplyResources(this.tlpHookButton, "tlpHookButton");
            this.tlpHookButton.Controls.Add(this.tlpHookButton_Start, 3, 1);
            this.tlpHookButton.Controls.Add(this.bCleanUp, 1, 1);
            this.tlpHookButton.Name = "tlpHookButton";
            // 
            // tlpHookButton_Start
            // 
            resources.ApplyResources(this.tlpHookButton_Start, "tlpHookButton_Start");
            this.tlpHookButton_Start.Controls.Add(this.bStopHook, 0, 2);
            this.tlpHookButton_Start.Controls.Add(this.bStartHook, 0, 0);
            this.tlpHookButton_Start.Name = "tlpHookButton_Start";
            // 
            // bStopHook
            // 
            resources.ApplyResources(this.bStopHook, "bStopHook");
            this.bStopHook.Image = global::WPELibrary.Properties.Resources.Stop16;
            this.bStopHook.Name = "bStopHook";
            this.bStopHook.UseVisualStyleBackColor = true;
            this.bStopHook.Click += new System.EventHandler(this.bStopHook_Click);
            // 
            // bStartHook
            // 
            resources.ApplyResources(this.bStartHook, "bStartHook");
            this.bStartHook.Image = global::WPELibrary.Properties.Resources.Play16;
            this.bStartHook.Name = "bStartHook";
            this.bStartHook.UseVisualStyleBackColor = true;
            this.bStartHook.Click += new System.EventHandler(this.bStartHook_Click);
            // 
            // bCleanUp
            // 
            resources.ApplyResources(this.bCleanUp, "bCleanUp");
            this.bCleanUp.Name = "bCleanUp";
            this.bCleanUp.UseVisualStyleBackColor = true;
            this.bCleanUp.Click += new System.EventHandler(this.bCleanUp_Click);
            // 
            // tlpInformation
            // 
            resources.ApplyResources(this.tlpInformation, "tlpInformation");
            this.tlpInformation.Controls.Add(this.gbFilterList, 0, 0);
            this.tlpInformation.Controls.Add(this.tlpPacketInfo, 1, 0);
            this.tlpInformation.Name = "tlpInformation";
            // 
            // gbFilterList
            // 
            this.gbFilterList.Controls.Add(this.tlpFilterList);
            resources.ApplyResources(this.gbFilterList, "gbFilterList");
            this.gbFilterList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbFilterList.Name = "gbFilterList";
            this.gbFilterList.TabStop = false;
            // 
            // tlpFilterList
            // 
            resources.ApplyResources(this.tlpFilterList, "tlpFilterList");
            this.tlpFilterList.Controls.Add(this.dgvFilterList, 0, 1);
            this.tlpFilterList.Controls.Add(this.tsFilterList, 0, 0);
            this.tlpFilterList.Name = "tlpFilterList";
            // 
            // dgvFilterList
            // 
            this.dgvFilterList.AllowUserToAddRows = false;
            this.dgvFilterList.AllowUserToDeleteRows = false;
            this.dgvFilterList.AllowUserToResizeColumns = false;
            this.dgvFilterList.AllowUserToResizeRows = false;
            this.dgvFilterList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFilterList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFilterList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFilterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilterList.ColumnHeadersVisible = false;
            this.dgvFilterList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIsCheck,
            this.cFNum,
            this.cFName});
            resources.ApplyResources(this.dgvFilterList, "dgvFilterList");
            this.dgvFilterList.MultiSelect = false;
            this.dgvFilterList.Name = "dgvFilterList";
            this.dgvFilterList.RowHeadersVisible = false;
            this.dgvFilterList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dgvFilterList.RowTemplate.Height = 25;
            this.dgvFilterList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilterList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilterList_CellContentClick);
            this.dgvFilterList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilterList_CellDoubleClick);
            // 
            // cIsCheck
            // 
            this.cIsCheck.DataPropertyName = "IsEnable";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.NullValue = false;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cIsCheck.DefaultCellStyle = dataGridViewCellStyle10;
            this.cIsCheck.FalseValue = "false";
            resources.ApplyResources(this.cIsCheck, "cIsCheck");
            this.cIsCheck.Name = "cIsCheck";
            this.cIsCheck.TrueValue = "true";
            // 
            // cFNum
            // 
            this.cFNum.DataPropertyName = "FNum";
            resources.ApplyResources(this.cFNum, "cFNum");
            this.cFNum.Name = "cFNum";
            this.cFNum.ReadOnly = true;
            // 
            // cFName
            // 
            this.cFName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cFName.DataPropertyName = "FName";
            resources.ApplyResources(this.cFName, "cFName");
            this.cFName.Name = "cFName";
            this.cFName.ReadOnly = true;
            // 
            // tsFilterList
            // 
            this.tsFilterList.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.tsFilterList, "tsFilterList");
            this.tsFilterList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFilterList_Load,
            this.tsFilterList_Save,
            this.toolStripSeparator1,
            this.tsFilterList_Add,
            this.tsFilterList_Edit,
            this.toolStripSeparator2,
            this.tsFilterList_Delete,
            this.tsFilterList_CleanUp});
            this.tsFilterList.Name = "tsFilterList";
            // 
            // tsFilterList_Load
            // 
            this.tsFilterList_Load.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFilterList_Load.Image = global::WPELibrary.Properties.Resources.openHS;
            resources.ApplyResources(this.tsFilterList_Load, "tsFilterList_Load");
            this.tsFilterList_Load.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tsFilterList_Load.Name = "tsFilterList_Load";
            this.tsFilterList_Load.Click += new System.EventHandler(this.tsFilterList_Load_Click);
            // 
            // tsFilterList_Save
            // 
            this.tsFilterList_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFilterList_Save.Image = global::WPELibrary.Properties.Resources.saveHS;
            resources.ApplyResources(this.tsFilterList_Save, "tsFilterList_Save");
            this.tsFilterList_Save.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tsFilterList_Save.Name = "tsFilterList_Save";
            this.tsFilterList_Save.Click += new System.EventHandler(this.tsFilterList_Save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // tsFilterList_Add
            // 
            this.tsFilterList_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFilterList_Add.Image = global::WPELibrary.Properties.Resources.PasteHS;
            resources.ApplyResources(this.tsFilterList_Add, "tsFilterList_Add");
            this.tsFilterList_Add.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tsFilterList_Add.Name = "tsFilterList_Add";
            this.tsFilterList_Add.Click += new System.EventHandler(this.tsFilterList_Add_Click);
            // 
            // tsFilterList_Edit
            // 
            this.tsFilterList_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFilterList_Edit.Image = global::WPELibrary.Properties.Resources.Edit24;
            resources.ApplyResources(this.tsFilterList_Edit, "tsFilterList_Edit");
            this.tsFilterList_Edit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tsFilterList_Edit.Name = "tsFilterList_Edit";
            this.tsFilterList_Edit.Click += new System.EventHandler(this.tsFilterList_Edit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // tsFilterList_Delete
            // 
            this.tsFilterList_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFilterList_Delete.Image = global::WPELibrary.Properties.Resources.Delete216;
            resources.ApplyResources(this.tsFilterList_Delete, "tsFilterList_Delete");
            this.tsFilterList_Delete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tsFilterList_Delete.Name = "tsFilterList_Delete";
            this.tsFilterList_Delete.Click += new System.EventHandler(this.tsFilterList_Delete_Click);
            // 
            // tsFilterList_CleanUp
            // 
            this.tsFilterList_CleanUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFilterList_CleanUp.Image = global::WPELibrary.Properties.Resources.Trash_can16;
            resources.ApplyResources(this.tsFilterList_CleanUp, "tsFilterList_CleanUp");
            this.tsFilterList_CleanUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tsFilterList_CleanUp.Name = "tsFilterList_CleanUp";
            this.tsFilterList_CleanUp.Click += new System.EventHandler(this.tsFilterList_CleanUp_Click);
            // 
            // tlpPacketInfo
            // 
            resources.ApplyResources(this.tlpPacketInfo, "tlpPacketInfo");
            this.tlpPacketInfo.Controls.Add(this.tcPacketInfo, 0, 0);
            this.tlpPacketInfo.Name = "tlpPacketInfo";
            // 
            // tcPacketInfo
            // 
            this.tcPacketInfo.Controls.Add(this.tpPacketData);
            this.tcPacketInfo.Controls.Add(this.tpComparison);
            this.tcPacketInfo.Controls.Add(this.tpXOR);
            this.tcPacketInfo.Controls.Add(this.tpEncoding);
            this.tcPacketInfo.Controls.Add(this.tpSystemLog);
            resources.ApplyResources(this.tcPacketInfo, "tcPacketInfo");
            this.tcPacketInfo.Multiline = true;
            this.tcPacketInfo.Name = "tcPacketInfo";
            this.tcPacketInfo.SelectedIndex = 0;
            // 
            // tpPacketData
            // 
            this.tpPacketData.Controls.Add(this.tlpPacketData);
            resources.ApplyResources(this.tpPacketData, "tpPacketData");
            this.tpPacketData.Name = "tpPacketData";
            this.tpPacketData.UseVisualStyleBackColor = true;
            // 
            // tlpPacketData
            // 
            this.tlpPacketData.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.tlpPacketData, "tlpPacketData");
            this.tlpPacketData.Controls.Add(this.tlpHexBox, 0, 0);
            this.tlpPacketData.Name = "tlpPacketData";
            // 
            // tlpHexBox
            // 
            resources.ApplyResources(this.tlpHexBox, "tlpHexBox");
            this.tlpHexBox.Controls.Add(this.hbPacketData, 0, 0);
            this.tlpHexBox.Name = "tlpHexBox";
            // 
            // hbPacketData
            // 
            this.hbPacketData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // 
            // 
            this.hbPacketData.BuiltInContextMenu.CopyMenuItemImage = global::WPELibrary.Properties.Resources.CopyHS;
            this.hbPacketData.BuiltInContextMenu.CopyMenuItemText = resources.GetString("hbPacketData.BuiltInContextMenu.CopyMenuItemText");
            this.hbPacketData.BuiltInContextMenu.CutMenuItemImage = global::WPELibrary.Properties.Resources.CutHS;
            this.hbPacketData.BuiltInContextMenu.CutMenuItemText = resources.GetString("hbPacketData.BuiltInContextMenu.CutMenuItemText");
            this.hbPacketData.BuiltInContextMenu.PasteMenuItemImage = global::WPELibrary.Properties.Resources.PasteHS;
            this.hbPacketData.BuiltInContextMenu.PasteMenuItemText = resources.GetString("hbPacketData.BuiltInContextMenu.PasteMenuItemText");
            this.hbPacketData.BuiltInContextMenu.SelectAllMenuItemText = resources.GetString("hbPacketData.BuiltInContextMenu.SelectAllMenuItemText");
            this.hbPacketData.ColumnInfoVisible = true;
            this.hbPacketData.ContextMenuStrip = this.cmsHexBox;
            resources.ApplyResources(this.hbPacketData, "hbPacketData");
            this.hbPacketData.LineInfoVisible = true;
            this.hbPacketData.Name = "hbPacketData";
            this.hbPacketData.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hbPacketData.StringViewVisible = true;
            this.hbPacketData.VScrollBarVisible = true;
            // 
            // cmsHexBox
            // 
            this.cmsHexBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsHexBox_Send,
            this.cmsHexBox_tss1,
            this.cmsHexBox_SendList,
            this.cmsHexBox_tss2,
            this.cmsHexBox_FilterList,
            this.cmsHexBox_tss3,
            this.cmsHexBox_CopyHex,
            this.cmsHexBox_CopyText,
            this.cmsHexBox_tss4,
            this.cmsHexBox_SelectAll});
            this.cmsHexBox.Name = "cmsHexBox";
            resources.ApplyResources(this.cmsHexBox, "cmsHexBox");
            this.cmsHexBox.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsHexBox_ItemClicked);
            // 
            // cmsHexBox_Send
            // 
            this.cmsHexBox_Send.Image = global::WPELibrary.Properties.Resources.sent;
            resources.ApplyResources(this.cmsHexBox_Send, "cmsHexBox_Send");
            this.cmsHexBox_Send.Name = "cmsHexBox_Send";
            // 
            // cmsHexBox_tss1
            // 
            this.cmsHexBox_tss1.Name = "cmsHexBox_tss1";
            resources.ApplyResources(this.cmsHexBox_tss1, "cmsHexBox_tss1");
            // 
            // cmsHexBox_SendList
            // 
            this.cmsHexBox_SendList.Image = global::WPELibrary.Properties.Resources.File_info16;
            resources.ApplyResources(this.cmsHexBox_SendList, "cmsHexBox_SendList");
            this.cmsHexBox_SendList.Name = "cmsHexBox_SendList";
            // 
            // cmsHexBox_tss2
            // 
            this.cmsHexBox_tss2.Name = "cmsHexBox_tss2";
            resources.ApplyResources(this.cmsHexBox_tss2, "cmsHexBox_tss2");
            // 
            // cmsHexBox_FilterList
            // 
            this.cmsHexBox_FilterList.Image = global::WPELibrary.Properties.Resources.File_info16;
            resources.ApplyResources(this.cmsHexBox_FilterList, "cmsHexBox_FilterList");
            this.cmsHexBox_FilterList.Name = "cmsHexBox_FilterList";
            // 
            // cmsHexBox_tss3
            // 
            this.cmsHexBox_tss3.Name = "cmsHexBox_tss3";
            resources.ApplyResources(this.cmsHexBox_tss3, "cmsHexBox_tss3");
            // 
            // cmsHexBox_CopyHex
            // 
            this.cmsHexBox_CopyHex.Image = global::WPELibrary.Properties.Resources.CopyHS;
            this.cmsHexBox_CopyHex.Name = "cmsHexBox_CopyHex";
            resources.ApplyResources(this.cmsHexBox_CopyHex, "cmsHexBox_CopyHex");
            // 
            // cmsHexBox_CopyText
            // 
            this.cmsHexBox_CopyText.Image = global::WPELibrary.Properties.Resources.CopyHS;
            this.cmsHexBox_CopyText.Name = "cmsHexBox_CopyText";
            resources.ApplyResources(this.cmsHexBox_CopyText, "cmsHexBox_CopyText");
            // 
            // cmsHexBox_tss4
            // 
            this.cmsHexBox_tss4.Name = "cmsHexBox_tss4";
            resources.ApplyResources(this.cmsHexBox_tss4, "cmsHexBox_tss4");
            // 
            // cmsHexBox_SelectAll
            // 
            this.cmsHexBox_SelectAll.Name = "cmsHexBox_SelectAll";
            resources.ApplyResources(this.cmsHexBox_SelectAll, "cmsHexBox_SelectAll");
            // 
            // tpComparison
            // 
            this.tpComparison.Controls.Add(this.tlpComparison);
            resources.ApplyResources(this.tpComparison, "tpComparison");
            this.tpComparison.Name = "tpComparison";
            this.tpComparison.UseVisualStyleBackColor = true;
            // 
            // tlpComparison
            // 
            this.tlpComparison.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.tlpComparison, "tlpComparison");
            this.tlpComparison.Controls.Add(this.tlpComparison_Button, 2, 0);
            this.tlpComparison.Controls.Add(this.lComparison_B, 1, 0);
            this.tlpComparison.Controls.Add(this.lComparison_A, 0, 0);
            this.tlpComparison.Controls.Add(this.pComparison_A, 0, 1);
            this.tlpComparison.Controls.Add(this.pComparison_B, 1, 1);
            this.tlpComparison.Controls.Add(this.pComparison_Result, 2, 1);
            this.tlpComparison.Name = "tlpComparison";
            // 
            // tlpComparison_Button
            // 
            this.tlpComparison_Button.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.tlpComparison_Button, "tlpComparison_Button");
            this.tlpComparison_Button.Controls.Add(this.bComparison_Exchange, 5, 0);
            this.tlpComparison_Button.Controls.Add(this.bComparison_Clear, 1, 0);
            this.tlpComparison_Button.Controls.Add(this.bComparison, 3, 0);
            this.tlpComparison_Button.Name = "tlpComparison_Button";
            // 
            // bComparison_Exchange
            // 
            resources.ApplyResources(this.bComparison_Exchange, "bComparison_Exchange");
            this.bComparison_Exchange.Name = "bComparison_Exchange";
            this.bComparison_Exchange.UseVisualStyleBackColor = true;
            this.bComparison_Exchange.Click += new System.EventHandler(this.bComparison_Exchange_Click);
            // 
            // bComparison_Clear
            // 
            resources.ApplyResources(this.bComparison_Clear, "bComparison_Clear");
            this.bComparison_Clear.Name = "bComparison_Clear";
            this.bComparison_Clear.UseVisualStyleBackColor = true;
            this.bComparison_Clear.Click += new System.EventHandler(this.bComparison_Clear_Click);
            // 
            // bComparison
            // 
            resources.ApplyResources(this.bComparison, "bComparison");
            this.bComparison.Name = "bComparison";
            this.bComparison.UseVisualStyleBackColor = true;
            this.bComparison.Click += new System.EventHandler(this.bComparison_Click);
            // 
            // lComparison_B
            // 
            resources.ApplyResources(this.lComparison_B, "lComparison_B");
            this.lComparison_B.BackColor = System.Drawing.SystemColors.Control;
            this.lComparison_B.Name = "lComparison_B";
            // 
            // lComparison_A
            // 
            resources.ApplyResources(this.lComparison_A, "lComparison_A");
            this.lComparison_A.BackColor = System.Drawing.SystemColors.Control;
            this.lComparison_A.Name = "lComparison_A";
            // 
            // pComparison_A
            // 
            this.pComparison_A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pComparison_A.Controls.Add(this.rtbComparison_A);
            resources.ApplyResources(this.pComparison_A, "pComparison_A");
            this.pComparison_A.Name = "pComparison_A";
            // 
            // rtbComparison_A
            // 
            this.rtbComparison_A.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.rtbComparison_A, "rtbComparison_A");
            this.rtbComparison_A.Name = "rtbComparison_A";
            this.rtbComparison_A.TextChanged += new System.EventHandler(this.rtbComparison_A_TextChanged);
            // 
            // pComparison_B
            // 
            this.pComparison_B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pComparison_B.Controls.Add(this.rtbComparison_B);
            resources.ApplyResources(this.pComparison_B, "pComparison_B");
            this.pComparison_B.Name = "pComparison_B";
            // 
            // rtbComparison_B
            // 
            this.rtbComparison_B.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.rtbComparison_B, "rtbComparison_B");
            this.rtbComparison_B.Name = "rtbComparison_B";
            this.rtbComparison_B.TextChanged += new System.EventHandler(this.rtbComparison_B_TextChanged);
            // 
            // pComparison_Result
            // 
            this.pComparison_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pComparison_Result.Controls.Add(this.rtbComparison_Result);
            resources.ApplyResources(this.pComparison_Result, "pComparison_Result");
            this.pComparison_Result.Name = "pComparison_Result";
            // 
            // rtbComparison_Result
            // 
            this.rtbComparison_Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.rtbComparison_Result, "rtbComparison_Result");
            this.rtbComparison_Result.Name = "rtbComparison_Result";
            // 
            // tpXOR
            // 
            this.tpXOR.Controls.Add(this.tlpPacketInfo_XOR);
            resources.ApplyResources(this.tpXOR, "tpXOR");
            this.tpXOR.Name = "tpXOR";
            this.tpXOR.UseVisualStyleBackColor = true;
            // 
            // tlpPacketInfo_XOR
            // 
            this.tlpPacketInfo_XOR.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.tlpPacketInfo_XOR, "tlpPacketInfo_XOR");
            this.tlpPacketInfo_XOR.Controls.Add(this.hbXOR_To, 0, 2);
            this.tlpPacketInfo_XOR.Controls.Add(this.tlpPacketInfo_XOR_Button, 0, 1);
            this.tlpPacketInfo_XOR.Controls.Add(this.hbXOR_From, 0, 0);
            this.tlpPacketInfo_XOR.Name = "tlpPacketInfo_XOR";
            // 
            // hbXOR_To
            // 
            this.hbXOR_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.hbXOR_To.BuiltInContextMenu.CopyMenuItemImage = global::WPELibrary.Properties.Resources.CopyHS;
            this.hbXOR_To.BuiltInContextMenu.CopyMenuItemText = resources.GetString("hbXOR_To.BuiltInContextMenu.CopyMenuItemText");
            this.hbXOR_To.BuiltInContextMenu.CutMenuItemImage = global::WPELibrary.Properties.Resources.CutHS;
            this.hbXOR_To.BuiltInContextMenu.CutMenuItemText = resources.GetString("hbXOR_To.BuiltInContextMenu.CutMenuItemText");
            this.hbXOR_To.BuiltInContextMenu.PasteMenuItemImage = global::WPELibrary.Properties.Resources.PasteHS;
            this.hbXOR_To.BuiltInContextMenu.PasteMenuItemText = resources.GetString("hbXOR_To.BuiltInContextMenu.PasteMenuItemText");
            this.hbXOR_To.BuiltInContextMenu.SelectAllMenuItemText = resources.GetString("hbXOR_To.BuiltInContextMenu.SelectAllMenuItemText");
            this.hbXOR_To.ColumnInfoVisible = true;
            resources.ApplyResources(this.hbXOR_To, "hbXOR_To");
            this.hbXOR_To.LineInfoVisible = true;
            this.hbXOR_To.Name = "hbXOR_To";
            this.hbXOR_To.ReadOnly = true;
            this.hbXOR_To.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hbXOR_To.VScrollBarVisible = true;
            // 
            // tlpPacketInfo_XOR_Button
            // 
            resources.ApplyResources(this.tlpPacketInfo_XOR_Button, "tlpPacketInfo_XOR_Button");
            this.tlpPacketInfo_XOR_Button.Controls.Add(this.lXOR2, 3, 0);
            this.tlpPacketInfo_XOR_Button.Controls.Add(this.bXOR_Clear, 6, 0);
            this.tlpPacketInfo_XOR_Button.Controls.Add(this.bXOR, 4, 0);
            this.tlpPacketInfo_XOR_Button.Controls.Add(this.lXOR, 1, 0);
            this.tlpPacketInfo_XOR_Button.Controls.Add(this.txtXOR, 2, 0);
            this.tlpPacketInfo_XOR_Button.Name = "tlpPacketInfo_XOR_Button";
            // 
            // lXOR2
            // 
            resources.ApplyResources(this.lXOR2, "lXOR2");
            this.lXOR2.Name = "lXOR2";
            // 
            // bXOR_Clear
            // 
            resources.ApplyResources(this.bXOR_Clear, "bXOR_Clear");
            this.bXOR_Clear.Name = "bXOR_Clear";
            this.bXOR_Clear.UseVisualStyleBackColor = true;
            this.bXOR_Clear.Click += new System.EventHandler(this.bXOR_Clear_Click);
            // 
            // bXOR
            // 
            resources.ApplyResources(this.bXOR, "bXOR");
            this.bXOR.Name = "bXOR";
            this.bXOR.UseVisualStyleBackColor = true;
            this.bXOR.Click += new System.EventHandler(this.bXOR_Click);
            // 
            // lXOR
            // 
            resources.ApplyResources(this.lXOR, "lXOR");
            this.lXOR.Name = "lXOR";
            // 
            // txtXOR
            // 
            this.txtXOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXOR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtXOR, "txtXOR");
            this.txtXOR.Name = "txtXOR";
            this.txtXOR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXOR_KeyPress);
            // 
            // hbXOR_From
            // 
            this.hbXOR_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.hbXOR_From.BuiltInContextMenu.CopyMenuItemImage = global::WPELibrary.Properties.Resources.CopyHS;
            this.hbXOR_From.BuiltInContextMenu.CopyMenuItemText = resources.GetString("hbXOR_From.BuiltInContextMenu.CopyMenuItemText");
            this.hbXOR_From.BuiltInContextMenu.CutMenuItemImage = global::WPELibrary.Properties.Resources.CutHS;
            this.hbXOR_From.BuiltInContextMenu.CutMenuItemText = resources.GetString("hbXOR_From.BuiltInContextMenu.CutMenuItemText");
            this.hbXOR_From.BuiltInContextMenu.PasteMenuItemImage = global::WPELibrary.Properties.Resources.PasteHS;
            this.hbXOR_From.BuiltInContextMenu.PasteMenuItemText = resources.GetString("hbXOR_From.BuiltInContextMenu.PasteMenuItemText");
            this.hbXOR_From.BuiltInContextMenu.SelectAllMenuItemText = resources.GetString("hbXOR_From.BuiltInContextMenu.SelectAllMenuItemText");
            this.hbXOR_From.ColumnInfoVisible = true;
            resources.ApplyResources(this.hbXOR_From, "hbXOR_From");
            this.hbXOR_From.LineInfoVisible = true;
            this.hbXOR_From.Name = "hbXOR_From";
            this.hbXOR_From.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hbXOR_From.VScrollBarVisible = true;
            // 
            // tpEncoding
            // 
            this.tpEncoding.Controls.Add(this.tlpPacketInfo_Encoding);
            resources.ApplyResources(this.tpEncoding, "tpEncoding");
            this.tpEncoding.Name = "tpEncoding";
            this.tpEncoding.UseVisualStyleBackColor = true;
            // 
            // tlpPacketInfo_Encoding
            // 
            this.tlpPacketInfo_Encoding.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.tlpPacketInfo_Encoding, "tlpPacketInfo_Encoding");
            this.tlpPacketInfo_Encoding.Controls.Add(this.tlpPacketInfo_Encoding_Button, 1, 0);
            this.tlpPacketInfo_Encoding.Controls.Add(this.tlpPacketInfo_Encoding_Result, 2, 0);
            this.tlpPacketInfo_Encoding.Controls.Add(this.pPacketInfo_Encoding, 0, 0);
            this.tlpPacketInfo_Encoding.Name = "tlpPacketInfo_Encoding";
            // 
            // tlpPacketInfo_Encoding_Button
            // 
            resources.ApplyResources(this.tlpPacketInfo_Encoding_Button, "tlpPacketInfo_Encoding_Button");
            this.tlpPacketInfo_Encoding_Button.Controls.Add(this.bPacketInfo_Decoding, 0, 3);
            this.tlpPacketInfo_Encoding_Button.Controls.Add(this.bPacketInfo_Encoding, 0, 1);
            this.tlpPacketInfo_Encoding_Button.Name = "tlpPacketInfo_Encoding_Button";
            // 
            // bPacketInfo_Decoding
            // 
            resources.ApplyResources(this.bPacketInfo_Decoding, "bPacketInfo_Decoding");
            this.bPacketInfo_Decoding.Name = "bPacketInfo_Decoding";
            this.bPacketInfo_Decoding.UseVisualStyleBackColor = true;
            this.bPacketInfo_Decoding.Click += new System.EventHandler(this.bPacketInfo_Decoding_Click);
            // 
            // bPacketInfo_Encoding
            // 
            resources.ApplyResources(this.bPacketInfo_Encoding, "bPacketInfo_Encoding");
            this.bPacketInfo_Encoding.Name = "bPacketInfo_Encoding";
            this.bPacketInfo_Encoding.UseVisualStyleBackColor = true;
            this.bPacketInfo_Encoding.Click += new System.EventHandler(this.bPacketInfo_Encoding_Click);
            // 
            // tlpPacketInfo_Encoding_Result
            // 
            resources.ApplyResources(this.tlpPacketInfo_Encoding_Result, "tlpPacketInfo_Encoding_Result");
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.txtPacketInfo_Encoding_ANSIUnicode, 3, 5);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.lPacketInfo_Encoding_ANSIUnicode, 2, 5);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.txtPacketInfo_Encoding_ANSIUTF32, 3, 4);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.lPacketInfo_Encoding_ANSIUTF32, 2, 4);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.txtPacketInfo_Encoding_ANSIUTF16, 3, 3);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.lPacketInfo_Encoding_ANSIASCII, 2, 3);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.txtPacketInfo_Encoding_Unicode, 1, 5);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.lPacketInfo_Encoding_Unicode, 0, 5);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.txtPacketInfo_Encoding_UTF32, 1, 4);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.lPacketInfo_Encoding_UTF32, 0, 4);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.txtPacketInfo_Encoding_UTF16, 1, 3);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.lPacketInfo_Encoding_ASCII, 0, 3);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.txtPacketInfo_Encoding_ANSIbase64, 3, 6);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.txtPacketInfo_Encoding_ANSIUTF8, 3, 2);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.txtPacketInfo_Encoding_ANSIUTF7, 3, 1);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.txtPacketInfo_Encoding_ANSIGBK, 3, 0);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.lPacketInfo_Encoding_ANSIbase64, 2, 6);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.lPacketInfo_Encoding_ANSIUTF8, 2, 2);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.lPacketInfo_Encoding_ANSIUTF7, 2, 1);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.lPacketInfo_Encoding_UTF7, 0, 1);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.lPacketInfo_Encoding_ANSIGBK, 2, 0);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.txtPacketInfo_Encoding_base64, 1, 6);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.txtPacketInfo_Encoding_UTF8, 1, 2);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.txtPacketInfo_Encoding_UTF7, 1, 1);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.lPacketInfo_Encoding_base64, 0, 6);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.lPacketInfo_Encoding_UTF8, 0, 2);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.lPacketInfo_Encoding_Bytes, 0, 0);
            this.tlpPacketInfo_Encoding_Result.Controls.Add(this.txtPacketInfo_Encoding_Bytes, 1, 0);
            this.tlpPacketInfo_Encoding_Result.Name = "tlpPacketInfo_Encoding_Result";
            // 
            // txtPacketInfo_Encoding_ANSIUnicode
            // 
            this.txtPacketInfo_Encoding_ANSIUnicode.BackColor = System.Drawing.SystemColors.Window;
            this.txtPacketInfo_Encoding_ANSIUnicode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPacketInfo_Encoding_ANSIUnicode, "txtPacketInfo_Encoding_ANSIUnicode");
            this.txtPacketInfo_Encoding_ANSIUnicode.Name = "txtPacketInfo_Encoding_ANSIUnicode";
            this.txtPacketInfo_Encoding_ANSIUnicode.ReadOnly = true;
            // 
            // lPacketInfo_Encoding_ANSIUnicode
            // 
            resources.ApplyResources(this.lPacketInfo_Encoding_ANSIUnicode, "lPacketInfo_Encoding_ANSIUnicode");
            this.lPacketInfo_Encoding_ANSIUnicode.Name = "lPacketInfo_Encoding_ANSIUnicode";
            // 
            // txtPacketInfo_Encoding_ANSIUTF32
            // 
            this.txtPacketInfo_Encoding_ANSIUTF32.BackColor = System.Drawing.SystemColors.Window;
            this.txtPacketInfo_Encoding_ANSIUTF32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPacketInfo_Encoding_ANSIUTF32, "txtPacketInfo_Encoding_ANSIUTF32");
            this.txtPacketInfo_Encoding_ANSIUTF32.Name = "txtPacketInfo_Encoding_ANSIUTF32";
            this.txtPacketInfo_Encoding_ANSIUTF32.ReadOnly = true;
            // 
            // lPacketInfo_Encoding_ANSIUTF32
            // 
            resources.ApplyResources(this.lPacketInfo_Encoding_ANSIUTF32, "lPacketInfo_Encoding_ANSIUTF32");
            this.lPacketInfo_Encoding_ANSIUTF32.Name = "lPacketInfo_Encoding_ANSIUTF32";
            // 
            // txtPacketInfo_Encoding_ANSIUTF16
            // 
            this.txtPacketInfo_Encoding_ANSIUTF16.BackColor = System.Drawing.SystemColors.Window;
            this.txtPacketInfo_Encoding_ANSIUTF16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPacketInfo_Encoding_ANSIUTF16, "txtPacketInfo_Encoding_ANSIUTF16");
            this.txtPacketInfo_Encoding_ANSIUTF16.Name = "txtPacketInfo_Encoding_ANSIUTF16";
            this.txtPacketInfo_Encoding_ANSIUTF16.ReadOnly = true;
            // 
            // lPacketInfo_Encoding_ANSIASCII
            // 
            resources.ApplyResources(this.lPacketInfo_Encoding_ANSIASCII, "lPacketInfo_Encoding_ANSIASCII");
            this.lPacketInfo_Encoding_ANSIASCII.Name = "lPacketInfo_Encoding_ANSIASCII";
            // 
            // txtPacketInfo_Encoding_Unicode
            // 
            this.txtPacketInfo_Encoding_Unicode.BackColor = System.Drawing.SystemColors.Window;
            this.txtPacketInfo_Encoding_Unicode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPacketInfo_Encoding_Unicode, "txtPacketInfo_Encoding_Unicode");
            this.txtPacketInfo_Encoding_Unicode.Name = "txtPacketInfo_Encoding_Unicode";
            this.txtPacketInfo_Encoding_Unicode.ReadOnly = true;
            // 
            // lPacketInfo_Encoding_Unicode
            // 
            resources.ApplyResources(this.lPacketInfo_Encoding_Unicode, "lPacketInfo_Encoding_Unicode");
            this.lPacketInfo_Encoding_Unicode.Name = "lPacketInfo_Encoding_Unicode";
            // 
            // txtPacketInfo_Encoding_UTF32
            // 
            this.txtPacketInfo_Encoding_UTF32.BackColor = System.Drawing.SystemColors.Window;
            this.txtPacketInfo_Encoding_UTF32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPacketInfo_Encoding_UTF32, "txtPacketInfo_Encoding_UTF32");
            this.txtPacketInfo_Encoding_UTF32.Name = "txtPacketInfo_Encoding_UTF32";
            this.txtPacketInfo_Encoding_UTF32.ReadOnly = true;
            // 
            // lPacketInfo_Encoding_UTF32
            // 
            resources.ApplyResources(this.lPacketInfo_Encoding_UTF32, "lPacketInfo_Encoding_UTF32");
            this.lPacketInfo_Encoding_UTF32.Name = "lPacketInfo_Encoding_UTF32";
            // 
            // txtPacketInfo_Encoding_UTF16
            // 
            this.txtPacketInfo_Encoding_UTF16.BackColor = System.Drawing.SystemColors.Window;
            this.txtPacketInfo_Encoding_UTF16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPacketInfo_Encoding_UTF16, "txtPacketInfo_Encoding_UTF16");
            this.txtPacketInfo_Encoding_UTF16.Name = "txtPacketInfo_Encoding_UTF16";
            this.txtPacketInfo_Encoding_UTF16.ReadOnly = true;
            // 
            // lPacketInfo_Encoding_ASCII
            // 
            resources.ApplyResources(this.lPacketInfo_Encoding_ASCII, "lPacketInfo_Encoding_ASCII");
            this.lPacketInfo_Encoding_ASCII.Name = "lPacketInfo_Encoding_ASCII";
            // 
            // txtPacketInfo_Encoding_ANSIbase64
            // 
            this.txtPacketInfo_Encoding_ANSIbase64.BackColor = System.Drawing.SystemColors.Window;
            this.txtPacketInfo_Encoding_ANSIbase64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPacketInfo_Encoding_ANSIbase64, "txtPacketInfo_Encoding_ANSIbase64");
            this.txtPacketInfo_Encoding_ANSIbase64.Name = "txtPacketInfo_Encoding_ANSIbase64";
            this.txtPacketInfo_Encoding_ANSIbase64.ReadOnly = true;
            // 
            // txtPacketInfo_Encoding_ANSIUTF8
            // 
            this.txtPacketInfo_Encoding_ANSIUTF8.BackColor = System.Drawing.SystemColors.Window;
            this.txtPacketInfo_Encoding_ANSIUTF8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPacketInfo_Encoding_ANSIUTF8, "txtPacketInfo_Encoding_ANSIUTF8");
            this.txtPacketInfo_Encoding_ANSIUTF8.Name = "txtPacketInfo_Encoding_ANSIUTF8";
            this.txtPacketInfo_Encoding_ANSIUTF8.ReadOnly = true;
            // 
            // txtPacketInfo_Encoding_ANSIUTF7
            // 
            this.txtPacketInfo_Encoding_ANSIUTF7.BackColor = System.Drawing.SystemColors.Window;
            this.txtPacketInfo_Encoding_ANSIUTF7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPacketInfo_Encoding_ANSIUTF7, "txtPacketInfo_Encoding_ANSIUTF7");
            this.txtPacketInfo_Encoding_ANSIUTF7.Name = "txtPacketInfo_Encoding_ANSIUTF7";
            this.txtPacketInfo_Encoding_ANSIUTF7.ReadOnly = true;
            // 
            // txtPacketInfo_Encoding_ANSIGBK
            // 
            this.txtPacketInfo_Encoding_ANSIGBK.BackColor = System.Drawing.SystemColors.Window;
            this.txtPacketInfo_Encoding_ANSIGBK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPacketInfo_Encoding_ANSIGBK, "txtPacketInfo_Encoding_ANSIGBK");
            this.txtPacketInfo_Encoding_ANSIGBK.Name = "txtPacketInfo_Encoding_ANSIGBK";
            this.txtPacketInfo_Encoding_ANSIGBK.ReadOnly = true;
            // 
            // lPacketInfo_Encoding_ANSIbase64
            // 
            resources.ApplyResources(this.lPacketInfo_Encoding_ANSIbase64, "lPacketInfo_Encoding_ANSIbase64");
            this.lPacketInfo_Encoding_ANSIbase64.Name = "lPacketInfo_Encoding_ANSIbase64";
            // 
            // lPacketInfo_Encoding_ANSIUTF8
            // 
            resources.ApplyResources(this.lPacketInfo_Encoding_ANSIUTF8, "lPacketInfo_Encoding_ANSIUTF8");
            this.lPacketInfo_Encoding_ANSIUTF8.Name = "lPacketInfo_Encoding_ANSIUTF8";
            // 
            // lPacketInfo_Encoding_ANSIUTF7
            // 
            resources.ApplyResources(this.lPacketInfo_Encoding_ANSIUTF7, "lPacketInfo_Encoding_ANSIUTF7");
            this.lPacketInfo_Encoding_ANSIUTF7.Name = "lPacketInfo_Encoding_ANSIUTF7";
            // 
            // lPacketInfo_Encoding_UTF7
            // 
            resources.ApplyResources(this.lPacketInfo_Encoding_UTF7, "lPacketInfo_Encoding_UTF7");
            this.lPacketInfo_Encoding_UTF7.Name = "lPacketInfo_Encoding_UTF7";
            // 
            // lPacketInfo_Encoding_ANSIGBK
            // 
            resources.ApplyResources(this.lPacketInfo_Encoding_ANSIGBK, "lPacketInfo_Encoding_ANSIGBK");
            this.lPacketInfo_Encoding_ANSIGBK.Name = "lPacketInfo_Encoding_ANSIGBK";
            // 
            // txtPacketInfo_Encoding_base64
            // 
            this.txtPacketInfo_Encoding_base64.BackColor = System.Drawing.SystemColors.Window;
            this.txtPacketInfo_Encoding_base64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPacketInfo_Encoding_base64, "txtPacketInfo_Encoding_base64");
            this.txtPacketInfo_Encoding_base64.Name = "txtPacketInfo_Encoding_base64";
            this.txtPacketInfo_Encoding_base64.ReadOnly = true;
            // 
            // txtPacketInfo_Encoding_UTF8
            // 
            this.txtPacketInfo_Encoding_UTF8.BackColor = System.Drawing.SystemColors.Window;
            this.txtPacketInfo_Encoding_UTF8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPacketInfo_Encoding_UTF8, "txtPacketInfo_Encoding_UTF8");
            this.txtPacketInfo_Encoding_UTF8.Name = "txtPacketInfo_Encoding_UTF8";
            this.txtPacketInfo_Encoding_UTF8.ReadOnly = true;
            // 
            // txtPacketInfo_Encoding_UTF7
            // 
            this.txtPacketInfo_Encoding_UTF7.BackColor = System.Drawing.SystemColors.Window;
            this.txtPacketInfo_Encoding_UTF7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPacketInfo_Encoding_UTF7, "txtPacketInfo_Encoding_UTF7");
            this.txtPacketInfo_Encoding_UTF7.Name = "txtPacketInfo_Encoding_UTF7";
            this.txtPacketInfo_Encoding_UTF7.ReadOnly = true;
            // 
            // lPacketInfo_Encoding_base64
            // 
            resources.ApplyResources(this.lPacketInfo_Encoding_base64, "lPacketInfo_Encoding_base64");
            this.lPacketInfo_Encoding_base64.Name = "lPacketInfo_Encoding_base64";
            // 
            // lPacketInfo_Encoding_UTF8
            // 
            resources.ApplyResources(this.lPacketInfo_Encoding_UTF8, "lPacketInfo_Encoding_UTF8");
            this.lPacketInfo_Encoding_UTF8.Name = "lPacketInfo_Encoding_UTF8";
            // 
            // lPacketInfo_Encoding_Bytes
            // 
            resources.ApplyResources(this.lPacketInfo_Encoding_Bytes, "lPacketInfo_Encoding_Bytes");
            this.lPacketInfo_Encoding_Bytes.Name = "lPacketInfo_Encoding_Bytes";
            // 
            // txtPacketInfo_Encoding_Bytes
            // 
            this.txtPacketInfo_Encoding_Bytes.BackColor = System.Drawing.SystemColors.Window;
            this.txtPacketInfo_Encoding_Bytes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPacketInfo_Encoding_Bytes, "txtPacketInfo_Encoding_Bytes");
            this.txtPacketInfo_Encoding_Bytes.Name = "txtPacketInfo_Encoding_Bytes";
            this.txtPacketInfo_Encoding_Bytes.ReadOnly = true;
            // 
            // pPacketInfo_Encoding
            // 
            this.pPacketInfo_Encoding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPacketInfo_Encoding.Controls.Add(this.rtbPacketInfo_Encoding);
            resources.ApplyResources(this.pPacketInfo_Encoding, "pPacketInfo_Encoding");
            this.pPacketInfo_Encoding.Name = "pPacketInfo_Encoding";
            // 
            // rtbPacketInfo_Encoding
            // 
            this.rtbPacketInfo_Encoding.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.rtbPacketInfo_Encoding, "rtbPacketInfo_Encoding");
            this.rtbPacketInfo_Encoding.Name = "rtbPacketInfo_Encoding";
            // 
            // tpSystemLog
            // 
            this.tpSystemLog.Controls.Add(this.dgvLogList);
            resources.ApplyResources(this.tpSystemLog, "tpSystemLog");
            this.tpSystemLog.Name = "tpSystemLog";
            this.tpSystemLog.UseVisualStyleBackColor = true;
            // 
            // dgvLogList
            // 
            this.dgvLogList.AllowUserToAddRows = false;
            this.dgvLogList.AllowUserToDeleteRows = false;
            this.dgvLogList.AllowUserToResizeColumns = false;
            this.dgvLogList.AllowUserToResizeRows = false;
            this.dgvLogList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLogList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvLogList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTime,
            this.cFuncName,
            this.cContent});
            this.dgvLogList.ContextMenuStrip = this.cmsLogList;
            resources.ApplyResources(this.dgvLogList, "dgvLogList");
            this.dgvLogList.MultiSelect = false;
            this.dgvLogList.Name = "dgvLogList";
            this.dgvLogList.ReadOnly = true;
            this.dgvLogList.RowHeadersVisible = false;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLogList.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvLogList.RowTemplate.Height = 23;
            this.dgvLogList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // cTime
            // 
            this.cTime.DataPropertyName = "Time";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cTime.DefaultCellStyle = dataGridViewCellStyle12;
            resources.ApplyResources(this.cTime, "cTime");
            this.cTime.Name = "cTime";
            this.cTime.ReadOnly = true;
            // 
            // cFuncName
            // 
            this.cFuncName.DataPropertyName = "FuncName";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cFuncName.DefaultCellStyle = dataGridViewCellStyle13;
            resources.ApplyResources(this.cFuncName, "cFuncName");
            this.cFuncName.Name = "cFuncName";
            this.cFuncName.ReadOnly = true;
            // 
            // cContent
            // 
            this.cContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cContent.DataPropertyName = "Content";
            resources.ApplyResources(this.cContent, "cContent");
            this.cContent.Name = "cContent";
            this.cContent.ReadOnly = true;
            // 
            // cmsLogList
            // 
            this.cmsLogList.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsLogList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsLogList_CleanUp,
            this.toolStripSeparator5,
            this.cmsLogList_ToExcel});
            this.cmsLogList.Name = "cmsLogList";
            resources.ApplyResources(this.cmsLogList, "cmsLogList");
            this.cmsLogList.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsLogList_ItemClicked);
            // 
            // cmsLogList_CleanUp
            // 
            this.cmsLogList_CleanUp.Image = global::WPELibrary.Properties.Resources.Trash_can16;
            resources.ApplyResources(this.cmsLogList_CleanUp, "cmsLogList_CleanUp");
            this.cmsLogList_CleanUp.Name = "cmsLogList_CleanUp";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // cmsLogList_ToExcel
            // 
            this.cmsLogList_ToExcel.Image = global::WPELibrary.Properties.Resources.saveHS;
            resources.ApplyResources(this.cmsLogList_ToExcel, "cmsLogList_ToExcel");
            this.cmsLogList_ToExcel.Name = "cmsLogList_ToExcel";
            // 
            // ssProcessInfo
            // 
            this.ssProcessInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslProcessName,
            this.toolStripStatusLabel1,
            this.tsslProcessInfo,
            this.toolStripStatusLabel4,
            this.tsslWinSock,
            this.toolStripStatusLabel3,
            this.tsslTotalBytes});
            resources.ApplyResources(this.ssProcessInfo, "ssProcessInfo");
            this.ssProcessInfo.Name = "ssProcessInfo";
            // 
            // tsslProcessName
            // 
            this.tsslProcessName.Name = "tsslProcessName";
            resources.ApplyResources(this.tsslProcessName, "tsslProcessName");
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.DarkGray;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // tsslProcessInfo
            // 
            this.tsslProcessInfo.Name = "tsslProcessInfo";
            resources.ApplyResources(this.tsslProcessInfo, "tsslProcessInfo");
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.ForeColor = System.Drawing.Color.DarkGray;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            resources.ApplyResources(this.toolStripStatusLabel4, "toolStripStatusLabel4");
            // 
            // tsslWinSock
            // 
            this.tsslWinSock.Name = "tsslWinSock";
            resources.ApplyResources(this.tsslWinSock, "tsslWinSock");
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.DarkGray;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            resources.ApplyResources(this.toolStripStatusLabel3, "toolStripStatusLabel3");
            // 
            // tsslTotalBytes
            // 
            this.tsslTotalBytes.Name = "tsslTotalBytes";
            resources.ApplyResources(this.tsslTotalBytes, "tsslTotalBytes");
            // 
            // bgwSocketList
            // 
            this.bgwSocketList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSocketList_DoWork);
            this.bgwSocketList.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSocketList_RunWorkerCompleted);
            // 
            // tSocketInfo
            // 
            this.tSocketInfo.Interval = 10;
            this.tSocketInfo.Tick += new System.EventHandler(this.tSocketInfo_Tick);
            // 
            // bgwLogList
            // 
            this.bgwLogList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLogList_DoWork);
            // 
            // bgwSearchPacketData
            // 
            this.bgwSearchPacketData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSearchPacketData_DoWork);
            this.bgwSearchPacketData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSearchPacketData_RunWorkerCompleted);
            // 
            // niWPE
            // 
            this.niWPE.ContextMenuStrip = this.cmsIcon;
            resources.ApplyResources(this.niWPE, "niWPE");
            this.niWPE.Click += new System.EventHandler(this.niWPE_Click);
            // 
            // cmsIcon
            // 
            this.cmsIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsIcon_Show,
            this.tss17,
            this.cmsIcon_StartHook,
            this.cmsIcon_StopHook,
            this.tss18,
            this.cmsIcon_CleanUp,
            this.tss19,
            this.cmsIcon_ShowSendList,
            this.tss20,
            this.cmsIcon_Exit});
            this.cmsIcon.Name = "cmsIcon";
            resources.ApplyResources(this.cmsIcon, "cmsIcon");
            this.cmsIcon.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsIcon_ItemClicked);
            // 
            // cmsIcon_Show
            // 
            this.cmsIcon_Show.Image = global::WPELibrary.Properties.Resources.Info16;
            resources.ApplyResources(this.cmsIcon_Show, "cmsIcon_Show");
            this.cmsIcon_Show.Name = "cmsIcon_Show";
            // 
            // tss17
            // 
            this.tss17.Name = "tss17";
            resources.ApplyResources(this.tss17, "tss17");
            // 
            // cmsIcon_StartHook
            // 
            this.cmsIcon_StartHook.Image = global::WPELibrary.Properties.Resources.Play16;
            resources.ApplyResources(this.cmsIcon_StartHook, "cmsIcon_StartHook");
            this.cmsIcon_StartHook.Name = "cmsIcon_StartHook";
            // 
            // cmsIcon_StopHook
            // 
            this.cmsIcon_StopHook.Image = global::WPELibrary.Properties.Resources.Stop16;
            resources.ApplyResources(this.cmsIcon_StopHook, "cmsIcon_StopHook");
            this.cmsIcon_StopHook.Name = "cmsIcon_StopHook";
            // 
            // tss18
            // 
            this.tss18.Name = "tss18";
            resources.ApplyResources(this.tss18, "tss18");
            // 
            // cmsIcon_CleanUp
            // 
            this.cmsIcon_CleanUp.Image = global::WPELibrary.Properties.Resources.Trash_can16;
            resources.ApplyResources(this.cmsIcon_CleanUp, "cmsIcon_CleanUp");
            this.cmsIcon_CleanUp.Name = "cmsIcon_CleanUp";
            // 
            // tss19
            // 
            this.tss19.Name = "tss19";
            resources.ApplyResources(this.tss19, "tss19");
            // 
            // cmsIcon_ShowSendList
            // 
            this.cmsIcon_ShowSendList.Image = global::WPELibrary.Properties.Resources.File_info16;
            resources.ApplyResources(this.cmsIcon_ShowSendList, "cmsIcon_ShowSendList");
            this.cmsIcon_ShowSendList.Name = "cmsIcon_ShowSendList";
            // 
            // tss20
            // 
            this.tss20.Name = "tss20";
            resources.ApplyResources(this.tss20, "tss20");
            // 
            // cmsIcon_Exit
            // 
            this.cmsIcon_Exit.Image = global::WPELibrary.Properties.Resources.logout24;
            this.cmsIcon_Exit.Name = "cmsIcon_Exit";
            resources.ApplyResources(this.cmsIcon_Exit, "cmsIcon_Exit");
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.NullValue = null;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle15;
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Image = global::WPELibrary.Properties.Resources.sent;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Socket_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tlpSocketForm);
            this.DoubleBuffered = true;
            this.Name = "Socket_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DLL_Form_FormClosed);
            this.Resize += new System.EventHandler(this.Socket_Form_Resize);
            this.tlpSocketForm.ResumeLayout(false);
            this.tlpSocketForm.PerformLayout();
            this.ssSocketList.ResumeLayout(false);
            this.ssSocketList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocketList)).EndInit();
            this.cmsSocketList.ResumeLayout(false);
            this.tlpParameter.ResumeLayout(false);
            this.gbSocketList_Set.ResumeLayout(false);
            this.tlpSocketList_Set.ResumeLayout(false);
            this.tlpSocketList_Set.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSocketList_AutoClearValue)).EndInit();
            this.gbFilterSet.ResumeLayout(false);
            this.tlpFilterSet.ResumeLayout(false);
            this.tlpFilterSet.PerformLayout();
            this.tlpFilterSet_PacketLength.ResumeLayout(false);
            this.tlpFilterSet_PacketLength.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCheckSizeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCheckSizeFrom)).EndInit();
            this.gbHookType.ResumeLayout(false);
            this.tlpHookType.ResumeLayout(false);
            this.tlpHookType.PerformLayout();
            this.gbHookButton_Search.ResumeLayout(false);
            this.tlpSearch.ResumeLayout(false);
            this.tlpSearch.PerformLayout();
            this.tlpSearchButton.ResumeLayout(false);
            this.tlpHookButton.ResumeLayout(false);
            this.tlpHookButton_Start.ResumeLayout(false);
            this.tlpInformation.ResumeLayout(false);
            this.gbFilterList.ResumeLayout(false);
            this.tlpFilterList.ResumeLayout(false);
            this.tlpFilterList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilterList)).EndInit();
            this.tsFilterList.ResumeLayout(false);
            this.tsFilterList.PerformLayout();
            this.tlpPacketInfo.ResumeLayout(false);
            this.tcPacketInfo.ResumeLayout(false);
            this.tpPacketData.ResumeLayout(false);
            this.tlpPacketData.ResumeLayout(false);
            this.tlpHexBox.ResumeLayout(false);
            this.cmsHexBox.ResumeLayout(false);
            this.tpComparison.ResumeLayout(false);
            this.tlpComparison.ResumeLayout(false);
            this.tlpComparison.PerformLayout();
            this.tlpComparison_Button.ResumeLayout(false);
            this.pComparison_A.ResumeLayout(false);
            this.pComparison_B.ResumeLayout(false);
            this.pComparison_Result.ResumeLayout(false);
            this.tpXOR.ResumeLayout(false);
            this.tlpPacketInfo_XOR.ResumeLayout(false);
            this.tlpPacketInfo_XOR_Button.ResumeLayout(false);
            this.tlpPacketInfo_XOR_Button.PerformLayout();
            this.tpEncoding.ResumeLayout(false);
            this.tlpPacketInfo_Encoding.ResumeLayout(false);
            this.tlpPacketInfo_Encoding_Button.ResumeLayout(false);
            this.tlpPacketInfo_Encoding_Result.ResumeLayout(false);
            this.tlpPacketInfo_Encoding_Result.PerformLayout();
            this.pPacketInfo_Encoding.ResumeLayout(false);
            this.tpSystemLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogList)).EndInit();
            this.cmsLogList.ResumeLayout(false);
            this.ssProcessInfo.ResumeLayout(false);
            this.ssProcessInfo.PerformLayout();
            this.cmsIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSocketForm;
        private System.Windows.Forms.TableLayoutPanel tlpParameter;
        private System.Windows.Forms.GroupBox gbHookType;
        private System.Windows.Forms.TableLayoutPanel tlpHookType;
        private System.Windows.Forms.CheckBox cbHookRecvFrom;
        private System.Windows.Forms.CheckBox cbHookSend;
        private System.Windows.Forms.CheckBox cbHookSendTo;
        private System.Windows.Forms.CheckBox cbHookRecv;
        private System.Windows.Forms.CheckBox cbHookWSASend;
        private System.Windows.Forms.CheckBox cbHookWSASendTo;
        private System.Windows.Forms.CheckBox cbHookWSARecv;
        private System.Windows.Forms.CheckBox cbHookWSARecvFrom;
        private System.Windows.Forms.GroupBox gbFilterSet;
        private System.Windows.Forms.DataGridView dgvSocketList;
        private System.Windows.Forms.TableLayoutPanel tlpInformation;
        private System.Windows.Forms.TableLayoutPanel tlpPacketInfo;
        private System.Windows.Forms.TabControl tcPacketInfo;
        private System.Windows.Forms.TabPage tpSystemLog;
        private System.Windows.Forms.ContextMenuStrip cmsSocketList;
        private System.Windows.Forms.ToolStripMenuItem cmsSocketList_UseSocket;
        private System.Windows.Forms.ToolStripSeparator tss4;
        private System.Windows.Forms.ToolStripMenuItem cmsSocketList_ShowSendList;
        private System.Windows.Forms.ToolStripSeparator tss5;
        private System.Windows.Forms.ToolStripMenuItem cmsSocketList_ToExcel;
        private System.Windows.Forms.ContextMenuStrip cmsLogList;
        private System.Windows.Forms.ToolStripMenuItem cmsLogList_CleanUp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem cmsLogList_ToExcel;
        private System.ComponentModel.BackgroundWorker bgwSocketList;
        private System.Windows.Forms.Timer tSocketInfo;
        private System.ComponentModel.BackgroundWorker bgwLogList;
        private System.Windows.Forms.TabPage tpPacketData;
        private System.Windows.Forms.TableLayoutPanel tlpPacketData;
        private System.Windows.Forms.TableLayoutPanel tlpHexBox;
        private Be.Windows.Forms.HexBox hbPacketData;
        private System.Windows.Forms.StatusStrip ssSocketList;
        private System.Windows.Forms.ToolStripStatusLabel tlALL;
        private System.Windows.Forms.ToolStripStatusLabel tlALL_CNT;
        private System.Windows.Forms.ToolStripStatusLabel tlSplit1;
        private System.Windows.Forms.ToolStripStatusLabel tlQueue;
        private System.Windows.Forms.ToolStripStatusLabel tlQueue_CNT;
        private System.Windows.Forms.ToolStripStatusLabel tlSplit2;
        private System.Windows.Forms.ToolStripStatusLabel tlSend;
        private System.Windows.Forms.ToolStripStatusLabel tlSend_CNT;
        private System.Windows.Forms.ToolStripStatusLabel tlSplit3;
        private System.Windows.Forms.ToolStripStatusLabel tlRecv;
        private System.Windows.Forms.ToolStripStatusLabel tlRecv_CNT;
        private System.Windows.Forms.ToolStripStatusLabel tlSplit4;
        private System.Windows.Forms.ToolStripStatusLabel tlFilter;
        private System.Windows.Forms.ToolStripStatusLabel tlFilter_CNT;
        private System.Windows.Forms.GroupBox gbHookButton_Search;
        private System.Windows.Forms.TableLayoutPanel tlpHookButton;
        private System.Windows.Forms.Button bCleanUp;
        private System.Windows.Forms.TableLayoutPanel tlpHookButton_Start;
        private System.Windows.Forms.Button bStopHook;
        private System.Windows.Forms.Button bStartHook;
        private System.Windows.Forms.TableLayoutPanel tlpSearch;
        private System.Windows.Forms.TableLayoutPanel tlpSearchButton;
        private System.Windows.Forms.Button bSearchNext;
        private System.Windows.Forms.Button bSearch;
        private System.ComponentModel.BackgroundWorker bgwSearchPacketData;
        private System.Windows.Forms.StatusStrip ssProcessInfo;
        private System.Windows.Forms.ToolStripStatusLabel tsslProcessName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tlSendTo;
        private System.Windows.Forms.ToolStripStatusLabel tlSendTo_CNT;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel tlRecvFrom;
        private System.Windows.Forms.ToolStripStatusLabel tlRecvFrom_CNT;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel tlWSASend;
        private System.Windows.Forms.ToolStripStatusLabel tlWSASend_CNT;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel11;
        private System.Windows.Forms.ToolStripStatusLabel tlWSARecv;
        private System.Windows.Forms.ToolStripStatusLabel tlWSARecv_CNT;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel14;
        private System.Windows.Forms.ToolStripStatusLabel tlWSASendTo;
        private System.Windows.Forms.ToolStripStatusLabel tlWSASendTo_CNT;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel17;
        private System.Windows.Forms.ToolStripStatusLabel tlWSARecvFrom;
        private System.Windows.Forms.ToolStripStatusLabel tlWSARecvFrom_CNT;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalBytes;
        private System.Windows.Forms.ToolStripStatusLabel tsslProcessInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel tsslWinSock;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.NotifyIcon niWPE;
        private System.Windows.Forms.ContextMenuStrip cmsIcon;
        private System.Windows.Forms.ToolStripMenuItem cmsIcon_Show;
        private System.Windows.Forms.ToolStripSeparator tss17;
        private System.Windows.Forms.ToolStripMenuItem cmsIcon_Exit;
        private System.Windows.Forms.ToolStripMenuItem cmsIcon_StartHook;
        private System.Windows.Forms.ToolStripMenuItem cmsIcon_StopHook;
        private System.Windows.Forms.ToolStripSeparator tss18;
        private System.Windows.Forms.ToolStripMenuItem cmsIcon_CleanUp;
        private System.Windows.Forms.ToolStripSeparator tss19;
        private System.Windows.Forms.ToolStripMenuItem cmsIcon_ShowSendList;
        private System.Windows.Forms.ToolStripSeparator tss20;
        private System.Windows.Forms.ContextMenuStrip cmsHexBox;
        private System.Windows.Forms.ToolStripMenuItem cmsHexBox_Send;
        private System.Windows.Forms.ToolStripSeparator cmsHexBox_tss1;
        private System.Windows.Forms.ToolStripMenuItem cmsHexBox_SendList;
        private System.Windows.Forms.ToolStripSeparator cmsHexBox_tss2;
        private System.Windows.Forms.ToolStripMenuItem cmsHexBox_FilterList;
        private System.Windows.Forms.ToolStripMenuItem cmsSocketList_Send;
        private System.Windows.Forms.ToolStripSeparator cmsSocketList_tss1;
        private System.Windows.Forms.DataGridViewImageColumn cTypeImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPacketType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSocket;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cData;
        private System.Windows.Forms.GroupBox gbFilterList;
        private System.Windows.Forms.TableLayoutPanel tlpFilterList;
        private System.Windows.Forms.ToolStrip tsFilterList;
        private System.Windows.Forms.ToolStripButton tsFilterList_Load;
        private System.Windows.Forms.ToolStripButton tsFilterList_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsFilterList_Add;
        private System.Windows.Forms.ToolStripButton tsFilterList_Edit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsFilterList_Delete;
        private System.Windows.Forms.ToolStripButton tsFilterList_CleanUp;
        private System.Windows.Forms.DataGridView dgvFilterList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cIsCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFName;
        private System.Windows.Forms.ToolStripStatusLabel tlIntercept;
        private System.Windows.Forms.ToolStripStatusLabel tlIntercept_CNT;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.TabPage tpComparison;
        private System.Windows.Forms.TableLayoutPanel tlpComparison;
        private System.Windows.Forms.Label lComparison_A;
        private System.Windows.Forms.Label lComparison_B;
        private System.Windows.Forms.TableLayoutPanel tlpComparison_Button;
        private System.Windows.Forms.Button bComparison;
        private System.Windows.Forms.Button bComparison_Clear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cmsSocketList_Comparison_A;
        private System.Windows.Forms.ToolStripMenuItem cmsSocketList_Comparison_B;
        private System.Windows.Forms.Button bComparison_Exchange;
        private System.Windows.Forms.DataGridView dgvLogList;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFuncName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cContent;
        private System.Windows.Forms.TabPage tpEncoding;
        private System.Windows.Forms.TableLayoutPanel tlpPacketInfo_Encoding;
        private System.Windows.Forms.TableLayoutPanel tlpPacketInfo_Encoding_Button;
        private System.Windows.Forms.Button bPacketInfo_Encoding;
        private System.Windows.Forms.Button bPacketInfo_Decoding;
        private System.Windows.Forms.TableLayoutPanel tlpPacketInfo_Encoding_Result;
        private System.Windows.Forms.Label lPacketInfo_Encoding_UTF8;
        private System.Windows.Forms.Label lPacketInfo_Encoding_Bytes;
        private System.Windows.Forms.Label lPacketInfo_Encoding_base64;
        private System.Windows.Forms.TextBox txtPacketInfo_Encoding_UTF8;
        private System.Windows.Forms.TextBox txtPacketInfo_Encoding_UTF7;
        private System.Windows.Forms.TextBox txtPacketInfo_Encoding_Bytes;
        private System.Windows.Forms.TextBox txtPacketInfo_Encoding_ANSIbase64;
        private System.Windows.Forms.TextBox txtPacketInfo_Encoding_ANSIUTF8;
        private System.Windows.Forms.TextBox txtPacketInfo_Encoding_ANSIUTF7;
        private System.Windows.Forms.TextBox txtPacketInfo_Encoding_ANSIGBK;
        private System.Windows.Forms.Label lPacketInfo_Encoding_ANSIbase64;
        private System.Windows.Forms.Label lPacketInfo_Encoding_ANSIUTF8;
        private System.Windows.Forms.Label lPacketInfo_Encoding_ANSIUTF7;
        private System.Windows.Forms.Label lPacketInfo_Encoding_UTF7;
        private System.Windows.Forms.Label lPacketInfo_Encoding_ANSIGBK;
        private System.Windows.Forms.TextBox txtPacketInfo_Encoding_base64;
        private System.Windows.Forms.TextBox txtPacketInfo_Encoding_UTF16;
        private System.Windows.Forms.Label lPacketInfo_Encoding_ASCII;
        private System.Windows.Forms.Label lPacketInfo_Encoding_UTF32;
        private System.Windows.Forms.TextBox txtPacketInfo_Encoding_UTF32;
        private System.Windows.Forms.Label lPacketInfo_Encoding_Unicode;
        private System.Windows.Forms.TextBox txtPacketInfo_Encoding_Unicode;
        private System.Windows.Forms.TextBox txtPacketInfo_Encoding_ANSIUTF16;
        private System.Windows.Forms.Label lPacketInfo_Encoding_ANSIASCII;
        private System.Windows.Forms.Label lPacketInfo_Encoding_ANSIUTF32;
        private System.Windows.Forms.TextBox txtPacketInfo_Encoding_ANSIUTF32;
        private System.Windows.Forms.Label lPacketInfo_Encoding_ANSIUnicode;
        private System.Windows.Forms.TextBox txtPacketInfo_Encoding_ANSIUnicode;
        private System.Windows.Forms.GroupBox gbSocketList_Set;
        private System.Windows.Forms.TableLayoutPanel tlpSocketList_Set;
        private System.Windows.Forms.CheckBox cbSocketList_AutoRoll;
        private System.Windows.Forms.RadioButton rbFromHead;
        private System.Windows.Forms.RadioButton rbFromIndex;
        private System.Windows.Forms.ToolStripSeparator cmsHexBox_tss3;
        private System.Windows.Forms.ToolStripMenuItem cmsHexBox_CopyHex;
        private System.Windows.Forms.ToolStripMenuItem cmsHexBox_CopyText;
        private System.Windows.Forms.TabPage tpXOR;
        private System.Windows.Forms.TableLayoutPanel tlpPacketInfo_XOR;
        private System.Windows.Forms.TableLayoutPanel tlpPacketInfo_XOR_Button;
        private Be.Windows.Forms.HexBox hbXOR_From;
        private System.Windows.Forms.Button bXOR;
        private System.Windows.Forms.Button bXOR_Clear;
        private System.Windows.Forms.Label lXOR;
        private System.Windows.Forms.TextBox txtXOR;
        private Be.Windows.Forms.HexBox hbXOR_To;
        private System.Windows.Forms.Label lXOR2;
        private System.Windows.Forms.ToolStripSeparator cmsHexBox_tss4;
        private System.Windows.Forms.ToolStripMenuItem cmsHexBox_SelectAll;
        private System.Windows.Forms.TableLayoutPanel tlpFilterSet;
        private System.Windows.Forms.TableLayoutPanel tlpFilterSet_PacketLength;
        private System.Windows.Forms.NumericUpDown nudCheckSizeTo;
        private System.Windows.Forms.Label lCheck_Size;
        private System.Windows.Forms.NumericUpDown nudCheckSizeFrom;
        private System.Windows.Forms.CheckBox cbCheckSize;
        private System.Windows.Forms.RadioButton rbFilter_Show;
        private System.Windows.Forms.RadioButton rbFilter_NotShow;
        private System.Windows.Forms.TextBox txtCheckPort;
        private System.Windows.Forms.CheckBox cbCheckPort;
        private System.Windows.Forms.TextBox txtCheckData;
        private System.Windows.Forms.CheckBox cbCheckData;
        private System.Windows.Forms.CheckBox cbCheckSocket;
        private System.Windows.Forms.CheckBox cbCheckIP;
        private System.Windows.Forms.TextBox txtCheckSocket;
        private System.Windows.Forms.TextBox txtCheckIP;
        private System.Windows.Forms.Panel pComparison_A;
        private System.Windows.Forms.RichTextBox rtbComparison_A;
        private System.Windows.Forms.Panel pComparison_B;
        private System.Windows.Forms.RichTextBox rtbComparison_B;
        private System.Windows.Forms.Panel pComparison_Result;
        private System.Windows.Forms.RichTextBox rtbComparison_Result;
        private System.Windows.Forms.Panel pPacketInfo_Encoding;
        private System.Windows.Forms.RichTextBox rtbPacketInfo_Encoding;
        private System.Windows.Forms.NumericUpDown nudSocketList_AutoClearValue;
        private System.Windows.Forms.CheckBox cbSocketList_AutoClear;
    }
}