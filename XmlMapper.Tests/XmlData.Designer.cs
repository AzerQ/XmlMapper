﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XmlMapper.Tests {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class XmlData {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal XmlData() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("XmlMapper.Tests.XmlData", typeof(XmlData).Assembly);
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
        ///   Looks up a localized string similar to &lt;LibraryContext&gt;
        ///    &lt;Book&gt;
        ///        &lt;Title&gt;The Great Gatsby&lt;/Title&gt;
        ///        &lt;Author&gt;F. Scott Fitzgerald&lt;/Author&gt;
        ///        &lt;Year&gt;1925&lt;/Year&gt;
        ///        &lt;Genres&gt;
        ///            &lt;Genre name=&apos;Novel&apos;/&gt;
        ///            &lt;Genre name=&apos;Fiction&apos;/&gt;
        ///        &lt;/Genres&gt;
        ///    &lt;/Book&gt;
        ///    &lt;Book&gt;
        ///        &lt;Title&gt;To Kill a Mockingbird&lt;/Title&gt;
        ///        &lt;Author&gt;Harper Lee&lt;/Author&gt;
        ///        &lt;Year&gt;1960&lt;/Year&gt;
        ///        &lt;Genres&gt;
        ///            &lt;Genre name=&apos;Classic&apos;/&gt;
        ///            &lt;Genre name=&apos;Drama&apos;/&gt;
        ///        &lt;/Genres&gt;
        ///    &lt;/Book&gt;
        ///&lt;/ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LibraryContext {
            get {
                return ResourceManager.GetString("LibraryContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;UsersContext&gt;
        ///	&lt;User&gt;
        ///		&lt;FullName&gt;Alice Smith&lt;/FullName&gt;
        ///		&lt;Login&gt;alice.smith&lt;/Login&gt;
        ///		&lt;Age&gt;30&lt;/Age&gt;
        ///		&lt;BIO&gt;Software Developer&lt;/BIO&gt;
        ///		&lt;IsActive&gt;true&lt;/IsActive&gt;
        ///		&lt;JoinDate&gt;2022-03-15&lt;/JoinDate&gt;
        ///		&lt;Address&gt;
        ///			&lt;Street&gt;Main Street&lt;/Street&gt;
        ///			&lt;City&gt;Springfield&lt;/City&gt;
        ///			&lt;PostalCode&gt;12345&lt;/PostalCode&gt;
        ///		&lt;/Address&gt;
        ///		&lt;Roles&gt;
        ///			&lt;Role id=&apos;101&apos; name=&apos;Admin&apos; description=&apos;Full access&apos;/&gt;
        ///			&lt;Role id=&apos;102&apos; name=&apos;User&apos; description=&apos;Limited access&apos;/&gt;
        ///		&lt;/Roles&gt;
        ///	&lt;/User&gt;
        ///&lt;/UsersContext&gt;.
        /// </summary>
        internal static string UsersContext {
            get {
                return ResourceManager.GetString("UsersContext", resourceCulture);
            }
        }
    }
}