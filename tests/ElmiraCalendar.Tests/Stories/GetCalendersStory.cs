using TestStack.BDDfy;
using Xunit;

namespace ElmiraCalendar.Tests.Stories
{
    [Story(
              Title = "Getting calendars",
              AsA = "As a client user",
              IWant = "I want to get all calendars" ,
              SoThat = "So I can use one of them as my base calendar")]
    public class GetCalendarsStory
    {
        [Fact]
        public void GetCalendars()
        {
            new GetCalendarsScenario().BDDfy<GetCalendarsStory>();
        }
    }
}
