
using UnityEngine;

public class camera : MonoBehaviour




{
    public Transform target;
    public Vector3 offset;
    [Range(1,10)]
    public float smoothfactor;


    private void FixedUpdate()
    {
        follow();
    }
    void follow()
    {
        Vector3 targetposition = target.position + offset;
        Vector3 smoothposition = Vector3.Lerp(transform.position,targetposition,smoothfactor*Time.fixedDeltaTime);
        transform.position = smoothposition;

    }



}