#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DId
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PartialAgentPresenter : global::System.IEquatable<PartialAgentPresenter>
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.PartialAgentPresenterPhotoAvatar? PhotoAvatar { get; init; }
#else
        public global::DId.PartialAgentPresenterPhotoAvatar? PhotoAvatar { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PhotoAvatar))]
#endif
        public bool IsPhotoAvatar => PhotoAvatar != null;

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DId.PartialAgentPresenterVideoAvatar? VideoAvatar { get; init; }
#else
        public global::DId.PartialAgentPresenterVideoAvatar? VideoAvatar { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoAvatar))]
#endif
        public bool IsVideoAvatar => VideoAvatar != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PartialAgentPresenter(global::DId.PartialAgentPresenterPhotoAvatar value) => new PartialAgentPresenter((global::DId.PartialAgentPresenterPhotoAvatar?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.PartialAgentPresenterPhotoAvatar?(PartialAgentPresenter @this) => @this.PhotoAvatar;

        /// <summary>
        /// 
        /// </summary>
        public PartialAgentPresenter(global::DId.PartialAgentPresenterPhotoAvatar? value)
        {
            PhotoAvatar = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PartialAgentPresenter(global::DId.PartialAgentPresenterVideoAvatar value) => new PartialAgentPresenter((global::DId.PartialAgentPresenterVideoAvatar?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DId.PartialAgentPresenterVideoAvatar?(PartialAgentPresenter @this) => @this.VideoAvatar;

        /// <summary>
        /// 
        /// </summary>
        public PartialAgentPresenter(global::DId.PartialAgentPresenterVideoAvatar? value)
        {
            VideoAvatar = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PartialAgentPresenter(
            global::DId.PartialAgentPresenterPhotoAvatar? photoAvatar,
            global::DId.PartialAgentPresenterVideoAvatar? videoAvatar
            )
        {
            PhotoAvatar = photoAvatar;
            VideoAvatar = videoAvatar;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VideoAvatar as object ??
            PhotoAvatar as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PhotoAvatar?.ToString() ??
            VideoAvatar?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPhotoAvatar || IsVideoAvatar;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::DId.PartialAgentPresenterPhotoAvatar?, TResult>? photoAvatar = null,
            global::System.Func<global::DId.PartialAgentPresenterVideoAvatar?, TResult>? videoAvatar = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPhotoAvatar && photoAvatar != null)
            {
                return photoAvatar(PhotoAvatar!);
            }
            else if (IsVideoAvatar && videoAvatar != null)
            {
                return videoAvatar(VideoAvatar!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::DId.PartialAgentPresenterPhotoAvatar?>? photoAvatar = null,
            global::System.Action<global::DId.PartialAgentPresenterVideoAvatar?>? videoAvatar = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPhotoAvatar)
            {
                photoAvatar?.Invoke(PhotoAvatar!);
            }
            else if (IsVideoAvatar)
            {
                videoAvatar?.Invoke(VideoAvatar!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PhotoAvatar,
                typeof(global::DId.PartialAgentPresenterPhotoAvatar),
                VideoAvatar,
                typeof(global::DId.PartialAgentPresenterVideoAvatar),
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
        public bool Equals(PartialAgentPresenter other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::DId.PartialAgentPresenterPhotoAvatar?>.Default.Equals(PhotoAvatar, other.PhotoAvatar) &&
                global::System.Collections.Generic.EqualityComparer<global::DId.PartialAgentPresenterVideoAvatar?>.Default.Equals(VideoAvatar, other.VideoAvatar) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PartialAgentPresenter obj1, PartialAgentPresenter obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PartialAgentPresenter>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PartialAgentPresenter obj1, PartialAgentPresenter obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PartialAgentPresenter o && Equals(o);
        }
    }
}
