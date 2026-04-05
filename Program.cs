using System;

class SayaMusicTrack
{
    private int id;
    private string title;
    private int playCount;

    public SayaMusicTrack(string title)
    {
        Random rnd = new Random();
        this.id = rnd.Next(10000, 99999); //generate id
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        playCount += count; //nambah
    }

    //print semua
    public void PrintTrackDetails()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack lagu1 = new SayaMusicTrack("Hindia - Evaluasi");

        lagu1.IncreasePlayCount(5000); // test

        lagu1.PrintTrackDetails();
    }
}