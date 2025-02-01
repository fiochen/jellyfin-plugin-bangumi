using System.Collections.Generic;

namespace Jellyfin.Plugin.Bangumi.Model;

public class DataList<T>
{
    public int Total { get; set; }

    public int Limit { get; set; }

    public int Offset { get; set; }

    public IEnumerable<T> Data { get; set; } = [];
}
