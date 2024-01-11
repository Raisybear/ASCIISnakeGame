# ASCIISnakeGame

### User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |Muss             |Funktional|Als Benutzer will ich ein Menu haben, um die Spielmodi zu sehen, damit ich weiss was ich spielen kann.|
| 2    |Muss             |Funktional|Als Benutzer will ich das Menu mittels Tasteneingaben bedienen können, damit ich etwas auswählen kann.|
| 3    |Muss     |Qualität|Als Benutzer will ich ein Spielfeld haben, auf dem ich die Schlange sehen kann, damit ich weiss wo die Schlange ist.|
| 4    |Muss             |Qualität|Als Benutzer will ich einen klassichen Snakegame Modus haben, Damit ich spielen kann.|
| 5    |Kann             |Qualität|Als Benutzer will ich einen speziellen Invincible Snakegame Modus haben, damit ich mehr Variation habe.|
| 6    |Muss       |Funktional|Als Benutzer will ich die Schlange mit Tasteneingaben bedienen können, damit ich spielen kann.|
| 7    |Muss       |Funktional|Als Benutzer will ich ein Menu haben, das auftaucht wenn ich ESC drücke, damit ich den Modus ändern kann.|
| 8    |Muss        |Funktional|Als Benutzer will ich das Menu mittels Tasteneingaben bedienen können, damit ich etwas auswählen kann.|
| 9    |Muss    |Funktional|Als Benutzer will ich eine Funktion haben den Score nach dem Spiel anzuzeigen, damit ich weiss wie gut ich war.|
| 10 |Muss |Funktional|Als Benutzer will ich, dass ich Äpfel einsammeln und diese immer wieder auftauchen, damit ich einen Highscore holen kann.|
| 11 |Muss    |Funktional|Als Benutzer will ich, dass die Schlange stirbt wenn sie gegen eine Wand fährt, damit man sterben kann.|


### Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Programm gestartet|-|Man wird begrüsst und erhält ein kleines Toturial um das Menu und das Snake Game zu manövrieren |
| 2.1  | Menu Angezeigt| S/ArrowDown |Neue Menu Option wird nach unten aus Ausgewählt.|
| 2.2  | Menu Angezeigt| W/ArrowUp |Neue Menu Option wird nach oben aus Ausgewählt.|
| 2.3  | Wahl 1 Gewählt|Enter Taste|Klassisches Snakespiel wird gestartet.  |
| 2.4  | Wahl 2 Gewählt|Enter Taste|Spezielles Invincible Snakespiel wird gestartet.|
| 2  | Klassisches Snakespiel gestartet| w |Schlange wechselt die Richtung nach oben.|
| 7  | Klassisches Snakespiel gestartet| a |Schlange wechselt die Richtung nach links.|
| 8  | Klassisches Snakespiel gestartet| s |Schlange wechselt die Richtung nach unten.|
| 9  | Klassisches Snakespiel gestartet| d |Schlange wechselt die Richtung nach rechts.|
| 10 | Klassisches Snakespiel gestartet| - |Schlange geht kontinuerlich in gegebene Richtung.|
| 11 | Spezielles Invincible Snakespiel gestartet| w |Schlange wechselt die Richtung nach oben.|
| 12 | Spezielles Invincible Snakespiel gestartet| a |Schlange wechselt die Richtung nach links.|
| 13 | Spezielles Invincible Snakespiel gestartet| s |Schlange wechselt die Richtung nach unten.|
| 14 | Spezielles Invincible Snakespiel gestartet| d |Schlange wechselt die Richtung nach rechts.|
| 15 | Spezielles Invincible Snakespiel gestartet| - |Schlange geht kontinuerlich in gegebene RIchtung.|
| 16 | Ein Snakespiel gestartet| ESC Taste |Man kommt in ein Menu.|
| 17  | Menu Angezeigt| S/ArrowDown |Neue Menu Option wird nach unten aus Ausgewählt.|
| 18  | Menu Angezeigt| S/ArrowDown |Neue Menu Option wird nach unten aus Ausgewählt.|
| 19  | Wahl 1 Gewählt|Enter Taste|Game wird direkt wieder neu gestartet. |
| 20  | Wahl 2 Gewählt|Enter Taste|Man kommt zurück ins Hauptmenu. |
| 21  | Gestorben/ESC|-|Score wird angezeigt. |
| 22  | Gegen Wand gefahren|-|Das Menu wird aufgerufen. |


### Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |11.01.2023|OK|Elias Spycher|
| 1.1  |11.01.2023|OK|Elias Spycher|
| 1.1  |11.01.2023|OK|Elias Spycher|
| 1.1  |11.01.2023|OK|Elias Spycher|
| 1.1  |11.01.2023|OK|Elias Spycher|
| 1.1  |11.01.2023|OK|Elias Spycher|
| 1.1  |11.01.2023|OK|Elias Spycher|
| 1.1  |11.01.2023|OK|Elias Spycher|
| 1.1  |11.01.2023|OK|Elias Spycher|
| 1.1  |11.01.2023|OK|Elias Spycher|
| 1.1  |11.01.2023|OK|Elias Spycher|
| 1.1  |11.01.2023|OK|Elias Spycher|
| 1.1  |11.01.2023|OK|Elias Spycher|
| 1.1  |11.01.2023|OK|Elias Spycher|
| 1.1  |11.01.2023|OK|Elias Spycher|
| 1.1  |11.01.2023|OK|Elias Spycher|
| 1.1  |11.01.2023|OK|Elias Spycher|

### Testbericht
