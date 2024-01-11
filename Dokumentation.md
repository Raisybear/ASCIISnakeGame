# ASCIISnakeGame

### User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |Muss             |Funktional|Als Benutzer will ich ein Menu haben, um die Spielmodi zu sehen, damit ich weiss was ich spielen kann.|
| 2    |Muss             |Funktional|Als Benutzer will ich das Menu mittels Tasteneingaben bedienen können, damit ich etwas auswählen kann.|
| 2    |Muss     |Qualität|Als Benutzer will ich ein Spielfeld haben, auf dem ich die Schlange sehen kann, damit ich weiss wo die Schlange ist.|
| 2    |Muss             |Qualität|Als Benutzer will ich einen klassichen Snakegame Modus haben, Damit ich spielen kann.|
| 2    |Kann             |Qualität|Als Benutzer will ich einen speziellen Invincible Snakegame Modus haben, damit ich mehr Variation habe.|
| 2    |Muss       |Funktional|Als Benutzer will ich die Schlange mit Tasteneingaben bedienen können, damit ich spielen kann.|
| 2    |Muss       |Funktional|Als Benutzer will ich ein Menu haben, das auftaucht wenn ich ESC drücke, damit ich den Modus ändern kann.|
| 2    |Muss        |Funktional|Als Benutzer will ich das Menu mittels Tasteneingaben bedienen können, damit ich etwas auswählen kann.|
| 2    |Muss    |Funktional|Als Benutzer will ich eine Funktion haben den Score nach dem Spiel anzuzeigen, damit ich weiss wie gut ich war.|


### Testfälle

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
| 4  | Wahl 1 Gewählt|Enter Taste|Game wird direkt wieder neu gestartet.  |
| 4  | Wahl 2 Gewählt|Enter Taste|Man kommt zurück ins Hauptmenu.  |
| 4  | Gestorben/ESC|-|Score wird angezeigt.  |


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
