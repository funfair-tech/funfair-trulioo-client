using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     Fields specific for the country the verification is being done for.
    ///     Call configuration/v1/fields/Identity Verification/countryCode to get the list of fields that are valid for your configuration
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
    public class CountrySpecific : Dictionary<string, Dictionary<string, string>>
    {
    }
}


