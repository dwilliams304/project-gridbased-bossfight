using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Vector2 moveVector;
    private InputAction moveAction;

    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private float _moveSpeedModifier = 1f;
    [SerializeField] private Transform _movePoint;

    [SerializeField] private LayerMask _bounds;

    // Start is called before the first frame update
    void Start()
    {
        _movePoint.parent = null;
        moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        moveVector = moveAction.ReadValue<Vector2>();
        transform.position = Vector3.MoveTowards(transform.position, _movePoint.position, _moveSpeed * _moveSpeedModifier * Time.deltaTime);

        Move();
    }

    private void Move()
    {
        if(Vector3.Distance(transform.position, _movePoint.position) <= 0.0f){ //are at the same position as our movepoint?
            Vector3 movePosition;

            if(Mathf.Abs(moveVector.x) == 1f){ //if our x-axis movement input == +/- 1, try to move
                movePosition = new Vector3(moveVector.x, 0f, 0f); //create desired moveposition
                if (!Physics2D.OverlapCircle(_movePoint.position + movePosition, .2f, _bounds)) //check to make sure we are not hitting world bounds
                {
                    _movePoint.position += movePosition;
                }
            }
            else if(Mathf.Abs(moveVector.y) == 1f){ //do the same with the y-axis input/movement
                movePosition = new Vector3(0f, moveVector.y, 0f);
                if (!Physics2D.OverlapCircle(_movePoint.position + movePosition, .2f, _bounds))
                {
                    _movePoint.position += movePosition;
                }
            }
        }
    }
}
