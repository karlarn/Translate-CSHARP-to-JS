using System;
using System.Collections.Generic;

namespace insulter
{
    class Program
    {
        static void Main(string[] args)
        {
            var insults = new List<string>()
            {
                "You look like what morning breath smells like.",
    "If you tried to give me cpr I would probably throw myself back under water",
    "I am not a fan of you",
    "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
    "I'd rather walk than be on the same plane as you",
    "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
    "Do you have to be so...like that?"
            };
            int numberOfInsults = insults.Count;
            List<int> index = new List<int>();
            while(index.Count<3)
            {
                int randomNumber = new Random().Next(numberOfInsults);
                if (index.Contains(randomNumber))
                {
                    randomNumber = new Random().Next(numberOfInsults);
                    index.Add(randomNumber);
                }
                else
                {
                    index.Add(randomNumber);
                }

            }
            foreach(var i in index)
            {
                Console.WriteLine(insults[i]);
            }
        }
    }
}
