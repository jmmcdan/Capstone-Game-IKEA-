using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EInteractableItems : MonoBehaviour
{
        [SerializeField] private bool triggerActive = false;

        public void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                triggerActive = true;
            }
        }

        public void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                triggerActive = false;
            }
        }

        private void Update()
        {
            if (triggerActive && Input.GetKeyDown(KeyCode.E))
            {
                OpenShelfGUI();
            }
        }

        public void OpenShelfGUI()
        {
            Debug.Log("OpenGUI(Haven't made it yet)");
        }
}
