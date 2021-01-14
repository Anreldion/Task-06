using System;

namespace DataAccessLayer.Object_Relational_Mapping
{
    public class Schedule
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int SubjectId { get; set; }
        public int SessionId { get; set; }
        public int GroupId { get; set; }
        public int TestFormId { get; set; }

        public Schedule()
        {
        }

        public Schedule(DateTime date, int subjectId, int sessionId, int groupId, int testFormId)
        {
            Date = date;
            SubjectId = subjectId;
            SessionId = sessionId;
            GroupId = groupId;
            TestFormId = testFormId;
        }

        public Schedule(int id, DateTime date, int subjectId, int sessionId, int groupId, int testFormId)
        {
            Id = id;
            Date = date;
            SubjectId = subjectId;
            SessionId = sessionId;
            GroupId = groupId;
            TestFormId = testFormId;
        }

        public override bool Equals(object obj)
        {
            return obj is Schedule schedule &&
                   Id == schedule.Id &&
                   Date == schedule.Date &&
                   SubjectId == schedule.SubjectId &&
                   SessionId == schedule.SessionId &&
                   GroupId == schedule.GroupId &&
                   TestFormId == schedule.TestFormId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Date, SubjectId, SessionId, GroupId, TestFormId);
        }
    }
}
