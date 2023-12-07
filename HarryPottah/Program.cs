namespace HarryPottah
{/*      
  * 
  * Pause til 13.35
  *      
Harry Potter oppgave!

Karakteren skal ha mulighet til å gå inn i en Magibutikk, 
der kan de kjøpe et dyr:  ugle,rotte eller en katt. 
De har også mulighet til å kjøpe en tryllestav: føniksstav, unikornstav eller trollstav.
For å få til dette må du lage en egen klasse som er butikken,
og presentere brukeren med en meny for hva personen skal kjøpe.

//forlate galtvort (character)
//Ankom butikk (character)
//se utvalg av ting (magicshop)
//kjøp ting (character)
//fysik overlevering fra butikk til karakter ?
//forlat butikk (character)
//ankom galtvort (charter)

Karakteren skal ha mulighet til å trylle - ta inn input fra brukeren,
og dersom en skriver en riktig trylleformel skal det printes til skjermen at de har utført tryllingen
trylleformler: 
vingardium leviosa (får en fjær til å fly)
hokus pokus (fyrer av fyrverkerier)

Dersom en karakter har en ugle, 
har de mulighet til å sende et brev med uglen til en annen karakter.
Karakteren som mottar brevet, får da brevet i inventoryen. Et brev inneholder en melding.

*/
    internal class Program
    {
        static void Main(string[] args)
        {
            var shop = new MagicShop();
            var galtvort = new Galtvort(shop);            
        }
    }
}