/* Copyright 2023 Solidsoft Reply Ltd.

 *     Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 *     You may obtain a copy of the License at

 * http://www.apache.org/licenses/LICENSE-2.0

 * Unless required by applicable law or agreed to in writing, software
 *     distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *     See the License for the specific language governing permissions and
 * limitations under the License.
 * */

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