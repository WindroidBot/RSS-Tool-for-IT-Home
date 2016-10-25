using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class ITHomeHead
    {
        public ITHomeHead()
        {

        }
   
        private string channelTitle;
        private string channelDescription;
        private string channelLink;
        private string channelGenerator;
        private string channelLanguage;
        private string imageLink;
        private string imageUrl;
        private string imageTitle;

        public string ChannelTitle
        {
            get
            {
                return channelTitle;
            }

            set
            {
                channelTitle = value;
            }
        }

        public string ChannelDescription
        {
            get
            {
                return channelDescription;
            }

            set
            {
                channelDescription = value;
            }
        }

        public string ChannelLink
        {
            get
            {
                return channelLink;
            }

            set
            {
                channelLink = value;
            }
        }

        public string ChannelGenerator
        {
            get
            {
                return channelGenerator;
            }

            set
            {
                channelGenerator = value;
            }
        }

        public string ChannelLanguage
        {
            get
            {
                return channelLanguage;
            }

            set
            {
                channelLanguage = value;
            }
        }

        public string ImageLink
        {
            get
            {
                return imageLink;
            }

            set
            {
                imageLink = value;
            }
        }

        public string ImageUrl
        {
            get
            {
                return imageUrl;
            }

            set
            {
                imageUrl = value;
            }
        }

        public string ImageTitle
        {
            get
            {
                return imageTitle;
            }

            set
            {
                imageTitle = value;
            }
        }
        /*
private string ItemTitle;
private string ItemLink;
private string ItemDescription;
private string ItemPubdate;
private string Itemguid;
*/


    }
}
