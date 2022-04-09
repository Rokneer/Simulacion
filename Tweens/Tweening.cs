using UnityEngine;

public class Tweening : MonoBehaviour
{
    [SerializeField]
    AnimationCurve curve;

    [SerializeField]
    private float duration = 5;

    [SerializeField]
    private Vector3 startPos;

    [SerializeField]
    private Vector3 endPos = Vector3.one;


    private void Update()
    {
        float t = Time.time / duration;
        transform.position = Vector3.LerpUnclamped(startPos, endPos, curve.Evaluate(t));
    }
}
