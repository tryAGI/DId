#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CustomAuthConfig : global::System.IEquatable<CustomAuthConfig>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.CustomAuthConfigBasic? Basic { get; init; }
#else
        public global::DId.CustomAuthConfigBasic? Basic { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Basic))]
#endif
        public bool IsBasic => Basic != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.CustomAuthConfigOAuth2? OAuth2 { get; init; }
#else
        public global::DId.CustomAuthConfigOAuth2? OAuth2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OAuth2))]
#endif
        public bool IsOAuth2 => OAuth2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomAuthConfig(global::DId.CustomAuthConfigBasic value) => new CustomAuthConfig((global::DId.CustomAuthConfigBasic?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.CustomAuthConfigBasic?(CustomAuthConfig @this) => @this.Basic;

        /// <summary>
        /// 
        /// </summary>
        public CustomAuthConfig(global::DId.CustomAuthConfigBasic? value)
        {
            Basic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomAuthConfig(global::DId.CustomAuthConfigOAuth2 value) => new CustomAuthConfig((global::DId.CustomAuthConfigOAuth2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.CustomAuthConfigOAuth2?(CustomAuthConfig @this) => @this.OAuth2;

        /// <summary>
        /// 
        /// </summary>
        public CustomAuthConfig(global::DId.CustomAuthConfigOAuth2? value)
        {
            OAuth2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CustomAuthConfig(
            global::DId.CustomAuthConfigBasic? basic,
            global::DId.CustomAuthConfigOAuth2? oAuth2
            )
        {
            Basic = basic;
            OAuth2 = oAuth2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OAuth2 as object ??
            Basic as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Basic?.ToString() ??
            OAuth2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBasic || IsOAuth2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::DId.CustomAuthConfigBasic?, TResult>? basic = null,
            global::System.Func<global::DId.CustomAuthConfigOAuth2?, TResult>? oAuth2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBasic && basic != null)
            {
                return basic(Basic!);
            }
            else if (IsOAuth2 && oAuth2 != null)
            {
                return oAuth2(OAuth2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::DId.CustomAuthConfigBasic?>? basic = null,
            global::System.Action<global::DId.CustomAuthConfigOAuth2?>? oAuth2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBasic)
            {
                basic?.Invoke(Basic!);
            }
            else if (IsOAuth2)
            {
                oAuth2?.Invoke(OAuth2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Basic,
                typeof(global::DId.CustomAuthConfigBasic),
                OAuth2,
                typeof(global::DId.CustomAuthConfigOAuth2),
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
        public bool Equals(CustomAuthConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::DId.CustomAuthConfigBasic?>.Default.Equals(Basic, other.Basic) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.CustomAuthConfigOAuth2?>.Default.Equals(OAuth2, other.OAuth2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CustomAuthConfig obj1, CustomAuthConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CustomAuthConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CustomAuthConfig obj1, CustomAuthConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CustomAuthConfig o && Equals(o);
        }
    }
}
