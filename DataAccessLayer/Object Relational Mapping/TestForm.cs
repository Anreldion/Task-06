using System;

namespace DataAccessLayer.Object_Relational_Mapping
{
    public class TestForm
    {
        public TestForm()
        {
        }

        public TestForm(string name)
        {
            Name = name;
        }

        public TestForm(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            return obj is TestForm form &&
                   Id == form.Id &&
                   Name == form.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}
