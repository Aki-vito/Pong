     using UnityEngine;
     using System.Collections;
     
     public class Ballmove : MonoBehaviour {
         
         Rigidbody2D myRigidbody;
				 public float speed;
		     Vector2 vecd;
         public float cold;
				 public float seconds;
				 public float maxspeed = 15f;
         public float minspeed = 10f;
				  
         void Start () {

              transform.Translate(Vector3.right * Time.deltaTime);
					    vecd = GetComponent<Rigidbody2D>().velocity = Random.onUnitSphere * 11;
                      

               
             
         }

        void FixedUpdate(){



                   if(GetComponent<Rigidbody2D>().velocity.magnitude > maxspeed)
         {
                GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity.normalized * maxspeed;
         }

                if(GetComponent<Rigidbody2D>().velocity.magnitude < minspeed)
								{
   
                  GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity.normalized * maxspeed;
										


								}
   
				}

         
    




		 }

       
       
     
     
