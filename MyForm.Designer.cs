namespace WMP
{
    partial class MyForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PlayListBox = new System.Windows.Forms.ListBox();
            this.playlist_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.削除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.選択項目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.プロパティーToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新規作成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.URLを開くtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.上書き保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.名前を付けて保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.印刷ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.印刷プレビューToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ツールToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.カスタマイズToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.オプションToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.プロパティーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.内容ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.インデックスToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.検索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.バージョン情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowsMediaPlayer = new WMP.MyAxWindowsMediaPlayer();
            this.playlist_contextMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // PlayListBox
            // 
            this.PlayListBox.AllowDrop = true;
            this.PlayListBox.ContextMenuStrip = this.playlist_contextMenuStrip;
            this.PlayListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.PlayListBox.FormattingEnabled = true;
            this.PlayListBox.ItemHeight = 12;
            this.PlayListBox.Location = new System.Drawing.Point(418, 26);
            this.PlayListBox.Margin = new System.Windows.Forms.Padding(0);
            this.PlayListBox.Name = "PlayListBox";
            this.PlayListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.PlayListBox.Size = new System.Drawing.Size(196, 376);
            this.PlayListBox.TabIndex = 10;
            this.PlayListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PlayListBox_MouseDoubleClick);
            this.PlayListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.PlayListBox_DragDrop);
            this.PlayListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayListBox_MouseDown);
            this.PlayListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.PlayListBox_DragEnter);
            this.PlayListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayListBox_KeyDown);
            // 
            // playlist_contextMenuStrip
            // 
            this.playlist_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.削除ToolStripMenuItem,
            this.プロパティーToolStripMenuItem1});
            this.playlist_contextMenuStrip.Name = "playlist_contextMenuStrip";
            this.playlist_contextMenuStrip.Size = new System.Drawing.Size(149, 48);
            // 
            // 削除ToolStripMenuItem
            // 
            this.削除ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.選択項目ToolStripMenuItem});
            this.削除ToolStripMenuItem.Name = "削除ToolStripMenuItem";
            this.削除ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.削除ToolStripMenuItem.Text = "削除";
            // 
            // 選択項目ToolStripMenuItem
            // 
            this.選択項目ToolStripMenuItem.Name = "選択項目ToolStripMenuItem";
            this.選択項目ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.選択項目ToolStripMenuItem.Text = "選択項目";
            this.選択項目ToolStripMenuItem.Click += new System.EventHandler(this.clear_selected_item_click);
            // 
            // プロパティーToolStripMenuItem1
            // 
            this.プロパティーToolStripMenuItem1.Name = "プロパティーToolStripMenuItem1";
            this.プロパティーToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.プロパティーToolStripMenuItem1.Text = "プロパティー";
            this.プロパティーToolStripMenuItem1.Click += new System.EventHandler(this.プロパティーToolStripMenuItem1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(415, 26);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 387);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            this.splitter1.DoubleClick += new System.EventHandler(this.splitter1_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.編集ToolStripMenuItem,
            this.ツールToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 26);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規作成ToolStripMenuItem,
            this.URLを開くtoolStripMenuItem1,
            this.開くToolStripMenuItem,
            this.toolStripSeparator,
            this.上書き保存ToolStripMenuItem,
            this.名前を付けて保存ToolStripMenuItem,
            this.toolStripSeparator1,
            this.印刷ToolStripMenuItem,
            this.印刷プレビューToolStripMenuItem,
            this.toolStripSeparator2,
            this.終了ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 新規作成ToolStripMenuItem
            // 
            this.新規作成ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("新規作成ToolStripMenuItem.Image")));
            this.新規作成ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新規作成ToolStripMenuItem.Name = "新規作成ToolStripMenuItem";
            this.新規作成ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新規作成ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.新規作成ToolStripMenuItem.Text = "新規作成";
            this.新規作成ToolStripMenuItem.Click += new System.EventHandler(this.新規作成ToolStripMenuItem_Click);
            // 
            // URLを開くtoolStripMenuItem1
            // 
            this.URLを開くtoolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("URLを開くtoolStripMenuItem1.Image")));
            this.URLを開くtoolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.URLを開くtoolStripMenuItem1.Name = "URLを開くtoolStripMenuItem1";
            this.URLを開くtoolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.URLを開くtoolStripMenuItem1.Text = "URLを開く";
            this.URLを開くtoolStripMenuItem1.Click += new System.EventHandler(this.URLを開くtoolStripMenuItem1_Click);
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("開くToolStripMenuItem.Image")));
            this.開くToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.開くToolStripMenuItem.Text = "開く";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.開くToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(180, 6);
            // 
            // 上書き保存ToolStripMenuItem
            // 
            this.上書き保存ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("上書き保存ToolStripMenuItem.Image")));
            this.上書き保存ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.上書き保存ToolStripMenuItem.Name = "上書き保存ToolStripMenuItem";
            this.上書き保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.上書き保存ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.上書き保存ToolStripMenuItem.Text = "上書き保存";
            this.上書き保存ToolStripMenuItem.Visible = false;
            // 
            // 名前を付けて保存ToolStripMenuItem
            // 
            this.名前を付けて保存ToolStripMenuItem.Name = "名前を付けて保存ToolStripMenuItem";
            this.名前を付けて保存ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.名前を付けて保存ToolStripMenuItem.Text = "名前を付けて保存";
            this.名前を付けて保存ToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            this.toolStripSeparator1.Visible = false;
            // 
            // 印刷ToolStripMenuItem
            // 
            this.印刷ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("印刷ToolStripMenuItem.Image")));
            this.印刷ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.印刷ToolStripMenuItem.Name = "印刷ToolStripMenuItem";
            this.印刷ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.印刷ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.印刷ToolStripMenuItem.Text = "印刷";
            this.印刷ToolStripMenuItem.Visible = false;
            // 
            // 印刷プレビューToolStripMenuItem
            // 
            this.印刷プレビューToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("印刷プレビューToolStripMenuItem.Image")));
            this.印刷プレビューToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.印刷プレビューToolStripMenuItem.Name = "印刷プレビューToolStripMenuItem";
            this.印刷プレビューToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.印刷プレビューToolStripMenuItem.Text = "印刷プレビュー";
            this.印刷プレビューToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(180, 6);
            this.toolStripSeparator2.Visible = false;
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // 編集ToolStripMenuItem
            // 
            this.編集ToolStripMenuItem.Name = "編集ToolStripMenuItem";
            this.編集ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.編集ToolStripMenuItem.Text = "編集";
            this.編集ToolStripMenuItem.Visible = false;
            // 
            // ツールToolStripMenuItem
            // 
            this.ツールToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.カスタマイズToolStripMenuItem,
            this.オプションToolStripMenuItem,
            this.プロパティーToolStripMenuItem});
            this.ツールToolStripMenuItem.Name = "ツールToolStripMenuItem";
            this.ツールToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.ツールToolStripMenuItem.Text = "ツール";
            // 
            // カスタマイズToolStripMenuItem
            // 
            this.カスタマイズToolStripMenuItem.Name = "カスタマイズToolStripMenuItem";
            this.カスタマイズToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.カスタマイズToolStripMenuItem.Text = "カスタマイズ";
            // 
            // オプションToolStripMenuItem
            // 
            this.オプションToolStripMenuItem.Name = "オプションToolStripMenuItem";
            this.オプションToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.オプションToolStripMenuItem.Text = "オプション";
            // 
            // プロパティーToolStripMenuItem
            // 
            this.プロパティーToolStripMenuItem.Name = "プロパティーToolStripMenuItem";
            this.プロパティーToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.プロパティーToolStripMenuItem.Text = "プロパティ";
            this.プロパティーToolStripMenuItem.Click += new System.EventHandler(this.プロパティーToolStripMenuItem_Click);
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.内容ToolStripMenuItem,
            this.インデックスToolStripMenuItem,
            this.検索ToolStripMenuItem,
            this.toolStripSeparator5,
            this.バージョン情報ToolStripMenuItem});
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.ヘルプToolStripMenuItem.Text = "ヘルプ";
            this.ヘルプToolStripMenuItem.Visible = false;
            // 
            // 内容ToolStripMenuItem
            // 
            this.内容ToolStripMenuItem.Name = "内容ToolStripMenuItem";
            this.内容ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.内容ToolStripMenuItem.Text = "内容";
            // 
            // インデックスToolStripMenuItem
            // 
            this.インデックスToolStripMenuItem.Name = "インデックスToolStripMenuItem";
            this.インデックスToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.インデックスToolStripMenuItem.Text = "インデックス";
            // 
            // 検索ToolStripMenuItem
            // 
            this.検索ToolStripMenuItem.Name = "検索ToolStripMenuItem";
            this.検索ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.検索ToolStripMenuItem.Text = "検索";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(169, 6);
            // 
            // バージョン情報ToolStripMenuItem
            // 
            this.バージョン情報ToolStripMenuItem.Name = "バージョン情報ToolStripMenuItem";
            this.バージョン情報ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.バージョン情報ToolStripMenuItem.Text = "バージョン情報...";
            // 
            // WindowsMediaPlayer
            // 
            this.WindowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowsMediaPlayer.Enabled = true;
            this.WindowsMediaPlayer.Location = new System.Drawing.Point(0, 26);
            this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
            this.WindowsMediaPlayer.Size = new System.Drawing.Size(415, 387);
            this.WindowsMediaPlayer.TabIndex = 7;
            this.WindowsMediaPlayer.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.WindowsMediaPlayer_MediaChange);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 413);
            this.Controls.Add(this.WindowsMediaPlayer);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.PlayListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MyForm";
            this.Text = "WMP";
            this.playlist_contextMenuStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WMP.MyAxWindowsMediaPlayer WindowsMediaPlayer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox PlayListBox;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新規作成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem 上書き保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 名前を付けて保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 印刷ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 印刷プレビューToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ツールToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem カスタマイズToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem オプションToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 内容ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem インデックスToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 検索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip playlist_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 削除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 選択項目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem プロパティーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem プロパティーToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem URLを開くtoolStripMenuItem1;

    }
}

