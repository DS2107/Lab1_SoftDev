using Lab1_Stru_IVT_7;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lab1_Stru_IVT_7_V8.Tests
{
    [TestClass]
    public class StringFormatterTests
    {
            // Тестовый метод на пустую строку 
            [TestMethod]
            public void EmptyString()
            {
                StringFormatter stringFormatter = new StringFormatter();
                Assert.AreEqual("", stringFormatter.ShortFileString(""));
            }

            // Тестовый метод на строку null
            [TestMethod]
            [ExpectedException(typeof(NullReferenceException))]
            public void NullString()
            {
                StringFormatter stringFormatter = new StringFormatter();
                stringFormatter.ShortFileString(null);
            }

            // Получить имя файла и его расширение
            [TestMethod]
            public void GetFileName()
            {
                StringFormatter stringFormatter = new StringFormatter();
                Assert.AreEqual(@"Key.ka", stringFormatter.SelectShortName(@"D:\Key.ka"));
            }

            // Изменить расширение
            [TestMethod]
            public void ChangeExtension()
            {
                StringFormatter stringFormatter = new StringFormatter();
                Assert.AreEqual(@"Hello.tmp", stringFormatter.SelectExpansion(@"Hello.txt"));
            }

            // tmp на tmp
            [TestMethod]
            public void ChangeExtensionTMP()
            {
                StringFormatter stringFormatter = new StringFormatter();
                Assert.AreEqual(@"Hello.tmp", stringFormatter.SelectExpansion(@"Hello"));
            }

            [TestMethod]
            public void Change()
            {
                StringFormatter stringFormatter = new StringFormatter();
                StringAssert.Contains(@"Hello.tmp", stringFormatter.SelectExpansion(@".tmp"));
            }
            
            [TestMethod]
            public void Change1()
            {
                StringFormatter stringFormatter = new StringFormatter();
                StringAssert.EndsWith(@"Hello.tmp", stringFormatter.SelectExpansion(@".tmp"));
            }

            // большие буквы
            [TestMethod]
            public void GetUpperString()
            {
                StringFormatter stringFormatter = new StringFormatter();
                Assert.AreEqual(@"ЧИФИР.TMP", stringFormatter.UpperString(@"чифир.tmp"));
            }
    }
}
