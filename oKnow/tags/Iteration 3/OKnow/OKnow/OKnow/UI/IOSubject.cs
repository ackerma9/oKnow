using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OKnow.UI
{
    public static class IOSubject
    {
        private static IOState current;
        private static IOState previous;

        private static Dictionary<IOEvent, List<IOObserver>> observerDictionary = new Dictionary<IOEvent, List<IOObserver>>();
        //private static HashSet<IOObserver> observers = new HashSet<IOObserver>();

        private static Boolean initialized = false;

        public static void AddObserver(IOEvent e, IOObserver obj)
        {
            if (!initialized)
            {
                Initialize();
            }

            if(!observerDictionary.ContainsKey(e))
            {
                observerDictionary.Add(e, new List<IOObserver>());
            }
            observerDictionary[e].Add(obj);
        }

        public static void Initialize()
        {
            current = new IOState();
            previous = new IOState();
            initialized = true;
            observerDictionary.Clear();
        }

        public static void Update()
        {
            if (!initialized)
            {
                Initialize();
            }
            previous = current;
            current = new IOState();

            foreach (IOEvent e in observerDictionary.Keys)
            {
                if (e.HasOccured(current, previous))
                {
                    foreach (IOObserver observer in observerDictionary[e])
                    {
                        observer.Notify(e);
                    }
                }
            }
        }

    }
}
