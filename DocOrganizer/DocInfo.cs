using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using Aspose.Pdf;

namespace DocOrganizer
{
    public class DocInfo : IEqualityComparer<DocInfo>
    {
        public string sourceFile;
        public string sourcePath;
        public string extension;

        public DocInfo(string imagepath)
        {
            sourceFile = imagepath;
            sourcePath = Directory.GetParent(imagepath).FullName;
            Name = Path.GetFileName(imagepath);
            Day = DateTime.Today;
            extension = Path.GetExtension(imagepath);
        }

        public DateTime Day { get; set; }
        public string Name { get; set; }
        public string TargetDirectory { get; set; }

        public InfoType DocType;

        public string GetDestinationFile()
        {
            return Path.Combine(GetDestination(), Name);
        }
        public string GetDestination()
        {
            string typename = Enum.GetName(typeof(InfoType), DocType);
            return Path.Combine(TargetDirectory, typename);
        }

        public string SaveImage()
        {
            string destination = GetDestination();
            string destinationfile = GetDestinationFile();

            if (Directory.Exists(destination))
            {
                File.Copy(sourceFile, destinationfile);
                return destinationfile;
            }
            else
            {
                Directory.CreateDirectory(destination);
                File.Copy(sourceFile, destinationfile);
                return destinationfile;
            }
        }

        public bool Equals(DocInfo x, DocInfo y)
        {
            Boolean nameC = x.Name == y.Name;
            Boolean pathC = x.sourceFile == y.sourceFile;
            Boolean typeC = x.DocType == y.DocType;

            return nameC && pathC && typeC;
        }

        public int GetHashCode(DocInfo obj)
        {
            var donno = obj.Name + obj.sourceFile + obj.DocType;

            return donno.GetHashCode();
        }

        public bool CheckNameUnique()
        {
            string dest = GetDestinationFile();
            bool exists = File.Exists(dest);
            return !exists;
        }

        public void DeleteSourceFile()
        {
            File.Delete(sourceFile);
        }

        public string YearPath()
        {
            return Path.Combine(TargetDirectory, Day.Year.ToString());
        }

        public string MonthPath()
        {
            if (Day.Month < 10)
            {
                return Path.Combine(YearPath(), "0" + Day.Month.ToString());
            }
            else
            {
                return Path.Combine(YearPath(), Day.Month.ToString());
            }
        }

        public string DayPath()
        {
            if (Day.Day < 10)
            {
                return Path.Combine(MonthPath(), "0" + Day.Day.ToString());
            }
            else
            {
                return Path.Combine(MonthPath(), Day.Day.ToString());
            }
        }

        public string pdfConverter()
        {
            string dirpath = Path.Combine(sourcePath, "Temp");
            string filepath = Path.Combine(dirpath, "Temp.jpeg");

            if (!Directory.Exists(dirpath))
            {
                Directory.CreateDirectory(dirpath);
            }

            Aspose.Pdf.License licpdf = new Aspose.Pdf.License();
            Aspose.Pdf.Devices.JpegDevice dev = new Aspose.Pdf.Devices.JpegDevice();
            Document pdfdoc = new Aspose.Pdf.Document(sourceFile);
            dev.Process(pdfdoc.Pages[1], filepath);

            return filepath;
        }

        public string CreatePath()
        {
            string day = DayPath();
            TargetDirectory = day;
            if (!Directory.Exists(day))
            {
                Directory.CreateDirectory(day);
                return day;
            }
            return day;
        }

        public void EnsureUniqueName()
        {
            string oldname = Name;
            Name += extension;
            int index = 1;
            while (!CheckNameUnique())
            {
                Name = oldname + index + extension;
                index++;
            }
        }
    }
}
