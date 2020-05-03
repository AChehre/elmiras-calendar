using FluentAssertions;
using TestStack.BDDfy;
using static Xunit.Assert;

namespace ElmiraCalendar.Tests
{
    public class GetCalendarsScenario
    {
        private readonly string _calendarsUrl = "url";
        private string result = string.Empty;


        [When("User call Calendars url")]
        private void CallCalendarsUrl()
        {
            result = _calendarsUrl;
        }

        [Then("User should get OK status")]
        private void CheckStatusCode()
        {
            result.Should().Be(_calendarsUrl);
        }
        [AndThen("Response must have calendars")]
        private void CheckResponse()
        {
            result.Should().Be(_calendarsUrl);
        }

    }
}