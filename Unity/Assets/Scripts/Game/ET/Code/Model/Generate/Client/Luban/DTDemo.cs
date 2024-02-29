
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;

namespace ET
{
public partial class DTDemo : IDataTable
{
    private readonly System.Collections.Generic.Dictionary<int, DRDemo> _dataMap;
    private readonly System.Collections.Generic.List<DRDemo> _dataList;
    private readonly System.Func<Cysharp.Threading.Tasks.UniTask<ByteBuf>> _loadFunc;

    public DTDemo(System.Func<Cysharp.Threading.Tasks.UniTask<ByteBuf>> loadFunc)
    {
        _loadFunc = loadFunc;
        _dataMap = new System.Collections.Generic.Dictionary<int, DRDemo>();
        _dataList = new System.Collections.Generic.List<DRDemo>();
    }

    public async Cysharp.Threading.Tasks.UniTask LoadAsync()
    {
        ByteBuf _buf = await _loadFunc();
        _dataMap.Clear();
        _dataList.Clear();
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            DRDemo _v;
            _v = DRDemo.DeserializeDRDemo(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
        PostInit();
    }

    public System.Collections.Generic.Dictionary<int, DRDemo> DataMap => _dataMap;
    public System.Collections.Generic.List<DRDemo> DataList => _dataList;
    public DRDemo GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public DRDemo Get(int key) => _dataMap[key];
    public DRDemo this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
        PostResolveRef();
    }


    partial void PostInit();
    partial void PostResolveRef();
}
}
