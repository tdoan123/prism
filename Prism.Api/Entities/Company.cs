namespace Prism.Api.Entities;

public enum CompanyCategory
{
    Private,
    Public
}

public class Company
{
    public long CompanyId { get; set; }
    public required string CompanyName { get; set; }

    public CompanyCategory CompanyType { get; set; }   // Public or Private
    public DateTime CreatedAt { get; set; }

    public ICollection<CompanyRegistration> Registrations { get; set; } = [];
    public ICollection<CompanyListing> Listings { get; set; } = [];

}
