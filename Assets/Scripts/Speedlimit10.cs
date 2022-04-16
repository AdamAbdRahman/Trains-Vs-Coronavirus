using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class Speedlimit10 : MonoBehaviour
    {
        private float plusscore = 200f;
        private float minusscore = 1f;

        public GameObject TGVtrain;
        private CinemachineDollyCart cinemachinedollycart;
        private CinemachineDollyCart1 cinemachinedollycart1;

        public GameObject drivingpanel;
        private GameScore ScoreBySpeedLimit;

        // Start is called before the first frame update
        void Start()
        {
            TGVtrain = GameObject.Find("TGV");
            cinemachinedollycart = TGVtrain.GetComponent<CinemachineDollyCart>();
            cinemachinedollycart1 = TGVtrain.GetComponent<CinemachineDollyCart1>();

            drivingpanel = GameObject.Find("Canvas");
            ScoreBySpeedLimit = drivingpanel.GetComponent<GameScore>();

        }

        private void OnTriggerEnter(Collider other)
        {

            if (cinemachinedollycart.m_Speed <= 5)
            {
                ScoreBySpeedLimit.SetScoreText(plusscore);
            }
            else
            {
                ScoreBySpeedLimit.SetScoreText(minusscore);
            }

            if (cinemachinedollycart1.m_Speed <= 5)
            {
                ScoreBySpeedLimit.SetScoreText(plusscore);
                Debug.Log("sucess");
            }
            else
            {
                ScoreBySpeedLimit.SetScoreText(minusscore);
                Debug.Log("not sucess");
            }
        }
    }
}
