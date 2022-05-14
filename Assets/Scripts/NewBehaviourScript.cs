using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BMSYS
{
    public class NewBehaviourScript : MonoBehaviour
    {

        private int index;

        // Start is called before the first frame update
        void Start()
        {
            Init();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Init()
        {
            Debug.Log($"index = {index}");
        }
    }
}
