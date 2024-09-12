/*
ord väljs
skriv ut så många _ som finns
ta in gissning

byt ut _ med bokstaven om edt finns i ordet
om bokstaven inte finns, rtia en del av gubben

om all _ har blivit fyllda vinn
om gubben ritas förlora
*/

string word = "apheirophobia";

/*blir en array med [*/string[] hiddenword = ["_ ","_ ","_ ","_ ","_ ","_ ","_ ","_ ","_ ","_ ","_ ","_ ","_ "];

Console.WriteLine("hung man");

foreach(string letter in hiddenword)
{
    Console.Write(letter);
}

Console.WriteLine("gissa en bokstav");

string guess = Console.ReadLine();

if (word.Contains(guess))
{
    Console.WriteLine("du är smart");
}

Console.ReadLine();

