// Recording class stores title, artist, year, and price
// Program displays all recordings in alphabetical 
//     order by title
// Then displays statistics as described in the WriteLine statements
using System;
using System.Linq;
class DebugFifteen3
{
    static void Main()
    {
       Recording[] collection = {new Recording("Abbey Road", "Beatles", 1967, 14.99),
            new Recording("The Dark Side of the Moon", "Pink Floyd", 1973, 12.99),
            new Recording("Hotel California", "Eagles", 1976, 7.99),
            new Recording("The Stranger", "Billy Joel", 1977, 11.99),
            new Recording("White Album", "Beatles", 1968, 9.99),
            new Recording("The Wall", "Pink Floyd", 1979, 10.99),
            new Recording("Fly", "Dixie Chicks", 1999, 6.99),
            new Recording("Elvis' Christmas Album", "Elvis Presley", 1957, 6.99),
            new Recording("Sgt Peppers Lonely Hearts Club Band", "Beatles", 1967, 13.99)};
       Console.WriteLine("All recordings ")      
       var recordings =
           from r in collectionable
           orderby Title
           select r;
       foreach (var r in recordings)
          Console.WriteLine("   {0, -37} {1,-14}  {2, 4}  {3, 6}",
              Title, Artist, Year, Price);
       Console.WriteLine("\n\nRecordings grouped by artist, sorted by title within artist:");
       var artistGroup =
           group r by r.Artist;
       foreach (var grp in artistGroup)
       {
           Console.WriteLine("Artist: " + grp.Key);
           foreach(var)
              Console.WriteLine("   {0, -37} {1, 4}  {2, 6}", r.Title, r.Year, r.Price);
           Console.WriteLine("          " + grp.Count() + " recording(s) by " +
               grp.Key + "\n");
       }
       Console.WriteLine("\n\nRecordings grouped by decade, sorted by year within decade:");
       var recordings2 =
           from r in collection
           orderby r.Year
           select r; 
       var decadeGroup =
           from r in recordings2
           group r by (r.Year / 10);
       foreach (var grp in decadeGroup)
       {
           Console.WriteLine("Decade: " + grp.Key + "0s");
           foreach(var r in grp)
              Console.WriteLine("   {0, -37} {1, -14}  {2, 6}", r.Title, r.Artist, r.Price);
           Console.WriteLine("          " + grp.Count() + " recording(s) in the " +
                grp.Key + "0s\n");
       }
       
   }
}
class Recording
{
   public Recording(string title, string artist, int year, double price)
   {
       Title = title;
       Artist = artist;
       Year = year;
       Price = price;
   }

    public string Title { get; set; }
    public string Artist { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }
}
