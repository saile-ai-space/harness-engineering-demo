# Harness Engineering – Übungs-Repo

Ein kleines, erfundenes Projekt (C# und TypeScript) mit fertigem Harness: Regeln, Skills und ein Reviewer-Agent.
Hier könnt ihr gefahrlos üben. Ihr arbeitet in eurer eigenen Kopie, dieses Repo selbst könnt ihr nicht verändern.

> **Wichtig:** Alle Daten sind erfunden. Das Passwort in `OrderService.cs` ist absichtlich eingebaut, damit das Code-Review etwas findet. Kopiert bitte keine echten Firmen- oder Kundendaten hier hinein.

## Loslegen (5 Minuten)

1. Oben auf **Code → Download ZIP** klicken und entpacken. Wer Git nutzt: `git clone` mit dem Link dieser Seite.
2. In VS Code: **Datei → Ordner öffnen** und genau den Ordner wählen, in dem die `AGENTS.md` liegt.
3. Fragt VS Code, ob ihr den Autoren vertraut: **Ja**. Sonst werden keine Regeln geladen.
4. Chat öffnen und unten den Modus **Agent** wählen.
5. Test: `Welche Regeln gelten in diesem Projekt und welche Skills kennst du?`
   Die Antwort sollte auf Deutsch kommen und die Regeln aus der `AGENTS.md` nennen.

## Was liegt wo

| Datei / Ordner | Was es ist | Wann es wirkt |
|---|---|---|
| `AGENTS.md` | Grundregeln für das ganze Projekt | bei jeder Aufgabe |
| `.github/instructions/*.instructions.md` | Regeln je Dateityp (`applyTo`) | nur wenn passende Dateien im Spiel sind (Copilot) |
| `src/Backend/AGENTS.md`, `src/Frontend/AGENTS.md` | Regeln je Ordner | wenn in dem Ordner gearbeitet wird (Codex) |
| `.agents/skills/code-review/` | Skill: Review nach Checkliste | wenn die KI ihn für passend hält oder ihr `/` tippt |
| `.agents/skills/unit-tests/` | Skill: Tests nach Konvention | wie oben |
| `.github/agents/reviewer.agent.md` | Custom Agent: Reviewer, darf nur lesen | wenn ihr ihn unten im Chat auswählt (Copilot) |
| `CLAUDE.md` | verweist auf `AGENTS.md` | für Claude Code |
| `buero/` | Material für Microsoft 365 Copilot, ChatGPT und Cowork | für die Business-Übungen |

**Faustregel:** Rules beschreiben Grenzen. Skills beschreiben Arbeitsabläufe. Agenten legen fest, wer etwas mit welchen Rechten tut.

## Übungen (45 Minuten, zu zweit oder zu dritt)

Sucht euch eine Spalte aus. Wer ein eigenes Repo dabei hat, darf die Aufgaben auch dort machen.

### Basis: Regeln, die wirken

1. **Regel ausprobieren:**
   `Füge in OrderService eine Methode hinzu, die den Bruttopreis einer Bestellung inklusive 19 % Mehrwertsteuer berechnet.`
   Schaut euch an, wie die Regeln aus `AGENTS.md` und `csharp.instructions.md` das Ergebnis prägen (decimal, Konstante, Tests).
2. **Eigene Regel ergänzen:** Schreibt eine neue Regel in die `AGENTS.md`, zum Beispiel „Jede öffentliche Methode bekommt einen XML-Kommentar auf Englisch“. Neuer Chat, gleicher Auftrag: Wirkt die Regel?
3. **Im eigenen Repo:** AGENTS.md per Interview anlegen lassen:
   ```
   Ich möchte eine AGENTS.md für dieses Repository anlegen. Schau dir zuerst den Code an.
   Stell mir dann nacheinander höchstens 8 Fragen zu unseren Regeln, Befehlen und Grenzen.
   Schreib danach eine AGENTS.md mit maximal 40 Zeilen.
   ```

### Pro: Skills und Agenten

1. **Review mit Skill:** `Mach ein Code-Review von src/Backend/Orders/OrderService.cs`
   Danach unten im Chat **Reviewer** auswählen: `Prüfe src/Frontend/priceFormatter.ts`
2. **Eigenen Skill bauen:**
   ```
   Leg einen Skill unter .agents/skills/commit-nachricht/SKILL.md an, der aus den aktuellen Änderungen
   eine Commit-Nachricht nach Conventional Commits schreibt. Die description soll klar sagen, wann er genutzt wird.
   ```
   Testet ihn: `Schreib mir eine Commit-Nachricht für meine Änderungen.`
3. **Gleicher Agent in Codex:**
   `Wir haben in .github/agents einen Reviewer für Copilot. Leg mir das Gleiche als Custom Agent für Codex an.`
4. **Bonus:** Lasst den Reviewer mit einem anderen Modell prüfen als dem, das den Code geschrieben hat. Fragt die KI, wie das in eurem Tool geht.

### Business: Dasselbe Prinzip ohne Code

Alles liegt im Ordner `buero/`.

1. **Eigene Anweisungen:** Text aus `buero/eigene-anweisungen.txt` anpassen und in Microsoft 365 Copilot, einem ChatGPT-Projekt oder Copilot Cowork hinterlegen.
2. **Meetingnotizen:** Die Anleitung aus `buero/meetingnotizen/SKILL.md` als Anweisung nutzen und die Beispielnotizen zusammenfassen lassen: Entscheidungen, To-dos mit „Wer“ und „Bis wann“, offene Fragen.
3. **Konfigurationsberater:** Im Agent Builder von Microsoft 365 Copilot einen Agenten bauen.
   - Anweisungen: `buero/konfigurationsberater/anweisungen.txt`
   - Wissen: `buero/konfigurationsberater/produktdoku.docx` hochladen
   - Testen mit `buero/konfigurationsberater/testanfragen.md`

## Zurücksetzen

In VS Code links die **Quellcodeverwaltung** öffnen und **Alle Änderungen verwerfen** wählen. Ohne Git: Ordner löschen und das ZIP neu entpacken.
