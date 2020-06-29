using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GridSpace : MonoBehaviour {

	public Button button;

    private GameController g;
    //private two_torus t;
    public bool onet;

    public void Move(Button b)
    {
        //if (onet)
        g.Move(int.Parse(b.name), onet);
        //else
            //t.Move(int.Parse(b.name));
    }

    public void SetGameControllerReference(GameController game)
    {
        g = game;
    }

    /*public void SetGameControllerReference2(two_torus game)
    {
        t = game;
    }*/

}
