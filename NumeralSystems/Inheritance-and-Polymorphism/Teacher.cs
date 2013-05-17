using System;

namespace InheritanceAndPolymorphism
{
    public class Teacher
    {
        private string teacherName;

        public Teacher(string teacherName)
        {
            this.TeacherName = teacherName;
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }
            set
            {
                if (value.Length >= 2)
                {
                    this.teacherName = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Name should be at least two letters!");
                }
            }
        }

        public override string ToString()
        {
            return this.TeacherName;
        }
    }
}