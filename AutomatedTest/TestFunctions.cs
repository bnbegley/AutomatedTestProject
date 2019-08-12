using NUnit.Framework;
using AutomatedTestLibrary;
namespace Tests
{
    public class TestFunctions

    {
        Functions functions = null;
        [SetUp] //this setup method will be called first before any other methods 
        public void Setup()
        { functions = new Functions();
        }

        [Test]
        public void TestAdd1()
        {

            var answer = functions.Add1(0);
            Assert.AreEqual(1, answer);
            answer = functions.Add1(-1);
            Assert.AreEqual(0, answer);
        }
        [Test]
        public void TestXSquaredPlus3()
        {
            var ans = functions.XSquaredPlus3(0);
            Assert.AreEqual(3, ans);

            ans = functions.XSquaredPlus3(3);
            Assert.AreEqual(12, ans);

            ans = functions.XSquaredPlus3(2);
            Assert.AreEqual(7, ans);

            ans = functions.XSquaredPlus3(4);
            Assert.AreEqual(19, ans);

            ans = functions.XSquaredPlus3(5);
            Assert.AreNotEqual(7, ans);
        }
        [Test]
        public void X7X12() {
            var ans = functions.X7X12(2);
            Assert.AreEqual(11, ans);

            ans = functions.X7X12(7);
            Assert.AreEqual(61, ans);

            ans = functions.X7X12(8);
            Assert.AreEqual(77, ans);

            ans = functions.X7X12(0);
            Assert.AreEqual(5, ans);

            ans = functions.X7X12(-3);
            Assert.AreEqual(11, ans);

            Assert.AreNotEqual(20, functions.X7X12(-1));

        }
                

        }
    }
