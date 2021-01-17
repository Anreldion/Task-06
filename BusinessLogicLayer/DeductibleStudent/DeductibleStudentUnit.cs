using System;

namespace BusinessLogicLayer.DeductibleStudent
{
    public class DeductibleStudentUnit
    {
        public DeductibleStudentUnit(string name, string surname, string middleName, string educationForm, string groupName)
        {
            Name = name;
            Surname = surname;
            MiddleName = middleName;
            EducationForm = educationForm;
            GroupName = groupName;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string EducationForm { get; set; }
        public string GroupName { get; set; }

        public override bool Equals(object obj)
        {
            return obj is DeductibleStudentUnit student &&
                   Name == student.Name &&
                   Surname == student.Surname &&
                   MiddleName == student.MiddleName &&
                   GroupName == student.GroupName &&
                   EducationForm == student.EducationForm;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Surname, MiddleName, EducationForm, GroupName);
        }
        public override string ToString()
        {
            return $"{Surname} {Name} {MiddleName}";
        }
    }
}
