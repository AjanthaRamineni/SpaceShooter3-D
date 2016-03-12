using UnityEngine;
using System.Collections;

public class BestroyByBoundary : MonoBehaviour
{
	void OnTriggerExit(Collider other)
	{
		Destroy(other.gameObject);
	} 

}
