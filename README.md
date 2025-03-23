# Problem Plecakowy
**Patrycja Biskot, 275456**


Projekt rozwiązuje problem plecakowy za pomocą algorytmu zachłannego. Posiada prostą aplikację konsolową, graficzny interfejs użytkownika, oraz testy jednostkowe dla aplikacji konsolowej.

## Aplikacja Konsolowa
### Klasy:
<ul>
<li>Klasa Item - przechowuje informacje o poszczególnym przedmiocie (id, value <1, 10>, weight <1, 10>)</li>
<li>Klasa Problem - tworzy instancję problemu do rozwiązania (lista przedmiotów) i zawiera metodę Solve do rozwiązania problemu</li>
<li>Klasa Result - przechowuje informacje o wyniku rozwiązania problemu (lista id przedmiotów, całkowita waga i całkowita wartość przedmiotów)</li>
</ul>

  ### Metoda rozwiązania:
Metoda Solve (klasa Problem) przyjmuje jako parametr pojemność plecaka i zwraca wynik w postaci obiektu klasy Result.
Lista przedmiotów jest sortowana malejąco według stosunku wartości przedmiotu do jego wagi. Następnie przeprowadzana jest weryfikacja wszystkich przedmiotów z posortowanej listy, aby sprawdzić, czy jeszcze mieszczą się w plecaku.
Jeśli przedmiot można umieścić w plecaku, jego id dodawane jest do listy w obiekcie klasy Result i zwiększana jest całkowita waga oraz wartość przedmiotów.

## Testy jednostkowe
Testy zostały wykonane przy pomocy MsTest.
<ul>
  <li>Metoda TestMinOneValidOption - sprawdza czy jeśli co najmniej jeden przedmiot może być dodany do plecaka to wynik nie jest pusty, tj. lista ids posiada elementy i całkowita waga/wartość jest nie zerowa</li>
  <li>Metoda TestNoValidOption - sprawdza czy jeśli istnieją przedmioty, ale nie mogą być dodane do plecaka (za mała pojemność) to wynik jest pusty, tj. lista ids nie posiada elementów i całkowita waga/wartość jest zerowa</li>
  <li>Metoda TestCorrectSolution - sprawdza czy dla określonej instancji problemu wynik jest poprawny, tj. lista zawiera odpowiednie numery przedmiotów, całkowita waga i wartość mają oczekiwane wartości</li>
  <li>Metoda TestCorrectInstance - sprawdza czy poprawnie są tworzone poszczególne przedmioty, tj. waga i wartość przedmiotu jest losowana z przedziału od 1 do 10</li>
  <li>Metoda TestEmptyProblem - sprawdza czy jeśli nie istnieją jakiekolwiek przedmioty to wynik jest pusty, tj. lista ids nie posiada elementów i całkowita waga/wartość jest równa zero</li>
</ul>

## Graficzny interfejs użytkownika
Interfejs został wykonany za pomocą Windows Forms. Użytkownik ma możliwość wprowadzenia informacji o źródle losowania (seed), rozmiarze plecaka oraz liczbie wygenerowanych przedmiotów.
Po naciśnieciu przycisku Run program uruchamia się oraz wyświetla wygenerowaną instancję problemu oraz jej rozwiązanie. W przypadku wprowadzenia nieodpowiedniej wartości przez użytkownika (np. litery) pole zmienia kolor na czerwony i nie generuje się instancja oraz jej rozwiązanie.

### Główne metody:
<ul>
  <li>ButtonRun_Click - sprawdza czy wprowadzono poprawne wartości, jeśli są poprawne to tworzy instancję problemu i jej rozwiązanie, wyświetla wynik w aplikacji, jeśli dane są niepoprawne to kończy swoje działanie</li>
  <li>ValidateInputSeed - sprawdza czy wprowadzone ziarno jest poprawne, tj. jest liczbą typu intiger; jeśli jest poprawna to zmienia kolor okna na zielony i zwraca prawdę, jeśli nie to zmienia kolor na czerwony i zwraca fałsz</li>
  <li>ValidateInputNumber - sprawdza czy wprowadzona liczba przedmiotów jest poprawna, tj. jest liczbą nieujemną typu intiger; jeśli jest poprawna to zmienia kolor okna na zielony i zwraca prawdę, jeśli nie to zmienia kolor na czerwony i zwraca fałsz</li>
  <li>ValidateInputCapacity - sprawdza czy wprowadzona pojemność plecaka jest poprawna, tj. jest liczbą nieujemną typu intiger; jeśli jest poprawna to zmienia kolor okna na zielony i zwraca prawdę, jeśli nie to zmienia kolor na czerwony i zwraca fałsz</li>
</ul>
