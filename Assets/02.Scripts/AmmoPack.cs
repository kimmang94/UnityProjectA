using Photon.Pun;
using UnityEngine;

public class AmmoPack : MonoBehaviourPun, IItem
{
    public int ammo = 30;

    // target에 탄알을 추가하는 처리
    public void Use(GameObject target)
    {
        // 전달받은 게임 오브젝트로부터 PlayerShooter 컴포넌트 
        // 가져오기 시도
        PlayerShooter playerShooter = target.GetComponent<PlayerShooter>();

        // PlayerShooter 컴포넌트가 있으면서
        // 총 오브젝트가 존재하면
        if(playerShooter != null && playerShooter.gun != null)
        {
            // 총의 남은 탄알 수를 ammo 만큼 더하기. + 모든 클라이언트에서 실행
            //playerShooter.gun.ammoRemain += ammo;
            playerShooter.gun.photonView.RPC("AddAmmo", RpcTarget.All, ammo);
        }

        // 사용되었으므로 자신을 파괴 -> 모든 클라이언트에서 자신 파괴
        PhotonNetwork.Destroy(gameObject);
    }
}
