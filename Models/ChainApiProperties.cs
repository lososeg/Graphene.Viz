using Newtonsoft.Json;

namespace Graphene.Viz.Models
{
    /// <summary>
    /// chain_api_properties
    /// libraries\api\include\golos\api\chain_api_properties.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ChainApiProperties
    {
        /// <summary>
        /// API name: account_creation_fee
        /// 
        /// </summary>
        /// <returns>API type: asset</returns>
        [JsonProperty("account_creation_fee")]
        public Asset AccountCreationFee { get; set; }

        /// <summary>
        /// API name: maximum_block_size
        /// 
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("maximum_block_size")]
        public uint MaximumBlockSize { get; set; }

        /// <summary>
        /// API name: create_account_delegation_ratio
        /// 
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("create_account_delegation_ratio")]
        public uint CreateAccountDelegationRatio { get; set; }

        /// <summary>
        /// API name: create_account_delegation_time
        /// 
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("create_account_delegation_time", NullValueHandling = NullValueHandling.Ignore)]
        public uint CreateAccountDelegationTime { get; set; }

        /// <summary>
        /// API name: min_delegation
        /// 
        /// </summary>
        /// <returns>API type: asset</returns>
        [JsonProperty("min_delegation")]
        public Asset MinDelegation { get; set; }

        /// <summary>
        /// API name: min_curation_percent
        /// 
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("min_curation_percent", NullValueHandling = NullValueHandling.Ignore)]
        public ushort MinCurationPercent { get; set; }

        /// <summary>
        /// API name: max_curation_percent
        /// 
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("max_curation_percent", NullValueHandling = NullValueHandling.Ignore)]
        public ushort MaxCurationPercent { get; set; }

        /// <summary>
        /// API name: bandwidth_reserve_percent
        /// 
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("bandwidth_reserve_percent", NullValueHandling = NullValueHandling.Ignore)]
        public ushort BandwidthReservePercent { get; set; }

        /// <summary>
        /// API name: bandwidth_reserve_below
        /// 
        /// </summary>
        /// <returns>API type: asset</returns>
        [JsonProperty("bandwidth_reserve_below")]
        public Asset BandwidthReserveBelow { get; set; }

        /// <summary>
        /// API name: flag_energy_additional_cost
        /// 
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("flag_energy_additional_cost", NullValueHandling = NullValueHandling.Ignore)]
        public ushort flag_energy_additional_cost { get; set; }

        /// <summary>
        /// API name: vote_accounting_min_rshares
        /// 
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("vote_accounting_min_rshares", NullValueHandling = NullValueHandling.Ignore)]
        public ulong vote_accounting_min_rshares { get; set; }

        /// <summary>
        /// API name: committee_request_approve_min_percent
        /// 
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("committee_request_approve_min_percent", NullValueHandling = NullValueHandling.Ignore)]
        public ushort committee_request_approve_min_percent { get; set; }

        /// <summary>
        /// API name: inflation_witness_percent
        /// 
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("inflation_witness_percent", NullValueHandling = NullValueHandling.Ignore)]
        public ushort inflation_witness_percent { get; set; }

        /// <summary>
        /// API name: inflation_ratio_committee_vs_reward_fund
        /// 
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("inflation_ratio_committee_vs_reward_fund", NullValueHandling = NullValueHandling.Ignore)]
        public ushort inflation_ratio_committee_vs_reward_fund { get; set; }

        /// <summary>
        /// API name: inflation_recalc_period
        /// 
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("inflation_recalc_period", NullValueHandling = NullValueHandling.Ignore)]
        public uint inflation_recalc_period { get; set; }

        /// <summary>
        /// API name: data_operations_cost_additional_bandwidth
        /// 
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("data_operations_cost_additional_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public uint data_operations_cost_additional_bandwidth { get; set; }

        /// <summary>
        /// API name: witness_miss_penalty_percent
        /// 
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("witness_miss_penalty_percent", NullValueHandling = NullValueHandling.Ignore)]
        public ushort witness_miss_penalty_percent { get; set; }

        /// <summary>
        /// API name: witness_miss_penalty_duration
        /// 
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("witness_miss_penalty_duration", NullValueHandling = NullValueHandling.Ignore)]
        public uint witness_miss_penalty_duration { get; set; }
    }
}