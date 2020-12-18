# Serious Progress

`ConsoleHelper` is een class die toelaat om strings te builden voor console applicaties. Zo kan het een mooie progress bar genereren die je dan via de console aan de gebruiker kan tonen.

Bv:

```text
------------------------
| #####............... |
------------------------
```

Hierbij wordt de voortgang (progress) weergegeven door hashtags `#` en het resterende gedeelte door puntjes `.`. De totale lengte van de progress bar zelf wordt als argument `maximum` meegegeven terwijl de huidige progress terug te vinden is via `progress`. Je mag er van uit gaan dat `progress` en `maximum` steeds geldige positieve waarden bevatten waarbij `progress` nooit groter is dan `maximum`.

Jouw taak (zie `View => Task List` in Visual Studio) bestaat er nu uit om deze methode `GenerateProgressBar()` te implementeren. Een paar specificaties waaraan de methode moet voldoen zijn:

* Dient de resulteren string te returnen (dus geen `Console.WriteLine` in de methode)
* Maak een kader van dashes `-` en pipes `|`
* Links en rechts van de progress dienen spaties te staan.
* De breedte van het kader is afhankelijk van de maximumwaarde van de progress bar

Indien gewenst mag je gerust private methodes in de class bijmaken.

Je mag de `Main()` methode aanpassen / uitbreiden als je dit nodig vind.

Probeer er echter wel voor te zorgen dat je project op het einde compileert. Desnoods zet je niet-werkende code in commentaar.

## Verwachte output

```text
Welcome to Serious Progress

------------------------
| .................... |
------------------------
------------------------
| #................... |
------------------------
------------------------
| #####............... |
------------------------
------------------------
| #########........... |
------------------------
------------------------
| ##############...... |
------------------------
------------------------
| ##################.. |
------------------------
------------------------
| #################### |
------------------------
```

## Unit Tests

Het project wordt tevens vergezeld van Unit Tests. Gelieve deze te runnen.
