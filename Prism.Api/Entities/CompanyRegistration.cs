using System;
using System.Data;

namespace Prism.Api.Entities;

public class CompanyRegistration
{
    public long CompanyRegistrationId { get; set; }
    public long CompanyId { get; set; }
    public required string RegistrationNumber { get; set; }
    public string? RegistrationAuthority { get; set; }
    public string? CountryCode { get; set; }
    public string? StateOrProvince { get; set; }
    public DateTime? RegistrationDate { get; set; }
    public Company Company { get; set; } = null!;

}
