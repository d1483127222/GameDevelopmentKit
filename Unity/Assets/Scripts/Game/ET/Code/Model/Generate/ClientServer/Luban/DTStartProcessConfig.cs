
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
public partial class DTStartProcessConfig : IDataTable
{
    private readonly System.Collections.Generic.List<DRStartProcessConfig> _dataList;
    private System.Collections.Generic.Dictionary<(string, int), DRStartProcessConfig> _dataMapUnion;
    private readonly System.Func<Cysharp.Threading.Tasks.UniTask<ByteBuf>> _loadFunc;

    public DTStartProcessConfig(System.Func<Cysharp.Threading.Tasks.UniTask<ByteBuf>> loadFunc)
    {
        _loadFunc = loadFunc;
        _dataList = new System.Collections.Generic.List<DRStartProcessConfig>();
         _dataMapUnion = new System.Collections.Generic.Dictionary<(string, int), DRStartProcessConfig>();
    }

    public async Cysharp.Threading.Tasks.UniTask LoadAsync()
    {
        ByteBuf _buf = await _loadFunc();
        _dataList.Clear();
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            DRStartProcessConfig _v;
            _v = DRStartProcessConfig.DeserializeDRStartProcessConfig(_buf);
            _dataList.Add(_v);
        }
        _dataMapUnion.Clear();
        foreach(var _v in _dataList)
        {
            _dataMapUnion.Add((_v.StartConfig, _v.Id), _v);
        }
        PostInit();
    }

    public System.Collections.Generic.List<DRStartProcessConfig> DataList => _dataList;
    public DRStartProcessConfig Get(string StartConfig, int Id) => _dataMapUnion.TryGetValue((StartConfig, Id), out DRStartProcessConfig __v) ? __v : null;

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
