using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo_Console;
using Todo;

namespace Todo_Console_Tests
{
    [TestClass]
    public class TodoConsoleTest
    {
        // TODO: Develop tests for the Todo console app.
        // See .A1-Todo-console.md.html

        [TestMethod]
        public void TestMethod1()
        {
            test(@"1
discription
7
", null);
        }

        [TestMethod]
        public void TestMethod2()
        {
            test(@"1
discription
2
1
new discription
7
", null);
        }
        
        [TestMethod]
        public void TestMethod3()
        {
            test(@"1
discription
3
1
7
", null);
        }

        [TestMethod]
        public void TestMethod4()
        {
            test(@"1
discription
4
1
7
", null);
        }

        [TestMethod]
        public void TestMethod5()
        {
            test(@"1
discription
3
1
5
yes
7
", null);
        }

        [TestMethod]
        public void TestMethod6()
        {
            test(@"1
discription
6
1
7
", null);
        }

        [TestMethod]
        public void TestMethod7()
        {
            test(@"1
discription
6
2
7
", null);
        }

        [TestMethod]
        public void TestMethod8()
        {
            test(@"1
discription
3
1
6
3
7
", null);
        }

        [TestMethod]
        public void TestMethod10()
        {
            test(@"1
discription
1
another discription
4
1
7
", null);
        }

        [TestMethod]
        public void TestMethod11()
        {
            test(@"1
discription
1
another discription
3
1
3
2
7
", null);
        }

        [TestMethod]
        public void TestMethod12()
        {
            test(@"1
discription
1
another discription
6
2
7
", null);
        }

        [TestMethod]
        public void TestMethod13()
        {
            test(@"1
discription
3
1
6
3
7
", null);
        }
        [TestMethod]
        public void TestMethod14()
        {
            test(@"1
discription
1
dis
3
1
5
yes
7
", null);
        }

        [TestMethod]
        public void TestMethod15()
        {
            test(@"1
discription
3
1
7
", null);
        }
        

        // test utility method to run the prime tool app with
        // a string script as input
        void test(string script, string expectedOutput)
        {
            // save default Console.Out and Console.In
            TextWriter cout = Console.Out;
            TextReader cin = Console.In;

            // redirect Console.Out to a StringWriter (buffer)
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            // set script as the app Console.In
            StringReader sr = new StringReader(script);
            Console.SetIn(sr);

            // call the console app
            Todo_Console.Program.Main(new string[0]);

            // restore default Console.Out and Console.In
            Console.SetOut(cout);
            Console.SetIn(cin);

            // close resources
            sw.Close();
            sr.Close();

            // get the actual ouput
            // if the expected output is null,
            //    then the test simply prints out the actual output (for debugging)
            // otherwise, it asserts that the expected output is equal to the actual ouput
            string actualOutput = sw.ToString();
            if (expectedOutput == null)
            {
                Console.Write(actualOutput);
            }
            else
            {
                Assert.AreEqual(expectedOutput, actualOutput);
            }
        }
        
    }
}
