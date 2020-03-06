using Cryptography.ECDSA;

namespace Graphene.Viz
{
    public class Config
    {
        public static byte[] ChainId { get; set; } = Hex.HexToBytes("2040effda178d4fffff5eab7a915d4019879f5205cc5392e4bcced2b6edda0cd");
        public static string KeyPrefix { get; set; } = "VIZ";
        public string[] ChainFieldName { get; set; } = { "VIZ_CHAIN_ID", "VIZ_CHAIN_ID" };
    }
}