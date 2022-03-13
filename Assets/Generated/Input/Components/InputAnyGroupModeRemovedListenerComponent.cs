//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public AnyGroupModeRemovedListenerComponent anyGroupModeRemovedListener { get { return (AnyGroupModeRemovedListenerComponent)GetComponent(InputComponentsLookup.AnyGroupModeRemovedListener); } }
    public bool hasAnyGroupModeRemovedListener { get { return HasComponent(InputComponentsLookup.AnyGroupModeRemovedListener); } }

    public void AddAnyGroupModeRemovedListener(System.Collections.Generic.List<IAnyGroupModeRemovedListener> newValue) {
        var index = InputComponentsLookup.AnyGroupModeRemovedListener;
        var component = (AnyGroupModeRemovedListenerComponent)CreateComponent(index, typeof(AnyGroupModeRemovedListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAnyGroupModeRemovedListener(System.Collections.Generic.List<IAnyGroupModeRemovedListener> newValue) {
        var index = InputComponentsLookup.AnyGroupModeRemovedListener;
        var component = (AnyGroupModeRemovedListenerComponent)CreateComponent(index, typeof(AnyGroupModeRemovedListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveAnyGroupModeRemovedListener() {
        RemoveComponent(InputComponentsLookup.AnyGroupModeRemovedListener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherAnyGroupModeRemovedListener;

    public static Entitas.IMatcher<InputEntity> AnyGroupModeRemovedListener {
        get {
            if (_matcherAnyGroupModeRemovedListener == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.AnyGroupModeRemovedListener);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherAnyGroupModeRemovedListener = matcher;
            }

            return _matcherAnyGroupModeRemovedListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public void AddAnyGroupModeRemovedListener(IAnyGroupModeRemovedListener value) {
        var listeners = hasAnyGroupModeRemovedListener
            ? anyGroupModeRemovedListener.value
            : new System.Collections.Generic.List<IAnyGroupModeRemovedListener>();
        listeners.Add(value);
        ReplaceAnyGroupModeRemovedListener(listeners);
    }

    public void RemoveAnyGroupModeRemovedListener(IAnyGroupModeRemovedListener value, bool removeComponentWhenEmpty = true) {
        var listeners = anyGroupModeRemovedListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveAnyGroupModeRemovedListener();
        } else {
            ReplaceAnyGroupModeRemovedListener(listeners);
        }
    }
}
