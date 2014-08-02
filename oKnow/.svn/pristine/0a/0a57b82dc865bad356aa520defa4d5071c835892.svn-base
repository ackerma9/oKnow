using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OKnow
{
    public class ResetAttemptsState : NoOpGameState
    {
        public override void Activate()
        {
            base.Activate();
            Game.ShowBoard();
            Game.GameBoard.CurrentPlayer.attempt = 1;

            Game.GameState = new PlayerMoveState();
        }

        public override String Name
        {
            get { return "Reset Attempts"; }
        }
    }
}
