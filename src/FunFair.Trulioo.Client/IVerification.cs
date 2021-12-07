using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using FunFair.Trulioo.Client.Model;

namespace FunFair.Trulioo.Client;

public interface IVerification
{
    [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
    Task<VerifyResult> VerifyAsync(VerifyRequest request);
}