using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class ITHomeNews
    {
        public ITHomeNews()
        {

        }

        private string itemTitle;
        private string itemLink;
        private string itemDescription;
        private string itemPubdate;
        private string itemguid;

        public string ItemTitle
        {
            get
            {
                return itemTitle;
            }

            set
            {
                itemTitle = value;
            }
        }

        public string ItemLink
        {
            get
            {
                return itemLink;
            }

            set
            {
                itemLink = value;
            }
        }

        public string ItemDescription
        {
            get
            {
                return itemDescription;
            }

            set
            {
                itemDescription = value;
            }
        }

        public string ItemPubdate
        {
            get
            {
                return itemPubdate;
            }

            set
            {
                itemPubdate = value;
            }
        }

        public string Itemguid
        {
            get
            {
                return itemguid;
            }

            set
            {
                itemguid = value;
            }
        }
    }
}
