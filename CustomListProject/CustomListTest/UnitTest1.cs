using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
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

        //public void CustomList_Add_AddingOneStringIndicesCheck()
        //{
        //    //arrange
        //    CustomList<string> list1 = new CustomList<string>();
        //    string expected = "string1";
        //    string actual;
        //    string string1 = "string1";

        //    //act
        //    list1.Add(string1);
        //    actual = list1[0];

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}

        //public void CustomList_Add_AddingTrueBool()
        //{
        //    //arrange
        //    CustomList<bool> list1 = new CustomList<bool>();
        //    bool expected = true;
        //    bool actual;
        //    bool true1 = true;

        //    //act
        //    list1.Add(true1);
        //    actual = list1[0];

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}

        //public void CustomList_Add_AddingTwoDouble()
        //{
        //    //arrange
        //    CustomList<double> list1 = new CustomList<double>();
        //    double expected = 8.1;
        //    double actual;
        //    double double1 = 4.5;
        //    double double2 = 3.6;

        //    //act
        //    list1.Add(double1 + double2);
        //    actual = list1[0];

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}


    }
}
