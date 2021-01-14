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
        public DateTime From { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime To { get; set; }
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
            From = from;
            To = to;
        }

        public Session(int sessionPeriodId, DateTime from, DateTime to)
        {
            SessionPeriodId = sessionPeriodId;
            From = from;
            To = to;
        }

        public override bool Equals(object obj)
        {
            return obj is Session session &&
                   Id == session.Id &&
                   SessionPeriodId == session.SessionPeriodId &&
                   From == session.From &&
                   To == session.To;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, SessionPeriodId, From, To);
        }
    }
}
