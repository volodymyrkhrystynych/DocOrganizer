using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Pdf;

namespace DocOrganizer
{
    public partial class MainForm : Form
    {
        private string SourcePath;
        private string DestinationPath;
        private LinkedList<DocInfo> DocArray;
        private LinkedListNode<DocInfo> currentselected;
        private Bitmap MyImage;

        public MainForm()
        {
            InitializeComponent();
            
            DestinationPath = System.IO.Path.Combine(Environment.GetFolderPath(
                            Environment.SpecialFolder.MyDoc‌​uments));

            textBoxOutputDir.Text = DestinationPath;
            LoadlistBoxTypes();
            listBoxTypes.SelectedIndex = 0;
        }

        public static string[] GetImagePathsList(string path)
        {
            List<string> result = new List<string>();

            string[] ImageExtentions = new string[] { ".bmp", ".emf", ".exif", ".gif", ".icon", ".jpeg", ".png", ".tiff", ".wmf", ".jpg", ".pdf" };

            string[] temp = Directory.GetFiles(path);

            foreach (string item in temp)
            {
                string ext = Path.GetExtension(item);
                if (ImageExtentions.Contains(ext)){
                    result.Add(item);
                }
            }      

            return result.ToArray();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        public static LinkedList<DocInfo> LoadInfo(string[] pathslist)
        {
            LinkedList<DocInfo> Result = new LinkedList<DocInfo>();

            foreach (string item in pathslist)
            {
                DocInfo newitem = new DocInfo(item);
                Result.AddLast(newitem);
            }

            return Result;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            DialogResult result = browser.ShowDialog();
            textBoxInputDir.Text = browser.SelectedPath;
            SourcePath = browser.SelectedPath;
            if (Directory.Exists(SourcePath))
            {
                DocArray = LoadInfo(GetImagePathsList(SourcePath));
                if (DocArray.Count > 0)
                {
                    currentselected = DocArray.First;
                    LoadInfo(currentselected.Value);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            DialogResult result = browser.ShowDialog();
            textBoxOutputDir.Text = browser.SelectedPath;
            DestinationPath = browser.SelectedPath;
        }

        private void LoadInfo(DocInfo info)
        {
            if (MyImage != null)
            {
                MyImage.Dispose();
            }
            pictureBoxDoc.SizeMode = PictureBoxSizeMode.StretchImage;

            if ((info.extension == ".pdf"))
            {
                MyImage = new Bitmap(info.pdfConverter());
            }
            else
            {
                MyImage = new Bitmap(info.sourceFile);;
            }
            pictureBoxDoc.Image = (System.Drawing.Image)MyImage;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            SelectNext();
        }

        private void SelectNext()
        {
            if (currentselected is null)
            {
                return;
            }
            if (!(currentselected.Next is null))
            {
                currentselected = currentselected.Next;
                LoadInfo(currentselected.Value);
            }
            else if (currentselected.List.Count > 0)
            {
                currentselected = currentselected.List.First;
                LoadInfo(currentselected.Value);
            }
        }

        private void buttonSaveAndNext_Click(object sender, EventArgs e)
        {
            var tobedeleted = currentselected;

            if (tobedeleted == null)
            {
                return;
            }

            DocInfo info = tobedeleted.Value;

            info.Day = monthCalendarSet.SelectionStart;
            info.Name = textBoxName.Text;
            info.DocType = (InfoType)Enum.Parse(typeof(InfoType), listBoxTypes.Items[listBoxTypes.SelectedIndex].ToString());
            info.TargetDirectory = textBoxOutputDir.Text;
            info.CreatePath();
            info.EnsureUniqueName();
            info.SaveImage();

            SelectNext();
        }

        private void LoadlistBoxTypes()
        {
            listBoxTypes.Items.Clear();
            foreach (string item in Enum.GetNames(typeof(InfoType)))
            {
                listBoxTypes.Items.Add(item);
            }   
        }

        private void LoadlistBoxDefaultNames(InfoType info)
        {
            switch (info)
            {
                case InfoType.Regular:
                    var type = typeof(RegularType);
                    LoadDefaultNames(type);
                    break;
                case InfoType.Reciept:
                    var type1 = typeof(RecieptType);
                    LoadDefaultNames(type1);
                    break;
                case InfoType.Homework:
                    var type2 = typeof(HomeworkType);
                    LoadDefaultNames(type2);
                    break;
                case InfoType.Answers:
                    var type3 = typeof(AnswersType);
                    LoadDefaultNames(type3);
                    break;
                case InfoType.Document:
                    var type4 = typeof(DocumentType);
                    LoadDefaultNames(type4);
                    break;
                case InfoType.Misc:
                    var type5 = typeof(MiscType);
                    LoadDefaultNames(type5);
                    break;
            }
        }

        private void LoadDefaultNames(Type E)
        {
            listBoxDefaultNames.Items.Clear();
            foreach (string item in Enum.GetNames(E))
            {
                listBoxDefaultNames.Items.Add(item);
            }
            listBoxDefaultNames.SelectedIndex = 0;
        }

        private void listBoxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTypes.SelectedIndex > -1)
            {
                InfoType selected = (InfoType)Enum.Parse(typeof(InfoType), listBoxTypes.Items[listBoxTypes.SelectedIndex].ToString());
                LoadlistBoxDefaultNames(selected);
            }
        }

        private void listBoxDefaultNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = listBoxDefaultNames.SelectedIndex;
            if (!(selected == -1))
            {
                textBoxName.Text = listBoxDefaultNames.Items[selected].ToString();
            }
        }
    }
}
