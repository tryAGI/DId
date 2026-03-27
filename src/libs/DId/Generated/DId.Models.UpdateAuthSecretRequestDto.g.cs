#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UpdateAuthSecretRequestDto : global::System.IEquatable<UpdateAuthSecretRequestDto>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.UpdateAuthSecretRequestDtoBasicAuthentication? BasicAuthentication { get; init; }
#else
        public global::DId.UpdateAuthSecretRequestDtoBasicAuthentication? BasicAuthentication { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BasicAuthentication))]
#endif
        public bool IsBasicAuthentication => BasicAuthentication != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.UpdateAuthSecretRequestDtoBearerToken? BearerToken { get; init; }
#else
        public global::DId.UpdateAuthSecretRequestDtoBearerToken? BearerToken { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BearerToken))]
#endif
        public bool IsBearerToken => BearerToken != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.UpdateAuthSecretRequestDtoApiKey? ApiKey { get; init; }
#else
        public global::DId.UpdateAuthSecretRequestDtoApiKey? ApiKey { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiKey))]
#endif
        public bool IsApiKey => ApiKey != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateAuthSecretRequestDto(global::DId.UpdateAuthSecretRequestDtoBasicAuthentication value) => new UpdateAuthSecretRequestDto((global::DId.UpdateAuthSecretRequestDtoBasicAuthentication?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.UpdateAuthSecretRequestDtoBasicAuthentication?(UpdateAuthSecretRequestDto @this) => @this.BasicAuthentication;

        /// <summary>
        /// 
        /// </summary>
        public UpdateAuthSecretRequestDto(global::DId.UpdateAuthSecretRequestDtoBasicAuthentication? value)
        {
            BasicAuthentication = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateAuthSecretRequestDto(global::DId.UpdateAuthSecretRequestDtoBearerToken value) => new UpdateAuthSecretRequestDto((global::DId.UpdateAuthSecretRequestDtoBearerToken?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.UpdateAuthSecretRequestDtoBearerToken?(UpdateAuthSecretRequestDto @this) => @this.BearerToken;

        /// <summary>
        /// 
        /// </summary>
        public UpdateAuthSecretRequestDto(global::DId.UpdateAuthSecretRequestDtoBearerToken? value)
        {
            BearerToken = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateAuthSecretRequestDto(global::DId.UpdateAuthSecretRequestDtoApiKey value) => new UpdateAuthSecretRequestDto((global::DId.UpdateAuthSecretRequestDtoApiKey?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.UpdateAuthSecretRequestDtoApiKey?(UpdateAuthSecretRequestDto @this) => @this.ApiKey;

        /// <summary>
        /// 
        /// </summary>
        public UpdateAuthSecretRequestDto(global::DId.UpdateAuthSecretRequestDtoApiKey? value)
        {
            ApiKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UpdateAuthSecretRequestDto(
            global::DId.UpdateAuthSecretRequestDtoBasicAuthentication? basicAuthentication,
            global::DId.UpdateAuthSecretRequestDtoBearerToken? bearerToken,
            global::DId.UpdateAuthSecretRequestDtoApiKey? apiKey
            )
        {
            BasicAuthentication = basicAuthentication;
            BearerToken = bearerToken;
            ApiKey = apiKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ApiKey as object ??
            BearerToken as object ??
            BasicAuthentication as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BasicAuthentication?.ToString() ??
            BearerToken?.ToString() ??
            ApiKey?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBasicAuthentication || IsBearerToken || IsApiKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::DId.UpdateAuthSecretRequestDtoBasicAuthentication?, TResult>? basicAuthentication = null,
            global::System.Func<global::DId.UpdateAuthSecretRequestDtoBearerToken?, TResult>? bearerToken = null,
            global::System.Func<global::DId.UpdateAuthSecretRequestDtoApiKey?, TResult>? apiKey = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBasicAuthentication && basicAuthentication != null)
            {
                return basicAuthentication(BasicAuthentication!);
            }
            else if (IsBearerToken && bearerToken != null)
            {
                return bearerToken(BearerToken!);
            }
            else if (IsApiKey && apiKey != null)
            {
                return apiKey(ApiKey!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::DId.UpdateAuthSecretRequestDtoBasicAuthentication?>? basicAuthentication = null,
            global::System.Action<global::DId.UpdateAuthSecretRequestDtoBearerToken?>? bearerToken = null,
            global::System.Action<global::DId.UpdateAuthSecretRequestDtoApiKey?>? apiKey = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBasicAuthentication)
            {
                basicAuthentication?.Invoke(BasicAuthentication!);
            }
            else if (IsBearerToken)
            {
                bearerToken?.Invoke(BearerToken!);
            }
            else if (IsApiKey)
            {
                apiKey?.Invoke(ApiKey!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BasicAuthentication,
                typeof(global::DId.UpdateAuthSecretRequestDtoBasicAuthentication),
                BearerToken,
                typeof(global::DId.UpdateAuthSecretRequestDtoBearerToken),
                ApiKey,
                typeof(global::DId.UpdateAuthSecretRequestDtoApiKey),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(UpdateAuthSecretRequestDto other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::DId.UpdateAuthSecretRequestDtoBasicAuthentication?>.Default.Equals(BasicAuthentication, other.BasicAuthentication) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.UpdateAuthSecretRequestDtoBearerToken?>.Default.Equals(BearerToken, other.BearerToken) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.UpdateAuthSecretRequestDtoApiKey?>.Default.Equals(ApiKey, other.ApiKey) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateAuthSecretRequestDto obj1, UpdateAuthSecretRequestDto obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateAuthSecretRequestDto>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateAuthSecretRequestDto obj1, UpdateAuthSecretRequestDto obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateAuthSecretRequestDto o && Equals(o);
        }
    }
}
