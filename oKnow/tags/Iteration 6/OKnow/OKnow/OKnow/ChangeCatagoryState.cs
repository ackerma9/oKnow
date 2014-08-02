using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OKnow
{
    public class ChangeCategoryState : NoOpGameState
    {
        public override void Activate()
        {
            base.Activate();
            Game.ShowBoard();

            Game.GameBoard.Category = OKnow.Questions.CatagoryUtils.RandomCatagory(Game.GameBoard.Category);

            Game.GameState = new PlayerMoveState();
        }

        public override String Name
        {
            get { return "Randomize Category"; }
        }
    }
}
