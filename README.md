<h1 align="center">Описание</h1> 

Одностраничное Web приложение с функцией поиска по базе данных. 

<h2><b>ОБЯЗАТЕЛЬНО!!!</b></h2>

В файл <b>appsettings.json</b> нужно добавить строку подключения к базе данных. 


```
"ConnectionStrings": {
    "DefaultConnection": "Server=myserver;Database=mydb;User=myuser;Password=mypassword;"
  }

```

Замените строку Server=myserver;Database=mydb;User=myuser;Password=mypassword; на свое подключение к базе данных. 

В проекте использовалась MySql.

Также для работы проекта потребуется установить пакеты Nuget:

```
- Pomelo.EntityFrameworkCore.MySql;
- Microsoft.EntityFrameworkCore.Tools;
- Microsoft.EntityFrameworkCore.Design;
```

Перед запуском проекта не забудьте создать миграции через консоль диспетчера пакетов. Иначе проект не запустится, так как нет существующей таблицы.

```
Add-Migration YoursMigration

Update-Database

```

Проект запускался на базе <b>Visual Studio</b>.