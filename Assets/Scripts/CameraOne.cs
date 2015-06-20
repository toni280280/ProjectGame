using UnityEngine;
using System.Collections;

public class CameraOne : MonoBehaviour
{

    private float offsetX;
    private float offsetY;

    public GameObject obj;
    

    public void Start() 
    {
        this.offsetX = this.transform.position.x - this.obj.transform.position.x;
        this.offsetY = this.transform.position.y - this.obj.transform.position.y;
        
    }
    public void Update()
    {
        
          
        var b = this.transform.position;
        b.x = this.obj.transform.position.x + offsetX;
        this.transform.position = b;

        var a = this.transform.position;
        a.y = this.obj.transform.position.y + offsetY;
        this.transform.position = a;
        
    }
}
