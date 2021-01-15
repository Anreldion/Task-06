using System;

namespace DataAccessLayer.Object_Relational_Mapping
{
    public class Session
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int SessionPeriodId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DateFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DateTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Session()
        {
        }

        public Session(int id, int sessionPeriodId, DateTime from, DateTime to)
        {
            Id = id;
            SessionPeriodId = sessionPeriodId;
            DateFrom = from;
            DateTo = to;
        }

        public Session(int sessionPeriodId, DateTime from, DateTime to)
        {
            SessionPeriodId = sessionPeriodId;
            DateFrom = from;
            DateTo = to;
        }

        public override bool Equals(object obj)
        {
            return obj is Session session &&
                   Id == session.Id &&
                   SessionPeriodId == session.SessionPeriodId &&
                   DateFrom == session.DateFrom &&
                   DateTo == session.DateTo;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, SessionPeriodId, DateFrom, DateTo);
        }
    }
}
