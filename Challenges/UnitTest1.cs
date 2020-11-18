using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenges
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string name = "Supercalifragilisticexpialidocious";
            foreach (char letter in name)
            {
                Console.WriteLine(letter);
            }
        }
    

    [TestMethod]
    public void TestMethod2()
        {
            string name = "Supercalifragilisticexpialidocious";
            foreach (char letter in name)
            {
                if(letter == 'i')
                {
                    Console.WriteLine('i');
                }
                else
                {
                    Console.WriteLine("Not an i. ");
                }
            }

        }
        [TestMethod]
        public void TestMethod3()
        {
            string name = "Supercalifragilisticexpialidocious";
            int count = 0;
            for (int i = 0; i < name.Length; i++)
            {
                count++;
            }
            Console.WriteLine(count);
        }
