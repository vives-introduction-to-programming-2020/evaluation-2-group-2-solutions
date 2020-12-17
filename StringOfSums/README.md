# String of Sums

`SumParser` is een class die toelaat om een som string te parsen die voldoet aan het formaat: `A+B`, waarbij `A` en `B` beide positieve gehele waarden zijn.

Bv.:

* `"3+5"`, waarbij `3` dan de eerste operand is en `5` de tweede.

Jouw taak (zie `View => Task List` in Visual Studio) bestaat uit het implementeren van de methode `SolveSum()` die de string binnen krijgt als argument en het resultaat van de som dient te berekenen en teruggeven als `int`.

Je mag er van uitgaan dat de `string` die de methode binnen krijgt geldig is, enkel positieve getallen bevat en altijd een plus `+` teken bevat.

Je mag de `Main()` methode aanpassen / uitbreiden als je dit nodig vind.

Probeer er echter wel voor te zorgen dat je project op het einde compileert. Desnoods zet je niet-werkende code in commentaar.

## Verwachte output

```text
Welcome to String of Sums

2+4 = 6
17+21 = 38
88+12 = 100
66+23 = 89
```

## Unit Tests

Het project wordt tevens vergezeld van Unit Tests. Gelieve deze te runnen.
