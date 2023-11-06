## 1.Erstellung der Datenbank
### 1.1 Erstellen der Klassen
2 Seperate C# Klassen anlegen in dem Models ordnern.

### 1.2. Erstellen der Context-Klasse

Eine Klass in dem Data-Ordner hinzufügen. Hierbei muss die neue Klasse von DBContext erben.
Um Zugriff auf die Datenbanktabellen zu ermöglichen müssen diese als public DBSet hinzugefügt werden.

### 1.3. Datenbankverbindung einrichten

Hier geibt es mehrere Möglichkeiten das zu machen. In meinem Fall nehme ich den Leichtsinnigen ansatzt und gebe den Connection string hardcodiert in die OnConfigureMethode mit.

>  optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=GameLibrary;Trusted_Connection=True");

### 1.4. Migration

> add-migration InitialSchoolDB

oder

> dotnet ef migrations add InitialSchoolDB


Updaten:
> update-database –verbose

oder

> dotnet ef database update

### 1.5. Daten hinzufügen

Context in der Startmethode instazieren, Methode auskommentieren, Context-Methode AddRange nutzten und am ende eine SaveChanges aufrufen

### 1.6. Updaten der Datenbank

Entity-Klasse Adress erstellen und eine DB-Migration ausführen

### 1.7. Daten updaten

Holl dir aus der Datenbank die DeveloperStudio-Klasse mit dem Namen "Stunlock Studios" und Update die Adresse mit den Folgenden Daten:

* Country: Sweden
* City: Skövde
* Street: Kaplansgaten

### 1.8. Simple Querries

Holl dir alle Spiele von Genre "Soulslike" und gebe diesen einen Rabatt von 5%

Gebe denn Namen des DeveloperStudios und das ReleaseDate der Spiele aus, die jeweils im Genre "OpenWorld" sind

## 2. Configuration der Datenbanktabellen
Es gibt hier zwei Arten die Entitätseigenschaften sowie Relationen anzupassen.

1. Über die Entity-Klasse
2. Über die Fluent API

Hier kann selbst ausgesucht werden welche der zwei Methoden man nutzt. Es werden immer beide Ansätze gezeigt.

#### 2.1. Relationen

Wir fügen eine neue Entity-Klasse namens **Publisher** hinzu. 
Füge die neue Klasse so hinzu das ein DeveloperStudio mehrere Publisher hat und ein Publisher mehrere DevelopStudios (N-to-N-Beziehung).

Die Publisher-Klasse besitzt folgende Merkmale:
* Id -> string
* Name -> string
* Customer -> Liste aus DeveloperStudios
* Costs -> double


#### 2.2. Entitätseigenschaften
Passe folgende Merkmale mit den Entitätseigenschaften an.

* Game-Klasse
	* Name soll eine maximal Länge von 100 haben
	* Decription soll die Maximallänge haben
	* Price soll eine Genauigkeit von 6 und eine Skallierung von 2 haben
	* Releasedate sollte DateTime UTC sein
	* Genres sollte eine maximale Länge von 20 besitzen
	
#### 2.3. ValueObjecte hinzufügen

Aus der Adresse soll jetzt ein ValueObject werden und benötigt somit keine eigene Tabelle und Id mehr. 
Passe die DeveloperStudio und Adress-Klasse so an das die Spalten der DeveloperStudio-Tabelle mit den Adress-Spalten erweitert werden.
Nutze hierfür die Fluent-Api oder die Entitätseigenschaften.

### 2.4. ShadowProperties

Füge die ShadowProperties **UpdatedDate** und **CreatedDate** der Game, DevelopStudio und Publisher-Klasse hinzu 

### 3. Zusätzlichen Code ausführen
Fast Jede Methode der Context-Klasse ist veränderbar und kann überschrieben werden. 
Schreibe die Methoden so um, das wenn eine neue Entity angelegt oder geupdated wird, das heutige Datum in die CreatedDate und UpdatedDate mit geschrieben werden.