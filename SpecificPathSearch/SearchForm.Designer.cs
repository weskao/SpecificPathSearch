using SpecificPathSearch.Properties;

namespace SpecificPathSearch
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.btnDir = new System.Windows.Forms.Button();
            this.lblSearchString = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.lblAll = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.listAll = new System.Windows.Forms.ListBox();
            this.listCondition = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msgLabel = new System.Windows.Forms.Label();
            this.copyBtn = new System.Windows.Forms.Button();
            this.conditionContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CutFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.CopyPathToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.conditionContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDir
            // 
            this.btnDir.Location = new System.Drawing.Point(81, 39);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(83, 33);
            this.btnDir.TabIndex = 0;
            this.btnDir.Text = "指定資料夾";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // lblSearchString
            // 
            this.lblSearchString.AutoSize = true;
            this.lblSearchString.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblSearchString.Location = new System.Drawing.Point(9, 89);
            this.lblSearchString.Name = "lblSearchString";
            this.lblSearchString.Size = new System.Drawing.Size(184, 16);
            this.lblSearchString.TabIndex = 1;
            this.lblSearchString.Text = "檔案或資料夾包含的文字";
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(195, 44);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(290, 22);
            this.txtDir.TabIndex = 2;
            this.txtDir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDir_KeyDown);
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(195, 84);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(290, 22);
            this.txtCondition.TabIndex = 3;
            this.txtCondition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCondition_KeyDown);
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblAll.Location = new System.Drawing.Point(44, 174);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(88, 16);
            this.lblAll.TabIndex = 4;
            this.lblAll.Text = "全部資料夾";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblCondition.Location = new System.Drawing.Point(274, 174);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(120, 16);
            this.lblCondition.TabIndex = 5;
            this.lblCondition.Text = "符合條件資料夾";
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExecute.Location = new System.Drawing.Point(18, 124);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(492, 33);
            this.btnExecute.TabIndex = 6;
            this.btnExecute.Text = "執行";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // listAll
            // 
            this.listAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listAll.Font = new System.Drawing.Font("新細明體", 9F);
            this.listAll.FormattingEnabled = true;
            this.listAll.ItemHeight = 12;
            this.listAll.Location = new System.Drawing.Point(47, 200);
            this.listAll.Name = "listAll";
            this.listAll.Size = new System.Drawing.Size(187, 208);
            this.listAll.TabIndex = 7;
            // 
            // listCondition
            // 
            this.listCondition.Font = new System.Drawing.Font("新細明體", 9F);
            this.listCondition.FormattingEnabled = true;
            this.listCondition.ItemHeight = 12;
            this.listCondition.Location = new System.Drawing.Point(277, 200);
            this.listCondition.Name = "listCondition";
            this.listCondition.Size = new System.Drawing.Size(187, 208);
            this.listCondition.TabIndex = 8;
            this.listCondition.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listCondition_DrawItem);
            this.listCondition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listCondition_KeyDown);
            this.listCondition.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listCondition_MouseDoubleClick);
            this.listCondition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listCondition_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(452, 426);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 30);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.msgLabel);
            this.groupBox1.Controls.Add(this.copyBtn);
            this.groupBox1.Location = new System.Drawing.Point(2, -9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 481);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Click += new System.EventHandler(this.groupBox1_Click);
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.msgLabel.ForeColor = System.Drawing.Color.Green;
            this.msgLabel.Location = new System.Drawing.Point(202, 438);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(152, 19);
            this.msgLabel.TabIndex = 2;
            this.msgLabel.Tag = "";
            this.msgLabel.Text = "show msg here";
            this.msgLabel.Visible = false;
            // 
            // copyBtn
            // 
            this.copyBtn.ForeColor = System.Drawing.Color.Transparent;
            this.copyBtn.Image = global::SpecificPathSearch.Properties.Resources.copy;
            this.copyBtn.Location = new System.Drawing.Point(488, 38);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(40, 40);
            this.copyBtn.TabIndex = 1;
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // conditionContextMenu
            // 
            this.conditionContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CutFileToolStripMenuItem,
            this.CopyFileToolStripMenuItem1,
            this.DelFileToolStripMenuItem,
            this.toolStripMenuItem2,
            this.CopyPathToolStripMenuItem2});
            this.conditionContextMenu.Name = "contextMenuStrip1";
            this.conditionContextMenu.Size = new System.Drawing.Size(123, 98);
            // 
            // CutFileToolStripMenuItem
            // 
            this.CutFileToolStripMenuItem.Name = "CutFileToolStripMenuItem";
            this.CutFileToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.CutFileToolStripMenuItem.Text = "剪下";
            this.CutFileToolStripMenuItem.Click += new System.EventHandler(this.CutFileToolStripMenuItem_Click);
            // 
            // CopyFileToolStripMenuItem1
            // 
            this.CopyFileToolStripMenuItem1.Name = "CopyFileToolStripMenuItem1";
            this.CopyFileToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.CopyFileToolStripMenuItem1.Text = "複製";
            this.CopyFileToolStripMenuItem1.Click += new System.EventHandler(this.CopyFileToolStripMenuItem_Click);
            // 
            // DelFileToolStripMenuItem
            // 
            this.DelFileToolStripMenuItem.Name = "DelFileToolStripMenuItem";
            this.DelFileToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.DelFileToolStripMenuItem.Text = "刪除";
            this.DelFileToolStripMenuItem.Click += new System.EventHandler(this.DelFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(119, 6);
            // 
            // CopyPathToolStripMenuItem2
            // 
            this.CopyPathToolStripMenuItem2.Name = "CopyPathToolStripMenuItem2";
            this.CopyPathToolStripMenuItem2.Size = new System.Drawing.Size(122, 22);
            this.CopyPathToolStripMenuItem2.Text = "複製路徑";
            this.CopyPathToolStripMenuItem2.Click += new System.EventHandler(this.CopyPathToolStripMenuItem_Click);
            // 
            // profilePic
            // 
            this.profilePic.Image = global::SpecificPathSearch.Properties.Resources.ebook;
            this.profilePic.InitialImage = null;
            this.profilePic.Location = new System.Drawing.Point(2, 13);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(73, 69);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 10;
            this.profilePic.TabStop = false;
            this.profilePic.Click += new System.EventHandler(this.profilePic_Click);
            this.profilePic.MouseEnter += new System.EventHandler(this.profilePic_MouseEnter);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(537, 468);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.listCondition);
            this.Controls.Add(this.listAll);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.lblAll);
            this.Controls.Add(this.txtCondition);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.lblSearchString);
            this.Controls.Add(this.btnDir);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Specific Path Searcher";
            this.SizeChanged += new System.EventHandler(this.SearchForm_SizeChanged);
            this.Click += new System.EventHandler(this.SearchForm_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.conditionContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.Label lblSearchString;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.Label lblAll;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ListBox listAll;
        private System.Windows.Forms.ListBox listCondition;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip conditionContextMenu;
        private System.Windows.Forms.ToolStripMenuItem CopyFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CopyPathToolStripMenuItem2;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.ToolStripMenuItem CutFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem DelFileToolStripMenuItem;
    }
}

