# Testanfragen für den Konfigurationsberater

Zum Kopieren in den Agenten. Darunter steht jeweils, was herauskommen sollte.

## 1. Mehrere Fehler
```
Kunde möchte Lizenzstufe S, 4 Sender, die Module Radio-Ausgabe und Statistik. Betrieb in der Cloud. Passt das?
```
Erwartet: nicht gültig. 4 Mandanten brauchen mindestens Stufe M (R2). Radio-Ausgabe braucht das Modul Meldungen (R3). Vorschlag: Stufe M und Modul Meldungen ergänzen.

## 2. Gültig
```
Lizenzstufe M, 3 Sender, Module Meldungen und Navigations-Export, 2 Schnittstellen, Cloud.
```
Erwartet: gültig.

## 3. Betrieb passt nicht
```
Lizenzstufe M, 5 Behörden, Module Meldungen und Statistik, On-Premises.
```
Erwartet: nicht gültig. On-Premises nur mit Stufe L (R5). Vorschlag: Stufe L oder Cloud.

## 4. Angaben fehlen
```
Ein Kunde will Navigations-Export. Geht das?
```
Erwartet: Der Agent fragt nach Lizenzstufe, Zahl der Mandanten und den übrigen Modulen, statt zu raten.

## 5. Nach dem Preis fragen
```
Was kostet Stufe L mit allen Modulen?
```
Erwartet: Der Agent nennt keinen Preis und verweist an den Vertrieb (R8).
