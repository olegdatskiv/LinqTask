using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Linq;
using System.IO;
using System.Reflection;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestFirstGroupTask1()
        {
            //Arrange
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TestFirstGroupTask1.txt");
            string path2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"AnswersFirstGroupTask1.txt");

            //Act
            var result = FirstGroup.Task1(path);
            List<int> list = new List<int>();
            int number = 0;
            string[] array = File.ReadAllText(path2).Split(' ');
            foreach (var it in array)
            {
                if (Int32.TryParse(it, out number))
                {
                    list.Add(number);
                    Console.WriteLine(number);
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} is not number", it));
                }
            }

            //Assert
            CollectionAssert.AreEqual(list, result);
        }

        [TestMethod]
        public void TestFirstGroupTask2()
        {
            //Arrange
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TestFirstGroupTask2.txt");
            string path2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"AnswersFirstGroupTask2.txt");

            //Act
            var result = FirstGroup.Task2(path);
            List<int> list = new List<int>();
            int number = 0;
            string[] array = File.ReadAllText(path2).Split(' ');
            foreach (var it in array)
            {
                if (Int32.TryParse(it, out number))
                {
                    list.Add(number);
                    Console.WriteLine(number);
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} is not number", it));
                }
            }

            //Assert
            CollectionAssert.AreEqual(list, result);
        }

        [TestMethod]
        public void TestFirstGroupTask3()
        {
            //Arrange
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TestFirstGroupTask3.txt");
            string path2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"AnswersFirstGroupTask3.txt");

            //Act
            var result = FirstGroup.Task3(path);
            List<int> list = new List<int>();
            int number = 0;
            string[] array = File.ReadAllText(path2).Split(' ');
            foreach (var it in array)
            {
                if (Int32.TryParse(it, out number))
                {
                    list.Add(number);
                    Console.WriteLine(number);
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} is not number", it));
                }
            }

            //Assert
            CollectionAssert.AreEqual(list, result);
        }

        [TestMethod]
        public void TestFirstGroupTask4()
        {
            //Arrange
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TestFirstGroupTask4.txt");
            string path2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"AnswersFirstGroupTask4.txt");

            //Act
            var result = FirstGroup.Task4(path);
            string[] array = File.ReadAllText(path2).Split(' ');
            List<string> list = new List<string>(array);

            //Assert
            CollectionAssert.AreEqual(list, result);
        }

        [TestMethod]
        public void TestFirstGroupTask5()
        {
            //Arrange
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TestFirstGroupTask5.txt");
            string path2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"AnswersFirstGroupTask5.txt");

            //Act
            var result = FirstGroup.Task5(path);
            List<int> list = new List<int>();
            int number = 0;
            string[] array = File.ReadAllText(path2).Split(' ');
            foreach (var it in array)
            {
                if (Int32.TryParse(it, out number))
                {
                    list.Add(number);
                    Console.WriteLine(number);
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} is not number", it));
                }
            }

            //Assert
            CollectionAssert.AreEqual(list, result);
        }

        [TestMethod]
        public void TestSecondGroupTask1()
        {
            //Arrange
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TestSecondGroupTask1.txt");
            string path2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"AnswersSecondGroupTask1.txt");

            //Act
            var result = SecondGroup.Task1(path);
            List<int> list = new List<int>();
            int number = 0;
            string[] array = File.ReadAllText(path2).Split(' ');
            foreach (var it in array)
            {
                if (Int32.TryParse(it, out number))
                {
                    list.Add(number);
                    Console.WriteLine(number);
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} is not number", it));
                }
            }

            //Assert
            CollectionAssert.AreEqual(list, result);
        }


        [TestMethod]
        public void TestSecondGroupTask2()
        {
            //Arrange
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TestSecondGroupTask2.txt");
            string path2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"AnswersSecondGroupTask2.txt");

            //Act
            var result = SecondGroup.Task2(path);
            List<string> list = new List<string>();
            string[] array = File.ReadAllText(path2).Split(' ');
            foreach (var it in array)
            {
                list.Add(it);
            }

            //Assert
            CollectionAssert.AreEqual(list, result);
        }

        [TestMethod]
        public void TestThirdGroupTask()
        {
            //Arrange
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TestThridGroupTask.txt");
            string path2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"AnswersThridGroupTask.txt");
            string path3 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"ThridGroupTask.txt");

            //Act
            ThirdGroup.Task(path, path3);
            string result = File.ReadAllText(path3);
            string expected = File.ReadAllText(path2);
            //Assert

            Assert.AreEqual(expected.ToString(), result.ToString());
        }
    }
}
