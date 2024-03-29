﻿using System;
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
    public partial class MainWindow : Form
    {
        private int _bookSelected = 0;

        internal static void DisplayInLogin(int diceThrow)
        {
            throw new NotImplementedException();
        }

        private static readonly Game _game = Game.Instance;

        public MainWindow()
        {
            Player.StatsGenerated += LogToCombat;
            FightEnemy.FightEvent += LogToCombat;
            FightEnemy.AskEvent += AskPlayer;
            InitializeComponent();
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var page = _game.TurnToPage(int.Parse(button.Tag.ToString()));
            ProcessPage(page);
        }

        private void ProcessPage(Page page)
        {
            UpdateGameForm();
            if (page.Enemies != null)
            {

                    FightEnemy.FightEnemies(_game.GamePlayer,page.Enemies);
                
            }
            this.Update();
        }

        private void UpdateGameForm()
        {
            MainTextBox.Text = _game.GetCurrentPage().Text;
            PageLabel.Text = "Page: " + _game.CurrentPageNumber;
            ApLabel.Text = "AP: " + _game.GamePlayer?.Ap;
            MaxApLabel.Text = "Max AP: " + _game.GamePlayer?.MaxAp;
            StaminaLabel.Text = "Stamina: " + _game.GamePlayer?.Stamina;
            MaxStaminaLabel.Text = "Max Stamina: " + _game.GamePlayer?.MaxStamina;
            LuckLabel.Text = "Luck: " + _game.GamePlayer?.Luck;
            MaxLuckLabel.Text = "Max Luck: " + _game.GamePlayer?.MaxLuck;
            CoinLabel.Text = "Coins:" + _game.GamePlayer?.Coins;
            labelProviant.Text = "Proviant: " + _game.GamePlayer?.Proviant;
            SetLinksButtons();
            SetSpellButtons();
            this.Update();
        }

        private List<Button> GetBtnList()
        {
            return new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10 };
        }

        private void SetLinksButtons()
        {
            List<Button> btnList = GetBtnList();
            var pageLinks = _game.GetCurrentPage().Links;
            int i = 0;
            for (; i < pageLinks.Count; i++)
            {
                var btn = btnList[i];
                btn.Enabled = true;
                btn.Text = pageLinks[i].ToString();
                btn.Tag = pageLinks[i].ToString();
            }
            for (; i < btnList.Count; i++)
            {
                var btn = btnList[i];
                btn.Text = "";
                btn.Enabled = false;
            }
        }

        private void SetSpellButtons()
        {
            var btnList = new List<Button> { button6, button7, button8, button9, button10 };
            var pageSpells = _game.GetCurrentPage().Spells;
            foreach (var btn in btnList)
            {
                btn.Text = "";
                btn.Enabled = false;
            }

            if (pageSpells == null) return;

            for (int i = 0; i < pageSpells.Count; i++)
            {
                var btn = btnList[i];
                btn.Enabled = true;
                btn.Text = pageSpells[i].Name;
                btn.Tag = pageSpells[i].Page;
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _game.StartGame();
            UpdateGameForm();
        }

        public static Player.PlayerClass AskForClass()
        {
            DialogResult dialogResult = MessageBox.Show("For Mage press no", "For Warrior press yes", MessageBoxButtons.YesNo);
            var role = (dialogResult == DialogResult.Yes) ? Player.PlayerClass.Warrior : Player.PlayerClass.Mage;
            return role;
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new BookEditWindow(_game.Pages, _game.CurrentPageNumber)
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            frm.FormClosing += delegate { this.UpdateGameForm(); this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void shamutantiHillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialogResult1 = MessageBox.Show("For Mage press no", "For Warrior press yes", MessageBoxButtons.YesNo);
                var role = (dialogResult1 == DialogResult.Yes) ? Player.PlayerClass.Warrior : Player.PlayerClass.Mage;
                _bookSelected = 0;
                _game.LoadBook(_bookSelected);
                _game.StartGame(role);
            }
            else if (dialogResult == DialogResult.No)
            {
            }

        }

        public void LogToCombat(object sender, CombatLogEventArgs args)
        {
            textBoxCombatLog.AppendText(Environment.NewLine);
            textBoxCombatLog.AppendText(args.MessageToCombatLog.ToString());
        }

        private void AskPlayer(object sender, AskPlayerEventArgs args)
        {
            DialogResult dialogResult = MessageBox.Show(args.MessageToAsk, "?", MessageBoxButtons.YesNo);
            args.Answer = dialogResult == DialogResult.Yes;
        }

        private void goToPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string promptValue = Prompt.ShowDialog("Page", "write a nubmer");
            var page = _game.TurnToPage(int.Parse(promptValue.ToString()));
            ProcessPage(page);
        }

        internal static void DisplayInLog(int diceThrow)
        {
            throw new NotImplementedException();
        }
    }
}
