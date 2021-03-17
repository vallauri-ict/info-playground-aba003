

## Progetto 26
## Obiettivo: Simulare una connessione tramite un id con le interfacce

## L'interfaccia IDispAggiuntivo:
- Stabilisce quale aspetto dovrà avere un oggetto. In particolare presenta un campo intero **id** e un boolean **status** per gestire la connessione
- Presenta anche due metodi connetti e disconneti ai quali va passata una stringa (nome della connessione)

## La classe MyComponents:
- Implementa tramite delle get e set l'id e lo stato della connessione
- Implementa i metodi connetti e disconnetti. Essi tramite una message box restituiscono se si è connessi oppure no alla connessione passata come parametro nel Form1
- Implementa un metodo Stato() che restituisce lo stato corrente della connessione
