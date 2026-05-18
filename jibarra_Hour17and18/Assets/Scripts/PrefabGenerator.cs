using UnityEngine;

public class PrefabGenerator : MonoBehaviour
/* Hi professor Chao, I tried a few different things, and I still can't 
figure it out :(
I tried going to tutoring today (5/4), which is why the assignment is late. 
But no one showed up to tutoring. I will turn it in as-is, and take my lumps!
Thank you! */
{
	public GameObject Streetlight;
	public float spacing = 3f;

	void Start()
	{
		for (int i = 0; i < 10; i++)
			{
				Vector3 spawnPosition = new Vector3(i * spacing, 0f, 0f);
				Instantiate(Streetlight, spawnPosition, Quaternion.identity);
			}
	}
	void Update()
	{	
		if (Input.GetKeyDown(KeyCode.B))
		{
			Instantiate(Streetlight);
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(Streetlight, transform.position, transform.rotation);
		}
	}
}