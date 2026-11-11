# AGENTS.md für src/Frontend (TypeScript)

Gilt zusätzlich zur AGENTS.md im Hauptordner, sobald im Frontend gearbeitet wird.
Inhalt identisch mit `.github/instructions/typescript.instructions.md`.
(GitHub Copilot liest die Instructions-Datei, Codex liest diese Datei.)

- Kein `any`. Jede Funktion hat typisierte Parameter und einen Rückgabetyp.
- `const` und `let`, nie `var`.
- Preise immer mit `Intl.NumberFormat("de-DE", { style: "currency", currency: "EUR" })` formatieren.
- Nur benannte Exporte, kein `export default`.
- Tests mit Vitest, Datei liegt neben der getesteten Datei (`name.test.ts`).
