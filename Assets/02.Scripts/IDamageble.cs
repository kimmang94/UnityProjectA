using UnityEngine;

public interface IDamageble
{
    void OnDamage(float damage, Vector3 hitPoint, Vector3 hitNormal);
}
