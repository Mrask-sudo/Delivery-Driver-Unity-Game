using UnityEngine;

public class FollowCam : MonoBehaviour
{
        [SerializeField] GameObject thingTOFollow;

    void LateUpdate()
    {
        transform.position = thingTOFollow.transform.position + new Vector3 (0,0,-10);
    }
}
