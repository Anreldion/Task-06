using DataAccessLayer.Object_Relational_Mapping;

namespace DataAccessLayer.Data_Access_Object
{
    /// <summary>
    /// 
    /// </summary>
    public class DAOSchedule : DAO<Schedule>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        public DAOSchedule(string connectionString) : base(connectionString)
        {
        }
    }

}
