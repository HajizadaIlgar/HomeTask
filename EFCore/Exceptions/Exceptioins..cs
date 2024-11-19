namespace EFCore.Exceptions
{
    using System;

    public class UserNotFoundException : Exception
    {
        public UserNotFoundException() : base("Bele bir istifadeci tapilmadi")
        {
        }

        public UserNotFoundException(string message) : base(message)
        {
        }
    }

    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException() : base("Bele bir mehsul tapilmadi")
        {
        }

        public ProductNotFoundException(string message) : base(message)
        {
        }
    }


}
