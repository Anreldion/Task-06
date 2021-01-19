using BusinessLogicLayer;
using BusinessLogicLayer.DeductibleStudent;
using BusinessLogicLayer.PointsByGroup;
using BusinessLogicLayer.SessionResult;
using NUnit.Framework;
using System.IO;

namespace NUnitTestProject
{
    /// <summary>
    /// Testing method of <see cref="DeductibleStudentsReport"/> class
    /// </summary>
    [TestFixture]
    public class DeductibleStudentsReportsTests
    {
        protected const string Path = @"DeductibleStudentsReport.xlsx";
        const string ConnectionString = @"Data Source=UserPC\SQLEXPRESS; Initial Catalog=SessionResultsDatabase; Integrated Security=true;";
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

    [TestFixture]
    public class PointsByGroupReportTests
    {
        protected const string PathToReport = @"PointsByGroupReport.xlsx";
        const string ConnectionString = @"Data Source=UserPC\SQLEXPRESS; Initial Catalog=SessionResultsDatabase; Integrated Security=true;";
        private static PointsByGroupReport Report { get; } = new PointsByGroupReport(ConnectionString);

        [OneTimeSetUp]
        public void SetUp()
        {

        }

        [Test]
        public void PointsByGroupReportTest()
        {
            Excel.CreateReportFile(Report.GetReport(), PathToReport);
            Assert.IsTrue(File.Exists(PathToReport));
        }
    }
    [TestFixture]
    public class SessionResultReportTests
    {
        protected const string PathToReport = @"SessionResultReport.xlsx";
        const string ConnectionString = @"Data Source=UserPC\SQLEXPRESS; Initial Catalog=SessionResultsDatabase; Integrated Security=true;";
        private static SessionResultReport Report { get; } = new SessionResultReport(ConnectionString);

        [OneTimeSetUp]
        public void SetUp()
        {

        }

        [Test]
        [TestCase(1)]
        public void SessionResultReportTest(int id)
        {
            Excel.CreateReportFile(Report.GetReport(id), PathToReport, true);
            Assert.IsTrue(File.Exists(PathToReport));
        }
    }
}
