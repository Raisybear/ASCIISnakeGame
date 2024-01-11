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
| 9 |Muss    |Funktional|Als Benutzer will ich, dass die Schlange stirbt wenn sie gegen eine Wand fährt, damit man sterben kann.|
| 10    |Muss    |Funktional|Als Benutzer will ich eine Funktion haben den Score nach dem Spiel anzuzeigen, damit ich weiss wie gut ich war.|
| 11 |Muss |Funktional|Als Benutzer will ich, dass ich Äpfel einsammeln und diese immer wieder auftauchen, damit ich einen Highscore holen kann.|
| 12 |Muss |Funktional|Als Benutzer will ich, dass die Schlange bei jedem eingesammelten Apfel um 1 Feld länger wird.|



### Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Programm gestartet|-|Man wird begrüsst und erhält ein kleines Toturial um das Menu und das Snake Game zu manövrieren |
| 2.1  | Menu Angezeigt| S/ArrowDown |Neue Menu Option wird nach unten aus Ausgewählt.|
| 2.2  | Menu Angezeigt| W/ArrowUp |Neue Menu Option wird nach oben aus Ausgewählt.|
| 4.1  | Wahl 1 Gewählt|Enter Taste|Klassisches Snakespiel wird gestartet.  |
| 5.1  | Wahl 2 Gewählt|Enter Taste|Spezielles Invincible Snakespiel wird gestartet.|
| 6.1  | Klassisches Snakespiel gestartet| w |Schlange wechselt die Richtung nach oben.|
| 6.2  | Klassisches Snakespiel gestartet| a |Schlange wechselt die Richtung nach links.|
| 6.3  | Klassisches Snakespiel gestartet| s |Schlange wechselt die Richtung nach unten.|
| 6.4  | Klassisches Snakespiel gestartet| d |Schlange wechselt die Richtung nach rechts.|
| 6.5 | Klassisches Snakespiel gestartet| - |Schlange geht kontinuerlich in gegebene Richtung.|
| 6.6 | Spezielles Invincible Snakespiel gestartet| w |Schlange wechselt die Richtung nach oben.|
| 6.7 | Spezielles Invincible Snakespiel gestartet| a |Schlange wechselt die Richtung nach links.|
| 6.8 | Spezielles Invincible Snakespiel gestartet| s |Schlange wechselt die Richtung nach unten.|
| 6.9 | Spezielles Invincible Snakespiel gestartet| d |Schlange wechselt die Richtung nach rechts.|
| 6.10 | Spezielles Invincible Snakespiel gestartet| - |Schlange geht kontinuerlich in gegebene RIchtung.|
| 7.1| Ein Snakespiel gestartet| ESC Taste |Man kommt in ein Menu.|
| 8.1  | Menu Angezeigt| S/ArrowDown |Neue Menu Option wird nach unten aus Ausgewählt.|
| 8.2  | Menu Angezeigt| S/ArrowDown |Neue Menu Option wird nach unten aus Ausgewählt.|
| 8.3  | Wahl 1 Gewählt|Enter Taste|Game wird direkt wieder neu gestartet. |
| 8.4  | Wahl 2 Gewählt|Enter Taste|Man kommt zurück ins Hauptmenu. |
| 9.1  | Gegen Wand gefahren|-|Game Over! Das Menu wird aufgerufen. |
| 10.1  | Gestorben/ESC|-|Score wird angezeigt. |
| 11.1  | Snakespiel gestartet|-|Apfel ist auf dem Feld vorhanden |
| 11.2  | Über Apfel gefahren -> Eingesammelt|-|Neuer Apfel erscheint auf Feld |
| 11.3  | Über Apfel gefahren -> Eingesammelt|-|Highscore +1 |
| 12.1  | Über Apfel gefahren -> Eingesammelt|-|Schlange wird 1 Feld länger |



### Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1.1  |11.01.2023|OK|Elias Spycher|
| 2.2.1  |11.01.2023|OK|Elias Spycher|
| 3.2.2  |11.01.2023|OK|Elias Spycher|
| 4.4.1  |11.01.2023|OK|Elias Spycher|
| 5.5.1  |11.01.2023|OK|Elias Spycher|
| 6.6.1  |11.01.2023|OK|Elias Spycher|
| 7.6.2  |11.01.2023|OK|Elias Spycher|
| 8.6.3  |11.01.2023|OK|Elias Spycher|
| 9.6.4  |11.01.2023|OK|Elias Spycher|
| 10.6.5  |11.01.2023|OK|Elias Spycher|
| 11.6.6  |11.01.2023|OK|Elias Spycher|
| 12.6.7  |11.01.2023|OK|Elias Spycher|
| 13.6.8 |11.01.2023|OK|Elias Spycher|
| 14.6.9  |11.01.2023|OK|Elias Spycher|
| 14.6.10  |11.01.2023|OK|Elias Spycher|
| 15.7.1  |11.01.2023|OK|Elias Spycher|
| 16.8.1  |11.01.2023|OK|Elias Spycher|
| 17.8.2  |11.01.2023|OK|Elias Spycher|
| 18.8.3  |11.01.2023|OK|Elias Spycher|
| 19.8.4  |11.01.2023|OK|Elias Spycher|
| 20.9.1  |11.01.2023|OK|Elias Spycher|
| 16.8.1  |11.01.2023|OK|Elias Spycher|
| 16.8.1  |11.01.2023|OK|Elias Spycher|
| 16.8.1  |11.01.2023|OK|Elias Spycher|

### Testbericht
