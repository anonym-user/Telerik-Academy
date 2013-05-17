using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public abstract class Course
    {
        private string courseName;
        private Teacher teacherName;
        public IList<Student> students;

        protected Course(string courseName, Teacher teacherName, IList<Student> students)
        {
            this.courseName = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string CourseName
        {
            get
            {
                return this.courseName;
            }
            set 
            {
                if (value != null)
                {
                    this.courseName = value;
                }
                else
                {
                    throw new ArgumentException("The name of the course cannot be null");
                }
            }
        }

        public Teacher TeacherName
        { 
            get
            {
                return this.teacherName;
            }
            set 
            {
                if (value != null)
                {
                    this.teacherName = value;
                }
                else
                {
                    throw new ArgumentException("The name of the teacher cannot be null");
                }
            }
        }

        public IList<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                if (value != null)
                {
                    this.students = value;
                }
                else
                {
                    throw new ArgumentNullException("The students list cannot be null");
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.CourseName);
            result.AppendFormat("; Teacher = {0}", this.TeacherName.ToString());
            result.AppendFormat("; Students = {0}", this.GetStudentsAsString());
            
            return result.ToString();
        }

        private string GetStudentsAsString()
        {
            string studentsListAsString = "";
            for (int i = 0; i < this.Students.Count; i++)
            {
                studentsListAsString += this.Students[i].ToString();
                if (i < this.Students.Count - 1)
                {
                    studentsListAsString += ", ";
                }
            }

            return studentsListAsString;
        }
    }
}
