﻿using System;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using WPELibrary.Lib;

namespace WinsockPacketEditor
{
    public partial class SystemMode_Form : Form
    {        
        private string WebSiteURL = string.Empty;
        private readonly ToolTip tt = new ToolTip();

        #region//窗体加载

        public SystemMode_Form()
        {
            MultiLanguage.SetDefaultLanguage(Properties.Settings.Default.DefaultLanguage);

            InitializeComponent();            

            this.InitToolTip();
        }

        private void InitToolTip()
        {
            try
            {
                if (!bgwCheckURL.IsBusy)
                {
                    bgwCheckURL.RunWorkerAsync();
                }

                //tt.SetToolTip(pbAbout, MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_3));
                //tt.SetToolTip(pbLanguage, MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_4));
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        #endregion

        #region//启动按钮

        private void bProxy_Start_Click(object sender, EventArgs e)
        {
            Program.Mode = "Proxy";

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bProcess_Start_Click(object sender, EventArgs e)
        {
            Program.Mode = "Process";

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion

        #region//选择语言

        private void tsmiChinese_Click(object sender, EventArgs e)
        {
            this.LanguageChange("zh-CN");
        }

        private void tsmiEnglish_Click(object sender, EventArgs e)
        {
            this.LanguageChange("en-US");
        }

        private void LanguageChange(string SelectLanguage)
        {
            try
            {
                if (!Properties.Settings.Default.DefaultLanguage.Equals(SelectLanguage))
                {
                    Program.SaveDefaultLanguage(SelectLanguage);

                    Socket_Operation.ShowMessageBox(MultiLanguage.GetDefaultLanguage(MultiLanguage.MutiLan_12));

                    Application.Restart();
                    Process.GetCurrentProcess().Kill();
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        #endregion

        #region//关于

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            Process.Start(this.WebSiteURL);
        }

        #endregion

        #region//检测网站可访问性（异步）

        private void bgwCheckURL_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                e.Result = this.CheckWebSiteIsOK(Properties.Settings.Default.WPE64_URL);
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void bgwCheckURL_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            try
            {
                bool bWPE64_URL = (bool)e.Result;

                if (bWPE64_URL)
                {
                    this.WebSiteURL = Properties.Settings.Default.WPE64_URL;
                }
                else
                {
                    this.WebSiteURL = Properties.Settings.Default.WPE64_IP;
                }
            }
            catch (Exception ex)
            {
                Socket_Operation.DoLog(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private bool CheckWebSiteIsOK(string sURL)
        {
            bool bReturn = false;

            try
            {
                HttpWebRequest hwr = (HttpWebRequest)WebRequest.Create(sURL);
                HttpWebResponse resp = (HttpWebResponse)hwr.GetResponse();

                if (resp.StatusCode == HttpStatusCode.OK)
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
    }
}