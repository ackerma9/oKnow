using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OKnow
{
    public class RandomPositionSwapState : NoOpGameState
    {

        private static Random rand = new Random(new System.DateTime().Millisecond);

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

                OKnow.Pieces.AbstractTile swapTile = Game.GameBoard.CurrentPlayer.getTile();
                Game.GameBoard.CurrentPlayer.setTile(other.getTile());
                other.setTile(swapTile);
            }
            Game.GameState = new PlayerMoveState();

            Game.GameBoard.NextTurn();
        }

        public override string Name
        {
            get
            {
                return "Random Swap";
            }
        }

    }
}
