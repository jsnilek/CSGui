using NUnit.Framework;

namespace TestMyGui
{
    public class TestBookUtilities
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReadBook()
        {
            var bookPages = MyGui.BookUtilities.LoadBook("TestBook");
            Assert.AreEqual(bookPages[0].PageText, "Info");
            Assert.AreEqual(bookPages[1].PageText, "page1");
            Assert.AreEqual(bookPages[1].PageLinks.Count, 4);
            Assert.AreEqual(bookPages[1].PageLinks[0], 1);
        }

        [Test]
        public void WriteBook()
        {
            var testBookName = "AutoCreatedTestBook";
            var bookPages = MyGui.BookUtilities.LoadBook("TestBook");
            MyGui.BookUtilities.WriteBook(testBookName, bookPages);
            var TestbookPages = MyGui.BookUtilities.LoadBook(testBookName);
            Assert.AreEqual(bookPages[0].PageText, TestbookPages[0].PageText);
            Assert.AreEqual(bookPages[1].PageText, TestbookPages[1].PageText);
            Assert.AreEqual(bookPages[1].PageLinks.Count, TestbookPages[1].PageLinks.Count);
            Assert.AreEqual(bookPages[1].PageLinks[0], TestbookPages[1].PageLinks[0]);
        }

        [Test]
        public void ReadBook_Spells()
        {
            var testBookName = "AutoCreatedTestBookSpells";
            var bookPages = MyGui.BookUtilities.LoadBook("TestBookSpells");
            MyGui.BookUtilities.WriteBook(testBookName, bookPages);
            var TestbookPages = MyGui.BookUtilities.LoadBook(testBookName);
            Assert.AreEqual(bookPages[0].PageText, TestbookPages[0].PageText);
            Assert.IsNotNull(bookPages[0].PageSpells);
            Assert.AreEqual(bookPages[1].PageText, TestbookPages[1].PageText);
            Assert.AreEqual(bookPages[1].PageLinks.Count, TestbookPages[1].PageLinks.Count);
            Assert.AreEqual(bookPages[1].PageLinks[0], TestbookPages[1].PageLinks[0]);
        }

        [Test]
        public void ReadBook_Enemies()
        {
            var testBookName = "AutoCreatedTestBookEnemies";
            var bookPages = MyGui.BookUtilities.LoadBook("TestBookEnemies");
            MyGui.BookUtilities.WriteBook(testBookName, bookPages);
            var TestbookPages = MyGui.BookUtilities.LoadBook(testBookName);
            Assert.AreEqual(bookPages[0].PageText, TestbookPages[0].PageText);
            Assert.IsNotNull(bookPages[0].PageEnemies);
            Assert.AreEqual(bookPages[1].PageText, TestbookPages[1].PageText);
            Assert.AreEqual(bookPages[1].PageLinks.Count, TestbookPages[1].PageLinks.Count);
            Assert.AreEqual(bookPages[1].PageLinks[0], TestbookPages[1].PageLinks[0]);
        }
    }
}