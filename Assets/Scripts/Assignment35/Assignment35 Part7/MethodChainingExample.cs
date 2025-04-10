using UnityEngine;
namespace Assignment357
{
    public class MethodChainingExample : MonoBehaviour
    {
        class Mathcube
        {
            public GameObject cube = GameObject.Find("Cube");

            //Updates the GameObject’s position.
            public Mathcube SetPosition(Vector3 position)
            {
                cube.transform.position = position;
                return this;
            }
            
            //Updates the GameObject’s rotation.
            public Mathcube SetRotation(Vector3 rotation)
            {
                cube.transform.rotation = Quaternion.Euler(rotation);
                return this;
            }
            
            //Updates the GameObject’s scale.
            public Mathcube SetScale(Vector3 scale)
            {
                cube.transform.localScale = scale;
                return this;
            }
        }

        //In the Start method, chain the methods together to set the position, rotation, and scale
        // of the current gameObject. Call the methods one after the other in a single chain:
        void Start()
        {
            Mathcube mathcube = new Mathcube();
            mathcube.SetPosition(new Vector3(0, 1, 0)).SetRotation(new Vector3(45, 0, 0)).SetScale(new Vector3(2, 2, 2));
        }
    }
}
