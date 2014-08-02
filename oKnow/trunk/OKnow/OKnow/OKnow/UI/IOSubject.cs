using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace OKnow.UI
{
    /// <summary>
    /// Subject which can be observed for notifications of IO events
    /// </summary>
    public static class IOSubject
    {
        private static IOState current;
        private static IOState previous;
        private static Dictionary<IOEvent, List<IOObserver>> observerDictionary = new Dictionary<IOEvent, List<IOObserver>>();
        private static Boolean initialized = false;

        /// <summary>
        /// Registers an observer for an IO event
        /// </summary>
        /// <param name="e">IO event</param>
        /// <param name="obj">observer</param>
        public static void AddObserver(IOEvent e, IOObserver obj)
        {
            if (!initialized)
            {
                Initialize(new GameTime());
            }

            if(!observerDictionary.ContainsKey(e))
            {
                observerDictionary.Add(e, new List<IOObserver>());
            }
            observerDictionary[e].Add(obj);
        }

        /// <summary>
        /// Initializeds the IOSubject
        /// </summary>
        /// <param name="gametime"></param>
        public static void Initialize(GameTime gametime)
        {
            current = new IOState(gametime);
            previous = new IOState(gametime);
            initialized = true;
            observerDictionary.Clear();
        }

        /// <summary>
        /// Updates the input states and notifies observers if events have occured
        /// </summary>
        /// <param name="gametime"></param>
        public static void Update(GameTime gametime)
        {
            if (!initialized)
            {
                Initialize(gametime);
            }
            previous = current;
            current = new IOState(gametime);

            List<IOEvent> eventList = observerDictionary.Keys.ToList();
            foreach (IOEvent e in eventList)
            {
                if (e.HasOccured(current, previous))
                {
                    List<IOObserver> observers = new List<IOObserver>(observerDictionary[e]);
                    foreach (IOObserver observer in observers)
                    {
                        observer.Notify(e);
                    }
                }
            }
        }

        /// <summary>
        /// Removes an observer and all registered events
        /// </summary>
        /// <param name="obj"></param>
        public static void RemoveObserver(IOObserver obj)
        {
            if (!initialized)
            {
                Initialize(new GameTime());
            }
            else
            {
                List<IOEvent> eventList = observerDictionary.Keys.ToList();
                foreach (IOEvent e in eventList)
                {
                    while(observerDictionary[e].Contains(obj))
                    {
                        observerDictionary[e].Remove(obj);
                    }

                    if (observerDictionary[e].Count <= 0)
                    {
                        observerDictionary.Remove(e);
                    }
                }
            }
        }
    }
}
