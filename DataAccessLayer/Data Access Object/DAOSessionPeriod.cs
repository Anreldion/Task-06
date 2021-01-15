using DataAccessLayer.Object_Relational_Mapping;

namespace DataAccessLayer.Data_Access_Object
{
    /// <summary>
    /// 
    /// </summary>
    public class DAOSessionPeriod : DAO<SessionPeriod>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        public DAOSessionPeriod(string connectionString) : base(connectionString)
        {
        }
    }

}
