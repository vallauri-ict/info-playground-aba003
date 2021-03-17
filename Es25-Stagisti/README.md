

## Progetto 25
## Obiettivo: Realizzare la gestione degli studenti e degli stagisti della scuola. 
Nella form sono presenti i campi di testo da compilare per caricare uno studente o uno stagista (tutti i dati dello studente più l'azienda dello stage e l'ammontare di ore. Il pulsante
Elimina consente di rimuovere dalla lista (e dalla dgv di visualizzazione) lo studente/stagista. Il pulsante Cerca Azienda visualizza il numero totale di ore degli stagisti nell'azienda
selezionata.

## Classe Persona:
E' la classe più generica. Contiene il suo costruttore e 3 campi privati: Nome, Cognome e Città.  

## Classe Alunno:
Eredita i campi di Persona. Contiene alcuni attributi come la classe, la specializzazione e la sezione. La matricola è ricavata da un numero progressivo incrementato ad ogni caricamento.
Contiene un metodo override Visualizza() che resituisce i suoi attirbuti.

## Classe Stagisti:
Eredita i campi di Alunno. Contiene 2 attributi privati aggiuntivi: le ore in azienda e l'azienda stessa. Presenta lo stesso metodo ovverride Visualizza().
