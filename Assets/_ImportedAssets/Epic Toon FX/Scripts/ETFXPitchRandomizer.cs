using UnityEngine;

namespace _ImportedAssets.Epic_Toon_FX.Scripts
{

	public class ETFXPitchRandomizer : MonoBehaviour
	{
	
		public float randomPercent = 10;
	
		void Start ()
		{
        transform.GetComponent<AudioSource>().pitch *= 1 + Random.Range(-randomPercent / 100, randomPercent / 100);
		}
	}
}