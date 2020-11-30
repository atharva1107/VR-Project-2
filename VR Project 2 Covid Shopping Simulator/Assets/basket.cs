using UnityEngine;
using System.Collections;
using System.Collections.Generic; // need this to use list

public class basket : MonoBehaviour
{
    [SerializeField] public AudioSource audio;
    private List<string> boughtList = new List<string>();
    list l = new list();
    List<string> checklist;
    checklist = l.GenerateList();

    private void OnDisable()//clears when the game or scene ends i think
    {
     
        boughtList.Clear();

    }
    private void OnTriggerEnter(Collider other) //when the object enters the trigger collider
    {

        if (other != null)
        {
            //if using a list of gameObject mesh name is added to the list so if box.fbx -> box is used
            var meshFilter = other.gameObject.GetComponent<MeshFilter>();
            var mesh = meshFilter.sharedMesh;

            if (!boughtList.Contains(mesh.name))
            {
                boughtList.Add(mesh.name);
                checklist.Remove(mesh.name);
                audio.Play();

            }

            Destroy(other.gameObject.GetComponent<MeshRenderer>());

        }

    }

    private void OnTriggerExit(Collider other)//same as above, but exiting
    {

    }

}
