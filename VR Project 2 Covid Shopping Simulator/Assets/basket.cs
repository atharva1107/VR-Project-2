using UnityEngine;
using System.Collections;
using System.Collections.Generic; // need this to use list

public class basket : MonoBehaviour
{


    private List<string> boughtList = new List<string>();
    private void OnDisable()//clears when the game or scene ends i think
    {
        /* just for checking if contents of the list are being added correctly
        for(int i =0; i< boughtList.Count; i++)
        {
            Debug.Log(boughtList[i]);
        }
        */
        boughtList.Clear();


    }
    private void OnTriggerEnter(Collider other) //when the object enters the trigger collider
    {

       
        //if using a list of gameObject mesh name so if box.fbx -> box is used
        var meshFilter = other.gameObject.GetComponent<MeshFilter>();
        var mesh = meshFilter.sharedMesh;
        boughtList.Add(mesh.name);
    }

    private void OnTriggerExit(Collider other)//same as above, but exiting
    {




        //despawns the object
        if (other != null)
        {
            Destroy(other.gameObject.GetComponent<MeshRenderer>());
        }

       

    }
}