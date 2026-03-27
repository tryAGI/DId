#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TextToSpeechProviders : global::System.IEquatable<TextToSpeechProviders>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.TextToSpeechProvidersMicrosoft? Microsoft { get; init; }
#else
        public global::DId.TextToSpeechProvidersMicrosoft? Microsoft { get; }
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
        public global::DId.TextToSpeechProvidersElevenLabs? ElevenLabs { get; init; }
#else
        public global::DId.TextToSpeechProvidersElevenLabs? ElevenLabs { get; }
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
        public global::DId.TextToSpeechProvidersAmazon? Amazon { get; init; }
#else
        public global::DId.TextToSpeechProvidersAmazon? Amazon { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Amazon))]
#endif
        public bool IsAmazon => Amazon != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.TextToSpeechProvidersGoogle? Google { get; init; }
#else
        public global::DId.TextToSpeechProvidersGoogle? Google { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Google))]
#endif
        public bool IsGoogle => Google != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.TextToSpeechProvidersOpenAI? OpenAI { get; init; }
#else
        public global::DId.TextToSpeechProvidersOpenAI? OpenAI { get; }
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
        public static implicit operator TextToSpeechProviders(global::DId.TextToSpeechProvidersMicrosoft value) => new TextToSpeechProviders((global::DId.TextToSpeechProvidersMicrosoft?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.TextToSpeechProvidersMicrosoft?(TextToSpeechProviders @this) => @this.Microsoft;

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechProviders(global::DId.TextToSpeechProvidersMicrosoft? value)
        {
            Microsoft = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToSpeechProviders(global::DId.TextToSpeechProvidersElevenLabs value) => new TextToSpeechProviders((global::DId.TextToSpeechProvidersElevenLabs?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.TextToSpeechProvidersElevenLabs?(TextToSpeechProviders @this) => @this.ElevenLabs;

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechProviders(global::DId.TextToSpeechProvidersElevenLabs? value)
        {
            ElevenLabs = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToSpeechProviders(global::DId.TextToSpeechProvidersAmazon value) => new TextToSpeechProviders((global::DId.TextToSpeechProvidersAmazon?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.TextToSpeechProvidersAmazon?(TextToSpeechProviders @this) => @this.Amazon;

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechProviders(global::DId.TextToSpeechProvidersAmazon? value)
        {
            Amazon = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToSpeechProviders(global::DId.TextToSpeechProvidersGoogle value) => new TextToSpeechProviders((global::DId.TextToSpeechProvidersGoogle?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.TextToSpeechProvidersGoogle?(TextToSpeechProviders @this) => @this.Google;

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechProviders(global::DId.TextToSpeechProvidersGoogle? value)
        {
            Google = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToSpeechProviders(global::DId.TextToSpeechProvidersOpenAI value) => new TextToSpeechProviders((global::DId.TextToSpeechProvidersOpenAI?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.TextToSpeechProvidersOpenAI?(TextToSpeechProviders @this) => @this.OpenAI;

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechProviders(global::DId.TextToSpeechProvidersOpenAI? value)
        {
            OpenAI = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechProviders(
            global::DId.TextToSpeechProvidersMicrosoft? microsoft,
            global::DId.TextToSpeechProvidersElevenLabs? elevenLabs,
            global::DId.TextToSpeechProvidersAmazon? amazon,
            global::DId.TextToSpeechProvidersGoogle? google,
            global::DId.TextToSpeechProvidersOpenAI? openAI
            )
        {
            Microsoft = microsoft;
            ElevenLabs = elevenLabs;
            Amazon = amazon;
            Google = google;
            OpenAI = openAI;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OpenAI as object ??
            Google as object ??
            Amazon as object ??
            ElevenLabs as object ??
            Microsoft as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Microsoft?.ToString() ??
            ElevenLabs?.ToString() ??
            Amazon?.ToString() ??
            Google?.ToString() ??
            OpenAI?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMicrosoft || IsElevenLabs || IsAmazon || IsGoogle || IsOpenAI;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::DId.TextToSpeechProvidersMicrosoft?, TResult>? microsoft = null,
            global::System.Func<global::DId.TextToSpeechProvidersElevenLabs?, TResult>? elevenLabs = null,
            global::System.Func<global::DId.TextToSpeechProvidersAmazon?, TResult>? amazon = null,
            global::System.Func<global::DId.TextToSpeechProvidersGoogle?, TResult>? google = null,
            global::System.Func<global::DId.TextToSpeechProvidersOpenAI?, TResult>? openAI = null,
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
            else if (IsAmazon && amazon != null)
            {
                return amazon(Amazon!);
            }
            else if (IsGoogle && google != null)
            {
                return google(Google!);
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
            global::System.Action<global::DId.TextToSpeechProvidersMicrosoft?>? microsoft = null,
            global::System.Action<global::DId.TextToSpeechProvidersElevenLabs?>? elevenLabs = null,
            global::System.Action<global::DId.TextToSpeechProvidersAmazon?>? amazon = null,
            global::System.Action<global::DId.TextToSpeechProvidersGoogle?>? google = null,
            global::System.Action<global::DId.TextToSpeechProvidersOpenAI?>? openAI = null,
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
            else if (IsAmazon)
            {
                amazon?.Invoke(Amazon!);
            }
            else if (IsGoogle)
            {
                google?.Invoke(Google!);
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
                typeof(global::DId.TextToSpeechProvidersMicrosoft),
                ElevenLabs,
                typeof(global::DId.TextToSpeechProvidersElevenLabs),
                Amazon,
                typeof(global::DId.TextToSpeechProvidersAmazon),
                Google,
                typeof(global::DId.TextToSpeechProvidersGoogle),
                OpenAI,
                typeof(global::DId.TextToSpeechProvidersOpenAI),
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
        public bool Equals(TextToSpeechProviders other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::DId.TextToSpeechProvidersMicrosoft?>.Default.Equals(Microsoft, other.Microsoft) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.TextToSpeechProvidersElevenLabs?>.Default.Equals(ElevenLabs, other.ElevenLabs) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.TextToSpeechProvidersAmazon?>.Default.Equals(Amazon, other.Amazon) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.TextToSpeechProvidersGoogle?>.Default.Equals(Google, other.Google) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.TextToSpeechProvidersOpenAI?>.Default.Equals(OpenAI, other.OpenAI) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TextToSpeechProviders obj1, TextToSpeechProviders obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextToSpeechProviders>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TextToSpeechProviders obj1, TextToSpeechProviders obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextToSpeechProviders o && Equals(o);
        }
    }
}
