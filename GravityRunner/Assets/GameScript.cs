using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    public int xSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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

