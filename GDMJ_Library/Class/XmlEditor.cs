using System;
using System.Collections;
using System.Xml;

namespace GDMJ_Library.Class
{
    public class XmlEditor
    {

        private String path;

        public XmlEditor(String path)
        {
            this.path = path;
        }



        public void AddNewNode(ArrayList newNodeInfo)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement head = doc.DocumentElement;
            XmlElement newNode = doc.CreateElement(newNodeInfo[0].ToString());
            for (int i = 1; i < newNodeInfo.Count; i+=2)
            {
                XmlElement childNode = doc.CreateElement(newNodeInfo[i].ToString());
                XmlText childValue = doc.CreateTextNode(newNodeInfo[i + 1].ToString());
                childNode.AppendChild(childValue);
                newNode.AppendChild(childNode);
            }
            head.AppendChild(newNode);
            doc.Save(path);
        }
    }
}
