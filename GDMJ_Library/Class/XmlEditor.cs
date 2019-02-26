using System;
using System.Collections;
using System.Xml;
using System.IO;

namespace GDMJ_Library
{
    public class XmlEditor
    {

        private String path;

        public XmlEditor(String path)
        {
            this.path = path;
            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }

        public void Erase()
        {
            File.Delete(path);
        }

        public void Recreate()
        {
            File.Delete(path);
            File.Create(path);
        }

        public void AddNewNode(ArrayList newNodeInfo)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement head = doc.DocumentElement;
            XmlElement newNode = doc.CreateElement(newNodeInfo[0].ToString());
            for (int i = 1; i < newNodeInfo.Count; i += 2)
            {
                XmlElement childNode = doc.CreateElement(newNodeInfo[i].ToString());
                XmlText childValue = doc.CreateTextNode(newNodeInfo[i].ToString());
                childNode.AppendChild(childValue);
                newNode.AppendChild(childNode);
            }
            head.AppendChild(newNode);
            doc.Save(path);
        }
    }
}
