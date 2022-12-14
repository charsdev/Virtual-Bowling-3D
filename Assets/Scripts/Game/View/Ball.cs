using UnityEngine;

namespace Game
{
    public class Ball : MonoBehaviour
    {
        private Vector3 _ballStartPos;
        private Rigidbody _rigidBody;
        public float Power;
        private float moveSpeed = 5f;

        void Start()
        {
            _rigidBody = GetComponent<Rigidbody>();
            _rigidBody.useGravity = false;
            _ballStartPos = transform.position;
        }

        public void MoveToDirection(Vector3 direction)
        {
            _rigidBody.position += (moveSpeed * Time.deltaTime * direction);
        }

        public void Launch()
        {
            _rigidBody.useGravity = true;
            Power = Random.Range(60, 80);
            _rigidBody.velocity = Vector3.forward * Power;
        }

        public void Reset()
        {
            transform.position = _ballStartPos;
            transform.rotation = Quaternion.identity;
            _rigidBody.velocity = Vector3.zero;
            _rigidBody.angularVelocity = Vector3.zero;
            _rigidBody.useGravity = false;
        }
    }
}