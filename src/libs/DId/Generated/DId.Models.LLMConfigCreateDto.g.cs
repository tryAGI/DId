#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct LLMConfigCreateDto : global::System.IEquatable<LLMConfigCreateDto>
    {
        /// <summary>
        /// Create-request shapes: `provider` is required. Plain interfaces (no Omit/Pick) so TSOA can generate routes.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.LLMConfigCreateDtoVariant1? Value1 { get; init; }
#else
        public global::DId.LLMConfigCreateDtoVariant1? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.LLMConfigCreateDtoVariant2? Value2 { get; init; }
#else
        public global::DId.LLMConfigCreateDtoVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.LLMConfigCreateDtoVariant3? Value3 { get; init; }
#else
        public global::DId.LLMConfigCreateDtoVariant3? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.LLMConfigCreateDtoVariant4? Value4 { get; init; }
#else
        public global::DId.LLMConfigCreateDtoVariant4? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.LLMConfigCreateDtoVariant5? Value5 { get; init; }
#else
        public global::DId.LLMConfigCreateDtoVariant5? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.LLMConfigCreateDtoVariant6? Value6 { get; init; }
#else
        public global::DId.LLMConfigCreateDtoVariant6? Value6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value6))]
#endif
        public bool IsValue6 => Value6 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMConfigCreateDto(global::DId.LLMConfigCreateDtoVariant1 value) => new LLMConfigCreateDto((global::DId.LLMConfigCreateDtoVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.LLMConfigCreateDtoVariant1?(LLMConfigCreateDto @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public LLMConfigCreateDto(global::DId.LLMConfigCreateDtoVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMConfigCreateDto(global::DId.LLMConfigCreateDtoVariant2 value) => new LLMConfigCreateDto((global::DId.LLMConfigCreateDtoVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.LLMConfigCreateDtoVariant2?(LLMConfigCreateDto @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public LLMConfigCreateDto(global::DId.LLMConfigCreateDtoVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMConfigCreateDto(global::DId.LLMConfigCreateDtoVariant3 value) => new LLMConfigCreateDto((global::DId.LLMConfigCreateDtoVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.LLMConfigCreateDtoVariant3?(LLMConfigCreateDto @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public LLMConfigCreateDto(global::DId.LLMConfigCreateDtoVariant3? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMConfigCreateDto(global::DId.LLMConfigCreateDtoVariant4 value) => new LLMConfigCreateDto((global::DId.LLMConfigCreateDtoVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.LLMConfigCreateDtoVariant4?(LLMConfigCreateDto @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public LLMConfigCreateDto(global::DId.LLMConfigCreateDtoVariant4? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMConfigCreateDto(global::DId.LLMConfigCreateDtoVariant5 value) => new LLMConfigCreateDto((global::DId.LLMConfigCreateDtoVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.LLMConfigCreateDtoVariant5?(LLMConfigCreateDto @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public LLMConfigCreateDto(global::DId.LLMConfigCreateDtoVariant5? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMConfigCreateDto(global::DId.LLMConfigCreateDtoVariant6 value) => new LLMConfigCreateDto((global::DId.LLMConfigCreateDtoVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.LLMConfigCreateDtoVariant6?(LLMConfigCreateDto @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public LLMConfigCreateDto(global::DId.LLMConfigCreateDtoVariant6? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LLMConfigCreateDto(
            global::DId.LLMConfigCreateDtoVariant1? value1,
            global::DId.LLMConfigCreateDtoVariant2? value2,
            global::DId.LLMConfigCreateDtoVariant3? value3,
            global::DId.LLMConfigCreateDtoVariant4? value4,
            global::DId.LLMConfigCreateDtoVariant5? value5,
            global::DId.LLMConfigCreateDtoVariant6? value6
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
            Value6 = value6;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value6 as object ??
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() ??
            Value4?.ToString() ??
            Value5?.ToString() ??
            Value6?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3 || IsValue4 || IsValue5 || IsValue6;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::DId.LLMConfigCreateDtoVariant1?, TResult>? value1 = null,
            global::System.Func<global::DId.LLMConfigCreateDtoVariant2?, TResult>? value2 = null,
            global::System.Func<global::DId.LLMConfigCreateDtoVariant3?, TResult>? value3 = null,
            global::System.Func<global::DId.LLMConfigCreateDtoVariant4?, TResult>? value4 = null,
            global::System.Func<global::DId.LLMConfigCreateDtoVariant5?, TResult>? value5 = null,
            global::System.Func<global::DId.LLMConfigCreateDtoVariant6?, TResult>? value6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }
            else if (IsValue6 && value6 != null)
            {
                return value6(Value6!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::DId.LLMConfigCreateDtoVariant1?>? value1 = null,
            global::System.Action<global::DId.LLMConfigCreateDtoVariant2?>? value2 = null,
            global::System.Action<global::DId.LLMConfigCreateDtoVariant3?>? value3 = null,
            global::System.Action<global::DId.LLMConfigCreateDtoVariant4?>? value4 = null,
            global::System.Action<global::DId.LLMConfigCreateDtoVariant5?>? value5 = null,
            global::System.Action<global::DId.LLMConfigCreateDtoVariant6?>? value6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
            }
            else if (IsValue6)
            {
                value6?.Invoke(Value6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::DId.LLMConfigCreateDtoVariant1),
                Value2,
                typeof(global::DId.LLMConfigCreateDtoVariant2),
                Value3,
                typeof(global::DId.LLMConfigCreateDtoVariant3),
                Value4,
                typeof(global::DId.LLMConfigCreateDtoVariant4),
                Value5,
                typeof(global::DId.LLMConfigCreateDtoVariant5),
                Value6,
                typeof(global::DId.LLMConfigCreateDtoVariant6),
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
        public bool Equals(LLMConfigCreateDto other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::DId.LLMConfigCreateDtoVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.LLMConfigCreateDtoVariant2?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.LLMConfigCreateDtoVariant3?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.LLMConfigCreateDtoVariant4?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.LLMConfigCreateDtoVariant5?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.LLMConfigCreateDtoVariant6?>.Default.Equals(Value6, other.Value6) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LLMConfigCreateDto obj1, LLMConfigCreateDto obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LLMConfigCreateDto>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LLMConfigCreateDto obj1, LLMConfigCreateDto obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LLMConfigCreateDto o && Equals(o);
        }
    }
}
