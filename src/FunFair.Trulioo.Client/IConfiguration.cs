using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace FunFair.Trulioo.Client;

public interface IConfiguration
{
    [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
    Task<Dictionary<string, dynamic>> GetFieldsAsync(string countryCode, string configurationName);

    [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
    Task<IEnumerable<string>> GetСonsentsAsync(string countryCode, string configurationName);

    [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
    Task<IEnumerable<string>> GetCountryCodesAsync(string configurationName);
}