using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        private void startGameButton_Click(object sender, EventArgs e)
        {
            int numberOfPlayers = (int)numberOfPlayersUpDown.Value;
            int chipsForOnePlayer = (int)chipsUpDown.Value;
            int minNumToPass = (int)minNumToPassUpDown.Value;
            game = new Game(numberOfPlayers, chipsForOnePlayer, minNumToPass);
            Player player = game.playersList[0];
            round = game.createRound(player);
            foreach (Player pl in game.playersList)
            {
                round.paymentPerRound(pl);
            }

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

        private void passButton_Click(object sender, EventArgs e)
        {
            if (round.currentPlayer != game.playersList.Last())
            {
                Player player = round.currentPlayer.makePass(game);
                uiUpdate(player);
                return;
            }
            
            List<Player> winners = getWinnersList(round);
            if (winners.Any())
            {
                winnersListBox.Items.Clear();
                foreach (Player winner in winners)
                {
                    winnersListBox.Items.Add($"Игрок {winner.id}: {getPlayerScore(winner, round)}");
                }
                giveChips(round);
            }
            else
            {
                winnersListBox.Items.Clear();
                winnersListBox.Items.Add($"Никто не выиграл");
            }
            selectTab(winnersPage);
        }

        private void giveChips(Round round)
        {
            var winners = getWinnersList(round);
            int len = winners.Count;
            int numChips = round.bankOfChips;
            int fullChips = numChips / len;
            foreach (Player player in winners)
            {
                player.chips += fullChips;
            }
            round.bankOfChips -= fullChips;
        }

        private List<Player> getWinnersList(Round round)
        {
            List<Player> winners = new List<Player> { };
            var rolls = round.rollsList;
            var grouped = rolls.GroupBy(r => r.playerValue.Item1)
                          .Select(g => new { g.Key, Sum = g.Sum(r => r.playerValue.Item2) })
                          .Where(g => g.Sum <= 21)
                          .OrderByDescending(g => g.Sum);

            if (!grouped.Any())
            {
                return winners;
            }

            var maxSum = grouped.First().Sum;
            var maxSumGroups = grouped.Where(g => g.Sum == maxSum);

            foreach (var group in maxSumGroups)
            {
                winners.Add(group.Key);
            }

            return winners;
        }

        private void uiUpdate(Player player)
        {
            idLabel.Text = $"{player.id}";
            scoreLabel.Text = "0";
            rollDiceButton.Enabled = true;
            passButton.Enabled = false;
            numChips.Text = $"{player.chips}";
            bankChips.Text = $"{round.bankOfChips}";
            roundNum.Text = $"{round.roundNumber}";
        }

        private void newRoundButton_Click(object sender, EventArgs e)
        {
            Player player = game.playersList.First();
            game.playersList.RemoveAt(0);
            game.playersList.Add(player);
            Player currentPlayer = game.playersList.First();
            round = game.createRound(currentPlayer);

            List<Player> losers = new List<Player> { };
            foreach (Player pl in game.playersList)
            {
                if (round.paymentPerRound(pl) == -1)
                {
                    loseListBox.Items.Add($"Игрок {pl.id}");
                    losers.Add(pl);
                }
            }

            foreach (Player pl in losers)
            {
                game.playersList.Remove(pl);
            }

            if (losers.Contains(currentPlayer))
            {
                round.currentPlayer = game.playersList.First();
            }

            if (game.playersList.Count == 1)
            {
                nameWinner.Text = $"Игрок {game.playersList.First().id}!";
                selectTab(gameWinnerPage);
                return;
            }

            uiUpdate(game.playersList.First());
            selectTab(gamePage);
        }

        private void statisticButton_Click(object sender, EventArgs e)
        {
            var view = statisticListView.Items;
            view.Clear();
            foreach (Round round in game.roundsList)
            {
                view.Add($"Раунд {round.roundNumber}, победители:");
                List<Player> winners = getWinnersList(round);
                if (!winners.Any())
                {
                    view.Add("Никто не одержал победу в этом раунде");
                }
                foreach (Player winner in winners)
                {
                    view.Add($"Игрок {winner.id}, получивший {getPlayerScore(winner, round)} очков");
                }
                view.Add($"");
            }
            RemoveLast(view, 3);
            view.Add("Победитель игры:");
            view.Add($"Игрок {round.currentPlayer.id}!");
            selectTab(statisticPage);
        }

        private static void RemoveLast(ListBox.ObjectCollection view, int count)
        {
            for (int i = 0; i < count; i++)
            {
                view.RemoveAt(view.Count - 1);
            }
        }
    }
}
