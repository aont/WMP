using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WMPLib;
using AxWMPLib;

namespace WMP
{
    public partial class MyForm : Form
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyForm(args));
        }

        public MyForm(string[] args)
        {
            InitializeComponent();

            AddToCurrentPlaylist(args);
            this.WindowsMediaPlayer.Ctlcontrols.play();
            this.WindowsMediaPlayer.settings.setMode("loop", true);
            //this.WindowsMediaPlayer.settings.setMode("shuffle", true);

        }

        private void AddToCurrentPlaylist(params string[] urls)
        {
            var currentPlaylist = this.WindowsMediaPlayer.currentPlaylist;


            if (urls == null)
                return;
            foreach (string url in urls)
            {
                try
                {
                    if (url == "" || url == null)
                        continue;
                    currentPlaylist.appendItem(
                          WindowsMediaPlayer.newMedia(url)
                          );
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }

            WindowsMediaPlayer_CurrentPlaylistChange();
        }

        private void 新規作成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowsMediaPlayer.currentPlaylist.clear();
            WindowsMediaPlayer_CurrentPlaylistChange();
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            AddToCurrentPlaylist(this.openFileDialog1.FileNames);
            this.WindowsMediaPlayer.Ctlcontrols.play();
        }



        void WindowsMediaPlayer_CurrentPlaylistChange()
        {
            ListBox PlayListBox = this.PlayListBox;
            int index = PlayListBox.SelectedIndex;
            this.PlayListBox.Items.Clear();
            IWMPPlaylist currentPlaylist = this.WindowsMediaPlayer.currentPlaylist;
            for (int i = 0; i < currentPlaylist.count; i++)
            {
                this.PlayListBox.Items.Add(
                    new MediaProperty(
                    currentPlaylist.get_Item(i)
                    )
                    );
            }
            if (index >= PlayListBox.Items.Count)
                PlayListBox.SelectedIndex = PlayListBox.Items.Count - 1;
            else
                PlayListBox.SelectedIndex = index;
        }

        private void splitter1_DoubleClick(object sender, EventArgs e)
        {
            this.PlayListBox.Visible = !this.PlayListBox.Visible;
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void PlayListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowsMediaPlayer.Ctlcontrols.playItem(
                (this.PlayListBox.SelectedItem as MediaProperty).Media
            );
        }

        private void PlayListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = this.PlayListBox.IndexFromPoint(e.Location);
                if (index != -1)
                {
                    this.PlayListBox.SelectedIndices.Clear();
                    this.PlayListBox.SelectedIndex = index;
                }
            }
        }

        private void clear_selected_item_click(object sender, EventArgs e)
        {
            IWMPPlaylist currentPlaylist = this.WindowsMediaPlayer.currentPlaylist;
            currentPlaylist.removeItem(
                (this.PlayListBox.SelectedItem as MediaProperty).Media
            );
        }

        private void プロパティーToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowsMediaPlayer.ShowPropertyPages();
        }

        private void プロパティーToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            (this.PlayListBox.SelectedItem as MediaProperty).ShowProperties();

        }

        private void PlayListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                IWMPPlaylist currentPlaylist = this.WindowsMediaPlayer.currentPlaylist;
                var selecteditems = this.PlayListBox.SelectedItems;
                foreach (MediaProperty item in selecteditems)
                {
                    currentPlaylist.removeItem(item.Media);
                }
                WindowsMediaPlayer_CurrentPlaylistChange();
            }
        }

        URLInputForm urlinputform = null;
        private void URLを開くtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            URLInputForm urlinputform = this.urlinputform;
            if (urlinputform == null)
            {
                urlinputform = this.urlinputform = new URLInputForm();
                urlinputform.Show();
                urlinputform.AddUrl += new URLInputForm.AddUrlEventHandler(urlinputform_AddUrl);
            }

            if (urlinputform.Visible == true)
            {
                urlinputform.Focus();
            }
            else
            {
                urlinputform.Show();
            }
        }

        void urlinputform_AddUrl(object sender, string[] urls)
        {
            AddToCurrentPlaylist(urls);
        }

        private void PlayListBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

        }

        private void PlayListBox_DragDrop(object sender, DragEventArgs e)
        {
            IDataObject e_Data = e.Data;
            AddToCurrentPlaylist(e_Data.GetData(DataFormats.FileDrop) as string[]);

            /*
            string mes = "";
            foreach (string p in e_Data.GetFormats(true))
            {
                mes += p + " , ";
            }
            MessageBox.Show(mes);
             */
        }


        protected override void OnResize(EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.WindowsMediaPlayer.fullScreen = true;
            }
            base.OnResize(e);
        }



        private void WindowsMediaPlayer_MediaChange(object sender, _WMPOCXEvents_MediaChangeEvent e)
        {
            WindowsMediaPlayer_CurrentPlaylistChange();
            foreach (MediaProperty mediaproperty in this.PlayListBox.Items)
            {
                if (this.WindowsMediaPlayer.currentMedia.get_isIdentical(mediaproperty.Media))
                {
                    this.PlayListBox.SelectedItems.Clear();
                    this.PlayListBox.SelectedItem = (mediaproperty);
                    break;
                }
            }
        }

        private void WindowsMediaPlayer_CurrentItemChange(object sender, _WMPOCXEvents_CurrentItemChangeEvent e)
        {

        }

    }
}
