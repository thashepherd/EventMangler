﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventMangler.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EventMangler.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to D:\Program Files (x86)\Steam\steamapps\common\FTL Faster Than Light\resources\dat.dat-unpacked.
        /// </summary>
        internal static string data_root_dir {
            get {
                return ResourceManager.GetString("data_root_dir", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to D:/Program Files (x86)/Steam/steamapps/common/FTL Faster Than Light/mods/Sonata/data/events_imageList.xml.
        /// </summary>
        internal static string default_imagelist {
            get {
                return ResourceManager.GetString("default_imagelist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to D:/Program Files (x86)/Steam/steamapps/common/FTL Faster Than Light/mods/Sonata/.
        /// </summary>
        internal static string mod_root_dir {
            get {
                return ResourceManager.GetString("mod_root_dir", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to D:\Program Files (x86)\Steam\steamapps\common\FTL Faster Than Light\resources\resource.dat-unpacked.
        /// </summary>
        internal static string resources_root_dir {
            get {
                return ResourceManager.GetString("resources_root_dir", resourceCulture);
            }
        }
    }
}