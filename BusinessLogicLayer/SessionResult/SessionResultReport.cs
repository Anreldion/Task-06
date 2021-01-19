using System.Collections.Generic;

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
            List<SessionResultTable> list = new List<SessionResultTable>();



            return list;

        }

    }
}
