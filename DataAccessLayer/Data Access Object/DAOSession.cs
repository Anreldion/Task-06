using DataAccessLayer.Object_Relational_Mapping;

namespace DataAccessLayer.Data_Access_Object
{
    /// <summary>
    /// 
    /// </summary>
    public class DAOSession : DAO<Session>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        public DAOSession(string connectionString) : base(connectionString)
        {
        }
    }

}
