﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.ComponentModel;
using System.Reflection;
using Be.Windows.Forms;
using System.Diagnostics;
using System.Collections.Concurrent;

namespace WPELibrary.Lib
{
    public static class Socket_Cache
    {  
        public static byte[] bByteBuff = new byte[0];
        public static bool Support_WS1, Support_WS2;
        public static bool Hook_Send, Hook_SendTo, Hook_Recv, Hook_RecvFrom, Hook_WSASend, Hook_WSASendTo, Hook_WSARecv, Hook_WSARecvFrom;
        public static bool Check_Size, Check_Socket, Check_IP, Check_Packet;
        public static string txtCheck_Socket, txtCheck_IP, txtCheck_Packet;
        public static decimal txtCheck_Size_From, txtCheck_Size_To;

        public static FindOptions FindOptions = new FindOptions();
        public static bool DoSearch;

        #region//封包

        public static class SocketPacket
        {
            public static int PacketData_MaxLen = 60;

            #region//结构定义

            [StructLayout(LayoutKind.Explicit)]

            public struct in_addr
            {
                [FieldOffset(0)]
                public S_un _S_un;

                [StructLayout(LayoutKind.Explicit)]

                public struct S_un
                {
                    [FieldOffset(0)]
                    public S_un_b S_un_b;

                    [FieldOffset(0)]
                    public S_un_w S_un_w;

                    [FieldOffset(0)]
                    public uint S_addr;
                }

                [StructLayout(LayoutKind.Sequential)]

                public struct S_un_b
                {
                    public byte s_b1;
                    public byte s_b2;
                    public byte s_b3;
                    public byte s_b4;
                }

                [StructLayout(LayoutKind.Sequential)]

                public struct S_un_w
                {
                    public ushort s_w1;
                    public ushort s_w2;
                }
            }            

            public struct sockaddr
            {
                public short sin_family;
                public ushort sin_port;
                public in_addr sin_addr;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
                public byte[] sin_zero;
            }

            [StructLayout(LayoutKind.Sequential)]

            public struct WSABUF
            {
                public int len;
                public IntPtr buf;
            }

            [StructLayout(LayoutKind.Sequential)]

            public struct OVERLAPPED
            {
                public IntPtr InternalLow;
                public IntPtr InternalHigh;
                public int OffsetLow;
                public int OffsetHigh;
                public IntPtr EventHandle;
            }

            public enum PacketType
            {
                Send,
                SendTo,
                Recv,
                RecvFrom,                
                WSASend,
                WSASendTo,
                WSARecv,
                WSARecvFrom,
            }

            public enum IPType
            {
                From,
                To,
            }

            public enum EncodingFormat
            {
                Char,
                Byte,
                Short,
                UShort,
                Int32,
                UInt32,
                Int64,
                UInt64,
                Float,
                Double,
                Bin,
                Hex,
                UTF7,
            }

            #endregion            
        }

        #endregion

        #region//封包队列

        public static class SocketQueue
        {
            public static int Send_CNT = 0;
            public static int SendTo_CNT = 0;
            public static int Recv_CNT = 0;
            public static int RecvFrom_CNT = 0;
            public static int WSASend_CNT = 0;
            public static int WSASendTo_CNT = 0;
            public static int WSARecv_CNT = 0;
            public static int WSARecvFrom_CNT = 0;
            public static int Filter_CNT = 0;
            public static int Total_SendBytes = 0;
            public static int Total_RecvBytes = 0;

            public static ConcurrentQueue<Socket_PacketInfo> qSocket_PacketInfo = new ConcurrentQueue<Socket_PacketInfo>();

            #region//封包入队列            

            public static void SocketPacket_ToQueue(int iSocket, byte[] bBuffByte, Socket_Cache.SocketPacket.PacketType ptPacketType, Socket_Cache.SocketPacket.sockaddr sAddr, int iResLen)
            {
                try
                {
                    string sPacketIP = Socket_Operation.GetIPString_BySocketAddr(iSocket, sAddr, ptPacketType);

                    if (!string.IsNullOrEmpty(sPacketIP) && sPacketIP.IndexOf("|") > 0)
                    {  
                        string sIPFrom = sPacketIP.Split('|')[0];
                        string sIPTo = sPacketIP.Split('|')[1];                        
                        DateTime dtTime = DateTime.Now;

                        Socket_PacketInfo spi = new Socket_PacketInfo(dtTime, iSocket, ptPacketType, sIPFrom, sIPTo, bBuffByte, iResLen);

                        qSocket_PacketInfo.Enqueue(spi);
                    }
                }
                catch (Exception ex)
                {
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }                
            }

