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

        [TestMethod]
        public void CustomList_ToString_ConvertingIntToString()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            string expected = "1";
            string actual;
            int number1 = 1;


            //act
            list1.Add(number1);
            actual = list1.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_ToString_ConvertingFiveIntsToString()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            string expected = "12345";
            string actual;
            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            int number4 = 4;
            int number5 = 5;

            //act
            list1.Add(number1);
            list1.Add(number2);
            list1.Add(number3);
            list1.Add(number4);
            list1.Add(number5);
            actual = list1.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_ToString_Converting()
        {
            //arrange
            CustomList<char> list1 = new CustomList<char>();
            string expected = "Flamingo";
            string actual;
            char character1 = 'F';
            char character2 = 'l';
            char character3 = 'a';
            char character4 = 'm';
            char character5 = 'i';
            char character6 = 'n';
            char character7 = 'g';
            char character8 = 'o';


            //act
            list1.Add(character1);
            list1.Add(character2);
            list1.Add(character3);
            list1.Add(character4);
            list1.Add(character5);
            list1.Add(character6);
            list1.Add(character7);
            list1.Add(character8);
            actual = list1.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_OverLoadPlus_CombineTwoIntLists()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> actual;
            string expected = (12345678).ToString();
           
            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            int number4 = 4;
            int number5 = 5;
            int number6 = 6;
            int number7 = 7;
            int number8 = 8;



            //act
            list1.Add(number1);
            list1.Add(number2);
            list1.Add(number3);
            list1.Add(number4);
            list2.Add(number5);
            list2.Add(number6);
            list2.Add(number7);
            list2.Add(number8);
            actual = list1 + list2;


            //assert
            //CollectionAssert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void CustomList_OverLoadPlus_CombineTwoCharLists()
        {
            //arrange
            CustomList<char> list1 = new CustomList<char>();
            CustomList<char> list2 = new CustomList<char>();
            CustomList<char> actual;
            string expected = "Banana";

            char character1 = 'B';
            char character2 = 'a';
            char character3 = 'n';
            char character4 = 'a';
            char character5 = 'n';
            char character6 = 'a';
            



            //act
            list1.Add(character1);
            list1.Add(character2);
            list1.Add(character3);
            list1.Add(character4);
            list2.Add(character5);
            list2.Add(character6);
            actual = list1 + list2;


            //assert
            //CollectionAssert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void CustomList_OverLoadMinus_RemoveSimilarIntsFromTwoLists()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> actual;
            string expected = "2";

            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            int number4 = 4;

            int number5 = 1;
            int number6 = 3;
            int number7 = 4;
            int number8 = 5;



            //act
            list1.Add(number1);
            list1.Add(number2);
            list1.Add(number3);
            list1.Add(number4);
            list2.Add(number5);
            list2.Add(number6);
            list2.Add(number7);
            list2.Add(number8);
            actual = list1 - list2;


            //assert
            CollectionAssert.AreEqual(expected, actual);
            //Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void CustomList_OverLoadMinus_RemoveSimilarIntsFromTwo()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> actual;
            int expected = 271;

            int number1 = 1;
            int number2 = 2;
            int number3 = 7;
            int number4 = 1;

            int number5 = 1;
            int number6 = 3;
            int number7 = 4;
            int number8 = 5;



            //act
            list1.Add(number1);
            list1.Add(number2);
            list1.Add(number3);
            list1.Add(number4);
            list2.Add(number5);
            list2.Add(number6);
            list2.Add(number7);
            list2.Add(number8);
            actual = list1 - list2;


            //assert
            CollectionAssert.AreEqual(expected, actual);
            //Assert.AreEqual(expected, actual);
        }

    }
}
