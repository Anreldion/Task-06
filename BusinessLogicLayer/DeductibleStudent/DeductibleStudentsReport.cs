using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer.DeductibleStudent
{
    public class DeductibleStudentsReport : Report
    {
        public DeductibleStudentsReport(string connectionString) : base(connectionString)
        {
        }
        public IEnumerable<DeductibleStudentsTable> GetReport(int sessionId, int mark)
        {
            string[] GroupNames = GetGroupNames().Distinct().ToArray();
            List<DeductibleStudentsTable> list = new List<DeductibleStudentsTable>();
            foreach (var groupName in GroupNames)
            {
                list.Add(new DeductibleStudentsTable(GetStudents(sessionId, mark, groupName), groupName));
            }

            return list;
        }
        private IEnumerable<DeductibleStudentUnit> GetStudents(int sessionId, int mark, string groupName)
        {
            IEnumerable<(int, int, int)> StudentIdAndFormEducationIdAndGroupID = GetStudentIdAndFormEducationIdAndGroupID(sessionId, 6).Distinct();
            IEnumerable<DeductibleStudentUnit> AllDeductibleStudents = from sfg in StudentIdAndFormEducationIdAndGroupID
                                                          join students in Students on sfg.Item1 equals students.Id
                                                          join groups in Groups on sfg.Item2 equals groups.Id
                                                          join form in EducationForms on sfg.Item3 equals form.Id
                                                          select (new DeductibleStudentUnit(students.Name, students.Surname, students.MiddleName, form.Name, groups.Name));
            IEnumerable<DeductibleStudentUnit> deductibleStudent = from ads in AllDeductibleStudents
                                                               where (groupName == ads.GroupName)
                                                               select ads;
            return deductibleStudent;
        }
        private IEnumerable<(int, int, int)> GetStudentIdAndFormEducationIdAndGroupID(int sessionId, int mark)// => Results.Where(result => result.Mark < mark && result.SessionId == sessionId).Select(results, group => results.StudentId).Distinct();
        {
            return from result in Results
                   join studene in Students on result.StudentId equals studene.Id
                   join ed_form in EducationForms on studene.EducationFormId equals ed_form.Id
                   where result.Mark < mark && result.SessionId == sessionId
                   select (result.StudentId, studene.GroupId, ed_form.Id);
        }
        public string[] GetGroupNames() => Groups.Select(g => g.Name).Distinct().ToArray();
    }
}
