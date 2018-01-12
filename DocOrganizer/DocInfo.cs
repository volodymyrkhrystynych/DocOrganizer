using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DocOrganizer
{
    public class DocInfo : IEqualityComparer<DocInfo>
    {
        public string sourceFile;
        public string sourcePath;
        private string extension;

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
            return Path.Combine(TargetDirectory, Day.Year.ToString(), Day.Month.ToString());
        }

        public string DayPath()
        {
            return Path.Combine(TargetDirectory, Day.Year.ToString(), Day.Month.ToString(), Day.Day.ToString());
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
