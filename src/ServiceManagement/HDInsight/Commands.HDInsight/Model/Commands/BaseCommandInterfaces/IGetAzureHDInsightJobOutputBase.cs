﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.WindowsAzure.Management.HDInsight.Cmdlet.DataObjects;
using Microsoft.WindowsAzure.Management.HDInsight.Cmdlet.GetAzureHDInsightClusters.BaseInterfaces;

namespace Microsoft.WindowsAzure.Management.HDInsight.Cmdlet.Commands.BaseCommandInterfaces
{
    internal interface IGetAzureHDInsightJobOutputBase : IAzureHDInsightCommonCommandBase
    {
        /// <summary>
        ///     Gets or sets the HDInsight cluster to connect to.
        /// </summary>
        string Cluster { get; set; }

        /// <summary>
        ///     Gets or sets the Id of the jobDetails to retrieve.
        /// </summary>
        string JobId { get; set; }

        /// <summary>
        ///     Gets or sets the type of jobDetails output to retrieve.
        /// </summary>
        JobOutputType OutputType { get; set; }

        /// <summary>
        ///     Gets or sets the directory to download task logs to.
        /// </summary>
        string TaskLogsDirectory { get; set; }
    }
}
