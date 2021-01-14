using System;

namespace DataAccessLayer.Object_Relational_Mapping
{
    public class Student
    {
        public Student()
        {
        }

        public Student(string name, string surname, int genderId, DateTime date, int groupId, int course, int educationFormId)
        {
            Name = name;
            Surname = surname;
            GenderId = genderId;
            DateofBirth = date;
            GroupId = groupId;
            EducationFormId = educationFormId;
        }

        public Student(int id, string name, string surname, int genderId, DateTime date, int groupId, int course, int educationFormId)
        {
            Id = id;
            Name = name;
            Surname = surname;
            GenderId = genderId;
            DateofBirth = date;
            GroupId = groupId;
            EducationFormId = educationFormId;
        }

        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string MiddleName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int GenderId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DateofBirth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int GroupId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int EducationFormId { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Id == student.Id &&
                   Name == student.Name &&
                   Surname == student.Surname &&
                   GenderId == student.GenderId &&
                   DateofBirth == student.DateofBirth &&
                   GroupId == student.GroupId &&
                   EducationFormId == student.EducationFormId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Surname, GenderId, DateofBirth, GroupId, EducationFormId);
        }
    }
}
