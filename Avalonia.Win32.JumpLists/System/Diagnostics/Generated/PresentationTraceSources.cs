﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// NOTE: This file was generated by $(WpfCodeGenDir)AvTrace\PresentationTraceSources.tt.
// Any manual updates to this file will overwritten.

namespace System.Diagnostics
{
    /// <summary>Access point for TraceSources</summary>
    public static partial class PresentationTraceSources
    {
        /// <summary>DependencyPropertySource for DependencyProperty</summary>
        public static TraceSource DependencyPropertySource
        {
            get
            {
                if (_DependencyPropertySource == null)
                {
                    _DependencyPropertySource = CreateTraceSource("System.Windows.DependencyProperty");
                }
                return _DependencyPropertySource;
            }
        }
        internal static TraceSource _DependencyPropertySource;

        /// <summary>FreezableSource for Freezable</summary>
        public static TraceSource FreezableSource
        {
            get
            {
                if (_FreezableSource == null)
                {
                    _FreezableSource = CreateTraceSource("System.Windows.Freezable");
                }
                return _FreezableSource;
            }
        }
        internal static TraceSource _FreezableSource;

        /// <summary>NameScopeSource for NameScope</summary>
        public static TraceSource NameScopeSource
        {
            get
            {
                if (_NameScopeSource == null)
                {
                    _NameScopeSource = CreateTraceSource("System.Windows.NameScope");
                }
                return _NameScopeSource;
            }
        }
        internal static TraceSource _NameScopeSource;

        /// <summary>RoutedEventSource for RoutedEvent</summary>
        public static TraceSource RoutedEventSource
        {
            get
            {
                if (_RoutedEventSource == null)
                {
                    _RoutedEventSource = CreateTraceSource("System.Windows.RoutedEvent");
                }
                return _RoutedEventSource;
            }
        }
        internal static TraceSource _RoutedEventSource;

        /// <summary>AnimationSource for Animation</summary>
        public static TraceSource AnimationSource
        {
            get
            {
                if (_AnimationSource == null)
                {
                    _AnimationSource = CreateTraceSource("System.Windows.Media.Animation");
                }
                return _AnimationSource;
            }
        }
        internal static TraceSource _AnimationSource;

        /// <summary>DataBindingSource for DataBinding</summary>
        public static TraceSource DataBindingSource
        {
            get
            {
                if (_DataBindingSource == null)
                {
                    _DataBindingSource = CreateTraceSource("System.Windows.Data");
                }
                return _DataBindingSource;
            }
        }
        internal static TraceSource _DataBindingSource;

        /// <summary>DocumentsSource for Documents</summary>
        public static TraceSource DocumentsSource
        {
            get
            {
                if (_DocumentsSource == null)
                {
                    _DocumentsSource = CreateTraceSource("System.Windows.Documents");
                }
                return _DocumentsSource;
            }
        }
        internal static TraceSource _DocumentsSource;

        /// <summary>ResourceDictionarySource for ResourceDictionary</summary>
        public static TraceSource ResourceDictionarySource
        {
            get
            {
                if (_ResourceDictionarySource == null)
                {
                    _ResourceDictionarySource = CreateTraceSource("System.Windows.ResourceDictionary");
                }
                return _ResourceDictionarySource;
            }
        }
        internal static TraceSource _ResourceDictionarySource;

        /// <summary>MarkupSource for Markup</summary>
        public static TraceSource MarkupSource
        {
            get
            {
                if (_MarkupSource == null)
                {
                    _MarkupSource = CreateTraceSource("System.Windows.Markup");
                }
                return _MarkupSource;
            }
        }
        internal static TraceSource _MarkupSource;

        /// <summary>HwndHostSource for HwndHost</summary>
        public static TraceSource HwndHostSource
        {
            get
            {
                if (_HwndHostSource == null)
                {
                    _HwndHostSource = CreateTraceSource("System.Windows.Interop.HwndHost");
                }
                return _HwndHostSource;
            }
        }
        internal static TraceSource _HwndHostSource;

        /// <summary>ShellSource for Shell</summary>
        public static TraceSource ShellSource
        {
            get
            {
                if (_ShellSource == null)
                {
                    _ShellSource = CreateTraceSource("System.Windows.Shell");
                }
                return _ShellSource;
            }
        }
        internal static TraceSource _ShellSource;
    }
}