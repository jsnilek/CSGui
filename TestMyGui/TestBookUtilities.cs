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
            Assert.AreEqual(bookPages[0].Text, "Info");
            Assert.AreEqual(bookPages[1].Text, "page1");
            Assert.AreEqual(bookPages[1].Links.Count, 4);
            Assert.AreEqual(bookPages[1].Links[0], 1);
        }

        [Test]
        public void WriteBook()
        {
            var testBookName = "AutoCreatedTestBook";
            var bookPages = MyGui.BookUtilities.LoadBook("TestBook");
            MyGui.BookUtilities.WriteBook(testBookName, bookPages);
            var TestbookPages = MyGui.BookUtilities.LoadBook(testBookName);
            Assert.AreEqual(bookPages[0].Text, TestbookPages[0].Text);
            Assert.AreEqual(bookPages[1].Text, TestbookPages[1].Text);
            Assert.AreEqual(bookPages[1].Links.Count, TestbookPages[1].Links.Count);
            Assert.AreEqual(bookPages[1].Links[0], TestbookPages[1].Links[0]);
        }

        [Test]
        public void ReadBook_Spells()
        {
            var testBookName = "AutoCreatedTestBookSpells";
            var bookPages = MyGui.BookUtilities.LoadBook("TestBookSpells");
            MyGui.BookUtilities.WriteBook(testBookName, bookPages);
            var TestbookPages = MyGui.BookUtilities.LoadBook(testBookName);
            Assert.AreEqual(bookPages[0].Text, TestbookPages[0].Text);
            Assert.IsNotNull(bookPages[0].Spells);
            Assert.AreEqual(bookPages[1].Text, TestbookPages[1].Text);
            Assert.AreEqual(bookPages[1].Links.Count, TestbookPages[1].Links.Count);
            Assert.AreEqual(bookPages[1].Links[0], TestbookPages[1].Links[0]);
        }

        [Test]
        public void ReadBook_Enemies()
        {
            var testBookName = "AutoCreatedTestBookEnemies";
            var bookPages = MyGui.BookUtilities.LoadBook("TestBookEnemies");
            MyGui.BookUtilities.WriteBook(testBookName, bookPages);
            var TestbookPages = MyGui.BookUtilities.LoadBook(testBookName);
            Assert.AreEqual(bookPages[0].Text, TestbookPages[0].Text);
            Assert.IsNotNull(bookPages[0].Enemies);
            Assert.AreEqual(bookPages[1].Text, TestbookPages[1].Text);
            Assert.AreEqual(bookPages[1].Links.Count, TestbookPages[1].Links.Count);
            Assert.AreEqual(bookPages[1].Links[0], TestbookPages[1].Links[0]);
        }
    }
}