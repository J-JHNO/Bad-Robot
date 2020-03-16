using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiIA : MonoBehaviour {

    private Vector3 depart;
    public Transform arriver;
    public float speed = 1;

    private Vector3 basePosition;

    // rotation
    public float x;
    public float y;
    public float z;

    // Use this for initialization
    IEnumerator Start () {
        depart = transform.position;
        basePosition = depart;
        x = transform.rotation.x;
        y = transform.rotation.y;
        z = transform.rotation.z;

        while (true)
        {
            float i = Mathf.PingPong(Time.time * speed, 1);
            transform.position = Vector3.Lerp(depart, arriver.position,i);
            yield return 0;
        }
	}

    public void Reset()
    {
        transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        Quaternion rotation = new Quaternion(x, y, z, 1);
        transform.SetPositionAndRotation(basePosition, rotation);
    }

}
