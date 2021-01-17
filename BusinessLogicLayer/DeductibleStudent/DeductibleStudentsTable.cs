using System;
using System.Collections.Generic;

namespace BusinessLogicLayer.DeductibleStudent
{
    public class DeductibleStudentsTable
    {
        public IEnumerable<DeductibleStudentUnit> deductibleStudents;

        public DeductibleStudentsTable(IEnumerable<DeductibleStudentUnit> deductibleStudents, string group)
        {
            this.deductibleStudents = deductibleStudents;
            Group = group;
        }

        public string Group { get; set; }
        public string[] Headers { get; } = { "Surname", "Name", "MiddleName", "Mark", "EducationForms" };

        public override bool Equals(object obj)
        {
            return obj is DeductibleStudentsTable table &&
                   EqualityComparer<IEnumerable<DeductibleStudentUnit>>.Default.Equals(deductibleStudents, table.deductibleStudents) &&
                   Group == table.Group &&
                   EqualityComparer<string[]>.Default.Equals(Headers, table.Headers);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(deductibleStudents, Group, Headers);
        }
    }
}
