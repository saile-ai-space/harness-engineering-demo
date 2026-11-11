# Produktdokumentation „InfoHub“ – Konfigurationsregeln

Erfundenes Übungsprodukt der Beispiel AG. Stand: Workshop-Version.

## 1. Lizenzstufen

| Stufe | Mandanten (z. B. Sender, Behörden) | Zusatzmodule | Schnittstellen | Betrieb |
|---|---|---|---|---|
| S | 1 bis 2 | höchstens 2 | höchstens 2 | nur Cloud (EU) |
| M | 3 bis 5 | alle | höchstens 5 | nur Cloud (EU) |
| L | unbegrenzt | alle | unbegrenzt | Cloud (EU) oder On-Premises |

## 2. Module

| Modul | Typ | Voraussetzung |
|---|---|---|
| Basis | Pflicht | – |
| Meldungen (Störungen erfassen und pflegen) | Zusatzmodul | Basis |
| Radio-Ausgabe (Texte für Sprechermeldungen) | Zusatzmodul | Meldungen |
| Navigations-Export (Daten an Navigationsanbieter) | Zusatzmodul | Meldungen, Lizenzstufe M oder L |
| Statistik | Zusatzmodul | Basis |

## 3. Regeln

- **R1:** Das Modul Basis ist immer enthalten.
- **R2:** Die Zahl der Mandanten bestimmt die Mindest-Lizenzstufe (siehe Tabelle 1).
- **R3:** Ein Modul darf nur gebucht werden, wenn seine Voraussetzungen gebucht sind (siehe Tabelle 2).
- **R4:** Navigations-Export ist erst ab Lizenzstufe M buchbar.
- **R5:** On-Premises-Betrieb ist nur mit Lizenzstufe L möglich.
- **R6:** Die Zahl der Zusatzmodule und Schnittstellen darf die Grenze der Lizenzstufe nicht überschreiten.
- **R7:** Mehrsprachige Ausgabe (Zusatzoption) gibt es nur zusammen mit Radio-Ausgabe.
- **R8:** Preise und Rabatte legt ausschließlich der Vertrieb fest. Die Dokumentation enthält keine Preise.
