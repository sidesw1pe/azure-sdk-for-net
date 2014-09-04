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
    /// The List Web Sites operation response.
    /// </summary>
    public partial class WebSpacesListWebSitesResponse : OperationResponse, IEnumerable<WebSite>
    {
        private IList<WebSite> _webSites;
        
        /// <summary>
        /// Optional. The web sites associated with the specified web space.
        /// </summary>
        public IList<WebSite> WebSites
        {
            get
            {
                if (this._webSites == null)
                {
                    this._webSites = new System.Collections.Generic.List<Microsoft.WindowsAzure.Management.WebSites.Models.WebSite>();
                }
                return this._webSites;
            }
            set { this._webSites = value; }
        }
        
        /// <summary>
        /// Optional. The web sites associated with the specified web space.
        /// </summary>
        public IList<WebSite> WebSitesValue
        {
            get { return this._webSites; }
            set { this._webSites = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the WebSpacesListWebSitesResponse
        /// class.
        /// </summary>
        public WebSpacesListWebSitesResponse()
        {
        }
        
        /// <summary>
        /// Gets the sequence of WebSites.
        /// </summary>
        public IEnumerator<WebSite> GetEnumerator()
        {
            return this.WebSitesValue.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of WebSites.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
