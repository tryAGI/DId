#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct LLMConfig : global::System.IEquatable<LLMConfig>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.LLMConfigOpenAI? OpenAI { get; init; }
#else
        public global::DId.LLMConfigOpenAI? OpenAI { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAI))]
#endif
        public bool IsOpenAI => OpenAI != null;

        /// <summary>
        /// OpenAI External LLM
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.LLMConfigVariant2? LLMConfigVariant2 { get; init; }
#else
        public global::DId.LLMConfigVariant2? LLMConfigVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LLMConfigVariant2))]
#endif
        public bool IsLLMConfigVariant2 => LLMConfigVariant2 != null;

        /// <summary>
        /// Azure OpenAI External LLM
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.LLMConfigVariant3? LLMConfigVariant3 { get; init; }
#else
        public global::DId.LLMConfigVariant3? LLMConfigVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LLMConfigVariant3))]
#endif
        public bool IsLLMConfigVariant3 => LLMConfigVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.LLMConfigDId? DId { get; init; }
#else
        public global::DId.LLMConfigDId? DId { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DId))]
#endif
        public bool IsDId => DId != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.LLMConfigGoogle? Google { get; init; }
#else
        public global::DId.LLMConfigGoogle? Google { get; }
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
        public static implicit operator LLMConfig(global::DId.LLMConfigOpenAI value) => new LLMConfig((global::DId.LLMConfigOpenAI?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.LLMConfigOpenAI?(LLMConfig @this) => @this.OpenAI;

        /// <summary>
        /// 
        /// </summary>
        public LLMConfig(global::DId.LLMConfigOpenAI? value)
        {
            OpenAI = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMConfig(global::DId.LLMConfigVariant2 value) => new LLMConfig((global::DId.LLMConfigVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.LLMConfigVariant2?(LLMConfig @this) => @this.LLMConfigVariant2;

        /// <summary>
        /// 
        /// </summary>
        public LLMConfig(global::DId.LLMConfigVariant2? value)
        {
            LLMConfigVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMConfig(global::DId.LLMConfigVariant3 value) => new LLMConfig((global::DId.LLMConfigVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.LLMConfigVariant3?(LLMConfig @this) => @this.LLMConfigVariant3;

        /// <summary>
        /// 
        /// </summary>
        public LLMConfig(global::DId.LLMConfigVariant3? value)
        {
            LLMConfigVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMConfig(global::DId.LLMConfigDId value) => new LLMConfig((global::DId.LLMConfigDId?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.LLMConfigDId?(LLMConfig @this) => @this.DId;

        /// <summary>
        /// 
        /// </summary>
        public LLMConfig(global::DId.LLMConfigDId? value)
        {
            DId = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMConfig(global::DId.LLMConfigGoogle value) => new LLMConfig((global::DId.LLMConfigGoogle?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.LLMConfigGoogle?(LLMConfig @this) => @this.Google;

        /// <summary>
        /// 
        /// </summary>
        public LLMConfig(global::DId.LLMConfigGoogle? value)
        {
            Google = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LLMConfig(
            global::DId.LLMConfigOpenAI? openAI,
            global::DId.LLMConfigVariant2? lLMConfigVariant2,
            global::DId.LLMConfigVariant3? lLMConfigVariant3,
            global::DId.LLMConfigDId? dId,
            global::DId.LLMConfigGoogle? google
            )
        {
            OpenAI = openAI;
            LLMConfigVariant2 = lLMConfigVariant2;
            LLMConfigVariant3 = lLMConfigVariant3;
            DId = dId;
            Google = google;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Google as object ??
            DId as object ??
            LLMConfigVariant3 as object ??
            LLMConfigVariant2 as object ??
            OpenAI as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OpenAI?.ToString() ??
            LLMConfigVariant2?.ToString() ??
            LLMConfigVariant3?.ToString() ??
            DId?.ToString() ??
            Google?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenAI || IsLLMConfigVariant2 || IsLLMConfigVariant3 || IsDId || IsGoogle;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::DId.LLMConfigOpenAI?, TResult>? openAI = null,
            global::System.Func<global::DId.LLMConfigVariant2?, TResult>? lLMConfigVariant2 = null,
            global::System.Func<global::DId.LLMConfigVariant3?, TResult>? lLMConfigVariant3 = null,
            global::System.Func<global::DId.LLMConfigDId?, TResult>? dId = null,
            global::System.Func<global::DId.LLMConfigGoogle?, TResult>? google = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAI && openAI != null)
            {
                return openAI(OpenAI!);
            }
            else if (IsLLMConfigVariant2 && lLMConfigVariant2 != null)
            {
                return lLMConfigVariant2(LLMConfigVariant2!);
            }
            else if (IsLLMConfigVariant3 && lLMConfigVariant3 != null)
            {
                return lLMConfigVariant3(LLMConfigVariant3!);
            }
            else if (IsDId && dId != null)
            {
                return dId(DId!);
            }
            else if (IsGoogle && google != null)
            {
                return google(Google!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::DId.LLMConfigOpenAI?>? openAI = null,
            global::System.Action<global::DId.LLMConfigVariant2?>? lLMConfigVariant2 = null,
            global::System.Action<global::DId.LLMConfigVariant3?>? lLMConfigVariant3 = null,
            global::System.Action<global::DId.LLMConfigDId?>? dId = null,
            global::System.Action<global::DId.LLMConfigGoogle?>? google = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAI)
            {
                openAI?.Invoke(OpenAI!);
            }
            else if (IsLLMConfigVariant2)
            {
                lLMConfigVariant2?.Invoke(LLMConfigVariant2!);
            }
            else if (IsLLMConfigVariant3)
            {
                lLMConfigVariant3?.Invoke(LLMConfigVariant3!);
            }
            else if (IsDId)
            {
                dId?.Invoke(DId!);
            }
            else if (IsGoogle)
            {
                google?.Invoke(Google!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenAI,
                typeof(global::DId.LLMConfigOpenAI),
                LLMConfigVariant2,
                typeof(global::DId.LLMConfigVariant2),
                LLMConfigVariant3,
                typeof(global::DId.LLMConfigVariant3),
                DId,
                typeof(global::DId.LLMConfigDId),
                Google,
                typeof(global::DId.LLMConfigGoogle),
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
        public bool Equals(LLMConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::DId.LLMConfigOpenAI?>.Default.Equals(OpenAI, other.OpenAI) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.LLMConfigVariant2?>.Default.Equals(LLMConfigVariant2, other.LLMConfigVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.LLMConfigVariant3?>.Default.Equals(LLMConfigVariant3, other.LLMConfigVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.LLMConfigDId?>.Default.Equals(DId, other.DId) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.LLMConfigGoogle?>.Default.Equals(Google, other.Google) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LLMConfig obj1, LLMConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LLMConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LLMConfig obj1, LLMConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LLMConfig o && Equals(o);
        }
    }
}
