using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    
    // Install VS Code Snippets Extension to get Autocomplete for this function.
    private void OnCollisionEnter(Collision other) {
        hits++;
        Debug.Log("You've bumped into a thing " + hits + " times");
    }
}
