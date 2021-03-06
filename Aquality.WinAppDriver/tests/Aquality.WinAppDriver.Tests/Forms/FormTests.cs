﻿namespace Aquality.WinAppDriver.Tests.Forms
{
    public class FormTests : AbstractFormTests
    {
        protected override string ExpectedElementType => "Форма";

        protected override ICalculatorForm CalculatorForm { get; }

        protected override ITestForm TestForm { get; }

        public FormTests()
        {
            CalculatorForm = new CalculatorForm();
            TestForm = new TestForm(Locator, PageName);
        }
    }
}