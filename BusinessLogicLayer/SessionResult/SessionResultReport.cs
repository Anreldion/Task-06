using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer.SessionResult
{
    /// <summary>
    /// The class allows you to create up the session for each group in a table.
    /// </summary>
    public class SessionResultReport : Report
    {
        /// <summary>
        /// Class constructor <see cref="SessionResultReport"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public SessionResultReport(string connectionString) : base(connectionString)
        {
        }
        /// <summary>
        /// Get the session summary for each group in the form of a table.
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <returns></returns>
        public IEnumerable<SessionResultTable> GetReport(int sessionId)
        {
            return GetGroupId(sessionId).Select(groupId => new SessionResultTable(GetRowSessionResult(sessionId, groupId), GetGroupName(groupId))).ToList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId"></param>
        /// <returns></returns>
        int[] GetGroupId(int sessionId) => Schedules.Where(s => s.SessionId == sessionId).Select(s => s.GroupId).Distinct().ToArray();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        string GetGroupName(int groupId) => Groups.FirstOrDefault(g => g.Id == groupId)?.Name;

        IEnumerable<SessionResultUnit> GetRowSessionResult(int sessionId, int groupId)
        {
            return from students in Students
                   join results in Results on students.Id equals results.StudentId
                   join subjects in Subjects on results.SubjectId equals subjects.Id
                   join schedules in Schedules on students.GroupId equals schedules.GroupId
                   join testForms in TestForms on schedules.TestFormId equals testForms.Id
                   where results.SessionId == sessionId && schedules.SessionId == sessionId && schedules.GroupId == groupId && students.GroupId == groupId
                   select new SessionResultUnit(students.Name, students.Surname, students.MiddleName, subjects.Name, results.Mark, schedules.Date, testForms.Name);
        }
    }
}
