using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace DocOrganizer.Tests
{
    /// <summary>
    /// Summary description for MainFormTests
    /// </summary>
    [TestClass]
    public class MainFormTests
    {
        [TestMethod]
        public void LoadInfoPathsTest()
        {
            string filename = "..\\..\\Images";
            string path = Path.Combine(Environment.CurrentDirectory, filename);

            string[] pathslist = MainForm.GetImagePathsList(path);

            Assert.IsTrue(pathslist.Length == 6);
        }

        [TestMethod]
        public void LoadInfoListTest()
        {
            string filename = "..\\..\\Images";
            string path = Path.Combine(Environment.CurrentDirectory, filename);

            string[] pathslist = MainForm.GetImagePathsList(path);

            LinkedList<DocInfo> infolist = MainForm.LoadInfo(pathslist);

            Assert.IsTrue(infolist.Count == 6);
        }
    }
}