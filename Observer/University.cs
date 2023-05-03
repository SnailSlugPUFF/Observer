using System;
using System.Collections.Generic;

namespace UniversityObserver
{
    class University : IObservable
    {
        CourseInfo courseInfo; // информация о курсах

        List<IObserver> observers;
        public University()
        {
            observers = new List<IObserver>();
            courseInfo = new CourseInfo();
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(courseInfo);
            }
        }

        public void ChangeCourses()
        {
            Random rnd = new Random();
            courseInfo.MathCourse = rnd.Next(20, 40);
            courseInfo.PhysicsCourse = rnd.Next(30, 50);
            NotifyObservers();
        }
    }
}