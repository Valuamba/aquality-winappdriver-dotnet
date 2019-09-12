﻿using Aquality.WinAppDriver.Applications;
using Aquality.WinAppDriver.Tests.Applications.Locators;
using NUnit.Framework;

namespace Aquality.WinAppDriver.Tests.Applications
{
    public class CalculatorTest : TestWithApplication
    {
        [Test]
        public void Should_WorkWithCalculator()
        {
            ApplicationManager.Application.Driver.FindElement(CalculatorWindow.OneButton).Click();
            ApplicationManager.Application.Driver.FindElement(CalculatorWindow.PlusButton).Click();
            ApplicationManager.Application.Driver.FindElement(CalculatorWindow.TwoButton).Click();
            ApplicationManager.Application.Driver.FindElement(CalculatorWindow.EqualsButton).Click();
            var result = ApplicationManager.Application.Driver.FindElement(CalculatorWindow.ResultsLabel).Text;
            StringAssert.Contains("3", result);
        }
    }
}
