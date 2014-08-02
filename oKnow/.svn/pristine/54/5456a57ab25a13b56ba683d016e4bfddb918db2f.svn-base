using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OKnow
{
    /// <summary>
    /// Describes the reset attempts powerup state
    /// </summary>
    public class ResetAttemptsState : NoOpGameState
    {
        /// <summary>
        /// When this powerup state is activated, reset the current player's attempts to 0
        /// </summary>
        public override void Activate()
        {
            base.Activate();
            Game.ShowBoard();
            Game.GameBoard.CurrentPlayer.attempt = 1;

            Game.GameState = new PlayerMoveState();
        }

        /// <summary>
        /// Return the name of this powerup state
        /// </summary>
        public override String Name
        {
            get { return "Reset Attempts"; }
        }
    }
}
