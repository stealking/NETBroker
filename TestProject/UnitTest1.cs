using Core.Extensions;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("2023-12-01", DayOfWeek.Friday)]
        [TestCase("2023-12-24", DayOfWeek.Monday)]
        public void GetDateOfLastWeekOfDay(DateTime date, DayOfWeek dayOfWeek)
        {
            var d = ĐateTimeExtensions.GetLastWeekday(date, dayOfWeek);
            Assert.That(d.DayOfWeek, Is.EqualTo(dayOfWeek));
        }
    }
}