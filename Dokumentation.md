# ASCIISnakeGame

### User Stories

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1  | Programm gestartet|-|Man wird begrüsst und erhält ein kleines Toturial um das Menu und das Snake Game zu manövrieren |
| 2  | Menu Angezeigt| S/ArrowDown |Neue Menu Option wird nach unten aus Ausgewählt.|
| 3  | Menu Angezeigt| W/ArrowUp |Neue Menu Option wird nach oben aus Ausgewählt.|
| 4  | Wahl 1 Gewählt|Enter Taste|Klassisches Snakespiel wird gestartet.  |
|5  | Wahl 2 Gewählt|Enter Taste|Spezielles Invincible Snakespiel wird gestartet.|
|6  | Klassisches Snakespiel gestartet| w |Schlange wechselt die Richtung nach oben.|
| 7  | Klassisches Snakespiel gestartet| a |Schlange wechselt die Richtung nach links.|
| 8  | Klassisches Snakespiel gestartet| s |Schlange wechselt die Richtung nach unten.|
| 9  | Klassisches Snakespiel gestartet| d |Schlange wechselt die Richtung nach rechts.|
| 10 | Klassisches Snakespiel gestartet| - |Schlange geht kontinuerlich in gegebene Richtung.|
| 11 | Spezielles Invincible Snakespiel gestartet| w |Schlange wechselt die Richtung nach oben.|
| 11 | Spezielles Invincible Snakespiel gestartet| a |Schlange wechselt die Richtung nach links.|
| 11 | Spezielles Invincible Snakespiel gestartet| s |Schlange wechselt die Richtung nach unten.|
| 11 | Spezielles Invincible Snakespiel gestartet| d |Schlange wechselt die Richtung nach rechts.|
| 11 | Spezielles Invincible Snakespiel gestartet| - |Schlange geht kontinuerlich in gegebene RIchtung.|
| 11 | Ein Snakespiel gestartet| ESC Taste |Man kommt in ein Menu.|
| 2  | Menu Angezeigt| S/ArrowDown |Neue Menu Option wird nach unten aus Ausgewählt.|
| 2  | Menu Angezeigt| S/ArrowDown |Neue Menu Option wird nach unten aus Ausgewählt.|
| 4  | Wahl 1 Gewählt|Enter Taste|Game wird direkt wieder gestartet.  |
| 4  | Wahl 2 Gewählt|Enter Taste|Man kommt zurück ins Hauptmenu.  |

### Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1 |      Spiel gestartet        |     -    |         Spieler erscheint in einer Spielwelt.         |
| 1.2 |      Spiel wurde gestartet       |     A/D gedrückt    |          A -> Spieler läuft nach links, D -> Spieler läuft nach rechts.         |
| 2.1 |      Spiel wurde gestartet        |    Spacebar wurde gedrückt     |         Spieler springt vom Boden in die Luft und fällt wieder nach unten.          |
| 3.1 |   Spiel wurde seit einiger Zeit gespielt und alle Anforderungen sind erfüllt |   Level verlassen durch Tür oder Ähnliches |  Spieler kommt ins nächste Level.|
| 4.1 |   Spiel gestartet           |     -    |          Texturen sichtbar         |
| 5.1 |   Spiel gestartet und sich durch das Level bewegt.           |     A/D/Space    |          Monster erscheinen        | 
| 6.1 |   Waffe erhalten           |    Linksklick/Rechtsklick     |     Waffe verursacht Schaden an Gegnern und kann diese Töten.          |
| 7.1 |   Level abgeschlossen           |    -     |          Spieler wird wieder ins Menu gebracht, um ein neues Level zu spielen.         |
| 8.1 |   Level wird gestartet           |    -     | Level hat ein anderes Thema als das letzte Level.|
| 9.1 |   Spieler spielt Spiel| - |Plattform bewegt sich|
|10.1 | Spieler startet das Spiel| - |Level Auswahl erscheint|
|11.1 | Spieler beendet Level| - |Level Auswahl erscheint|
|12.1 | Spieler spielt Spiel|Taste für Waffe 1 wird gedrückt.|Schwert wird ausgewählt.|
|12.2 | Spieler spielt Spiel|Taste für Waffe 2 wird gedrückt.|Bogen wird ausgewählt.|
|13.1 | Spieler spielt Spiel| - |Healthbar wird angezeigt.|
|13.2 | Spieler spielt Spiel| Spieler wird von Monster getroffen.| Healthbar nimmt ab.|
|14.1 | Spieler geht zu Shopkeeper| Spieler drückt die interagieren Taste bei dem Shopkeeper|Shopmenü erscheint.|
|14.2 | Spieler ist im Shopkeeper menü| Spieler drückt auf z. B. Heilung| Heilung wird dem Inventar des Spielers hinzugefügt.|
|15.1 | Spieler spielt Spiel| Spieler tötet Monster. |Monster lässt Währung fallen.|
|16.1 | Spieler spielt Spiel| - | Monster läuft zu Spieler.|
|16.2 | Spieler spielt Spiel| Spieler ist nahe am Monster.| Monster explodiert.|
|17.1 | Spieler spielt Spiel| - | Monster fliegt in der Luft.|
|17.2 | Spieler spielt Spiel| Spieler ist in der Nähe des Monsters.| Monster schiesst Pfeile.|

### Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |21.03.2023|OK|Stefan Jesenko|
| 1.2  |21.03.2023|OK|Stefan Jesenko|
| 2.1  |21.03.2023|OK|Stefan Jesenko|
| 3.1  |21.03.2023|OK|Stefan Jesenko|
| 4.1  |21.03.2023|NOK|Stefan Jesenko|
| 5.1  |21.03.2023|OK|Stefan Jesenko|
| 6.1  |21.03.2023|OK|Stefan Jesenko|
| 7.1  |21.03.2023|NOK|Stefan Jesenko|
| 8.1  |21.03.2023|OK|Stefan Jesenko|
| 9.1  |21.03.2023|OK|Stefan Jesenko|
|10.1  |21.03.2023|NOK|Stefan Jesenko|
|11.1  |21.03.2023|NOK|Stefan Jesenko|
|12.1  |21.03.2023|OK|Stefan Jesenko|
|12.2  |21.03.2023|NOK|Stefan Jesenko|
|13.1  |21.03.2023|OK|Stefan Jesenko|
|13.2  |21.03.2023|OK|Stefan Jesenko|
|14.1  |21.03.2023|NOK|Stefan Jesenko|
|14.2  |21.03.2023|NOK|Stefan Jesenko|
|15.1  |21.03.2023|NOK|Stefan Jesenko|
|16.1  |21.03.2023|OK|Stefan Jesenko|
|16.2  |21.03.2023|NOK|Stefan Jesenko|
|17.1  |21.03.2023|OK|Stefan Jesenko|
|17.2  |21.03.2023|OK|Stefan Jesenko|


### Testbericht
