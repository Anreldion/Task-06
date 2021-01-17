﻿using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer.DeductibleStudent
{
    /// <summary>
    /// Class for the formation of tables in groups with students to be expelled.
    /// </summary>
    public class DeductibleStudentsReport : Report
    {
        /// <summary>
        /// Class constructor <see cref="DeductibleStudentsReport"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DeductibleStudentsReport(string connectionString) : base(connectionString)
        {
        }
        /// <summary>
        /// Get a list of tables by group. The tables contain the full names of the students to be expelled.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="mark"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Get information about the student to be expelled.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="mark"></param>
        /// <param name="groupName"></param>
        /// <returns>List with <see cref="DeductibleStudentUnit"/></returns>
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
        /// <summary>
        /// Get student IDs to drop out.
        /// </summary>
        /// <param name="sessionId">ID session</param>
        /// <param name="зassing_score">Passing score</param>
        /// <returns>IEnumerable<(int StudentId, int GroupId, int EducationFormId)></returns>
        private IEnumerable<(int, int, int)> GetStudentIdAndFormEducationIdAndGroupID(int sessionId, int зassing_score)// => Results.Where(result => result.Mark < mark && result.SessionId == sessionId).Select(results, group => results.StudentId).Distinct();
        {
            return from result in Results
                   join studene in Students on result.StudentId equals studene.Id
                   join ed_form in EducationForms on studene.EducationFormId equals ed_form.Id
                   where result.Mark < зassing_score && result.SessionId == sessionId
                   select (result.StudentId, studene.GroupId, ed_form.Id);
        }
        /// <summary>
        /// Get unique group names
        /// </summary>
        /// <returns>Array with group names</returns>
        public string[] GetGroupNames() => Groups.Select(g => g.Name).Distinct().ToArray();
    }
}
