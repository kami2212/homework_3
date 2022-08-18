using UnityEngine;

namespace Su
{
    public class Monster : MonoBehaviour
    {
        [SerializeField,Header("���ʳt��"),Range(0,10)]
        private float movespeed = 3.5f;
        [SerializeField, Tooltip("�����O"), Range(0, 500)]
        private int attack = 100;
        [SerializeField, Tooltip("��q"), Range(0, 5000)]
        private int hp = 350;
        [SerializeField, Tooltip("�l�ܽd��"), Range(0, 50)]
        private int trackingrange = 30;
        [SerializeField, Tooltip("�l�ܽd��")]
        private Vector3 trackdisplacement;

        [SerializeField, Header("�����D��")]
        private GameObject dropprops;
        [SerializeField, Tooltip("�������v"),Range(0,1)]
        private float dropchance = 1;

        [SerializeField, Header("�����D�㭵��")]
        private AudioClip dropaudio;
        [SerializeField, Tooltip("���˭���")]
        private AudioClip hurtaudio;
        [SerializeField, Tooltip("��������")]
        private AudioClip attackaudio;

        private AudioSource ads;
        private Rigidbody2D rig;
        private Animator ani;
    }
}

