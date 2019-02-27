using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace GDMJ_Library.Tools
{
    public class SimpleSave
    {
        XDocument xDoc = new XDocument();

        const string xml_dir = "Data\\";
        const string xml_name = "SimpleSave.xml";

        public SimpleSave()
        {
            if (!File.Exists(xml_dir + xml_name))
            {
                Directory.CreateDirectory("Data");
                XmlTextWriter textWritter = new XmlTextWriter(xml_dir + xml_name, Encoding.UTF8);

                textWritter.WriteStartDocument();

                textWritter.WriteStartElement("head");

                textWritter.WriteEndElement();

                textWritter.Close();

            }

            XDocument.Load(xml_dir + xml_name);
            
        }

        public void AddVar()
        {

        }
    }
}
