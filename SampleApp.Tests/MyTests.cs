using HtmlAgilityPack;
using Microsoft.AspNetCore.Components.Testing;
using SampleApp.Pages;
using System;
using Xunit;

namespace SampleApp.Tests
{
    public class MyTests
    {
        private TestHost host = new TestHost();

        [Fact]
        public void RadzenButton()
        {
            var component = host.AddComponent<Pages.Index>();
            string RadzenButtonValue() => component.Find("span").InnerText;
            HtmlNode radzenButton = component.Find("button");

            Assert.Equal("Hi!", RadzenButtonValue());

            radzenButton.Click();
            Assert.Equal("Bye", RadzenButtonValue());

            radzenButton.Click();
            Assert.Equal("Hi!", RadzenButtonValue());
        }
    }
}
