using DataAccessLayer.Object_Relational_Mapping;

namespace DataAccessLayer.Data_Access_Object
{
    /// <summary>
    /// Factory to create Data Access Object.
    /// </summary>
    public class DAOFactory
    {
        private static DAOFactory _instance;
        private static string _connectionString;

        /// <summary>Default constructor</summary>
        /// <remarks>Private</remarks>
        private DAOFactory()
        {
        }

        /// <summary>Getting instance of class</summary>
        /// <param name="connectionString">SQL Server connection string</param>
        /// <returns>Instance of <see cref="DaoFactory"/></returns>
        public static DAOFactory GetInstance(string connectionString)
        {
            if (_instance == null)
            {
                _instance = new DAOFactory();
                _connectionString = connectionString;
            }
            return _instance;
        }

        public DAO<Gender> GetGender()
        {
            return new DAOGender(_connectionString);
        }
        public DAO<Group> GetGroup()
        {
            return new DAOGroup(_connectionString);
        }
        public DAO<Result> GetResult()
        {
            return new DAOResult(_connectionString);
        }
        public DAO<Schedule> GetSchedule()
        {
            return new DAOSchedule(_connectionString);
        }
        public DAO<Session> GetSession()
        {
            return new DAOSession(_connectionString);
        }
        public DAO<Student> GetStudent()
        {
            return new DAOStudent(_connectionString);
        }
        public DAO<Subject> GetSubject()
        {
            return new DAOSubject(_connectionString);
        }
        public DAO<TestForm> GetTestForm()
        {
            return new DAOTestForm(_connectionString);
        }
    }
}
