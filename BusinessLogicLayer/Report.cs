using DataAccessLayer.Data_Access_Object;
using DataAccessLayer.Object_Relational_Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    public abstract class Report
    {
        protected Report(string connectionString)
        {
            DAOFactory = DAOFactory.GetInstance(connectionString);
            Sessions = DAOFactory.GetSession().ReadAllAsync().Result;
            Results = DAOFactory.GetResult().ReadAllAsync().Result;
            Schedules = DAOFactory.GetSchedule().ReadAllAsync().Result;
            Groups = DAOFactory.GetGroup().ReadAllAsync().Result;
            TestForms = DAOFactory.GetTestForm().ReadAllAsync().Result;
            Students = DAOFactory.GetStudent().ReadAllAsync().Result;
            Subjects = DAOFactory.GetSubject().ReadAllAsync().Result;
        }
        public DAOFactory DAOFactory { get; set; }
        public IEnumerable<Gender> Genders { get; set; }
        public IEnumerable<Group> Groups { get; set; }
        public IEnumerable<Result> Results { get; set; }
        public IEnumerable<Schedule> Schedules { get; set; }
        public IEnumerable<Session> Sessions { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }
        public IEnumerable<TestForm> TestForms { get; set; }
    }
}
