using UnityEngine;

public class Waypoints : MonoBehaviour
{

    public static Transform[] points;

    void Awake()
    {
        points = new Transform[transform.childCount];
    }

}
