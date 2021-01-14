using System;

namespace DataAccessLayer.Object_Relational_Mapping
{
    public class SessionPeriod
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Form of education name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public SessionPeriod()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Group name</param>
        public SessionPeriod(string name)
        {
            Name = name;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Form of education ID</param>
        /// <param name="name">Form of education name</param>
        public SessionPeriod(int id, string name)
        {
            Id = id;
            Name = name;
        }
        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            return obj is SessionPeriod period &&
                   Id == period.Id &&
                   Name == period.Name;
        }
        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}
