using UnityEngine;
using UnityEngine.UI;

public class GroupModeLabelController : MonoBehaviour, IAnyGroupModeListener, IAnyGroupModeRemovedListener
{
    public Text label;

    string _text;

    void Awake()
    {
        _text = label.text;
    }

    void Start()
    {
        var contexts = Contexts.sharedInstance;
        var listener = contexts.input.CreateEntity();
        listener.AddAnyGroupModeListener(this);
        listener.AddAnyGroupModeRemovedListener(this);

        if (contexts.input.isBurstMode)
        {
            OnAnyGroupMode(contexts.input.burstModeEntity);
        }
        else
        {
            OnAnyGroupModeRemoved(contexts.input.burstModeEntity);
        }
    }

    public void OnAnyGroupMode(InputEntity entity)
    {
        label.text = _text + ": on";
    }

    public void OnAnyGroupModeRemoved(InputEntity entity)
    {
        label.text = _text + ": off";
    }
}