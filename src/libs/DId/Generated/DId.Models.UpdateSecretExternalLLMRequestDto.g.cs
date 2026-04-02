#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UpdateSecretExternalLLMRequestDto : global::System.IEquatable<UpdateSecretExternalLLMRequestDto>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.UpdateSecretExternalLLMRequestDtoOpenAIConfiguration? OpenAIConfiguration { get; init; }
#else
        public global::DId.UpdateSecretExternalLLMRequestDtoOpenAIConfiguration? OpenAIConfiguration { get; }
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
        public global::DId.UpdateSecretExternalLLMRequestDtoVariant2? UpdateSecretExternalLLMRequestDtoVariant2 { get; init; }
#else
        public global::DId.UpdateSecretExternalLLMRequestDtoVariant2? UpdateSecretExternalLLMRequestDtoVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateSecretExternalLLMRequestDtoVariant2))]
#endif
        public bool IsUpdateSecretExternalLLMRequestDtoVariant2 => UpdateSecretExternalLLMRequestDtoVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateSecretExternalLLMRequestDto(global::DId.UpdateSecretExternalLLMRequestDtoOpenAIConfiguration value) => new UpdateSecretExternalLLMRequestDto((global::DId.UpdateSecretExternalLLMRequestDtoOpenAIConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.UpdateSecretExternalLLMRequestDtoOpenAIConfiguration?(UpdateSecretExternalLLMRequestDto @this) => @this.OpenAIConfiguration;

        /// <summary>
        /// 
        /// </summary>
        public UpdateSecretExternalLLMRequestDto(global::DId.UpdateSecretExternalLLMRequestDtoOpenAIConfiguration? value)
        {
            OpenAIConfiguration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateSecretExternalLLMRequestDto(global::DId.UpdateSecretExternalLLMRequestDtoVariant2 value) => new UpdateSecretExternalLLMRequestDto((global::DId.UpdateSecretExternalLLMRequestDtoVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.UpdateSecretExternalLLMRequestDtoVariant2?(UpdateSecretExternalLLMRequestDto @this) => @this.UpdateSecretExternalLLMRequestDtoVariant2;

        /// <summary>
        /// 
        /// </summary>
        public UpdateSecretExternalLLMRequestDto(global::DId.UpdateSecretExternalLLMRequestDtoVariant2? value)
        {
            UpdateSecretExternalLLMRequestDtoVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UpdateSecretExternalLLMRequestDto(
            global::DId.UpdateSecretExternalLLMRequestDtoOpenAIConfiguration? openAIConfiguration,
            global::DId.UpdateSecretExternalLLMRequestDtoVariant2? updateSecretExternalLLMRequestDtoVariant2
            )
        {
            OpenAIConfiguration = openAIConfiguration;
            UpdateSecretExternalLLMRequestDtoVariant2 = updateSecretExternalLLMRequestDtoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UpdateSecretExternalLLMRequestDtoVariant2 as object ??
            OpenAIConfiguration as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OpenAIConfiguration?.ToString() ??
            UpdateSecretExternalLLMRequestDtoVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenAIConfiguration || IsUpdateSecretExternalLLMRequestDtoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::DId.UpdateSecretExternalLLMRequestDtoOpenAIConfiguration?, TResult>? openAIConfiguration = null,
            global::System.Func<global::DId.UpdateSecretExternalLLMRequestDtoVariant2?, TResult>? updateSecretExternalLLMRequestDtoVariant2 = null,
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
            else if (IsUpdateSecretExternalLLMRequestDtoVariant2 && updateSecretExternalLLMRequestDtoVariant2 != null)
            {
                return updateSecretExternalLLMRequestDtoVariant2(UpdateSecretExternalLLMRequestDtoVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::DId.UpdateSecretExternalLLMRequestDtoOpenAIConfiguration?>? openAIConfiguration = null,
            global::System.Action<global::DId.UpdateSecretExternalLLMRequestDtoVariant2?>? updateSecretExternalLLMRequestDtoVariant2 = null,
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
            else if (IsUpdateSecretExternalLLMRequestDtoVariant2)
            {
                updateSecretExternalLLMRequestDtoVariant2?.Invoke(UpdateSecretExternalLLMRequestDtoVariant2!);
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
                typeof(global::DId.UpdateSecretExternalLLMRequestDtoOpenAIConfiguration),
                UpdateSecretExternalLLMRequestDtoVariant2,
                typeof(global::DId.UpdateSecretExternalLLMRequestDtoVariant2),
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
        public bool Equals(UpdateSecretExternalLLMRequestDto other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::DId.UpdateSecretExternalLLMRequestDtoOpenAIConfiguration?>.Default.Equals(OpenAIConfiguration, other.OpenAIConfiguration) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.UpdateSecretExternalLLMRequestDtoVariant2?>.Default.Equals(UpdateSecretExternalLLMRequestDtoVariant2, other.UpdateSecretExternalLLMRequestDtoVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateSecretExternalLLMRequestDto obj1, UpdateSecretExternalLLMRequestDto obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateSecretExternalLLMRequestDto>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateSecretExternalLLMRequestDto obj1, UpdateSecretExternalLLMRequestDto obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateSecretExternalLLMRequestDto o && Equals(o);
        }
    }
}
