# Dependencies
[Graphene.Core](https://github.com/lososeg/Graphene.Core)

# Usage
```
using Graphene.Viz;

wssNode = "wss://.....";
privateKeys = new List<byte[]>
{
    Base58.GetBytes("5**************************************************") \\WIF
};
login = "username";

Api = new OperationManager(new WebSocketManager());
Api.ConnectToAsync(wssNode, CancellationToken.None);
```
## GetAccounts
```
string[] logins = new {login};
var accounts = await Api.GetAccountsAsync(logins, CancellationToken.None);
foreach (var account in accounts)
{
    Console.WriteLine(account.Name);
}
```
## GetChainProperties
```
var props = await Api.GetChainPropertiesAsync(CancellationToken.None);
Console.WriteLine(props.MinCurationPercent);
```
## GetDynamicGlobalProperties
```
var props = await Api.GetDynamicGlobalPropertiesAsync(CancellationToken.None);
Console.WriteLine(props.HeadBlockNumber);
```
## Transfer
```
var transferOp = new TransferOperation(login, "loginTo", new Asset("1.000 VIZ"), "memo or empty string");
var responce = Api.BroadcastOperations(privateKeys, transferOp, CancellationToken.None);
```
