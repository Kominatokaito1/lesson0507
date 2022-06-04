using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BMSYS
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField]
        private int index;
        [SerializeField]
        private int count;
        [SerializeField]
        private float ballSpeed = 30;
        [SerializeField]
        private Rigidbody rigidBody;
        // Start is called before the first frame update
        void Start()
        {
            Init();
        }

        private void Awake()
        {
            //rigidBody = 
        }
        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                rigidBody.velocity = Vector3.up * 30;
            }
        }

        public void Init()
        {
            Debug.Log($"index = {index}");
        }
    }
}
