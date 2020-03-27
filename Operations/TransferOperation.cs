﻿using Graphene.Core.Attributes;
using Graphene.Viz.Models;
using Newtonsoft.Json;

namespace Graphene.Viz.Operations
{
    /// <inheritdoc />
    /// <summary>
    /// Transfers VIZ from one account to another.
    /// 
    /// transfer_operation
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class TransferOperation : BaseOperation
    {
        public const string OperationName = "transfer";

        public override OperationType Type => OperationType.Transfer;

        public override string TypeName => OperationName;


        /// <summary>
        /// API name: from
        /// 
        /// </summary>
        /// <returns>API type: account_name_type</returns>
        [MessageOrder(20)]
        [JsonProperty("from")]
        public string From { get; set; }

        /// Account to transfer asset to

        /// <summary>
        /// API name: to
        /// 
        /// </summary>
        /// <returns>API type: account_name_type</returns>
        [MessageOrder(30)]
        [JsonProperty("to")]
        public string To { get; set; }

        /// The amount of asset to transfer from @ref from to @ref to

        /// <summary>
        /// API name: amount
        /// 
        /// </summary>
        /// <returns>API type: asset</returns>
        [MessageOrder(40)]
        [JsonProperty("amount")]
        public Asset Amount { get; set; }


        /// The memo is plain-text, any encryption on the memo is up to
        /// a higher level protocol.

        /// <summary>
        /// API name: memo
        /// 
        /// </summary>
        /// <returns>API type: string</returns>
        [MessageOrder(50)]
        [JsonProperty("memo")]
        public string Memo { get; set; }


        /// <summary>
        /// Transfers VIZ from one account to another.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="amount"></param>
        /// <param name="memo"></param>
        public TransferOperation(string from, string to, Asset amount, string memo)
        {
            From = from;
            To = to;
            Amount = amount;
            Memo = memo;
        }
    }
}