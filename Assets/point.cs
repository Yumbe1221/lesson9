using TouchScript;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void OnEnable()
    {
        var t = TouchManager.Instance;
        if (t == null) return;
        t.PointersPressed += OnPointersPressed;
    }

    private void OnDisable()
    {
        var t = TouchManager.Instance;
        if (t == null) return;
        t.PointersPressed -= OnPointersPressed;
    }

    private void OnPointersPressed(object sender, PointerEventArgs e)
    {
        foreach (var n in e.Pointers)
        {
            Debug.LogFormat("Id: {0} Position: {1}", n.Id, n.Position);
        }
    }
}