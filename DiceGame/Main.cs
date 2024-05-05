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
            game.createRound(player);
            round = game.roundsList.Last();
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

        // новая игра полное обнуление
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
            Dictionary<Player, int> scores = new Dictionary<Player, int> { };
            foreach (Player player in game.playersList)
            {
                scores.Add(player, getPlayerScore(player, round));
            }
            var values = scores
                .Where(pair => pair.Value <= 21)
                .GroupBy(pair => pair.Value)
                .OrderByDescending(group => group.Key);

            if (!values.Any()) return winners;

            var newValue = values.First();
            foreach (var score in newValue)
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

        // Выводится один и тот же победитель, потому что игроки удаляются из игры,
        // нужно реализовать переход хода без удаления игрока из списка
        private void statisticButton_Click(object sender, EventArgs e)
        {
            statisticListView.Items.Clear();
            foreach (Round round in game.roundsList)
            {
                statisticListView.Items.Add($"Раунд {round.roundNumber}, победители:");
                List<Player> winners = getWinnersList(round);
                foreach (Player winner in winners)
                {
                    statisticListView.Items.Add($"Игрок {winner.id}, получивший {getPlayerScore(winner, round)} очков") ;
                }
                statisticListView.Items.Add($"");
            }
            selectTab(statisticPage);
        }
    }
}
