using UnityEngine;

namespace Section.Classes.Challenge01
{
    public class CustomerDatabase : MonoBehaviour
    {
        /// Challenge Overview:
        /// Create a program which adds "Customers" to a database.
        /// Assume the database needs customer information.
        ///
        /// Create at least 3 customers via code using a constructor.
        /// Should also be able to add customers through the inspector.
        ///
        /// Customer Traits:
        ///     first name
        ///     last name
        ///     age
        ///     gender
        ///     occupation
        /// 

        Customer sarah;
        Customer kelly;
        Customer john;
        Customer linda;
        [SerializeField]
        Customer[] customers;

        // Start is called before the first frame update
        void Start()
        {
            sarah = new Customer("Sarah", "Palmer", 31, "F", "Spartan Commander");
            kelly = new Customer("Kelly", "Shaddock", 47, "F", "Petty Officer First Class");
            john = new Customer("John", "", 47, "M", "Master Cheif Petty Officer");
        }
    }
}