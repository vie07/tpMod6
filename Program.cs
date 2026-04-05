using System;
using System.Diagnostics; // untuk Debug.Assert

class SayaMusicTrack
{
    private int id;
    private string title;
    private int playCount;

    public SayaMusicTrack(string title)
    {
        //precondition
        Debug.Assert(title != null, "title tidak boleh null"); //cek null
        Debug.Assert(title.Length <= 100, "title max 100 karakter"); //cek panjang

        Random rnd = new Random();
        this.id = rnd.Next(10000, 99999); //generate id
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        //precondition
        Debug.Assert(count <= 10000000, "max 10 juta"); //batas input

        try
        {
            checked //detect overflow
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Terjadi overflow!"); //biar program ga crash
        }
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
        //tes precondition normal
        SayaMusicTrack lagu1 = new SayaMusicTrack("Hindia - Evaluasi");

        lagu1.IncreasePlayCount(5000);
        lagu1.PrintTrackDetails();

        //tes exception overflow
        for (int i = 0; i < 10; i++)
        {
            lagu1.IncreasePlayCount(10000001); // bikin overflow
        }
    }
}