using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private float _moveSpeedModifier = 1f;
    [SerializeField] private Transform _movePoint;

    [SerializeField] private LayerMask _bounds;

    // Start is called before the first frame update
    void Start()
    {
        _movePoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _movePoint.position, _moveSpeed * _moveSpeedModifier * Time.deltaTime);

        if(Vector3.Distance(transform.position, _movePoint.position) <= 0.0f){
            if(Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f){
                if (!Physics2D.OverlapCircle(_movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .2f, _bounds))
                {
                    _movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                }
            }
            else if(Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f){
                if (!Physics2D.OverlapCircle(_movePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .2f, _bounds))
                {
                    _movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                }
            }
        }
    }
}
