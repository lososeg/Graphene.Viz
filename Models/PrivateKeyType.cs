using Graphene.Core;
using Graphene.Core.Attributes;
using Graphene.Core.Converters;
using Newtonsoft.Json;
using Cryptography.ECDSA;

namespace Graphene.Viz.Models
{
    [JsonConverter(typeof(CustomJsonConverter))]
    public class PrivateKeyType : ICustomJson
    {
        [MessageOrder(1)]
        public byte[] Data { get; set; }


        public PrivateKeyType() { }

        public PrivateKeyType(string value)
        {
            Data = Core.Base58.DecodePrivateWif(value);
        }

        public PrivateKeyType(byte[] data)
        {
            Data = data;
        }

        public PublicKeyType ToPublicKey()
        {
            PublicKeyType publicKey = new PublicKeyType(Secp256K1Manager.GetPublicKey(Data, true));
            return publicKey;
        }

        #region ICustomJson

        public void ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var value = reader.Value.ToString();
            Data = Core.Base58.DecodePrivateWif(value);
        }

        public void WriteJson(JsonWriter writer, JsonSerializer serializer)
        {
            var wif = Core.Base58.EncodePrivateWif(Data);
            writer.WriteValue(wif);
        }

        #endregion
    }
}