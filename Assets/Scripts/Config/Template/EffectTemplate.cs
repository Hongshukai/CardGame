//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ball.Config {
  using ProtoBuf;
  
  
  [ProtoContract()]
  public class EffectTemplate : IGeneratorObject {
    
    // 索引
    [ProtoMember(1)]
    public int Id;
    
    // 用途
    [ProtoMember(2)]
    public int Usage;
    
    // 资源路径
    [ProtoMember(3)]
    public string AssetPath;
    
    public virtual void OnInit() {
    }
    
    public static EffectTemplate[] Load() {
      return Load<EffectTemplate>();
    }
    
    public static T[] Load<T>()
      where T : EffectTemplate, new () {
      return GeneratorUtility.Load<T>("EffectsConfig", "Effect");
    }
  }
}
