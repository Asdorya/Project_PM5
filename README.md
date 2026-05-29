# Equipment Rental

Десктопное приложение для аренды оборудования на **Windows Forms** (.NET 8) с базой данных **MySQL**.

## Требования

- Windows 10/11
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [MySQL Server](https://dev.mysql.com/downloads/mysql/) (порт **3306**)
- [MySQL Connector/NET](https://dev.mysql.com/downloads/connector/net/) 9.7 (сборка `MySql.Data.dll`)

## Настройка базы данных

1. Запустите MySQL Server.
2. Создайте базу и таблицу пользователей (в MySQL Workbench или командной строке):
3. При необходимости измените строку подключения в файле `DB.cs`:

```
server=localhost;port=3306;username=root;password=root;database=equipments
```

Укажите свои логин, пароль и имя базы, если они отличаются от значений по умолчанию.

## Подключение MySQL Connector

В проекте используется ссылка на `MySql.Data.dll` из папки установки Connector/NET:

`C:\Program Files (x86)\MySQL\MySQL Connector NET 9.7\MySql.Data.dll`

Установите Connector/NET или поправьте путь в `Equipment_rental.csproj`, если библиотека лежит в другом месте.

## Сборка и запуск

### Через командную строку

Откройте терминал в папке проекта и выполните:

```bash
dotnet build
dotnet run
```

### Через Visual Studio

1. Откройте файл `Equipment_rental.csproj`.
2. Нажмите **F5** (запуск с отладкой) или **Ctrl+F5** (без отладки).

### Готовый исполняемый файл

После успешной сборки можно запустить:

`bin\Debug\net8.0-windows\Equipment_rental.exe`

## Работа с приложением

1. При старте открывается главное окно (**MainForm**).
2. Нажмите кнопку входа — откроется форма авторизации (**LoginForm**).
3. Для регистрации нового пользователя перейдите на форму регистрации (**RegistreForm**) с экрана входа.
4. Для входа нужны логин, пароль и код с картинки (капча).

Убедитесь, что MySQL запущен и база `equipments` создана — иначе при входе и регистрации появятся ошибки подключения.

# Er-диаграмма базы данных

erDiagram
    ROLES ||--o{ USERS : "assigns"
    USERS ||--o{ LOGIN_ATTEMPTS : "makes"
    USERS ||--o{ RENTAL_CONTRACTS : "processes"
    USERS ||--o{ RENTAL_CONTRACTS : "rents"
    EQUIPMENT ||--o{ RENTAL_CONTRACTS : "rented in"
    RENTAL_CONTRACTS ||--o{ RETURNS : "has"
    RENTAL_CONTRACTS ||--o{ PENALTIES : "has"

    ROLES {
        int id PK
        string name
    }

    USERS {
        int id PK
        string login UK
        string password_hash
        string password_salt
        int role_id FK
        timestamp created_at
    }

    LOGIN_ATTEMPTS {
        int id PK
        int user_id FK
        boolean is_success
        string message
        timestamp created_at
    }

    EQUIPMENT {
        int id PK
        string name
        string category
        string status
        decimal price_per_day
        string serial_number UK
        text description
        int quantity
        timestamp created_at
    }

    RENTAL_CONTRACTS {
        int id PK
        int customer_id FK
        int processed_by_user_id FK
        string contract_number UK
        date rental_start_date
        date rental_end_date
        decimal total_cost
        string status
        timestamp created_at
    }

    RETURNS {
        int id PK
        int contract_id FK
        date actual_return_date
        date expected_return_date
        int days_over_due
        text notes
        timestamp created_at
    }

    PENALTIES {
        int id PK
        int rental_contract_id FK
        string penalty_type
        decimal amount
        date issued_date
        string status
        text description
        timestamp created_at
    }
