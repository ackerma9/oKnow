using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OKnow
{
    public static class PowerUpUtils
    {
        private static Random rand = new Random(new System.DateTime().Millisecond);
        private static Type[] powerUps = { typeof(SkipQuestionState), typeof(ChangeCategoryState), typeof(ResetAttemptsState)  , typeof(RandomPositionSwapState)};

        public static IGameState RandomPowerUp()
        {
            int i = rand.Next(0, powerUps.Length);
            Type[] emptyParamType = new Type[0];
            object[] emptyParam = new object[0];

            IGameState rtn = (IGameState)powerUps[i].GetConstructor(emptyParamType).Invoke(emptyParam);
            return rtn;
        }
    }
}
