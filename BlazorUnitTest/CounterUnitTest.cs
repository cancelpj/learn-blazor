using BlazorApp.Pages;
using Bunit;
using Xunit;
using static Bunit.ComponentParameterFactory;

namespace BlazorUnitTest
{
    public class CounterUnitTest : TestContext
    {
        [Fact]
        public void Counter_OnBtnClicked()
        {
            // Arrange
            IRenderedComponent<Counter> cut = RenderComponent<Counter>();
            AngleSharp.Dom.IElement paraElm = cut.Find("p");

            // Act
            cut.Find("button").Click();
            string paraElmText = paraElm.TextContent;

            // Assert
            paraElmText.MarkupMatches("Current count: 1");
        }

        [Theory]
        [InlineData(null, 1)]
        [InlineData(1, 1)]
        [InlineData(0, 0)]
        [InlineData(3, 3)]
        //[InlineData("a", 0)]
        public void Counter_OnBtnClickedWithParameter(object input, int output)
        {
            // Arrange
            Bunit.Rendering.ComponentParameter componentParameter = Parameter("IncrementAment", input);
            IRenderedComponent<Counter> cut = RenderComponent<Counter>(componentParameter);
            AngleSharp.Dom.IElement paraElm = cut.Find("p");

            // Act
            cut.Find("button").Click();
            string paraElmText = paraElm.TextContent;

            // Assert
            paraElmText.MarkupMatches("Current count: " + output.ToString());
        }

        [Fact]
        public void Index_OnBtnClicked()
        {
            // Arrange
            IRenderedComponent<Index> cut = RenderComponent<Index>();
            AngleSharp.Dom.IElement paraElm = cut.Find("p");

            // Act
            cut.Find("button").Click();
            string paraElmText = paraElm.TextContent;

            // Assert
            paraElmText.MarkupMatches("Current count: 10");
        }

    }
}
