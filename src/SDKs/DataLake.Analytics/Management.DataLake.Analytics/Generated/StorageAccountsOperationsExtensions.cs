// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Analytics
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for StorageAccountsOperations.
    /// </summary>
    public static partial class StorageAccountsOperationsExtensions
    {
            /// <summary>
            /// Gets the first page of Azure Storage accounts, if any, linked to the
            /// specified Data Lake Analytics account. The response includes a link to the
            /// next page, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// OData Select statement. Limits the properties on each entry to just those
            /// requested, e.g. Categories?$select=CategoryName,Description. Optional.
            /// </param>
            /// <param name='count'>
            /// The Boolean value of true or false to request a count of the matching
            /// resources included with the resources in the response, e.g.
            /// Categories?$count=true. Optional.
            /// </param>
            public static IPage<StorageAccountInformation> ListByAccount(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, ODataQuery<StorageAccountInformation> odataQuery = default(ODataQuery<StorageAccountInformation>), string select = default(string), bool? count = default(bool?))
            {
                return operations.ListByAccountAsync(resourceGroupName, accountName, odataQuery, select, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the first page of Azure Storage accounts, if any, linked to the
            /// specified Data Lake Analytics account. The response includes a link to the
            /// next page, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// OData Select statement. Limits the properties on each entry to just those
            /// requested, e.g. Categories?$select=CategoryName,Description. Optional.
            /// </param>
            /// <param name='count'>
            /// The Boolean value of true or false to request a count of the matching
            /// resources included with the resources in the response, e.g.
            /// Categories?$count=true. Optional.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<StorageAccountInformation>> ListByAccountAsync(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, ODataQuery<StorageAccountInformation> odataQuery = default(ODataQuery<StorageAccountInformation>), string select = default(string), bool? count = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAccountWithHttpMessagesAsync(resourceGroupName, accountName, odataQuery, select, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the specified Data Lake Analytics account to add an Azure Storage
            /// account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='storageAccountName'>
            /// The name of the Azure Storage account to add
            /// </param>
            /// <param name='parameters'>
            /// The parameters containing the access key and optional suffix for the Azure
            /// Storage Account.
            /// </param>
            public static void Add(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, string storageAccountName, AddStorageAccountParameters parameters)
            {
                operations.AddAsync(resourceGroupName, accountName, storageAccountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the specified Data Lake Analytics account to add an Azure Storage
            /// account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='storageAccountName'>
            /// The name of the Azure Storage account to add
            /// </param>
            /// <param name='parameters'>
            /// The parameters containing the access key and optional suffix for the Azure
            /// Storage Account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AddAsync(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, string storageAccountName, AddStorageAccountParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AddWithHttpMessagesAsync(resourceGroupName, accountName, storageAccountName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the specified Azure Storage account linked to the given Data Lake
            /// Analytics account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='storageAccountName'>
            /// The name of the Azure Storage account for which to retrieve the details.
            /// </param>
            public static StorageAccountInformation Get(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, string storageAccountName)
            {
                return operations.GetAsync(resourceGroupName, accountName, storageAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified Azure Storage account linked to the given Data Lake
            /// Analytics account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='storageAccountName'>
            /// The name of the Azure Storage account for which to retrieve the details.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageAccountInformation> GetAsync(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, string storageAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, storageAccountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the Data Lake Analytics account to replace Azure Storage blob
            /// account details, such as the access key and/or suffix.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='storageAccountName'>
            /// The Azure Storage account to modify
            /// </param>
            /// <param name='parameters'>
            /// The parameters containing the access key and suffix to update the storage
            /// account with, if any. Passing nothing results in no change.
            /// </param>
            public static void Update(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, string storageAccountName, UpdateStorageAccountParameters parameters = default(UpdateStorageAccountParameters))
            {
                operations.UpdateAsync(resourceGroupName, accountName, storageAccountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the Data Lake Analytics account to replace Azure Storage blob
            /// account details, such as the access key and/or suffix.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='storageAccountName'>
            /// The Azure Storage account to modify
            /// </param>
            /// <param name='parameters'>
            /// The parameters containing the access key and suffix to update the storage
            /// account with, if any. Passing nothing results in no change.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, string storageAccountName, UpdateStorageAccountParameters parameters = default(UpdateStorageAccountParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(resourceGroupName, accountName, storageAccountName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates the specified Data Lake Analytics account to remove an Azure
            /// Storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='storageAccountName'>
            /// The name of the Azure Storage account to remove
            /// </param>
            public static void Delete(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, string storageAccountName)
            {
                operations.DeleteAsync(resourceGroupName, accountName, storageAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the specified Data Lake Analytics account to remove an Azure
            /// Storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='storageAccountName'>
            /// The name of the Azure Storage account to remove
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, string storageAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, storageAccountName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists the Azure Storage containers, if any, associated with the specified
            /// Data Lake Analytics and Azure Storage account combination. The response
            /// includes a link to the next page of results, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='storageAccountName'>
            /// The name of the Azure storage account from which to list blob containers.
            /// </param>
            public static IPage<StorageContainer> ListStorageContainers(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, string storageAccountName)
            {
                return operations.ListStorageContainersAsync(resourceGroupName, accountName, storageAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the Azure Storage containers, if any, associated with the specified
            /// Data Lake Analytics and Azure Storage account combination. The response
            /// includes a link to the next page of results, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='storageAccountName'>
            /// The name of the Azure storage account from which to list blob containers.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<StorageContainer>> ListStorageContainersAsync(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, string storageAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListStorageContainersWithHttpMessagesAsync(resourceGroupName, accountName, storageAccountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the specified Azure Storage container associated with the given Data
            /// Lake Analytics and Azure Storage accounts.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='storageAccountName'>
            /// The name of the Azure storage account from which to retrieve the blob
            /// container.
            /// </param>
            /// <param name='containerName'>
            /// The name of the Azure storage container to retrieve
            /// </param>
            public static StorageContainer GetStorageContainer(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, string storageAccountName, string containerName)
            {
                return operations.GetStorageContainerAsync(resourceGroupName, accountName, storageAccountName, containerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified Azure Storage container associated with the given Data
            /// Lake Analytics and Azure Storage accounts.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='storageAccountName'>
            /// The name of the Azure storage account from which to retrieve the blob
            /// container.
            /// </param>
            /// <param name='containerName'>
            /// The name of the Azure storage container to retrieve
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageContainer> GetStorageContainerAsync(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, string storageAccountName, string containerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStorageContainerWithHttpMessagesAsync(resourceGroupName, accountName, storageAccountName, containerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the SAS token associated with the specified Data Lake Analytics and
            /// Azure Storage account and container combination.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='storageAccountName'>
            /// The name of the Azure storage account for which the SAS token is being
            /// requested.
            /// </param>
            /// <param name='containerName'>
            /// The name of the Azure storage container for which the SAS token is being
            /// requested.
            /// </param>
            public static IPage<SasTokenInformation> ListSasTokens(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, string storageAccountName, string containerName)
            {
                return operations.ListSasTokensAsync(resourceGroupName, accountName, storageAccountName, containerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the SAS token associated with the specified Data Lake Analytics and
            /// Azure Storage account and container combination.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='storageAccountName'>
            /// The name of the Azure storage account for which the SAS token is being
            /// requested.
            /// </param>
            /// <param name='containerName'>
            /// The name of the Azure storage container for which the SAS token is being
            /// requested.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SasTokenInformation>> ListSasTokensAsync(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, string storageAccountName, string containerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListSasTokensWithHttpMessagesAsync(resourceGroupName, accountName, storageAccountName, containerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the first page of Azure Storage accounts, if any, linked to the
            /// specified Data Lake Analytics account. The response includes a link to the
            /// next page, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<StorageAccountInformation> ListByAccountNext(this IStorageAccountsOperations operations, string nextPageLink)
            {
                return operations.ListByAccountNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the first page of Azure Storage accounts, if any, linked to the
            /// specified Data Lake Analytics account. The response includes a link to the
            /// next page, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<StorageAccountInformation>> ListByAccountNextAsync(this IStorageAccountsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAccountNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the Azure Storage containers, if any, associated with the specified
            /// Data Lake Analytics and Azure Storage account combination. The response
            /// includes a link to the next page of results, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<StorageContainer> ListStorageContainersNext(this IStorageAccountsOperations operations, string nextPageLink)
            {
                return operations.ListStorageContainersNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the Azure Storage containers, if any, associated with the specified
            /// Data Lake Analytics and Azure Storage account combination. The response
            /// includes a link to the next page of results, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<StorageContainer>> ListStorageContainersNextAsync(this IStorageAccountsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListStorageContainersNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the SAS token associated with the specified Data Lake Analytics and
            /// Azure Storage account and container combination.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SasTokenInformation> ListSasTokensNext(this IStorageAccountsOperations operations, string nextPageLink)
            {
                return operations.ListSasTokensNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the SAS token associated with the specified Data Lake Analytics and
            /// Azure Storage account and container combination.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SasTokenInformation>> ListSasTokensNextAsync(this IStorageAccountsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListSasTokensNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
