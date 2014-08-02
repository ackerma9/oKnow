using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OKnow
{
    /// <summary>
    /// Describes the random position swap powerup state
    /// </summary>
    public class RandomPositionSwapState : NoOpGameState
    {

        private static Random rand = new Random(new System.DateTime().Millisecond);

        /// <summary>
        /// When this powerup is activated, swap current player with a randomly selected different player and then change the turn
        /// </summary>
        public override void Activate()
        {
            base.Activate();
            Game.ShowBoard();

            if (Game.GameBoard.Players.Count > 1)
            {
                Player other = Game.GameBoard.CurrentPlayer;
                while (other == Game.GameBoard.CurrentPlayer)
                {
                    other = Game.GameBoard.Players[rand.Next(0, Game.GameBoard.Players.Count)];
                }

                OKnow.Pieces.AbstractTile swapTile = Game.GameBoard.CurrentPlayer.GetTile();
                Game.GameBoard.CurrentPlayer.SetTile(other.GetTile());
                other.SetTile(swapTile);
            }
            Game.GameState = new PlayerMoveState();

            Game.GameBoard.NextTurn();
        }

        /// <summary>
        /// Return the name of this powerup state
        /// </summary>
        public override string Name
        {
            get
            {
                return "Random Swap";
            }
        }

    }
}
