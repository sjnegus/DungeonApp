using DungeonLibrary;
using Xunit;

namespace DungeonTests
{
    public class DungeonTests
    {
        [Fact]
        public void Test_Combat()
        {
            

        }
    }

    internal class Calculator
    {
        internal static int Arithmetic(int a, char op, int b)
        {
            if (op == '+')
            {
                return a + b;
            }
            if (op == '-')
            {
                return a - b;
            }
            if (op == '*')
            {
                return a * b;   
            }
            if (op == '/')
            {
                return a / b;
            }
            else
            {
                throw new ArgumentException($"{op} is an invalid operator.");
            }
        }
    }
}