### 1. Минимальный. Parent может быть null у дитя

- создается теневое свойство AuthorId у книги
- AuthorId у книги может быть null
- запрещено каскадное удаление - On Delete = no_action