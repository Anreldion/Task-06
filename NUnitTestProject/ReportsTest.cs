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
        protected const string Path = @"DeductibleStudentsReport.xlsx";
        private static DeductibleStudentsReport Report { get; } = new DeductibleStudentsReport(ConnectionString);

        [OneTimeSetUp]
        public void SetUp()
        {

        }

        [Test]
        [TestCase(1)]
        public void DeductibleStudentTest(int sessionId)
        {
            Excel.CreateReportFile(Report.GetReport(sessionId, 6), Path);
            Assert.IsTrue(File.Exists(Path));
        }
    }

    /// <summary>
    /// Testing method of <see cref="PointsByGroupReport"/> class
    /// </summary>
    [TestFixture]
    public class PointsByGroupReportTests : ConnectionInfo
    {
        private static PointsByGroupReport Report { get; } = new PointsByGroupReport(ConnectionString);

        [OneTimeSetUp]
        public void SetUp()
        {

        }

        [Test]
        [TestCase("PointsByGroupReport 1.xlsx")]
        public void PointsByGroupReportTest(string path_to_file)
        {
            Excel.CreateReportFile(Report.GetReport(), path_to_file);
            Assert.IsTrue(File.Exists(path_to_file));
        }
    }

    /// <summary>
    /// Testing method of <see cref="SessionResultReport"/> class
    /// </summary>
    [TestFixture]
    public class SessionResultReportTests : ConnectionInfo
    {
        private static SessionResultReport Report { get; } = new SessionResultReport(ConnectionString);

        [OneTimeSetUp]
        public void SetUp()
        {

        }

        [Test]
        [TestCase(1, "SessionResultReport 1.xlsx")]
        [TestCase(2, "SessionResultReport 2.xlsx")]
        public void SessionResultReportTest(int sessionId, string path_to_file)
        {
            Excel.CreateReportFile(Report.GetReport(sessionId), path_to_file, true);
            Assert.IsTrue(File.Exists(path_to_file));
        }
    }
}
