using System;

namespace DataAccessLayer.Object_Relational_Mapping
{
    public class Subject
    {
        public Subject()
        {
        }

        public Subject(string name)
        {
            Name = name;
        }

        public Subject(int id, string name)
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
            return obj is Subject subject &&
                   Id == subject.Id &&
                   Name == subject.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}
