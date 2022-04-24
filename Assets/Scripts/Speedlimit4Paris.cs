using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class Speedlimit4Paris : MonoBehaviour
    {
        public float plusscore = 1029f;
        public float minusscore = 1024f;

        public GameObject KVBtext;

        public GameObject TGVEngine1;
        private CinemachineDollyCart3 Path3ForEngine1;

        public GameObject drivingpanel;
        private GameScore ScoreBySpeedLimit;

        // Start is called before the first frame update
        void Start()
        {
            TGVEngine1 = GameObject.Find("TGV");
            Path3ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart3>();
            
            ScoreBySpeedLimit = drivingpanel.GetComponent<GameScore>();
        }
    
        private void OnTriggerStay(Collider other)
        {

            if (Path3ForEngine1.m_Speed <= 5)
            {
                ScoreBySpeedLimit.SetScoreText(plusscore);
                Debug.Log("To Paris!");
            }
            else
            {
                ScoreBySpeedLimit.SetScoreText(minusscore);
            }

             KVBtext.GetComponent<Text>().text = "";
        }
    }
}
