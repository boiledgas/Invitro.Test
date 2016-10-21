using System.IO;
using System.Text;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Invitro.Task.Task2
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var test = new Test {Id = "1", Number = 1};
            const string Xml = @"﻿<?xml version=""1.0"" encoding=""utf-16""?>
<Test xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <Id>1</Id>
  <Number>1</Number>
</Test>";
            var serializer = new XmlSerializer(typeof(Test));
            using (var stream = new MemoryStream())
            using(var writer = new StreamWriter(stream, Encoding.Unicode))
            {
                serializer.Serialize(writer, test);
                var result = Encoding.Unicode.GetString(stream.ToArray());
                Assert.AreEqual(Xml, result);
            }
        }
    }
}
