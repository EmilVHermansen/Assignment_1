using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    //[SerializeField] GameObject FloatingTextPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void PrintText()
	{
        //Instantiate(FloatingTextPrefab, new Vector3(0, 0, 0), Quaternion.identity).SetActive(true);
        Debug.Log("Wauw you pressed a button! Good job =)");
        print("Wauw you pressed a button! Good job =)");
	}
}
