---
applyTo: "**/*.ts"
description: "TypeScript-Regeln der Beispiel AG"
---

# TypeScript-Regeln

- Kein `any`. Jede Funktion hat typisierte Parameter und einen Rückgabetyp.
- `const` und `let`, nie `var`.
- Preise immer mit `Intl.NumberFormat("de-DE", { style: "currency", currency: "EUR" })` formatieren.
- Nur benannte Exporte, kein `export default`.
- Tests mit Vitest, Datei liegt neben der getesteten Datei (`name.test.ts`).
