﻿using System.Threading;
using System.Threading.Tasks;
using Graphene.Core.JsonRpc;
using Graphene.Viz.Models;
using Newtonsoft.Json.Linq;

namespace Graphene.Viz
{
    /**
     * @brief The network_broadcast_api class allows broadcasting of transactions.
     */

    /// <summary>
    /// network_broadcast_api
    /// 
    /// </summary>
    public partial class OperationManager
    {

        /// <summary>
        /// API name: broadcast_transaction
        /// Broadcast a transaction to the network
        ///
        /// *The transaction will be checked for validity in the local database prior to broadcasting. If it fails to apply locally, an error will be thrown and the transaction will not be broadcast.
        /// 
        /// </summary>
        /// <param name="trx">API type: signed_transaction The transaction to broadcast
        /// 
        /// The transaction will be checked for validity in the local database prior to broadcasting. If it fails to
        /// apply locally, an error will be thrown and the transaction will not be broadcast.</param>
        /// <param name="token">Throws a <see cref="T:System.OperationCanceledException" /> if this token has had cancellation requested.</param>
        /// <returns>API type: void</returns>
        /// <exception cref="T:System.OperationCanceledException">The token has had cancellation requested.</exception>
        public Task<JsonRpcResponse<VoidResponse>> BroadcastTransactionAsync(SignedTransaction trx, CancellationToken token)
        {
            return CustomBroadcastRequestAsync<VoidResponse>(KnownApiNames.NetworkBroadcast, "broadcast_transaction", new object[] { trx }, token);
        }

        /// <summary>
        /// API name: broadcast_transaction_synchronous
        /// This call will not return until the transaction is included in a block.
        ///
        /// 
        /// </summary>
        /// <param name="trx">API type: signed_transaction</param>
        /// <param name="token">Throws a <see cref="T:System.OperationCanceledException" /> if this token has had cancellation requested.</param>
        /// <returns>API type: variant</returns>
        /// <exception cref="T:System.OperationCanceledException">The token has had cancellation requested.</exception>
        public Task<JsonRpcResponse<JObject>> BroadcastTransactionSynchronousAsync(SignedTransaction trx, CancellationToken token)
        {
            return CustomBroadcastRequestAsync<JObject>(KnownApiNames.NetworkBroadcast, "broadcast_transaction_synchronous", new object[] { trx }, token);
        }

/*        /// <summary>
        /// API name: broadcast_block
        /// 
        /// </summary>
        /// <param name="block">API type: signed_block</param>
        /// <param name="token">Throws a <see cref="T:System.OperationCanceledException" /> if this token has had cancellation requested.</param>
        /// <returns>API type: void</returns>
        /// <exception cref="T:System.OperationCanceledException">The token has had cancellation requested.</exception>
        public Task<JsonRpcResponse<VoidResponse>> BroadcastBlockAsync(SignedBlock block, CancellationToken token)
        {
            return CustomBroadcastRequestAsync<VoidResponse>(KnownApiNames.NetworkBroadcast, "broadcast_block", new object[] { block }, token);
        }*/
    }
}