using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 5.0f;
    
    void LateUpdate()
    {
        transform.position += new Vector3(0, 0,-1*speed)*Time.deltaTime;
        
    }
}
