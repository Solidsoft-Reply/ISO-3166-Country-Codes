This simple library supports the resolution of ISO 3166-1 Alpha-2, Alpha-3 and numeric country codes to records containing country information, including the English and French short names of the country.

The code provides three methods to resolve codes:

* GetCountryByAlpha2Code(string)
* GetCountryByAlpha3Code(string)
* GetCountryByNumericCode(string or int)

In each case, the method returns a record containing the full data for the given code, including English and French country names.

In addition, there are several read-only dictionaries relating country names and codes to country records.
