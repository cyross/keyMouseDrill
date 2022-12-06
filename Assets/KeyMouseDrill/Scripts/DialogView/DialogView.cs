using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace KeyMouDrill
{
    public class DialogView : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnClickCloseButton()
        {
            this.gameObject.SetActive(false);
        }
    }
}
