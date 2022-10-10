﻿
namespace ObserverPattern.Model
{
    public abstract class Observer
    {
        protected Subject subject;

        public abstract void Notify(Subject subject, object arg);
    }
}
