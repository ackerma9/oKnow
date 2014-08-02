using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace OKnow.UI
{
    /// <summary>
    /// Describes Time event
    /// </summary>
    public class TimerEvent : IOEvent
    {
        private double targetTimeSeconds;
        /// <summary>
        /// Constructs
        /// </summary>
        /// <param name="currentTime">current time</param>
        /// <param name="deltaSeconds">time until event occurs</param>
        public TimerEvent(GameTime currentTime, double deltaSeconds)
        {
            targetTimeSeconds = currentTime.TotalGameTime.TotalSeconds + deltaSeconds;
        }

        /// <summary>
        /// Returns true if the time runs out
        /// </summary>
        /// <param name="current">current IO state</param>
        /// <param name="previous">precious IO state</param>
        /// <returns>true if the time runs out</returns>
        public virtual Boolean HasOccured(IOState current, IOState previous)
        {
            return current.GameTime.TotalGameTime.TotalSeconds > targetTimeSeconds;
        }

        /// <summary>
        /// Super complex hash function.  0% collisions
        /// </summary>
        /// <returns>1</returns>
        public override int GetHashCode()
        {
            return 1;
        }

        /// <summary>
        /// Returns the number of seconds until the time goes off
        /// </summary>
        /// <param name="gameTime">current game time</param>
        /// <returns>the number of seconds until the time goes off</returns>
        public double SecondsRemaining(GameTime gameTime)
        {
            return targetTimeSeconds - gameTime.TotalGameTime.TotalSeconds;
        }
    }
}
