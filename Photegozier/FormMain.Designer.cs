﻿namespace Groupic
{
    partial class Groupic
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Groupic));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.gbOption = new System.Windows.Forms.GroupBox();
            this.chkSepertateRawFile = new System.Windows.Forms.CheckBox();
            this.chkAutoDeleteDoneItem = new System.Windows.Forms.CheckBox();
            this.chkCategoryByMonth = new System.Windows.Forms.CheckBox();
            this.chkUseDash = new System.Windows.Forms.CheckBox();
            this.lblPreviewDateFormat = new System.Windows.Forms.Label();
            this.chkDateFormat = new System.Windows.Forms.CheckBox();
            this.chkMakeRoot = new System.Windows.Forms.CheckBox();
            this.btnCategorizing = new System.Windows.Forms.Button();
            this.gbDelete = new System.Windows.Forms.GroupBox();
            this.btnDeleteDoneItem = new System.Windows.Forms.Button();
            this.btnDeleteSelectedFileList = new System.Windows.Forms.Button();
            this.btnDeleteAllFileList = new System.Windows.Forms.Button();
            this.fileListView = new System.Windows.Forms.ListView();
            this.columnHeaderNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIsDone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCreationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbOption.SuspendLayout();
            this.gbDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.gbOption);
            this.splitContainer1.Panel1.Controls.Add(this.btnCategorizing);
            this.splitContainer1.Panel1.Controls.Add(this.gbDelete);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.fileListView);
            this.splitContainer1.Size = new System.Drawing.Size(613, 594);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.TabIndex = 12;
            this.splitContainer1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripQuit,
            this.toolStripAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripQuit
            // 
            this.toolStripQuit.Name = "toolStripQuit";
            this.toolStripQuit.Size = new System.Drawing.Size(43, 20);
            this.toolStripQuit.Text = "종료";
            this.toolStripQuit.Click += new System.EventHandler(this.toolStripQuit_Click);
            // 
            // toolStripAbout
            // 
            this.toolStripAbout.BackColor = System.Drawing.Color.Transparent;
            this.toolStripAbout.Name = "toolStripAbout";
            this.toolStripAbout.Size = new System.Drawing.Size(95, 20);
            this.toolStripAbout.Text = "프로그램 정보";
            this.toolStripAbout.Click += new System.EventHandler(this.toolStripAbout_Click);
            // 
            // gbOption
            // 
            this.gbOption.Controls.Add(this.chkSepertateRawFile);
            this.gbOption.Controls.Add(this.chkAutoDeleteDoneItem);
            this.gbOption.Controls.Add(this.chkCategoryByMonth);
            this.gbOption.Controls.Add(this.chkUseDash);
            this.gbOption.Controls.Add(this.lblPreviewDateFormat);
            this.gbOption.Controls.Add(this.chkDateFormat);
            this.gbOption.Controls.Add(this.chkMakeRoot);
            this.gbOption.Location = new System.Drawing.Point(111, 30);
            this.gbOption.Name = "gbOption";
            this.gbOption.Size = new System.Drawing.Size(398, 129);
            this.gbOption.TabIndex = 0;
            this.gbOption.TabStop = false;
            this.gbOption.Text = "옵션";
            // 
            // chkSepertateRawFile
            // 
            this.chkSepertateRawFile.AutoSize = true;
            this.chkSepertateRawFile.Location = new System.Drawing.Point(17, 106);
            this.chkSepertateRawFile.Name = "chkSepertateRawFile";
            this.chkSepertateRawFile.Size = new System.Drawing.Size(216, 16);
            this.chkSepertateRawFile.TabIndex = 21;
            this.chkSepertateRawFile.Text = "RAW 파일을 하위 RAW 폴더에 저장";
            this.chkSepertateRawFile.UseVisualStyleBackColor = true;
            this.chkSepertateRawFile.CheckedChanged += new System.EventHandler(this.chkSepertateRawFile_CheckedChanged);
            // 
            // chkAutoDeleteDoneItem
            // 
            this.chkAutoDeleteDoneItem.AutoSize = true;
            this.chkAutoDeleteDoneItem.Location = new System.Drawing.Point(17, 84);
            this.chkAutoDeleteDoneItem.Name = "chkAutoDeleteDoneItem";
            this.chkAutoDeleteDoneItem.Size = new System.Drawing.Size(240, 16);
            this.chkAutoDeleteDoneItem.TabIndex = 6;
            this.chkAutoDeleteDoneItem.Text = "작업 후 완료된 항목 목록에서 자동 삭제";
            this.chkAutoDeleteDoneItem.UseVisualStyleBackColor = true;
            this.chkAutoDeleteDoneItem.CheckedChanged += new System.EventHandler(this.chkAutoDeleteDoneItem_CheckedChanged);
            // 
            // chkCategoryByMonth
            // 
            this.chkCategoryByMonth.AutoSize = true;
            this.chkCategoryByMonth.Location = new System.Drawing.Point(133, 42);
            this.chkCategoryByMonth.Name = "chkCategoryByMonth";
            this.chkCategoryByMonth.Size = new System.Drawing.Size(76, 16);
            this.chkCategoryByMonth.TabIndex = 4;
            this.chkCategoryByMonth.Text = "월별 분류";
            this.chkCategoryByMonth.UseVisualStyleBackColor = true;
            this.chkCategoryByMonth.CheckedChanged += new System.EventHandler(this.chkCategoryByMonth_CheckedChanged);
            // 
            // chkUseDash
            // 
            this.chkUseDash.AutoSize = true;
            this.chkUseDash.Location = new System.Drawing.Point(215, 42);
            this.chkUseDash.Name = "chkUseDash";
            this.chkUseDash.Size = new System.Drawing.Size(66, 16);
            this.chkUseDash.TabIndex = 5;
            this.chkUseDash.Text = "\"-\" 사용";
            this.chkUseDash.UseVisualStyleBackColor = true;
            this.chkUseDash.CheckedChanged += new System.EventHandler(this.chkUseDash_CheckedChanged);
            // 
            // lblPreviewDateFormat
            // 
            this.lblPreviewDateFormat.AutoSize = true;
            this.lblPreviewDateFormat.Location = new System.Drawing.Point(36, 63);
            this.lblPreviewDateFormat.Name = "lblPreviewDateFormat";
            this.lblPreviewDateFormat.Size = new System.Drawing.Size(133, 12);
            this.lblPreviewDateFormat.TabIndex = 20;
            this.lblPreviewDateFormat.Text = "날짜형식 미리보기 라벨";
            // 
            // chkDateFormat
            // 
            this.chkDateFormat.AutoSize = true;
            this.chkDateFormat.Location = new System.Drawing.Point(17, 42);
            this.chkDateFormat.Name = "chkDateFormat";
            this.chkDateFormat.Size = new System.Drawing.Size(110, 16);
            this.chkDateFormat.TabIndex = 3;
            this.chkDateFormat.Text = "4자리 연도 사용";
            this.chkDateFormat.UseVisualStyleBackColor = true;
            this.chkDateFormat.CheckedChanged += new System.EventHandler(this.chkDateFormat_CheckedChanged);
            // 
            // chkMakeRoot
            // 
            this.chkMakeRoot.AutoSize = true;
            this.chkMakeRoot.Location = new System.Drawing.Point(17, 20);
            this.chkMakeRoot.Name = "chkMakeRoot";
            this.chkMakeRoot.Size = new System.Drawing.Size(159, 16);
            this.chkMakeRoot.TabIndex = 2;
            this.chkMakeRoot.Text = "Category 폴더 안에 분류";
            this.chkMakeRoot.UseVisualStyleBackColor = true;
            this.chkMakeRoot.CheckedChanged += new System.EventHandler(this.chkMakeRoot_CheckedChanged);
            // 
            // btnCategorizing
            // 
            this.btnCategorizing.Location = new System.Drawing.Point(12, 42);
            this.btnCategorizing.Name = "btnCategorizing";
            this.btnCategorizing.Size = new System.Drawing.Size(89, 117);
            this.btnCategorizing.TabIndex = 1;
            this.btnCategorizing.Text = "분류시작";
            this.btnCategorizing.UseVisualStyleBackColor = true;
            this.btnCategorizing.Click += new System.EventHandler(this.btnCategorizing_Click);
            // 
            // gbDelete
            // 
            this.gbDelete.Controls.Add(this.btnDeleteDoneItem);
            this.gbDelete.Controls.Add(this.btnDeleteSelectedFileList);
            this.gbDelete.Controls.Add(this.btnDeleteAllFileList);
            this.gbDelete.Location = new System.Drawing.Point(515, 30);
            this.gbDelete.Name = "gbDelete";
            this.gbDelete.Size = new System.Drawing.Size(86, 130);
            this.gbDelete.TabIndex = 0;
            this.gbDelete.TabStop = false;
            this.gbDelete.Text = "삭제";
            // 
            // btnDeleteDoneItem
            // 
            this.btnDeleteDoneItem.Location = new System.Drawing.Point(5, 100);
            this.btnDeleteDoneItem.Name = "btnDeleteDoneItem";
            this.btnDeleteDoneItem.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDoneItem.TabIndex = 9;
            this.btnDeleteDoneItem.Text = "완료 삭제";
            this.btnDeleteDoneItem.UseVisualStyleBackColor = true;
            this.btnDeleteDoneItem.Click += new System.EventHandler(this.btnDeleteDoneItem_Click);
            // 
            // btnDeleteSelectedFileList
            // 
            this.btnDeleteSelectedFileList.Location = new System.Drawing.Point(5, 60);
            this.btnDeleteSelectedFileList.Name = "btnDeleteSelectedFileList";
            this.btnDeleteSelectedFileList.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSelectedFileList.TabIndex = 8;
            this.btnDeleteSelectedFileList.Text = "선택 삭제";
            this.btnDeleteSelectedFileList.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedFileList.Click += new System.EventHandler(this.btnDeleteSelectedFileList_Click);
            // 
            // btnDeleteAllFileList
            // 
            this.btnDeleteAllFileList.Location = new System.Drawing.Point(5, 20);
            this.btnDeleteAllFileList.Name = "btnDeleteAllFileList";
            this.btnDeleteAllFileList.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAllFileList.TabIndex = 7;
            this.btnDeleteAllFileList.Text = "전체 삭제";
            this.btnDeleteAllFileList.UseVisualStyleBackColor = true;
            this.btnDeleteAllFileList.Click += new System.EventHandler(this.btnDeleteAllFileList_Click);
            // 
            // fileListView
            // 
            this.fileListView.AllowColumnReorder = true;
            this.fileListView.AllowDrop = true;
            this.fileListView.CheckBoxes = true;
            this.fileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNo,
            this.columnHeaderIsDone,
            this.columnHeaderFilePath,
            this.columnHeaderCreationDate,
            this.columnHeaderSize});
            this.fileListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileListView.FullRowSelect = true;
            this.fileListView.GridLines = true;
            this.fileListView.HideSelection = false;
            this.fileListView.Location = new System.Drawing.Point(0, 0);
            this.fileListView.Name = "fileListView";
            this.fileListView.Size = new System.Drawing.Size(613, 420);
            this.fileListView.TabIndex = 11;
            this.fileListView.UseCompatibleStateImageBehavior = false;
            this.fileListView.View = System.Windows.Forms.View.Details;
            this.fileListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileListView_DragDrop);
            this.fileListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileListView_DragEnter);
            // 
            // columnHeaderNo
            // 
            this.columnHeaderNo.Text = "No";
            this.columnHeaderNo.Width = 43;
            // 
            // columnHeaderIsDone
            // 
            this.columnHeaderIsDone.Text = "완료";
            this.columnHeaderIsDone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderIsDone.Width = 40;
            // 
            // columnHeaderFilePath
            // 
            this.columnHeaderFilePath.Text = "이름";
            this.columnHeaderFilePath.Width = 290;
            // 
            // columnHeaderCreationDate
            // 
            this.columnHeaderCreationDate.Text = "생성 날짜";
            this.columnHeaderCreationDate.Width = 84;
            // 
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "크기";
            // 
            // Groupic
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(613, 594);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Groupic";
            this.Text = "Groupic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbOption.ResumeLayout(false);
            this.gbOption.PerformLayout();
            this.gbDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCategorizing;
        private System.Windows.Forms.GroupBox gbDelete;
        private System.Windows.Forms.Button btnDeleteSelectedFileList;
        private System.Windows.Forms.Button btnDeleteAllFileList;
        private System.Windows.Forms.ListView fileListView;
        private System.Windows.Forms.ColumnHeader columnHeaderNo;
        private System.Windows.Forms.ColumnHeader columnHeaderFilePath;
        private System.Windows.Forms.ColumnHeader columnHeaderCreationDate;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.GroupBox gbOption;
        private System.Windows.Forms.Label lblPreviewDateFormat;
        private System.Windows.Forms.CheckBox chkDateFormat;
        private System.Windows.Forms.CheckBox chkMakeRoot;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripAbout;
        private System.Windows.Forms.CheckBox chkUseDash;
        private System.Windows.Forms.CheckBox chkCategoryByMonth;
        private System.Windows.Forms.ColumnHeader columnHeaderIsDone;
        private System.Windows.Forms.CheckBox chkAutoDeleteDoneItem;
        private System.Windows.Forms.Button btnDeleteDoneItem;
        private System.Windows.Forms.CheckBox chkSepertateRawFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripQuit;
    }
}

