using Ditch.Core.Models;
using Newtonsoft.Json;

namespace Graphene.Viz.Models
{
    /// <summary>
    /// account_api_object
    /// /libraries/api/include/graphene/api/account_api_object.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class AccountApiObject
    {

        /// <summary>
        /// API name: id
        /// 
        /// </summary>
        /// <returns>API type: account_object::id_type</returns>
        [JsonProperty("id")]
        public object Id { get; set; }

        /// <summary>
        /// API name: name
        /// 
        /// </summary>
        /// <returns>API type: account_name_type</returns>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// API name: master_authority
        /// 
        /// </summary>
        /// <returns>API type: authority</returns>
        [JsonProperty("master_authority")]
        public Authority MasterAuthority { get; set; }

        /// <summary>
        /// API name: active_authority
        /// 
        /// </summary>
        /// <returns>API type: authority</returns>
        [JsonProperty("active_authority")]
        public Authority ActiveAuthority { get; set; }

        /// <summary>
        /// API name: regular_authority
        /// 
        /// </summary>
        /// <returns>API type: authority</returns>
        [JsonProperty("regular_authority")]
        public Authority RegularAuthority { get; set; }

        /// <summary>
        /// API name: memo_key
        /// 
        /// </summary>
        /// <returns>API type: public_key_type</returns>
        [JsonProperty("memo_key")]
        public PublicKeyType MemoKey { get; set; }

        /// <summary>
        /// API name: json_metadata
        /// 
        /// </summary>
        /// <returns>API type: string</returns>
        [JsonProperty("json_metadata")]
        public string JsonMetadata { get; set; }

        /// <summary>
        /// API name: proxy
        /// 
        /// </summary>
        /// <returns>API type: account_name_type</returns>
        [JsonProperty("proxy")]
        public string Proxy { get; set; }

        /// <summary>
        /// API name: referrer
        /// 
        /// </summary>
        /// <returns>API type: account_name_type</returns>
        [JsonProperty("referrer")]
        public string Referrer { get; set; }

        /// <summary>
        /// API name: last_master_update
        /// 
        /// </summary>
        /// <returns>API type: time_point_sec</returns>
        [JsonProperty("last_master_update")]
        public TimePointSec LastMasterUpdate { get; set; }

        /// <summary>
        /// API name: last_account_update
        /// 
        /// </summary>
        /// <returns>API type: time_point_sec</returns>
        [JsonProperty("last_account_update")]
        public TimePointSec LastAccountUpdate { get; set; }

        /// <summary>
        /// API name: created
        /// 
        /// </summary>
        /// <returns>API type: time_point_sec</returns>
        [JsonProperty("created")]
        public TimePointSec Created { get; set; }

        /// <summary>
        /// API name: last_account_recovery
        /// 
        /// </summary>
        /// <returns>API type: time_point_sec</returns>
        [JsonProperty("last_account_recovery")]
        public TimePointSec LastAccountRecovery { get; set; }

        /// <summary>
        /// API name: subcontent_count
        /// 
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("subcontent_count")]
        public uint SubcontentCount { get; set; }

