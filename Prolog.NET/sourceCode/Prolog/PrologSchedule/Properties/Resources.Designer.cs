﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prolog.Scheduler.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Prolog.Scheduler.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A folder could not be found..
        /// </summary>
        internal static string MessageDirectoryNotFoundException {
            get {
                return ResourceManager.GetString("MessageDirectoryNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicate fact/rule specified..
        /// </summary>
        internal static string MessageDuplicateClause {
            get {
                return ResourceManager.GetString("MessageDuplicateClause", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unexpected error occurred..
        /// </summary>
        internal static string MessageException {
            get {
                return ResourceManager.GetString("MessageException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File {0} was not found..
        /// </summary>
        internal static string MessageFileNotFoundException {
            get {
                return ResourceManager.GetString("MessageFileNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error has occurred while reading or writing a file..
        /// </summary>
        internal static string MessageIOException {
            get {
                return ResourceManager.GetString("MessageIOException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unrecognized input specified..
        /// </summary>
        internal static string MessageUnrecognizedInput {
            get {
                return ResourceManager.GetString("MessageUnrecognizedInput", resourceCulture);
            }
        }
    }
}