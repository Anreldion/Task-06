using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer.PointsByGroup
{
    /// <summary>
    /// The class contains information about the average / minimum / maximum score for each group
    /// </summary>
    public class PointsByGroupReport : Report
    {
        /// <summary>
        /// Class constructor <see cref="PointsByGroupReport"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public PointsByGroupReport(string connectionString) : base(connectionString)
        {
        }

        public IEnumerable<PointsByGroupTable> GetReport()
        {
            IEnumerable<(int, int)> SessionIdAndGroupId = from schedules in Schedules
                                                          select (schedules.SessionId, schedules.GroupId);
            SessionIdAndGroupId = SessionIdAndGroupId.Distinct();
            IEnumerable<int> AllSessionsId = from s in SessionIdAndGroupId
                                             select (s.Item1);
            AllSessionsId = AllSessionsId.Distinct();
            List<PointsByGroupUnit> listPointsByGroupUnit = SessionIdAndGroupId.Select(s => GetPointsByGroup(s.Item1, s.Item2)).ToList();
            List<PointsByGroupTable> listPointsByGroupTable = new List<PointsByGroupTable>();

            listPointsByGroupTable = AllSessionsId.Select(s => new PointsByGroupTable(SelectPointsByGroup(listPointsByGroupUnit, s), GetSessionPeriodName(s))).ToList();

            return listPointsByGroupTable;
        }
        PointsByGroupUnit GetPointsByGroup(int sessionId, int groupId)
        {
            IEnumerable<int> AllMark = from result in Results
                                       join students in Students on result.StudentId equals students.Id
                                       where result.SessionId == sessionId && students.GroupId == groupId
                                       select result.Mark;

            double min = AllMark.Min(min => min);
            double max = AllMark.Max(max => max);
            double averenge = AllMark.Average();

            string groupName = Groups.FirstOrDefault(g => g.Id == groupId)?.Name;

            return new PointsByGroupUnit(groupName, min, averenge, max, sessionId);
        }
        List<PointsByGroupUnit> SelectPointsByGroup(List<PointsByGroupUnit> list, int sessionId)
        {
            List<PointsByGroupUnit> rlist = list.Where(s => s.SessionId == sessionId).ToList();
            return rlist;
        }

        string GetSessionPeriodName(int sessionId)
        {
            IEnumerable<(string, DateTime, DateTime)> name = from sessions in Sessions
                                                             join period in SessionPeriods on sessions.SessionPeriodId equals period.Id
                                                             where sessionId == sessions.Id
                                                             select (period.Name, sessions.DateFrom, sessions.DateTo);

            return $"{name.Last().Item1} ({name.Last().Item2.ToString("dd.MM.yy")} - {name.Last().Item3.ToString("dd.MM.yy")})";
        }

    }
}
