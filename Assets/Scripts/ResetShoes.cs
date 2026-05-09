using UnityEngine;

public class ResetShoes : MonoBehaviour
{
    void LateUpdate()
    {
        // Resets the local position of the shoes to (0, 0, 0) every frame to prevent them from moving out of place
        transform.localPosition = Vector3.zero;
    }
}
