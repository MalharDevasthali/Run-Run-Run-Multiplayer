using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Commons
{
    public class GenericSinglton<T> : MonoBehaviour where T : GenericSinglton<T>
    {

        private static T Instance;
        public static T instance { get { return Instance; } }
        private void Awake()
        {
            if(Instance == null)
            {
                Instance = (T)this;
            
            }
            else
            {
                Destroy(this.gameObject);
                Debug.LogError(Instance+" singleton is trying to create another instance.");
            }
        }
    }
}