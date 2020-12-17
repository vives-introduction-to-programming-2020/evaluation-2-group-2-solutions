# B-Rail but on Time

Deze applicatie vormt de basis van een traject simulator om mensen met de trein te laten reizen. Op dit moment is reeds een class voorzien om de start en eind locatie bij te houden, namelijk `Location`.

Reizen van punt a naar punt b wordt dan gemodelleerd door de class `Traject` waar een `from` en `to` `Location` object wordt in bijgehouden.

Om de trajecten naar de terminal uit te kunnen printen dienen echter beide classes nog te worden voorzien van de `ToString()` methode.

Implementeer deze zodat `Location` een string teruggeeft in het formaat `Aalst [9300]`, waarbij `Aalst` de naam is en `9300` de postcode.

Implementeer vervolgens ook deze voor een `Traject` zodat we volgende output krijgen: `Traject from Ostend [8400] to Brugge [8200]`

Je mag de `Main()` methode aanpassen / uitbreiden als je dit nodig vind.

Probeer er echter wel voor te zorgen dat je project op het einde compileert. Desnoods zet je niet-werkende code in commentaar.

## Verwachte output

```text
Welcome to B-Rail but on Time

Traject from Ostend [8400] to Brugge [8200]
```

## Unit Tests

Het project wordt tevens vergezeld van Unit Tests. Gelieve deze te runnen.
