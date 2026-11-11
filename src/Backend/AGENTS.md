# AGENTS.md für src/Backend (C#)

Gilt zusätzlich zur AGENTS.md im Hauptordner, sobald im Backend gearbeitet wird.
Inhalt identisch mit `.github/instructions/csharp.instructions.md`.
(GitHub Copilot liest die Instructions-Datei, Codex liest diese Datei.)

- Geldbeträge immer als `decimal`, nie als `double` oder `float`.
- Keine Zahlen im Code verstecken: Steuersätze, Rabatte und Grenzwerte als benannte Konstante (z. B. `const decimal VatRate = 0.19m;`).
- Asynchroner Code: `async`/`await` durchgehend, `CancellationToken` als letzter Parameter. Nie `.Result` oder `.Wait()`.
- Logging nur über `ILogger<T>`, nie `Console.WriteLine`.
- Datenbankzugriffe nur mit Parametern, nie Strings zusammenbauen (SQL-Injection).
- Exceptions nicht verschlucken: kein leeres `catch`, kein `return null` als Fehlerersatz.
- Tests mit xUnit, Namensschema `Methode_Situation_ErwartetesErgebnis`.
