using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument testxml = new XmlDocument();
            testxml.Load(@"C:\Users\xxy\Desktop\test.xml");
            XmlNode rss = testxml.SelectSingleNode("rss");
            XmlNode channel = rss.SelectSingleNode("channel");

            ITHomeHead head = new ITHomeHead();
            XmlElement xe = (XmlElement)channel;
            head.ChannelDescription = xe.GetAttribute("description").ToString();
            

            Console.WriteLine("End");
            Console.Read();

            /*
            Console.WriteLine(headxml.ChannelDescription);
            Console.WriteLine(headxml.ChannelGenerator);
            Console.WriteLine(headxml.ChannelLanguage);
            Console.WriteLine(headxml.ChannelLink);
            Console.WriteLine(headxml.ChannelTitle);
            Console.ReadLine();
            */
        }
    }
}
