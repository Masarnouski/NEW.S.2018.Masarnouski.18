using System;
using NUnit.Framework;

namespace Task1.Tests
{
    [TestFixture]
    class Task1
    {
        [Test]
        public void NameCheckerService_Arg_With_Numbers_Return_Exception()
        {
            SqlRepository repo = new SqlRepository();
            NameCheckerService service = new NameCheckerService(repo);
            Assert.Throws<ArgumentException> (()=>service.Verify("Eugene12"));
        }

        [Test]
        public void NameCheckerService_NullArg__Return_Exception()
        {
            SqlRepository repo = new SqlRepository();
            NameCheckerService service = new NameCheckerService(repo);
            Assert.Throws<ArgumentNullException>(() => service.Verify(null));
        }

        [Test]
        public void NameCheckerService_CheckArg__Succeed()
        {
            SqlRepository repo = new SqlRepository();
            NameCheckerService service = new NameCheckerService(repo);
            Tuple<bool,string> result = service.Verify("Eugene");
            Tuple<bool, string> expectedResult = Tuple.Create(true, "Name is Ok. User was created");
            Assert.AreEqual(result,expectedResult);
        }

        [Test]
        public void NameCheckerService_Length_Bigger_Then_15__Succeed()
        {
            SqlRepository repo = new SqlRepository();
            NameCheckerService service = new NameCheckerService(repo);
            Tuple<bool, string> result = service.Verify("Eugene Masarnouski Vitalevich");
            Tuple<bool, string> expectedResult = Tuple.Create(false, "Eugene Masarnouski Vitalevich length too long");
            Assert.AreEqual(result, expectedResult);
        }


    }
}
