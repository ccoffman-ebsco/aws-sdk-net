/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// This is the response object from the ListNotebookExecutions operation.
    /// </summary>
    public partial class ListNotebookExecutionsResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<NotebookExecutionSummary> _notebookExecutions = new List<NotebookExecutionSummary>();

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A pagination token that a subsequent <code>ListNotebookExecutions</code> can use to
        /// determine the next set of results to retrieve.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookExecutions. 
        /// <para>
        /// A list of notebook executions.
        /// </para>
        /// </summary>
        public List<NotebookExecutionSummary> NotebookExecutions
        {
            get { return this._notebookExecutions; }
            set { this._notebookExecutions = value; }
        }

        // Check to see if NotebookExecutions property is set
        internal bool IsSetNotebookExecutions()
        {
            return this._notebookExecutions != null && this._notebookExecutions.Count > 0; 
        }

    }
}