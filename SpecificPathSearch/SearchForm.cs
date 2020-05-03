using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SpecificPathSearch.Properties;

namespace SpecificPathSearch
{
    public partial class SearchForm : Form
    {
        #region color
        /// <summary>
        /// 第一列的顏色
        /// </summary>
        public Color RowColor1 = Color.PaleGreen;
        /// <summary>
        /// 第二列的顏色
        /// </summary>
        public Color RowColor2 = Color.CornflowerBlue;

        /// <summary>
        /// 第一列的漸層色
        /// </summary>
        public Color RowGradualColor1 = Color.DarkKhaki;
        /// <summary>
        /// 第二列的漸層色
        /// </summary>
        public Color RowGradualColor2 = Color.DarkSlateBlue;

        // 要讓選擇的ListBox項目出現不一樣的顏色
        public Color SelectRowColor = Color.Yellow;


        #endregion
        private string title = "Information";
        private int cnt = 0;
        private int picSwtichCnt = 0;
        private int clickReachTime = 3;
        private bool picSwtichFlag = true;
        private string web = Web.EBook;
        private Font fontFormat = new Font("Segoe Print", 12.0f);
        private List<string> pathList;
        private const string lblAllDefalutText = "全部檔案or資料夾";
        private const string lblConditionDefalutText = "符合條件檔案or資料夾";
        private int cntAll = 0;
        private int cntCondition = 0;
        //private const string DefaultPath = @"C:\Users\user\Desktop";
        private static readonly string DefaultPath = Directory.GetCurrentDirectory();
        private const string DefaultSearchStr = "Cancer";
        private string copyPathSuccessMsg = "路徑複製成功!";
        private string copyFileSuccessMsg = "檔案複製成功!";
        private string fileNotExistMsg = "該檔案不存在";

        public SearchForm()
        {
            InitializeComponent();
            initUI();
            addComponents();
            setDefaultFocus();
            btnExecute_Click(null, null); // default to click this button
        }

        private void setDefaultFocus()
        {
            this.ActiveControl = txtCondition;
        }

        private void addComponents()
        {
            Control[] beAddComponents = { txtCondition, txtDir, btnExecute, listCondition, 
                                       listAll, profilePic, lblAll, lblCondition, 
                                       lblSearchString, btnExit, btnDir };
            for(int i = 0; i < beAddComponents.Length ;i++)
            {
                groupBox1.Controls.Add(beAddComponents[i]);
            }
        }

        private void initUI()
        {
            setTextBoxSingle(txtDir);
            setTextBoxSingle(txtCondition);
            txtDir.Text = DefaultPath;
            txtCondition.Text = DefaultSearchStr;
            groupBox1.Size = this.Size;
            HideMsgLabel();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.DoubleBuffered = true;  // 降低flicker，改善圖像閃爍的情形 
        }

        private void HideMsgLabel()
        {
            msgLabel.Visible = false;
        }

        private void setTextBoxSingle(TextBox textBox)
        {
            textBox.AutoSize = false;
            textBox.Height = 27;
            textBox.Font = fontFormat;
        }

        // 重點2：FolderBrowserDialog 使用
        private void btnDir_Click(object sender, EventArgs e)
        {
            // 使用者指定搜尋的資料夾
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.ShowNewFolderButton = false;
            FBD.Description = "請選擇資料夾";
            FBD.RootFolder = Environment.SpecialFolder.Desktop;

            if (FBD.ShowDialog() == DialogResult.OK) txtDir.Text = FBD.SelectedPath;
        }

        // 清除前一次搜尋結果
        private void clearPreviousSearchResult()
        {
            listAll.Items.Clear();
            listCondition.Items.Clear();

            cntAll = 0;
            cntCondition = 0;

            pathList = null; // release resource
        }

