using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.PointsByGroup
{
    /// <summary>
    /// The class contains information about the average / minimum / maximum score for the group
    /// </summary>
    public class PointsByGroupUnit
    {
        /// <summary>
        /// Class constructor <see cref="PointsByGroupUnit"/>
        /// </summary>
        /// <param name="groupName">Group name</param>
        /// <param name="minimumScore">Minimum score</param>
        /// <param name="averageScore">Average score</param>
        /// <param name="maximumScore">Maximum score</param>
        public PointsByGroupUnit(string groupName, double minimumScore, double averageScore, double maximumScore)
        {
            GroupName = groupName;
            MinimumScore = minimumScore;
            AverageScore = averageScore;
            MaximumScore = maximumScore;
        }

        /// <summary>
        /// Group name 
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// Minimum score
        /// </summary>
        public double MinimumScore { get; set; }
        /// <summary>
        /// Average score
        /// </summary>
        public double AverageScore { get; set; }
        /// <summary>
        /// Maximum score
        /// </summary>
        public double MaximumScore { get; set; }
        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            return obj is PointsByGroupUnit table &&
                   GroupName == table.GroupName &&
                   MinimumScore == table.MinimumScore &&
                   AverageScore == table.AverageScore &&
                   MaximumScore == table.MaximumScore;
        }
        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            return HashCode.Combine(GroupName, MinimumScore, AverageScore, MaximumScore);
        }
    }
}
