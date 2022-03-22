1. Instalar as dependência nuget
  - Microsoft.EntityFrameworkCore
  - Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.EntityFrameworkCore.Tools
  - Microsoft.EntityFrameworkCore.Design

  2. Criar DbContext
public class BiblioDbContext : DbContext
{
    public BiblioDbContext(DbContextOptions<BiblioDbContext> options) : base(options)
    {
    }
}

3. Configurar a connection string no ficheiro de configuraçãoes (appsettings.json)
  
  "ConnectionStrings": {
    "BiblioConnectionString" :  "Data Source=.\\;Initial Catalog=biblio_local;Integrated Security = True" 
  },


4. Configurar a injeção de dependência do contexto (Program.cs)
var connectionString = builder.Configuration.GetConnectionString("BiblioConnectionString");

builder.Services.AddDbContext<BiblioDbContext>(options =>
    options.UseSqlServer(connectionString));

----------------------------------------------------------------
Desenvolvimento - Sempre que se altera o modelo
----------------------------------------------------------------

1. Alteração do modelo (Entidades, Propriedades, etc.)

2. Declaração das entidades que serão mapeadas em tabelas como propriedades no DbContext
    Exemplo:
        public DbSet<Book> Books { get; set; }
        public DbSet<Country> Countries { get; set; }

3. Criar a migração 
    Comando: add-migration "MigrationName"

4. Atualizar a BD
    Comando: update-database
