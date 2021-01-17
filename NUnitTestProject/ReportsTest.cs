using BusinessLogicLayer;
using BusinessLogicLayer.DeductibleStudent;
using NUnit.Framework;
using System.IO;

namespace NUnitTestProject
{
    [TestFixture]
    public class ReportsTest
    {
        protected const string PathToExpelledStudentsReportExcelFile = @"Report.xlsx";
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
            Excel.CreateReportFile(Report.GetReport(id,6), PathToExpelledStudentsReportExcelFile);
            Assert.IsTrue(File.Exists(PathToExpelledStudentsReportExcelFile));
        }

    }
}
