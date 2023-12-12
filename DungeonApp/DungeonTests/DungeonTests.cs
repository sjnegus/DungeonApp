using DungeonLibrary;
using Xunit;

namespace DungeonTests
{
    public class DungeonTests
    {
        [Fact]
        public void Test_DamageDealt()
        {

            // -- ARRANGE --

            Monster a = new()
            {
                MinDamage = 1,
                MaxDamage = 5
            };

            // -- ACT --

            int actual = a.CalcDamage();

            // -- ASSERT --
            
            Assert.InRange(actual, 1, 5);
        }
        [Fact]
        public void Test_HitChance()
        {
            // -- ARRANGE --

            Player a = new()
            {
                HitChance = 8
            };

            // -- ACT --

            int expected = 8;
            int actual = a.HitChance;

            // -- ASSERT --

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Test_Block()
        {
            // -- ARRANGE --

            Player a = new()
            {
                Block = 7
            };

            // -- ACT --

            int expected = 7;
            int actual = a.Block;

            // -- ASSERT --

            Assert.Equal(expected, actual);

        }

    }


}