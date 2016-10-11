﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace DirectoriesAndFileIO
{
    [TestClass]
    public class TestReadFiles
    {
        string testDir = "";
        string fileA = "";
        string fileAContents = "";
        string fileB = "";
        string fileBContents = "";
        string subDir = "";
        string subDirFile = "";
        string subDirFileContents = "";

        [TestInitialize]
        public void Initialize()
        {
            // Create a test-directory with known files and directories
            testDir = "testDir";
            fileA = Path.Combine(testDir, "a.txt");
            fileB = Path.Combine(testDir, "b.txt");
            subDir = Path.Combine(testDir, "subDir");
            subDirFile = Path.Combine(subDir, subDirFile);
            fileAContents = "This is a.txt.";
            fileBContents = "This is b.txt. \n b nieuwe regel1 \n b nieuwe regel2 \n nieuwe regel3";
            subDirFileContents = "This is a file in a sub-directory.";

            Directory.CreateDirectory(testDir);
            File.WriteAllText(fileA, fileAContents);
            File.WriteAllText(fileB, fileBContents);
            Directory.CreateDirectory(subDir);
        }

        [TestCleanup]
        public void CleanUp()
        {
            if (Directory.Exists(testDir))
            {
                Directory.Delete(testDir, true);
            }
        }

        [TestMethod]
        public void TestFileReadAllText()
        {
            string txt = File.ReadAllText(fileA);
            Assert.AreEqual(fileAContents, txt);
        }

        [TestMethod]
        public void TestReadAllLines()
        {
            string[] lines = File.ReadAllLines(fileA);

            Assert.AreEqual(1, lines.Length);
            Assert.AreEqual(fileAContents, lines[0]);

            string[] lines2 = File.ReadAllLines(fileB);

            Assert.AreEqual(1, lines2.Length);
            Assert.AreEqual(fileBContents, lines2[0]);
        }

        [TestMethod]
        public void TestFileOpenText()
        {
            StreamReader s = File.OpenText(fileA);
            string txt = "";
            txt = s.ReadLine();


            Assert.AreEqual(fileAContents, txt);
            s.Close();
        }

        [TestMethod]
        public void TestStreamReader()
        {
            StreamReader s = new StreamReader(fileA);

            string txt = s.ReadToEnd();
            Assert.AreEqual(fileAContents, txt);

            s.Close();
        }

        [TestMethod]
        public void TestFileStream()
        {
            byte[] data = new byte[20];

            FileStream stream = File.OpenRead(fileA);
            int r = stream.Read(data, 0, 20);

            string txt = "";
            foreach(byte b in data)
            {
                if(b != 0)
                {
                    txt += (char)b;
                }
            }

            Assert.AreEqual(fileAContents.Length, r);
            Assert.AreEqual(fileAContents, txt);

            stream.Close();
        }

        [TestMethod]
        public void TestReadAllText()
        {
            StreamReader s = new StreamReader(fileB);
            string txt = s.ReadToEnd();
            Assert.IsTrue(txt.Contains("nieuwe regel1"));
            s.Close();
        }

    }
}
