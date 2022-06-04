using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.Sunil.PhotonGame
{
    public class Capsule : MonoBehaviour
    {

        // Start is called before the first frame update


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                this.gameObject.SetActive(false);
                Invoke("GameObjectSetActiveFalse", 10f);
            }


        }


        void GameObjectSetActiveFalse()
        {
            this.gameObject.SetActive(true);
        }
    }
}