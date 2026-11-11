# AGENTS.md – Grundregeln für KI-Agenten in diesem Repo

Diese Datei liest der Agent bei jeder Aufgabe automatisch mit.
Halte sie kurz: Nur was immer gilt, gehört hierher.

## Projekt
- Übungsprojekt "Auftragsverwaltung" der Beispiel AG (erfunden) für den KI-Workshop.
- Backend: C# / .NET 8 in `src/Backend`
- Frontend: TypeScript in `src/Frontend`
- Tests: `tests/Backend.Tests` (xUnit ist eingebunden), TypeScript-Tests mit Vitest (in `package.json` eingebunden)

## Befehle
- Tests C#: `dotnet test tests/Backend.Tests` (nur wenn ein .NET SDK installiert ist)
- Tests TypeScript: `npm test` (nur wenn Node.js installiert ist)
- Ist kein SDK installiert: nichts bauen oder ausführen, nur Dateien schreiben.

## Sprache
- Antworte immer auf Deutsch.
- Code, Bezeichner und Commit-Nachrichten auf Englisch.

## So arbeitest du
- Erst lesen, dann ändern: Schau dir die betroffenen Dateien an, bevor du etwas schreibst.
- Kleine Schritte: Ändere nur, was für die Aufgabe nötig ist.
- Zu jeder neuen Methode gehört ein Unit-Test.
- Beende jede Antwort mit dem Abschnitt **"Was ich geändert habe"** (max. 3 Stichpunkte).

## Grenzen
- Keine neuen NuGet- oder npm-Pakete ohne Rückfrage.
- Keine echten Kundendaten in Code, Tests oder Beispielen. Nutze erfundene Daten wie "Muster GmbH".
- Keine Passwörter oder Zugangsdaten in den Code schreiben. Finde welche? Melde sie.
- Dateien in `config/production` niemals ändern.

## Detailregeln
- C#-Regeln: `.github/instructions/csharp.instructions.md`
- TypeScript-Regeln: `.github/instructions/typescript.instructions.md`
- Für Code-Reviews gibt es den Skill `code-review`.
