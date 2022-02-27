using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGui
{
    public partial class Form2 : Form
    {
        private List<Page> _pages { get; }
        private int _currentPage;
        public Form2(List<Page> pages, int page = 0)
        {
            InitializeComponent();
            _pages = pages;
            _currentPage = page;
            ShowPage(page);
        }

        private void ShowPage(int page = 0)
        {
            Page pageToEddit = _pages[page];
            PageText.Text = pageToEddit.PageText;
            PageToLoad.Text = page.ToString();
            Links.Text = pageToEddit.SerializePageLinks();
            Spells.Text = pageToEddit.SerializePageSpells().Split('=')[1];
            textBoxEnemies.Text = pageToEddit.SerializePageEnemies().Split('=')[1];
        }


        private void buttonLoad_Click(object sender, EventArgs e)
        {
            var newPageNumber = 0;
            try { newPageNumber = int.Parse(PageToLoad.Text); }
            catch (Exception)
            { }
            if (newPageNumber >= 0 || newPageNumber < _pages.Count)
            {
                ShowPage(int.Parse(PageToLoad.Text));
                _currentPage = newPageNumber;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _pages[_currentPage].PageText = PageText.Text;
            _pages[_currentPage].PageLinks = BookUtilities.ParseLinks(Links.Text);
            _pages[_currentPage].PageSpells = Spells.Text != string.Empty
                ? BookUtilities.ParseClass(Spells.Text, l => new Page.Spell(l)) : null;
            _pages[_currentPage].PageEnemies = textBoxEnemies.Text != string.Empty
                ? BookUtilities.ParseClass(textBoxEnemies.Text, l => new Enemy(l)) : null;
            BookUtilities.WriteBook(BookUtilities.GetBookPath(0), _pages);
        }

        private void LoadPrevButton_Click(object sender, EventArgs e)
        {
            var newPageNumber = _currentPage - 1;
            if (newPageNumber >= 0 || newPageNumber < _pages.Count)
            {
                ShowPage(newPageNumber);
                PageToLoad.Text = newPageNumber.ToString();
                _currentPage = newPageNumber;
            }
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            var newPageNumber = _currentPage + 1;
            if (newPageNumber >= 0 || newPageNumber < _pages.Count)
            {
                ShowPage(newPageNumber);
                PageToLoad.Text = newPageNumber.ToString();
                _currentPage = newPageNumber;
            }
        }
    }
}
