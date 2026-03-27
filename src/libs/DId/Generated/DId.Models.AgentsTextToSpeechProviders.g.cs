#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AgentsTextToSpeechProviders : global::System.IEquatable<AgentsTextToSpeechProviders>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.AgentsTextToSpeechProvidersMicrosoft? Microsoft { get; init; }
#else
        public global::DId.AgentsTextToSpeechProvidersMicrosoft? Microsoft { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Microsoft))]
#endif
        public bool IsMicrosoft => Microsoft != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.AgentsTextToSpeechProvidersElevenLabs? ElevenLabs { get; init; }
#else
        public global::DId.AgentsTextToSpeechProvidersElevenLabs? ElevenLabs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ElevenLabs))]
#endif
        public bool IsElevenLabs => ElevenLabs != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.AgentsTextToSpeechProvidersOpenAI? OpenAI { get; init; }
#else
        public global::DId.AgentsTextToSpeechProvidersOpenAI? OpenAI { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAI))]
#endif
        public bool IsOpenAI => OpenAI != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentsTextToSpeechProviders(global::DId.AgentsTextToSpeechProvidersMicrosoft value) => new AgentsTextToSpeechProviders((global::DId.AgentsTextToSpeechProvidersMicrosoft?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.AgentsTextToSpeechProvidersMicrosoft?(AgentsTextToSpeechProviders @this) => @this.Microsoft;

        /// <summary>
        /// 
        /// </summary>
        public AgentsTextToSpeechProviders(global::DId.AgentsTextToSpeechProvidersMicrosoft? value)
        {
            Microsoft = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentsTextToSpeechProviders(global::DId.AgentsTextToSpeechProvidersElevenLabs value) => new AgentsTextToSpeechProviders((global::DId.AgentsTextToSpeechProvidersElevenLabs?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.AgentsTextToSpeechProvidersElevenLabs?(AgentsTextToSpeechProviders @this) => @this.ElevenLabs;

        /// <summary>
        /// 
        /// </summary>
        public AgentsTextToSpeechProviders(global::DId.AgentsTextToSpeechProvidersElevenLabs? value)
        {
            ElevenLabs = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentsTextToSpeechProviders(global::DId.AgentsTextToSpeechProvidersOpenAI value) => new AgentsTextToSpeechProviders((global::DId.AgentsTextToSpeechProvidersOpenAI?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.AgentsTextToSpeechProvidersOpenAI?(AgentsTextToSpeechProviders @this) => @this.OpenAI;

        /// <summary>
        /// 
        /// </summary>
        public AgentsTextToSpeechProviders(global::DId.AgentsTextToSpeechProvidersOpenAI? value)
        {
            OpenAI = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentsTextToSpeechProviders(
            global::DId.AgentsTextToSpeechProvidersMicrosoft? microsoft,
            global::DId.AgentsTextToSpeechProvidersElevenLabs? elevenLabs,
            global::DId.AgentsTextToSpeechProvidersOpenAI? openAI
            )
        {
            Microsoft = microsoft;
            ElevenLabs = elevenLabs;
            OpenAI = openAI;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OpenAI as object ??
            ElevenLabs as object ??
            Microsoft as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Microsoft?.ToString() ??
            ElevenLabs?.ToString() ??
            OpenAI?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMicrosoft || IsElevenLabs || IsOpenAI;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::DId.AgentsTextToSpeechProvidersMicrosoft?, TResult>? microsoft = null,
            global::System.Func<global::DId.AgentsTextToSpeechProvidersElevenLabs?, TResult>? elevenLabs = null,
            global::System.Func<global::DId.AgentsTextToSpeechProvidersOpenAI?, TResult>? openAI = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMicrosoft && microsoft != null)
            {
                return microsoft(Microsoft!);
            }
            else if (IsElevenLabs && elevenLabs != null)
            {
                return elevenLabs(ElevenLabs!);
            }
            else if (IsOpenAI && openAI != null)
            {
                return openAI(OpenAI!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::DId.AgentsTextToSpeechProvidersMicrosoft?>? microsoft = null,
            global::System.Action<global::DId.AgentsTextToSpeechProvidersElevenLabs?>? elevenLabs = null,
            global::System.Action<global::DId.AgentsTextToSpeechProvidersOpenAI?>? openAI = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMicrosoft)
            {
                microsoft?.Invoke(Microsoft!);
            }
            else if (IsElevenLabs)
            {
                elevenLabs?.Invoke(ElevenLabs!);
            }
            else if (IsOpenAI)
            {
                openAI?.Invoke(OpenAI!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Microsoft,
                typeof(global::DId.AgentsTextToSpeechProvidersMicrosoft),
                ElevenLabs,
                typeof(global::DId.AgentsTextToSpeechProvidersElevenLabs),
                OpenAI,
                typeof(global::DId.AgentsTextToSpeechProvidersOpenAI),
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
        public bool Equals(AgentsTextToSpeechProviders other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::DId.AgentsTextToSpeechProvidersMicrosoft?>.Default.Equals(Microsoft, other.Microsoft) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.AgentsTextToSpeechProvidersElevenLabs?>.Default.Equals(ElevenLabs, other.ElevenLabs) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.AgentsTextToSpeechProvidersOpenAI?>.Default.Equals(OpenAI, other.OpenAI) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentsTextToSpeechProviders obj1, AgentsTextToSpeechProviders obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentsTextToSpeechProviders>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentsTextToSpeechProviders obj1, AgentsTextToSpeechProviders obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentsTextToSpeechProviders o && Equals(o);
        }
    }
}
