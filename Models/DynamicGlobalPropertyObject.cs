using Graphene.Core.Models;
using Newtonsoft.Json;

namespace Graphene.Viz.Models
{
    /**
     * @class dynamic_global_property_object
     * @brief Maintains global state information
     * @ingroup object
     * @ingroup implementation
     *
     * This is an implementation detail. The values here are calculated during normal chain operations and reflect the
     * current values of global blockchain properties.
     */

    /// <summary>
    /// dynamic_global_property_object
    /// libraries\chain\include\golos\chain\global_property_object.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class DynamicGlobalPropertyObject
    {

        /// <summary>
        /// API name: id
        /// 
        /// </summary>
        /// <returns>API type: id_type</returns>
        [JsonProperty("id")]
        public object Id { get; set; }

        /// <summary>
        /// API name: head_block_number
        /// = 0;
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("head_block_number")]
        public uint HeadBlockNumber { get; set; }

        /// <summary>
        /// API name: head_block_id
        /// 
        /// </summary>
        /// <returns>API type: block_id_type</returns>
        [JsonProperty("head_block_id")]
        public string HeadBlockId { get; set; }

        /// <summary>
        /// API name: genesis_time
        /// 
        /// </summary>
        /// <returns>API type: time_point_sec</returns>
        [JsonProperty("genesis_time")]
        public TimePointSec GenesisTime { get; set; }

        /// <summary>
        /// API name: time
        /// 
        /// </summary>
        /// <returns>API type: time_point_sec</returns>
        [JsonProperty("time")]
        public TimePointSec Time { get; set; }

        /// <summary>
        /// API name: current_witness
        /// 
        /// </summary>
        /// <returns>API type: account_name_type</returns>
        [JsonProperty("current_witness")]
        public string CurrentWitness { get; set; }

        /// <summary>
        /// API name: committee_fund
        /// 
        /// </summary>
        /// <returns>API type: asset</returns>
        [JsonProperty("committee_fund")]
        public Asset CommitteeFund { get; set; }

        /// <summary>
        /// API name: committee_requests
        /// = 0;
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("committee_requests")]
        public uint CommitteeRequests { get; set; }

        /// <summary>
        /// API name: current_supply
        /// 
        /// </summary>
        /// <returns>API type: asset</returns>
        [JsonProperty("current_supply")]
        public Asset CurrentSupply { get; set; }

        /// <summary>
        /// API name: total_vesting_fund
        /// 
        /// </summary>
        /// <returns>API type: asset</returns>
        [JsonProperty("total_vesting_fund")]
        public Asset TotalVestingFund { get; set; }

        /// <summary>
        /// API name: total_vesting_shares
        /// 
        /// </summary>
        /// <returns>API type: asset</returns>
        [JsonProperty("total_vesting_shares")]
        public Asset TotalVestingShares { get; set; }

        /// <summary>
        /// API name: total_reward_fund
        /// 
        /// </summary>
        /// <returns>API type: asset</returns>
        [JsonProperty("total_reward_fund")]
        public Asset TotalRewardFund { get; set; }

        /// <summary>
        /// API name: total_reward_shares
        /// 
        /// </summary>
        /// <returns>API type: uint64_t</returns>
        [JsonProperty("total_reward_shares")]
        public ulong TotalRewardShares { get; set; }

        /// <summary>
        /// API name: average_block_size
        /// = 0;
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("average_block_size")]
        public uint AverageBlockSize { get; set; }

        /// <summary>
        /// API name: maximum_block_size
        /// = 0;
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("maximum_block_size")]
        public uint MaximumBlockSize { get; set; }

        /// <summary>
        /// API name: current_aslot
        /// = 0;
        /// </summary>
        /// <returns>API type: uint64_t</returns>
        [JsonProperty("current_aslot")]
        public ulong CurrentAslot { get; set; }

        /// <summary>
        /// API name: recent_slots_filled
        /// 
        /// </summary>
        /// <returns>API type: uint128_t</returns>
        [JsonProperty("recent_slots_filled")]
        public UInt128 RecentSlotsFilled { get; set; }

        /// <summary>
        /// API name: participation_count
        /// = 0; ///&lt; Divide by 128 to compute participation percentage
        /// </summary>
        /// <returns>API type: uint8_t</returns>
        [JsonProperty("participation_count")]
        public byte ParticipationCount { get; set; }

        /// <summary>
        /// API name: last_irreversible_block_num
        ///
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("last_irreversible_block_num")]
        public uint LastIrreversibleBlockNum { get; set; }

        /// <summary>
        /// API name: max_virtual_bandwidth
        /// 
        /// </summary>
        /// <returns>API type: uint64_t</returns>
        [JsonProperty("max_virtual_bandwidth")]
        public ulong MaxVirtualBandwidth { get; set; }

        /// <summary>
        /// API name: current_reserve_ratio
        /// 
        /// </summary>
        /// <returns>API type: uint64_t</returns>
        [JsonProperty("current_reserve_ratio")]
        public ulong CurrentReserveRatio { get; set; }

        /// <summary>
        /// API name: vote_regeneration_per_day
        /// 
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("vote_regeneration_per_day")]
        public uint VoteRegenerationPerDay { get; set; }

        /// <summary>
        /// API name: bandwidth_reserve_candidates
        ///
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("bandwidth_reserve_candidates")]
        public uint BandwidthReserveCandidates { get; set; }

        /// <summary>
        /// API name: inflation_calc_block_num
        /// 
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("inflation_calc_block_num")]
        public uint InflationCalcBlockNum { get; set; }

        /// <summary>
        /// API name: inflation_witness_percent
        /// 
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("inflation_witness_percent")]
        public ushort InflationWitnessPercent { get; set; }

        /// <summary>
        /// API name: inflation_ratio
        /// 
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("inflation_ratio")]
        public ushort InflationRatio { get; set; }
    }
}