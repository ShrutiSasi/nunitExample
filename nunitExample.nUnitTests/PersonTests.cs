using System.Runtime.CompilerServices;

namespace nunitExample.nUnitTests
{
    public class PersonTests
    {
        public Person person { get; set; } = null!; //null forgiving operator
        
        [SetUp]
        public void Setup()
        {
          person = new Person();
        }

        [TestCase("John","","Doe")]
        [TestCase("Richard", "W.", "Scott")]
        public void GetFullName_EqualTest(string fname, string mname, string lname)
        {
            //Assign
            person.Fname = fname;
            person.Mname = mname;
            person.Lname = lname;

            //Act
            string fullName = person.GetFullName();

            //Assert
            //Assert.Pass();
            Assert.That(string.Format("{0} {1} {2}",fname,mname,lname), Is.EqualTo(fullName));
        }

        [TestCase("John", "", "")]
        [TestCase("John", "Doe", "")]
        //[ExpectedException(typeof(MissingFieldException))] //not supported in NUnit 3 and above
        public void GetFullName_ExceptionTest(string fname, string mname, string lname)
        {
            //Assign
            person.Fname = fname;
            person.Mname = mname;
            person.Lname = lname;

            //Act
            string fullName = person.GetFullName();

            //Assert
            //Assert.Pass();
            Assert.That(()=>(string.Format("{0} {1} {2}", fname, mname, lname), Is.EqualTo(fullName)),Throws.TypeOf<MissingFieldException>());
        }
    }
}