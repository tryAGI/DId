#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GetExpressiveAvatarDto : global::System.IEquatable<GetExpressiveAvatarDto>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.AllOf<global::DId.GetExpressiveAvatarDtoVariant1Variant1, object>? GetExpressiveAvatarDtoVariant1 { get; init; }
#else
        public global::DId.AllOf<global::DId.GetExpressiveAvatarDtoVariant1Variant1, object>? GetExpressiveAvatarDtoVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetExpressiveAvatarDtoVariant1))]
#endif
        public bool IsGetExpressiveAvatarDtoVariant1 => GetExpressiveAvatarDtoVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.GetExpressiveAvatarDtoVariant2? GetExpressiveAvatarDtoVariant2 { get; init; }
#else
        public global::DId.GetExpressiveAvatarDtoVariant2? GetExpressiveAvatarDtoVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetExpressiveAvatarDtoVariant2))]
#endif
        public bool IsGetExpressiveAvatarDtoVariant2 => GetExpressiveAvatarDtoVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetExpressiveAvatarDto(global::DId.AllOf<global::DId.GetExpressiveAvatarDtoVariant1Variant1, object> value) => new GetExpressiveAvatarDto((global::DId.AllOf<global::DId.GetExpressiveAvatarDtoVariant1Variant1, object>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.AllOf<global::DId.GetExpressiveAvatarDtoVariant1Variant1, object>?(GetExpressiveAvatarDto @this) => @this.GetExpressiveAvatarDtoVariant1;

        /// <summary>
        /// 
        /// </summary>
        public GetExpressiveAvatarDto(global::DId.AllOf<global::DId.GetExpressiveAvatarDtoVariant1Variant1, object>? value)
        {
            GetExpressiveAvatarDtoVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetExpressiveAvatarDto(global::DId.GetExpressiveAvatarDtoVariant2 value) => new GetExpressiveAvatarDto((global::DId.GetExpressiveAvatarDtoVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.GetExpressiveAvatarDtoVariant2?(GetExpressiveAvatarDto @this) => @this.GetExpressiveAvatarDtoVariant2;

        /// <summary>
        /// 
        /// </summary>
        public GetExpressiveAvatarDto(global::DId.GetExpressiveAvatarDtoVariant2? value)
        {
            GetExpressiveAvatarDtoVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GetExpressiveAvatarDto(
            global::DId.AllOf<global::DId.GetExpressiveAvatarDtoVariant1Variant1, object>? getExpressiveAvatarDtoVariant1,
            global::DId.GetExpressiveAvatarDtoVariant2? getExpressiveAvatarDtoVariant2
            )
        {
            GetExpressiveAvatarDtoVariant1 = getExpressiveAvatarDtoVariant1;
            GetExpressiveAvatarDtoVariant2 = getExpressiveAvatarDtoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GetExpressiveAvatarDtoVariant2 as object ??
            GetExpressiveAvatarDtoVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GetExpressiveAvatarDtoVariant1?.ToString() ??
            GetExpressiveAvatarDtoVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGetExpressiveAvatarDtoVariant1 && IsGetExpressiveAvatarDtoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::DId.AllOf<global::DId.GetExpressiveAvatarDtoVariant1Variant1, object>?, TResult>? getExpressiveAvatarDtoVariant1 = null,
            global::System.Func<global::DId.GetExpressiveAvatarDtoVariant2?, TResult>? getExpressiveAvatarDtoVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGetExpressiveAvatarDtoVariant1 && getExpressiveAvatarDtoVariant1 != null)
            {
                return getExpressiveAvatarDtoVariant1(GetExpressiveAvatarDtoVariant1!);
            }
            else if (IsGetExpressiveAvatarDtoVariant2 && getExpressiveAvatarDtoVariant2 != null)
            {
                return getExpressiveAvatarDtoVariant2(GetExpressiveAvatarDtoVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::DId.AllOf<global::DId.GetExpressiveAvatarDtoVariant1Variant1, object>?>? getExpressiveAvatarDtoVariant1 = null,
            global::System.Action<global::DId.GetExpressiveAvatarDtoVariant2?>? getExpressiveAvatarDtoVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGetExpressiveAvatarDtoVariant1)
            {
                getExpressiveAvatarDtoVariant1?.Invoke(GetExpressiveAvatarDtoVariant1!);
            }
            else if (IsGetExpressiveAvatarDtoVariant2)
            {
                getExpressiveAvatarDtoVariant2?.Invoke(GetExpressiveAvatarDtoVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GetExpressiveAvatarDtoVariant1,
                typeof(global::DId.AllOf<global::DId.GetExpressiveAvatarDtoVariant1Variant1, object>),
                GetExpressiveAvatarDtoVariant2,
                typeof(global::DId.GetExpressiveAvatarDtoVariant2),
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
        public bool Equals(GetExpressiveAvatarDto other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::DId.AllOf<global::DId.GetExpressiveAvatarDtoVariant1Variant1, object>?>.Default.Equals(GetExpressiveAvatarDtoVariant1, other.GetExpressiveAvatarDtoVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.GetExpressiveAvatarDtoVariant2?>.Default.Equals(GetExpressiveAvatarDtoVariant2, other.GetExpressiveAvatarDtoVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GetExpressiveAvatarDto obj1, GetExpressiveAvatarDto obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetExpressiveAvatarDto>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GetExpressiveAvatarDto obj1, GetExpressiveAvatarDto obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetExpressiveAvatarDto o && Equals(o);
        }
    }
}
