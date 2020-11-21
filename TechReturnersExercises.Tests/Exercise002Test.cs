// using System;
// using Xunit;
// using TechReturners.Exercises;
// using System.Collections;
// using System.Collections.Generic;


// namespace TechReturners.Tests
// {
//     public class Exercise002Test
//     {
//         [Fact]
//         public void CheckIsFromManchester()
//         {
//             Person p1 = new Person("Peter", "Smith", "Manchester", 23);
//             Person p2 = new Person("Susan", "Farmer", "Leeds", 23);
//             Assert.Equal(true, Exercise002.IsFromManchester(p1));
//             Assert.Equal(false, Exercise002.IsFromManchester(p2));
//         }

//         [Fact]
//         public void CheckCanWatchFilm()
//         {
//             Person p1 = new Person("Peter", "Smith", "Manchester", 17);
//             Person p2 = new Person("Susan", "Farmer", "Leeds", 18);
//             Assert.Equal(false, Exercise002.CanWatchFilm(p1));
//             Assert.Equal(true, Exercise002.CanWatchFilm(p2));
//         }
//     }
// }