        /// <summary>
        /// API name: vote_count
        /// 
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("vote_count")]
        public uint VoteCount { get; set; }

        /// <summary>
        /// API name: content_count
        /// 
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("content_count")]
        public uint ContentCount { get; set; }

        /// <summary>
        /// API name: awarded_rshares
        /// 
        /// </summary>
        /// <returns>API type: uint64_t</returns>
        [JsonProperty("awarded_rshares")]
        public ulong AwardedRshares { get; set; }

        /// <summary>
        /// API name: custom_sequence
        /// 
        /// </summary>
        /// <returns>API type: uint64_t</returns>
        [JsonProperty("custom_sequence")]
        public ulong CustomSequence { get; set; }

        /// <summary>
        /// API name: custom_sequence_block_num
        /// 
        /// </summary>
        /// <returns>API type: uint64_t</returns>
        [JsonProperty("custom_sequence_block_num")]
        public ulong CustomSequenceBlockNum { get; set; }

        /// <summary>
        /// API name: energy
        /// 
        /// </summary>
        /// <returns>API type: uint16_t</returns>
        [JsonProperty("energy")]
        public ushort Energy { get; set; }

        /// <summary>
        /// API name: last_vote_time
        /// 
        /// </summary>
        /// <returns>API type: time_point_sec</returns>
        [JsonProperty("last_vote_time")]
        public TimePointSec LastVoteTime { get; set; }

        /// <summary>
        /// API name: balance
        /// 
        /// </summary>
        /// <returns>API type: asset</returns>
        [JsonProperty("balance")]
        public Asset Balance { get; set; }

        /// <summary>
        /// API name: curation_rewards
        /// 
        /// </summary>
        /// <returns>API type: share_type</returns>
        [JsonProperty("curation_rewards")]
        public object CurationRewards { get; set; }

        /// <summary>
        /// API name: posting_rewards
        /// 
        /// </summary>
        /// <returns>API type: share_type</returns>
        [JsonProperty("posting_rewards")]
        public object PostingRewards { get; set; }

        /// <summary>
        /// API name: receiver_awards
        /// 
        /// </summary>
        /// <returns>API type: share_type</returns>
        [JsonProperty("receiver_awards")]
        public object ReceiverAwards { get; set; }

        /// <summary>
        /// API name: benefactor_awards
        /// 
        /// </summary>
        /// <returns>API type: share_type</returns>
        [JsonProperty("benefactor_awards")]
        public object BenefactorAwards { get; set; }

        /// <summary>
        /// API name: vesting_shares
        /// 
        /// </summary>
        /// <returns>API type: asset</returns>
        [JsonProperty("vesting_shares")]
        public Asset VestingShares { get; set; }

        /// <summary>
        /// API name: delegated_vesting_shares
        /// 
        /// </summary>
        /// <returns>API type: asset</returns>
        [JsonProperty("delegated_vesting_shares")]
        public Asset DelegatedVestingShares { get; set; }

        /// <summary>
        /// API name: received_vesting_shares
        /// 
        /// </summary>
        /// <returns>API type: asset</returns>
        [JsonProperty("received_vesting_shares")]
        public Asset ReceivedVestingShares { get; set; }

        /// <summary>
        /// API name: vesting_withdraw_rate
        /// 
        /// </summary>
        /// <returns>API type: asset</returns>
        [JsonProperty("vesting_withdraw_rate")]
        public Asset VestingWithdrawRate { get; set; }

        /// <summary>
        /// API name: next_vesting_withdrawal
        /// 
        /// </summary>
        /// <returns>API type: time_point_sec</returns>
        [JsonProperty("next_vesting_withdrawal")]
        public TimePointSec NextVestingWithdrawal { get; set; }

        /// <summary>
        /// API name: withdrawn
        /// 
        /// </summary>
        /// <returns>API type: share_type</returns>
        [JsonProperty("withdrawn")]
        public object Withdrawn { get; set; }

        /// <summary>
        /// API name: to_withdraw
        /// 
        /// </summary>
        /// <returns>API type: share_type</returns>
        [JsonProperty("to_withdraw")]
        public object ToWithdraw { get; set; }

        /// <summary>
        /// API name: withdraw_routes
        /// 
        /// </summary>
        /// <returns>API type: uint16_t</returns>
        [JsonProperty("withdraw_routes")]
        public ushort WithdrawRoutes { get; set; }

        /// <summary>
        /// API name: proxied_vsf_votes
        /// 
        /// </summary>
        /// <returns>API type: share_type</returns>
        [JsonProperty("proxied_vsf_votes")]
        public object[] ProxiedVsfVotes { get; set; }

        /// <summary>
        /// API name: witnesses_voted_for
        /// 
        /// </summary>
        /// <returns>API type: uint16_t</returns>
        [JsonProperty("witnesses_voted_for")]
        public ushort WitnessesVotedFor { get; set; }

        /// <summary>
        /// API name: witnesses_vote_weight
        /// 
        /// </summary>
        /// <returns>API type: share_type</returns>
        [JsonProperty("witnesses_vote_weight")]
        public object WitnessesVoteWeight { get; set; }

        /// <summary>
        /// API name: last_root_post
        /// 
        /// </summary>
        /// <returns>API type: time_point_sec</returns>
        [JsonProperty("last_root_post")]
        public TimePointSec LastRootPost { get; set; }

        /// <summary>
        /// API name: last_post
        /// 
        /// </summary>
        /// <returns>API type: time_point_sec</returns>
        [JsonProperty("last_post")]
        public TimePointSec LastPost { get; set; }

        /// <summary>
        /// API name: average_bandwidth
        /// 
        /// </summary>
        /// <returns>API type: share_type</returns>
        [JsonProperty("average_bandwidth")]
        public object AverageBandwidth { get; set; }

        /// <summary>
        /// API name: lifetime_bandwidth
        /// 
        /// </summary>
        /// <returns>API type: share_type</returns>
        [JsonProperty("lifetime_bandwidth")]
        public object LifetimeBandwidth { get; set; }

        /// <summary>
        /// API name: last_bandwidth_update
        /// 
        /// </summary>
        /// <returns>API type: time_point_sec</returns>
        [JsonProperty("last_bandwidth_update")]
        public TimePointSec LastBandwidthUpdate { get; set; }

        /// <summary>
        /// API name: witness_votes
        /// 
        /// </summary>
        /// <returns>API type: string</returns>
        [JsonProperty("witness_votes")]
        public string[] WitnessVotes { get; set; }

        /// <summary>
        /// API name: valid
        /// 
        /// </summary>
        /// <returns>API type: bool</returns>
        [JsonProperty("valid")]
        public bool Valid { get; set; }

        /// <summary>
        /// API name: account_seller
        /// 
        /// </summary>
        /// <returns>API type: account_name_type</returns>
        [JsonProperty("account_seller")]
        public string AccountSeller { get; set; }

        /// <summary>
        /// API name: account_offer_price
        /// 
        /// </summary>
        /// <returns>API type: asset</returns>
        [JsonProperty("account_offer_price")]
        public Asset AccountOfferPrice { get; set; }

        /// <summary>
        /// API name: account_on_sale
        /// 
        /// </summary>
        /// <returns>API type: bool</returns>
        [JsonProperty("account_on_sale")]
        public bool AccountOnSale { get; set; }

        /// <summary>
        /// API name: subaccount_seller
        /// 
        /// </summary>
        /// <returns>API type: subaccount_seller</returns>
        [JsonProperty("subaccount_seller")]
        public string SubaccountSeller { get; set; }

        /// <summary>
        /// API name: subaccount_offer_price
        /// 
        /// </summary>
        /// <returns>API type: asset</returns>
        [JsonProperty("subaccount_offer_price")]
        public Asset SubaccountOfferPrice { get; set; }

        /// <summary>
        /// API name: subaccount_on_sale
        /// 
        /// </summary>
        /// <returns>API type: bool</returns>
        [JsonProperty("subaccount_on_sale")]
        public bool SubaccountOnSale { get; set; }
    }
}