
// @@@ START COPYRIGHT @@@
//
// (C) Copyright 2015 Hewlett-Packard Development Company, L.P.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//
// @@@ END COPYRIGHT @@@
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trafodion.Data.Properties {
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
    public class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Trafodion.Data.Properties.Messages", typeof(Messages).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Communication failure.  Details: {0}.
        /// </summary>
        public static string CommunicationFailure {
            get {
                return ResourceManager.GetString("CommunicationFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connected to the default datasource {0}.
        /// </summary>
        public static string ConnectedToDefaultDS {
            get {
                return ResourceManager.GetString("ConnectedToDefaultDS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Requested datasource is not available.  .
        /// </summary>
        public static string DSNotAvailable {
            get {
                return ResourceManager.GetString("DSNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An internal error occured.  Operation: {0} Details: {1}.
        /// </summary>
        public static string InternalError {
            get {
                return ResourceManager.GetString("InternalError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The TrafodionDbConnection is not in a valid state for that operation.  Current State: {0}.
        /// </summary>
        public static string InvalidConnectionState {
            get {
                return ResourceManager.GetString("InvalidConnectionState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid TrafodionDbDbType value: {0}.
        /// </summary>
        public static string InvalidTrafodionDbDbType {
            get {
                return ResourceManager.GetString("InvalidTrafodionDbDbType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The TrafodionDbTransaction has already been committed or rolled back..
        /// </summary>
        public static string InvalidTransactionState {
            get {
                return ResourceManager.GetString("InvalidTransactionState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No servers available to handle the request..
        /// </summary>
        public static string NoServerHandle {
            get {
                return ResourceManager.GetString("NoServerHandle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided parameters do not match the prepared statement..
        /// </summary>
        public static string ParameterCountMismatch {
            get {
                return ResourceManager.GetString("ParameterCountMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No port available to launch additional servers..
        /// </summary>
        public static string PortNotAvailable {
            get {
                return ResourceManager.GetString("PortNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data cursor is not valid..
        /// </summary>
        public static string StmtInvalid {
            get {
                return ResourceManager.GetString("StmtInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retry the connection.  Server resources are busy..
        /// </summary>
        public static string TryAgain {
            get {
                return ResourceManager.GetString("TryAgain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported command type: {0}.
        /// </summary>
        public static string UnsupportedCommandType {
            get {
                return ResourceManager.GetString("UnsupportedCommandType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Isolation level {0} is not supported..
        /// </summary>
        public static string UnsupportedIsolationLevel {
            get {
                return ResourceManager.GetString("UnsupportedIsolationLevel", resourceCulture);
            }
        }
    }
}