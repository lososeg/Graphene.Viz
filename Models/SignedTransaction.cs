using Newtonsoft.Json;

namespace Graphene.Viz.Models
{
    /// <inheritdoc />
    /// <summary>
    /// signed_transaction
    /// 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SignedTransaction : Transaction
    {
        /// <summary>
        /// API name: signatures
        /// 
        /// </summary>
        /// <returns>API type: signature_type</returns>
        [JsonProperty("signatures")]
        public string[] Signatures { get; set; }
    }
}