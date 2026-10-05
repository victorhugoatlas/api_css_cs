```markdown
# api_css_cs 💻

API RESTful simples desenvolvida em C# (.NET 10) para o gerenciamento do estoque de veículos de uma concessionária.

## 💻 Technologies

* C# (.NET 10)
* ASP.NET Core Web API
* Entity Framework Core
* SQLite
* Scalar (OpenAPI / Swagger Documentation)

### Prerequisites

* .NET 10 SDK
* Git

### Cloning

```bash
git clone https://github.com/victorhugoatlas/api_css_cs

```

### Starting

```bash
cd api_css_cs
dotnet restore
dotnet ef database update
dotnet run

```

Acesse a documentação no navegador: `https://localhost:PORTA/scalar/v1`

## 📍 API Endpoints

| Route | Description |
| --- | --- |
| `GET /api/veiculo` | Lista todos os veículos do estoque |
| `GET /api/veiculo/{id}` | Busca os detalhes de um veículo pelo ID |
| `POST /api/veiculo` | Cadastra um novo veículo no estoque |
| `PUT /api/veiculo/{id}` | Atualiza os dados de um veículo existente |
| `DELETE /api/veiculo/{id}` | Remove um veículo do estoque |

### GET /api/veiculo

RESPONSE

```json
[
  {
    "id": 1,
    "marca": "BMW",
    "modelo": "R 1300 GS",
    "versao": "PREMIUM TRIPLE BLACK ASA",
    "anoFabricacao": 2025,
    "anoModelo": 2026,
    "placa": "GSA1R30",
    "km": 2680,
    "preco": 137000.00,
    "cor": "PRETO"
  }
]

```

### POST /api/veiculo

REQUEST

```json
{
  "marca": "BMW",
  "modelo": "R 1300 GS",
  "versao": "PREMIUM TRIPLE BLACK ASA",
  "anoFabricacao": 2025,
  "anoModelo": 2026,
  "placa": "GSA1R30",
  "km": 2680,
  "preco": 137000.00,
  "cor": "PRETO"
}

```

RESPONSE

```json
{
  "id": 1,
  "marca": "BMW",
  "modelo": "R 1300 GS",
  "versao": "PREMIUM TRIPLE BLACK ASA",
  "anoFabricacao": 2025,
  "anoModelo": 2026,
  "placa": "GSA1R30",
  "km": 2680,
  "preco": 137000.00,
  "cor": "PRETO"
}

```