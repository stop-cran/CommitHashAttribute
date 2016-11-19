using System;

namespace CommitHash
{
    /// <summary>
    /// Commit hash to mark source code state.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly)]
    public class CommitHashAttribute : Attribute
    {
        /// <param name="value">Commit hash</param>
        public CommitHashAttribute(string value)
        {
            Value = value;
        }

        /// <summary>
        /// Git commit hash
        /// </summary>
        public string Value { get; }
    }
}
