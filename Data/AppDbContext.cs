using Microsoft.EntityFrameworkCore;
using api_css_cs.Models;

namespace api_css_cs.Data;

/// <summary>
/// O AppDbContext é a ponte entre o código C# e o banco de dados.
/// Ele mapeia as Nossas Models para tabelas no banco de dados.
/// </summary>
public class AppDbContext : DbContext
{
    // Construtor que recebe as configurações do banco (ex: SQLite, connection string)
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    // DbSet representa a tabela no banco de dados.
    // Aqui estamos dizendo que teremos uma tabela chamada "Veiculos" baseada na classe "VeiculoModel".
    public DbSet<VeiculoModel> Veiculos { get; set; }
}