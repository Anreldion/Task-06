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
            string[] GroupNames = GetGroupNames();
            int[] AllSessionId = GetSessionID();
            int[] AllMark = GetAllMark(1);


            //IEnumerable<(double, double, double, int, int)> info = from 

            List<PointsByGroupTable> list = new List<PointsByGroupTable>();



            return list;
        }

        public string[] GetGroupNames() => Groups.Select(g => g.Name).Distinct().ToArray();
        public int[] GetSessionID() => Sessions.Select(s => s.Id).Distinct().ToArray();
        public int[] GetAllMark(int sessionId) => Results.Where(r => r.SessionId == sessionId).Select(r => r.Mark).ToArray();
        public int[] GetAllStudentId(int groupId) => Students.Where(s => s.GroupId == groupId).Select(s => s.Id).ToArray();
        public double GetMinimumMark(int sessionId, int groupId)
        {
            return 1;
        }
        PointsByGroupUnit GetPoints(int sessionId, int groupId)
        {
            IEnumerable<int> AllMark = from result in Results
                                       join students in Students on result.StudentId equals students.Id
                                       where result.SessionId == sessionId && students.GroupId == groupId
                                       select result.Mark;

            double min = AllMark.Min(min => min);
            double max = AllMark.Max(max => max);
            double averenge = AllMark.Average();

            string groupName = Groups.Where(g => g.Id == groupId).Select(g => g.Name).Distinct().ToString();

            return new PointsByGroupUnit(groupName, min, averenge, max);
        }
    }
}
