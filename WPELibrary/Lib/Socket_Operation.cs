﻿using System;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Reflection;
using System.Data;
using System.Linq;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Xml;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;
using System.Security.Cryptography;
using System.Xml.Linq;
using EasyHook;

namespace WPELibrary.Lib
{   
    public static class Socket_Operation
    {        
        public static bool bDoLog = true;
        public static bool bDoLog_HookTime = true;
        public static DataTable dtSearchFrom = new DataTable();
        public static DataTable dtPacketFormat = new DataTable();

        #region//数据格式转换

        #region//base64 编码，解码

        public static string Base64_Encoding(string sString)
        {
            string sReturn = string.Empty;

            try
            {
                byte[] bBuffer = StringToBytes(Socket_Cache.SocketPacket.EncodingFormat.Default, sString);
                sReturn = Convert.ToBase64String(bBuffer);
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return sReturn;
        }

        public static string Base64_Decoding(string sString)
        {
            string sReturn = string.Empty;

            try
            {
                byte[] bBuffer = Convert.FromBase64String(sString);
                sReturn = Encoding.Default.GetString(bBuffer);
            }
            catch
            {
                //
            }

            return sReturn;
        }

        #endregion

        #region//字符串转byte[]

        public static byte[] StringToBytes(Socket_Cache.SocketPacket.EncodingFormat efFormat, string sString)
        {
            byte[] bReturn = new byte[sString.Length];

            try
            {
                switch (efFormat)
                {
                    case Socket_Cache.SocketPacket.EncodingFormat.Default:
                        bReturn = Encoding.Default.GetBytes(sString);
                        break;

                    case Socket_Cache.SocketPacket.EncodingFormat.Hex:
                        bReturn = Hex_To_Bytes(sString);
                        break;

                    case Socket_Cache.SocketPacket.EncodingFormat.GBK:
                        bReturn = Encoding.GetEncoding("GBK").GetBytes(sString);
                        break;

                    case Socket_Cache.SocketPacket.EncodingFormat.Unicode:
                        bReturn = Encoding.Unicode.GetBytes(sString);
                        break;

                    case Socket_Cache.SocketPacket.EncodingFormat.UTF7:
                        bReturn = Encoding.UTF7.GetBytes(sString);
                        break;

                    case Socket_Cache.SocketPacket.EncodingFormat.UTF8:
                        bReturn = Encoding.UTF8.GetBytes(sString);
                        break;

                    case Socket_Cache.SocketPacket.EncodingFormat.UTF16:
                        bReturn = Encoding.BigEndianUnicode.GetBytes(sString);
                        break;

                    case Socket_Cache.SocketPacket.EncodingFormat.UTF32:
                        bReturn = Encoding.UTF32.GetBytes(sString);
                        break;                
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bReturn;
        }

        #endregion

        #region//byte[]转字符串

        public static string BytesToString(Socket_Cache.SocketPacket.EncodingFormat efFormat, byte[] buffer)
        {
            string sReturn = string.Empty;

            try
            {
                if (buffer.Length > 0)
                {
                    switch (efFormat)
                    {
                        case Socket_Cache.SocketPacket.EncodingFormat.Default:
                            sReturn = Encoding.Default.GetString(buffer);
                            break;

                        case Socket_Cache.SocketPacket.EncodingFormat.Char:
                            char c = Convert.ToChar(buffer[0]);
                            if ((int)c > 31)
                            {
                                sReturn = c.ToString();
                            }
                            else
                            {
                                sReturn = ".";
                            }
                            break;

                        case Socket_Cache.SocketPacket.EncodingFormat.Byte:
                            sReturn = buffer[0].ToString();
                            break;

                        case Socket_Cache.SocketPacket.EncodingFormat.Bytes:

                            foreach (byte b in buffer)
                            {
                                sReturn += Convert.ToInt32(b) + ",";
                            }

                            sReturn = sReturn.TrimEnd(',');
                            sReturn = string.Format("{{{0}}}", sReturn);

                            break;

                        case Socket_Cache.SocketPacket.EncodingFormat.Short:
                            if (buffer.Length >= 2)
                            {
                                sReturn = BitConverter.ToInt16(buffer, 0).ToString();
                            }
                            break;

                        case Socket_Cache.SocketPacket.EncodingFormat.UShort:
                            if (buffer.Length >= 2)
                            {
                                sReturn = BitConverter.ToUInt16(buffer, 0).ToString();
                            }
                            break;

                        case Socket_Cache.SocketPacket.EncodingFormat.Int32:
                            if (buffer.Length >= 4)
                            {
                                sReturn = BitConverter.ToInt32(buffer, 0).ToString();
                            }
                            break;

                        case Socket_Cache.SocketPacket.EncodingFormat.UInt32:
                            if (buffer.Length >= 4)
                            {
                                sReturn = BitConverter.ToUInt32(buffer, 0).ToString();
                            }
                            break;

                        case Socket_Cache.SocketPacket.EncodingFormat.Int64:
                            if (buffer.Length >= 8)
                            {
                                sReturn = BitConverter.ToInt64(buffer, 0).ToString();
                            }
                            break;

                        case Socket_Cache.SocketPacket.EncodingFormat.UInt64:
                            if (buffer.Length >= 8)
                            {
                                sReturn = BitConverter.ToUInt64(buffer, 0).ToString();
                            }
                            break;

                        case Socket_Cache.SocketPacket.EncodingFormat.Float:
                            if (buffer.Length >= 4)
                            {
                                sReturn = BitConverter.ToSingle(buffer, 0).ToString();
                            }
                            break;

                        case Socket_Cache.SocketPacket.EncodingFormat.Double:
                            if (buffer.Length >= 8)
                            {
                                sReturn = BitConverter.ToDouble(buffer, 0).ToString();
                            }
                            break;

                        case Socket_Cache.SocketPacket.EncodingFormat.Bin:
                            foreach (byte b in buffer)
                            {
                                string strTemp = Convert.ToString(b, 2);
                                strTemp = strTemp.Insert(0, new string('0', 8 - strTemp.Length));
                                sReturn += strTemp + " ";
                            }
                            sReturn = sReturn.Trim();
                            break;

                        case Socket_Cache.SocketPacket.EncodingFormat.Hex:
                            foreach (byte b in buffer)
                            {
                                sReturn += b.ToString("X2") + " ";
                            }
                            sReturn = sReturn.Trim();
                            break;

                        case Socket_Cache.SocketPacket.EncodingFormat.GBK:
                            sReturn = Encoding.GetEncoding("GBK").GetString(buffer);
                            break;

                        case Socket_Cache.SocketPacket.EncodingFormat.Unicode:
                            sReturn = Encoding.Unicode.GetString(buffer);
                            break;

                        case Socket_Cache.SocketPacket.EncodingFormat.ASCII:
                            sReturn = Encoding.ASCII.GetString(buffer);
                            break;

                        case Socket_Cache.SocketPacket.EncodingFormat.UTF7:
                            sReturn = Encoding.UTF7.GetString(buffer);
                            break;

                        case Socket_Cache.SocketPacket.EncodingFormat.UTF8:
                            sReturn = Encoding.UTF8.GetString(buffer);
                            break;

                        case Socket_Cache.SocketPacket.EncodingFormat.UTF16:
                            sReturn = Encoding.BigEndianUnicode.GetString(buffer);
                            break;

                        case Socket_Cache.SocketPacket.EncodingFormat.UTF32:
                            sReturn = Encoding.UTF32.GetString(buffer);
                            break;                    
                    }
                }
            }
            catch (Exception ex)
            {
                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return sReturn;
        }

        #endregion

        #region//十六进制字符串转byte[]

        public static byte[] Hex_To_Bytes(string hexString)
        {
            try
            {
                hexString = hexString.Replace(" ", "");

                if ((hexString.Length % 2) != 0)
                {
                    hexString += " ";
                }

                byte[] returnBytes = new byte[hexString.Length / 2];

                for (int i = 0; i < returnBytes.Length; i++)
                {
                    returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
                }

                return returnBytes;
            }
            catch
            {  
                return new byte[0];
            }
        }

        #endregion

        #region//判断是否十六进制字符串（带空格）

        public static bool IsHexString(string value)
        {
            bool bReturn = false;

            try
            {  
                string pattern = @"^([A-Fa-f0-9]{2}\s?)+$";

                bReturn = Regex.IsMatch(value, pattern);
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bReturn;            
        }

        #endregion

        #region//获取中文字符串对应的bool类型

        public static bool GetBoolFromChineseString(string ChineseString)
        {
            bool bReturn = false;

            try
            {
                switch (ChineseString)
                {
                    case "真":
                        bReturn = true;
                        break;

                    case "假":
                        bReturn = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bReturn;
        }

        #endregion

        #region//转换FILT过滤器的字符串

        public static string ConvertFILTString(string FiltString, bool bPosition)
        {
            string Return = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(FiltString) && FiltString.IndexOf("$") > 0)
                {
                    string[] slFiltString = FiltString.Split('$');

                    for (int i = 0; i < slFiltString.Length - 1; i += 3)
                    {
                        int iIndex = int.Parse(slFiltString[i]) - 1;
                        string sHex = slFiltString[i + 1];
                        int iHexCount = int.Parse(slFiltString[i + 2]);

                        for (int j = 0; j < iHexCount; j++)
                        {
                            int iFIndex = iIndex + j;

                            if (bPosition)
                            {
                                iFIndex += 250;
                            }

                            Return += iFIndex.ToString() + "-" + sHex.Substring(j * 2, 2) + ",";
                        }
                    }

                    Return = Return.TrimEnd(',');
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return Return;
        }

        #endregion

        #endregion

        #region//统计封包数量

        public static void CountSocketInfo(Socket_Cache.SocketPacket.PacketType ptPacketType, int iPacketLen)
        {
            try
            {
                Interlocked.Increment(ref Socket_Cache.TotalPackets);

                switch (ptPacketType)
                {
                    case Socket_Cache.SocketPacket.PacketType.Send:
                        Interlocked.Add(ref Socket_Cache.Total_SendBytes, iPacketLen);
                        break;

                    case Socket_Cache.SocketPacket.PacketType.SendTo:
                        Interlocked.Add(ref Socket_Cache.Total_SendBytes, iPacketLen);
                        break;

                    case Socket_Cache.SocketPacket.PacketType.Recv:
                        Interlocked.Add(ref Socket_Cache.Total_RecvBytes, iPacketLen);
                        break;

                    case Socket_Cache.SocketPacket.PacketType.RecvFrom:
                        Interlocked.Add(ref Socket_Cache.Total_RecvBytes, iPacketLen);
                        break;

                    case Socket_Cache.SocketPacket.PacketType.WSASend:
                        Interlocked.Add(ref Socket_Cache.Total_SendBytes, iPacketLen);
                        break;

                    case Socket_Cache.SocketPacket.PacketType.WSASendTo:
                        Interlocked.Add(ref Socket_Cache.Total_SendBytes, iPacketLen);
                        break;

                    case Socket_Cache.SocketPacket.PacketType.WSARecv:
                        Interlocked.Add(ref Socket_Cache.Total_RecvBytes, iPacketLen);
                        break;

                    case Socket_Cache.SocketPacket.PacketType.WSARecvFrom:
                        Interlocked.Add(ref Socket_Cache.Total_RecvBytes, iPacketLen);
                        break;
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        #endregion

        #region//判断文本框输入的字符类型

        public static bool CheckTextInput_IsDigit(char keyChar)
        {
            bool bReturn = false;

            try
            {
                if (char.IsControl(keyChar) || char.IsDigit(keyChar) || keyChar.Equals(';') || keyChar.Equals('.') || keyChar.Equals('-'))
                {
                    bReturn = true;
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bReturn;
        }

        public static bool CheckTextInput_IsHex(char keyChar)
        {
            bool bReturn = false;

            try
            {
                if (char.IsControl(keyChar) || Socket_Operation.IsHexChar(keyChar) || keyChar.Equals(' ') || keyChar.Equals(';'))
                {
                    bReturn = true;
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bReturn;
        }

        private static bool IsHexChar(char c)
        {
            bool bReturn = false;

            try
            {
                if ((c >= '0' && c <= '9') || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F'))
                {
                    bReturn = true;
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bReturn;
        }

        #endregion        

        #region//获取当前进程的格式化名称

        public static string GetProcessName()
        {
            string sReturn = string.Empty;

            try
            {
                Process pProcess = Process.GetCurrentProcess();
                sReturn = string.Format("{0}{1} [{2}]", MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_20), pProcess.ProcessName, RemoteHooking.GetCurrentProcessId());
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return sReturn;
        }

        #endregion

        #region//获取当前进程的信息

        public static string GetProcessInfo()
        {
            string sReturn = string.Empty;

            try
            {
                Process pProcess = Process.GetCurrentProcess();

                string sMainWindowTitle = pProcess.MainWindowTitle;
                string sMainWindowHandle = pProcess.MainWindowHandle.ToString();

                if (String.IsNullOrEmpty(sMainWindowTitle))
                {
                    sReturn = pProcess.MainModule.ModuleName;
                }
                else
                {
                    sReturn = string.Format(MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_73), pProcess.MainWindowTitle, pProcess.MainWindowHandle.ToString());
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return sReturn;
        }

        #endregion

        #region//获取当前进程支持的Winsock版本信息

        public static string GetWinSockSupportInfo()
        {
            string sReturn = "WinSock";

            try
            {
                Socket_Cache.Support_WS1 = false;
                Socket_Cache.Support_WS2 = false;

                ProcessModuleCollection modules = Process.GetCurrentProcess().Modules;

                foreach (ProcessModule module in modules)
                {
                    string sModuleName = module.ModuleName;

                    if (sModuleName.Equals(WSock32.ModuleName, StringComparison.CurrentCultureIgnoreCase))
                    {
                        Socket_Cache.Support_WS1 = true;
                        sReturn += " 1.1";
                    }

                    if (sModuleName.Equals(WS2_32.ModuleName, StringComparison.CurrentCultureIgnoreCase))
                    {
                        Socket_Cache.Support_WS2 = true;
                        sReturn += " 2.0";
                    }
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return sReturn;
        }

        #endregion

        #region//从内存复制指定长度的字节数组

        public static byte[] GetBytes_FromIntPtr(IntPtr ipBuff, int iLen)
        {
            byte[] bBuffer = new byte[iLen];

            try
            {
                Marshal.Copy(ipBuff, bBuffer, 0, iLen);
            }
            catch (Exception ex)
            {
                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bBuffer;
        }

        #endregion

        #region//设置指针地址位置的字节数据

        public static bool SetByteToIntPtr(byte[] bBuffer, IntPtr ipBuff, int iLen)
        {
            bool bResult = false;

            try
            {
                Marshal.Copy(bBuffer, 0, ipBuff, iLen);
                bResult = true;
            }
            catch
            {
                bResult = false;
            }

            return bResult;
        }

        #endregion

        #region//获取sockaddr对应的IP地址和端口

        public static string GetIPString_BySocketAddr(int pSocket, Socket_Cache.SocketPacket.sockaddr pAddr, Socket_Cache.SocketPacket.PacketType pType)
        {
            string sReturn = "";

            try
            {  
                string sIP_From = string.Empty;
                string sIP_To = string.Empty;

                sIP_From = Socket_Operation.GetIP_BySocket(pSocket, Socket_Cache.SocketPacket.IPType.From);

                if (pType == Socket_Cache.SocketPacket.PacketType.Send || pType == Socket_Cache.SocketPacket.PacketType.Recv || pType == Socket_Cache.SocketPacket.PacketType.WSASend || pType == Socket_Cache.SocketPacket.PacketType.WSARecv)
                {
                    sIP_To = Socket_Operation.GetIP_BySocket(pSocket, Socket_Cache.SocketPacket.IPType.To);
                }
                else if (pType == Socket_Cache.SocketPacket.PacketType.SendTo || pType == Socket_Cache.SocketPacket.PacketType.RecvFrom || pType == Socket_Cache.SocketPacket.PacketType.WSASendTo || pType == Socket_Cache.SocketPacket.PacketType.WSARecvFrom)
                {
                    sIP_To = Socket_Operation.GetIP_ByAddr(pAddr);
                }

                if (!string.IsNullOrEmpty(sIP_From) && !string.IsNullOrEmpty(sIP_To))
                {
                    sReturn = sIP_From + "|" + sIP_To;
                }
            }
            catch (Exception ex)
            {
                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return sReturn;
        }

        public static string GetIP_ByAddr(Socket_Cache.SocketPacket.sockaddr saAddr)
        {
            string sReturn = "";

            try
            {
                string sIP = Marshal.PtrToStringAnsi(WS2_32.inet_ntoa(saAddr.sin_addr));
                string sPort = WS2_32.ntohs(saAddr.sin_port).ToString();

                sReturn = sIP + ":" + sPort;
            }
            catch (Exception ex)
            {
                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return sReturn;
        }

        public static string GetIP_BySocket(int iSocket, Socket_Cache.SocketPacket.IPType IPType)
        {
            string sReturn = "";

            try
            {
                Socket_Cache.SocketPacket.sockaddr saAddr = new Socket_Cache.SocketPacket.sockaddr();
                int iAddrLen = Marshal.SizeOf(saAddr);

                switch (IPType)
                {
                    case Socket_Cache.SocketPacket.IPType.From:

                        WS2_32.getsockname(iSocket, ref saAddr, ref iAddrLen);

                        break;

                    case Socket_Cache.SocketPacket.IPType.To:

                        WS2_32.getpeername(iSocket, ref saAddr, ref iAddrLen);

                        break;                    
                }

                sReturn = GetIP_ByAddr(saAddr);
            }
            catch (Exception ex)
            {
                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return sReturn;
        }

        #endregion

        #region//获取IP地址和端口对应的sockaddr

        public static Socket_Cache.SocketPacket.sockaddr GetSocketAddr_ByIPString(string IPString)
        {
            Socket_Cache.SocketPacket.sockaddr saReturn = new Socket_Cache.SocketPacket.sockaddr();

            try
            {
                if (!string.IsNullOrEmpty(IPString) && IPString.IndexOf(":") > 0)
                {                    
                    string sIP = IPString.Split(':')[0];
                    string sPort = IPString.Split(':')[1];

                    saReturn.sin_family = ((short)AddressFamily.InterNetwork);
                    saReturn.sin_port = WS2_32.htons(ushort.Parse(sPort));

                    Socket_Cache.SocketPacket.in_addr ia = new Socket_Cache.SocketPacket.in_addr();
                    IPAddress ipAddress = IPAddress.Parse(sIP);
                    ia._S_un.S_addr = ((uint)ipAddress.GetHashCode());

                    saReturn.sin_addr = ia;
                    saReturn.sin_zero = new byte[8];
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return saReturn;
        }

        #endregion

        #region//获取封包数据字符串（十六进制）

        public static string GetPacketData_Hex(byte[] bBuff, int Max_DataLen)
        {
            string sReturn = "";

            try
            {
                int iPacketLen = bBuff.Length;

                if (iPacketLen > Max_DataLen)
                {
                    byte[] bTemp = new byte[Max_DataLen];

                    for (int j = 0; j < Max_DataLen; j++)
                    {
                        bTemp[j] = bBuff[j];
                    }

                    sReturn = Socket_Operation.BytesToString(Socket_Cache.SocketPacket.EncodingFormat.Hex, bTemp) + " ...";
                }
                else
                {
                    sReturn = Socket_Operation.BytesToString(Socket_Cache.SocketPacket.EncodingFormat.Hex, bBuff);
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return sReturn;
        }

        #endregion

        #region//获取WSABUF数组的字节数组        

        public static byte[] GetByteFromWSABUF(IntPtr lpBuffers, Int32 dwBufferCount, int BytesCNT)
        {
            byte[] bReturn = new byte[0];

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

                        byte[] bBuff = new byte[iBuffLen];
                        Marshal.Copy(wsBuffer.buf, bBuff, 0, iBuffLen);

                        bReturn = bReturn.Concat(bBuff).ToArray();                        
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

        #region//获取指定步长的Byte

        public static byte GetStepByte(byte bStepByte, int iStepLen)
        {
            byte bReturn = byte.MinValue;

            try
            {
                int iStepValue = Convert.ToInt32(bStepByte);
                iStepValue += iStepLen;

                while (iStepValue > 255)
                {
                    iStepValue -= 256;
                }

                while (iStepValue < 0)
                {
                    iStepValue += 256;
                }

                bReturn = Convert.ToByte(iStepValue);
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bReturn;
        }

        #endregion

        #region//获取递进后的Byte[]

        public static byte[] GetStepBytes(byte[] bStepBuffer, int iStepPosition, int iStepLen)
        {
            byte[] bReturn = null;

            try
            {
                byte bStepByte = bStepBuffer[iStepPosition];

                bStepBuffer[iStepPosition] = GetStepByte(bStepByte, iStepLen);

                bReturn = bStepBuffer;
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bReturn;
        }

        #endregion

        #region//获取封包类型对应的名称

        public static string GetName_ByPacketType(Socket_Cache.SocketPacket.PacketType socketType)
        {
            string sReturn = string.Empty;

            try
            {
                switch (socketType)
                {
                    case Socket_Cache.SocketPacket.PacketType.Send:
                        sReturn = MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_54);
                        break;

                    case Socket_Cache.SocketPacket.PacketType.Recv:
                        sReturn = MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_55);
                        break;

                    case Socket_Cache.SocketPacket.PacketType.SendTo:
                        sReturn = MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_56);
                        break;

                    case Socket_Cache.SocketPacket.PacketType.RecvFrom:
                        sReturn = MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_57);
                        break;

                    case Socket_Cache.SocketPacket.PacketType.WSASend:
                        sReturn = MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_58);
                        break;

                    case Socket_Cache.SocketPacket.PacketType.WSARecv:
                        sReturn = MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_59);
                        break;

                    case Socket_Cache.SocketPacket.PacketType.WSASendTo:
                        sReturn = MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_60);
                        break;

                    case Socket_Cache.SocketPacket.PacketType.WSARecvFrom:
                        sReturn = MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_61);
                        break;
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return sReturn;
        }

        #endregion

        #region//获取滤镜动作对应的名称

        public static string GetName_ByFilterAction(Socket_Cache.Filter.FilterAction filterAction)
        {
            string sReturn = string.Empty;

            try
            {
                switch (filterAction)
                {
                    case Socket_Cache.Filter.FilterAction.Replace:
                        sReturn = MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_65);
                        break;

                    case Socket_Cache.Filter.FilterAction.Intercept:
                        sReturn = MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_66);
                        break;

                    case Socket_Cache.Filter.FilterAction.NoModify_Display:
                        sReturn = MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_67);
                        break;

                    case Socket_Cache.Filter.FilterAction.NoModify_NoDisplay:
                        sReturn = MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_68);
                        break;
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return sReturn;
        }

        #endregion

        #region//获取封包类型对应的图标

        public static Image GetImg_ByPacketType(Socket_Cache.SocketPacket.PacketType socketType)
        {
            Image imgReturn = null;

            try
            {
                switch (socketType)
                {
                    case Socket_Cache.SocketPacket.PacketType.Send:
                        imgReturn = Properties.Resources.sent;
                        break;
                    case Socket_Cache.SocketPacket.PacketType.Recv:
                        imgReturn = Properties.Resources.received;
                        break;
                    case Socket_Cache.SocketPacket.PacketType.SendTo:
                        imgReturn = Properties.Resources.sent;
                        break;
                    case Socket_Cache.SocketPacket.PacketType.RecvFrom:
                        imgReturn = Properties.Resources.received;
                        break;
                    case Socket_Cache.SocketPacket.PacketType.WSASend:
                        imgReturn = Properties.Resources.sent;
                        break;
                    case Socket_Cache.SocketPacket.PacketType.WSARecv:
                        imgReturn = Properties.Resources.received;
                        break;
                    case Socket_Cache.SocketPacket.PacketType.WSASendTo:
                        imgReturn = Properties.Resources.sent;
                        break;
                    case Socket_Cache.SocketPacket.PacketType.WSARecvFrom:
                        imgReturn = Properties.Resources.received;
                        break;
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return imgReturn;
        }

        #endregion

        #region//获取字节长度对应的字符串

        public static string GetDisplayBytes(long size)
        {
            string sReturn = string.Empty;

            try
            {
                const long multi = 1024;
                long kb = multi;
                long mb = kb * multi;
                long gb = mb * multi;
                long tb = gb * multi;

                const string BYTES = "Bytes";
                const string KB = "KB";
                const string MB = "MB";
                const string GB = "GB";
                const string TB = "TB";
                
                if (size < kb)
                {
                    sReturn = string.Format("{0} {1}", size, BYTES);
                }
                else if (size < mb)
                {
                    sReturn = string.Format("{0} {1} ({2} Bytes)", ConvertToOneDigit(size, kb), KB, ConvertBytesDisplay(size));
                }
                else if (size < gb)
                {
                    sReturn = string.Format("{0} {1} ({2} Bytes)", ConvertToOneDigit(size, mb), MB, ConvertBytesDisplay(size));
                }
                else if (size < tb)
                {
                    sReturn = string.Format("{0} {1} ({2} Bytes)", ConvertToOneDigit(size, gb), GB, ConvertBytesDisplay(size));
                }
                else
                {
                    sReturn = string.Format("{0} {1} ({2} Bytes)", ConvertToOneDigit(size, tb), TB, ConvertBytesDisplay(size));
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }              

            return sReturn;
        }

        private static string ConvertBytesDisplay(long size)
        {
            string sReturn = string.Empty;

            try
            {
                sReturn = size.ToString("###,###,###,###,###", CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return sReturn;
        }

        private static string ConvertToOneDigit(long size, long quan)
        {
            string sReturn = string.Empty;

            try
            {
                double quotient = (double)size / (double)quan;
                sReturn = quotient.ToString("0.#", CultureInfo.CurrentCulture);                
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return sReturn;
        }

        #endregion

        #region//是否显示封包（过滤条件）        

        public static bool ISShowSocketPacket_ByFilter(Socket_PacketInfo spi)
        {
            try
            {
                //套接字
                if (Socket_Cache.CheckSocket)
                {
                    if (Socket_Cache.CheckNotShow)
                    {
                        if (ISFilter_BySocket(spi.PacketSocket))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (ISFilter_BySocket(spi.PacketSocket))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }

                //IP地址
                if (Socket_Cache.CheckIP)
                {
                    if (Socket_Cache.CheckNotShow)
                    {
                        if (ISFilter_ByIP(spi.PacketFrom) || ISFilter_ByIP(spi.PacketTo))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (ISFilter_ByIP(spi.PacketFrom) || ISFilter_ByIP(spi.PacketTo))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }               
                }

                //端口号
                if (Socket_Cache.CheckPort)
                {
                    if (Socket_Cache.CheckNotShow)
                    {
                        if (ISFilter_ByPort(spi.PacketFrom) || ISFilter_ByPort(spi.PacketTo))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (ISFilter_ByPort(spi.PacketFrom) || ISFilter_ByPort(spi.PacketTo))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }

                //指定包头
                if (Socket_Cache.CheckHead)
                {
                    if (Socket_Cache.CheckNotShow)
                    {
                        if (ISFilter_ByHead(spi.PacketBuffer))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (ISFilter_ByHead(spi.PacketBuffer))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }

                //封包内容
                if (Socket_Cache.CheckData)
                {
                    if (Socket_Cache.CheckNotShow)
                    {
                        if (ISFilter_ByPacket(spi.PacketBuffer))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (ISFilter_ByPacket(spi.PacketBuffer))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }

                //封包大小
                if (Socket_Cache.CheckSize)
                {
                    if (Socket_Cache.CheckNotShow)
                    {
                        if (ISFilter_BySize(spi.PacketLen))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (ISFilter_BySize(spi.PacketLen))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return true;
        }

        #region//检测套接字

        private static bool ISFilter_BySocket(int iPacketSocket)
        {
            bool bReturn = false;

            try
            {
                if (!string.IsNullOrEmpty(Socket_Cache.CheckSocket_Value))
                {
                    string[] sSocketArr = Socket_Cache.CheckSocket_Value.Split(';');

                    foreach (string sSocket in sSocketArr)
                    {
                        if (!string.IsNullOrEmpty(sSocket))
                        {
                            if (int.TryParse(sSocket, out int iCheckSocket))
                            {
                                if (iPacketSocket == iCheckSocket)
                                {
                                    return true;
                                }
                            }
                        }                        
                    }
                }
            }
            catch (Exception ex)
            {
                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bReturn;
        }

        #endregion

        #region//检测IP地址

        private static bool ISFilter_ByIP(string sPacketIP)
        {
            bool bReturn = false;

            try
            {
                if (!string.IsNullOrEmpty(sPacketIP))
                {
                    string sIP = sPacketIP.Split(':')[0];
                    string sPort = sPacketIP.Split(':')[1];
                    
                    if (!string.IsNullOrEmpty(Socket_Cache.CheckIP_Value))
                    {
                        string[] sIPArr = Socket_Cache.CheckIP_Value.Split(';');

                        foreach (string sCheckIP in sIPArr)
                        {
                            if (!string.IsNullOrEmpty(sCheckIP))
                            {
                                if (sIP.Equals(sCheckIP))
                                {
                                    return true;
                                }
                            }                            
                        }
                    }
                }                  
            }
            catch (Exception ex)
            {
                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bReturn;
        }

        #endregion

        #region//检测端口号

        private static bool ISFilter_ByPort(string sPacketPort)
        {
            bool bReturn = false;

            try
            {
                if (!string.IsNullOrEmpty(sPacketPort))
                {
                    string sIP = sPacketPort.Split(':')[0];
                    string sPort = sPacketPort.Split(':')[1];

                    if (!string.IsNullOrEmpty(Socket_Cache.CheckPort_Value))
                    {
                        string[] sPortArr = Socket_Cache.CheckPort_Value.Split(';');

                        foreach (string sCheckPort in sPortArr)
                        {
                            if (!string.IsNullOrEmpty(sCheckPort))
                            {
                                if (sPort.Equals(sCheckPort))
                                {
                                    return true;
                                }
                            }                                
                        }
                    }
                }  
            }
            catch (Exception ex)
            {
                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bReturn;
        }

        #endregion

        #region//检测包头

        private static bool ISFilter_ByHead(byte[] bBuffer)
        {
            bool bReturn = false;

            try
            {
                if (!string.IsNullOrEmpty(Socket_Cache.CheckHead_Value))
                {
                    string sPacket = BytesToString(Socket_Cache.SocketPacket.EncodingFormat.Hex, bBuffer).Replace(" ", "");

                    string[] sHeadArr = Socket_Cache.CheckHead_Value.Replace(" ", "").Split(';');

                    foreach (string sCheckHead in sHeadArr)
                    {
                        if (!string.IsNullOrEmpty(sCheckHead))
                        {
                            if (sPacket.IndexOf(sCheckHead) == 0)
                            {
                                return true;
                            }
                        }                        
                    }
                }
            }
            catch (Exception ex)
            {
                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bReturn;
        }

        #endregion

        #region//检测封包内容

        private static bool ISFilter_ByPacket(byte[] bBuffer)
        {
            bool bReturn = false;

            try
            {
                if (!string.IsNullOrEmpty(Socket_Cache.CheckData_Value))
                {
                    string sPacket = BytesToString(Socket_Cache.SocketPacket.EncodingFormat.Hex, bBuffer).Replace(" ", "");

                    string[] sPacketArr = Socket_Cache.CheckData_Value.Replace(" ", "").Split(';');

                    foreach (string sCheckPacket in sPacketArr)
                    {
                        if (!string.IsNullOrEmpty(sCheckPacket))
                        {
                            if (sPacket.IndexOf(sCheckPacket) >= 0)
                            {
                                return true;
                            }
                        }                        
                    }
                }                    
            }
            catch (Exception ex)
            {
                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bReturn;
        }

        #endregion

        #region//检测封包大小

        private static bool ISFilter_BySize(int PacketLength)
        {
            bool bReturn = false;

            try
            {
                if (!string.IsNullOrEmpty(Socket_Cache.CheckLength_Value))
                {
                    string[] sLengthArr = Socket_Cache.CheckLength_Value.Split(';');

                    foreach (string sLength in sLengthArr)
                    {
                        if (!string.IsNullOrEmpty(sLength))
                        {
                            if (sLength.IndexOf("-") > 0)
                            {
                                if (int.TryParse(sLength.Split('-')[0], out int iFrom) && int.TryParse(sLength.Split('-')[1], out int iTo))
                                {
                                    if (PacketLength >= iFrom && PacketLength <= iTo)
                                    {
                                        bReturn = true;
                                    }
                                }
                            }
                            else
                            {
                                if (int.TryParse(sLength, out int iLength))
                                {
                                    if (PacketLength == iLength)
                                    {
                                        bReturn = true;
                                    }
                                }
                            }
                        }                        
                    }
                }
            }
            catch (Exception ex)
            {
                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bReturn;
        }

        #endregion

        #endregion

        #region//搜索封包数据        

        public static int FindSocketList(Socket_Cache.SocketPacket.EncodingFormat efFormat, int FromIndex, string SearchData, bool MatchCase)
        {
            int iResult = -1;

            try
            {
                if (!string.IsNullOrEmpty(SearchData))
                {
                    int iListCNT = Socket_Cache.SocketList.lstRecPacket.Count;

                    if (iListCNT > 0 && FromIndex < iListCNT)
                    {
                        string sSearch = "";

                        for (int i = FromIndex; i < iListCNT; i++)
                        {
                            byte[] bSearch = Socket_Cache.SocketList.lstRecPacket[i].PacketBuffer;
                            sSearch = BytesToString(efFormat, bSearch);

                            if (!MatchCase)
                            {
                                sSearch = sSearch.ToLower();
                                SearchData = SearchData.ToLower();
                            }

                            if (sSearch.IndexOf(SearchData) >= 0)
                            {
                                iResult = i;
                                break;
                            }
                        }
                    }
                }                
            }
            catch (Exception ex)
            {
                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return iResult;
        }

        #endregion      

        #region//显示发送窗体

        public static void ShowSendForm(int iSLIndex)
        {
            try
            {
                if (iSLIndex > -1)
                {
                    Socket_SendForm ssForm = new Socket_SendForm(iSLIndex);
                    ssForm.Show();
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        #endregion

        #region//显示发送列表窗体

        public static void ShowSendListForm()
        {
            try
            {
                if (Socket_Cache.SendList.bShow_SendListForm)
                {
                    Socket_SendListForm sslForm = new Socket_SendListForm();
                    sslForm.Show();
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        #endregion

        #region//保存发送列表数据

        public static bool SaveSendList()
        {
            bool bReturn = true;

            try
            {
                SaveFileDialog sfdSocketInfo = new SaveFileDialog();
                                
                sfdSocketInfo.Filter = MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_70) + "（*.sp）|*.sp";
                sfdSocketInfo.RestoreDirectory = true;

                if (sfdSocketInfo.ShowDialog() == DialogResult.OK)
                {
                    XmlDocument doc = new XmlDocument();

                    XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                    doc.AppendChild(xmlDeclaration);

                    XmlElement xeSendList = doc.CreateElement("SendList");
                    doc.AppendChild(xeSendList);

                    if (Socket_Cache.SendList.dtSocketSendList.Rows.Count > 0)
                    {
                        for (int i = 0; i < Socket_Cache.SendList.dtSocketSendList.Rows.Count; i++)
                        {
                            string sIndex = (i + 1).ToString();
                            string sNote = Socket_Cache.SendList.dtSocketSendList.Rows[i]["Remark"].ToString().Trim();
                            string sSocket = Socket_Cache.SendList.dtSocketSendList.Rows[i]["Socket"].ToString().Trim();
                            string sIPTo = Socket_Cache.SendList.dtSocketSendList.Rows[i]["ToAddress"].ToString().Trim();
                            string sLen = Socket_Cache.SendList.dtSocketSendList.Rows[i]["Len"].ToString().Trim();
                            byte[] bBuffer = (byte[])Socket_Cache.SendList.dtSocketSendList.Rows[i]["Bytes"];
                            string sData = BytesToString(Socket_Cache.SocketPacket.EncodingFormat.Hex, bBuffer);

                            XmlElement xeSend = doc.CreateElement("Send");
                            xeSendList.AppendChild(xeSend);

                            XmlElement xeIndex = doc.CreateElement("Index");
                            xeIndex.InnerText = sIndex;
                            xeSend.AppendChild(xeIndex);

                            XmlElement xeNote = doc.CreateElement("Note");
                            xeNote.InnerText = sNote;
                            xeSend.AppendChild(xeNote);

                            XmlElement xeSocket = doc.CreateElement("Socket");
                            xeSocket.InnerText = sSocket;
                            xeSend.AppendChild(xeSocket);

                            XmlElement xeIPTo = doc.CreateElement("IPTo");
                            xeIPTo.InnerText = sIPTo;
                            xeSend.AppendChild(xeIPTo);

                            XmlElement xeLen = doc.CreateElement("Len");
                            xeLen.InnerText = sLen;
                            xeSend.AppendChild(xeLen);

                            XmlElement xeData = doc.CreateElement("Data");
                            xeData.InnerText = sData;
                            xeSend.AppendChild(xeData);
                        }
                    }

                    doc.Save(sfdSocketInfo.FileName);
                }
            }
            catch (Exception ex)
            {
                bReturn = false;
                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            
            return bReturn;
        }

        #endregion

        #region//加载发送列表数据

        public static bool LoadSendList()
        {
            bool bReturn = true;

            try
            {
                OpenFileDialog ofdLoadSocket = new OpenFileDialog();

                ofdLoadSocket.Filter = MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_70) + "（*.sp）|*.sp";
                ofdLoadSocket.RestoreDirectory = true;

                ofdLoadSocket.ShowDialog();
                string FilePath = ofdLoadSocket.FileName;

                if (!string.IsNullOrEmpty(FilePath))
                {  
                    Socket_Cache.SendList.SendListClear();

                    XmlDocument doc = new XmlDocument();
                    doc.Load(FilePath);
                    XmlNode xnSendList = doc.DocumentElement;

                    foreach (XmlNode xnSend in xnSendList.ChildNodes)
                    {
                        string sIndex = xnSend.SelectSingleNode("Index").InnerText;
                        string sNote = xnSend.SelectSingleNode("Note").InnerText;
                        string sSocket = xnSend.SelectSingleNode("Socket").InnerText;
                        string sIPTo = xnSend.SelectSingleNode("IPTo").InnerText;
                        string sLen = xnSend.SelectSingleNode("Len").InnerText;
                        string sData = xnSend.SelectSingleNode("Data").InnerText;

                        int iIndex = int.Parse(sIndex);                        
                        int iSocket = int.Parse(sSocket);                        
                        int iLen = int.Parse(sLen);

                        byte[] bBuffer = StringToBytes(Socket_Cache.SocketPacket.EncodingFormat.Hex, sData);

                        Socket_Cache.SendList.AddToSendList_New(iIndex, sNote, iSocket, sIPTo, sData, bBuffer);
                    }
                }            
            }
            catch (Exception ex)
            {
                bReturn = false;
                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bReturn;
        }

        #endregion

        #region//保存滤镜列表数据

        public static void SaveFilterList_Dialog(string FileName, int FilterIndex)
        {
            try
            {
                if (Socket_Cache.FilterList.lstFilter.Count > 0)
                {
                    SaveFileDialog sfdSocketInfo = new SaveFileDialog();

                    sfdSocketInfo.Filter = MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_75) + "（*.fp）|*.fp";

                    if (!string.IsNullOrEmpty(FileName))
                    {
                        sfdSocketInfo.FileName = FileName;
                    }
                    
                    sfdSocketInfo.RestoreDirectory = true;

                    if (sfdSocketInfo.ShowDialog() == DialogResult.OK)
                    {
                        Socket_PasswordFrom pwForm = new Socket_PasswordFrom(Socket_Cache.FilterList.PWType.Export);
                        pwForm.ShowDialog();

                        SaveFilterList(sfdSocketInfo.FileName, FilterIndex, true);                    
                    }
                }  
            }
            catch (Exception ex)
            {                
                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }        

        public static void SaveFilterList(string FilePath, int FilterIndex, bool DoEncrypt)
        {
            try
            {
                SaveFilterList_ToXDocument(FilePath, FilterIndex);

                if (DoEncrypt)
                {
                    string sPassword = Socket_Cache.FilterList.AESKey;

                    if (!string.IsNullOrEmpty(sPassword))
                    {
                        EncryptFilterList(FilePath, sPassword);
                    }
                }
            }
            catch (Exception ex)
            {  
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private static void SaveFilterList_ToXDocument(string FilePath, int FilterIndex)
        {
            try
            {
                XDocument xdoc = new XDocument
                {
                    Declaration = new XDeclaration("1.0", "utf-8", "yes")
                };

                XElement xeRoot = new XElement("FilterList");
                xdoc.Add(xeRoot);

                if (Socket_Cache.FilterList.lstFilter.Count > 0)
                {
                    int Start = 0;
                    int End = Socket_Cache.FilterList.lstFilter.Count;

                    if (FilterIndex > -1 && FilterIndex < End)
                    {
                        Start = FilterIndex;
                        End = FilterIndex + 1;
                    }

                    for (int i = Start; i < End; i++)
                    {
                        string sIsEnable = Socket_Cache.FilterList.lstFilter[i].IsEnable.ToString();
                        string sFNum = Socket_Cache.FilterList.lstFilter[i].FNum.ToString();
                        string sFName = Socket_Cache.FilterList.lstFilter[i].FName;
                        string sFAppointHeader = Socket_Cache.FilterList.lstFilter[i].AppointHeader.ToString();
                        string sFHeaderContent = Socket_Cache.FilterList.lstFilter[i].HeaderContent;
                        string sFAppointSocket = Socket_Cache.FilterList.lstFilter[i].AppointSocket.ToString();
                        string sFSocketContent = Socket_Cache.FilterList.lstFilter[i].SocketContent.ToString();
                        string sFAppointLength = Socket_Cache.FilterList.lstFilter[i].AppointLength.ToString();
                        string sFLengthContent = Socket_Cache.FilterList.lstFilter[i].LengthContent.ToString();
                        string sFMode = ((int)Socket_Cache.FilterList.lstFilter[i].FMode).ToString();
                        string sFAction = ((int)Socket_Cache.FilterList.lstFilter[i].FAction).ToString();
                        string sFFunction = GetFilterFunctionString(Socket_Cache.FilterList.lstFilter[i].FFunction);
                        string sFStartFrom = ((int)Socket_Cache.FilterList.lstFilter[i].FStartFrom).ToString();
                        string sFProgressionStep = Socket_Cache.FilterList.lstFilter[i].ProgressionStep.ToString();
                        string sFProgressionPosition = Socket_Cache.FilterList.lstFilter[i].ProgressionPosition;
                        string sFSearch = Socket_Cache.FilterList.lstFilter[i].FSearch;
                        string sFModify = Socket_Cache.FilterList.lstFilter[i].FModify;

                        XElement xeFilter =
                            new XElement("Filter",
                            new XElement("IsEnable", sIsEnable),
                            new XElement("Num", sFNum),
                            new XElement("Name", sFName),
                            new XElement("AppointHeader", sFAppointHeader),
                            new XElement("HeaderContent", sFHeaderContent),
                            new XElement("AppointSocket", sFAppointSocket),
                            new XElement("SocketContent", sFSocketContent),
                            new XElement("AppointLength", sFAppointLength),
                            new XElement("LengthContent", sFLengthContent),
                            new XElement("Mode", sFMode),
                            new XElement("Action", sFAction),
                            new XElement("Function", sFFunction),
                            new XElement("StartFrom", sFStartFrom),
                            new XElement("ProgressionStep", sFProgressionStep),
                            new XElement("ProgressionPosition", sFProgressionPosition),
                            new XElement("Search", sFSearch),
                            new XElement("Modify", sFModify)
                            );

                        xeRoot.Add(xeFilter);
                    }
                }

                xdoc.Save(FilePath);
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        #endregion

        #region//加载滤镜列表数据

        public static void LoadFilterList_Dialog()
        {
            try
            {
                OpenFileDialog ofdLoadSocket = new OpenFileDialog();

                ofdLoadSocket.Filter = MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_75) + "（*.fp）|*.fp";
                ofdLoadSocket.RestoreDirectory = true;

                ofdLoadSocket.ShowDialog();
                string FilePath = ofdLoadSocket.FileName;

                if (!string.IsNullOrEmpty(FilePath))
                {
                    LoadFilterList(FilePath, true);
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        public static void LoadFilterList(string FilePath, bool LoadFromUser)
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    XDocument xdoc = new XDocument();

                    bool bEncrypt = IsEncrypt_FilterList(FilePath);

                    if (bEncrypt)
                    {
                        if (LoadFromUser)
                        {
                            Socket_PasswordFrom pwForm = new Socket_PasswordFrom(Socket_Cache.FilterList.PWType.Import);
                            pwForm.ShowDialog();
                        }

                        xdoc = DecryptFilterList(FilePath, Socket_Cache.FilterList.AESKey);
                    }
                    else
                    {
                        xdoc = XDocument.Load(FilePath);
                    }                    

                    if (xdoc == null)
                    {
                        string sError = MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_92);

                        if (LoadFromUser)
                        {
                            ShowMessageBox(sError);
                        }
                        else
                        {
                            DoLog(MethodBase.GetCurrentMethod().Name, sError);
                        }
                    }
                    else
                    {
                        LoadFilterList_FromXDocument(xdoc);

                        if (bEncrypt)
                        {
                            DoLog(MethodBase.GetCurrentMethod().Name, MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_81));
                        }
                        else
                        {
                            DoLog(MethodBase.GetCurrentMethod().Name, MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_80));
                        }
                    }
                }                
            }
            catch (Exception ex)
            {  
                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private static void LoadFilterList_FromXDocument(XDocument xdoc)
        {
            try
            {
                foreach (XElement xeFilter in xdoc.Root.Elements())
                {
                    bool bIsEnable = false;
                    if (xeFilter.Element("IsEnable") != null)
                    {
                        bIsEnable = bool.Parse(xeFilter.Element("IsEnable").Value);
                    }                  
                    
                    string sFNum = string.Empty;
                    if (xeFilter.Element("Num") != null)
                    {
                        sFNum = xeFilter.Element("Num").Value;
                    }

                    string sFName = string.Empty;
                    if (xeFilter.Element("Name") != null)
                    {
                        sFName = xeFilter.Element("Name").Value;
                    }

                    bool bAppointHeader = false;
                    if (xeFilter.Element("AppointHeader") != null)
                    {
                        bAppointHeader = bool.Parse(xeFilter.Element("AppointHeader").Value);
                    }
                    
                    string sFHeaderContent = string.Empty;
                    if (xeFilter.Element("HeaderContent") != null)
                    {
                        sFHeaderContent = xeFilter.Element("HeaderContent").Value;
                    }

                    bool bAppointSocket = false;
                    if (xeFilter.Element("AppointSocket") != null)
                    {
                        bAppointSocket = bool.Parse(xeFilter.Element("AppointSocket").Value);
                    }

                    decimal dFSocketContent = 1;
                    if (xeFilter.Element("SocketContent") != null)
                    {
                        dFSocketContent = decimal.Parse(xeFilter.Element("SocketContent").Value);
                    }

                    bool bAppointLength = false;
                    if (xeFilter.Element("AppointLength") != null)
                    {
                        bAppointLength = bool.Parse(xeFilter.Element("AppointLength").Value);
                    }

                    decimal dFLengthContent = 1;
                    if (xeFilter.Element("LengthContent") != null)
                    {
                        dFLengthContent = decimal.Parse(xeFilter.Element("LengthContent").Value);
                    }

                    Socket_Cache.Filter.FilterMode FilterMode = Socket_Cache.Filter.FilterMode.Normal;
                    if (xeFilter.Element("Mode") != null)
                    {
                        FilterMode = GetFilterMode_ByString(xeFilter.Element("Mode").Value);
                    }

                    Socket_Cache.Filter.FilterAction FilterAction = Socket_Cache.Filter.FilterAction.NoModify_Display;
                    if (xeFilter.Element("Action") != null)
                    {
                        FilterAction = GetFilterAction_ByString(xeFilter.Element("Action").Value);
                    }

                    Socket_Cache.Filter.FilterFunction FilterFunction = new Socket_Cache.Filter.FilterFunction();
                    if (xeFilter.Element("Function") != null)
                    {
                        FilterFunction = GetFilterFunction_ByString(xeFilter.Element("Function").Value);
                    }

                    Socket_Cache.Filter.FilterStartFrom FilterStartFrom = Socket_Cache.Filter.FilterStartFrom.Head;
                    if (xeFilter.Element("StartFrom") != null)
                    {
                        FilterStartFrom = GetFilterStartFrom_ByString(xeFilter.Element("StartFrom").Value);
                    }

                    bool IsProgressionDone = false;

                    decimal dFProgressionStep = 1;
                    if (xeFilter.Element("ProgressionStep") != null)
                    {
                        dFProgressionStep = decimal.Parse(xeFilter.Element("ProgressionStep").Value);
                    }

                    string sFProgressionPosition = string.Empty;
                    if (xeFilter.Element("ProgressionPosition") != null)
                    {
                        sFProgressionPosition = xeFilter.Element("ProgressionPosition").Value;
                    }

                    int iProgressionCount = 0;

                    string sFSearch = string.Empty;
                    if (xeFilter.Element("Search") != null)
                    {
                        sFSearch = xeFilter.Element("Search").Value;
                    }

                    string sFModify = string.Empty;
                    if (xeFilter.Element("Modify") != null)
                    {
                        sFModify = xeFilter.Element("Modify").Value;
                    }

                    Socket_Cache.FilterList.AddFilter_New(bIsEnable, sFName, bAppointHeader, sFHeaderContent, bAppointSocket, dFSocketContent, bAppointLength, dFLengthContent, FilterMode, FilterAction, FilterFunction, FilterStartFrom, IsProgressionDone, dFProgressionStep, sFProgressionPosition, iProgressionCount, sFSearch, sFModify);
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        #endregion

        #region//加解密滤镜列表文件

        private static bool IsEncrypt_FilterList(string FilePath)
        {
            bool bReturn = false;

            try
            {
                XDocument xdoc = XDocument.Load(FilePath);
                XElement xeRoot = xdoc.Root;
            }
            catch
            {
                bReturn = true;
            }

            return bReturn;
        }

        private static byte[] GetAESKeyFromString(string Password)
        {
            byte[] bReturn = null;

            try
            {
                using (MD5 md5 = MD5.Create())
                {
                    byte[] bPW = Encoding.Default.GetBytes(Password);

                    byte[] bPW_MD5 = md5.ComputeHash(bPW);
                    string sPW_MD5 = BitConverter.ToString(bPW_MD5, 4, 8).Replace("-", "");                    

                    bReturn = Encoding.UTF8.GetBytes(sPW_MD5);
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bReturn;
        }

        private static void EncryptFilterList(string FilterList_Path, string Password)
        {
            try
            {
                byte[] bAES = GetAESKeyFromString(Password);

                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = bAES;
                    aesAlg.IV = bAES;

                    XDocument xmlDoc = XDocument.Load(FilterList_Path);

                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, aesAlg.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            xmlDoc.Save(cs);
                        }

                        File.WriteAllBytes(FilterList_Path, ms.ToArray());
                    }
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }            
        }

        private static XDocument DecryptFilterList(string FilterList_Path, string Password)
        {
            XDocument xdReturn = new XDocument();

            try
            {
                byte[] bAES = GetAESKeyFromString(Password);

                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = bAES;
                    aesAlg.IV = bAES;

                    byte[] xmlBytes = File.ReadAllBytes(FilterList_Path);

                    using (MemoryStream ms = new MemoryStream(xmlBytes))
                    {
                        try
                        {
                            using (CryptoStream cs = new CryptoStream(ms, aesAlg.CreateDecryptor(), CryptoStreamMode.Read))
                            {
                                xdReturn = XDocument.Load(cs);
                            }
                        }
                        catch
                        {
                            xdReturn = null;
                        }                        
                    }
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return xdReturn;
        }

        #endregion

        #region//获取滤镜作用类别字符串

        public static string GetFilterFunctionString(Socket_Cache.Filter.FilterFunction FilterFunction)
        { 
            string sReturn = string.Empty;

            try
            {
                sReturn += Convert.ToInt32(FilterFunction.Send) + ":";
                sReturn += Convert.ToInt32(FilterFunction.SendTo) + ":";
                sReturn += Convert.ToInt32(FilterFunction.Recv) + ":";
                sReturn += Convert.ToInt32(FilterFunction.RecvFrom) + ":";
                sReturn += Convert.ToInt32(FilterFunction.WSASend) + ":";
                sReturn += Convert.ToInt32(FilterFunction.WSASendTo) + ":";
                sReturn += Convert.ToInt32(FilterFunction.WSARecv) + ":";
                sReturn += Convert.ToInt32(FilterFunction.WSARecvFrom);
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return sReturn;
        }

        #endregion

        #region//获取滤镜字符串

        public static string GetFilterString_ByBytes(byte[] bBuffer)
        {
            string sReturn = "";

            try
            {
                for (int i = 0; i < bBuffer.Length; i++)
                {
                    string sHex = bBuffer[i].ToString("X2");
                    sReturn += i.ToString() + "-" + sHex + ",";
                }

                sReturn = sReturn.Trim(',');
            }
            catch (Exception ex)
            {
                sReturn = "";
                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return sReturn;
        }    

        #endregion

        #region//获取滤镜选项

        public static Socket_Cache.Filter.FilterMode GetFilterMode_ByString(string FilterMode)
        {
            Socket_Cache.Filter.FilterMode FMode;

            try
            {
                FMode = (Socket_Cache.Filter.FilterMode)Enum.Parse(typeof(Socket_Cache.Filter.FilterMode), FilterMode);
            }
            catch (Exception ex)
            {
                FMode = Socket_Cache.Filter.FilterMode.Normal;
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }                       

            return FMode;
        }

        public static Socket_Cache.Filter.FilterAction GetFilterAction_ByString(string FilterAction)
        {
            Socket_Cache.Filter.FilterAction FAction;

            try
            {
                FAction = (Socket_Cache.Filter.FilterAction)Enum.Parse(typeof(Socket_Cache.Filter.FilterAction), FilterAction);
            }
            catch (Exception ex)
            {
                FAction = Socket_Cache.Filter.FilterAction.Replace;
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return FAction;
        }

        public static Socket_Cache.Filter.FilterFunction GetFilterFunction_ByString(string FilterFunction)
        {
            Socket_Cache.Filter.FilterFunction FFunction = new Socket_Cache.Filter.FilterFunction();

            try
            {
                string[] slFilterFunction = FilterFunction.Split(':');                

                FFunction.Send = Convert.ToBoolean(int.Parse(slFilterFunction[0]));
                FFunction.SendTo = Convert.ToBoolean(int.Parse(slFilterFunction[1]));
                FFunction.Recv = Convert.ToBoolean(int.Parse(slFilterFunction[2]));
                FFunction.RecvFrom = Convert.ToBoolean(int.Parse(slFilterFunction[3]));
                FFunction.WSASend = Convert.ToBoolean(int.Parse(slFilterFunction[4]));
                FFunction.WSASendTo = Convert.ToBoolean(int.Parse(slFilterFunction[5]));
                FFunction.WSARecv = Convert.ToBoolean(int.Parse(slFilterFunction[6]));
                FFunction.WSARecvFrom = Convert.ToBoolean(int.Parse(slFilterFunction[7]));
            }
            catch (Exception ex)
            {  
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return FFunction;
        }

        public static Socket_Cache.Filter.FilterStartFrom GetFilterStartFrom_ByString(string sFStartFrom)
        {
            Socket_Cache.Filter.FilterStartFrom FStartFrom;

            try
            {
                FStartFrom = (Socket_Cache.Filter.FilterStartFrom)Enum.Parse(typeof(Socket_Cache.Filter.FilterStartFrom), sFStartFrom);
            }
            catch (Exception ex)
            {
                FStartFrom = Socket_Cache.Filter.FilterStartFrom.Head;
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return FStartFrom;
        }

        public static Socket_Cache.FilterList.Execute GetFilterListExecute_ByString(string sFLExecute)
        {
            Socket_Cache.FilterList.Execute FLExecute;

            try
            {
                FLExecute = (Socket_Cache.FilterList.Execute)Enum.Parse(typeof(Socket_Cache.FilterList.Execute), sFLExecute);
            }
            catch (Exception ex)
            {
                FLExecute = Socket_Cache.FilterList.Execute.Priority;
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return FLExecute;
        }

        #endregion

        #region//显示滤镜窗体（对话框）

        public static void ShowFilterForm_Dialog(int iFNum)
        {
            try
            {
                if (Socket_Cache.FilterList.lstFilter.Count > 0)
                {
                    if (iFNum > 0)
                    {
                        Socket_FilterForm fFilterForm = new Socket_FilterForm(iFNum);
                        fFilterForm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        #endregion

        #region//删除滤镜（对话框）

        public static void CleanUpFilterList_Dialog()
        {
            try
            {
                DialogResult dr = Socket_Operation.ShowSelectMessageBox(MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_38));

                if (dr.Equals(DialogResult.OK))
                {
                    Socket_Cache.FilterList.FilterListClear();                    
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        public static void DeleteFilter_ByFilterNum_Dialog(int iFNum)
        {
            try
            {
                if (iFNum > 0)
                {
                    DialogResult dr = Socket_Operation.ShowSelectMessageBox(MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_37));

                    if (dr.Equals(DialogResult.OK))
                    {
                        Socket_Cache.FilterList.DeleteFilter_ByFilterNum(iFNum);                        
                    }
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        #endregion

        #region//复制滤镜

        public static int CopyFilter_ByFilterIndex(int iFIndex)
        {
            int iReturn = -1;

            try
            {
                bool IsEnable = false;
                string FName = string.Format(MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_62), Socket_Cache.FilterList.lstFilter[iFIndex].FName);
                bool bAppointHeader = Socket_Cache.FilterList.lstFilter[iFIndex].AppointHeader;
                string HeaderContent = Socket_Cache.FilterList.lstFilter[iFIndex].HeaderContent;
                bool bAppointSocket = Socket_Cache.FilterList.lstFilter[iFIndex].AppointSocket;
                decimal SocketContent = Socket_Cache.FilterList.lstFilter[iFIndex].SocketContent;
                bool bAppointLength = Socket_Cache.FilterList.lstFilter[iFIndex].AppointLength;
                decimal LengthContent = Socket_Cache.FilterList.lstFilter[iFIndex].LengthContent;
                Socket_Cache.Filter.FilterMode FMode = Socket_Cache.FilterList.lstFilter[iFIndex].FMode;
                Socket_Cache.Filter.FilterAction FAction = Socket_Cache.FilterList.lstFilter[iFIndex].FAction;
                Socket_Cache.Filter.FilterFunction FFunction = Socket_Cache.FilterList.lstFilter[iFIndex].FFunction;
                Socket_Cache.Filter.FilterStartFrom FStartFrom = Socket_Cache.FilterList.lstFilter[iFIndex].FStartFrom;
                bool IsProgressionDone = false;
                decimal ProgressionStep = Socket_Cache.FilterList.lstFilter[iFIndex].ProgressionStep;
                string ProgressionPosition = Socket_Cache.FilterList.lstFilter[iFIndex].ProgressionPosition;
                int ProgressionCount = 0;
                string FSearch = Socket_Cache.FilterList.lstFilter[iFIndex].FSearch;
                string FModify = Socket_Cache.FilterList.lstFilter[iFIndex].FModify;

                Socket_Cache.FilterList.AddFilter_New(
                    IsEnable, 
                    FName, 
                    bAppointHeader, 
                    HeaderContent, 
                    bAppointSocket, 
                    SocketContent, 
                    bAppointLength, 
                    LengthContent, 
                    FMode, 
                    FAction, 
                    FFunction, 
                    FStartFrom, 
                    IsProgressionDone, 
                    ProgressionStep, 
                    ProgressionPosition, 
                    ProgressionCount, 
                    FSearch, 
                    FModify);

                iReturn = Socket_Cache.FilterList.lstFilter.Count - 1;
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return iReturn;
        }

        #endregion

        #region//移动滤镜在列表中的位置

        public static int MoveFilter_ByFilterIndex(int iFIndex, Socket_Cache.Filter.FilterMove filterMove)
        {
            int iReturn = -1;

            try
            {
                int iFilterListCount = Socket_Cache.FilterList.lstFilter.Count;

                Socket_FilterInfo sfi = Socket_Cache.FilterList.lstFilter[iFIndex];

                switch (filterMove)
                {
                    case Socket_Cache.Filter.FilterMove.Top:

                        if (iFIndex > 0)
                        {
                            Socket_Cache.FilterList.lstFilter.RemoveAt(iFIndex);
                            Socket_Cache.FilterList.lstFilter.Insert(0, sfi);

                            iReturn = 0;
                        }

                        break;

                    case Socket_Cache.Filter.FilterMove.Up:

                        if (iFIndex > 0)
                        {
                            Socket_Cache.FilterList.lstFilter.RemoveAt(iFIndex);
                            Socket_Cache.FilterList.lstFilter.Insert(iFIndex - 1, sfi);

                            iReturn = iFIndex - 1;
                        }

                        break;

                    case Socket_Cache.Filter.FilterMove.Down:

                        if (iFIndex < iFilterListCount - 1)
                        {
                            Socket_Cache.FilterList.lstFilter.RemoveAt(iFIndex);
                            Socket_Cache.FilterList.lstFilter.Insert(iFIndex + 1, sfi);

                            iReturn = iFIndex + 1;
                        }

                        break;

                    case Socket_Cache.Filter.FilterMove.Bottom:

                        if (iFIndex < iFilterListCount - 1)
                        {
                            Socket_Cache.FilterList.lstFilter.RemoveAt(iFIndex);
                            Socket_Cache.FilterList.lstFilter.Add(sfi);

                            iReturn = Socket_Cache.FilterList.lstFilter.Count - 1;
                        }

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

        #region//检查滤镜是否生效

        public static bool CheckFilter_IsEffective(Int32 iSocket, IntPtr ipBuff, int iLen, Socket_Cache.SocketPacket.PacketType ptType, Socket_FilterInfo sfi)
        {
            bool bResult = true;

            try
            {
                if (sfi.IsEnable)
                {
                    if (CheckFilterFunction_ByPacketType(ptType, sfi.FFunction))
                    {
                        if (sfi.AppointSocket)
                        {
                            if (!CheckPacket_IsMatch_AppointSocket(iSocket, sfi.SocketContent))
                            {
                                return false;
                            }
                        }

                        if (sfi.AppointLength)
                        {
                            if (!CheckPacket_IsMatch_AppointLength(iLen, sfi.LengthContent))
                            {
                                return false;
                            }
                        }

                        if (sfi.AppointHeader)
                        {
                            if (!CheckPacket_IsMatch_AppointHeader(ipBuff, iLen, sfi.HeaderContent))
                            {
                                return false;
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                return false;
            }

            return bResult;
        }

        #endregion

        #region//获取封包类别对应的滤镜作用类别

        public static Socket_Cache.Filter.FilterFunction GetFilterFunction_ByPacketType(Socket_Cache.SocketPacket.PacketType ptType)
        {
            Socket_Cache.Filter.FilterFunction ffReturn = new Socket_Cache.Filter.FilterFunction();

            try
            {
                switch (ptType)
                {
                    case Socket_Cache.SocketPacket.PacketType.Send:
                        ffReturn.Send = true;
                        break;

                    case Socket_Cache.SocketPacket.PacketType.SendTo:
                        ffReturn.SendTo = true;
                        break;

                    case Socket_Cache.SocketPacket.PacketType.Recv:
                        ffReturn.Recv = true;
                        break;

                    case Socket_Cache.SocketPacket.PacketType.RecvFrom:
                        ffReturn.RecvFrom = true;
                        break;

                    case Socket_Cache.SocketPacket.PacketType.WSASend:
                        ffReturn.WSASend = true;
                        break;

                    case Socket_Cache.SocketPacket.PacketType.WSASendTo:
                        ffReturn.WSASendTo = true;
                        break;

                    case Socket_Cache.SocketPacket.PacketType.WSARecv:
                        ffReturn.WSARecv = true;
                        break;

                    case Socket_Cache.SocketPacket.PacketType.WSARecvFrom:
                        ffReturn.WSARecvFrom = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return ffReturn;
        }

        #endregion

        #region//检查滤镜作用类别

        public static bool CheckFilterFunction_ByPacketType(Socket_Cache.SocketPacket.PacketType ptType, Socket_Cache.Filter.FilterFunction ffFunction)
        { 
            bool bReturn = false;

            try
            {
                switch (ptType)
                {
                    case Socket_Cache.SocketPacket.PacketType.Send:
                        bReturn = ffFunction.Send;
                        break;

                    case Socket_Cache.SocketPacket.PacketType.SendTo:
                        bReturn = ffFunction.SendTo;
                        break;

                    case Socket_Cache.SocketPacket.PacketType.Recv:
                        bReturn = ffFunction.Recv;
                        break;

                    case Socket_Cache.SocketPacket.PacketType.RecvFrom:
                        bReturn = ffFunction.RecvFrom;
                        break;

                    case Socket_Cache.SocketPacket.PacketType.WSASend:
                        bReturn = ffFunction.WSASend;
                        break;

                    case Socket_Cache.SocketPacket.PacketType.WSASendTo:
                        bReturn = ffFunction.WSASendTo;
                        break;

                    case Socket_Cache.SocketPacket.PacketType.WSARecv:
                        bReturn = ffFunction.WSARecv;
                        break;

                    case Socket_Cache.SocketPacket.PacketType.WSARecvFrom:
                        bReturn = ffFunction.WSARecvFrom;
                        break;
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bReturn;
        }

        #endregion

        #region//检查是否匹配指定套接字

        public static bool CheckPacket_IsMatch_AppointSocket(Int32 iSocket, decimal dSocketContent)
        {
            bool bResult = false;

            try
            {
                if (iSocket == dSocketContent)
                {
                    bResult = true;
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_53) + ex.Message);
            }

            return bResult;
        }

        #endregion

        #region//检查是否匹配指定长度

        public static bool CheckPacket_IsMatch_AppointLength(int iLen, decimal dLengthContent)
        {
            bool bResult = false;

            try
            {
                if (iLen == dLengthContent)
                {
                    bResult = true;
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_53) + ex.Message);
            }

            return bResult;
        }

        #endregion

        #region//检查是否匹配指定包头

        public static bool CheckPacket_IsMatch_AppointHeader(IntPtr ipBuff, int iLen, string sHeaderContent)
        {
            bool bResult = false;

            try
            {
                if (!string.IsNullOrEmpty(sHeaderContent))
                {
                    byte[] bHeaderContent = Socket_Operation.StringToBytes(Socket_Cache.SocketPacket.EncodingFormat.Hex, sHeaderContent);
                    int iHeaderContent_Len = bHeaderContent.Length;

                    if (iHeaderContent_Len > 0 && iHeaderContent_Len <= iLen)
                    {
                        byte[] bPacketHeader = Socket_Operation.GetBytes_FromIntPtr(ipBuff, iHeaderContent_Len);
                        string sPacketHeader = Socket_Operation.BytesToString(Socket_Cache.SocketPacket.EncodingFormat.Hex, bPacketHeader);

                        if (sHeaderContent.Equals(sPacketHeader))
                        {
                            bResult = true;
                        }
                    }                    
                }                
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_53) + ex.Message);
            }

            return bResult;
        }

        #endregion

        #region//检查滤镜是否匹配成功（普通滤镜）

        public static bool CheckFilter_IsMatch_Normal(Socket_FilterInfo sfi, IntPtr ipBuff, int iLen)
        {
            bool bResult = true;

            try
            {
                if (!string.IsNullOrEmpty(sfi.FSearch))
                {
                    string[] slSearch = sfi.FSearch.Split(',');

                    foreach (string sSearch in slSearch)
                    {
                        if (!string.IsNullOrEmpty(sSearch) && sSearch.IndexOf("-") > 0)
                        {
                            int iIndex = int.Parse(sSearch.Split('-')[0]);
                            string sValue = sSearch.Split('-')[1];

                            if (iIndex >= 0 && iIndex < iLen)
                            {
                                string sBuffValue = Marshal.ReadByte(ipBuff, iIndex).ToString("X2");

                                if (!sValue.Equals(sBuffValue))
                                {
                                    bResult = false;
                                    break;
                                }
                            }
                            else
                            {
                                bResult = false;
                                break;
                            }
                        }                        
                    }
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_53) + ex.Message);
                bResult = false;
            }

            return bResult;
        }

        #endregion

        #region//检查滤镜是否匹配成功（高级滤镜）

        public static List<int> CheckFilter_IsMatch_Adcanced(Socket_FilterInfo sfi, IntPtr ipBuff, int iLen)
        {
            List<int> lReturn = new List<int>();

            try
            {
                if (!string.IsNullOrEmpty(sfi.FSearch))
                {
                    byte[] bBUffer = Socket_Operation.GetBytes_FromIntPtr(ipBuff, iLen);

                    Dictionary<int, int> dSearchIndex = new Dictionary<int, int>();
                    Dictionary<int, byte> dSearchValue = new Dictionary<int, byte>();

                    string[] slSearch = sfi.FSearch.Split(',');

                    for (int i = 0; i < slSearch.Length; i++)
                    {
                        int iIndex = int.Parse(slSearch[i].Split('-')[0]);
                        string sValue = slSearch[i].Split('-')[1];
                        byte bValue = Convert.ToByte(sValue, 16);

                        dSearchIndex.Add(i, iIndex);
                        dSearchValue.Add(i, bValue);
                    }

                    int iMatchIndex = -1;
                    int iBuffIndex = -1;

                    byte bFirst_SearchValue = dSearchValue[0];

                    for (int i = 0; i < iLen; i++)
                    {
                        if (bBUffer[i] == bFirst_SearchValue)
                        {
                            iMatchIndex = i;

                            for (int j = 1; j < slSearch.Length; j++)
                            {
                                int iIndex = dSearchIndex[j];
                                byte bValue = dSearchValue[j];

                                iBuffIndex = i + iIndex;

                                if (iBuffIndex >= 0 && iBuffIndex < iLen)
                                {
                                    if (bBUffer[iBuffIndex] != bValue)
                                    {
                                        iMatchIndex = -1;
                                        break;
                                    }
                                }
                                else
                                {
                                    iMatchIndex = -1;
                                    break;
                                }
                            }

                            if (iMatchIndex > -1)
                            {
                                lReturn.Add(iMatchIndex);

                                if (iBuffIndex > i)
                                {
                                    i = iBuffIndex;
                                }

                                if (sfi.FStartFrom == Socket_Cache.Filter.FilterStartFrom.Head)
                                {
                                    break;
                                }
                            }
                        }
                    }
                }                
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_53) + ex.Message);
            }

            return lReturn;
        }

        #endregion

        #region//执行滤镜（普通滤镜）

        public static bool DoFilter_Normal(Socket_FilterInfo sfi, IntPtr ipBuff, int iLen)
        {
            bool bReturn = true;

            try
            {
                if (string.IsNullOrEmpty(sfi.FSearch))
                {
                    return false;
                }

                if (string.IsNullOrEmpty(sfi.FModify) && string.IsNullOrEmpty(sfi.ProgressionPosition))
                {
                    return false;
                }

                if (!string.IsNullOrEmpty(sfi.FModify))
                {
                    string[] slModify = sfi.FModify.Split(',');

                    foreach (string sModify in slModify)
                    {
                        if (!string.IsNullOrEmpty(sModify) && sModify.IndexOf("-") > 0)
                        {
                            int iIndex = int.Parse(sModify.Split('-')[0]);
                            string sValue = sModify.Split('-')[1];

                            if (iIndex >= 0 && iIndex < iLen)
                            {
                                byte bValue = Convert.ToByte(sValue, 16);
                                Marshal.WriteByte(ipBuff, iIndex, bValue);
                            }
                        }
                    }
                }

                if (!string.IsNullOrEmpty(sfi.ProgressionPosition))
                {
                    int iStep = ((int)sfi.ProgressionStep);
                    string[] slProgression = sfi.ProgressionPosition.Split(',');

                    foreach (string sProgression in slProgression)
                    {
                        if (!string.IsNullOrEmpty(sProgression))
                        {
                            if (int.TryParse(sProgression, out int iIndex))
                            {
                                if (iIndex >= 0 && iIndex < iLen)
                                {  
                                    byte bValue = Marshal.ReadByte(ipBuff, iIndex);
                                    bValue = GetStepByte(bValue, iStep * (sfi.ProgressionCount + 1));
                                    Marshal.WriteByte(ipBuff, iIndex, bValue);

                                    sfi.IsProgressionDone = true;
                                }  
                            }                           
                        }
                    }                 
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                bReturn = false;
            }

            return bReturn;
        }

        #endregion

        #region//执行滤镜（高级滤镜）

        public static bool DoFilter_Advanced(Socket_FilterInfo sfi, int iMatch, IntPtr ipBuff, int iLen)
        {
            bool bReturn = true;

            try
            {
                if (string.IsNullOrEmpty(sfi.FSearch))
                {
                    return false;
                }

                if (string.IsNullOrEmpty(sfi.FModify) && string.IsNullOrEmpty(sfi.ProgressionPosition))
                {
                    return false;
                }

                Socket_Cache.Filter.FilterStartFrom FStartFrom = sfi.FStartFrom;

                if (!string.IsNullOrEmpty(sfi.FModify))
                {
                    string[] slModify = sfi.FModify.Split(',');

                    foreach (string sModify in slModify)
                    {
                        if (!string.IsNullOrEmpty(sModify) && sModify.IndexOf("-") > 0)
                        {
                            if (int.TryParse(sModify.Split('-')[0], out int iIndex))
                            {
                                string sValue = sModify.Split('-')[1];

                                if (FStartFrom == Socket_Cache.Filter.FilterStartFrom.Position)
                                {
                                    iIndex = iMatch + (iIndex - (Socket_Cache.Filter.FilterSize_MaxLen / 2));
                                }                             

                                if (iIndex >= 0 && iIndex < iLen)
                                {
                                    byte bValue = Convert.ToByte(sValue, 16);
                                    Marshal.WriteByte(ipBuff, iIndex, bValue);
                                }
                            }
                        }
                    }
                }

                if (!string.IsNullOrEmpty(sfi.ProgressionPosition))
                {
                    int iStep = ((int)sfi.ProgressionStep);
                    string[] slProgression = sfi.ProgressionPosition.Split(',');                    

                    foreach (string sProgression in slProgression)
                    {
                        if (!string.IsNullOrEmpty(sProgression))
                        {
                            if (int.TryParse(sProgression, out int iIndex))
                            {
                                if (FStartFrom == Socket_Cache.Filter.FilterStartFrom.Position)
                                {
                                    iIndex = iMatch + (iIndex - (Socket_Cache.Filter.FilterSize_MaxLen / 2));
                                }                                

                                if (iIndex >= 0 && iIndex < iLen)
                                {
                                    byte bValue = Marshal.ReadByte(ipBuff, iIndex);                                    
                                    bValue = GetStepByte(bValue, iStep * (sfi.ProgressionCount + 1));                                    
                                    Marshal.WriteByte(ipBuff, iIndex, bValue);

                                    sfi.IsProgressionDone = true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                bReturn = false;
            }

            return bReturn;
        }

        #endregion

        #region//保存封包列表为Excel

        public static void SaveSocketListToExcel()
        {
            int iSuccess = 0;

            try
            {
                if (Socket_Cache.SocketList.lstRecPacket.Count > 0)
                {
                    SaveFileDialog sfdSaveToExcel = new SaveFileDialog();
                    sfdSaveToExcel.Filter = "Execl files (*.xls)|*.xls";
                    sfdSaveToExcel.FilterIndex = 0;
                    sfdSaveToExcel.RestoreDirectory = true;
                    sfdSaveToExcel.CreatePrompt = true;

                    sfdSaveToExcel.Title = MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_76);

                    if (sfdSaveToExcel.ShowDialog() == DialogResult.OK)
                    {
                        Stream myStream = sfdSaveToExcel.OpenFile();
                        StreamWriter sw = new StreamWriter(myStream, Encoding.GetEncoding(-0));

                        string sColTitle = MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_77);
                        sw.WriteLine(sColTitle);

                        foreach (Socket_PacketInfo spi in Socket_Cache.SocketList.lstRecPacket)
                        {
                            try
                            {
                                string sColValue = "";

                                string sTime = spi.PacketTime.ToString("yyyy-MM-dd HH:mm:ss:fffffff");
                                string sIndex = spi.PacketIndex.ToString();
                                string sType = spi.PacketType.ToString();
                                string sSocket = spi.PacketSocket.ToString();
                                string sFrom = spi.PacketFrom;
                                string sTo = spi.PacketTo;
                                string sLen = spi.PacketLen.ToString();
                                byte[] bBuff = spi.PacketBuffer;
                                string sData = BytesToString(Socket_Cache.SocketPacket.EncodingFormat.Hex, bBuff);

                                sColValue += sTime + "\t" + sIndex + "\t" + sType + "\t" + sSocket + "\t" + sFrom + "\t" + sTo + "\t" + sLen + "\t" + sData + "\t";
                                sw.WriteLine(sColValue);

                                iSuccess++;
                            }
                            catch (Exception ex)
                            {
                                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                            }
                        }

                        sw.Close();
                        myStream.Close();                        
                    }
                }
            }
            catch(Exception ex)
            {
                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }            
        }

        #endregion

        #region//保存日志列表为Excel
        
        public static void SaveLogListToExcel()
        {
            int iSuccess = 0;

            try
            {
                SaveFileDialog sfdSaveToExcel = new SaveFileDialog();
                sfdSaveToExcel.Filter = "Execl files (*.xls)|*.xls";
                sfdSaveToExcel.FilterIndex = 0;
                sfdSaveToExcel.RestoreDirectory = true;
                sfdSaveToExcel.CreatePrompt = true;
                                
                sfdSaveToExcel.Title = MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_76);

                if (sfdSaveToExcel.ShowDialog() == DialogResult.OK)
                {
                    Stream myStream = sfdSaveToExcel.OpenFile();
                    StreamWriter sw = new StreamWriter(myStream, Encoding.GetEncoding(-0));
                                        
                    string sColTitle = MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_78);
                    sw.WriteLine(sColTitle);

                    foreach (Socket_LogInfo sl in Socket_Cache.LogList.lstRecLog)
                    {
                        try
                        {
                            string sColValue = "";

                            string sTime = sl.LogTime;
                            string sFuncName = sl.FuncName;
                            string sContent = sl.LogContent;

                            sColValue += sTime + "\t" + sFuncName + "\t" + sContent + "\t";
                            sw.WriteLine(sColValue);

                            iSuccess++;
                        }
                        catch (Exception ex)
                        {
                            DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
                        }
                    }

                    sw.Close();
                    myStream.Close();
                }
            }
            catch (Exception ex)
            {  
                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        #endregion        

        #region//保存系统设置

        public static bool SaveConfigs()
        {
            bool bReturn = true;

            try
            {
                Properties.Settings.Default.FilterConfig_CheckNotShow = Socket_Cache.CheckNotShow;
                Properties.Settings.Default.FilterConfig_CheckSocket = Socket_Cache.CheckSocket;
                Properties.Settings.Default.FilterConfig_CheckIP = Socket_Cache.CheckIP;
                Properties.Settings.Default.FilterConfig_CheckPort = Socket_Cache.CheckPort;
                Properties.Settings.Default.FilterConfig_CheckHead = Socket_Cache.CheckHead;
                Properties.Settings.Default.FilterConfig_CheckData = Socket_Cache.CheckData;
                Properties.Settings.Default.FilterConfig_CheckSize = Socket_Cache.CheckSize;

                Properties.Settings.Default.FilterConfig_CheckSocket_Value = Socket_Cache.CheckSocket_Value;
                Properties.Settings.Default.FilterConfig_CheckLength_Value = Socket_Cache.CheckLength_Value;
                Properties.Settings.Default.FilterConfig_CheckIP_Value = Socket_Cache.CheckIP_Value;
                Properties.Settings.Default.FilterConfig_CheckPort_Value = Socket_Cache.CheckPort_Value;
                Properties.Settings.Default.FilterConfig_CheckHead_Value = Socket_Cache.CheckHead_Value;
                Properties.Settings.Default.FilterConfig_CheckData_Value = Socket_Cache.CheckData_Value;                

                Properties.Settings.Default.HookConfig_HookSend = Socket_Cache.HookSend;
                Properties.Settings.Default.HookConfig_HookSendTo = Socket_Cache.HookSendTo;
                Properties.Settings.Default.HookConfig_HookRecv = Socket_Cache.HookRecv;
                Properties.Settings.Default.HookConfig_HookRecvFrom = Socket_Cache.HookRecvFrom;
                Properties.Settings.Default.HookConfig_HookWSASend = Socket_Cache.HookWSASend;
                Properties.Settings.Default.HookConfig_HookWSASendTo = Socket_Cache.HookWSASendTo;
                Properties.Settings.Default.HookConfig_HookWSARecv = Socket_Cache.HookWSARecv;
                Properties.Settings.Default.HookConfig_HookWSARecvFrom = Socket_Cache.HookWSARecvFrom;

                Properties.Settings.Default.ListConfig_SocketList_AutoRoll = Socket_Cache.SocketList.AutoRoll;
                Properties.Settings.Default.ListConfig_SocketList_AutoClear = Socket_Cache.SocketList.AutoClear;
                Properties.Settings.Default.ListConfig_SocketList_AutoClear_Value = Socket_Cache.SocketList.AutoClear_Value;
                Properties.Settings.Default.ListConfig_LogList_AutoRoll = Socket_Cache.LogList.AutoRoll;
                Properties.Settings.Default.ListConfig_LogList_AutoClear = Socket_Cache.LogList.AutoClear;
                Properties.Settings.Default.ListConfig_LogList_AutoClear_Value = Socket_Cache.LogList.AutoClear_Value;                

                Properties.Settings.Default.SystemConfig_SpeedMode = Socket_Cache.SpeedMode;
                Properties.Settings.Default.SystemConfig_FilterList_Execute = Socket_Cache.FilterList.FilterList_Execute.ToString();

                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                bReturn = false;
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bReturn;
        }

        #endregion

        #region//加载系统设置

        public static void LoadConfigs()
        {
            try
            {
                Socket_Cache.CheckNotShow = Properties.Settings.Default.FilterConfig_CheckNotShow;
                Socket_Cache.CheckSocket = Properties.Settings.Default.FilterConfig_CheckSocket;
                Socket_Cache.CheckIP = Properties.Settings.Default.FilterConfig_CheckIP;
                Socket_Cache.CheckPort = Properties.Settings.Default.FilterConfig_CheckPort;
                Socket_Cache.CheckHead = Properties.Settings.Default.FilterConfig_CheckHead;
                Socket_Cache.CheckData = Properties.Settings.Default.FilterConfig_CheckData;
                Socket_Cache.CheckSize = Properties.Settings.Default.FilterConfig_CheckSize;

                Socket_Cache.CheckSocket_Value = Properties.Settings.Default.FilterConfig_CheckSocket_Value;
                Socket_Cache.CheckLength_Value = Properties.Settings.Default.FilterConfig_CheckLength_Value;
                Socket_Cache.CheckIP_Value = Properties.Settings.Default.FilterConfig_CheckIP_Value;
                Socket_Cache.CheckPort_Value = Properties.Settings.Default.FilterConfig_CheckPort_Value;
                Socket_Cache.CheckHead_Value = Properties.Settings.Default.FilterConfig_CheckHead_Value;
                Socket_Cache.CheckData_Value = Properties.Settings.Default.FilterConfig_CheckData_Value;             

                Socket_Cache.HookSend = Properties.Settings.Default.HookConfig_HookSend;
                Socket_Cache.HookSendTo = Properties.Settings.Default.HookConfig_HookSendTo;
                Socket_Cache.HookRecv = Properties.Settings.Default.HookConfig_HookRecv;
                Socket_Cache.HookRecvFrom = Properties.Settings.Default.HookConfig_HookRecvFrom;
                Socket_Cache.HookWSASend = Properties.Settings.Default.HookConfig_HookWSASend;
                Socket_Cache.HookWSASendTo = Properties.Settings.Default.HookConfig_HookWSASendTo;
                Socket_Cache.HookWSARecv = Properties.Settings.Default.HookConfig_HookWSARecv;
                Socket_Cache.HookWSARecvFrom = Properties.Settings.Default.HookConfig_HookWSARecvFrom;            

                Socket_Cache.SocketList.AutoRoll = Properties.Settings.Default.ListConfig_SocketList_AutoRoll;
                Socket_Cache.SocketList.AutoClear = Properties.Settings.Default.ListConfig_SocketList_AutoClear;
                Socket_Cache.SocketList.AutoClear_Value = Properties.Settings.Default.ListConfig_SocketList_AutoClear_Value;
                Socket_Cache.LogList.AutoRoll = Properties.Settings.Default.ListConfig_LogList_AutoRoll;
                Socket_Cache.LogList.AutoClear = Properties.Settings.Default.ListConfig_LogList_AutoClear;
                Socket_Cache.LogList.AutoClear_Value = Properties.Settings.Default.ListConfig_LogList_AutoClear_Value;                

                Socket_Cache.SpeedMode = Properties.Settings.Default.SystemConfig_SpeedMode;
                Socket_Cache.FilterList.FilterList_Execute = GetFilterListExecute_ByString(Properties.Settings.Default.SystemConfig_FilterList_Execute);
            }
            catch (Exception ex)
            {                
                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }            
        }

        #endregion

        #region//弹出对话框
        public static void ShowMessageBox(string sMessage)
        {
            try
            {                
                MessageBox.Show(sMessage, MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_79), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }            
        }

        public static DialogResult ShowSelectMessageBox(string sMessage)
        {
            DialogResult dr = new DialogResult();

            try
            {                
                dr = MessageBox.Show(sMessage, MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_79), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return dr;
        }
        #endregion

        #region//记录日志        

        public static void DoLog(string sFuncName, string sLogContent)
        {
            if (bDoLog)
            {
                Task.Run(() =>
                {
                    Socket_Cache.LogQueue.LogToQueue(sFuncName, sLogContent);
                });
            }                     
        }

        #endregion

        #region//发送封包

        public static bool SendPacket(int iSocket, Socket_Cache.SocketPacket.PacketType stType, string sIPFrom, string sIPTo, byte[] bSendBuffer)
        {
            bool bReturn = false;

            try
            {
                if (iSocket > 0 && bSendBuffer.Length > 0)
                {
                    IntPtr ipSend = Marshal.AllocHGlobal(bSendBuffer.Length);
                    Marshal.Copy(bSendBuffer, 0, ipSend, bSendBuffer.Length);

                    int res = -1;
                    string sIPString = string.Empty;

                    if (stType == Socket_Cache.SocketPacket.PacketType.Send || stType == Socket_Cache.SocketPacket.PacketType.SendTo || stType == Socket_Cache.SocketPacket.PacketType.WSASend || stType == Socket_Cache.SocketPacket.PacketType.WSASendTo)
                    {
                        sIPString = sIPTo;
                    }
                    else if (stType == Socket_Cache.SocketPacket.PacketType.Recv || stType == Socket_Cache.SocketPacket.PacketType.RecvFrom || stType == Socket_Cache.SocketPacket.PacketType.WSARecv || stType == Socket_Cache.SocketPacket.PacketType.WSARecvFrom)
                    {
                        sIPString = sIPFrom;
                    }

                    if (stType == Socket_Cache.SocketPacket.PacketType.Send || stType == Socket_Cache.SocketPacket.PacketType.Recv || stType == Socket_Cache.SocketPacket.PacketType.WSASend || stType == Socket_Cache.SocketPacket.PacketType.WSARecv)
                    {
                        res = WS2_32.send(iSocket, ipSend, bSendBuffer.Length, SocketFlags.None);
                    }
                    else if (stType == Socket_Cache.SocketPacket.PacketType.SendTo || stType == Socket_Cache.SocketPacket.PacketType.RecvFrom || stType == Socket_Cache.SocketPacket.PacketType.WSASendTo || stType == Socket_Cache.SocketPacket.PacketType.WSARecvFrom)
                    {
                        Socket_Cache.SocketPacket.sockaddr saAddr = Socket_Operation.GetSocketAddr_ByIPString(sIPString);

                        int iSizeAddr = Marshal.SizeOf(saAddr);
                        IntPtr ipAddr = Marshal.AllocHGlobal(iSizeAddr);

                        Marshal.StructureToPtr<Socket_Cache.SocketPacket.sockaddr>(saAddr, ipAddr, true);

                        res = WS2_32.sendto(iSocket, ipSend, bSendBuffer.Length, SocketFlags.None, ipAddr, iSizeAddr);
                    }

                    if (res > 0)
                    {
                        bReturn = true;
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
    }
}
