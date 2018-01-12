using System;
using System.IO;
using DocOrganizer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DocOrganizer.Tests
{
    [TestClass]
    public class DocInfoTest
    {
        private DocInfo doc = new DocInfo(Path.Combine(Environment.CurrentDirectory, "..\\..\\Images\\BlackCar.jpg"));
        private string env = Environment.CurrentDirectory;

        [TestMethod]
        public void LoadInfoTest()
        {
            string filename = "..\\..\\Images\\BlackCar.jpg";
            string path = Path.Combine(Environment.CurrentDirectory, filename);

            Assert.AreEqual(path, doc.sourceFile);
        }

        [TestMethod]
        public void InfoDateTest()
        {
            DateTime day = new DateTime(2018, 01, 04);
            doc.Day = day;

            Assert.AreEqual(doc.Day, day);
        }
        [TestMethod]
        public void InfoNameTest()
        {
            Assert.AreEqual(doc.Name, "BlackCar.jpg");
        }

        [TestMethod]
        public void InfoDirectoryTest()
        {
            doc.TargetDirectory = env;

            Assert.AreEqual(doc.TargetDirectory, env);
        }

        [TestMethod]
        public void InfoTypeTest()
        {
            doc = SetupForSavingTests();

            string imagepath = doc.SaveImage();

            Assert.IsTrue(Directory.Exists(doc.GetDestination()));
        }

        [TestMethod]
        public void InfoDestinationDictTest()
        {
            string dir = "c://temp";
            doc.TargetDirectory = env;
            doc.DocType = InfoType.Regular;


            //Assert.AreEqual("c://temp\\Regular", doc.GetDestination());
            //Assert.AreEqual("c://temp\\Regular\\BlackCar.jpg", doc.GetDestinationFile());
        }

        [TestMethod]
        public void InfoSaveTest()
        {
            doc = SetupForSavingTests();

            string imagepath = doc.SaveImage();

            Assert.IsTrue(File.Exists(imagepath));
        }



        [TestMethod]
        public void EqualityTest()
        {
            doc.TargetDirectory = env;
            doc.DocType = InfoType.Regular;

            DocInfo samedoc1 = new DocInfo(doc.sourceFile);
            samedoc1.TargetDirectory = env;
            samedoc1.DocType = InfoType.Regular;

            DocInfo samedoc2 = new DocInfo(samedoc1.sourceFile);
            samedoc2.TargetDirectory = samedoc1.TargetDirectory;
            samedoc2.DocType = samedoc1.DocType;

            DocInfo diffdoc = new DocInfo(samedoc1.sourceFile);
            diffdoc.TargetDirectory = samedoc1.TargetDirectory;
            diffdoc.DocType = InfoType.Reciept;

            Assert.IsTrue(samedoc1.Equals(samedoc1, samedoc2));
            Assert.IsFalse(samedoc1.Equals(doc, diffdoc));
        }

        [TestMethod]
        public void CheckNameUniqueTest()
        {
            SetupForSavingTests();

            doc.SaveImage();

            Assert.IsFalse(doc.CheckNameUnique());
        }


        [TestMethod]
        public void DeleteASourceTest()
        {
            doc = SetupForSavingTests();

            string docpath = doc.SaveImage();

            DocInfo newdoc = new DocInfo(docpath);

            newdoc.DeleteSourceFile();

            Assert.IsFalse(File.Exists(docpath));
        }

        [TestMethod]
        public void DeleteDirectory()
        {
            doc = SetupForSavingTests();

            string docpath = doc.SaveImage();

            DocInfo newdoc = new DocInfo(docpath);

            newdoc.DeleteSourceFile();

            Assert.IsFalse(File.Exists(docpath));
        }

        [TestMethod]
        public void CreateDirectoryChainTest()
        {
            doc = SetupForSavingTests();

            string yearpath = doc.YearPath();
            string monthpath = doc.MonthPath();
            string daypath = doc.DayPath();


            string docpath = doc.CreatePath();


            Assert.IsTrue(Directory.Exists(yearpath));
            Assert.IsTrue(Directory.Exists(monthpath));
            Assert.IsTrue(Directory.Exists(daypath));
        }

        private DocInfo SetupForSavingTests()
        {
            doc.TargetDirectory = env;
            doc.DocType = InfoType.Regular;

            if (File.Exists(doc.GetDestinationFile()))
            {
                File.Delete(doc.GetDestinationFile());
            }
            if (Directory.Exists(doc.GetDestinationFile()))
            {
                Directory.Delete(doc.GetDestination());
            }

            string yearpath = doc.YearPath();
            string monthpath = doc.MonthPath();
            string daypath = doc.DayPath();

            if (Directory.Exists(daypath))
            {
                Directory.Delete(daypath);
                Directory.Delete(monthpath);
                Directory.Delete(yearpath);
            }

            return doc;
        }
    }
}
