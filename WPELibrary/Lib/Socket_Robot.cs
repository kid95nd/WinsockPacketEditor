﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using WindowsInput.Native;

namespace WPELibrary.Lib
{
    public class Socket_Robot
    {
        public int Instruction_Index = 0;
        public int Send_Success = 0;
        public int Send_Failure = 0;
        public int Total_Instruction = 0;
        public string RobotName = string.Empty;
        
        private DataTable RobotInstruction = new DataTable();
        public BackgroundWorker Worker = new BackgroundWorker();
        private readonly WindowsInput.InputSimulator sim = new WindowsInput.InputSimulator();

        #region//初始化

        public Socket_Robot()
        {  
            this.Worker.WorkerSupportsCancellation = true;
            this.Worker.WorkerReportsProgress = true;

            this.Worker.DoWork -= Robot_DoWork;
            this.Worker.DoWork += Robot_DoWork;

            this.Worker.ProgressChanged -= Robot_ProgressChanged;
            this.Worker.ProgressChanged += Robot_ProgressChanged;

            this.Worker.RunWorkerCompleted -= Robot_RunCompleted;
            this.Worker.RunWorkerCompleted += Robot_RunCompleted;
        }

        #endregion

        #region//启动机器人

        public void StartRobot(string RobotName, DataTable dtRobotInstruction)
        {
            try
            {
                if (!this.Worker.IsBusy)
                {
                    if (dtRobotInstruction.Rows.Count > 0)
                    {
                        this.RobotName = RobotName;
                        this.RobotInstruction = dtRobotInstruction;

                        int iReturn = Socket_Cache.Robot.CheckRobotInstruction(this.RobotInstruction, true);

                        if (iReturn > -1)
                        {
                            string sLog = string.Format(MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_123), iReturn + 1, this.RobotName);
                            Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, sLog);
                        }
                        else
                        {
                            this.Worker.RunWorkerAsync();

                            string sLog = string.Format(MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_109), this.RobotName);
                            Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, sLog);
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

        #region//停止机器人

        public void StopRobot()
        {
            try
            {
                if (this.Worker.IsBusy)
                {
                    this.Worker.CancelAsync();
                }                
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        #endregion

        #region//执行指令集

        private void Robot_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (this.RobotInstruction.Rows.Count > 0)
                {
                    this.Total_Instruction = 0;
                    this.Send_Success = 0;
                    this.Send_Failure = 0;

                    int iLoopStart = 0;
                    int iLoopCNT = 1;          

                    for (int i = 0; i < this.RobotInstruction.Rows.Count; i++)
                    {
                        if (Worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return;
                        }

                        Worker.ReportProgress(i);             

                        Socket_Cache.Robot.InstructionType instructionType = (Socket_Cache.Robot.InstructionType)RobotInstruction.Rows[i]["Type"];
                        string sContent = RobotInstruction.Rows[i]["Content"].ToString();

                        switch (instructionType)
                        {
                            case Socket_Cache.Robot.InstructionType.Send:

                                if (!string.IsNullOrEmpty(sContent) && sContent.IndexOf("|") > 0)
                                {
                                    int SendPacket_Index = 0;
                                    if (int.TryParse(sContent.Split('|')[0], out int iIndex))
                                    {
                                        SendPacket_Index = iIndex;
                                    }

                                    int SendPacket_Socket = 0;
                                    if (int.TryParse(sContent.Split('|')[1], out int iSocket))
                                    {
                                        SendPacket_Socket = iSocket;
                                    }

                                    bool bOK = Socket_Cache.SendList.DoSendList_ByIndex(SendPacket_Socket, SendPacket_Index);

                                    if (bOK)
                                    {
                                        this.Send_Success++;
                                    }
                                    else
                                    {
                                        this.Send_Failure++;
                                    }                                  
                                }

                                break;

                            case Socket_Cache.Robot.InstructionType.Delay:

                                if (int.TryParse(sContent, out int iDelay))
                                {
                                    Thread.Sleep(iDelay);                                
                                }

                                break;

                            case Socket_Cache.Robot.InstructionType.LoopStart:

                                iLoopStart = i;
                                int.TryParse(sContent, out iLoopCNT);

                                break;

                            case Socket_Cache.Robot.InstructionType.LoopEnd:

                                iLoopCNT--;

                                if (iLoopCNT > 0)
                                {
                                    i = iLoopStart;
                                }

                                break;

                            case Socket_Cache.Robot.InstructionType.KeyBoard:

                                if (!string.IsNullOrEmpty(sContent) && sContent.IndexOf("|") > 0)
                                {
                                    Socket_Cache.Robot.KeyBoardType kbType = Socket_Cache.Robot.GetKeyBoardType_ByString(sContent.Split('|')[0].ToString());
                                    string KeyCode = sContent.Split('|')[1];

                                    Keys kCode;
                                    VirtualKeyCode vkCode;                                    

                                    switch (kbType)
                                    {
                                        case Socket_Cache.Robot.KeyBoardType.Press:

                                            if (Enum.TryParse(KeyCode, true, out kCode))
                                            {
                                                if (Enum.TryParse(((int)kCode).ToString(), true, out vkCode))
                                                {
                                                    sim.Keyboard.KeyPress(vkCode);
                                                }
                                            }                                            

                                            break;

                                        case Socket_Cache.Robot.KeyBoardType.Down:

                                            if (Enum.TryParse(KeyCode, true, out kCode))
                                            {
                                                if (Enum.TryParse(((int)kCode).ToString(), true, out vkCode))
                                                {
                                                    sim.Keyboard.KeyDown(vkCode);
                                                }
                                            }

                                            break;

                                        case Socket_Cache.Robot.KeyBoardType.Up:

                                            if (Enum.TryParse(KeyCode, true, out kCode))
                                            {
                                                if (Enum.TryParse(((int)kCode).ToString(), true, out vkCode))
                                                {
                                                    sim.Keyboard.KeyUp(vkCode);
                                                }
                                            }

                                            break;

                                        case Socket_Cache.Robot.KeyBoardType.Combine:

                                            if (KeyCode.IndexOf("+") > 0)
                                            {
                                                string[] slKeyCode = KeyCode.Split('+');                                                

                                                List<VirtualKeyCode> ControlKey = new List<VirtualKeyCode>();
                                                List<VirtualKeyCode> NormalKey = new List<VirtualKeyCode>();                                               

                                                foreach (string sKey in slKeyCode)
                                                {
                                                    if (Enum.TryParse(sKey, true, out kCode))
                                                    {
                                                        if (Enum.TryParse(((int)kCode).ToString(), true, out vkCode))
                                                        {
                                                            if (vkCode == VirtualKeyCode.CONTROL || vkCode == VirtualKeyCode.MENU || vkCode == VirtualKeyCode.SHIFT)
                                                            {
                                                                ControlKey.Add(vkCode);
                                                            }
                                                            else
                                                            {
                                                                NormalKey.Add(vkCode);
                                                            }
                                                        }
                                                    }
                                                }

                                                sim.Keyboard.ModifiedKeyStroke(ControlKey, NormalKey);
                                            }

                                            break;

                                        case Socket_Cache.Robot.KeyBoardType.Text:

                                            if (!string.IsNullOrEmpty(KeyCode))
                                            {
                                                sim.Keyboard.TextEntry(KeyCode);
                                            }

                                            break;
                                    }                                    
                                }                           

                                break;

                            case Socket_Cache.Robot.InstructionType.Mouse:

                                if (!string.IsNullOrEmpty(sContent) && sContent.IndexOf("|") > 0)
                                {
                                    Socket_Cache.Robot.MouseType mType = Socket_Cache.Robot.GetMouseType_ByString(sContent.Split('|')[0].ToString());
                                    string MouseCode = sContent.Split('|')[1];

                                    int iMouseCode = 0;
                                    switch (mType)
                                    {
                                        case Socket_Cache.Robot.MouseType.LeftClick:
                                            sim.Mouse.LeftButtonClick();                                           
                                            break;

                                        case Socket_Cache.Robot.MouseType.RightClick:
                                            sim.Mouse.RightButtonClick();
                                            break;

                                        case Socket_Cache.Robot.MouseType.LeftDBClick:
                                            sim.Mouse.LeftButtonDoubleClick();
                                            break;

                                        case Socket_Cache.Robot.MouseType.RightDBClick:
                                            sim.Mouse.RightButtonDoubleClick();
                                            break;

                                        case Socket_Cache.Robot.MouseType.LeftDown:
                                            sim.Mouse.LeftButtonDown();
                                            break;

                                        case Socket_Cache.Robot.MouseType.LeftUp:
                                            sim.Mouse.LeftButtonUp();
                                            break;

                                        case Socket_Cache.Robot.MouseType.RightDown:
                                            sim.Mouse.RightButtonDown();
                                            break;

                                        case Socket_Cache.Robot.MouseType.RightUp:
                                            sim.Mouse.RightButtonUp();
                                            break;

                                        case Socket_Cache.Robot.MouseType.WheelUp:

                                            if (int.TryParse(MouseCode, out iMouseCode))
                                            {
                                                sim.Mouse.VerticalScroll(iMouseCode);                                                
                                            }
                                            
                                            break;

                                        case Socket_Cache.Robot.MouseType.WheelDown:

                                            if (int.TryParse(MouseCode, out iMouseCode))
                                            {
                                                sim.Mouse.VerticalScroll(-iMouseCode);
                                            }

                                            break;

                                        case Socket_Cache.Robot.MouseType.MoveTo:

                                            if (MouseCode.IndexOf(",") > 0)
                                            {
                                                string sMoveX = MouseCode.Split(',')[0].Trim();
                                                string sMoveY = MouseCode.Split(',')[1].Trim();

                                                if (int.TryParse(sMoveX, out int iX) && int.TryParse(sMoveY, out int iY))
                                                {
                                                    sim.Mouse.MoveMouseTo(iX, iY);
                                                }                                              
                                            }                                         

                                            break;

                                        case Socket_Cache.Robot.MouseType.MoveBy:

                                            if (MouseCode.IndexOf(",") > 0)
                                            {
                                                string sMoveX = MouseCode.Split(',')[0].Trim();
                                                string sMoveY = MouseCode.Split(',')[1].Trim();

                                                if (int.TryParse(sMoveX, out int iX) && int.TryParse(sMoveY, out int iY))
                                                {
                                                    sim.Mouse.MoveMouseBy(iX, iY);
                                                }
                                            }

                                            break;
                                    }
                                }

                                break;
                        }

                        if (instructionType != Socket_Cache.Robot.InstructionType.LoopStart && instructionType != Socket_Cache.Robot.InstructionType.LoopEnd)
                        {
                            this.Total_Instruction++;
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

        #region//汇报进度

        private void Robot_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.Instruction_Index = e.ProgressPercentage;
        }

        #endregion

        #region//执行完毕

        private void Robot_RunCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled)
                {
                    string sLog = string.Format(MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_110), this.RobotName);
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, sLog);                    
                }
                else if (e.Error != null)
                {
                    string sLog = string.Format(MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_111), this.RobotName, e.Error.Message);
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, sLog);
                }
                else
                {
                    string sLog = string.Format(MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_112), this.RobotName);
                    Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, sLog);
                }              
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        #endregion
    }
}