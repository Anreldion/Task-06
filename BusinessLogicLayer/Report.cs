using DataAccessLayer.Data_Access_Object;
using DataAccessLayer.Object_Relational_Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Report
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        protected Report(string connectionString)
        {
            Factory = DAOFactory.GetInstance(connectionString);
            GetAllData();
        }

        public DAOFactory Factory { get; set; }
        public IEnumerable<EducationForm> EducationForms { get; set; }
        public IEnumerable<Gender> Genders { get; set; }
        public IEnumerable<Group> Groups { get; set; }
        public IEnumerable<Result> Results { get; set; }
        public IEnumerable<Schedule> Schedules { get; set; }
        public IEnumerable<Session> Sessions { get; set; }
        public IEnumerable<SessionPeriod> SessionPeriods { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }
        public IEnumerable<TestForm> TestForms { get; set; }

        /// <summary>
        /// Get all data from database.
        /// </summary>
        void GetAllData()
        {
            EducationForms = Factory.GetEducationForm().ReadAllAsync().Result;
            Genders = Factory.GetGender().ReadAllAsync().Result;
            Sessions = Factory.GetSession().ReadAllAsync().Result;
            SessionPeriods = Factory.GetSessionPeriod().ReadAllAsync().Result;
            Results = Factory.GetResult().ReadAllAsync().Result;
            Schedules = Factory.GetSchedule().ReadAllAsync().Result;
            Groups = Factory.GetGroup().ReadAllAsync().Result;
            TestForms = Factory.GetTestForm().ReadAllAsync().Result;
            Students = Factory.GetStudent().ReadAllAsync().Result;
            Subjects = Factory.GetSubject().ReadAllAsync().Result;
        }
    }
}
