using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CommitHash
{
    public static class Utils
    {
        public static string GetCommitHashSingle(string assemblyNameFilter)
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .Where(a => a.GetName().Name.Contains(assemblyNameFilter))
                .Select(a => a.GetCustomAttribute<CommitHashAttribute>()?.Value)
                .Distinct()
                .Single();
        }

        public static Dictionary<string, string> GetCommitHashes()
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .ToDictionary(a => a.FullName, a => a.GetCustomAttribute<CommitHashAttribute>()?.Value);
        }
    }
}
