<h1 align="center">��������</h1> 

�������������� Web ���������� � �������� ������ �� ���� ������. 

<h2><b>�����������!!!</b></h2>

� ���� <b>appsettings.json</b> ����� �������� ������ ����������� � ���� ������. 


```
"ConnectionStrings": {
    "DefaultConnection": "Server=myserver;Database=mydb;User=myuser;Password=mypassword;"
  }

```

�������� ������ Server=myserver;Database=mydb;User=myuser;Password=mypassword; �� ���� ����������� � ���� ������. 

� ������� �������������� MySql.

����� ��� ������ ������� ����������� ���������� ������ Nuget:

```
- Pomelo.EntityFrameworkCore.MySql;
- Microsoft.EntityFrameworkCore.Tools;
- Microsoft.EntityFrameworkCore.Design;
```

����� �������� ������� �� �������� ������� �������� ����� ������� ���������� �������. ����� ������ �� ����������, ��� ��� ��� ������������ �������.

```
Add-Migration YoursMigration

Update-Database

```

������ ���������� �� ���� <b>Visual Studio</b>.