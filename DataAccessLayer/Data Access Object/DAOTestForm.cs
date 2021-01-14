using DataAccessLayer.Object_Relational_Mapping;

namespace DataAccessLayer.Data_Access_Object
{
    /// <summary>
    /// 
    /// </summary>
    public class DAOTestForm : DAO<TestForm>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        public DAOTestForm(string connectionString) : base(connectionString)
        {

        }
    }

}
