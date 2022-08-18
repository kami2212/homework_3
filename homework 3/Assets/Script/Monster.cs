using UnityEngine;

namespace Su
{   /// <summary>
    /// 怪物欄位
    /// </summary>
    public class Monster : MonoBehaviour
    {
        #region 角色資訊
        [SerializeField, Header("移動速度"), Range(0, 10), Tooltip("移動速度")]
        private float movespeed = 3.5f;
        [SerializeField, Tooltip("攻擊力"), Range(0, 500)]
        private int attack = 100;
        [SerializeField, Tooltip("血量"), Range(0, 5000)]
        private int hp = 350;
        [SerializeField, Tooltip("追蹤範圍"), Range(0, 50)]
        private int trackingrange = 30;
        [SerializeField, Tooltip("追蹤位移")]
        private Vector3 trackdisplacement;
        #endregion

        #region 掉落道具
        [SerializeField, Header("掉落道具")]
        private GameObject dropprops;
        [SerializeField, Tooltip("掉落機率"), Range(0, 1)]
        private float dropchance = 1;
        #endregion

        #region 音效
        [SerializeField, Header("掉落道具音效")]
        private AudioClip dropaudio;
        [SerializeField, Tooltip("受傷音效")]
        private AudioClip hurtaudio;
        [SerializeField, Tooltip("攻擊音效")]
        private AudioClip attackaudio;
        #endregion

        #region 元件
        private AudioSource ads;//音效來源 
        private Rigidbody2D rig;//2D 剛體
        private Animator ani;//動畫控制器
        #endregion
    }
}


