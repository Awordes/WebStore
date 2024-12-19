namespace WebStore.Infrastructure.Options;

public class PostgreDbOptions
{
    public const string SectionName = nameof(PostgreDbOptions);

    public required string ConnectionString { get; init; }

    public required string SchemaName { get; init; }

    public PostgreSqlVersion? PostgreSqlVersion { get; init; }
}

public class PostgreSqlVersion
{
    public int Major { get; init; }

    public int Minor { get; init; }
}
