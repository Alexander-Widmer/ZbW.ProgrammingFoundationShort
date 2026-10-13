# ZbW.ProgrammingFoundationShort

Kurzversion des ZbW-Kurses **Programming Foundation** mit WinForms- und Konsolenübungen.

## Struktur

```text
src/
├── ZbW.ProgrammingFoundationShort.sln
├── Directory.Build.props
├── ZbW.ProgrammingFoundationShort.Lessons/
└── ZbW.ProgrammingFoundationShort.Challenges/
```

## Projekte

| Projekt | Inhalt |
|---|---|
| `ZbW.ProgrammingFoundationShort.Lessons` | In-Class-Aufträge mit TODO-Stubs und `_Loesung` direkt daneben |
| `ZbW.ProgrammingFoundationShort.Challenges` | Hausaufgaben als vollständige Musterlösungen |

> **Musterlösungen sind sichtbar – du entscheidest, wann du hineinschaust.**
> Du lernst am meisten, wenn du eine Aufgabe zuerst selbst löst (auch wenn es hakt) und die Lösung erst danach zum
> Vergleichen öffnest. Für die Hausaufgaben legst du am besten ein eigenes Projekt bzw. einen eigenen Ordner an.

## Module

| Modul | Thema | Lessons | Challenges |
|---|---|---:|---:|
| 01 | Variablen, Datentypen & Operatoren | 3 | 4 |
| 02 | Kontrollstrukturen | 3 | 4 |
| 03 | Schleifen, Random & Fehlerbehandlung | 3 | 4 |
| 04 | Arrays & Methoden | 3 | 4 |
| 05 | Collections & Methoden Vertiefung | 3 | 4 |
| 06 | Klassen & Objekte | 3 | 4 |
| 07 | Referenzen & Vergleiche | 3 | 4 |
| 08 | Statische Elemente | 3 | 4 |
| 09 | Vererbung & Polymorphismus | 3 | 4 |
| 10 | Algorithmen & Datenstrukturen | 3 | 3 |
| 11 | Algorithmen-Schemas *(freiwillige Vertiefung, nicht Kursstoff)* | 3 | 4 |
| 12 | Datenstrukturen *(freiwillige Vertiefung, nicht Kursstoff)* | 3 | 4 |

## Für Studierende

Erstelle zuerst einen **Fork** dieses Repositories auf deinem eigenen GitHub-Account und klone danach deinen Fork lokal:

```powershell
git clone https://github.com/DEIN_USERNAME/ZbW.ProgrammingFoundationShort.git
cd ZbW.ProgrammingFoundationShort
```

Arbeite in deinem Fork, committe regelmässig und pushe deine Lösungen auf deinen GitHub-Account.

### Fork aktuell halten

Korrekturen und neue Module kommen ins Original-Repository. So holst du sie in deinen Fork:

1. Zuerst eigene Änderungen committen und pushen.
2. Auf GitHub in deinem Fork auf **Sync fork → Update branch** klicken.
3. Lokal `git pull` ausführen.

Alternativ auf der Kommandozeile (einmalig `upstream` einrichten):

```powershell
git remote add upstream https://github.com/jpp7/ZbW.ProgrammingFoundationShort.git
git fetch upstream
git merge upstream/main --no-edit
git push
```

Auf der GitHub-Webseite **nie «Discard commits»** wählen – das löscht deine eigenen Commits im Fork. Bei einem
Merge-Konflikt in einer Datei, die du selbst bearbeitet hast: deine Version behalten oder beide Varianten
zusammenführen. Ausführliche Anleitung mit IDE-Varianten und Konfliktlösung: Kursunterlagen, Vorbereitung
`00.06-Fork-aktualisieren`.

## Start

Öffne `src/ZbW.ProgrammingFoundationShort.sln` in Visual Studio oder Rider.

In `Program.cs` des jeweiligen Projekts ist pro Aufgabe eine Startzeile vorbereitet. Es soll jeweils nur eine `Application.Run(...)`-Zeile aktiv sein.

Beispiel:

```csharp
Application.Run(new ZbW.ProgrammingFoundationShort.Challenges.Module08.Aufgabe1_MathBibliothek.MathBibliothekForm());
```

## Build

```powershell
dotnet build src\ZbW.ProgrammingFoundationShort.sln --ignore-failed-sources
```

Der Zusatz `--ignore-failed-sources` ist nützlich, falls lokal ein privater NuGet-Feed konfiguriert ist, der ohne Anmeldung Warnungen erzeugt.

