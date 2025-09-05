Pet-проект RESTful Web API для управления списком покупателей, реализующее CRUD операции. Проект реализован на ASP.NET Core и использует SQL Server в качестве базы данных.

🧪 Процесс разработки
Цель: Целью проекта было закрепить на практике основы создания RESTful API на ASP.NET Core, работы с базой данных через Entity Framework и организации кода.
Подход: Был использован подход, где Controllers обрабатывают HTTP-запросы, Models представляют структуру данных, а база данных выступает в роли хранилища.

Что было изучено/закреплено:
Создание Web API проектов в ASP.NET Core.
Настройка подключения к SQL Server с помощью EF Core.
Реализация CRUD-операций в контроллерах.
Настройка маршрутизации (routing) и методов HTTP.
Использование Swagger для автоматической документации API.
Управление зависимостями с помощью NuGet.

🚀 Функциональность
Проект предоставляет стандартные CRUD-операции (Create, Read, Update, Delete) для работы с сущностью Customer:

GET (Read): Получение списка всех элементов или конкретного элемента по его идентификатору.
POST (Create): Добавление нового элемента.
PUT (Update): Полное обновление существующего элемента по идентификатору.
DELETE (Delete): Удаление элемента по идентификатору.

🛠️ Технологический стек
Бэкенд: ASP.NET Core 8
База данных: Microsoft SQL Server
ORM: Entity Framework Core
Документация API: Swagger
Инструменты разработки: Visual Studio, SQL Server Management Studio (SSMS)
Система контроля версий: Git

Проект использует модели C#, которые являются основой для таблиц в базе данных.
Пример сущности:
```C#
public class Customer
{
    public int Id { get; set; } // первичный ключ 
    public required string Name { get; set; }
    public required string Email { get; set; }
    public string? Phone { get; set; }
    public decimal Spend { get; set; }
}
```
🚦 Запуск проекта
Чтобы запустить проект локально необходимо настроить базу данных (установка и запуск SQL Server).
После этого в файле appsettings.json необходимо изменить строку подключения на свою:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=your_server_name;Database=YourDatabaseName;Trusted_Connection=True;TrustServerCertificate=True;"
}
```
После этого нобходимо будет применить миграции. Для этого в терминале необходимо выполнить команду:
```bash
  Update-Database
```

📖 Использование Swagger
Этот проект использует Swagger для автоматической генерации интерактивной документации API.
Что вы увидите:
Список всех контроллеров(один из них уже был при создании проекта в VS). Каждый контроллер группирует endpoints для работы с одной сущностью.
Список всех API endpoints (GET, POST, PUT, DELETE).
Описание каждого endpoint: URL, параметры, формат тела запроса и возможные коды ответов (200 OK, 404 Not Found и т.д.).
Интерактивное тестирование: Вы можете развернуть любой endpoint, нажать кнопку "Try it out", ввести необходимые данные (для POST/PUT) и выполнить запрос прямо из браузера. Сервер обработает ваш запрос и покажет реальный ответ.

Начальное окно при запуске Swagger:
<img width="1080" height="1368" alt="image" src="https://github.com/user-attachments/assets/98fcb64d-b61c-439c-830d-6ac445101480" />

Пример тела POST запроса:
<img width="1007" height="883" alt="image" src="https://github.com/user-attachments/assets/c0242cde-0482-4d4b-8a8c-457e881b4c81" />


