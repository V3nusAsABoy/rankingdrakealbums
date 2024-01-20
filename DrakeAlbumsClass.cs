using System.Runtime.InteropServices;

public class album : IComparable<album> // album class
{
    public string name; // name of album
    public int score; // album's score. the albums will be ranked in the end based on this score

    public album(string albumname, int albumscore) // sets up album object attributes with name and score
    {
        name = albumname;
        score = albumscore;
    }

    public int CompareTo(album other) // compares objects to each other based on score
    {
        return score.CompareTo(other.score);
    }
}