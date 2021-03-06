// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for KeyVaultSecretStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum KeyVaultSecretStatus
    {
        [EnumMember(Value = "Initialized")]
        Initialized,
        [EnumMember(Value = "WaitingOnCertificateOrder")]
        WaitingOnCertificateOrder,
        [EnumMember(Value = "Succeeded")]
        Succeeded,
        [EnumMember(Value = "CertificateOrderFailed")]
        CertificateOrderFailed,
        [EnumMember(Value = "OperationNotPermittedOnKeyVault")]
        OperationNotPermittedOnKeyVault,
        [EnumMember(Value = "AzureServiceUnauthorizedToAccessKeyVault")]
        AzureServiceUnauthorizedToAccessKeyVault,
        [EnumMember(Value = "KeyVaultDoesNotExist")]
        KeyVaultDoesNotExist,
        [EnumMember(Value = "KeyVaultSecretDoesNotExist")]
        KeyVaultSecretDoesNotExist,
        [EnumMember(Value = "UnknownError")]
        UnknownError,
        [EnumMember(Value = "ExternalPrivateKey")]
        ExternalPrivateKey,
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    internal static class KeyVaultSecretStatusEnumExtension
    {
        internal static string ToSerializedValue(this KeyVaultSecretStatus? value)
        {
            return value == null ? null : ((KeyVaultSecretStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this KeyVaultSecretStatus value)
        {
            switch( value )
            {
                case KeyVaultSecretStatus.Initialized:
                    return "Initialized";
                case KeyVaultSecretStatus.WaitingOnCertificateOrder:
                    return "WaitingOnCertificateOrder";
                case KeyVaultSecretStatus.Succeeded:
                    return "Succeeded";
                case KeyVaultSecretStatus.CertificateOrderFailed:
                    return "CertificateOrderFailed";
                case KeyVaultSecretStatus.OperationNotPermittedOnKeyVault:
                    return "OperationNotPermittedOnKeyVault";
                case KeyVaultSecretStatus.AzureServiceUnauthorizedToAccessKeyVault:
                    return "AzureServiceUnauthorizedToAccessKeyVault";
                case KeyVaultSecretStatus.KeyVaultDoesNotExist:
                    return "KeyVaultDoesNotExist";
                case KeyVaultSecretStatus.KeyVaultSecretDoesNotExist:
                    return "KeyVaultSecretDoesNotExist";
                case KeyVaultSecretStatus.UnknownError:
                    return "UnknownError";
                case KeyVaultSecretStatus.ExternalPrivateKey:
                    return "ExternalPrivateKey";
                case KeyVaultSecretStatus.Unknown:
                    return "Unknown";
            }
            return null;
        }

        internal static KeyVaultSecretStatus? ParseKeyVaultSecretStatus(this string value)
        {
            switch( value )
            {
                case "Initialized":
                    return KeyVaultSecretStatus.Initialized;
                case "WaitingOnCertificateOrder":
                    return KeyVaultSecretStatus.WaitingOnCertificateOrder;
                case "Succeeded":
                    return KeyVaultSecretStatus.Succeeded;
                case "CertificateOrderFailed":
                    return KeyVaultSecretStatus.CertificateOrderFailed;
                case "OperationNotPermittedOnKeyVault":
                    return KeyVaultSecretStatus.OperationNotPermittedOnKeyVault;
                case "AzureServiceUnauthorizedToAccessKeyVault":
                    return KeyVaultSecretStatus.AzureServiceUnauthorizedToAccessKeyVault;
                case "KeyVaultDoesNotExist":
                    return KeyVaultSecretStatus.KeyVaultDoesNotExist;
                case "KeyVaultSecretDoesNotExist":
                    return KeyVaultSecretStatus.KeyVaultSecretDoesNotExist;
                case "UnknownError":
                    return KeyVaultSecretStatus.UnknownError;
                case "ExternalPrivateKey":
                    return KeyVaultSecretStatus.ExternalPrivateKey;
                case "Unknown":
                    return KeyVaultSecretStatus.Unknown;
            }
            return null;
        }
    }
}
