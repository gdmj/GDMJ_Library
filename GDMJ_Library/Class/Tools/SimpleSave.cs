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
        XElement root;

        const string xml_dir = "Data\\";
        const string xml_name = "SimpleSave.xml";

        public SimpleSave()
        {
            if (!File.Exists(xml_dir + xml_name))
            {
                Directory.CreateDirectory("Data");

                xDoc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                                     new XElement("head"));
                root = xDoc.Element("head");
                xDoc.Root.Add(new XElement("Vars"),
                              new XElement("Arrays"));

                Save();

                /*XmlTextWriter textWritter = new XmlTextWriter(xml_dir + xml_name, Encoding.UTF8);

                textWritter.WriteStartDocument();

                textWritter.WriteStartElement("head");

                textWritter.WriteEndElement();

                textWritter.Close();*/

            }



            xDoc = XDocument.Load(xml_dir + xml_name);
            root = xDoc.Element("head");

        }

        public void AddVar(string name, string var)
        {
            bool found = false;

            foreach (XElement el in xDoc.Root.Elements("Vars"))
            {

                if (el.Name == name)
                {
                    found = true;
                    break;
                }
                else
                {
                    found = false;
                }
            }
            if (found == false)
            {
                xDoc.Root.Element("Vars").Add(new XElement(name));
            }
            xDoc.Root.Element("Vars").Element(name).Value = var;
            Save();
        }

        public string ReturnVar(string name)
        {
            return xDoc.Root.Element("Vars").Element(name).Value;
        }

        public void Save()
        {
            xDoc.Save(xml_dir + xml_name);
            //xDoc.Save(Path.Combine(Environment.CurrentDirectory + "\\" + xml_dir + xml_name));
        }

        public class NewArray : SimpleSave
        {
            string ArrayName;

            public NewArray(string name)
            {
                ArrayName = name;

                foreach (XElement el in xDoc.Root.Elements("Arrays"))
                {
                    if (el.Name == name)
                    {
                        el.Remove();
                    }
                }
                xDoc.Root.Element("Arrays").Add(new XElement(name));
                Save();
            }

            public void AddVar(string var)
            {
                xDoc.Root.Element("Arrays").Element(ArrayName).Add(new XElement("var", var));
                Save();
            }

            public void AddVar(int var)
            {
                xDoc.Root.Element("Arrays").Element(ArrayName).Add(new XElement("var", var.ToString()));
                Save();
            }

            public void AddArray(string[] array)
            {
                for (int i = 0; i == array.Count(); i += 1)
                {
                    xDoc.Root.Element("Arrays").Element(ArrayName).Add(new XElement("var", array[i]));
                }
                Save();
            }

            public void AddArray(ArrayList array)
            {
                for (int i = 0; i <= array.Count-1; i += 1)
                {
                    xDoc.Root.Element("Arrays").Element(ArrayName).Add(new XElement("var", array[i]));
                }
                Save();
            }

            public ArrayList ReturnArray()
            {
                ArrayList AL = new ArrayList();
                foreach (XElement el in xDoc.Root.Element("Arrays").Elements(ArrayName))
                {
                    AL.Add(el.Value.ToString());
                }

                return AL;
            }

            public string ReturnVar(int id)
            {
                ArrayList AL = new ArrayList();
                foreach (XElement el in xDoc.Root.Element("Arrays").Elements(ArrayName))
                {
                    AL.Add(el.Value.ToString());
                }
                
                if (id > AL.Count)
                {
                    Exception.New("Id > array size");
                }

                return AL[id].ToString();
            }
        }
    }
}
