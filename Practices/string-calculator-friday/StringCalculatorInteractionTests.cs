

using Moq;

namespace StringCalculator;

public class StringCalculatorInteractionTests
{

    [Theory]
    [InlineData("1, 2", "3")]
    [InlineData("1,2,3,4,5,6,7,8,9", "45")]
    public void AnswersAreLoggedToLogger(string numbers, string expected)
    {
        var mockedLogger = new Mock<ILogger>();
        var mockedWebService = new Mock<IWebService>();
        var calculator = new StringCalculator(mockedLogger.Object, mockedWebService.Object);


        calculator.Add(numbers);


        mockedLogger.Verify(logger => logger.Write(expected), Times.Once);
        mockedWebService.Verify(ws => ws.NotifyOfFailedLogging(It.IsAny<string>()), Times.Never);
        //  I need to verify (assert) that the logger was called with the expected value!

    }

    [Theory]
    [InlineData("Blammo!")]
    [InlineData("Taco Bell")]
    public void WhenLoggerBlowsUpTheWebServiceIsCalled(string expected)
    {
        // Given
        var stubbedLogger = new Mock<ILogger>();
        stubbedLogger.Setup(m => m.Write(It.IsAny<string>())).Throws(new LoggerException(expected));
        var mockedWebService = new Mock<IWebService>();
        var calculator = new StringCalculator(stubbedLogger.Object, mockedWebService.Object);         // When
        calculator.Add("1");

        mockedWebService.Verify(ws => ws.NotifyOfFailedLogging(expected));
    }


}
