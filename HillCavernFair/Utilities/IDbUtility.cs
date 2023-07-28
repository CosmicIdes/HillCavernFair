/* This interface is used with DBUtility, and does not have any extra methods that 
 DBUtility does not employ, an example of Interface Segregation Principle.*/

namespace HillCavernFair.Utilities
{
    public interface IDbUtility
	{
        void EnsureDbExists();
    }
}

