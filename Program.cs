string parola = "";
string risultato = "";
char lettSost = 'A';
char lettera = 'B'; 
Console.WriteLine("Inserisci la stringa");
parola = Console.ReadLine();
Console.WriteLine("Inserisci la lettera che verra' sostituire");
lettSost = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Inserisci la lettera che andrà al posto di quella sostituita");
lettera = Convert.ToChar(Console.ReadLine());
for (int i = 0; i < parola.Length; i++)
{
    if (parola[i] == lettSost)
    {
        risultato = risultato + lettera;
    }
    else
    {
        risultato = risultato + parola[i];
    }
}
Console.WriteLine(risultato);
