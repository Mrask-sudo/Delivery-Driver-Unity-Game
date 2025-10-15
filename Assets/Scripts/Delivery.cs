using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);
    bool hasPackage;
    [SerializeField] float destroyDelay;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up!!!");
            Destroy(other.gameObject, destroyDelay);
            spriteRenderer.color = hasPackageColor;
            hasPackage = true;
        }
        else if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package Delivered!!!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
