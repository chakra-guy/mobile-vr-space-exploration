// 2017 Riccardo E. Giorato - giorat
using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Collider))]
public class Teleport : MonoBehaviour {

    public GameObject camera;
    public float playerHeight = 5f;
    private AudioSource teleportSound;

    private VReyecaster cameraEyeCast;

    void Start() {
        cameraEyeCast = camera.GetComponent<VReyecaster>();
        teleportSound = GetComponent<AudioSource>();
    }

    public void Recenter() {
        #if !UNITY_EDITOR
            GvrCardboardHelpers.Recenter();
        #else
            GvrEditorEmulator emulator = FindObjectOfType<GvrEditorEmulator>();
            if (emulator == null)
            {
                return;
            }
            emulator.Recenter();
        #endif  // !UNITY_EDITOR
    }

    public void TeleportRandomly() {
        Debug.Log("click");
        teleportSound.Play(0);
        transform.position = cameraEyeCast.hitPoint();
        transform.position = new Vector3(transform.position.x, transform.position.y + playerHeight, transform.position.z);
    }
}
