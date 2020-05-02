using FluentAssertions;
using TestStack.BDDfy;
using static Xunit.Assert;

namespace ElmiraCalendar.Tests
{
    public class GetPersianDateScenario
    {
        private string _convertUrl;
        private string _gregorianDate;
        private string _persianDate;


        [Given("I pass <GregorianDate> as Gregorian date")]
        private void i_pass_parameter_as_gregorian_date(string gregorianDate)
        {
            _gregorianDate = gregorianDate;
        }

        [When("I call <ConvertUrl> url")]
        private void i_call_convert_to_persian_url(string convertUrl)
        {
            _convertUrl = convertUrl;
        }

        [Then("It should give me the <PersianDate> as persian time")]
        private void it_should_give_me_the_persian_time(string persianDate)
        {
            _persianDate = persianDate;

            Equal("convert", _convertUrl);
            Equal("1985/01/01", _gregorianDate);
            _persianDate.Should().Be("01/01/01");
        }
    }
}