﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace Golem.Framework
{
    public class ByE
    {
        public static By Text(string text)
        {
            return By.XPath("//*[text()='" + text + "']");
        }
        public static By PartialText(string text)
        {
            return By.XPath("//*[contains(text(),'"+text+"')]");
        }

        public static By PartialAttribute(string tag, string attribute, string value)
        {
            return By.XPath(string.Format("//{0}[contains({1},'{2}')]", tag, attribute, value));
        }

    }
}
