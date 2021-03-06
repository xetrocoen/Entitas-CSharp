//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public class SomeOtherClassComponent : IComponent {

    public SomeNamespace.SomeOtherClass value;
}

namespace Entitas {

    public partial class Entity {

        public SomeOtherClassComponent someOtherClass { get { return (SomeOtherClassComponent)GetComponent(VisualDebuggingComponentIds.SomeOtherClass); } }
        public bool hasSomeOtherClass { get { return HasComponent(VisualDebuggingComponentIds.SomeOtherClass); } }

        public Entity AddSomeOtherClass(SomeNamespace.SomeOtherClass newValue) {
            var component = CreateComponent<SomeOtherClassComponent>(VisualDebuggingComponentIds.SomeOtherClass);
            component.value = newValue;
            return AddComponent(VisualDebuggingComponentIds.SomeOtherClass, component);
        }

        public Entity ReplaceSomeOtherClass(SomeNamespace.SomeOtherClass newValue) {
            var component = CreateComponent<SomeOtherClassComponent>(VisualDebuggingComponentIds.SomeOtherClass);
            component.value = newValue;
            ReplaceComponent(VisualDebuggingComponentIds.SomeOtherClass, component);
            return this;
        }

        public Entity RemoveSomeOtherClass() {
            return RemoveComponent(VisualDebuggingComponentIds.SomeOtherClass);
        }
    }
}

    public partial class VisualDebuggingMatcher {

        static IMatcher _matcherSomeOtherClass;

        public static IMatcher SomeOtherClass {
            get {
                if(_matcherSomeOtherClass == null) {
                    var matcher = (Matcher)Matcher.AllOf(VisualDebuggingComponentIds.SomeOtherClass);
                    matcher.componentNames = VisualDebuggingComponentIds.componentNames;
                    _matcherSomeOtherClass = matcher;
                }

                return _matcherSomeOtherClass;
            }
        }
    }
