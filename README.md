# Analyseer

Bekijk de volledige commit-geschiedenis om te bestuderen hoe dit project tot stand gekomen is.

Probeer volgende vragen te beantwoorden:

i.v.m. MSTest:

- Welke Assert-methods worden naast `Assert.AreEqual` nog allemaal gebruikt?

> Assert.IsTrue, Assert.IsFalse

- Waarom heeft `TestDirectories` een `Initialize`- en `CleanUp`-method?

> In de initialize method worden de gegevens getest en in de cleanup worden ze weer verwijderd.

- Zijn de attributen `[TestMethod]`, `[TestClass]`, ... noodzakelijk? (Test uit!)

> Ja

- Wat is de shortcut om alle tests uit te voeren in VS?

> CTRL R en CTRL A

i.v.m. Files en Directories:

- Wat is het voordeel van `Path.Combine` i.v.m. strings aan elkaar plakken?

> Het is overzichtelijker en makkelijker om het bestand te veranderen, ze geven je een correct path.

- Wordt de return-waarde van `Directory.CreateDirectory(...)` steeds opgevangen? (TIP: gebruik `CTRL-SHIFT-F`)

> Nee, de return-waarde wordt maar 1 van de 3 keer opgevangen.

- Wat is de return-waarde van `Directory.CreateDirectory(...)`?

> testDir

- Wanneer is het nuttig om de return-waarde van `Directory.CreateDirectory(...)` op te vangen?

> Als je test wilt uitvoeren met de directory (Delete, refresh)

i.v.m. duidelijkheid/geschiedenis van de code:

- Lukken de testen in de commit 3ffe2c86? Waarom (niet)?

> Er ontbreekt een bestand.

- Wat lost commit d0320b6a op?

> Expect en Assert moest omgekeerd zijn.

- Wat is het probleem met de files in commit 9d184949?

> Slechte test die vaak falen.

- Wat doet commit 9b3e4065? Maakt dit de code makkelijker leesbaar? Makkelijker uitbreidbaar?

> Het maakt dit beter leesbaar, en makkelijker uitbreidbaar door de nieuwe strings.


# Opdracht 1 : FileOpenText

Voeg aan `TestReadFiles` een nieuwe test toe die handelt over `File.OpenText`.

- zie https://msdn.microsoft.com/en-us/library/system.io.file.opentext%28v=vs.110%29.aspx
- zet de test na `TestReadAllLines`
- noem de test `TestFileOpenText`
- test enkele nuttige dingen

# Opdracht 2 : TestReadFiles verbeteren

Momenteel gebruikt `TestReadFiles` de `fileB` nog niet echt nuttig.

Maak van `fileBContents` multi-line contents (met `\n` in) en zorg dat deze 2
tests ook `fileB` gebruiken om extra tests uit te voeren:

- `TestReadAllText`
- `TestReadAllLines`


# Opdracht 3 : TestWriteFiles

Voeg een nieuwe file `TestWriteFiles.cs` toe aan het UnitTest-project.

Ga hierin op gelijkaardige manier te werk als bij `TestReadFiles` maar ditmaal
om verschillende manieren te demonstreren om bestanden **weg te schrijven**.

Gebruik zeker :

- `Initialize` en `CleanUp`
- een test voor `WriteAllText`
- een test voor `WriteAllLines`
- een test voor `StreamWriter`
- eventueel een test voor `File.OpenWrite`

Maak voor elke van voorgaande tests ook een variant die **Append** doet i.p.v.
**Replace**.

