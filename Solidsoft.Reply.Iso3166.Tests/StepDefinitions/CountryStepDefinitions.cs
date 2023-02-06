using Solidsoft.Reply.Iso3166;

namespace Solidsoft.Reply.Iso3166Country.Tests.StepDefinitions;

[Binding]
public sealed class CountryStepDefinitions {

    private string _englishShortName = string.Empty;
    private string _frenchShortName = string.Empty;
    private string _alpha2Code = string.Empty;
    private string _alpha3Code = string.Empty;
    private string _numericCode = string.Empty;
    private ICountry _country = new NoCountry();
    private IReadOnlyDictionary<string, ICountry> _selectedDictionary;

    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    [Given("the Alpha-2 country code is (.*)")]
    public void GivenTheAlpha2CountryCodeIs(string alpha2Code)
    {
        _country = new NoCountry();
        _alpha2Code = alpha2Code;
    }

    [Given("the Alpha-3 country code is (.*)")]
    public void GivenTheAlpha3CountryCodeIs(string alpha3Code) {
        _alpha3Code = alpha3Code;
    }

    [Given("the numeric country code is (.*)")]
    public void GivenTheNumericCountryCodeIs(string numericCode) {
        _numericCode = numericCode;
    }

    [Given("the country name in English is (.*)")]
    public void GivenTheCountryNameInEnglishIs(string englishShortName) {
        _englishShortName = englishShortName;
    }

    [Given("the country name in French is (.*)")]
    public void GivenTheCountryNameInFrenchIs(string frenchShortName) {
        _frenchShortName = frenchShortName;
    }

    [When("I retrieve the country using the Alpha-2 country code")]
    public void WhenIRetrieveTheCountryUsingTheAlpha2CountryCode()
    {
        _country = Country.GetCountryByAlpha2Code(_alpha2Code);
    }

    [When("I retrieve the country using the Alpha-3 country code")]
    public void WhenIRetrieveTheCountryUsingTheAlpha3CountryCode() {
        _country = Country.GetCountryByAlpha3Code(_alpha3Code);
    }

    [When("I retrieve the country using the numeric country code")]
    public void WhenIRetrieveTheCountryUsingTheNumericCountryCode() {
        _country = Country.GetCountryByNumericCode(_numericCode);
    }

    [When("I retrieve the country record from the dictionary using the English country name")]
    public void WhenIRetrieveTheCountryRecordFromTheDictionaryUsingTheEnglishCountryName() {
        _country = Country.EnglishNames[_englishShortName];
    }

    [When("I retrieve the country record from the dictionary using the French country name")]
    public void WhenIRetrieveTheCountryRecordFromTheDictionaryUsingTheFrenchCountryName() {
        _country = Country.FrenchNames[_frenchShortName];
    }


    [When("I retrieve the country record from the dictionary using the Alpha-2 country code")]
    public void WhenIRetrieveTheCountryRecordFromTheDictionaryUsingTheAlpha2CountryCode() {
        _country = Country.Alpha2Codes[_alpha2Code];
    }


    [When("I retrieve the country record from the dictionary using the Alpha-3 country code")]
    public void WhenIRetrieveTheCountryRecordFromTheDictionaryUsingTheAlpha3CountryCode() {
        _country = Country.Alpha3Codes[_alpha3Code];
    }


    [When("I retrieve the country record from the dictionary using the numeric country code")]
    public void WhenIRetrieveTheCountryRecordFromTheDictionaryUsingTheNumericCountryCode() {
        _country = Country.NumericCodes[_numericCode];
    }

    [Then("the English short name should be (.*)")]
    public void ThenTheEnglishShortNameShouldBe(string englishShortName) {
        _country.EnglishShortName.Should().Be(englishShortName);
    }

    [Then("the French short name should be (.*)")]
    public void ThenTheFrenchShortNameShouldBe(string frenchShortName) {
        _country.FrenchShortName.Should().Be(frenchShortName);
    }


    [Then("the Alpha-2 code should be (.*)")]
    public void ThenTheAlpha2CodeShouldBe(string alpha2Code) {
        _country.Alpha2Code.Should().Be(alpha2Code);
    }


    [Then("the Alpha-3 code should be (.*)")]
    public void ThenTheAlpha3CodeShouldBe(string alpha3Code) {
        _country.Alpha3Code.Should().Be(alpha3Code);
    }


    [Then("the numeric code should be (.*)")]
    public void ThenTheNumericCodeShouldBe(string numericCode) {
        _country.Numeric.Should().Be(numericCode);
    }

    [Given("the dictionary is (.*)")]
    public void ThenTheDictionaryIs(string dictionaryName) {
        _selectedDictionary = dictionaryName switch
        {
            "EnglishNames" => Country.EnglishNames,
            "FrenchNames" => Country.FrenchNames,
            "Alpha2Codes" => Country.Alpha2Codes,
            "Alpha3Codes" => Country.Alpha3Codes,
            "NumericCodes" => Country.NumericCodes,
            _ => throw new ArgumentOutOfRangeException(nameof(dictionaryName), dictionaryName, null)
        };
    }

    [Then("the expected number of entries is (.*)")]
    public void ThenTheExpectedNumberOfEntriesIs(int expectedCount) {
        _selectedDictionary.Count.Should().Be(expectedCount);
    }
}

internal class NoCountry : ICountry
{
    public string EnglishShortName => string.Empty;
    public string FrenchShortName => string.Empty;
    public string Alpha2Code => string.Empty;
    public string Alpha3Code => string.Empty;
    public string Numeric => string.Empty;
}