using System;

namespace UniversityObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            University university = new University();
            Professor professor = new Professor("Иван Иваныч", university);
            Student student = new Student("Анна", university);

            // изменение курсов
            university.ChangeCourses();
            // профессор перестает наблюдать за изменением курсов
            professor.StopWatching()
            university.ChangeCourses();

            Console.Read();
        }
    }
}
