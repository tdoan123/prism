namespace Prism.Api.Entities;

public class CompanyListing
{
    public long CompanyListingId { get; set; }
    public long CompanyId { get; set; }

    public int ExchangeId { get; set; }
    public string? TicketSymbol { get; set; }

    public string? PrimaryCountryListing { get; set; }

    public Company Company { get; set; } = null!;

    public Exchange Exchange { get; set; } = null!;
}
