# Usage
[Graphene.Core](https://github.com/lososeg/Graphene.Core)
```
using Graphene.Core;

wssNode = "wss://.....";
privateKeys = new List<byte[]>
{
    Base58.GetBytes("5**************************************************") \\WIF
};
login = "username";

Api = new OperationManager(new WebSocketManager());
Api.ConnectToAsync(wssNode, CancellationToken.None);

string[] logins = new {login};
var accounts = await Api.GetAccountsAsync(logins, CancellationToken.None);
foreach (var account in accounts)
{
    Console.WriteLine(account.Name);
}

var props = await Api.GetChainPropertiesAsync(CancellationToken.None);
Console.WriteLine(props.MinCurationPercent);

var props = await Api.GetDynamicGlobalPropertiesAsync(CancellationToken.None);
Console.WriteLine(props.HeadBlockNumber);

var transferOp = new TransferOperation(login, "loginTo", new Asset("1.000 VIZ"), "memo or empty string");
var responce = Api.BroadcastOperations(privateKeys, transferOp, CancellationToken.None);
```

