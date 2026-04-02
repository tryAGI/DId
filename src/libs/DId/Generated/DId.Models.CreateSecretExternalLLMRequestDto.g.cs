#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateSecretExternalLLMRequestDto : global::System.IEquatable<CreateSecretExternalLLMRequestDto>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.CreateSecretExternalLLMRequestDtoOpenAIConfiguration? OpenAIConfiguration { get; init; }
#else
        public global::DId.CreateSecretExternalLLMRequestDtoOpenAIConfiguration? OpenAIConfiguration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIConfiguration))]
#endif
        public bool IsOpenAIConfiguration => OpenAIConfiguration != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.CreateSecretExternalLLMRequestDtoVariant2? CreateSecretExternalLLMRequestDtoVariant2 { get; init; }
#else
        public global::DId.CreateSecretExternalLLMRequestDtoVariant2? CreateSecretExternalLLMRequestDtoVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateSecretExternalLLMRequestDtoVariant2))]
#endif
        public bool IsCreateSecretExternalLLMRequestDtoVariant2 => CreateSecretExternalLLMRequestDtoVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateSecretExternalLLMRequestDto(global::DId.CreateSecretExternalLLMRequestDtoOpenAIConfiguration value) => new CreateSecretExternalLLMRequestDto((global::DId.CreateSecretExternalLLMRequestDtoOpenAIConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.CreateSecretExternalLLMRequestDtoOpenAIConfiguration?(CreateSecretExternalLLMRequestDto @this) => @this.OpenAIConfiguration;

        /// <summary>
        /// 
        /// </summary>
        public CreateSecretExternalLLMRequestDto(global::DId.CreateSecretExternalLLMRequestDtoOpenAIConfiguration? value)
        {
            OpenAIConfiguration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateSecretExternalLLMRequestDto(global::DId.CreateSecretExternalLLMRequestDtoVariant2 value) => new CreateSecretExternalLLMRequestDto((global::DId.CreateSecretExternalLLMRequestDtoVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.CreateSecretExternalLLMRequestDtoVariant2?(CreateSecretExternalLLMRequestDto @this) => @this.CreateSecretExternalLLMRequestDtoVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreateSecretExternalLLMRequestDto(global::DId.CreateSecretExternalLLMRequestDtoVariant2? value)
        {
            CreateSecretExternalLLMRequestDtoVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateSecretExternalLLMRequestDto(
            global::DId.CreateSecretExternalLLMRequestDtoOpenAIConfiguration? openAIConfiguration,
            global::DId.CreateSecretExternalLLMRequestDtoVariant2? createSecretExternalLLMRequestDtoVariant2
            )
        {
            OpenAIConfiguration = openAIConfiguration;
            CreateSecretExternalLLMRequestDtoVariant2 = createSecretExternalLLMRequestDtoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateSecretExternalLLMRequestDtoVariant2 as object ??
            OpenAIConfiguration as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OpenAIConfiguration?.ToString() ??
            CreateSecretExternalLLMRequestDtoVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenAIConfiguration || IsCreateSecretExternalLLMRequestDtoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::DId.CreateSecretExternalLLMRequestDtoOpenAIConfiguration?, TResult>? openAIConfiguration = null,
            global::System.Func<global::DId.CreateSecretExternalLLMRequestDtoVariant2?, TResult>? createSecretExternalLLMRequestDtoVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAIConfiguration && openAIConfiguration != null)
            {
                return openAIConfiguration(OpenAIConfiguration!);
            }
            else if (IsCreateSecretExternalLLMRequestDtoVariant2 && createSecretExternalLLMRequestDtoVariant2 != null)
            {
                return createSecretExternalLLMRequestDtoVariant2(CreateSecretExternalLLMRequestDtoVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::DId.CreateSecretExternalLLMRequestDtoOpenAIConfiguration?>? openAIConfiguration = null,
            global::System.Action<global::DId.CreateSecretExternalLLMRequestDtoVariant2?>? createSecretExternalLLMRequestDtoVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAIConfiguration)
            {
                openAIConfiguration?.Invoke(OpenAIConfiguration!);
            }
            else if (IsCreateSecretExternalLLMRequestDtoVariant2)
            {
                createSecretExternalLLMRequestDtoVariant2?.Invoke(CreateSecretExternalLLMRequestDtoVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenAIConfiguration,
                typeof(global::DId.CreateSecretExternalLLMRequestDtoOpenAIConfiguration),
                CreateSecretExternalLLMRequestDtoVariant2,
                typeof(global::DId.CreateSecretExternalLLMRequestDtoVariant2),
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
        public bool Equals(CreateSecretExternalLLMRequestDto other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::DId.CreateSecretExternalLLMRequestDtoOpenAIConfiguration?>.Default.Equals(OpenAIConfiguration, other.OpenAIConfiguration) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.CreateSecretExternalLLMRequestDtoVariant2?>.Default.Equals(CreateSecretExternalLLMRequestDtoVariant2, other.CreateSecretExternalLLMRequestDtoVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateSecretExternalLLMRequestDto obj1, CreateSecretExternalLLMRequestDto obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateSecretExternalLLMRequestDto>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateSecretExternalLLMRequestDto obj1, CreateSecretExternalLLMRequestDto obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateSecretExternalLLMRequestDto o && Equals(o);
        }
    }
}
