# Welkom bij niveau Advanced 
In de volgende opdracht, de dierentuin, gaan jullie de code aanpassen en verbeteren. Het is de bedoeling dat de dieren weer tot leven komen in de dierentuin en dat er natuurlijk meer dieren in de dierentuin worden geplaatst.

Veel Succes!

#### Leerdoelen
In deze opdracht zitten de volgende leerdoelen verwerkt:
* Je herkent een for-loop en kan deze aanpassen.
* Je herkent een lijst en kan deze aanvullen/aanpassen.
* Je herkent een switch statement en kan deze aanpassen.
* Je kan een if-statement maken.
* Je kan verschillende soorten data weergeven in een console.
* Je kan versiebeheer toepassen(git).
* Je werkt netjes binnen de Visual Studio community 2019 en volgen een coding standaard.

## Hoe zit de opdracht in elkaar
De opdracht bestaat uit verschillende niveaus. Het is de bedoeling om ze van starter tot expert uit te spelen en op te lossen. Hierdoor zie je de verbanden en problemen waardoor je het steeds beter begrijpt.

# De Opdrachten
Nadat je een opdracht hebt gemaakt is het belangrijk dat je die opdracht commit. Lees het kopje __Committen__ over hoe je dat moet doen.

Bekijk de Class Diagram:
![Class Diagram](/diagram/ClassDiagram.PNG?raw=true)

#### Opdracht 1. 
Verzin 4 nieuwe dieren voor in de dierentuin en stop ze in de lijst. - Commit met de volgende commit message `Opdracht 1 - nieuwe dieren toegevoegd.`
#### Opdracht 2. 
Print de dieren uit in de console. - Commit met de volgende commit message `Opdracht 2 - Dieren worden weergegeven in de console.`
#### Opdracht 3. 
Pas de if-statement aan en zorg dat elk dier een geluid maakt. - Commit met de volgende commit message `Opdracht 3 - De dierentuin leeft (ze maken geluid).`
#### Opdracht 3a. 
Maak de if-statement efficienter. - Commit met de volgende commit message `Opdracht 3a - If-statement verbetert`
#### Opdracht 4. 
Bestudeer de class Animal (Animal.cs) en laat het dier in de dierentuin een geluid maken via de methode in Animal. Zorg dat je nergens meer animal.sound gebruikt. - Commit met de volgende commit message `Opdracht 4 - animal.sound weggehaald en verbetert`
#### Opdracht 5.
Bestudeer de class Animal (Animal.cs) en print het aantal poten uit van de dieren. - Commit met de volgende commit message `Opdracht 5 - Poten uitgeprint van de dieren.`

# Committen
Committen van code betekent dat je van je code een soort checkpoint maakt van de huidige status van je code. Hierdoor bouw je een geschiedenis op met je code en kan je altijd terug naar dit moment. Dit kan handig zijn als je terug wilt naar de basis of start van het project/opdracht. Het is eigenlijk een blijvende `ctrl-z`/`Undo` moment. Je gaat met deze opdracht leren hoe je moet committen via deze opdrachten.

Voordat je een commit kan maken moet je eerst bepalen van welke files je een commit wilt maken. Je kan namelijk als je aan bijvoorbeeld 10 files hebt gewerkt hiervan maar 1 selecteren voor een commit. Dit doe je met de `git add <file>` commando waarvan `<file>` verwijst naar een daadwerkelijk file. Als je bijvoorbeeld `Program.cs` wilt committen omdat je die het aangepast kan je het volgende doen: `git add Zoo/Program.cs`. Dan druk je op enter en vervolgens kan je de commando `git commit` of `git commit -m"Jouw Bericht"` uitvoeren. Het verschil in die twee commit versies zit hem in het `-m` gedeelte. Zodra je `-m` uitvoerd kan je direct een bericht toevoegen en zonder `-m` zal hij een texteditor openen.

Als je bijvoorbeeld opdracht 1 afhebt kan je het volgende doen:
```console
git add Zoo/Program.cs
git commit -m"Opdracht 1 - nieuwe dieren toegevoegd."
git push
```
De `push` commando zorgt ervoor dat je alle commits naar de server stuurt. Je kan een `push` gebruiken wanneer jij je code online.

# Klaar?
Klaar met de starter opdracht? Kijk goed naar de volgende zaken en lever je starter code in.
Inleveren checklist:
- [x] Heb je elke opdracht in een losse commit geplaats met een logische naam?
- [x] Ziet je code er leesbaar uit? Goeie indenting en consistent?
- [x] Gebruik je engelse benaming van klasses en methode?
- [x] Is alles gepushed naar de server en zie je op github.com ook daadwerkelijk jouw aanpassingen?

Dan ben je nu klaar om naar het volgende niveau te gaan. Lees hieronder hoe je dat weer moet doen 👌😊👍

### Niveaus opstarten
Er zijn drie niveaus, starter, advanced en expert. De start code is verdeelt in de verschillende branches in deze git repository. Om een niveau te kunnen spelen moet je wisselen van de huidige branch naar de `starter`, `advanced` of `expert` branch. 

#### Wisselen Niveau
Om te wisselen van branch en dus van niveau is het belangrijk om alle code te hebben gecommit. Elke git commando moet je uitvoeren in de geclonede git folder.

Starter
```console
git switch starter
```

Advanced
```console
git switch advanced
```

Expert
```console
git switch expert
```
