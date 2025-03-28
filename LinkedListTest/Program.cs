using System.Collections.Generic;
using System.Security.Principal;
using LinkedListSpace;
using NUnit.Framework;

namespace LinkedListTests
{
    [TestFixture] // Says this class contains tests
    public class LinkedListTests
    {
        public LinkedList? list; //Preparing object

        [SetUp] // This meathod is executed before each test run
        public void Setup()
        {
            list = new LinkedList();
        }

        [TearDown] // This methode is ran after every test run
        public void TearDown()
        {
            list = null;
        }

        [Test]
        public void Test1()
        {
            Assert.Pass(); // always passes
        }

        //testing Every meathod from "Linked List"
        [Test]
        public void Test_AddFirst()
        {

            list!.AddFirst("Joe Blow");
            list!.AddFirst("Joe Schmoe");
            list!.AddFirst("John Smith");
            list!.AddFirst("Jane Doe");

            Assert.That("Jane Doe", Is.EqualTo(list!.GetValue(0)));
        }

        [Test]
        public void Test_AddLast()
        {
            list!.AddLast("Bob Bobberson");
            list!.AddLast("Sam Sammerson");
            list!.AddLast("Dave Daverson");

            Assert.That("Dave Daverson", Is.EqualTo(list!.GetValue(2)));
        }

        [Test]
        public void Test_RemoveFirst()
        {
            list!.AddLast("Bob Bobberson");
            list!.AddLast("Sam Sammerson");
            list!.AddLast("Dave Daverson");

            list!.RemoveFirst();
            list!.RemoveFirst();
            System.Console.WriteLine(list!.GetValue(0));
            Assert.That("Dave Daverson", Is.EqualTo(list!.GetValue(0)));
        }

        [Test]
        public void Test_RemoveLast()
        {
            list!.AddLast("Bob Bobberson");
            list!.AddLast("Sam Sammerson");
            list!.AddLast("Dave Daverson");
            list!.RemoveLast();
            list!.RemoveLast();

            Assert.That("Bob Bobberson", Is.EqualTo(list!.GetValue(0)));
        }

        [Test]
        public void Test_GetValue()
        {
            list!.RemoveLast();
            list!.RemoveLast();
            list!.AddFirst("Sam Sammerson");
            Assert.That("Sam Sammerson", Is.EqualTo(list!.GetValue(0)));
        }

        //Tests the size of the list
        [Test]
        public void Test_GetListSize()
        {
            list!.AddFirst("Joe Blow");
            list!.AddFirst("Joe Schmoe");
            list!.AddFirst("John Smith");

            Assert.That(3, Is.EqualTo(list!.Count));
        }
    }
}