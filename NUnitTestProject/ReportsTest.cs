using BusinessLogicLayer;
using BusinessLogicLayer.DeductibleStudent;
using BusinessLogicLayer.PointsByGroup;
using BusinessLogicLayer.SessionResult;
using NUnit.Framework;
using System.IO;

namespace NUnitTestProject
{
    [TestFixture]
    public class DeductibleStudentsReportsTest
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
    public class PointsByGroupReportTest
    {
        protected const string PathToReport = @"PointsByGroupReport.xlsx";
        const string ConnectionString = @"Data Source=UserPC\SQLEXPRESS; Initial Catalog=SessionResultsDatabase; Integrated Security=true;";
        private static PointsByGroupReport Report { get; } = new PointsByGroupReport(ConnectionString);

        [OneTimeSetUp]
        public void SetUp()
        {

        }

        [Test]
        public void DeductibleStudentTest()
        {
            Excel.CreateReportFile(Report.GetReport(), PathToReport);
            Assert.IsTrue(File.Exists(PathToReport));
        }
    }
    [TestFixture]
    public class SessionResultReportTest
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
        public void DeductibleStudentTest(int id)
        {
            Excel.CreateReportFile(Report.GetReport(id), PathToReport);
            Assert.IsTrue(File.Exists(PathToReport));
        }
    }
}
