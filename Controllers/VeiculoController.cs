using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api_css_cs.Data;
using api_css_cs.Models;

namespace api_css_cs.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VeiculoController : ControllerBase
{
    private readonly AppDbContext _context;

    // Injeção de dependência do AppDbContext para acessar o banco SQLite
    public VeiculoController(AppDbContext context)
    {
        _context = context;
    }

    // 1. GET: api/veiculo (Buscar Todos os Veículos)
    [HttpGet]
    public async Task<ActionResult<List<VeiculoModel>>> BuscarVeiculos()
    {
        var veiculos = await _context.Veiculos.ToListAsync();
        return Ok(veiculos);
    }

    // 2. GET: api/veiculo/1 (Buscar Veículo por ID)
    [HttpGet("{id}")]
    public async Task<ActionResult<VeiculoModel>> BuscarVeiculoPorId(int id)
    {
        var veiculo = await _context.Veiculos.FindAsync(id);

        if (veiculo == null)
            return NotFound("Veículo não encontrado no estoque.");

        return Ok(veiculo);
    }

    // 3. POST: api/veiculo (Cadastrar Novo Veículo)
    [HttpPost]
    public async Task<ActionResult<VeiculoModel>> CriarVeiculo(VeiculoModel veiculoModel)
    {
        if (veiculoModel == null)
            return BadRequest("Dados do veículo inválidos.");

        _context.Veiculos.Add(veiculoModel);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(BuscarVeiculoPorId), new { id = veiculoModel.Id }, veiculoModel);
    }

    // 4. PUT: api/veiculo/1 (Atualizar Veículo Existente)
    [HttpPut("{id}")]
    public async Task<IActionResult> EditarVeiculo(int id, VeiculoModel veiculoModel)
    {
        var veiculo = await _context.Veiculos.FindAsync(id);

        if (veiculo == null)
            return NotFound("Veículo não encontrado no estoque.");

        // Atualiza as propriedades com os novos dados recebidos
        veiculo.Marca = veiculoModel.Marca;
        veiculo.Modelo = veiculoModel.Modelo;
        veiculo.Versao = veiculoModel.Versao;
        veiculo.AnoFabricacao = veiculoModel.AnoFabricacao;
        veiculo.AnoModelo = veiculoModel.AnoModelo;
        veiculo.Placa = veiculoModel.Placa;
        veiculo.Km = veiculoModel.Km;
        veiculo.Preco = veiculoModel.Preco; // <--- Adicionado
        veiculo.Cor = veiculoModel.Cor;     // <--- Adicionado

        _context.Veiculos.Update(veiculo);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    // 5. DELETE: api/veiculo/1 (Remover Veículo do Estoque)
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletarVeiculo(int id)
    {
        var veiculo = await _context.Veiculos.FindAsync(id);

        if (veiculo == null)
            return NotFound("Veículo não encontrado no estoque.");

        _context.Veiculos.Remove(veiculo);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}