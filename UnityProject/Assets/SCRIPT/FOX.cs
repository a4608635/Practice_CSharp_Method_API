
using UnityEngine;

public class FOX : MonoBehaviour
{
    [Header("速度"), Range(1, 100)]
    public int aaa = 5;
    [Header("剛體")]
    public Rigidbody2D r2d;
    [Header("圖片渲染器")]
    public SpriteRenderer SSS;

    private void AAA()
    {
        print( Input.GetAxisRaw("Horizontal") * Time.deltaTime);


    }

    private void Update()
    {
        AAA();
       
            

    }
}
