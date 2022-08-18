using UnityEngine;

namespace Su
{   /// <summary>
    /// �Ǫ����
    /// </summary>
    public class Monster : MonoBehaviour
    {
        #region �����T
        [SerializeField, Header("���ʳt��"), Range(0, 10), Tooltip("���ʳt��")]
        private float movespeed = 3.5f;
        [SerializeField, Tooltip("�����O"), Range(0, 500)]
        private int attack = 100;
        [SerializeField, Tooltip("��q"), Range(0, 5000)]
        private int hp = 350;
        [SerializeField, Tooltip("�l�ܽd��"), Range(0, 50)]
        private int trackingrange = 30;
        [SerializeField, Tooltip("�l�ܦ첾")]
        private Vector3 trackdisplacement;
        #endregion

        #region �����D��
        [SerializeField, Header("�����D��")]
        private GameObject dropprops;
        [SerializeField, Tooltip("�������v"), Range(0, 1)]
        private float dropchance = 1;
        #endregion

        #region ����
        [SerializeField, Header("�����D�㭵��")]
        private AudioClip dropaudio;
        [SerializeField, Tooltip("���˭���")]
        private AudioClip hurtaudio;
        [SerializeField, Tooltip("��������")]
        private AudioClip attackaudio;
        #endregion

        #region ����
        private AudioSource ads;//���Ĩӷ� 
        private Rigidbody2D rig;//2D ����
        private Animator ani;//�ʵe���
        #endregion
    }
}


