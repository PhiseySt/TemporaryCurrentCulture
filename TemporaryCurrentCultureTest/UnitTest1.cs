using System.Globalization;
using TemporaryCurrentCulture;
using Xunit;

namespace TemporaryCurrentCultureTest
{
    public class UnitTest1
    {
        [Fact]
        void TestChangeOfCurrency()
        {
            using (new TemporaryThreadCulture(new CultureInfo("it-it")))
            {
                var euro = CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol;
                Assert.Equal(euro, "ˆ");

                using (new TemporaryThreadCulture(new CultureInfo("en-us")))
                {
                    var dollar = CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol;

                    Assert.NotEqual(euro, dollar);
                }
                Assert.Equal(euro, "ˆ");
            }
        }
    }
}