using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void GetTest1()
        {
            int[] nums = { 1, 3, 3, 6, 7 };
            string massage = Logic.Mas(nums, 5);
            Assert.AreEqual("Индексы пары: 1 и 2", massage);
        }
        [TestMethod()]
        public void Getest2()
        {
            int[] nums = { 1, 2, 3, 3, 3 };
            string massage = Logic.Mas(nums, 5);
            Assert.AreEqual("Индексы пары: 2 и 3", massage);
        }
        [TestMethod()]
        public void GetTest3()
        {
            int[] nums = { 1, 1, 3, 3, 3 };
            string massage = Logic.Mas(nums, 5);
            Assert.AreEqual("Индексы пары: 0 и 1", massage);
        }
        [TestMethod()]
        public void GetTest4()
        {
            int[] nums = { 1, 0, 3, 6, 9 };
            string massage = Logic.Mas(nums, 5);
            Assert.AreEqual("Нет такой пары чисел в последовательности", massage);
        }
        [TestMethod()]
        public void GetTest5()
        {
            int[] nums = { 1, 8, 0, 2, 9 };
            string massage = Logic.Mas(nums, 5);
            Assert.AreEqual("Нет такой пары чисел в последовательности", massage);
        }
    }
}