            #endregion

            #region//清除队列数据

            public static void ResetSocketQueue()
            {
                try
                {
                    while (!qSocket_PacketInfo.IsEmpty)
                    {
                        qSocket_PacketInfo.TryDequeue(out Socket_PacketInfo spi);
                    }                      
                }
                catch (Exception ex)
                {
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }
            }

            #endregion
        }

        #endregion

        #region//封包列表

        public static class SocketList
        {
            public static BindingList<Socket_PacketInfo> lstRecPacket = new BindingList<Socket_PacketInfo>();

            public delegate void SocketPacketReceived(Socket_PacketInfo si);
            public static event SocketPacketReceived RecSocketPacket;

            #region//封包入列表

            public static void SocketToList(int iMax_DataLen)
            {
                try
                {
                    if (SocketQueue.qSocket_PacketInfo.TryDequeue(out Socket_PacketInfo spi))
                    {
                        if (Socket_Operation.ISShowSocketPacket_ByFilter(spi))
                        {                            
                            int iPacketLen = spi.PacketLen;
                            byte[] bBuffer = spi.PacketBuffer;

                            spi.PacketIndex = lstRecPacket.Count + 1;
                            spi.PacketData = Socket_Operation.GetPacketData_Hex(bBuffer, iMax_DataLen);

                            Socket_Cache.SocketPacket.PacketType ptType = spi.PacketType;

                            switch (ptType)
                            {
                                case Socket_Cache.SocketPacket.PacketType.Send:
                                    SocketQueue.Total_SendBytes += iPacketLen;
                                    SocketQueue.Send_CNT++;
                                    break;
                                case Socket_Cache.SocketPacket.PacketType.SendTo:
                                    SocketQueue.Total_SendBytes += iPacketLen;
                                    SocketQueue.SendTo_CNT++;
                                    break;
                                case Socket_Cache.SocketPacket.PacketType.Recv:
                                    SocketQueue.Total_RecvBytes += iPacketLen;
                                    SocketQueue.Recv_CNT++;
                                    break;
                                case Socket_Cache.SocketPacket.PacketType.RecvFrom:
                                    SocketQueue.Total_RecvBytes += iPacketLen;
                                    SocketQueue.RecvFrom_CNT++;
                                    break;
                                case Socket_Cache.SocketPacket.PacketType.WSASend:
                                    SocketQueue.Total_SendBytes += iPacketLen;
                                    SocketQueue.WSASend_CNT++;
                                    break;
                                case Socket_Cache.SocketPacket.PacketType.WSASendTo:
                                    SocketQueue.Total_SendBytes += iPacketLen;
                                    SocketQueue.WSASendTo_CNT++;
                                    break;
                                case Socket_Cache.SocketPacket.PacketType.WSARecv:
                                    SocketQueue.Total_RecvBytes += iPacketLen;
                                    SocketQueue.WSARecv_CNT++;
                                    break;
                                case Socket_Cache.SocketPacket.PacketType.WSARecvFrom:
                                    SocketQueue.Total_RecvBytes += iPacketLen;
                                    SocketQueue.WSARecvFrom_CNT++;
                                    break;
                            }

                            RecSocketPacket?.Invoke(spi);
                        }
                        else
                        {
                            SocketQueue.Filter_CNT++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }
            }

            #endregion
        }

        #endregion

        #region//日志队列
        public static class LogQueue
        {
            public static ConcurrentQueue<Socket_LogInfo> qSocket_Log = new ConcurrentQueue<Socket_LogInfo>();

            #region//日志入队列

            public static void LogToQueue(string sFuncName, string sLogContent)
            {
                try
                {
                    Socket_LogInfo sli = new Socket_LogInfo(sFuncName, sLogContent);

                    qSocket_Log.Enqueue(sli);
                }
                catch (Exception ex) 
                {
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }
            }            

            #endregion

            #region//清除队列数据
            public static void ResetLogQueue()
            {
                try
                {
                    while (!qSocket_Log.IsEmpty)
                    {
                        qSocket_Log.TryDequeue(out Socket_LogInfo sl);
                    }
                }
                catch (Exception ex)
                {
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }
            }
            #endregion
        }
        #endregion

        #region//日志列表

        public static class LogList
        {
            public static BindingList<Socket_LogInfo> lstRecLog = new BindingList<Socket_LogInfo>();

            public delegate void SocketLogReceived(Socket_LogInfo sl);
            public static event SocketLogReceived RecSocketLog;

            #region//日志入列表

            public static void LogToList()
            {
                try
                {
                    if (LogQueue.qSocket_Log.TryDequeue(out Socket_LogInfo sli))
                    {
                        RecSocketLog?.Invoke(sli);
                    }              
                }
                catch (Exception ex)
                {
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }
            }

            #endregion
        }

        #endregion

        #region//滤镜列表

        public static class FilterList
        {
            public static int FilterNormal_SearchRowIndex = 0, FilterNormal_ModifyRowIndex = 1;
            public static int FilterAdvanced_SearchRowIndex = 0, FilterAdvanced_ModifyRowIndex = 0;
            public static int FilterSearchLen_New = 100, FilterModifyLen_New = 100;
            public static int Filter_MaxNum = 3;
            public static BindingList<Socket_FilterInfo> lstFilter = new BindingList<Socket_FilterInfo>();

            #region//初始化滤镜列表
            public static void InitFilterList(int iFilterMaxNum)
            {
                try
                {
                    int iFilterList = Socket_Operation.LoadFilterList("");

                    if (iFilterList == 0)
                    {
                        FilterListClear();

                        for (int i = 0; i < iFilterMaxNum; i++)
                        {
                            AddFilter_New();
                        }
                    }                    
                }
                catch (Exception ex)
                {
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }
            }
            #endregion

            #region//清空滤镜列表

            public static void FilterListClear()
            {
                try
                {
                    lstFilter.Clear();
                }
                catch (Exception ex)
                {
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }
            }

            #endregion

            #region//设置滤镜是否启用

            public static void SetIsCheck_ByFilterNum(int FNum, bool bCheck)
            {
                try
                {
                    if (FNum > 0)
                    {
                        int iFIndex = GetFilterIndex_ByFilterNum(FNum);

                        lstFilter[iFIndex].IsCheck = bCheck;
                    }
                }
                catch (Exception ex)
                {
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }
            }

            #endregion

            #region//获取滤镜是否启用

            public static bool GetIsCheck_ByFilterNum(int FNum)
            {
                bool bReturn = false;

                try
                {
                    if (FNum > 0)
                    {
                        int iFIndex = GetFilterIndex_ByFilterNum(FNum);

                        bReturn = lstFilter[iFIndex].IsCheck;
                    }
                }
                catch (Exception ex)
                {
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }

                return bReturn;                
            }

            #endregion

            #region//返回滤镜长度

            public static int GetFilterLen_ByFilterNum(int FNum)
            {
                int iReturn = 0;

                try
                {
                    if (FNum > 0)
                    {
                        int iFIndex = GetFilterIndex_ByFilterNum(FNum);

                        string sFSearch = lstFilter[iFIndex].FSearch;
                        string sFModify = lstFilter[iFIndex].FModify;


                        int iFSearch = 0, iFModify = 0;

                        if (string.IsNullOrEmpty(sFSearch) && string.IsNullOrEmpty(sFModify))
                        {
                            iReturn = FilterSearchLen_New;
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(sFSearch))
                            {
                                string[] slFSearch = sFSearch.Split(',');
                                string[] slTemp = slFSearch[slFSearch.Length - 1].ToString().Split('-');
                                iFSearch = int.Parse(slTemp[0].ToString());
                            }

                            if (!string.IsNullOrEmpty(sFModify))
                            {
                                string[] slFModify = sFModify.Split(',');
                                string[] slTemp = slFModify[slFModify.Length - 1].ToString().Split('-');
                                iFModify = int.Parse(slTemp[0].ToString());
                            }

                            if (iFSearch >= iFModify)
                            {
                                iReturn = iFSearch + 1;
                            }
                            else
                            {
                                iReturn = iFModify + 1;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }

                return iReturn;
            }

            #endregion

            #region//滤镜列表操作（新增，修改，删除）

            #region//新增

            public static void AddToFilterList_BySocketListIndex(int iSLIndex)
            {
                try
                {
                    if (SocketList.lstRecPacket.Count > 0 && iSLIndex > -1)
                    {
                        int iIndex = Socket_Cache.SocketList.lstRecPacket[iSLIndex].PacketIndex;
                        string sFName = Process.GetCurrentProcess().ProcessName.Trim() + " [" + iIndex.ToString() + "]";
                        byte[] bBuffer = Socket_Cache.SocketList.lstRecPacket[iSLIndex].PacketBuffer;

                        Socket_Cache.FilterList.AddToFilterList_New(sFName, bBuffer);
                    }  
                }
                catch (Exception ex)
                {
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }
            }

            public static void AddToFilterList_New(string sFName, byte[] bBuffer)
            {
                try
                {  
                    Socket_FilterInfo.FilterMode FMode = Socket_FilterInfo.FilterMode.Normal;
                    Socket_FilterInfo.StartFrom FStartFrom = Socket_FilterInfo.StartFrom.Head;
                    int iFModifyCNT = 1;

                    string sFSearch = Socket_Operation.GetFilterString_ByBytes(bBuffer);
                    int iFSearchLen = bBuffer.Length;

                    Socket_Cache.FilterList.AddFilter_New(sFName, FMode, FStartFrom, iFModifyCNT, sFSearch, iFSearchLen, "", iFSearchLen, false);
                    Socket_Operation.ShowMessageBox(String.Format(MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_27), sFName));
                }
                catch (Exception ex)
                {
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }
            }
            
            public static void AddFilter_New()
            {
                try
                {
                    AddFilter_New("", Socket_FilterInfo.FilterMode.Normal, Socket_FilterInfo.StartFrom.Head, 1, "", FilterSearchLen_New, "", FilterModifyLen_New, false);
                }
                catch (Exception ex)
                {
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }
            }
            
            public static void AddFilter_New(string FName, Socket_FilterInfo.FilterMode FMode, Socket_FilterInfo.StartFrom FStartFrom, int FModifyCNT, string FSearch, int FSearchLen, string FModify, int FModifyLen, bool bCheck)
            {
                try
                {
                    int FNum = GetFilterNum_New();

                    if (string.IsNullOrEmpty(FName))
                    {
                        FName = MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_50) + " " + FNum.ToString();
                    }

                    if (string.IsNullOrEmpty(FSearch))
                    {
                        FSearchLen = FilterSearchLen_New;
                    }

                    if (string.IsNullOrEmpty(FModify))
                    {
                        FModifyLen = FilterModifyLen_New;
                    }

                    Socket_FilterInfo sc = new Socket_FilterInfo(FNum, bCheck, FName, FMode, FStartFrom, FModifyCNT, FSearch, FSearchLen, FModify, FModifyLen);

                    lstFilter.Add(sc);
                }
                catch (Exception ex)
                {
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }
            }
            
            private static int GetFilterNum_New()
            {
                int iReturn = 0;

                try
                {
                    for (int i = 0; i < lstFilter.Count; i++)
                    {
                        int iFNum = lstFilter[i].FNum;

                        if (iFNum > iReturn)
                        {
                            iReturn = iFNum;
                        }
                    }

                    iReturn = iReturn + 1;
                }
                catch (Exception ex)
                {
                    iReturn = 0;

                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }                

                return iReturn;
            }

            #endregion

            #region//删除

            public static void DeleteFilter_ByFilterNum(int FNum)
            {
                try
                {
                    if (FNum > 0)
                    {
                        int iFIndex = GetFilterIndex_ByFilterNum(FNum);

                        if (iFIndex > -1)
                        {
                            lstFilter.RemoveAt(iFIndex);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }
            }

            #endregion

            #region//修改

            public static void UpdateFilter_ByFilterNum(int FNum, string FName, Socket_FilterInfo.FilterMode FMode, Socket_FilterInfo.StartFrom FStartFrom, int FModifyCNT, string FSearch, int FSearchLen, string FModify, int FModifyLen)
            {
                try
                {
                    if (FNum > 0 && !string.IsNullOrEmpty(FName))
                    {
                        int iFIndex = GetFilterIndex_ByFilterNum(FNum);

                        if (iFIndex > -1)
                        {
                            lstFilter[iFIndex].FName = FName;
                            lstFilter[iFIndex].FMode = FMode;                            
                            lstFilter[iFIndex].FStartFrom = FStartFrom;
                            lstFilter[iFIndex].FModifyCNT = FModifyCNT;
                            lstFilter[iFIndex].FSearch = FSearch;
                            lstFilter[iFIndex].FSearchLen = FSearchLen;
                            lstFilter[iFIndex].FModify = FModify;
                            lstFilter[iFIndex].FModifyLen = FModifyLen;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }
            }

            #endregion

            #endregion

            #region//获取滤镜编号

            public static int GetFilterIndex_ByFilterNum(int FNum)
            {
                int iReturn = -1;

                try
                {
                    for (int i = 0; i < lstFilter.Count; i++)
                    {
                        int iFNum = lstFilter[i].FNum;

                        if (iFNum == FNum)
                        {
                            iReturn = i;
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    iReturn = -1;

                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }

                return iReturn;
            }

            public static int GetFilterNum_ByFilterIndex(int FIndex)
            {
                int iReturn = -1;

                try
                {
                    int iFNum = lstFilter[FIndex].FNum;

                    if (iFNum > 0)
                    {
                        iReturn = iFNum;
                    }
                }
                catch (Exception ex)
                {
                    iReturn = -1;

                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }

                return iReturn;
            }

            #endregion

            #region//执行滤镜

            public static void DoFilter_WSABUF(IntPtr lpBuffers, int dwBufferCount, int BytesCNT)
            {
                try
                {
                    int BytesLeft = BytesCNT;

                    for (int i = 0; i < dwBufferCount; i++)
                    {
                        if (BytesLeft > 0)
                        {
                            IntPtr lpNewBuffer = IntPtr.Add(lpBuffers, Marshal.SizeOf(typeof(Socket_Cache.SocketPacket.WSABUF)) * i);
                            Socket_Cache.SocketPacket.WSABUF wsBuffer = Marshal.PtrToStructure<Socket_Cache.SocketPacket.WSABUF>(lpNewBuffer);

                            int iBuffLen = 0;

                            if (wsBuffer.len >= BytesLeft)
                            {
                                iBuffLen = BytesLeft;
                            }
                            else
                            {
                                iBuffLen = wsBuffer.len;
                            }

                            BytesLeft -= iBuffLen;

                            Socket_Cache.FilterList.DoFilter(wsBuffer.buf, iBuffLen);
                        }
                            
                    }
                }
                catch (Exception ex)
                {
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }
            }

            public static void DoFilter(IntPtr ipBuff, int iLen)
            {
                string sFName = string.Empty;

                try
                {
                    foreach (Socket_FilterInfo sfi in lstFilter)
                    {
                        if (Socket_Operation.CheckFilter_IsEffective(sfi))
                        {
                            sFName = sfi.FName;
                            Socket_FilterInfo.FilterMode Fmode = sfi.FMode;

                            switch (Fmode)
                            {
                                case Socket_FilterInfo.FilterMode.Normal:

                                    if (Socket_Operation.CheckFilter_IsMatch_Normal(sfi, ipBuff, iLen))
                                    {
                                        if (Socket_Operation.DoFilter_Normal(sfi, ipBuff, iLen))
                                        {
                                            Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_51) + sFName);                                            
                                        }
                                    }

                                    break;

                                case Socket_FilterInfo.FilterMode.Advanced:

                                    List<int> MatchIndex = Socket_Operation.CheckFilter_IsMatch_Adcanced(sfi, ipBuff, iLen);

                                    foreach (int iIndex in MatchIndex)
                                    {
                                        if (Socket_Operation.DoFilter_Advanced(sfi, iIndex, ipBuff, iLen))
                                        {
                                            Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_51) + sFName);                                            
                                        }
                                    }

                                    break;                                    
                            }
                        }
                    }
                }
                catch (Exception ex)
                {                    
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_52) + sFName + " | " + ex.Message);
                }
            }

            #endregion            
        }

        #endregion

        #region//封包发送列表

        public static class SendList
        {
            public static int Loop_CNT = 0;
            public static int Loop_Int = 0;
            public static int Loop_Send_CNT = 0;
            public static int SendList_Success_CNT = 0;
            public static int SendList_Fail_CNT = 0;
            public static int UseSocket = 0;
            public static bool bShow_SendListForm = true;

            public static DataTable dtSocketSendList = new DataTable();

            #region//初始化发送列表

            public static void InitSendList()
            {
                try
                {
                    dtSocketSendList.Columns.Clear();

                    dtSocketSendList.Columns.Add("ID", typeof(int));
                    dtSocketSendList.Columns.Add("Remark", typeof(string));
                    dtSocketSendList.Columns.Add("Socket", typeof(int));
                    dtSocketSendList.Columns.Add("ToAddress", typeof(string));
                    dtSocketSendList.Columns.Add("Len", typeof(int));
                    dtSocketSendList.Columns.Add("Data", typeof(string));
                    dtSocketSendList.Columns.Add("Bytes", typeof(byte[]));
                }
                catch (Exception ex)
                {
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }
            }

            #endregion            

            #region//发送列表操作（新增，删除）

            public static void AddToSendList_BySocketListIndex(int iSLIndex)
            {
                try
                {
                    if (SocketList.lstRecPacket.Count > 0 && iSLIndex > -1)
                    {
                        AddToSendList_New(SocketList.lstRecPacket[iSLIndex].PacketIndex, "", SocketList.lstRecPacket[iSLIndex].PacketSocket, SocketList.lstRecPacket[iSLIndex].PacketTo, SocketList.lstRecPacket[iSLIndex].PacketData, SocketList.lstRecPacket[iSLIndex].PacketBuffer);
                    }
                }
                catch (Exception ex)
                {
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }
            }

            public static void AddToSendList_New(int iIndex, string sNote, int iSocket, string sIPTo, string sData, byte[] bBuffer)
            {
                try
                {
                    DataRow dr = dtSocketSendList.NewRow();

                    dr["ID"] = iIndex;
                    dr["Remark"] = sNote;
                    dr["Socket"] = iSocket;
                    dr["ToAddress"] = sIPTo;
                    dr["Len"] = bBuffer.Length;
                    dr["Data"] = sData;
                    dr["Bytes"] = bBuffer;
                    dtSocketSendList.Rows.Add(dr);
                }
                catch (Exception ex)
                {
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }
            }

            public static void DeleteSendList_ByIndex(int SIndex)
            {
                try
                {
                    dtSocketSendList.Rows[SIndex].Delete();
                }
                catch (Exception ex)
                {
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }
            }

            #endregion

            #region//清空发送列表

            public static void SendListClear()
            {
                dtSocketSendList.Rows.Clear();
            }

            #endregion

            #region//发送列表

            public static bool SendPacketList_ByIndex(int iSocket, int iIndex)
            {
                bool bResult = false;

                try
                {
                    int iLen = (int)dtSocketSendList.Rows[iIndex]["Len"];
                    byte[] bBuffer = (byte[])dtSocketSendList.Rows[iIndex]["Bytes"];

                    if (bBuffer.Length > 0)
                    {
                        IntPtr ipSend = Marshal.AllocHGlobal(bBuffer.Length);
                        Marshal.Copy(bBuffer, 0, ipSend, bBuffer.Length);

                        bool bReturn = WinSockHook.SendPacket(iSocket, ipSend, bBuffer.Length);

                        if (bReturn)
                        {
                            SendList_Success_CNT++;
                        }
                        else
                        {
                            SendList_Fail_CNT++;
                        }

                        Thread.Sleep(Loop_Int);
                    }
                }
                catch (Exception ex)
                {
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                }

                return bResult;
            }

            #endregion
        }

        #endregion
    }
}
