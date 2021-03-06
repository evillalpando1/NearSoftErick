﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace NearSoft_interview
{
    class Utils
    {
        
            public static void AssertEqualString(string strExpectedResult, String strActualResult)
            {

                Assert.AreEqual(strExpectedResult, strActualResult);

            }

            public static void AssertIsPresent(IWebElement boolElement)
            {

                Assert.IsTrue(boolElement.Displayed);


            }



            public static void SendEnterKey(string field)
            {

            }



            public static Random random = new Random();
            public static string RandomString(int length)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                return new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
            }

        }
    }



