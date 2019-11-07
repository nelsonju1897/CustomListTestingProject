using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void CustomList_Add_AddingOneValueCount()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            int expected = 1;
            int actual;
            int number1 = 5;

            //act
            list1.Add(number1);
            actual = list1.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Add_AddingFiveValueArrayResize()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            int expected = 5;
            int actual;
            int number1 = 5;
            int number2 = 5;
            int number3 = 5;
            int number4 = 5;
            int number5 = 5;

            //act
            list1.Add(number1);
            list1.Add(number2);
            list1.Add(number3);
            list1.Add(number4);
            list1.Add(number5);
            actual = list1.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Add_AddingOneStringIndicesCheck()
        {
            //arrange
            CustomList<string> list1 = new CustomList<string>();
            string expected = "string1";
            string actual;
            string string1 = "string1";

            //act
            list1.Add(string1);
            actual = list1[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Add_AddingTrueBool()
        {
            //arrange
            CustomList<bool> list1 = new CustomList<bool>();
            bool expected = true;
            bool actual;
            bool true1 = true;

            //act
            list1.Add(true1);
            actual = list1[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Add_AddingTwoDouble()
        {
            //arrange
            CustomList<double> list1 = new CustomList<double>();
            double expected = 8.1;
            double actual;
            double double1 = 4.5;
            double double2 = 3.6;

            //act
            list1.Add(double1 + double2);
            actual = list1[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Remove_RemovingOneValueCount()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            int expected = 0;
            int actual;
            int number1 = 5;

            //act
            list1.Add(number1);
            list1.Remove(number1);
            actual = list1.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Remove_RemovingFiveValueArrayResize()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            int expected = 4;
            int actual;
            int number1 = 5;
            int number2 = 5;
            int number3 = 5;
            int number4 = 5;
            int number5 = 5;

            //act
            list1.Add(number1);
            list1.Add(number2);
            list1.Add(number3);
            list1.Add(number4);
            list1.Add(number5);
            list1.Remove(number3);
            actual = list1.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Remove_RemovingOneStringIndicesCheck()
        {
            //arrange
            CustomList<string> list1 = new CustomList<string>();
            string expected = "string4";
            string actual;
            string string1 = "string1";
            string string2 = "string2";
            string string3 = "string3";
            string string4 = "string4";
            string string5 = "string5";
            //act
            list1.Add(string1);
            list1.Add(string2);
            list1.Add(string3);
            list1.Add(string4);
            list1.Add(string5);
            list1.Remove(string3);
            actual = list1[2];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Remove_RemovingTrueBool()
        {
            //arrange
            CustomList<bool> list1 = new CustomList<bool>();
            bool expected = false;
            bool actual;
            bool true1 = true;
            bool true2 = false;
            bool true3 = true;
            bool true4 = true;

            //act
            list1.Add(true1);
            list1.Add(true2);
            list1.Add(true3);
            list1.Add(true4);
            list1.Remove(true1);
            actual = list1[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Remove_RemovingTwoDouble()
        {
            //arrange
            CustomList<double> list1 = new CustomList<double>();
            double expected = 5.5;
            double actual;
            double double1 = 1.1;
            double double2 = 2.2;
            double double3 = 3.3;
            double double4 = 4.4;

            //act
            list1.Add(double1 + double2);
            list1.Add(double3 + double4);
            list1.Add(double1 + double4);
            list1.Remove(double3 + double4);
            actual = list1[1];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Remove_RemovingValueBoolTrue()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            bool expected = true;
            bool actual;
            int number1 = 5;
            int number2 = 5;
            int number3 = 5;
            int number4 = 5;
            int number5 = 5;
            int number6 = 5;
            int number7 = 5;

            //act
            list1.Add(number1);
            list1.Add(number2);
            list1.Add(number3);
            list1.Add(number4);
            list1.Add(number5);
            list1.Add(number6);
            list1.Add(number7);
            list1.Remove(number7);
            actual = (list1[7] == 0);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
