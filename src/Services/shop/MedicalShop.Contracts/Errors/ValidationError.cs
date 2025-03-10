namespace MedicalShop.Contracts.Errors;

public class ValidationError
{
    public string Property { get; set; } = string.Empty;
    public string ErrorMessage { get; set; } = string.Empty;
}
