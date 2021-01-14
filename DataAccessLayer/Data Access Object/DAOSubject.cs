using DataAccessLayer.Object_Relational_Mapping;

namespace DataAccessLayer.Data_Access_Object
{
    /// <summary>
    /// 
    /// </summary>
    public class DAOSubject : DAO<Subject>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        public DAOSubject(string connectionString) : base(connectionString)
        {
        }
    }

}
