using DataAccessLayer.Data_Access_Object;
using DataAccessLayer.Object_Relational_Mapping;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NUnitTestProject
{
    [TestFixture]
    public class CRUDTests
    {
        protected DAOFactory DaoFactory { get; } = DAOFactory.GetInstance(@"Data Source=UserPC\SQLEXPRESS; Initial Catalog=SessionResultsDatabase; Integrated Security=true;");

        [Test]
        public void GenderTests()
        {
            //Create.
            Assert.IsTrue(DaoFactory.GetGender().CreateAsync(new Gender("Man")).Result);
            Assert.IsTrue(DaoFactory.GetGender().CreateAsync(new Gender("Man")).Result);

            //Read All
            IEnumerable<Gender> gender_list = DaoFactory.GetGender().ReadAllAsync().Result;
            int max_id = gender_list.Last().Id;
            Assert.IsNotNull(gender_list);

            //Update.
            Assert.IsTrue(DaoFactory.GetGender().UpdateAsync(new Gender(1, "Woman")).Result);

            //Delete.
            Assert.IsTrue(DaoFactory.GetGender().DeleteAsync(max_id--).Result);
            Assert.IsTrue(DaoFactory.GetGender().DeleteAsync(max_id).Result);
        }

        [Test]
        public void GroupTests()
        {
            //Create.
            Assert.IsTrue(DaoFactory.GetGroup().CreateAsync(new Group("NewGroup")).Result);

            //Read All
            IEnumerable<Group> list = DaoFactory.GetGroup().ReadAllAsync().Result;
            Assert.IsNotNull(list);

            //Update.
            Assert.IsTrue(DaoFactory.GetGroup().UpdateAsync(new Group(list.Last().Id, "NewGroupUpdate")).Result);

            //Delete.
            Assert.IsTrue(DaoFactory.GetGroup().DeleteAsync(list.Last().Id).Result);
        }

        [Test]
        public void ResultTests()
        {
            //Create.
            Assert.IsTrue(DaoFactory.GetResult().CreateAsync(new Result(1, 1, 1, 10)).Result);

            //Read All
            IEnumerable<Result> list = DaoFactory.GetResult().ReadAllAsync().Result;
            Assert.IsNotNull(list);

            //Update.
            Assert.IsTrue(DaoFactory.GetResult().UpdateAsync(new Result(list.Last().Id, 1, 1, 1, 9)).Result);

            //Delete.
            Assert.IsTrue(DaoFactory.GetResult().DeleteAsync(3).Result);


        }

        [Test]
        public void SchedulesTests()
        {
            //Create.
            Assert.IsTrue(DaoFactory.GetSchedule().CreateAsync(new Schedule(DateTime.Now,1, 1, 1, 1)).Result);
            //Is exists.
            Assert.IsNotNull(DaoFactory.GetSchedule().TryReadAsync(1).Result);
            //Is don't exists.
            Assert.IsNull(DaoFactory.GetSchedule().TryReadAsync(150).Result);
            //Update.
            Assert.IsTrue(DaoFactory.GetSchedule().UpdateAsync(new Schedule(1,DateTime.Now,1, 1, 1, 2)).Result);
            //Update if don't exists.
            Assert.IsFalse(DaoFactory.GetSchedule().UpdateAsync(new Schedule(150,DateTime.Now, 1, 1, 1, 150)).Result);
            //Delete.
            Assert.IsTrue(DaoFactory.GetSchedule().DeleteAsync(3).Result);
            //Delete if don't exists.
            Assert.IsFalse(DaoFactory.GetSchedule().DeleteAsync(150).Result);
            //Read All
            Assert.IsNotNull(DaoFactory.GetSchedule().ReadAllAsync().Result);
        }

        //[Test]
        //public void SessionsTests()
        //{
        //    //Create.
        //    Assert.IsTrue(DaoFactory.GetSession().CreateAsync(new Session("newSession", DateTime.Now)).Result);
        //    //Is exists.
        //    Assert.IsNotNull(DaoFactory.GetSession().TryReadAsync(1).Result);
        //    //Is don't exists.
        //    Assert.IsNull(DaoFactory.GetSession().TryReadAsync(150).Result);
        //    //Update.
        //    Assert.IsTrue(DaoFactory.GetSession().UpdateAsync(new Session(1,"newSessionUpdate", DateTime.Now)).Result);
        //    //Update if don't exists.
        //    Assert.IsFalse(DaoFactory.GetSession().UpdateAsync(new Session(150,"newSessionUpdate", DateTime.Now)).Result);
        //    //Delete.
        //    Assert.IsTrue(DaoFactory.GetSession().DeleteAsync(3).Result);
        //    //Delete if don't exists.
        //    Assert.IsFalse(DaoFactory.GetSession().DeleteAsync(150).Result);
        //    //Read All
        //    Assert.IsNotNull(DaoFactory.GetSession().ReadAllAsync().Result);
        //}

        [Test]
        public void StudentsTests()
        {
            //Create.
            Assert.IsTrue(DaoFactory.GetStudent().CreateAsync(new Student("Ivan", "Ivanov",1, DateTime.Now, 1, 1, 1)).Result);
            //Is exists.
            Assert.IsNotNull(DaoFactory.GetStudent().TryReadAsync(1).Result);
            //Is don't exists.
            Assert.IsNull(DaoFactory.GetStudent().TryReadAsync(150).Result);
            //Update.
            Assert.IsTrue(DaoFactory.GetStudent().UpdateAsync(new Student(1, "Petr", "Ivanov", 1, DateTime.Now, 1, 1, 1)).Result);
            //Update if don't exists.
            Assert.IsFalse(DaoFactory.GetStudent().UpdateAsync(new Student(150, "Petr", "Ivanov", 1, DateTime.Now, 1, 1, 1)).Result);
            //Delete.
            Assert.IsTrue(DaoFactory.GetStudent().DeleteAsync(3).Result);
            //Delete if don't exists.
            Assert.IsFalse(DaoFactory.GetStudent().DeleteAsync(150).Result);
            //Read All
            Assert.IsNotNull(DaoFactory.GetStudent().ReadAllAsync().Result);
        }

        [Test]
        public void SubjectsTests()
        {
            //Create.
            Assert.IsTrue(DaoFactory.GetSubject().CreateAsync(new Subject("NewSubjects")).Result);
            //Is exists.
            Assert.IsNotNull(DaoFactory.GetSubject().TryReadAsync(1).Result);
            //Is don't exists.
            Assert.IsNull(DaoFactory.GetSubject().TryReadAsync(4).Result);
            //Update.
            Assert.IsTrue(DaoFactory.GetSubject().UpdateAsync(new Subject(3, "UpdateNewSubjects")).Result);
            //Update if don't exists.
            Assert.IsFalse(DaoFactory.GetSubject().UpdateAsync(new Subject(4, "Update")).Result);
            //Delete.
            Assert.IsTrue(DaoFactory.GetSubject().DeleteAsync(3).Result);
            //Delete if don't exists.
            Assert.IsFalse(DaoFactory.GetSubject().DeleteAsync(4).Result);
            //Read All
            Assert.IsNotNull(DaoFactory.GetSubject().ReadAllAsync().Result);
        }

        [Test]
        public void TestFormsTests()
        {
            //Create.
            Assert.IsTrue(DaoFactory.GetTestForm().CreateAsync(new TestForm("NewTestForm")).Result);
            //Is exists.
            Assert.IsNotNull(DaoFactory.GetTestForm().TryReadAsync(1).Result);
            //Is don't exists.
            Assert.IsNull(DaoFactory.GetTestForm().TryReadAsync(4).Result);
            //Update.
            Assert.IsTrue(DaoFactory.GetTestForm().UpdateAsync(new TestForm(3, "UpdateNewTestForm")).Result);
            //Update if don't exists.
            Assert.IsFalse(DaoFactory.GetTestForm().UpdateAsync(new TestForm(4, "Update")).Result);
            //Delete.
            Assert.IsTrue(DaoFactory.GetTestForm().DeleteAsync(3).Result);
            //Delete if don't exists.
            Assert.IsFalse(DaoFactory.GetTestForm().DeleteAsync(4).Result);
            //Read All
            Assert.IsNotNull(DaoFactory.GetTestForm().ReadAllAsync().Result);
        }

    }
}