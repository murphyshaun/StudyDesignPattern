﻿using System;
using System.Collections.Generic;

namespace ObserverPattern.Model
{
    public class Subject
    {
        private readonly List<Observer> _observers = new List<Observer>();

        public void AttachObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        public void DetachObserver(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(Subject subject, Object arg)
        {
            _observers.ForEach(observer => observer.Notify(subject, arg));
        }
    }
}
