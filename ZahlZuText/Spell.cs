namespace ZahlZuText
{
    public class Spell
    {
        public Spell()
        {
    
        }

        public void spell(int number)
        {
            Dictionary<string, int> ageMapEiner = new Dictionary<string, int>();
            Dictionary<string, int> ageMapZehner = new Dictionary<string, int>();

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

            ageMapZehner.Add("twenty", 2);
            ageMapZehner.Add("thirty", 3);
            ageMapZehner.Add("forty", 4);
            ageMapZehner.Add("fifty", 5);
            ageMapZehner.Add("sixty", 6);
            ageMapZehner.Add("seventy", 7);
            ageMapZehner.Add("eighty", 8);
            ageMapZehner.Add("ninety", 9);

            string nummer = number.ToString();
            int length = nummer.Length;

            if (length == 3)
            {
                int hunderter = int.Parse(nummer[0].ToString());
                string hunderterText = "";

                switch (hunderter)
                {
                    case 1: hunderterText = "one hundred"; break;
                    case 2: hunderterText = "two hundred"; break;
                    case 3: hunderterText = "three hundred"; break;
                    case 4: hunderterText = "four hundred"; break;
                    case 5: hunderterText = "five hundred"; break;
                    case 6: hunderterText = "six hundred"; break;
                    case 7: hunderterText = "seven hundred"; break;
                    case 8: hunderterText = "eight hundred"; break;
                    case 9: hunderterText = "nine hundred"; break;
                }

                Console.WriteLine(hunderterText);

                int zehner = int.Parse(nummer[1].ToString());
                string zehnerText = "";

                if (zehner > 1)
                {
                    switch (zehner)
                    {
                        case 2: zehnerText = "twenty"; break;
                        case 3: zehnerText = "thirty"; break;
                        case 4: zehnerText = "forty"; break;
                        case 5: zehnerText = "fifty"; break;
                        case 6: zehnerText = "sixty"; break;
                        case 7: zehnerText = "seventy"; break;
                        case 8: zehnerText = "eighty"; break;
                        case 9: zehnerText = "ninety"; break;
                    }
                    Console.WriteLine(zehnerText); 
                }else if (zehner == 1)
                {
                    string testText = "";
                    switch (zehner)
                    {
                        case 2: testText = "eleven"; break;
                        case 3: testText = "twelve"; break;
                        case 4: testText = "thirteen"; break;
                        case 5: testText = "fourtheen"; break;
                        case 6: testText = "fifteen"; break;
                        case 7: testText = "sixteen"; break;
                        case 8: testText = "seventeen"; break;
                        case 9: testText = "eighteen"; break;
                    }
                    Console.WriteLine(testText);
                }

                int einer = int.Parse(nummer[2].ToString());
                if (einer > 0 && einer < 10)
                {
                    Console.WriteLine(ageMapEiner.FirstOrDefault(x => x.Value == einer).Key); // Gibt die Einerstelle aus
                }
            }
        }
    }
}
