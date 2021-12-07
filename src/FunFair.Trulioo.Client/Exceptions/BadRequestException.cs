using System;
using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Exceptions;

public sealed class BadRequestException : RequestException
{
    internal BadRequestException(string message, int code, string reason)
        : base(message: message, code: code, reason: reason)
    {
    }

    /// <inheritdoc />
    [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
    public BadRequestException()
        : base(message: "", code: -1, reason: "")
    {
    }

    /// <inheritdoc />
    [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
    public BadRequestException(string message)
        : base(message: message, code: -1, reason: "")
    {
    }

    /// <inheritdoc />
    [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
    public BadRequestException(string message, Exception innerException)
        : base(message: message, code: -1, reason: innerException.Message)
    {
    }
}