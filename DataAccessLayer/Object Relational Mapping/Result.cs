using System;

namespace DataAccessLayer.Object_Relational_Mapping
{
    public class Result
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int SessionId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int SubjectId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int StudentId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Mark { get; set; }
        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public Result()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="subjectId"></param>
        /// <param name="studentId"></param>
        /// <param name="mark"></param>
        public Result(int sessionId, int subjectId, int studentId, int mark)
        {
            SessionId = sessionId;
            SubjectId = subjectId;
            StudentId = studentId;
            Mark = mark;
        }

        public Result(int id, int sessionId, int subjectId, int studentId, int mark)
        {
            Id = id;
            SessionId = sessionId;
            SubjectId = subjectId;
            StudentId = studentId;
            Mark = mark;
        }

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            return obj is Result result &&
                   Id == result.Id &&
                   SessionId == result.SessionId &&
                   SubjectId == result.SubjectId &&
                   StudentId == result.StudentId &&
                   Mark == result.Mark;
        }
        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, SessionId, SubjectId, StudentId, Mark);
        }
    }
}
