using System.Collections;
using UnityEngine;

public abstract class EngineFunctionProvider : MonoBehaviour
{

    private void Update()
    {
        UpdateCall(); 
    }

    private void FixedUpdate()
    {
        FixedUpdateCall();
    }

    private void LateUpdate()
    {
        LateUpdateCall();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        OnCollisionEnter2DCall(collision.gameObject);
    }

    protected virtual void UpdateCall() { }
    protected virtual void FixedUpdateCall() { }
    protected virtual void LateUpdateCall() { }
    protected virtual void OnCollisionEnter2DCall(GameObject obj) { }
}