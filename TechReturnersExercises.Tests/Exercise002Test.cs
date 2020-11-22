using Xunit;
using TechReturners.Exercises;

namespace TechReturners.Tests
{
    public class Exercise002Test
    {
        [Fact]
        public void CheckIsFromManchester()
        {
            Person p1 = new Person("Peter", "Smith", "Manchester", 23);
            Person p2 = new Person("Susan", "Farmer", "Leeds", 23);
            Assert.True(Exercise002.IsFromManchester(p1));
            Assert.False(Exercise002.IsFromManchester(p2));
        }

        [Fact]
        public void CheckCanWatchFilm()
        {
            Person p1 = new Person("Peter", "Smith", "Manchester", 17);
            Person p2 = new Person("Susan", "Farmer", "Leeds", 18);
            Assert.False(Exercise002.CanWatchFilm(p1, 18));
            Assert.True(Exercise002.CanWatchFilm(p2, 15));
        }
    }
}
