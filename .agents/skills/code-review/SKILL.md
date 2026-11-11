---
name: code-review
description: Prüft Code nach den Review-Regeln der Beispiel AG und gibt eine Tabelle mit Findings zurück. Nutzen, wenn jemand ein Review, eine Code-Prüfung oder Feedback zu Code möchte.
---

# Code-Review nach Teamstandard

## Ablauf
1. Lies die zu prüfenden Dateien vollständig.
2. Geh die Checkliste in `checkliste.md` (gleicher Ordner) Punkt für Punkt durch.
3. Ändere selbst nichts. Du prüfst nur.

## Ausgabe
Eine Tabelle, sortiert nach Schwere (Kritisch zuerst):

| Schwere | Datei:Zeile | Problem | Vorschlag |
|---|---|---|---|

Schwere-Stufen:
- **Kritisch**: Sicherheitslücke, Datenverlust, Zugangsdaten im Code
- **Hoch**: Falsches Ergebnis möglich (z. B. Rundungsfehler bei Geld)
- **Mittel**: Verstößt gegen unsere Regeln, funktioniert aber
- **Niedrig**: Stil und Lesbarkeit

Danach ein Satz Fazit: "Kann so gemergt werden" oder "Erst die kritischen Punkte beheben".
