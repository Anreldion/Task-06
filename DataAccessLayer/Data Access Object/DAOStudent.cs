using DataAccessLayer.Object_Relational_Mapping;

namespace DataAccessLayer.Data_Access_Object
{
    /// <summary>
    /// 
    /// </summary>
    public class DAOStudent : DAO<Student>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        public DAOStudent(string connectionString) : base(connectionString)
        {
        }
    }

}
