using UnityEngine;

namespace Wormhole
{
    [CreateAssetMenu(fileName = "EnemyType", menuName = "Wormhole/EnemyType", order = 0)]
    public class EnemyType : ScriptableObject
    {
        public GameObject enemyPrefab;
        public GameObject weaponPrefab;
        public float speed = 2f;
    }
}