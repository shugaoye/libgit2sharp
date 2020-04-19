using System;
using System.Collections.Generic;
using System.Text;

namespace LibGit2Sharp.Core
{
    internal static class NativeDllName
    {
#if __IOS__
        public const string Name = "__Internal";
#elif __ANDROID__
        public const string Name = "libgit2-6777db8";
#elif WINDOWS_UWP
        public const string Name = "libgit2-6777db8";
#else
        public const string Name = "libgit2-6777db8";
#endif
    }
}
