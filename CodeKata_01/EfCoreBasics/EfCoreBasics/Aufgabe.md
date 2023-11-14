
# Aufgaben
Das allgemeine Ziel bei diesen Code-Katas ist es die grundlegenden Ef-Core Funktionen zu zeigen. Hierbei wird der sogennante Code-First approache genutzt. 
Mit diesem Approache ist es möglich Datenbanktabellen und Datenbanken aus dem Code zu konifugrieren und zu genererieren.
Es gibt noch das Database-First Approache, welchen wir hier ignorieren werden.

Ziel ist es am Ende zu Wissen:
* Wie man eine Datenbank anhand von Code erstellen kann
* Wie man die Datenbank konfigurieren kann
* Wie man Relationen mit EfCore abbilden kann
* Wie man auf die Daten zugreift


Quellen die für das Bearbeiten von dieser Aufgabe hilfreich sein können:

https://learn.microsoft.com/de-de/ef/

https://www.entityframeworktutorial.net/efcore/entity-framework-core.aspx


## 1.Erstellung der Datenbank
### 1.1 Erstellen der Klassen
Erstelle die folgende Seperate C# Entity-Klassen:

* Klasse: Student 
	* Merkmale:
		- StudentId -> int
		- Name -> string
		- LastName -> string
		- Classyear -> string
		- Birthdate -> Date

* Klasse: Classroom
	* Merkmale:
		- CalssroomId -> int
		- Name -> string
		- Seats -> int
		
Diese beiden Klassen sollen eine 1 zu N Relation zu einander haben. 

"Eine Classroom hat mehrere Studenten und ein Student ist in einem Classroom" 

### 1.2. Erstellen der Context-Klasse

Erstelle eine Context-Klasse namens SchoolContext 
Füge der Context-Klasse die definierten Entity-Klassen **Student** und **Classroom** hinzu.

### 1.3. Datenbankverbindung einrichten

Übergebe der Context-Klasse den Connection-String zur Datenbank. Hierbei können wir uns mit der Lokale-Datenbank verbinden, da diese Standartmäßig in MSQL vorhanden ist.
Der Datenbankname kann hier frei gewählt werden. Ich habe beispielsweise hier denn Namen "SchoolDB" gewählt.

### 1.4. Migration

Leite die erste Migration ein und initiere die Datenbank.
Sobald du das gemacht hast, guck dir das Ergeniss in der Lokalen Datenbank an.

### 1.5. Updaten der Datenbank

In der Klasse Student fehlen noch weitere Informationen bezüglich der Adresse.
Füger der Klasse **Students** folgende Merkmale hinzu und update die Datenbank.

* Country -> String
* City -> String
* Street -> String
* HouseNumber -> int


## 2. Configuration der Datenbanktabellen

Wenn es in Richtung Konfiguration der Datenbanktabellen geht gibt es in EFCore zwei Möglichkeiten das zu machen.

1. Über die Entity-Klasse anhand Attribute
2. Über die Fluent API in der Context-Klasse

Hier kann selbst ausgesucht werden welche der zwei Methoden man nutzt. Begründet aber bitte eure Entscheidung wieso ihr euch für eines der Beiden entschieden habt.

Ich werde versuchen beide Ansätze zu zeigen.

### 2.1. Entitätseigenschaften
Passe folgende Merkmale mit den Entitätseigenschaften an.

* Student-Klasse
	* Name
		* Type: nvarchar 
		* Maximallänge 100
		* Nicht null
	* Nachname
		* Type: nvarchar 
		* Darf die Maximallänge haben
		* Nicht null
	* Classyear
		* Type: varchar 
		* Maximallänge 15
		* Nicht null
	* Birthdate
		* Darf nicht null sein 

* Classroom-Klasse
	* Seats
		* Nicht Null
	* Id
		* Soll zu ClassroomNumber umbenannt werden
	* Name
		* Soll unique sein

### 2.2. Relationen
One-To-One, Many-To-Many, One-To-Many

Wir haben bereits eine One-To-Many Relationship erfolgreich hinzugefügt. 
Jetzt wollen wir aber auch sehen wie mit Ef-Core andere Relationships umgesetzt werden können.

Dementsprechend benötigen wir folgende Klassen:

* Klasse: Teacher
	* TeacherId -> int
	* Name -> string
	* LastName -> string
	* Age -> int
	* Salary -> double
	
* Klasse: Course
	* CourseId -> int
	* Subject -> string
	* Duration -> floate

One-To-One
Ein **Classroom** hat einen oder keinen **Teacher**. Ein **Teacher** hält sein Vortrag in einem **Classroom**.

Many-To-Many
Ein **Student** hat mehrere **Courses**. Ein **Course** hat mehrere **Students**.
	
### 2.3. ValueObjecte hinzufügen

Momentan haben wir es so, dass die Adresse aus multiplen Merkmale in der Klasse **Students* besteht.
Wir wollen aber daraus ein ValueObject machen. 
Verändere die Merkmale des Students so, das Adresse ein eigenständiges Object ist, aber dennoch als einzelne Spalten in die gleiche Tabelle geschrieben wird.
Die Adresse darf Null sein.

### 2.4. Vererbung

Es gibt jetzt auch statt nur **Teacher** noch **Professoren** und **Tutoren**. 
Lege die Klassen so an, das hierzu keine neue Tabelle angelegt wird sondern die Teacher-Klasse erweitert wird. 

* Professor
	* Titel -> string
* Tutor
	* LearnGroup -> string

Hier gibt es mehrere Ansätze:

* TPT (Table per Type)
* TPC (Table per concrete Type)
* TPH (Table per Hirachie)

Hierbei kannst du eine oder alle Methoden mal ausprobieren :)

Was fällt dir auf? Was denkst du ist die bessere Variante? Vor und Nachteile?

### 2.5. TestDaten hinzufügen

Erweitere die Start Methode so, das die Daten die hier erzeugt werden auf die Datenbank geschrieben werden. Sobald du das hast, führe die Anwendung aus.
Überprüfe das Ergebnis in deiner Datenbank. Sind die Daten erfolgreich reingeschrieben worden?


### 2.6. Arbeiten mit der Context-Klasse
Hier paar simple Querries, damit man so weiß wie man auf Daten in der Datenbank zugreifen kann.

* Füge ein neuen Kurs hinzu.
* Lösche den Kurs mit dem Inhalt "Autotunning leicht gemacht".
* Das Klassenzimmer "R305" wurde erweitert. Es gibt jetzt 15 mehr Sitzplätze in dem Raum. 
* Holl alle Schüler aus der Klasse 7b und gebe ihre Namen aus.
* Erhöhe den gehalt aller Lehrer um 5%.
* Erstelle ein neuen Kurs und füge diesem den Schülern, die ein J im Namen haben, hinzu.

### 2.6. ShadowProperties

Füge jeder Entity die ShadowPropertie "CreatedDate" und "UpdatedDate" hinzu.

Passe die Context-Klasse so an, dass auch automatisch bei jedem Hinzugügen oder Updaten einer Entity die Daten gesetzt werden.
