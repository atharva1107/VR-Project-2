using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialRandomizer : MonoBehaviour
{
    public GameObject other;
    private void Start()
    {
        Texture2D[] textures = Resources.LoadAll<Texture2D>("skins");

        Texture2D texture = textures[Random.Range(0, textures.Length)];
        other.GetComponent<MeshRenderer>().sharedMaterial.mainTexture = texture;
    }
}


