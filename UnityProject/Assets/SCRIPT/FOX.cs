using UnityEngine;

public class FOX : MonoBehaviour
{
    [Header("速度"), Range(1, 100)]
    public float aaa = 5;
    [Header("剛體")]
    public Rigidbody2D r2d;
    [Header("圖片渲染器")]
    public SpriteRenderer SSS;

    float bbb;


    private void Start()
    {
        
        transform.position = new Vector2(-5,0);
    }

    private void AAA()
    {
        bbb = Input.GetAxisRaw("Horizontal") * aaa;

        Vector2 a = new Vector2(bbb, 0);
        r2d.AddForce(a, ForceMode2D.Force);
    }

    private void Update()
    {
        float aaa = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        transform.Rotate(0, aaa, 0);

        AAA();
            

    }
}
