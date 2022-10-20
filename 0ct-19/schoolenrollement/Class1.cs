using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using _0ct_19;



namespace schoolenrollement
{
    [TestFixture]
    public class Enroltest
    {
        [TestCase]
        public void IsTrueEnroll()
        {
            student s = new student();
            s.rollno = 420;
            s.studname = "sara";
            s.course = Course.DotNet;
            enrollment r = new enrollment();
            r.enrolno = 908;
            r.fees = 12000;
            studentenrollment er = new studentenrollment();
            bool k = er.enrollstudent(s, r);
            Assert.That(k);

        }
    }
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestMethod1()
        {
            //Act  
            StubExtensionManager stub = new StubExtensionManager();
            FileChecker checker = new FileChecker(stub);

            //Action  
            bool IsTrueFile = checker.CheckFile("myFile.whatever");

            //Assert  
            Assert.AreEqual(true, IsTrueFile);
        }
    }
    [TestFixture]
    public class UnitTest2
    {
        [TestCase]
        public void TestMethod1()
        {
            //Act  
            MockExtensionService mockobject = new MockExtensionService();
            //Inject mock object now  
            ExtensionAnalyzer analyzer = new ExtensionAnalyzer(mockobject);
            //Action  
            analyzer.ExtensionCheck("somefile.someextension");

            //Assert  
            Assert.AreEqual(mockobject.ErrorMessage, "Wrong Type");
        }
    }

    internal class ExtensionAnalyzer
    {
        private MockExtensionService mockobject;

        public ExtensionAnalyzer(MockExtensionService mockobject)
        {
            this.mockobject = mockobject;
        }

        internal void ExtensionCheck(string v)
        {
            throw new NotImplementedException();
        }
    }

    internal class MockExtensionService
    {
        internal double ErrorMessage;
    }
}

    
