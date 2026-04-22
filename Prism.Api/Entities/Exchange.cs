using System;

namespace Prism.Api.Entities;

public class Exchange
{
    public int ExchangeId { get; set; }

    public required string ExchangeCode { get; set; }

    public required string ExchangeName { get; set; }

    public required string CountryCode { get; set; }

    public ICollection<CompanyListing> Listings { get; set; } = [];
}
