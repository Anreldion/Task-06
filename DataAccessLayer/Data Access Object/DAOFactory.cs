using DataAccessLayer.Object_Relational_Mapping;

namespace DataAccessLayer.Data_Access_Object
{
    /// <summary>
    /// Factory to create Data Access Object.
    /// </summary>
    public class DAOFactory
    {
        private static DAOFactory instance;
        private static string connectionString;

        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        private DAOFactory()
        {
        }

        /// <summary>Getting instance of class</summary>
        /// <param name="connectionString">SQL Server connection string</param>
        /// <returns>Instance of <see cref="DAOFactory"/></returns>
        public static DAOFactory GetInstance(string connectionString)
        {
            if (instance == null)
            {
                instance = new DAOFactory();
                DAOFactory.connectionString = connectionString;
            }
            return instance;
        }

        public DAO<EducationForm> GetEducationForm()
        {
            return new DAOEducationForm(connectionString);
        }
        public DAO<Gender> GetGender()
        {
            return new DAOGender(connectionString);
        }
        public DAO<Group> GetGroup()
        {
            return new DAOGroup(connectionString);
        }
        public DAO<Result> GetResult()
        {
            return new DAOResult(connectionString);
        }
        public DAO<Schedule> GetSchedule()
        {
            return new DAOSchedule(connectionString);
        }
        public DAO<Session> GetSession()
        {
            return new DAOSession(connectionString);
        }
        public DAO<SessionPeriod> GetSessionPeriod()
        {
            return new DAOSessionPeriod(connectionString);
        }
        public DAO<Student> GetStudent()
        {
            return new DAOStudent(connectionString);
        }
        public DAO<Subject> GetSubject()
        {
            return new DAOSubject(connectionString);
        }
        public DAO<TestForm> GetTestForm()
        {
            return new DAOTestForm(connectionString);
        }
    }
}
