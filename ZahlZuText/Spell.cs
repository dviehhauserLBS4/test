namespace ZahlZuText;

public class Spell
{
    
    public Spell()
    {
        int[] einer = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
      
    }

    public void spell(int number)
    {
        Dictionary<string, int> ageMapEiner = new Dictionary<string, int>();
        Dictionary<string, int> ageMapZehner= new Dictionary<string, int>();
        Dictionary<string, int> ageMapHunderter = new Dictionary<string, int>();

        ageMapEiner.Add("one", 1);
        ageMapEiner.Add("two", 2);
        ageMapEiner.Add("three", 3);
        ageMapEiner.Add("four", 4);
        ageMapEiner.Add("five", 5);
        ageMapEiner.Add("six", 6);
        ageMapEiner.Add("seven", 7);
        ageMapEiner.Add("eight", 8);
        ageMapEiner.Add("nine", 9);
        ageMapEiner.Add("eleven", 11);
        ageMapEiner.Add("twelve", 12);
        ageMapEiner.Add("thirteen", 13);
        ageMapEiner.Add("fourteen", 14);
        ageMapEiner.Add("fifteen", 15);
        ageMapEiner.Add("sixteen", 16);
        ageMapEiner.Add("seventeen", 17);
        ageMapEiner.Add("eighteen", 18);
        ageMapEiner.Add("nineteen", 19);
        
        ageMapZehner.Add("ten", 10);
        ageMapZehner.Add("twenty", 20);
        ageMapZehner.Add("thirty", 30);
        ageMapZehner.Add("forty", 40);
        ageMapZehner.Add("fifty", 50);
        ageMapZehner.Add("sixty", 60);
        ageMapZehner.Add("seventy", 70);
        ageMapZehner.Add("eighty", 80);
        ageMapZehner.Add("ninety", 90);
        
        ageMapHunderter.Add("100", 100);
        ageMapHunderter.Add("200", 200);
        ageMapHunderter.Add("300", 300);
        ageMapHunderter.Add("400", 400);
        ageMapHunderter.Add("500", 500);
        ageMapHunderter.Add("600", 600);
        ageMapHunderter.Add("700", 700);
        ageMapHunderter.Add("800", 800);
        ageMapHunderter.Add("900", 900);
        
        string nummer =number.ToString();
        string hunderter = nummer[0].ToString();
        Console.WriteLine(int.Parse(hunderter));

        if (int.Parse(hunderter) == 1)
        {
           
        }
    }
}