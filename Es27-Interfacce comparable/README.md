



## Progetto 27
## Obiettivo: Realizzare una semplice visualizzazione di un vettore con l'interfaccia Comparable

## La classe Persona:
- Eredita dall'interfaccia Comparable
- Ha 3 attributi privati nome, cognome e citta (con i loro costruttori)
- Il costruttore Persona() con tutti e 3 gli attributi come parametri
- L'override del metodo ToString() che restituisce Cognome, Nome e Citta
- Un particolare metodo CompareTo che esegue una String.Compare sul campo cognome

## Form 1:
- Dichiariamo un semplice vettore con una serie di persone
- Richiama il metodo ShowPersona() al click dei due bottoni ma 
- nel caso del click su "ordina e visualizza" viene fatto un Array.Sort del vettore
