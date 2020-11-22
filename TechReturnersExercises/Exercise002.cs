
namespace TechReturners.Exercises
{
    public class Exercise002
    {
        public static bool IsFromManchester(Person person)
        {
            return person.City == "Manchester";
        }

        public static bool CanWatchFilm(Person person, int ageLimit)
        {
            return person.Age >= ageLimit;
        }
    }
}
