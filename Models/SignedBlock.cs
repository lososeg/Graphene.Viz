﻿using Newtonsoft.Json;

namespace Graphene.Viz.Models
{
    /// <inheritdoc />
    /// <summary>
    /// signed_block
    /// libraries\protocol\include\golos\protocol\block.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SignedBlock : SignedBlockHeader
    {

        /// <summary>
        /// API name: transactions
        /// 
        /// </summary>
        /// <returns>API type: signed_transaction</returns>
        [JsonProperty("transactions")]
        public object[] Transactions { get; set; }
    }
}