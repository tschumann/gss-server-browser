using GameServerList.Common.External;
using GameServerList.Common.Utils;
using System.Collections.Concurrent;

namespace GameServerList.Tests;

public class AdHocTests
{
    public AdHocTests()
    {
    }

    [ManualFact]
    public async Task ValidateServerList()
    {
        var servers = FileUtils.LoadDataFromFile<List<string>>("../../../../GameServerList.App/Data/730_addresses.json");
        var validated = new ConcurrentBag<string>();

        await Parallel.ForEachAsync(servers, async (s, _) =>
        {
            var obj = await A2SQuery.QueryServerInfo(s, 5000);
            if (obj is not null && obj.HasValue)
                validated.Add(s);
        });

        FileUtils.WriteDataToFile("./validated.json", validated.Distinct().ToList());
    }
}