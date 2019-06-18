using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    public RectTransform[] things;
    public Rigidbody2D person;
    public SpriteRenderer personRenderer;
    public Sprite running1;
    public Sprite running2;


    public int xSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //RectTransform trans = thing.
        foreach(RectTransform thing in things)
        {
            thing.position += Vector3.left * 1.0f;
        }
        things[2].Rotate(new Vector3(0, 0, -1));

        if (Input.GetMouseButtonDown(0))
        {
            person.gravityScale *= -1;
            if (personRenderer.flipY)
            {
                personRenderer.flipY = false;
            }
            else
            {
                personRenderer.flipY = true;
            }
        }
        //running animation
        if (personRenderer.sprite == running1){
            personRenderer.sprite = running2;
        }
        else
        {
            personRenderer.sprite = running1;
        }

    }
}

public class GameObject : ScriptableObject
{
    int x;
    int y;
    int type;
    public GameObject(int xx, int yy, int typetype)
    {
        x = xx;
        y = yy;
        type = typetype;
    }
    void Update()
    {
        x -= 1;
    }
}

public class Ground : GameObject
{
    int x;
    int y;
    int type;
    int width;
    int height = 40;
    public Ground(int xx, int yy, int typetype, int widthwidth) : base( xx,  yy,  typetype)
    {
        x = xx;
        y = yy;
        type = typetype;
        width = widthwidth;
    }
    void draw()
    {
        
    }

}

