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
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The parameters supplied to the create runbook schedule link operation.
    /// </summary>
    public partial class RunbookCreateScheduleLinkParameters
    {
        private IList<NameValuePair> _parameters;
        
        /// <summary>
        /// Optional. A list of name value pairs.
        /// </summary>
        public IList<NameValuePair> Parameters
        {
            get
            {
                if (this._parameters == null)
                {
                    this._parameters = new List<NameValuePair>();
                }
                return this._parameters;
            }
            set { this._parameters = value; }
        }
        
        /// <summary>
        /// Optional. A list of name value pairs.
        /// </summary>
        public IList<NameValuePair> ParametersValue
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }
        
        private string _runbookId;
        
        /// <summary>
        /// Required. The runbook id.
        /// </summary>
        public string RunbookId
        {
            get { return this._runbookId; }
            set { this._runbookId = value; }
        }
        
        private string _scheduleId;
        
        /// <summary>
        /// Required. The schedule id.
        /// </summary>
        public string ScheduleId
        {
            get { return this._scheduleId; }
            set { this._scheduleId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// RunbookCreateScheduleLinkParameters class.
        /// </summary>
        public RunbookCreateScheduleLinkParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// RunbookCreateScheduleLinkParameters class with required arguments.
        /// </summary>
        public RunbookCreateScheduleLinkParameters(string runbookId, string scheduleId)
            : this()
        {
            if (runbookId == null)
            {
                throw new ArgumentNullException("runbookId");
            }
            if (scheduleId == null)
            {
                throw new ArgumentNullException("scheduleId");
            }
            this.RunbookId = runbookId;
            this.ScheduleId = scheduleId;
        }
    }
}
