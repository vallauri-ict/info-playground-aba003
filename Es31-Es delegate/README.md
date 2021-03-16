# info-playground-MarengoSimone

_Stud. Marengo Simone_

## Progetto 31:
Secondo esercizio delle dispense sui **delegate** del prof.Mana (robertomana.it)

## Obiettivo:
Questo secondo esempio fornisce due ulteriori miglioramenti rispetto al semplice esempio
precedente:
- Alla procedura di evento viene assegnata la firma tipica(Object sender, EventArgs e)
- All‟interno del metodo che deve generare l‟evento (nell‟esempio precedente il metodo
 SalvaSuFile) anziché richiamare direttamente il delegate di gestione dell‟evento, 
viene richiamata una funzione intermedia che una eventuale classe derivata potrà
 eventualmente modificare aggiungendo dei contenuti primadel verificarsi dell‟evento,
 e potrà anche richiamare direttamente per sollevare l‟evento.
- L'esercizio utilizza nuovamente i delegate per la **gestione degli eventi**
