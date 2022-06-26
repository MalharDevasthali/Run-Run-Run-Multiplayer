using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Commons
{
    public class GenericSinglton<T> : MonoBehaviour where T : GenericSinglton<T>
    {

        public static GenericSinglton<T> instance;
        private void Awake()
        {
            if(instance == null)
            {
                Destroy(this.gameObject);
                Debug.LogError("You are trying to create a singleton which is already present in project");
            }
            else
            {
                instance = this;
            }
        }

    }
}