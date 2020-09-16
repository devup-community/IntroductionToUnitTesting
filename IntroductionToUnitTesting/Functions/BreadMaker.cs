using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroductionToUnitTesting.Functions
{
    public class BreadMaker
    {
        public static int MakeBread(Ingredients ingredients)
        {
            var yeastCount = ingredients.Yeast / 1;
            var waterCount = ingredients.Water / 1;
            var flourCount = ingredients.Flour / 1;
            var saltCount = ingredients.Salt / 1;

            var maxBread = new List<double>();
            maxBread.Add(yeastCount);
            maxBread.Add(waterCount);
            maxBread.Add(flourCount);
            maxBread.Add(saltCount);

            var orderedList = maxBread.OrderBy(d => d);

            return (int)orderedList.First();
        }
    }
}
