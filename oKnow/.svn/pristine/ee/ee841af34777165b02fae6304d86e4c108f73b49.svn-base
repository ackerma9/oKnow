using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace OKnow.UI
{
    public static class IOSubject
    {
        private static IOState current;
        private static IOState previous;
        private static Dictionary<IOEvent, List<IOObserver>> observerDictionary = new Dictionary<IOEvent, List<IOObserver>>();
        private static Boolean initialized = false;

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

        public static void Initialize(GameTime gametime)
        {
            current = new IOState(gametime);
            previous = new IOState(gametime);
            initialized = true;
            observerDictionary.Clear();
        }

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
