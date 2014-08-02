using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace OKnow.UI
{
    public class TimerEvent : IOEvent
    {
        private double targetTimeSeconds;
        public TimerEvent(GameTime currentTime, double deltaSeconds)
        {
            targetTimeSeconds = currentTime.TotalGameTime.TotalSeconds + deltaSeconds;
        }

        public virtual Boolean HasOccured(IOState current, IOState previous)
        {
            return current.GameTime.TotalGameTime.TotalSeconds > targetTimeSeconds;
        }

        public override int GetHashCode()
        {
            return 1;
        }

        public double SecondsRemaining(GameTime gameTime)
        {
            return targetTimeSeconds - gameTime.TotalGameTime.TotalSeconds;
        }
    }
}
