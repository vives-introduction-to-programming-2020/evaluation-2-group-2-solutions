# Who Sorted this Out

`ArrayHelper` is een class die toelaat om een paar basis functionaliteiten uit te voeren op een array van getallen.

Zo laat de class toe om het grootste getal te zoeken in een array aan de hand van de methode `Maximum()`. Daarnaast kan je aan de hand van de methode `IsSortedAscending()` controleren op een array gesorteerd is van klein naar groot.

Beide methodes zijn echter nog niet geïmplementeerd. Dat is namelijk jouw taak (zie `View => Task List` in Visual Studio):

* Implementeer de methode `Maximum()` zodat deze in de array van getallen, `numbers`, op zoek gaat naar het grootste getal (negatieve getallen kunnen ook voorkomen). Geef **de index van het grootste getal terug** (niet de waarde zelf). Indien de array geen elementen bevat dien je `-1` terug te geven. Je mag er vanuit gaan dat de array **geen duplicate getallen** bevat.
* Implementeer de methode `IsSortedAscending()` zodat deze de array van getallen controleert of deze gesorteerd zijn van klein naar groot. Zorg er wel voor dat de methode eveneens werkt met een array die geen elementen bevat en dan `false` teruggeeft. Je mag er vanuit gaan dat de array **geen duplicate getallen** bevat.

Je mag de `Main()` methode aanpassen / uitbreiden als je dit nodig vind.

Probeer er echter wel voor te zorgen dat je project op het einde compileert. Desnoods zet je niet-werkende code in commentaar.

## Verwachte output

```text
Welcome to Who Sorted this Out

Largest number in values @ index: 2
Largest number in otherValues @ index: 0
Largest number in empty @ index: -1
Is first sorted ascending?: True
Is second sorted ascending?: False
Is third sorted ascending?: False
Is empty sorted ascending?: False
```

## Unit Tests

Het project wordt tevens vergezeld van Unit Tests. Gelieve deze te runnen.
