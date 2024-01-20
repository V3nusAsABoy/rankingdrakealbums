

using System.ComponentModel;
using System.Data;

// data for each album

album NothingWasTheSame = new album("nothing was the same", 1);
album TakeCare = new album("take care", 1);
album FatD = new album("for all the dogs", 1);
album Scorpion = new album("scorpion", 1);
album ThankMeLater = new album("thank me later", 1);
album SoFarGone = new album("so far gone", 1);
album IYRTITL = new album("if youre reading this its too late", 1);
album Views = new album("views", 1);
album MoreLife = new album("more life", 1);
album DLDT = new album("dark lane demo tapes", 1);
album CLB = new album("certified lover boy", 1);
album CarePackage = new album("care package", 1);
album HonestlyNevermind = new album("honestly nevermind", 1);
album YourLoss = new album("your loss", 1);
album WATTBA = new album("what a time to be alive", 1);

int answer = 0; // default int for user's answer

List<album> drakeAlbums = new List<album> { NothingWasTheSame, TakeCare, FatD, Scorpion, ThankMeLater, SoFarGone, IYRTITL, Views, MoreLife, DLDT, CLB, CarePackage, HonestlyNevermind, YourLoss, WATTBA }; // list of albums
List<string> names = new List<string> { "nothing was the same", "take care", "for all the dogs", "scorpion", "thank me later", "so far gone", "if youre reading this its too late", "views", "more life", "dark lane demo tapes", "certified lover boy", "care package", "honestly nevermind", "your loss", "what a time to be alive" }; // list of names to album. when an
// album gets picked over another album, the name of the other album gets added to its string. the loop checks if the name of the other album is added to the string to see if its been compared before

for (int i = 0; i < drakeAlbums.Count; i++) // for each album on the left to be compared to album on right.
{
    for(int j = 1; j < drakeAlbums.Count; j++) // for each album on right to be compared to album on the left
    {
        if (!(names[i].Contains(drakeAlbums[j].name) || (names[j].Contains(drakeAlbums[i].name)))) // this makes sure 2 albums being compared haven't already been compared
        {
            do
            {
                Console.Write(drakeAlbums[i].name + " or " + drakeAlbums[j].name + " (type 1 for the first option, 2 for the second): "); // text asking for input
                answer = Convert.ToInt32(Console.ReadLine()); // retrieves answer
            } while (answer != 1 && answer != 2); // makes sure answer is 1 or 2
            if (answer == 1)
            {
                drakeAlbums[i].score+=drakeAlbums[j].score; // adds to score for album that was selected
                names[i] += names[j]; // adds string of album that didn't get picked to album that did
                foreach (album drakealbum in drakeAlbums)
                {
                    if (names[drakeAlbums.IndexOf(drakealbum)].Contains(drakeAlbums[i].name) && drakeAlbums.IndexOf(drakealbum) != i) // for any album better than the first album, the points from the second album 
                    // will be given to it and the nme will be added to the string
                    {
                       names[drakeAlbums.IndexOf(drakealbum)]+=drakeAlbums[j].name;
                       drakealbum.score+=drakeAlbums[j].score;
                    }
                }
            }
            else // does what if block does but other way around
            {
                drakeAlbums[j].score+=drakeAlbums[i].score;
                names[j] += names[i];
                foreach (album drakealbum in drakeAlbums)
                {
                    if (names[drakeAlbums.IndexOf(drakealbum)].Contains(drakeAlbums[j].name)  && drakeAlbums.IndexOf(drakealbum) != j)
                    {
                       names[drakeAlbums.IndexOf(drakealbum)]+=drakeAlbums[i].name;
                       drakealbum.score+=drakeAlbums[i].score;
                    }
                }
            }

        }
    }
}

drakeAlbums.Sort(); // sorts albums by score
Console.WriteLine("Final ranking worst to best: \n");
foreach (album drakealbum in drakeAlbums) // writes out names of drake albums worst to best
{
    Console.WriteLine(drakealbum.name);
}
