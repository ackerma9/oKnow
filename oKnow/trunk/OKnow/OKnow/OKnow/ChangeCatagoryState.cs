using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OKnow
{
    /// <summary>
    /// Represent the state of the change category powerup
    /// </summary>
    public class ChangeCategoryState : NoOpGameState
    {
        /// <summary>
        /// Activates the change category powerup
        /// </summary>
        public override void Activate()
        {
            base.Activate();
            Game.ShowBoard();

            Game.GameBoard.Category = OKnow.Questions.CatagoryUtils.RandomCatagory(Game.GameBoard.Category);

            Game.GameState = new PlayerMoveState();
        }

        /// <summary>
        /// Name of the powerup
        /// </summary>
        public override String Name
        {
            get { return "Randomize Category"; }
        }
    }
}
