﻿using Newtonsoft.Json;

namespace Graphene.Viz.Models
{
    /// <inheritdoc />
    /// <summary>
    /// signed_block_header
    /// libraries\protocol\include\golos\protocol\block_header.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SignedBlockHeader : BlockHeader
    {

        /// <summary>
        /// API name: witness_signature
        /// 
        /// </summary>
        /// <returns>API type: signature_type</returns>
        [JsonProperty("witness_signature")]
        public object WitnessSignature { get; set; }
    }
}