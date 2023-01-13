


```

# Add new migration
dotnet ef migrations add InitialCreate  --project EFTestingWithSql.Data --startup-project EFTestingWithSql.WebApi

# Remove last migration
dotnet ef migrations remove --project EFTestingWithSql.Data --startup-project EFTestingWithSql.WebApi

# Apply Migrations
dotnet ef database update --project EFTestingWithSql.Data --startup-project EFTestingWithSql.WebApi

```