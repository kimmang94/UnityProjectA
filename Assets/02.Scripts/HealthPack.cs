using Photon.Pun;
using UnityEngine;

public class HealthPack : MonoBehaviourPun, IItem
{
    public float health = 50;

    public void Use(GameObject target)
    {
        // 전달받은 게임 오브젝트로부터 LivingEntity 컴포넌트
        // 가져오기 시도
        LivingEntity life = target.GetComponent<LivingEntity>();

        // LivingEntity 컴포넌트가 있다면
        if(life != null)
        {
            // 체력 회복 실행
            life.RestoreHealth(health);
        }

        // 사용되었으므로 자신을 파괴 -> 모든 클라이언트에서 자신 파괴
        // Destroy(gameObject);
        PhotonNetwork.Destroy(gameObject);
    }
}
