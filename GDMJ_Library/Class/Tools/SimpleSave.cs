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
        static XmlDocument XDoc = new XmlDocument();
        
        static XmlElement Element;
        XmlElement xRoot;

        XDocument xDocument;

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
            XDoc.Load(xml_dir + xml_name);
            xRoot = XDoc.DocumentElement;


            xDocument = XDocument.Load(xml_dir + xml_name);
        }

        public void NewCell(string ElName)
        {
            Element = XDoc.CreateElement(ElName);
            xRoot.AppendChild(Element);
        }

        public void AddVar(string ElName, string name, string var)
        {
            XmlNodeList ElementX = xRoot.GetElementsByTagName(ElName);
            XmlElement VarElement = XDoc.CreateElement(name);
            XmlText VarText = XDoc.CreateTextNode(var);
            ElementX.Item(0).AppendChild(VarElement);
            VarElement.AppendChild(VarText);
            Save();
        }

        public void AddVar(string name, string var)
        {
            string ElName = "Default";
            XmlNodeList ElementX = xRoot.GetElementsByTagName(ElName);
            if (ElementX.Item(0) == null)
            {
                Element = XDoc.CreateElement(ElName);
                xRoot.AppendChild(Element);
            }
            XmlElement VarElement = XDoc.CreateElement(name);
            XmlText VarText = XDoc.CreateTextNode(var);
            ElementX.Item(0).AppendChild(VarElement);
            VarElement.AppendChild(VarText);
            Save();
        }

        public string ReadVar(string ElName, string name)
        {
            ArrayList List = new ArrayList();

            List.AddRange(xDocument.Element(ElName).Elements(name).ToArray());
            if (List.Count != 1)
            {
                
            }
            return List.IndexOf(List.Count - 1).ToString();
        }

        public void DelElement(string ElName)
        {
            XmlNode ElementDel = xRoot.GetAttributeNode(ElName);
            xRoot.RemoveChild(ElementDel);
            Save();
        }

        public void DelElement()
        {
            XmlNode ElementDel = xRoot.GetAttributeNode("Default");
            xRoot.RemoveChild(ElementDel);
            Save();
        }

        public void Save()
        {
            XDoc.Save(xml_dir + xml_name);
        }
    }
}
