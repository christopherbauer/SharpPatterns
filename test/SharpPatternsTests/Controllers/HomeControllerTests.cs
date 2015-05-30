using System.Web.Mvc;
using NUnit.Framework;
using SharpPatterns.Controllers;

namespace SharpPatternsTests.Controllers
{
    class HomeControllerTests
    {
        [TestFixture]
        public static class when_getting_index
        {
            [Test]
            public static void then_should_return_view()
            {
                // Arrange
                var controller = new HomeController();

                // Act
                var viewResult = controller.Index();

                // Assert
                Assert.That(viewResult, Is.TypeOf(typeof(ViewResult)));
            }
        }
    }
}
