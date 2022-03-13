using System;
using Entitas;
using UnityEngine;

public sealed class InputSystem : IExecuteSystem, ICleanupSystem
{
    readonly Contexts _contexts;

    public InputSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Execute()
    {
        setBurstMode();
        setGroupMode();
        emitInput();
    }

    public void Cleanup()
    {
        foreach (var e in _contexts.input.GetGroup(InputMatcher.Input).GetEntities())
        {
            e.Destroy();
        }
    }

    void setBurstMode()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            _contexts.input.isBurstMode = !_contexts.input.isBurstMode;
        }
    }

    void setGroupMode()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            _contexts.input.isGroupMode = !_contexts.input.isGroupMode;
        }
    }

    void emitInput()
    {
        var input = _contexts.input.isBurstMode
            ? Input.GetMouseButton(0)
            : Input.GetMouseButtonDown(0);

        if (input)
        {
            var mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var e = _contexts.input.CreateEntity();
            e.AddInput(new Vector2Int(
                (int)Math.Round(mouseWorldPos.x),
                (int)Math.Round(mouseWorldPos.y)
            ));
        }
    }
}
