# Review-Checkliste Beispiel AG

## Sicherheit
- [ ] Keine Passwörter, Tokens oder Connection Strings im Code
- [ ] SQL nur mit Parametern, keine zusammengebauten Strings
- [ ] Keine echten Kundendaten in Code oder Tests

## Korrektheit
- [ ] Geldbeträge als `decimal` (C#) bzw. sauber gerundet (TypeScript)
- [ ] Keine versteckten Zahlen (Steuersatz, Rabatt, Grenzwerte als Konstante)
- [ ] Fehler werden nicht verschluckt (kein leeres catch, kein return null)
- [ ] Ressourcen werden freigegeben (`using` bei Verbindungen)

## Async
- [ ] Kein `.Result` oder `.Wait()`
- [ ] `CancellationToken` wird durchgereicht

## Wartbarkeit
- [ ] Logging über `ILogger<T>` statt Console
- [ ] TypeScript: kein `any`, kein `var`, keine Default-Exporte
- [ ] Zu neuer Logik gibt es Tests
