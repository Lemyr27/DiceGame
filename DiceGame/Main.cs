using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class Main : Form
    {
        Game game;
        Round round;

        public Main()
        {
            InitializeComponent();
        }

        private void selectTab(TabPage tab)
        {
            tabControl.SelectedTab = tab;
        }

        private void paramsButton_Click(object sender, EventArgs e)
        {
            selectTab(paramsPage);
        }

        // Списать фишки
        private void startGameButton_Click(object sender, EventArgs e)
        {
            int numberOfPlayers = (int)numberOfPlayersUpDown.Value;
            int chipsForOnePlayer = (int)chipsUpDown.Value;
            int minNumToPass = (int)minNumToPassUpDown.Value;
            game = new Game(numberOfPlayers, chipsForOnePlayer, minNumToPass);
            Player player = game.playersList[0];
            game.createRound(player);
            round = game.roundsList.Last();

            uiUpdate(player);
            selectTab(gamePage);
        }

        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            Player player = round.currentPlayer;
            Roll roll = player.rollDice();
            round.rollsList.Add(roll);
            rollPassCheck();
            scoreLabel.Text = $"{getPlayerScore(player, round)}";
        }

        private void rollPassCheck()
        {
            int playerValue = getPlayerScore(round.currentPlayer, round);
            rollDiceButton.Enabled = playerValue <= 21;
            passButton.Enabled = playerValue >= game.minNumToPass;
        }

        private int getPlayerScore(Player player, Round round)
        {
            int result = 0;
            foreach (Roll roll in round.rollsList)
            {
                if (roll.playerValue.Item1 == player)
                {
                    result += roll.playerValue.Item2;
                }
            }
            return result;
        }

        // Списать фишки
        // проверка для фишек(убирать игрока без фишек)
        // отобразить фишки игрока во время игры
        // начало нового раунда - добавить метод(возможно первого игрока тащить в конец списка)
        // проверка для конца игры(все 0 кроме одного), Экран победителя всей игры
        // новая игра полное обнуление
        private void passButton_Click(object sender, EventArgs e)
        {
            if (round.currentPlayer.id != game.playersList.Last().id)
            {
                Player player = round.currentPlayer.makePass(game);
                uiUpdate(player);
                return;
            }
            
            List<Player> winners = getWinnersList(round);
            foreach (Player winner in winners)
            {
                winnersListBox.Items.Add($"Игрок {winner.id}: {getPlayerScore(winner, round)}");
            }
            selectTab(winnersPage);
        }

        private List<Player> getWinnersList(Round round)
        {
            List<Player> winners = new List<Player> { };
            Dictionary<Player, int> scores = new Dictionary<Player, int> { };
            foreach (Player player in game.playersList)
            {
                scores.Add(player, getPlayerScore(player, round));
            }
            var values = scores
                .Where(pair => pair.Value <= 21)
                .GroupBy(pair => pair.Value)
                .OrderByDescending(group => group.Key)
                .First();

            foreach (var score in values)
            {
                winners.Add(score.Key);
            }
            return winners;
        }

        private void uiUpdate(Player player)
        {
            idLabel.Text = $"{player.id}";
            scoreLabel.Text = "0";
            rollDiceButton.Enabled = true;
            passButton.Enabled = false;
        }
    }
}
