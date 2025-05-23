namespace SearchTests
{
    internal interface IWebDriver
    {
        IWebElement FindElement(object value);
        object Navigate();
    }
}