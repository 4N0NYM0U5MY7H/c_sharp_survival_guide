using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDataBase : MonoBehaviour
{
    /// <summary>
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
    /// </summary>

    Customer jonathan;
    Customer jannet;
    Customer jessica;
    Customer eric;

    // Start is called before the first frame update
    void Start()
    {
        jonathan = new Customer("Jonathan", "Wienberger", 26, "M", "Software Engineer");
        jannet = new Customer("Jannet", "", 55, "F", "Instructor");
        jessica = new Customer("Jessica", "Lang", 23, "F", "Scientist");
    }
}
