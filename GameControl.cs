using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    public GameObject CurrentObstacle;
    public GameObject[] ObstacleExtractor;
    public Text my_text;

    public float saglik;

    public Image Healthbar;

  


    void Start()
    {
        saglik = 100;
      

    }
    public void OnMouseUpAsButton(int ÝndexValue)
    {
        if (ÝndexValue == 0)
        {
            //Instantiate(CurrentObstacle, new Vector3(1f, 2f, 3f), Quaternion.identity);
        }

        else if (ÝndexValue == 1)
        {         
           Instantiate(CurrentObstacle, ObstacleExtractor[1].transform.position,Quaternion.identity);    
        }

        else if (ÝndexValue == 2)
        {
            Instantiate(CurrentObstacle, ObstacleExtractor[0].transform.position, Quaternion.identity);
        }

    }

    public void healthDrop(float darbe)
    {
        saglik -= darbe;
        Healthbar.fillAmount = saglik;

    }
    private void healtController()
    {
        if (saglik <= 0)
        {
            Healthbar.enabled = false;
            my_text.enabled = true;

        }
    }


    
    void Update()
    {
        
    }

    //public void CurrentTarget()
    //{
    //    Instantiate(CurrentObstacle, new Vector3(1f,2f,3f), Quaternion.identity);
    //}

     
}
