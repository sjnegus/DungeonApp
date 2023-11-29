using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DungeonLibrary
{
    public class TitleIntro
    {
        /// <summary>
        /// Title of the game goes here
        /// </summary>
        /// <param name="title"></param>
        public static void Header(string title)
        {

            Console.Title = "*.*.* " + title + " *.*.*";
        }
        /// <summary>
        /// Intro to the game
        /// </summary>
        /// <param name="intro"></param>
        public static void Intro(string intro)
        {
            string Intro = "Will you be the hero this world needs?\nPlease help us!!!";
        }

    }
}
