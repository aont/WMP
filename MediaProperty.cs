using System;
using System.Collections.Generic;
using System.Text;
using WMPLib;

namespace WMP
{
    public class MediaProperty
    {
        public IWMPMedia Media;

        public MediaProperty(IWMPMedia Media)
        {
            this.Media = Media;
        }

        public override string ToString()
        {
            return Media.name;
        }

        public string Name
        {
            get
            {
                return Media.name;
            }
            set
            {
                Media.name = value;
            }
        }
        public string URL
        {
            get
            {
                return Media.sourceURL;
            }
        }
        public string Author
        {
            get
            {
                return Media.getItemInfo("Author");
            }
            set
            {
                Media.setItemInfo("Author", value);
            }
        }
        public string Artist
        {
            get
            {
                return Media.getItemInfo("DisplayArtist");
            }
            set
            {
                Media.setItemInfo("DisplayArtist", value);
            }
        }
        public string Composer
        {
            get
            {
                return Media.getItemInfo("WM/Composer");
            }
            set
            {
                Media.setItemInfo("WM/Composer", value);
            }
        }
        public string Title
        {
            get
            {
                return Media.getItemInfo("Title");
            }
            set
            {
                Media.setItemInfo("Title", value);
            }
        }
        public string Album
        {
            get
            {
                return Media.getItemInfo("WM/AlbumTitle");
            }
            set
            {
                Media.setItemInfo("WM/AlbumTitle", value);
            }
        }


        PropertyForm mediaPropertyForm = null;
        internal void ShowProperties()
        {
            if (mediaPropertyForm == null)
            {
                mediaPropertyForm = new PropertyForm(this);
            }
            if (mediaPropertyForm.Visible == false)
            {
                mediaPropertyForm.Show();
            }
            else
            {
                mediaPropertyForm.Focus();
            }
        }
    }
}
