// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.WebSites.Models;

namespace Microsoft.WindowsAzure.Management.WebSites.Models
{
    /// <summary>
    /// List of backups for the website.
    /// </summary>
    public partial class WebSiteGetBackupsResponse : OperationResponse, IEnumerable<BackupItem>
    {
        private IList<BackupItem> _backupItems;
        
        /// <summary>
        /// Optional. Backups for a web site.
        /// </summary>
        public IList<BackupItem> BackupItems
        {
            get
            {
                if (this._backupItems == null)
                {
                    this._backupItems = new System.Collections.Generic.List<Microsoft.WindowsAzure.Management.WebSites.Models.BackupItem>();
                }
                return this._backupItems;
            }
            set { this._backupItems = value; }
        }
        
        /// <summary>
        /// Optional. Backups for a web site.
        /// </summary>
        public IList<BackupItem> BackupItemsValue
        {
            get { return this._backupItems; }
            set { this._backupItems = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the WebSiteGetBackupsResponse class.
        /// </summary>
        public WebSiteGetBackupsResponse()
        {
        }
        
        /// <summary>
        /// Gets the sequence of BackupItems.
        /// </summary>
        public IEnumerator<BackupItem> GetEnumerator()
        {
            return this.BackupItemsValue.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of BackupItems.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
