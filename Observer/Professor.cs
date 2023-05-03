using System;

namespace UniversityObserver
{
    class Professor : IObserver
    {
        public string Name { get; set; }
        IObservable university;
        public Professor(string name, IObservable obs)
        {
            this.Name = name;
            university = obs;
            university.RegisterObserver(this);
        }
        public void Update(object ob)
        {
            CourseInfo courseInfo = (CourseInfo)ob;

            Console.WriteLine("Профессор {0} анализирует курсы: Математика: {1}, Физика: {2}",
                               this.Name, courseInfo.MathCourse, courseInfo.PhysicsCourse);
        }
        public void StopWatching()

        {
            university.RemoveObserver(this);
            Console.WriteLine("Профессор {0} перестал наблюдать за изменением курсов", this.Name);
        }
    }
}
