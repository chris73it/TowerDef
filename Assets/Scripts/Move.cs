using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 movDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += movDirection * Time.deltaTime;
    }
}