        private bool IsDirIsExist(string dir)
        {
            if (Directory.Exists(dir) == false)
            {
                string pathNotExistInfo = "你所指定的路徑不存在!";
                HideMsgLabel();
                MessageBox.Show(pathNotExistInfo, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // 重點3：Directory 和 Path 類別的使用
        private void btnExecute_Click(object sender, EventArgs e)
        {
            clearPreviousSearchResult();
            StartSearch();
        }

        private void StartSearch()
        {
            string dir = txtDir.Text;
            string condition = txtCondition.Text;

            // 檢查資料夾是否存在
            if (IsDirIsExist(dir))
            {
                // Directory.GetDirectories 回傳 string[] 
                listItems(dir, condition);
                lblShowResultInfo();
                HideMsgLabel();
                DrawListItems(listCondition);  // 啟動drawitem事件 將項目著色
            }
        }

        // 列出所有項目、指定項目
        private void listItems(string dirPath, string condition)
        {
            pathList = new List<string>();
            if (condition.Trim() == "") // condition 內沒輸入任何東西
            {
                foreach (string d in Directory.GetFileSystemEntries(dirPath))
                {
                    string fileName = Path.GetFileName(d);
                    listAll.Items.Add(fileName);
                    cntAll++;

                    cntCondition++;
                    pathList.Add(d); // 儲存路徑
                    listCondition.Items.Add(fileName);
                }
            }
            else
            {
                // foreach (string d in Directory.GetFiles(dir))
                foreach (string d in Directory.GetFileSystemEntries(dirPath))
                {
                    string fileName = Path.GetFileName(d);
                    // 此 list 列出全部的 dir
                    listAll.Items.Add(fileName);
                    cntAll++;

                    // 此 list 列出特定文字結尾資料夾
                    if (fileName != null)
                    {
                        // 有找到符合該搜尋條件的
                        if (fileName.IndexOf(condition, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            cntCondition++;
                            pathList.Add(d); // 儲存路徑
                            listCondition.Items.Add(fileName);
                        }
                    }
                }
            }
        }

        private void DrawListItems(ListBox listBox)
        {
            listBox.DrawMode = DrawMode.OwnerDrawFixed;  // 啟動drawitem事件
        }

        // label 顯示執行結果的相關資訊
        private void lblShowResultInfo()
        {
            lblAll.Text = string.Format("{0} (結果數: {1})", lblAllDefalutText, cntAll);
            lblCondition.Text = string.Format("{0}  (結果數: {1})", lblConditionDefalutText, cntCondition);
        }

#region// 判斷是否為folder 
        
        private bool IsFolder(string strPath)
        {
            if (Directory.Exists(strPath))
            {
                return true; // 此物件為 folder(資料夾)
            }
            return false;  // 此物件為 file(檔案)
        }
#endregion

        private bool IsFileOrDirectoryExists(string strPath)
        {
            bool isExist = Directory.Exists(strPath) || File.Exists(strPath);
            return isExist;
        }

        private void txtDir_KeyDown(object sender, KeyEventArgs e)
        {
            executeToRun(e);
        }

        private void txtCondition_KeyDown(object sender, KeyEventArgs e)
        {
            executeToRun(e);
        }

        private void executeToRun(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // enter按鍵
            {
                btnExecute_Click(null, null);
            }
        }


        private int GetSelectedItemIndex()
        {
            int index = listCondition.SelectedIndex;
            return index;
        }

        private void CopyFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = GetSelectedItemIndex();
            string filePath = GetFileOrDirPath(selectedIndex);
            bool isExist = IsFileOrDirectoryExists(filePath);
            if (isExist)
            {
                CopyFliesToClipboard(filePath);
                showMsgAtBottom(copyFileSuccessMsg);
            }
            else
            {
                ShowMsgBox(fileNotExistMsg);
            }

        }

        private void CopyPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = GetSelectedItemIndex();
            string filePath = GetFileOrDirPath(selectedIndex);
            CopyPathToClipboard(filePath);
            showMsgAtBottom(copyPathSuccessMsg);
        }

        private void showMsgAtBottom(string msg)
        {
            msgLabel.Text = msg;
            msgLabel.Visible = true;
        }

        private void CopyPathToClipboard(string path)
        {
            Clipboard.SetText(path);  //Clipboard.SetData(DataFormats.Text, path);
        }

        private void listCondition_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // 按下右鍵
            {
                // check if item is in codition list or not
                int index = GetSelectedItemIndex();
                bool isFoundMatchStr = (index != ListBox.NoMatches);
                if (isFoundMatchStr)
                {
                    ShowRightClickMenu(e);
                }
            }
        }

        private void listCondition_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = GetSelectedItemIndex();
            bool isFoundMatchStr = (index != ListBox.NoMatches);  // 是否找到該字串
            if (isFoundMatchStr)
            {
                string path = pathList[index];
                openFile(path);
            }
        }

        private void openFile(string filePath)
        {
            Process process = new Process();
            process.StartInfo.FileName = filePath;
            process.Start();
            process.Dispose(); // release resource
        }

        // 使用預設瀏覽器開啟網站
        private void openWebsite(string website)
        {
            //website = "http://www.google.com.tw/";
            string target = string.Format(@"{0}", website);
            // Process.Start("IExplore.exe", target); // 使用ie開啟該網站

            //當系統未安裝預設的程式來開啟相對應的資源的話，會出現例外錯誤
            try
            {
                Process.Start(target);
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                MessageBox.Show(ex.Message);
                HideMsgLabel();
            }
        }

        private void listCondition_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox list = (ListBox)sender;
            if (list.Items.Count <= 0)
                return;

            //定義框的大小
            Rectangle rec = new Rectangle(0, 0, list.Width, list.Height);

            //定義筆刷
            SolidBrush brushRow1 = new SolidBrush(this.RowColor1);
            SolidBrush brushRow2 = new SolidBrush(this.RowColor2);

