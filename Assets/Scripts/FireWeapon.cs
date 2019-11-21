using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FIRETYPE { REPEATER, SEMIAUTOMATIC, AUTOMATIC}
public class FireWeapon : MonoBehaviour
{
    
    [System.Serializable]
    public struct FireWeaponData
    {
        public FIRETYPE firetype;
        public float power;
        public float recoil;
        public float fireRate;
        public float range;
        public int magazineCapacity;
        [Range(0, 1f)]
        public float muzzleFireFrequency;
        public int currentAmmo { get; set; }

        public FireWeaponData(FIRETYPE firetype, float power, float recoil, float fireRate, float range, int magazineCapacity, float muzzleFireFrequency)
        {
            this.firetype = firetype;
            this.power = power;
            this.recoil = recoil;
            this.fireRate = fireRate;
            this.range = range;
            this.magazineCapacity = magazineCapacity;
            this.muzzleFireFrequency = muzzleFireFrequency;
            currentAmmo = magazineCapacity;
        }
    }

    [System.Serializable]
    public struct FireWeaponFXData
    {
        public ParticleSystem weaponFireParticles;
        public Light weaponFireLight;
        public AudioClip reloadSound;
        public AudioClip shootSound;
        public AudioClip emptySound;

        public FireWeaponFXData(ParticleSystem weaponFireParticles, Light weaponFireLight, AudioClip reloadSound, AudioClip shootSound, AudioClip emptySound)
        {
            this.weaponFireParticles = weaponFireParticles;
            this.weaponFireLight = weaponFireLight;
            this.reloadSound = reloadSound;
            this.shootSound = shootSound;
            this.emptySound = emptySound;
        }
    }

    public FireWeaponData gunData = new FireWeaponData(FIRETYPE.AUTOMATIC, 10f, 0.1f, 200f, 700f, 30, 0.7f);
    public FireWeaponFXData gunFX = new FireWeaponFXData();
    public Camera fpsCamera;
    public LayerMask impactMask; //Layers affected by player's shots
    public GameObject bulletHole;
    public bool isReloading { get; private set; }

    private RaycastHit hit;
    private Ray ray;
    private Recoiler gunRecoiler;
    private Recoiler camRecoiler;
    private AudioSource audioSource;
    private float firingTimer;

    private void Start()
    {
        //Recoiler components references from gun and camera
        gunRecoiler = GetComponentInParent<Recoiler>();
        camRecoiler = fpsCamera.GetComponentInParent<Recoiler>();

        //Start with full clip
        gunData.currentAmmo = gunData.magazineCapacity;
        GameObject.Find("AmmoText").GetComponent<UnityEngine.UI.Text>().text = gunData.currentAmmo + "/" + gunData.magazineCapacity;

        audioSource = GetComponent<AudioSource>();

        //If there is no audioSource component in the gameObject, add one.
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    private void Update()
    {
        if(gunFX.weaponFireLight != null)
        {
            gunFX.weaponFireLight.enabled = gunFX.weaponFireParticles.isPlaying;
        }
    }

    private void playFX()
    {
        if(gunFX.weaponFireParticles != null)
        {
            gunFX.weaponFireParticles.transform.parent.Rotate(0f, 0f, Random.Range(0f, 360f));
            gunFX.weaponFireParticles.Play(true);
        }
    }

    public void shoot(bool fireInput)
    {
        if(Time.time >= firingTimer && fireInput && !isReloading)
        {
            //Calculate the next shoot time
            firingTimer = Time.time + 60 / gunData.fireRate;

            //No bullets in the magazine
            if(gunData.currentAmmo == 0)
            {
                audioSource.PlayOneShot(gunFX.emptySound);
                firingTimer += gunFX.emptySound.length;
                return;
            }

            //Decrease current ammo by one
            gunData.currentAmmo--;
            GameObject.Find("AmmoText").GetComponent<UnityEngine.UI.Text>().text = gunData.currentAmmo + "/" + gunData.magazineCapacity;

            //Apply recoiling based on the equipped gun
            gunRecoiler.recoil += gunData.recoil;
            camRecoiler.recoil += gunData.recoil;

            //Play shoot sound and FX
            audioSource.PlayOneShot(gunFX.shootSound);

            if (Random.Range(0, 100) < gunData.muzzleFireFrequency * 100) playFX(); 

            //Calculate the middle point of the screen
            Vector2 screenCenterPoint = new Vector2(Screen.width / 2, Screen.height / 2);

            //Raycasting from the camera
            ray = fpsCamera.ScreenPointToRay(screenCenterPoint);

            if(Physics.Raycast(ray, out hit, gunData.range, impactMask))
            {
                //Variable to hold the position of the prefab
                //The contact point with the model is given by hit.point
                Vector3 bulletHolePosition = hit.point + hit.normal * 0.01f;

                //We need a variable to hold the rotation of the prefab
                //The new rotation will be matched between the vector forward and the hit normal
                Quaternion bulletHoleRotation = Quaternion.FromToRotation(Vector3.forward, hit.normal);
                GameObject hole = Instantiate(bulletHole, bulletHolePosition, bulletHoleRotation);
            }
        }
    }

    private IEnumerator reload()
    {
        isReloading = true;
        
        audioSource.PlayOneShot(gunFX.reloadSound);
        yield return new WaitForSeconds(gunFX.reloadSound.length);
        
        gunData.currentAmmo = gunData.magazineCapacity;
        GameObject.Find("AmmoText").GetComponent<UnityEngine.UI.Text>().text = gunData.currentAmmo + "/" + gunData.magazineCapacity;

        isReloading = false;
    }

    public void OnReloadButtonDown()
    {
        if(isReloading == false && gunData.currentAmmo < gunData.magazineCapacity)
        {
            StartCoroutine(reload());
        }
    }
}
