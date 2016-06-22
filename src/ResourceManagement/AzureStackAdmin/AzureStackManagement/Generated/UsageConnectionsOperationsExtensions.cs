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
using Microsoft.AzureStack.Management;
using Microsoft.AzureStack.Management.Models;

namespace Microsoft.AzureStack.Management
{
    public static partial class UsageConnectionsOperationsExtensions
    {
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IUsageConnectionsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource Group Name
        /// </param>
        /// <param name='usageConnectionId'>
        /// Required. Usage Connection Id
        /// </param>
        /// <param name='parameters'>
        /// Required. Usage Connections Create or Update Parameters
        /// </param>
        /// <returns>
        /// The usage connection create or update result.
        /// </returns>
        public static UsageConnectionsCreateOrUpdateResult CreateOrUpdate(this IUsageConnectionsOperations operations, string resourceGroupName, string usageConnectionId, UsageConnectionsCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IUsageConnectionsOperations)s).CreateOrUpdateAsync(resourceGroupName, usageConnectionId, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IUsageConnectionsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource Group Name
        /// </param>
        /// <param name='usageConnectionId'>
        /// Required. Usage Connection Id
        /// </param>
        /// <param name='parameters'>
        /// Required. Usage Connections Create or Update Parameters
        /// </param>
        /// <returns>
        /// The usage connection create or update result.
        /// </returns>
        public static Task<UsageConnectionsCreateOrUpdateResult> CreateOrUpdateAsync(this IUsageConnectionsOperations operations, string resourceGroupName, string usageConnectionId, UsageConnectionsCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, usageConnectionId, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IUsageConnectionsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Your documentation here.
        /// </param>
        /// <param name='usageConnectionId'>
        /// Required. Your documentation here.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IUsageConnectionsOperations operations, string resourceGroupName, string usageConnectionId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IUsageConnectionsOperations)s).DeleteAsync(resourceGroupName, usageConnectionId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IUsageConnectionsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Your documentation here.
        /// </param>
        /// <param name='usageConnectionId'>
        /// Required. Your documentation here.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IUsageConnectionsOperations operations, string resourceGroupName, string usageConnectionId)
        {
            return operations.DeleteAsync(resourceGroupName, usageConnectionId, CancellationToken.None);
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IUsageConnectionsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource Group name for usage connection information
        /// </param>
        /// <param name='usageConnectionId'>
        /// Required. Usage Connection Id
        /// </param>
        /// <returns>
        /// Usage Connections Model as result
        /// </returns>
        public static UsageConnectionsGetResult Get(this IUsageConnectionsOperations operations, string resourceGroupName, string usageConnectionId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IUsageConnectionsOperations)s).GetAsync(resourceGroupName, usageConnectionId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IUsageConnectionsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource Group name for usage connection information
        /// </param>
        /// <param name='usageConnectionId'>
        /// Required. Usage Connection Id
        /// </param>
        /// <returns>
        /// Usage Connections Model as result
        /// </returns>
        public static Task<UsageConnectionsGetResult> GetAsync(this IUsageConnectionsOperations operations, string resourceGroupName, string usageConnectionId)
        {
            return operations.GetAsync(resourceGroupName, usageConnectionId, CancellationToken.None);
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IUsageConnectionsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Your documentation here.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        public static UsageConnectionsListResult List(this IUsageConnectionsOperations operations, string resourceGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IUsageConnectionsOperations)s).ListAsync(resourceGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IUsageConnectionsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Your documentation here.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        public static Task<UsageConnectionsListResult> ListAsync(this IUsageConnectionsOperations operations, string resourceGroupName)
        {
            return operations.ListAsync(resourceGroupName, CancellationToken.None);
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IUsageConnectionsOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        public static UsageConnectionsListResult ListNext(this IUsageConnectionsOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IUsageConnectionsOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IUsageConnectionsOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        public static Task<UsageConnectionsListResult> ListNextAsync(this IUsageConnectionsOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IUsageConnectionsOperations.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        public static UsageConnectionsListResult ListWithoutResourceGroup(this IUsageConnectionsOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IUsageConnectionsOperations)s).ListWithoutResourceGroupAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IUsageConnectionsOperations.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        public static Task<UsageConnectionsListResult> ListWithoutResourceGroupAsync(this IUsageConnectionsOperations operations)
        {
            return operations.ListWithoutResourceGroupAsync(CancellationToken.None);
        }
    }
}