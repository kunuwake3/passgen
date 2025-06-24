# TrayPassGen

Простой генератор паролей в трее Windows.

## Возможности

- Левый клик по иконке в трее — генерирует пароль и копирует его в буфер.
- Правый клик — доступ к настройкам.
- Настраиваются:
  - длина пароля;
  - префикс;
  - символы: цифры, буквы, спецсимволы (в том числе безопасные).

## Сборка

```bash
dotnet publish -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true /p:PublishTrimmed=false
