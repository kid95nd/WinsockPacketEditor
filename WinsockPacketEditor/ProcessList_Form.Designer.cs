﻿
namespace WinsockPacketEditor
{
    partial class ProcessList_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessList_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bgwProcessList = new System.ComponentModel.BackgroundWorker();
            this.tlpProcessInfo = new System.Windows.Forms.TableLayoutPanel();
            this.dgvProcessList = new System.Windows.Forms.DataGridView();
            this.cICO = new System.Windows.Forms.DataGridViewImageColumn();
            this.cProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProcessID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpProcessInfoButton = new System.Windows.Forms.TableLayoutPanel();
            this.bSelected = new System.Windows.Forms.Button();
            this.bRefresh = new System.Windows.Forms.Button();
            this.bCreate = new System.Windows.Forms.Button();
            this.tlpProcessInfoSearch = new System.Windows.Forms.TableLayoutPanel();
            this.txtProcessSearch = new System.Windows.Forms.TextBox();
            this.pbProcessSearch = new System.Windows.Forms.PictureBox();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.tlpProcessInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessList)).BeginInit();
            this.tlpProcessInfoButton.SuspendLayout();
            this.tlpProcessInfoSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProcessSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // bgwProcessList
            // 
            this.bgwProcessList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwProcessList_DoWork);
            this.bgwProcessList.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwProcessList_RunWorkerCompleted);
            // 
            // tlpProcessInfo
            // 
            resources.ApplyResources(this.tlpProcessInfo, "tlpProcessInfo");
            this.tlpProcessInfo.Controls.Add(this.dgvProcessList, 0, 3);
            this.tlpProcessInfo.Controls.Add(this.tlpProcessInfoButton, 0, 6);
            this.tlpProcessInfo.Controls.Add(this.tlpProcessInfoSearch, 0, 1);
            this.tlpProcessInfo.Controls.Add(this.pbLoading, 0, 4);
            this.tlpProcessInfo.Name = "tlpProcessInfo";
            // 
            // dgvProcessList
            // 
            this.dgvProcessList.AllowUserToAddRows = false;
            this.dgvProcessList.AllowUserToDeleteRows = false;
            this.dgvProcessList.AllowUserToResizeColumns = false;
            this.dgvProcessList.AllowUserToResizeRows = false;
            this.dgvProcessList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProcessList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProcessList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProcessList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgvProcessList, "dgvProcessList");
            this.dgvProcessList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProcessList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cICO,
            this.cProcessName,
            this.cProcessID});
            this.dgvProcessList.EnableHeadersVisualStyles = false;
            this.dgvProcessList.MultiSelect = false;
            this.dgvProcessList.Name = "dgvProcessList";
            this.dgvProcessList.ReadOnly = true;
            this.dgvProcessList.RowHeadersVisible = false;
            this.dgvProcessList.RowTemplate.Height = 27;
            this.dgvProcessList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcessList.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcessList_CellMouseLeave);
            this.dgvProcessList.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProcessList_CellMouseMove);
            this.dgvProcessList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvProcessList_DataBindingComplete);
            // 
            // cICO
            // 
            this.cICO.DataPropertyName = "ICO";
            resources.ApplyResources(this.cICO, "cICO");
            this.cICO.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.cICO.Name = "cICO";
            this.cICO.ReadOnly = true;
            // 
            // cProcessName
            // 
            this.cProcessName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cProcessName.DataPropertyName = "PName";
            resources.ApplyResources(this.cProcessName, "cProcessName");
            this.cProcessName.Name = "cProcessName";
            this.cProcessName.ReadOnly = true;
            // 
            // cProcessID
            // 
            this.cProcessID.DataPropertyName = "PID";
            resources.ApplyResources(this.cProcessID, "cProcessID");
            this.cProcessID.Name = "cProcessID";
            this.cProcessID.ReadOnly = true;
            // 
            // tlpProcessInfoButton
            // 
            resources.ApplyResources(this.tlpProcessInfoButton, "tlpProcessInfoButton");
            this.tlpProcessInfoButton.Controls.Add(this.bSelected, 2, 0);
            this.tlpProcessInfoButton.Controls.Add(this.bRefresh, 1, 0);
            this.tlpProcessInfoButton.Controls.Add(this.bCreate, 0, 0);
            this.tlpProcessInfoButton.Name = "tlpProcessInfoButton";
            // 
            // bSelected
            // 
            resources.ApplyResources(this.bSelected, "bSelected");
            this.bSelected.Name = "bSelected";
            this.bSelected.UseVisualStyleBackColor = true;
            this.bSelected.Click += new System.EventHandler(this.bSelected_Click);
            // 
            // bRefresh
            // 
            resources.ApplyResources(this.bRefresh, "bRefresh");
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // bCreate
            // 
            resources.ApplyResources(this.bCreate, "bCreate");
            this.bCreate.Name = "bCreate";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // tlpProcessInfoSearch
            // 
            resources.ApplyResources(this.tlpProcessInfoSearch, "tlpProcessInfoSearch");
            this.tlpProcessInfoSearch.Controls.Add(this.txtProcessSearch, 1, 0);
            this.tlpProcessInfoSearch.Controls.Add(this.pbProcessSearch, 2, 0);
            this.tlpProcessInfoSearch.Name = "tlpProcessInfoSearch";
            // 
            // txtProcessSearch
            // 
            this.txtProcessSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtProcessSearch, "txtProcessSearch");
            this.txtProcessSearch.Name = "txtProcessSearch";
            this.txtProcessSearch.TextChanged += new System.EventHandler(this.txtProcessSearch_TextChanged);
            // 
            // pbProcessSearch
            // 
            resources.ApplyResources(this.pbProcessSearch, "pbProcessSearch");
            this.pbProcessSearch.Image = global::WinsockPacketEditor.Properties.Resources.Search;
            this.pbProcessSearch.Name = "pbProcessSearch";
            this.pbProcessSearch.TabStop = false;
            // 
            // pbLoading
            // 
            resources.ApplyResources(this.pbLoading, "pbLoading");
            this.pbLoading.Image = global::WinsockPacketEditor.Properties.Resources.loading;
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.TabStop = false;
            // 
            // ProcessList_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tlpProcessInfo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ProcessList_Form";
            this.Load += new System.EventHandler(this.ProcessList_Form_Load);
            this.tlpProcessInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessList)).EndInit();
            this.tlpProcessInfoButton.ResumeLayout(false);
            this.tlpProcessInfoSearch.ResumeLayout(false);
            this.tlpProcessInfoSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProcessSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker bgwProcessList;
        private System.Windows.Forms.TableLayoutPanel tlpProcessInfo;
        private System.Windows.Forms.DataGridView dgvProcessList;
        private System.Windows.Forms.TableLayoutPanel tlpProcessInfoButton;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.Button bSelected;
        private System.Windows.Forms.TableLayoutPanel tlpProcessInfoSearch;
        private System.Windows.Forms.TextBox txtProcessSearch;
        private System.Windows.Forms.PictureBox pbProcessSearch;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.DataGridViewImageColumn cICO;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProcessID;
    }
}