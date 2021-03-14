﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MS.Internal
{
    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using System.Runtime.Versioning;

    /// <summary>
    /// General utility class for macro-type functions.
    /// </summary>
    internal static class Utilities
    {
        private static readonly Version _osVersion = Environment.OSVersion.Version;

        internal static bool IsOSWindows7OrNewer
        {
            get { return _osVersion >= new Version(6, 1); }
        }

        internal static void SafeDispose<T>(ref T disposable) where T : IDisposable
        {
            // Dispose can safely be called on an object multiple times.
            IDisposable t = disposable;
            disposable = default;
            if (null != t)
            {
                t.Dispose();
            }
        }

        [SupportedOSPlatform("Windows")]
        internal static void SafeRelease<T>(ref T comObject) where T : class
        {
            T t = comObject;
            comObject = default;
            if (null != t)
            {
                Debug.Assert(Marshal.IsComObject(t));
                Marshal.ReleaseComObject(t);
            }
        }
    }
}