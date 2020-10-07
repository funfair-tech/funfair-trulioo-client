using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace FunFair.Trulioo.Client.URI
{
    /// <summary>
    ///     Represents a Trulioo resource name.
    /// </summary>
    internal sealed class ResourceName : ReadOnlyCollection<string>, IComparable, IComparable<ResourceName>, IEquatable<ResourceName>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ResourceName" /> class.
        /// </summary>
        /// <param name="resourceName">
        ///     Another resource name.
        /// </param>
        /// <param name="parts">
        ///     Names to be appended <paramref name="resourceName" />.
        /// </param>
        public ResourceName(ResourceName resourceName, params string[] parts)
            : this(resourceName.Concat(parts)
                               .ToArray())
        {
        }

        /// <summary>
        ///     Initialize a new instance of the <see cref="ResourceName" /> class.
        /// </summary>
        /// <param name="parts">
        /// </param>
        public ResourceName(params string[] parts)
            : base(parts)
        {
            foreach (string part in this)
            {
                if (string.IsNullOrEmpty(part))
                {
                    throw new ArgumentException(string.Concat(str0: "parts: ", this.ToString()), nameof(parts));
                }
            }
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ResourceName" /> class.
        /// </summary>
        /// <exception cref="ArgumentException">
        ///     Thrown when one or more arguments have unsupported or illegal values.
        /// </exception>
        /// <param name="parts">
        /// </param>
        public ResourceName(IEnumerable<string> parts)
            : this(parts.ToArray())
        {
        }

        /// <summary>
        ///     Compares the current <see cref="ResourceName" /> with another object and
        ///     returns an integer that indicates whether the current
        ///     <see cref="ResourceName" /> precedes, follows, or appears in the same
        ///     position in the sort order as the other object.
        /// </summary>
        /// <param name="obj">
        ///     The object to compare to the current <see cref="ResourceName" />.
        /// </param>
        /// <returns>
        ///     A 32-bit signed integer that indicates whether this instance precedes,
        ///     follows, or appears in the same position in the sort order as
        ///     <paramref name="obj" />.
        ///     <list type="table">
        ///         <listheader>
        ///             <term>
        ///                 Value
        ///             </term>
        ///             <description>
        ///                 Condition
        ///             </description>
        ///         </listheader>
        ///         <item>
        ///             <term>
        ///                 Less than zero
        ///             </term>
        ///             <description>
        ///                 This instance precedes <paramref name="obj" />.
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <term>
        ///                 Zero
        ///             </term>
        ///             <description>
        ///                 This instance is in the same position in the sort order as
        ///                 <paramref name="obj" />.
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <term>
        ///                 Greater than zero
        ///             </term>
        ///             <description>
        ///                 This instance follows <paramref name="obj" />,
        ///                 <paramref name="obj" /> is not a <see cref="ResourceName" />, or
        ///                 <paramref name="obj" /> is <c>null</c>.
        ///             </description>
        ///         </item>
        ///     </list>
        /// </returns>
        public int CompareTo(object obj)
        {
            return this.CompareTo(obj as ResourceName);
        }

        /// <summary>
        ///     Compares the current <see cref="ResourceName" /> with another one and
        ///     returns an integer that indicates whether the current
        ///     <see cref="ResourceName" /> precedes, follows, or appears in the same
        ///     position in the sort order as the other one.
        /// </summary>
        /// <param name="other">
        ///     The object to compare with the current <see cref="ResourceName" />.
        /// </param>
        /// <returns>
        ///     A 32-bit signed integer that indicates whether this instance precedes,
        ///     follows, or appears in the same position in the sort order as
        ///     <paramref name="other" />.
        ///     <list type="table">
        ///         <listheader>
        ///             <term>
        ///                 Value
        ///             </term>
        ///             <description>
        ///                 Condition
        ///             </description>
        ///         </listheader>
        ///         <item>
        ///             <term>
        ///                 Less than zero
        ///             </term>
        ///             <description>
        ///                 This instance precedes <paramref name="other" />.
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <term>
        ///                 Zero
        ///             </term>
        ///             <description>
        ///                 This instance is in the same position in the sort order as
        ///                 <paramref name="other" />.
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <term>
        ///                 Greater than zero
        ///             </term>
        ///             <description>
        ///                 This instance follows <paramref name="other" /> or
        ///                 <paramref name="other" /> is <c>null</c>.
        ///             </description>
        ///         </item>
        ///     </list>
        /// </returns>
        public int CompareTo(ResourceName other)
        {
            if (other == null)
            {
                return 1;
            }

            if (ReferenceEquals(this, objB: other))
            {
                return 0;
            }

            int diff = this.Items.Count - other.Items.Count;

            if (diff != 0)
            {
                return diff;
            }

            var pair = this.Items.Zip(second: other.Items, resultSelector: (p1, p2) => new {ThisPart = p1, OtherPart = p2})
                           .FirstOrDefault(predicate: p => p.ThisPart != p.OtherPart);

            if (pair == null)
            {
                return 0;
            }

            return string.Compare(strA: pair.ThisPart, strB: pair.OtherPart, comparisonType: StringComparison.Ordinal);
        }

        /// <summary>
        ///     Determines whether the current <see cref="ResourceName" /> and another one
        ///     are equal.
        /// </summary>
        /// <param name="other">
        ///     The object to compare with the current <see cref="ResourceName" />.
        /// </param>
        /// <returns>
        ///     <c>true</c> if <paramref name="other" /> is non <c>null</c> and is the
        ///     same as the current <see cref="ResourceName" />; otherwise,
        ///     <c>false</c>.
        /// </returns>
        public bool Equals(ResourceName other)
        {
            if ((object) other == null)
            {
                return false;
            }

            if (ReferenceEquals(this, objB: other))
            {
                return true;
            }

            if (this.Items.Count != other.Items.Count)
            {
                return false;
            }

            return this.Items.SequenceEqual(other.Items);
        }

        /// <summary>
        ///     Determines whether the current <see cref="ResourceName" /> and another
        ///     object are equal.
        /// </summary>
        /// <param name="obj">
        ///     The object to compare with the current <see cref="ResourceName" />.
        /// </param>
        /// <returns>
        ///     <c>true</c> if <paramref name="obj" /> is a non <c>null</c>
        ///     <see cref="ResourceName" /> and is the same as the current
        ///     <see cref="ResourceName" />; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as ResourceName);
        }

        /// <summary>
        ///     Computes the hash code for the current <see cref="ResourceName" />.
        /// </summary>
        /// <returns>
        ///     The hash code for the current <see cref="ResourceName" />.
        /// </returns>
        public override int GetHashCode()
        {
            return this.Items.Aggregate(seed: 17, func: (value, part) => value * 23 + part.GetHashCode());
        }

        /// <summary>
        ///     Greater-than comparison operator.
        /// </summary>
        /// <param name="a">
        ///     The first <see cref="ResourceName" /> to compare or <c>null</c>.
        /// </param>
        /// <param name="b">
        ///     The second <see cref="ResourceName" /> to compare or <c>null</c>.
        /// </param>
        /// <returns>
        ///     The result of the operation.
        /// </returns>
        public static bool operator >(ResourceName a, ResourceName b)
        {
            if ((object) a == null)
            {
                return false;
            }

            return a.CompareTo(b) > 0;
        }

        /// <summary>
        ///     Greater-than-or-equal comparison operator.
        /// </summary>
        /// <param name="a">
        ///     The first <see cref="ResourceName" /> to compare or <c>null</c>.
        /// </param>
        /// <param name="b">
        ///     The second <see cref="ResourceName" /> to compare or <c>null</c>.
        /// </param>
        /// <returns>
        ///     The result of the operation.
        /// </returns>
        public static bool operator >=(ResourceName a, ResourceName b)
        {
            if ((object) a == null)
            {
                return (object) b == null;
            }

            return a.CompareTo(b) < 0;
        }

        /// <summary>
        ///     Determines whether two <see cref="ResourceName" /> instances have the same
        ///     value.
        /// </summary>
        /// <param name="a">
        ///     The first <see cref="ResourceName" /> to compare or <c>null</c>.
        /// </param>
        /// <param name="b">
        ///     The second <see cref="ResourceName" /> to compare or <c>null</c>.
        /// </param>
        /// <returns>
        ///     <c>true</c> if the value of <paramref name="a" /> is the same as the value
        ///     of <paramref name="b" />; otherwise, <c>false</c>.
        /// </returns>
        public static bool operator ==(ResourceName a, ResourceName b)
        {
            if (ReferenceEquals(objA: a, objB: b))
            {
                return true;
            }

            if ((object) a == null || (object) b == null)
            {
                return false;
            }

            return a.Equals(b);
        }

        /// <summary>
        ///     Determines whether two <see cref="ResourceName" /> instances have
        ///     different values.
        /// </summary>
        /// <param name="a">
        ///     The first <see cref="ResourceName" /> to compare or <c>null</c>.
        /// </param>
        /// <param name="b">
        ///     The second <see cref="ResourceName" /> to compare or <c>null</c>.
        /// </param>
        /// <returns>
        ///     <c>true</c> if the value of <paramref name="a" /> is different than the
        ///     value of <paramref name="b" />; otherwise, <c>false</c>.
        /// </returns>
        public static bool operator !=(ResourceName a, ResourceName b)
        {
            return !(a == b);
        }

        /// <summary>
        ///     Less-than comparison operator.
        /// </summary>
        /// <param name="a">
        ///     The first <see cref="ResourceName" /> to compare or <c>null</c>.
        /// </param>
        /// <param name="b">
        ///     The second <see cref="ResourceName" /> to compare or <c>null</c>.
        /// </param>
        /// <returns>
        ///     The result of the operation.
        /// </returns>
        public static bool operator <(ResourceName a, ResourceName b)
        {
            if ((object) a == null)
            {
                return (object) b != null;
            }

            return a.CompareTo(b) < 0;
        }

        /// <summary>
        ///     Less-than-or-equal comparison operator.
        /// </summary>
        /// <param name="a">
        ///     The first <see cref="ResourceName" /> to compare or <c>null</c>.
        /// </param>
        /// <param name="b">
        ///     The second <see cref="ResourceName" /> to compare or <c>null</c>.
        /// </param>
        /// <returns>
        ///     The result of the operation.
        /// </returns>
        public static bool operator <=(ResourceName a, ResourceName b)
        {
            if ((object) a == null)
            {
                return true;
            }

            return a.CompareTo(b) < 0;
        }

        /// <summary>
        ///     Converts the value of the current <see cref="Namespace" /> to its
        ///     equivalent string representation.
        /// </summary>
        /// <returns>
        ///     A string representation of the current <see cref="Namespace" />
        /// </returns>
        public override string ToString()
        {
            IEnumerable<string> segments = from segment in this select segment;

            return string.Join(separator: "/", values: segments);
        }

        /// <summary>
        ///     Converts the value of the current <see cref="Namespace" /> object to its
        ///     equivalent URI encoded string representation.
        /// </summary>
        /// <remarks>
        ///     The value is converted using <see cref="Uri.EscapeUriString" />.
        /// </remarks>
        /// <returns>
        ///     A string representation of the current <see cref="Namespace" />
        /// </returns>
        public string ToUriString()
        {
            IEnumerable<string> segments = from segment in this select Uri.EscapeDataString(segment);

            return string.Join(separator: "/", values: segments);
        }
    }
}