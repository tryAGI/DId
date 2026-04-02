#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TriggerEventData : global::System.IEquatable<TriggerEventData>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.ChatEndEventData? ChatEnd { get; init; }
#else
        public global::DId.ChatEndEventData? ChatEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatEnd))]
#endif
        public bool IsChatEnd => ChatEnd != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.TriggerEventDataVariant2? TriggerEventDataVariant2 { get; init; }
#else
        public global::DId.TriggerEventDataVariant2? TriggerEventDataVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TriggerEventDataVariant2))]
#endif
        public bool IsTriggerEventDataVariant2 => TriggerEventDataVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TriggerEventData(global::DId.ChatEndEventData value) => new TriggerEventData((global::DId.ChatEndEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.ChatEndEventData?(TriggerEventData @this) => @this.ChatEnd;

        /// <summary>
        /// 
        /// </summary>
        public TriggerEventData(global::DId.ChatEndEventData? value)
        {
            ChatEnd = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TriggerEventData(global::DId.TriggerEventDataVariant2 value) => new TriggerEventData((global::DId.TriggerEventDataVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.TriggerEventDataVariant2?(TriggerEventData @this) => @this.TriggerEventDataVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TriggerEventData(global::DId.TriggerEventDataVariant2? value)
        {
            TriggerEventDataVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TriggerEventData(
            global::DId.ChatEndEventData? chatEnd,
            global::DId.TriggerEventDataVariant2? triggerEventDataVariant2
            )
        {
            ChatEnd = chatEnd;
            TriggerEventDataVariant2 = triggerEventDataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TriggerEventDataVariant2 as object ??
            ChatEnd as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatEnd?.ToString() ??
            TriggerEventDataVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatEnd || IsTriggerEventDataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::DId.ChatEndEventData?, TResult>? chatEnd = null,
            global::System.Func<global::DId.TriggerEventDataVariant2?, TResult>? triggerEventDataVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatEnd && chatEnd != null)
            {
                return chatEnd(ChatEnd!);
            }
            else if (IsTriggerEventDataVariant2 && triggerEventDataVariant2 != null)
            {
                return triggerEventDataVariant2(TriggerEventDataVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::DId.ChatEndEventData?>? chatEnd = null,
            global::System.Action<global::DId.TriggerEventDataVariant2?>? triggerEventDataVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatEnd)
            {
                chatEnd?.Invoke(ChatEnd!);
            }
            else if (IsTriggerEventDataVariant2)
            {
                triggerEventDataVariant2?.Invoke(TriggerEventDataVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatEnd,
                typeof(global::DId.ChatEndEventData),
                TriggerEventDataVariant2,
                typeof(global::DId.TriggerEventDataVariant2),
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
        public bool Equals(TriggerEventData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::DId.ChatEndEventData?>.Default.Equals(ChatEnd, other.ChatEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.TriggerEventDataVariant2?>.Default.Equals(TriggerEventDataVariant2, other.TriggerEventDataVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TriggerEventData obj1, TriggerEventData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TriggerEventData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TriggerEventData obj1, TriggerEventData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TriggerEventData o && Equals(o);
        }
    }
}
