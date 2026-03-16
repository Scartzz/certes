using Certes.Json;
using System;
using System.IO;
using System.Text.RegularExpressions;
using Xunit;

namespace Certes.Acme.Resource;

using System.Text.Json;

public class AccountTests
{
    [Fact]
    public void CanGetSetProperties()
    {
        var account = new Account();
        account.VerifyGetterSetter(a => a.Status, AccountStatus.Valid);
        account.VerifyGetterSetter(a => a.Contact, new string[] { "mailto:hello@example.com" });
        account.VerifyGetterSetter(a => a.Orders, new Uri("http://certes.is.working"));
        account.VerifyGetterSetter(a => a.TermsOfServiceAgreed, true);

        var r = new Account.Payload();
        r.VerifyGetterSetter(a => a.OnlyReturnExisting, true);
    }

    [Fact]
    public void CanBeSerialized()
    {
        var settings = JsonUtil.CreateJsonSettings();
        var srcJson = File.ReadAllText("./Data/account.json");
        var deserialized = JsonSerializer.Deserialize<Account>(srcJson, settings);
        var json = JsonSerializer.Serialize(deserialized, settings);

        Assert.Equal(AccountStatus.Valid, deserialized.Status);

        Assert.Equal(Regex.Replace(srcJson, @"\s", ""), Regex.Replace(json, @"\s", ""));
    }
}
