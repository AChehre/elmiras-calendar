using TestStack.BDDfy;
using Xunit;

namespace ElmiraCalendar.Tests
{

    // TODO: change project name to Elmira Calendar

    [Story(
              Title = "Getting persian date time",
              AsA = "As a client user",
              IWant = "I want to get persian date from every date time ",
              SoThat = "So I can use that in my application")]
    public class GetPersianDateFromGregorianDateStory
    {
        [Fact]
        public void GetPersianDateScenario()
        {
            var exampleTable = new ExampleTable("ConvertUrl","GregorianDate", "PersianDate")
            {
                {"convert","1985/01/01", "01/01/01"},
                {"convert","1985/01/01", "01/01/02"},
            };

            new GetPersianDateScenario().WithExamples(exampleTable)
                .WithTags("Tag1").BDDfy<GetPersianDateFromGregorianDateStory>();
        }
    }
}