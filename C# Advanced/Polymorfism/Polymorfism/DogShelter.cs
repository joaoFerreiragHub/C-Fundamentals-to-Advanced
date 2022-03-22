using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorfismUdemy
{
    class DogShelter : IEnumerable<Dog>
    {
        //list of type List<Dog>
        public List<Dog> dogs;

        //this constrictor will initialize the dogs list with some values
        public DogShelter()
        {
            //initialize the dogs list using the collection initializer
            dogs = new List<Dog>()
            {
                new Dog("Casper", false),
                new Dog("Sif", true),
                new Dog("Oreo", false),
                new Dog("Pixel", false)

            };
        }

        public IEnumerator<Dog> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
