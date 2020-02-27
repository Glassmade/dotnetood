using Moq;
using System;
using NUnit.Framework;


namespace FizzBuzz.Tests
{
    [TestFixture]
    class SimpleMoqTests
    {

        Mock<MyMoqDatabase> mockedDatabase;

        [SetUp]
        public void Init()
        {
            mockedDatabase = new Mock<MyMoqDatabase>();
            
        }

        [TestCase]
        public void mockTest_MoqDatabaseGetID_ReturnsValue_number77_AsDefined()
        {
            int expectedID = 77;
            mockedDatabase.Setup(p => p.getUniqueId()).Returns(expectedID);
            int resultID = mockedDatabase.Object.getUniqueId();
            Assert.AreEqual(expectedID, resultID);
            mockedDatabase.VerifyAll();

        }

        [TestCase]
        public void mockTest_MoqDatabaseDeleteByID_ReturnsTheValue_number88_AsDeleted() 
        {
            mockedDatabase.Setup(x => x.deleteUserWithUniqeID(88)).Returns(88);
            int resultId = mockedDatabase.Object.deleteUserWithUniqeID(88);
            Assert.AreEqual(88, resultId);
        }

        [TestCase]
        public void mockTest_MoqDatabaseAsAnArgument_ReturnsNotImplementedException_OnConcreteMoqClass()
        {
            MyMoqClass mockedClass = new MyMoqClass();
            Assert.That(() => mockedClass.MyMoqClassDoesSomethingWith(mockedDatabase.Object), Throws.TypeOf<NotImplementedException>());

        }


    }
}

