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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Sql.LegacySdk;
using Microsoft.Azure.Management.Sql.LegacySdk.Models;

namespace Microsoft.Azure.Management.Sql.LegacySdk
{
    /// <summary>
    /// The Windows Azure SQL Database management API provides a RESTful set of
    /// web services that interact with Windows Azure SQL Database services to
    /// manage your databases. The API enables users to create, retrieve,
    /// update, and delete databases and servers.
    /// </summary>
    public static partial class ServerCommunicationLinkOperationsExtensions
    {
        /// <summary>
        /// Begins creating a new or updating an existing Azure SQL Server
        /// communication. To determine the status of the operation call
        /// GetServerCommunicationLinkOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerCommunicationLinkOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server.
        /// </param>
        /// <param name='communicationLinkName'>
        /// Required. The name of the Azure SQL Server communication link to be
        /// operated on (Updated or created).
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for creating or updating a Server
        /// communication link.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql server communication link
        /// operation.
        /// </returns>
        public static ServerCommunicationLinkCreateOrUpdateResponse BeginCreateOrUpdate(this IServerCommunicationLinkOperations operations, string resourceGroupName, string serverName, string communicationLinkName, ServerCommunicationLinkCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServerCommunicationLinkOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, serverName, communicationLinkName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Begins creating a new or updating an existing Azure SQL Server
        /// communication. To determine the status of the operation call
        /// GetServerCommunicationLinkOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerCommunicationLinkOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server.
        /// </param>
        /// <param name='communicationLinkName'>
        /// Required. The name of the Azure SQL Server communication link to be
        /// operated on (Updated or created).
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for creating or updating a Server
        /// communication link.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql server communication link
        /// operation.
        /// </returns>
        public static Task<ServerCommunicationLinkCreateOrUpdateResponse> BeginCreateOrUpdateAsync(this IServerCommunicationLinkOperations operations, string resourceGroupName, string serverName, string communicationLinkName, ServerCommunicationLinkCreateOrUpdateParameters parameters)
        {
            return operations.BeginCreateOrUpdateAsync(resourceGroupName, serverName, communicationLinkName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Creates a new or updates an existing Azure SQL Server communication
        /// link.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerCommunicationLinkOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Database Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server.
        /// </param>
        /// <param name='communicationLinkName'>
        /// Required. The name of the Azure SQL Server communication link to be
        /// operated on (Updated or created).
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for creating or updating a Server
        /// communication link.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql server communication link
        /// operation.
        /// </returns>
        public static ServerCommunicationLinkCreateOrUpdateResponse CreateOrUpdate(this IServerCommunicationLinkOperations operations, string resourceGroupName, string serverName, string communicationLinkName, ServerCommunicationLinkCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServerCommunicationLinkOperations)s).CreateOrUpdateAsync(resourceGroupName, serverName, communicationLinkName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates a new or updates an existing Azure SQL Server communication
        /// link.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerCommunicationLinkOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Database Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server.
        /// </param>
        /// <param name='communicationLinkName'>
        /// Required. The name of the Azure SQL Server communication link to be
        /// operated on (Updated or created).
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for creating or updating a Server
        /// communication link.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql server communication link
        /// operation.
        /// </returns>
        public static Task<ServerCommunicationLinkCreateOrUpdateResponse> CreateOrUpdateAsync(this IServerCommunicationLinkOperations operations, string resourceGroupName, string serverName, string communicationLinkName, ServerCommunicationLinkCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, serverName, communicationLinkName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes the Azure SQL server communication link with the given name.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerCommunicationLinkOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server.
        /// </param>
        /// <param name='communicationLinkName'>
        /// Required. The name of the Azure SQL server communication link to be
        /// retrieved.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IServerCommunicationLinkOperations operations, string resourceGroupName, string serverName, string communicationLinkName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServerCommunicationLinkOperations)s).DeleteAsync(resourceGroupName, serverName, communicationLinkName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes the Azure SQL server communication link with the given name.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerCommunicationLinkOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server.
        /// </param>
        /// <param name='communicationLinkName'>
        /// Required. The name of the Azure SQL server communication link to be
        /// retrieved.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IServerCommunicationLinkOperations operations, string resourceGroupName, string serverName, string communicationLinkName)
        {
            return operations.DeleteAsync(resourceGroupName, serverName, communicationLinkName, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns information about an Azure SQL Server communication links.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerCommunicationLinkOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server.
        /// </param>
        /// <param name='communicationLinkName'>
        /// Required. The name of the Azure SQL server communication link to be
        /// retrieved.
        /// </param>
        /// <returns>
        /// Represents the response to a get server communication link request.
        /// </returns>
        public static ServerCommunicationLinkGetResponse Get(this IServerCommunicationLinkOperations operations, string resourceGroupName, string serverName, string communicationLinkName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServerCommunicationLinkOperations)s).GetAsync(resourceGroupName, serverName, communicationLinkName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns information about an Azure SQL Server communication links.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerCommunicationLinkOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server.
        /// </param>
        /// <param name='communicationLinkName'>
        /// Required. The name of the Azure SQL server communication link to be
        /// retrieved.
        /// </param>
        /// <returns>
        /// Represents the response to a get server communication link request.
        /// </returns>
        public static Task<ServerCommunicationLinkGetResponse> GetAsync(this IServerCommunicationLinkOperations operations, string resourceGroupName, string serverName, string communicationLinkName)
        {
            return operations.GetAsync(resourceGroupName, serverName, communicationLinkName, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the status of an Azure Sql Server communication link create or
        /// update operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerCommunicationLinkOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql server communication link
        /// operation.
        /// </returns>
        public static ServerCommunicationLinkCreateOrUpdateResponse GetServerCommunicationLinkOperationStatus(this IServerCommunicationLinkOperations operations, string operationStatusLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServerCommunicationLinkOperations)s).GetServerCommunicationLinkOperationStatusAsync(operationStatusLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the status of an Azure Sql Server communication link create or
        /// update operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerCommunicationLinkOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql server communication link
        /// operation.
        /// </returns>
        public static Task<ServerCommunicationLinkCreateOrUpdateResponse> GetServerCommunicationLinkOperationStatusAsync(this IServerCommunicationLinkOperations operations, string operationStatusLink)
        {
            return operations.GetServerCommunicationLinkOperationStatusAsync(operationStatusLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns information about Azure SQL Server communication links.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerCommunicationLinkOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Server communication
        /// link request.
        /// </returns>
        public static ServerCommunicationLinkListResponse List(this IServerCommunicationLinkOperations operations, string resourceGroupName, string serverName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServerCommunicationLinkOperations)s).ListAsync(resourceGroupName, serverName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns information about Azure SQL Server communication links.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerCommunicationLinkOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Server communication
        /// link request.
        /// </returns>
        public static Task<ServerCommunicationLinkListResponse> ListAsync(this IServerCommunicationLinkOperations operations, string resourceGroupName, string serverName)
        {
            return operations.ListAsync(resourceGroupName, serverName, CancellationToken.None);
        }
    }
}