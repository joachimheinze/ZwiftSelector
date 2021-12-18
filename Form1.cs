using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;


namespace ZwiftSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            XmlDocument doc = new XmlDocument();
            String xmlFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Zwift\prefs.xml";
            doc.Load(xmlFile);
            XmlNodeList nodeList;
            XmlNode root = doc.DocumentElement;
            XmlElement node = (XmlElement)doc.SelectSingleNode("//WORLD");
            if (node != null)
            {
                setWorld(node.InnerText);
            }



        } 

        private void setWorld (String wid)
        {
            switch (wid)
            {
                case "1":
                    aktWorld.Text = "Watopia";
                    break;
                case "2":
                    aktWorld.Text = "Richmond";
                    break;
                case "3":
                    aktWorld.Text = "London";
                    break;
                case "4":
                    aktWorld.Text = "New York";
                    break;
                case "5":
                    aktWorld.Text = "Insbruck";
                    break;
                case "7":
                    aktWorld.Text = "Yorkshire";
                    break;
                case "9":
                    aktWorld.Text = "Makuri Islands";
                    break;
                case "10":
                    aktWorld.Text = "France";
                    break;
                case "11":
                    aktWorld.Text = "Paris";
                    break;
                default:
                    aktWorld.Text = "Watopia";
                    break;
            }


        }

        private void Zwiftselection_SelectedIndexChanged(object sender, EventArgs e)
        { int selection = 0;
            switch (Zwiftselection.SelectedItem)
            {
                case "Watopia":
                    selection = 1;
                    break;
                case "Richmond":
                    selection = 2;
                    break;
                case "London":
                    selection = 3;
                    break;
                case "New York":
                    selection = 4;
                    break;
                case "Innsbruck":
                    selection = 5;
                    break;
                case "Yorkshire":
                    selection = 7;
                    break;
                case "Makuri Islands":
                    selection = 9;
                    break;
                case "France":
                    selection = 10;
                    break;
                case "Paris":
                    selection = 11;
                    break;
                default:
                    selection = 0;
                    break;
            }
            XmlDocument doc = new XmlDocument();
            String xmlFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Zwift\prefs.xml";
            doc.Load(xmlFile);
            XmlNodeList nodeList;
            XmlNode root = doc.DocumentElement;
            XmlElement node = (XmlElement)doc.SelectSingleNode("/ZWIFT/WORLD");
            if (node !=  null)
            {
                node.InnerText = selection.ToString();

            }
            else
            {
                XmlNode root1 = doc.DocumentElement;

                //Create a new node.
                XmlElement elem = doc.CreateElement("WORLD");
                elem.InnerText = selection.ToString();

                //Add the node to the document.
                root.InsertBefore(elem, root.FirstChild);

                //Console.WriteLine("Display the modified XML...");
                //doc.Save(Console.Out);
            }

            try
            {
                 doc.Save(xmlFile);
           }
            catch (UnauthorizedAccessException)
            {
                FileAttributes attr = (new FileInfo(xmlFile)).Attributes;
                Console.Write("UnAuthorizedAccessException: Unable to access file. ");
                if ((attr & FileAttributes.ReadOnly) > 0)
                    Console.Write("The file is read-only.");
                String xmlFile1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Zwift\prefs1.xml";
                doc.Save(xmlFile1);
                File.Delete(xmlFile);
                File.Copy(xmlFile1, xmlFile);


            }
            finally
            {
               setWorld(selection.ToString()   );
            }

        }
    }
}
