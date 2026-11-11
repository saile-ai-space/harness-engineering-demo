---
applyTo: "**/*.cs"
description: "C#-Regeln der Beispiel AG"
---

# C#-Regeln

- Geldbeträge immer als `decimal`, nie als `double` oder `float`.
- Keine Zahlen im Code verstecken: Steuersätze, Rabatte und Grenzwerte als benannte Konstante (z. B. `const decimal VatRate = 0.19m;`).
- Asynchroner Code: `async`/`await` durchgehend, `CancellationToken` als letzter Parameter. Nie `.Result` oder `.Wait()`.
- Logging nur über `ILogger<T>`, nie `Console.WriteLine`.
- Datenbankzugriffe nur mit Parametern, nie Strings zusammenbauen (SQL-Injection).
- Exceptions nicht verschlucken: kein leeres `catch`, kein `return null` als Fehlerersatz.
- Tests mit xUnit, Namensschema `Methode_Situation_ErwartetesErgebnis`.
