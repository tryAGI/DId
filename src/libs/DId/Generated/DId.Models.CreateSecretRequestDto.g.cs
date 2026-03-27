#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateSecretRequestDto : global::System.IEquatable<CreateSecretRequestDto>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.CreateSecretRequestDtoBasicAuthentication? BasicAuthentication { get; init; }
#else
        public global::DId.CreateSecretRequestDtoBasicAuthentication? BasicAuthentication { get; }
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
        public global::DId.CreateSecretRequestDtoBearerToken? BearerToken { get; init; }
#else
        public global::DId.CreateSecretRequestDtoBearerToken? BearerToken { get; }
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
        public global::DId.CreateSecretRequestDtoApiKey? ApiKey { get; init; }
#else
        public global::DId.CreateSecretRequestDtoApiKey? ApiKey { get; }
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
        public static implicit operator CreateSecretRequestDto(global::DId.CreateSecretRequestDtoBasicAuthentication value) => new CreateSecretRequestDto((global::DId.CreateSecretRequestDtoBasicAuthentication?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.CreateSecretRequestDtoBasicAuthentication?(CreateSecretRequestDto @this) => @this.BasicAuthentication;

        /// <summary>
        /// 
        /// </summary>
        public CreateSecretRequestDto(global::DId.CreateSecretRequestDtoBasicAuthentication? value)
        {
            BasicAuthentication = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateSecretRequestDto(global::DId.CreateSecretRequestDtoBearerToken value) => new CreateSecretRequestDto((global::DId.CreateSecretRequestDtoBearerToken?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.CreateSecretRequestDtoBearerToken?(CreateSecretRequestDto @this) => @this.BearerToken;

        /// <summary>
        /// 
        /// </summary>
        public CreateSecretRequestDto(global::DId.CreateSecretRequestDtoBearerToken? value)
        {
            BearerToken = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateSecretRequestDto(global::DId.CreateSecretRequestDtoApiKey value) => new CreateSecretRequestDto((global::DId.CreateSecretRequestDtoApiKey?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.CreateSecretRequestDtoApiKey?(CreateSecretRequestDto @this) => @this.ApiKey;

        /// <summary>
        /// 
        /// </summary>
        public CreateSecretRequestDto(global::DId.CreateSecretRequestDtoApiKey? value)
        {
            ApiKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateSecretRequestDto(
            global::DId.CreateSecretRequestDtoBasicAuthentication? basicAuthentication,
            global::DId.CreateSecretRequestDtoBearerToken? bearerToken,
            global::DId.CreateSecretRequestDtoApiKey? apiKey
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
            global::System.Func<global::DId.CreateSecretRequestDtoBasicAuthentication?, TResult>? basicAuthentication = null,
            global::System.Func<global::DId.CreateSecretRequestDtoBearerToken?, TResult>? bearerToken = null,
            global::System.Func<global::DId.CreateSecretRequestDtoApiKey?, TResult>? apiKey = null,
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
            global::System.Action<global::DId.CreateSecretRequestDtoBasicAuthentication?>? basicAuthentication = null,
            global::System.Action<global::DId.CreateSecretRequestDtoBearerToken?>? bearerToken = null,
            global::System.Action<global::DId.CreateSecretRequestDtoApiKey?>? apiKey = null,
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
                typeof(global::DId.CreateSecretRequestDtoBasicAuthentication),
                BearerToken,
                typeof(global::DId.CreateSecretRequestDtoBearerToken),
                ApiKey,
                typeof(global::DId.CreateSecretRequestDtoApiKey),
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
        public bool Equals(CreateSecretRequestDto other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::DId.CreateSecretRequestDtoBasicAuthentication?>.Default.Equals(BasicAuthentication, other.BasicAuthentication) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.CreateSecretRequestDtoBearerToken?>.Default.Equals(BearerToken, other.BearerToken) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.CreateSecretRequestDtoApiKey?>.Default.Equals(ApiKey, other.ApiKey) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateSecretRequestDto obj1, CreateSecretRequestDto obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateSecretRequestDto>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateSecretRequestDto obj1, CreateSecretRequestDto obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateSecretRequestDto o && Equals(o);
        }
    }
}