            //選筆刷
            Brush brush;
                if (e.Index % 2 == 0)
                    brush = brushRow1;
                else
                    brush = brushRow2;
            //畫框
            e.Graphics.FillRectangle(brush, e.Bounds);
            bool selected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected) ? true : false;
            if (selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(this.SelectRowColor), e.Bounds);
            }
            //畫字
            e.Graphics.DrawString(list.Items[e.Index].ToString(), this.Font, Brushes.Black, e.Bounds);
            //畫焦點框
            e.DrawFocusRectangle();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void profilePic_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseArgs = (MouseEventArgs) e;
            if (mouseArgs.Button == MouseButtons.Right) // 滑鼠右鍵
            {
                string[] website = {Web.EBook, Web.MochiDad, Web.FB};
                Bitmap[] pic = { Resources.ebook, Resources.cat, Resources.dog};

                picSwtichCnt++;

                int index = picSwtichCnt % website.Length;
                web = website[index];
                profilePic.Image = pic[index];

                /*/
                if (picSwtichFlag)
                {
                    web = Web.FB;
                    profilePic.Image = pic[2];
                }
                else
                {
                    web = Web.MochiDad;
                    profilePic.Image = Resources.ebook;
                }
                picSwtichFlag = !picSwtichFlag;  // change this flag*/
            }
            else
            {
                openWebsite(web);
            }
        }

        private void profilePic_MouseEnter(object sender, EventArgs e)
        {
            profilePic.Cursor = Cursors.Hand;
        }

        private void groupBox1_Click(object sender, EventArgs e)
        {
            /*cnt++;
            // display a image
            if (cnt == clickReachTime)
            {
                //this.BackgroundImage = Resources._2015年;
                groupBox1.Hide();
                cnt = 0;
            }*/
        }

        private void SearchForm_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            groupBox1.Show();
        }

        private void SearchForm_SizeChanged(object sender, EventArgs e)
        {
            groupBox1.Size = this.Size;
        }

        private void listCondition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DelFile();
            }
        }

        private string GetFileOrDirPath(int selectedIndex)
        {
            string filePath = pathList[selectedIndex];
            return filePath;
        }


        private void DelFile()
        {
            int index = GetSelectedItemIndex();
            string filePath = pathList[index];
            bool isFoundMatchStr = (index != ListBox.NoMatches);  // 在列表上是否找到該字串
            bool isExist = IsFileOrDirectoryExists(filePath);  // check whether the file or directory is exist or not

            if (isFoundMatchStr && isExist)
            {
                RemoveFile(index);
            }
            else
            {
                ShowMsgBox(fileNotExistMsg);
            }
        }

        private void ShowMsgBox(string msg)
        {
            HideMsgLabel();
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void RemoveFileFromListAll(string fileName)
        {
            listAll.Items.Remove(fileName);
        }

        private void RemoveFileFromListCondition(int index)
        {
            listCondition.Items.RemoveAt(index);
            pathList.RemoveAt(index);
        }

        private void RemoveFile(int index)
        {
            string fileName = listCondition.SelectedItem.ToString();
            string filePath = pathList[index];
            string delFileSuccessMsg = "刪除檔案成功";

            if (IsSuccessDelete(filePath))
            {
                RemoveFileFromListAll(fileName);
                RemoveFileFromListCondition(index);

                showMsgAtBottom(delFileSuccessMsg);
            }
            else
            {
                ShowMsgBox("刪除檔案失敗! 該檔案可能正在使用中!");
            }
        }

        private bool IsSuccessDelete(string filePath)
        {
            try
            {
                if (IsFolder(filePath)) // directory
                {
                    DirectoryInfo di = new DirectoryInfo(filePath);
                    di.Delete(true); // Delete this directory and all subdirectories and files in it
                }
                else
                {
                    File.Delete(filePath);
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void ShowRightClickMenu(MouseEventArgs e)
        {
            conditionContextMenu.Show(listCondition, new Point(e.X, e.Y));
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            string path = txtDir.Text;
            CopyPathToClipboard(path);
            showMsgAtBottom(copyPathSuccessMsg);
        }

        private void CopyFliesToClipboard(string filePath)
        {
            StringCollection FileCollection = new StringCollection();
            FileCollection.Add(filePath);
            Clipboard.SetFileDropList(FileCollection);
        }

        private void CutFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cutFileSuccessMsg = "剪下檔案";
            int selectedIndex = GetSelectedItemIndex();
            string filePath = GetFileOrDirPath(selectedIndex);
            bool isExist = IsFileOrDirectoryExists(filePath);
            if (isExist)
            {
                CutFliesToClipboard(filePath);
                showMsgAtBottom(cutFileSuccessMsg);
            }
            else
            {
                ShowMsgBox(fileNotExistMsg);
            }
        }

        private void CutFliesToClipboard(string filePath)
        {
            byte[] moveEffect = {2, 0, 0, 0};
            MemoryStream dropEffect = new MemoryStream();
            dropEffect.Write(moveEffect, 0, moveEffect.Length);

            StringCollection filesToCut = new StringCollection{filePath};
            DataObject data = new DataObject("Preferred DropEffect", dropEffect);
            data.SetFileDropList(filesToCut);

            Clipboard.Clear();
            Clipboard.SetDataObject(data, true);
        }

        private void DelFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelFile();
        }
    }
}
