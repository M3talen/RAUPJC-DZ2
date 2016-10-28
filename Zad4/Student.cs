﻿namespace Zad4
{
    public class Student
    {
        public Student(string name, string jmbag)
        {
            Name = name;
            Jmbag = jmbag;
        }

        public Student(string name, string jmbag, Gender gender)
        {
            Name = name;
            Jmbag = jmbag;
            Gender = gender;
        }

        public string Name { get; set; }
        public string Jmbag { get; set; }
        public Gender Gender { get; set; }

        public override bool Equals(object obj)
        {
            var stud = obj as Student;
            if ((bool) (stud == null)) return false;
            return stud.Jmbag.Equals(Jmbag);
        }

        public override int GetHashCode()
        {
            return Jmbag.GetHashCode();
        }

        public static object operator ==(Student a, Student b)
        {
            if (ReferenceEquals(a, null))
                return ReferenceEquals(b, null);

            return a.Equals(b);
        }

        public static object operator !=(Student a, Student b)
        {
            return !Equals(a, b);
        }

        public override string ToString()
        {
            return $" {Name} \t({Jmbag} : {Gender})";
        }
    }

    public enum Gender
    {
        Male,
        Female
    }
}