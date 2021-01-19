using BusinessLogicLayer;
using BusinessLogicLayer.DeductibleStudent;
using BusinessLogicLayer.PointsByGroup;
using BusinessLogicLayer.SessionResult;
using NUnit.Framework;
using System.IO;

namespace NUnitTestProject
{
    public class ConnectionInfo
    {
       public const string ConnectionString = @"Data Source=UserPC\SQLEXPRESS; Initial Catalog=SessionResultsDatabase; Integrated Security=true;";
    }
    /// <summary>
    /// Testing method of <see cref="DeductibleStudentsReport"/> class
    /// </summary>
    [TestFixture]
    public class DeductibleStudentsReportsTests : ConnectionInfo
    {
        private static DeductibleStudentsReport Report { get; } = new DeductibleStudentsReport(ConnectionString);

        /// <summary>
        /// Testing <see cref="DeductibleStudentsReport.GetReport"/ method
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="passing_score">Passing score</param>
        /// <param name="path">Path to file</param>
        [TestCase(1, 6, @"DeductibleStudentsReport 1.xlsx")]
        [Description ("Testing GetReport method")]
        public void GetReportTest(int sessionId, int passing_score, string path)
        {
            Excel.CreateReportFile(Report.GetReport(sessionId, passing_score), path, true);
            Assert.IsTrue(File.Exists(path));
        }

        /// <summary>
        /// Testing <see cref="DeductibleStudentsReport.GetReport(int, int, System.Func{DeductibleStudentUnit, object})"/ method
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="passing_score">Passing score</param>
        /// <param name="path">Path to file</param>
        [TestCase(1, 6, @"DeductibleStudentsReport 2.xlsx")]
        [Description("Testing GetReport method")]
        public void GetReportSortingTest(int sessionId, int passing_score, string path)
        {
            Excel.CreateReportFile(Report.GetReport(sessionId, passing_score, s => s.Surname), path, true);
            Assert.IsTrue(File.Exists(path));
        }

    }

    /// <summary>
    /// Testing method of <see cref="PointsByGroupReport"/> class
    /// </summary>
    [TestFixture]
    public class PointsByGroupReportTests : ConnectionInfo
    {
        private static PointsByGroupReport Report { get; } = new PointsByGroupReport(ConnectionString);

        /// <summary>
        /// Testing <see cref="PointsByGroupReport.GetReport"/ method
        /// </summary>
        /// <param name="path">Path to file</param>
        [TestCase(@"PointsByGroupReport 1.xlsx")]
        [Description("Testing GetReport method")]
        public void GetReportTest(string path)
        {
            Excel.CreateReportFile(Report.GetReport(), path);
            Assert.IsTrue(File.Exists(path));
        }

        /// <summary>
        /// Testing <see cref="PointsByGroupReport.GetReport(System.Func{PointsByGroupUnit, object})"/ method
        /// </summary>
        /// <param name="path">Path to file</param>
        [TestCase(@"DeductibleStudentsReport 2.xlsx")]
        [Description("Testing GetReport method")]
        public void GetReportSortingTest(string path)
        {
            Excel.CreateReportFile(Report.GetReport(s => s.AverageScore), path, true);
            Assert.IsTrue(File.Exists(path));
        }
    }

    /// <summary>
    /// Testing method of <see cref="SessionResultReport"/> class
    /// </summary>
    [TestFixture]
    public class SessionResultReportTests : ConnectionInfo
    {
        private static SessionResultReport Report { get; } = new SessionResultReport(ConnectionString);

        /// <summary>
        /// Testing <see cref="SessionResultReport.GetReport"/ method
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="path">Path to file</param>
        [TestCase(1, "SessionResultReport 1.xlsx")]
        [TestCase(2, "SessionResultReport 2.xlsx")]
        [Description("Testing GetReport method")]
        public void SessionResultReportTest(int sessionId, string path)
        {
            Excel.CreateReportFile(Report.GetReport(sessionId), path, true);
            Assert.IsTrue(File.Exists(path));
        }

        /// <summary>
        /// Testing <see cref="SessionResultReport.GetReport(int, System.Func{SessionResultUnit, object})"/ method
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="path">Path to file</param>
        [TestCase(1, @"SessionResultReport 2.xlsx")]
        [Description("Testing GetReport method")]
        public void GetReportSortingTest(int sessionId, string path)
        {
            Excel.CreateReportFile(Report.GetReport(sessionId,s => s.Subject), path, true);
            Assert.IsTrue(File.Exists(path));
        }
    }
}
