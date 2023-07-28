using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern.Template_Method_Pattern_1
{
    public class Chess : Game
    {
        public Chess(int numberOfPlayers) : base(numberOfPlayers)
        {
        }
        private int maxTurns = 10;
        private int turn = 1;
        protected override bool HaveWinner => turn == maxTurns;

        protected override int WinningPlayer => currentPlayer;

        protected override void Start()
        {
            Console.WriteLine($"starting a game of chess with {numberOfPlayers} players.");
        }

        protected override void TakeTurn()
        {
            Console.WriteLine($"Turn {turn++} taken by player {currentPlayer}.");
            currentPlayer = (currentPlayer + 1) % numberOfPlayers;
        }
    }
}
