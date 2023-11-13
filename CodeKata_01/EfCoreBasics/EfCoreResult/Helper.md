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

Rollback:

> dotnet ef database update <previous-migration-name>
