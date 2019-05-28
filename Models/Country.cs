using System.Collections.Generic;

namespace BookApiProject.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // the navigational properties are better to be virutal; This allows Entity Framework to override a property and create a
        // so-called proxy class at runtime and that allows for so-called lazy loading; This allows Entity Framework to avoid loading the
        // complete tree of dependent objects that are actually not needed sometimes.
        public virtual ICollection<Author> Authors { get; set; }
    }
}