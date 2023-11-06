
## Aufgaben
Die Aufgabe bei diesen Code-Katas ist es die grundlegenden Ef-Core Funktionen zu zeigen. Hierbei wird der sogennante Code-First approache genutzt. 
Mit diesem Approache ist es möglich Datenbanktabellen und Datenbanken aus dem Code zu konifugrieren und zu genererieren.
Es gibt noch das Database-First Approache, welchen wir hier ignorieren werden.

Quellen die für das Bearbeiten von dieser Aufgabe hilfreich sein können:

https://learn.microsoft.com/de-de/ef/
https://www.entityframeworktutorial.net/efcore/entity-framework-core.aspx

## 1.Erstellung der Datenbank
### 1.1 Erstellen der Klassen
Erstelle die folgende Seperate C# Entity-Klassen:

* Klasse: Game 
* Merkmale:
	- GameId -> int
	- Name -> string
	- Description -> string
	- Price -> double
	- ReleaseDate -> Date
	- DeveloperStudio -> DeveloperStudio
	- Genres -> Liste aus strings

* Klasse: DeveloperStudio
* Merkmale:
	- DeveloperStudioId -> int
	- Name -> sting
	- Description -> string
	- Games -> Liste aus Game
	- Founder -> string
	- FoundingDate -> date

### 1.2. Erstellen der Context-Klasse

Erstelle eine Context-Klasse namens GameLibraryContext 

Füge der Context-Klasse die definierten Entity-Klassen **Game** und **DeveloperStudio** hinzu.

### 1.3. Datenbankverbindung einrichten

Übergebe der Context-Klasse den Connection-String zur Datenbank. Hierbei können wir uns mit der Lokale-Datenbank verbinden, da diese Standartmäßig in MSQL vorhanden ist.
Der Datenbankname kann hier frei gewählt werden. Ich habe beispielsweise hier denn Namen "GameLibrary" gewählt.

### 1.4. Migration

Leite die erste Migration ein. Sobald du das gemacht hast, guck dir das Ergeniss in der Lokalen Datenbank an.

### 1.5. Daten hinzufügen

Erweitere die Start methode so, das die Daten die hier erzeugt werden auf die Datenbank geschrieben werden. Sobald du das hast, führe die Anwendung aus.

Überprüfe das Ergebnis in deiner Datenbank. Sind die Daten erfolgreich reingeschrieben worden?

### 1.6. Updaten der Datenbank

In der Klasse DeveloperStudio fehlt noch weitere Informationen, füge diese hinzu und update die Datenbank.

* DeveloperStudio
	* Country -> String
	* City -> String

### 1.7. Simple Querries
Holl dir aus der Datenbank die DeveloperStudio-Klasse mit dem Namen "Stunlock Studios" und Update die Adresse mit den Folgenden Daten:

* Country: Sweden
* City: Skövde

Holl dir alle Spiele von Genre "Soulslike" und gebe diesen einen Rabatt von 5%

Gebe denn Namen des DeveloperStudios der Spiele aus, die jeweils im Genre "OpenWorld" sind

## 2. Configuration der Datenbanktabellen
Es gibt hier zwei Arten die Entitätseigenschaften sowie Relationen anzupassen.

1. Über die Entity-Klasse
2. Über die Fluent API

Hier kann selbst ausgesucht werden welche der zwei Methoden man nutzt. Es werden immer beide Ansätze gezeigt.

#### 2.1. Entitätseigenschaften
Passe folgende Merkmale mit den Entitätseigenschaften an.

* Game-Klasse
	* Name soll eine maximal Länge von 100 haben und sollte von Typ varchar sein
	* Decription soll die Maximallänge haben und sollte von Typ varchar sein
	* Price soll eine Genauigkeit von 6 und eine Skallierung von 2 haben und vom Typ decimal sein
	* Genres sollte eine maximale Länge von 20 besitzen und Typ varchar sein
	* Description darf nullable sein
* DeveloperStudio-Klasse
	* City und Country dürfen nullable sein
	* Der Name sollte nicht länger als 100 sein
	* Die strings hier sollten auch vom Typ varchar sein

#### 2.2. Relationen

Wir fügen eine neue Entity-Klasse namens **Publisher** hinzu. 
Füge die neue Klasse so hinzu das ein DeveloperStudio mehrere Publisher hat und ein Publisher mehrere DevelopStudios (N-to-N-Beziehung).

Die Publisher-Klasse besitzt folgende Merkmale:
* Id -> string
* Name -> string
* Customer -> Liste aus DeveloperStudios
* Budged -> double
	
#### 2.3. ValueObjecte hinzufügen

Aus der Adresse soll jetzt ein ValueObject werden und benötigt somit keine eigene Tabelle und Id mehr. 
Passe die DeveloperStudio und Adress-Klasse so an das die Spalten der DeveloperStudio-Tabelle mit den Adress-Spalten erweitert werden.
Nutze hierfür die Fluent-Api oder die Entitätseigenschaften.

### 2.4. ShadowProperties

Füge die ShadowProperties **UpdatedDate** und **CreatedDate** der Game, DevelopStudio und Publisher-Klasse hinzu 

### 3. Zusätzlichen Code ausführen
Fast Jede Methode der Context-Klasse ist veränderbar und kann überschrieben werden. 
Schreibe die Methoden so um, das wenn eine neue Entity angelegt oder geupdated wird, das heutige Datum in die CreatedDate und UpdatedDate mit geschrieben werden.