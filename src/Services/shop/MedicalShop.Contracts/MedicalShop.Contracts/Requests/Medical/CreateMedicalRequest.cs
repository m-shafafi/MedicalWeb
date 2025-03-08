namespace MedicalShop.Contracts.Requests.Medicals;

public record CreateMedicalRequest(string Title, string Description, string Category);