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


