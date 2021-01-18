using BusinessLogicLayer;
using BusinessLogicLayer.DeductibleStudent;
using BusinessLogicLayer.PointsByGroup;
using NUnit.Framework;
using System.IO;

namespace NUnitTestProject
{
    [TestFixture]
    public class DeductibleStudentsReportsTest
    {
        protected const string PathToReport = @"DeductibleStudentsReport.xlsx";
        const string ConnectionString = @"Data Source=UserPC\SQLEXPRESS; Initial Catalog=SessionResultsDatabase; Integrated Security=true;";
        private static DeductibleStudentsReport Report { get; } = new DeductibleStudentsReport(ConnectionString);

        [OneTimeSetUp]
        public void SetUp()
        {

        }

        [Test]
        [TestCase(1)]
        public void DeductibleStudentTest(int id)
        {
            Excel.CreateReportFile(Report.GetReport(id, 6), PathToReport);
            Assert.IsTrue(File.Exists(PathToReport));
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
        [TestCase(1)]
        public void DeductibleStudentTest(int id)
        {
            Excel.CreateReportFile(Report.GetReport(), PathToReport);
            Assert.IsTrue(File.Exists(PathToReport));
        }
    }
}
