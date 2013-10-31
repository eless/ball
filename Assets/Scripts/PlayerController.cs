using UnityEngine;

public sealed class PlayerController : MonoBehaviour
{
  
  [SerializeField] private float acceleration = 15f;

 
 

   void Update()
  {
   
     
  }

  private void FixedUpdate()
  {
    var direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    rigidbody.AddForce(direction * acceleration);
    if (Input.GetButton("Jump"))
    {
      var big = Physics.OverlapSphere(transform.position, 2.1f);
      var small = Physics.OverlapSphere(transform.position, 0.6f);
      foreach (var body in big)
      {
        if (System.Array.IndexOf(small, body) == -1 && body.tag == "Box")
          body.rigidbody.AddForce((transform.position - body.transform.position) * 20);
      }
    }
  }

}
