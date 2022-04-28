using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleSelector : MonoBehaviour
{

    //now the problem with childing the sprites, RGBD and Colliders
    //is that the Paddle(parent) slides across the L/R Walls


    //different speeds
    public Vector3 MoveSpeeds;
    public Paddle Paddle;
    //public GameObject UIController;

    public List<GameObject> Paddles = new List<GameObject>();
    public List<GameObject> PaddleSprites = new List<GameObject>();
    int Selection;

    public void SelectPaddle(int _value)
    {
        Selection = _value;
        //Debug.Log(Selection);
        for (int i = Paddles.Count - 1; i >= 0; i--)
        {
            if (i != Selection) //&& Paddles[i] != null)
            {
                Paddles[i].SetActive(false);
                //Destroy(Paddles[i]);
                PaddleSprites[i].transform.localScale = new Vector3(1f, 1f, 1f);


            }
            else
            {
                Paddles[i].SetActive(true);
                //GameObject.Instantiate(Paddles[i], new Vector3(0f, -3.8f, 0f), Quaternion.identity);
                Paddle.MoveSpeed = MoveSpeeds[i];
                PaddleSprites[Selection].transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
            }

            //if (i != Selection)
            //{
            //    Paddles[i].SetActive(false);
            //    PaddleSprites[i].transform.localScale = new Vector3(1f, 1f, 1f);


            //}
            //else
            //{
            //    Paddles[i].SetActive(true);
            //    Paddle.MoveSpeed = MoveSpeeds[i];
            //    PaddleSprites[Selection].transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
            //}

        }
    }
}

//GameObject.Instanciate(Paddles[i], transform.position, Quaternion.identity);
//GameObject.Instantiate(BulletPrefab, transform.position, Quaternion.identity);