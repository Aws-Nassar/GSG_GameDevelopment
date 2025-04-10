using UnityEngine;
using UnityEngine.Events;
namespace Assignment356
{
    public class UnityEventExample : MonoBehaviour
    {
        //Declare a public UnityEvent field in your script to hold the custom event.
        public UnityEvent onEventTriggered;
        void Start()
        {
            //Inside the Start method, initialize it.
            onEventTriggered = new UnityEvent();

            //Use the AddListener method to attach a method to the UnityEvent.
            onEventTriggered.AddListener(OnEventResponse.EventListner);
        }
        
        //In the Update() method Use the Invoke method to call the event programmatically,
        // when the Spacebar key is pressed.
        void Update()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                onEventTriggered?.Invoke();
            }
        }
    }
}
