---
name: unit-tests
description: Schreibt Unit-Tests nach Teamkonvention (xUnit für C#, Vitest für TypeScript). Nutzen, wenn Tests für eine Methode, Klasse oder Datei geschrieben werden sollen.
---

# Unit-Tests nach Teamkonvention

## C# (xUnit)
- Testprojekt: `tests/Backend.Tests`, gleiche Ordnerstruktur wie `src/Backend`
- Klassenname: `<Klasse>Tests`
- Methodenname: `Methode_Situation_ErwartetesErgebnis`
- Aufbau jedes Tests: Arrange, Act, Assert (als Kommentare markiert)

## TypeScript (Vitest)
- Testdatei neben der Datei: `priceFormatter.test.ts`
- `describe` pro Funktion, `it` pro Fall, Beschreibung auf Deutsch

## Immer testen
1. Normalfall
2. Grenzwert (z. B. genau 1000 € beim Rabatt)
3. Leere oder ungültige Eingabe

## Testdaten
Nur erfundene Daten: "Muster GmbH", "Testkunde 1", Artikel "Schraube M8".
