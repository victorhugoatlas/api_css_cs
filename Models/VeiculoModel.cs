namespace api_css_cs.Models;

public class VeiculoModel
{
    public int Id { get; set; }

    // Fabricante (Ex: BMW, Volkswagen)
    public string Marca { get; set; } = string.Empty;

    // Modelo (Ex: F 800 GS, Golf)
    public string Modelo { get; set; } = string.Empty;

    // Versão (Ex: Trophy, Triple Black, Highline)
    public string Versao { get; set; } = string.Empty;

    // Ano em que o veículo foi fabricado (Ex: 2017)
    public int AnoFabricacao { get; set; }

    // Ano do modelo (Ex: 2018)
    public int AnoModelo { get; set; }

    // Placa do veículo
    public string Placa { get; set; } = string.Empty;

    // Quilometragem atual
    public int Km { get; set; }

    // Preço de venda
    public decimal Preco { get; set; }

    // Cor do veículo
    public string Cor { get; set; } = string.Empty;
}