using System;
namespace SpinningDiscs
{
    public class DVD : StorageDisk
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        

        public DVD(string name) : base( name)
        {
            Capacity = 4700;
            Speed = 16;
        }
    }
}
