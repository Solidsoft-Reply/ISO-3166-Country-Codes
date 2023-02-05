namespace Solidsoft.Reply.Iso3166;

/// <summary>
/// Represents a country record.
/// </summary>
public interface ICountry {
    /// <summary>
    /// Gets the short name of the country in English.
    /// </summary>
    string EnglishShortName { get; }

    /// <summary>
    /// Gets the short name of the country in French.
    /// </summary>
    string FrenchShortName { get; }

    /// <summary>
    /// Gets the Alpha-2 country code.
    /// </summary>
    string Alpha2Code { get; }

    /// <summary>
    /// Gets the Alpha-3 country code.
    /// </summary>
    public string Alpha3Code { get; }

    /// <summary>
    /// Gets the numeric country code.
    /// </summary>
    public string Numeric { get; }
}