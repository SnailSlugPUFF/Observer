using System;

namespace UniversityObserver
{
    class Student : IObserver
    {
        public string Name { get; set; }
        IObservable university;
        public Student(string name, IObservable obs)
        {
            this.Name = name;
            university = obs;
            university.RegisterObserver(this);
        }
        public void Update(object ob)
        {
            CourseInfo courseInfo = (CourseInfo)ob;
            Console.WriteLine("Студент {0} просматривает курсы: Математика: {1}, Физика: {2}",
                       this.Name, courseInfo.MathCourse, courseInfo.PhysicsCourse);
        }
    }
}